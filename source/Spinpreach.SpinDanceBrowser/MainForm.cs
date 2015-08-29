using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

using Spinpreach.SwordsDanceBase;
using Spinpreach.SwordsDancePlayer;

namespace Spinpreach.SpinDanceBrowser
{
    public partial class MainForm : Form
    {

        private SwordsDanceDatabase database;

        public MainForm(SwordsDanceDatabase database)
        {
            InitializeComponent();
            this.database = database;
            this.SwordsDanceBrowser.LoginCompletedEvent += this.SwordsDanceBrowser_LoginCompleted;
            this.SwordsDanceBrowser.LoginErrorEvent += this.SwordsDanceBrowser_LoginError;
            this.SwordsDanceBrowser.MuteChangedEvent += (isMute) => { this.Invoke(new Action<bool>(this.SwordsDanceBrowser_MuteChanged), isMute); };
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = string.Format("回転剣舞 ver {0}.{1}.{2}", version.Major, version.Minor, version.Build);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.SwordsDanceBrowser.Start();
        }

        #region SwordsDanceBrowser

        private void SwordsDanceBrowser_LoginCompleted()
        {
            var isMuted = this.SwordsDanceBrowser.IsMute();
            if (isMuted == null) { return; }
            this.SwordsDanceBrowser_MuteChanged((bool)isMuted);
        }

        private void SwordsDanceBrowser_LoginError(Exception ex)
        {
            StringBuilder msg = new StringBuilder();
            msg.AppendLine("ログインに失敗しました。");
            msg.AppendLine("");
            msg.AppendLine("※サーバが重い可能性があります。");
            msg.AppendLine("　何度か[再読み込み]をためしてみてください。");
            MessageBox.Show(msg.ToString(), "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void SwordsDanceBrowser_MuteChanged(bool isMuted)
        {
            switch (isMuted)
            {
                case true: this.MuteButton.Image = Properties.Resources.MuteonImage; break;
                case false: this.MuteButton.Image = Properties.Resources.MuteoffImage; break;
            }
        }

        #endregion

        #region MenuBar

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            string message = "再読み込みしてもいいですか？";
            string title = string.Empty;
            if (MessageBox.Show(this, message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.SwordsDanceBrowser.Start();
            }
        }

        private void ScreenShotButton_Click(object sender, EventArgs e)
        {
            ((ToolStripButton)sender).Enabled = false;

            string directory = string.Format(@"{0}\{1}", Directory.GetCurrentDirectory(), "ScreenShot");
            if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }
            string path = string.Format(@"{0}\{1}.{2}", directory, DateTime.Now.ToString("yyyyMMdd-HHmmss.fff"), "png");
            this.SwordsDanceBrowser.ScreenShot(path);

            ((ToolStripButton)sender).Enabled = true;
        }

        private void MuteButton_Click(object sender, EventArgs e)
        {
            ((ToolStripButton)sender).Enabled = false;

            this.SwordsDanceBrowser.ToggleMute();

            ((ToolStripButton)sender).Enabled = true;
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            ((ToolStripButton)sender).Enabled = false;

            this.MissionNotify.BalloonTipIcon = ToolTipIcon.Info;
            this.MissionNotify.BalloonTipTitle = "【 遠征帰還通知 】";
            this.MissionNotify.BalloonTipText = "XXXXXXXXXXXXXXx";
            this.MissionNotify.Visible = true;
            this.MissionNotify.ShowBalloonTip(2000);

            //notifyIcon.BalloonTipIcon = ToolTipIcon.Info;
            //notifyIcon.BalloonTipTitle = "【 遠征帰還通知 】";
            //notifyIcon.BalloonTipText = "XXXXXXXXXXXXXXXXXXXXXx";
            //notifyIcon.ShowBalloonTip(2000);

            //var frm = new LoginForm();
            //if (frm.ShowDialog() == DialogResult.OK)
            //{
            //    LoginInfo.Save(frm.LoginData);
            //    string message = "入力されたアカウントは次回起動時から使用されます。";
            //    string title = string.Empty;
            //    MessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            //}

            ((ToolStripButton)sender).Enabled = true;
        }

        #endregion

    }
}
