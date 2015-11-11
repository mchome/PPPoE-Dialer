/*
 * 用户： fuyumi
 * 日期: 2015/10/25 星期日
 * 时间: 下午 9:07
 */
 
using System;
using System.Collections.ObjectModel;
using System.Linq;
using System.Net;
using System.Threading;
using System.Windows.Forms;
using DotRas;

namespace pppoe_dialer
{
	public partial class MainForm : Form
	{
		public MainForm()
		{
			InitializeComponent();
			CreateConnect("PPPoEDial");
			btn_Hungup.Enabled = false;
		}
				
		public void CreateConnect(string ConnectName)
		{
			RasDialer dialer = new RasDialer();
			RasPhoneBook book = new RasPhoneBook();
			try {
				book.Open(RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.User));
				if (book.Entries.Contains(ConnectName)) {
					book.Entries[ConnectName].PhoneNumber = " ";
					book.Entries[ConnectName].Update();
				} else {
					ReadOnlyCollection<RasDevice> readOnlyCollection = RasDevice.GetDevices();
					RasDevice device = RasDevice.GetDevices().Where(o => o.DeviceType == RasDeviceType.PPPoE).First();
					RasEntry entry = RasEntry.CreateBroadbandEntry(ConnectName, device);
					entry.PhoneNumber = " ";
					book.Entries.Add(entry);
				}
			} catch (Exception) {
				lb_Status.Text = "创建PPPoE连接失败";
			}
		}
		
		void Btn_DialupClick(object sender, EventArgs e)
		{
			try {
				string username = Username.Text.Replace("\\r","\r").Replace("\\n","\n");
				string password = Password.Text.ToString();
				RasDialer dialer = new RasDialer();
				dialer.EntryName = "PPPoEDial";
				dialer.PhoneNumber = " ";
				dialer.AllowUseStoredCredentials = true;
				dialer.PhoneBookPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.User);
				dialer.Credentials = new NetworkCredential(username, password);
				dialer.Timeout = 1000;
				RasHandle myras = dialer.Dial();
				while (myras.IsInvalid) {
					lb_Status.Text = "拨号失败";
				}
				if (!myras.IsInvalid) {
					lb_Status.Text = "拨号成功! ";
					RasConnection conn = RasConnection.GetActiveConnectionByHandle(myras);
					RasIPInfo ipaddr = (RasIPInfo)conn.GetProjectionInfo(RasProjectionType.IP);
					lb_IPAddr.Text = "获得IP： " + ipaddr.IPAddress.ToString();
					btn_Dialup.Enabled = false;
					btn_Hungup.Enabled = true;
				}
			} catch (Exception) {
				lb_Status.Text = "拨号出现异常";
			}
		}
		
		void Btn_HungupClick(object sender, EventArgs e)
		{
			try {
				ReadOnlyCollection<RasConnection> conList = RasConnection.GetActiveConnections();
				foreach (RasConnection con in conList) {
					con.HangUp();
				}
				Thread.Sleep(1000);
				lb_Status.Text = "注销成功";
				lb_IPAddr.Text = "已注销";
				btn_Dialup.Enabled = true;
				btn_Hungup.Enabled = false;
			} catch (Exception) {
				lb_Status.Text = "注销出现异常";
			}
		}
	}
}
