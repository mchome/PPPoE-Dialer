/*
 * 由SharpDevelop创建。
 * 用户： master
 * 日期: 2015/10/25 星期日
 * 时间: 下午 9:07
 * 
 * 要改变这种模板请点击 工具|选项|代码编写|编辑标准头文件
 */
namespace pppoe_dialer
{
	partial class MainForm
	{
		/// <summary>
		/// Designer variable used to keep track of non-visual components.
		/// </summary>
		private System.ComponentModel.IContainer components = null;
		private System.Windows.Forms.Button btn_Dialup;
		private System.Windows.Forms.Button btn_Hungup;
		private System.Windows.Forms.Label lb_User;
		private System.Windows.Forms.TextBox Username;
		private System.Windows.Forms.Label lb_Pass;
		private System.Windows.Forms.TextBox Password;
		private System.Windows.Forms.StatusStrip Statusbar;
		private System.Windows.Forms.Label lb_IPAddr;
		private System.Windows.Forms.ToolStripStatusLabel lb_Status;
		
		/// <summary>
		/// Disposes resources used by the form.
		/// </summary>
		/// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		protected override void Dispose(bool disposing)
		{
			if (disposing) {
				if (components != null) {
					components.Dispose();
				}
			}
			base.Dispose(disposing);
		}
		
		/// <summary>
		/// This method is required for Windows Forms designer support.
		/// Do not change the method contents inside the source code editor. The Forms designer might
		/// not be able to load this method if it was changed manually.
		/// </summary>
		private void InitializeComponent()
		{
			this.btn_Dialup = new System.Windows.Forms.Button();
			this.btn_Hungup = new System.Windows.Forms.Button();
			this.lb_User = new System.Windows.Forms.Label();
			this.Username = new System.Windows.Forms.TextBox();
			this.lb_Pass = new System.Windows.Forms.Label();
			this.Password = new System.Windows.Forms.TextBox();
			this.Statusbar = new System.Windows.Forms.StatusStrip();
			this.lb_Status = new System.Windows.Forms.ToolStripStatusLabel();
			this.lb_IPAddr = new System.Windows.Forms.Label();
			this.Statusbar.SuspendLayout();
			this.SuspendLayout();
			// 
			// btn_Dialup
			// 
			this.btn_Dialup.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_Dialup.Location = new System.Drawing.Point(29, 189);
			this.btn_Dialup.Name = "btn_Dialup";
			this.btn_Dialup.Size = new System.Drawing.Size(75, 23);
			this.btn_Dialup.TabIndex = 0;
			this.btn_Dialup.Text = "拨号";
			this.btn_Dialup.UseVisualStyleBackColor = true;
			this.btn_Dialup.Click += new System.EventHandler(this.Btn_DialupClick);
			// 
			// btn_Hungup
			// 
			this.btn_Hungup.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.btn_Hungup.Location = new System.Drawing.Point(167, 189);
			this.btn_Hungup.Name = "btn_Hungup";
			this.btn_Hungup.Size = new System.Drawing.Size(75, 23);
			this.btn_Hungup.TabIndex = 1;
			this.btn_Hungup.Text = "注销";
			this.btn_Hungup.UseVisualStyleBackColor = true;
			this.btn_Hungup.Click += new System.EventHandler(this.Btn_HungupClick);
			// 
			// lb_User
			// 
			this.lb_User.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_User.Location = new System.Drawing.Point(29, 32);
			this.lb_User.Name = "lb_User";
			this.lb_User.Size = new System.Drawing.Size(45, 21);
			this.lb_User.TabIndex = 2;
			this.lb_User.Text = "账号：";
			// 
			// Username
			// 
			this.Username.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Username.Location = new System.Drawing.Point(80, 29);
			this.Username.Name = "Username";
			this.Username.Size = new System.Drawing.Size(162, 23);
			this.Username.TabIndex = 3;
			// 
			// lb_Pass
			// 
			this.lb_Pass.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_Pass.Location = new System.Drawing.Point(29, 68);
			this.lb_Pass.Name = "lb_Pass";
			this.lb_Pass.Size = new System.Drawing.Size(45, 18);
			this.lb_Pass.TabIndex = 4;
			this.lb_Pass.Text = "密码：";
			// 
			// Password
			// 
			this.Password.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.Password.Location = new System.Drawing.Point(80, 65);
			this.Password.Name = "Password";
			this.Password.Size = new System.Drawing.Size(162, 23);
			this.Password.TabIndex = 5;
			// 
			// Statusbar
			// 
			this.Statusbar.Font = new System.Drawing.Font("微软雅黑", 9F);
			this.Statusbar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
			this.lb_Status});
			this.Statusbar.Location = new System.Drawing.Point(0, 232);
			this.Statusbar.Name = "Statusbar";
			this.Statusbar.Size = new System.Drawing.Size(270, 22);
			this.Statusbar.TabIndex = 6;
			this.Statusbar.Text = "statusStrip1";
			// 
			// lb_Status
			// 
			this.lb_Status.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_Status.Name = "lb_Status";
			this.lb_Status.Size = new System.Drawing.Size(0, 17);
			// 
			// lb_IPAddr
			// 
			this.lb_IPAddr.Font = new System.Drawing.Font("微软雅黑", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
			this.lb_IPAddr.Location = new System.Drawing.Point(29, 122);
			this.lb_IPAddr.Name = "lb_IPAddr";
			this.lb_IPAddr.Size = new System.Drawing.Size(213, 23);
			this.lb_IPAddr.TabIndex = 7;
			this.lb_IPAddr.Text = "请输入账号和密码，并点击拨号";
			this.lb_IPAddr.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
			// 
			// MainForm
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(270, 254);
			this.Controls.Add(this.lb_IPAddr);
			this.Controls.Add(this.Statusbar);
			this.Controls.Add(this.Password);
			this.Controls.Add(this.lb_Pass);
			this.Controls.Add(this.Username);
			this.Controls.Add(this.lb_User);
			this.Controls.Add(this.btn_Hungup);
			this.Controls.Add(this.btn_Dialup);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
			this.MaximizeBox = false;
			this.Name = "MainForm";
			this.Text = "PPPoE 拨号器";
			this.Statusbar.ResumeLayout(false);
			this.Statusbar.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();

		}
	}
}
