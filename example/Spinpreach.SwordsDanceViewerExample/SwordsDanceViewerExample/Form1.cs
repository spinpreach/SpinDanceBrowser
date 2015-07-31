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

namespace Spinpreach.SwordsDanceViewerExample
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.SwordsDanceBrowser.LoginCompletedEvent += SwordsDanceBrowser_LoginCompletedEvent;
            this.SwordsDanceBrowser.MuteChangedEvent += SwordsDanceBrowser_MuteChangedEvent;
        }

        private void Form1_Shown(object sender, EventArgs e)
        {
            this.SwordsDanceBrowser.Start();
        }

        private void StartButton_Click(object sender, EventArgs e)
        {
            this.SwordsDanceBrowser.Start();
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

        private void ToggleMuteButton_Click(object sender, EventArgs e)
        {
            this.SwordsDanceBrowser.ToggleMute();
        }

        private void SwordsDanceBrowser_LoginCompletedEvent(object sender, EventArgs e)
        {
            var isMuted = this.SwordsDanceBrowser.IsMute();
            if (isMuted == null) { return; }
            this.ToggleMuteButton.Text = (bool)isMuted ? "×" : "●";
        }

        private void SwordsDanceBrowser_MuteChangedEvent(bool isMuted)
        {
            this.Invoke((MethodInvoker)delegate ()
            {
                this.ToggleMuteButton.Text = isMuted ? "×" : "●";
            });
        }        

    }
}
