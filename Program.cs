/*
 * 用户： fuyumi
 * 日期: 2015/10/25 星期日
 * 时间: 下午 9:07
 */
 
using System;
using System.Windows.Forms;

namespace pppoe_dialer
{
	/// <summary>
	/// Class with program entry point.
	/// </summary>
	internal sealed class Program
	{
		/// <summary>
		/// Program entry point.
		/// </summary>
		[STAThread]
		private static void Main(string[] args)
		{
			Application.EnableVisualStyles();
			Application.SetCompatibleTextRenderingDefault(false);
			Application.Run(new MainForm());
		}
		
	}
}
