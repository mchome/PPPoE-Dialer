using System;
using System.Linq;
using System.Windows;
using DotRas;

namespace pppoe_dialer
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MahApps.Metro.Controls.MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            CreateConnect("PPPoEDialer");
            hangup.IsEnabled = false;
        }

        public void CreateConnect(string ConnectName)
        {
            RasDialer dialer = new RasDialer();
            RasPhoneBook book = new RasPhoneBook();
            try
            {
                book.Open(RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.User));
                if (book.Entries.Contains(ConnectName))
                {
                    book.Entries[ConnectName].PhoneNumber = " ";
                    book.Entries[ConnectName].Update();
                }
                else {
                    System.Collections.ObjectModel.ReadOnlyCollection<RasDevice> readOnlyCollection = RasDevice.GetDevices();
                    RasDevice device = RasDevice.GetDevices().Where(o => o.DeviceType == RasDeviceType.PPPoE).First();
                    RasEntry entry = RasEntry.CreateBroadbandEntry(ConnectName, device);
                    entry.PhoneNumber = " ";
                    book.Entries.Add(entry);
                }
            }
            catch (Exception)
            {
                lb_status.Content = "创建PPPoE连接失败";
            }
        }

        private void dial_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                string username = tb_username.Text.Replace("\\r", "\r").Replace("\\n", "\n");
                string password = pb_password.Password.ToString();
                RasDialer dialer = new RasDialer();
                dialer.EntryName = "PPPoEDialer";
                dialer.PhoneNumber = " ";
                dialer.AllowUseStoredCredentials = true;
                dialer.PhoneBookPath = RasPhoneBook.GetPhoneBookPath(RasPhoneBookType.User);
                dialer.Credentials = new System.Net.NetworkCredential(username, password);
                dialer.Timeout = 500;
                RasHandle myras = dialer.Dial();
                while (myras.IsInvalid)
                {
                    lb_status.Content = "拨号失败";
                }
                if (!myras.IsInvalid)
                {
                    lb_status.Content = "拨号成功! ";
                    RasConnection conn = RasConnection.GetActiveConnectionByHandle(myras);
                    RasIPInfo ipaddr = (RasIPInfo)conn.GetProjectionInfo(RasProjectionType.IP);
                    lb_message.Content = "获得IP： " + ipaddr.IPAddress.ToString();
                    dial.IsEnabled = false;
                    hangup.IsEnabled = true;
                }
            }
            catch (Exception)
            {
                lb_status.Content = "拨号出现异常";
            }
        }

        private void hangup_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                System.Collections.ObjectModel.ReadOnlyCollection<RasConnection> conList = RasConnection.GetActiveConnections();
                foreach (RasConnection con in conList)
                {
                    con.HangUp();
                }
                System.Threading.Thread.Sleep(1000);
                lb_status.Content = "注销成功";
                lb_message.Content = "已注销";
                dial.IsEnabled = true;
                hangup.IsEnabled = false;
            }
            catch (Exception)
            {
                lb_status.Content = "注销出现异常";
            }
        }

        private void FollowMe(object sender, System.Windows.Navigation.RequestNavigateEventArgs e)
        {
            System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(e.Uri.AbsoluteUri));
            e.Handled = true;
        }
    }
}
