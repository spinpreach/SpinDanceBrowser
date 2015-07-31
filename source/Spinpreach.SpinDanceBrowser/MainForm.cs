﻿using System;
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

using MetroFramework.Forms;
using MetroFramework;

using Spinpreach.SwordsDanceBase;
using Spinpreach.SwordsDanceViewer;

namespace Spinpreach.SpinDanceBrowser
{
    public partial class MainForm : MetroForm
    {

        private SessionWrapper sessionWrapper;

        public MainForm(SessionWrapper sessionWrapper)
        {
            this.sessionWrapper = sessionWrapper;
            InitializeComponent();
            this.SwordsDanceBrowser.LoginCompletedEvent += SwordsDanceBrowser_LoginCompletedEvent;
            this.SwordsDanceBrowser.MuteChangedEvent += SwordsDanceBrowser_MuteChangedEvent;
            Version version = Assembly.GetExecutingAssembly().GetName().Version;
            this.Text = string.Format("回転剣舞 ver {0}.{1}.{2}", version.Major, version.Minor, version.Build);
        }

        private void MainForm_Shown(object sender, EventArgs e)
        {
            this.SwordsDanceBrowser.Start();
        }

        private void ReloadButton_Click(object sender, EventArgs e)
        {
            string message = "再読み込みしてもいいですか？";
            string title = string.Empty;
            if (MetroMessageBox.Show(this, message, title, MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                this.SwordsDanceBrowser.Start();
            }
        }

        private void SettingButton_Click(object sender, EventArgs e)
        {
            LoginForm frm = new LoginForm();
            if (frm.ShowDialog() == DialogResult.OK)
            {
                LoginInfo.Save(frm.LoginData);
                string message = "入力されたアカウントは次回起動時から使用されます。";
                string title = string.Empty;
                MetroMessageBox.Show(this, message, title, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void MuteButton_Click(object sender, EventArgs e)
        {
            this.SwordsDanceBrowser.ToggleMute();
        }

        private void ScreenShotButton_Click(object sender, EventArgs e)
        {
            this.ScreenShotButton.Enabled = false;

            string directory = string.Format(@"{0}\{1}", Directory.GetCurrentDirectory(), "ScreenShot");
            if (!Directory.Exists(directory)) { Directory.CreateDirectory(directory); }
            string path = string.Format(@"{0}\{1}.{2}", directory, DateTime.Now.ToString("yyyyMMdd-HHmmss.fff"), "png");

            this.SwordsDanceBrowser.ScreenShot(path);

            this.ScreenShotButton.Enabled = true;
        }

        private void SwordsDanceBrowser_LoginCompletedEvent(object sender, EventArgs e)
        {
            var isMuted = this.SwordsDanceBrowser.IsMute();
            if (isMuted == null) { return; }
            this.MuteImageChange((bool)isMuted);
        }

        private void SwordsDanceBrowser_MuteChangedEvent(bool isMuted)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                this.MuteImageChange(isMuted);
            });
        }

        private void MuteImageChange(bool isMuted)
        {
            switch (isMuted)
            {
                case true: this.MuteButton.BackgroundImage = Properties.Resources.MuteonImage; break;
                case false: this.MuteButton.BackgroundImage = Properties.Resources.MuteoffImage; break;
            }
        }

    }
}
