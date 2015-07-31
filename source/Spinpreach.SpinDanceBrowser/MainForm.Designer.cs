namespace Spinpreach.SpinDanceBrowser
{
    partial class MainForm
    {
        /// <summary>
        /// 必要なデザイナー変数です。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 使用中のリソースをすべてクリーンアップします。
        /// </summary>
        /// <param name="disposing">マネージ リソースを破棄する場合は true を指定し、その他の場合は false を指定します。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows フォーム デザイナーで生成されたコード

        /// <summary>
        /// デザイナー サポートに必要なメソッドです。このメソッドの内容を
        /// コード エディターで変更しないでください。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.SwordsDanceBrowser = new Spinpreach.SwordsDanceViewer.SwordsDanceBrowser();
            this.ScreenShotButton = new MetroFramework.Controls.MetroButton();
            this.MuteButton = new MetroFramework.Controls.MetroButton();
            this.ReloadButton = new MetroFramework.Controls.MetroButton();
            this.SettingButton = new MetroFramework.Controls.MetroButton();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // SwordsDanceBrowser
            // 
            this.SwordsDanceBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwordsDanceBrowser.Location = new System.Drawing.Point(10, 60);
            this.SwordsDanceBrowser.login = null;
            this.SwordsDanceBrowser.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SwordsDanceBrowser.MinimumSize = new System.Drawing.Size(23, 30);
            this.SwordsDanceBrowser.Name = "SwordsDanceBrowser";
            this.SwordsDanceBrowser.Size = new System.Drawing.Size(960, 580);
            this.SwordsDanceBrowser.TabIndex = 0;
            // 
            // ScreenShotButton
            // 
            this.ScreenShotButton.BackColor = System.Drawing.Color.Gray;
            this.ScreenShotButton.BackgroundImage = global::Spinpreach.SpinDanceBrowser.Properties.Resources.ScreenShotImage;
            this.ScreenShotButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ScreenShotButton.Location = new System.Drawing.Point(430, 14);
            this.ScreenShotButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ScreenShotButton.Name = "ScreenShotButton";
            this.ScreenShotButton.Size = new System.Drawing.Size(57, 38);
            this.ScreenShotButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.ScreenShotButton.TabIndex = 11;
            this.ScreenShotButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ScreenShotButton.UseSelectable = true;
            this.ScreenShotButton.Click += new System.EventHandler(this.ScreenShotButton_Click);
            // 
            // MuteButton
            // 
            this.MuteButton.BackColor = System.Drawing.Color.Gray;
            this.MuteButton.BackgroundImage = global::Spinpreach.SpinDanceBrowser.Properties.Resources.MuteoffImage;
            this.MuteButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.MuteButton.Location = new System.Drawing.Point(367, 14);
            this.MuteButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.Size = new System.Drawing.Size(57, 38);
            this.MuteButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.MuteButton.TabIndex = 12;
            this.MuteButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.MuteButton.UseSelectable = true;
            this.MuteButton.Click += new System.EventHandler(this.MuteButton_Click);
            // 
            // ReloadButton
            // 
            this.ReloadButton.BackColor = System.Drawing.Color.Gray;
            this.ReloadButton.BackgroundImage = global::Spinpreach.SpinDanceBrowser.Properties.Resources.ReloadImage;
            this.ReloadButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ReloadButton.Location = new System.Drawing.Point(241, 14);
            this.ReloadButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(57, 38);
            this.ReloadButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.ReloadButton.TabIndex = 13;
            this.ReloadButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.ReloadButton.UseSelectable = true;
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // SettingButton
            // 
            this.SettingButton.BackColor = System.Drawing.Color.Gray;
            this.SettingButton.BackgroundImage = global::Spinpreach.SpinDanceBrowser.Properties.Resources.SettingImage;
            this.SettingButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.SettingButton.Location = new System.Drawing.Point(304, 14);
            this.SettingButton.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(57, 38);
            this.SettingButton.Style = MetroFramework.MetroColorStyle.Purple;
            this.SettingButton.TabIndex = 14;
            this.SettingButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SettingButton.UseSelectable = true;
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(980, 660);
            this.Controls.Add(this.SettingButton);
            this.Controls.Add(this.ReloadButton);
            this.Controls.Add(this.MuteButton);
            this.Controls.Add(this.ScreenShotButton);
            this.Controls.Add(this.SwordsDanceBrowser);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(580, 100);
            this.Name = "MainForm";
            this.Padding = new System.Windows.Forms.Padding(10, 60, 10, 20);
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.StyleManager = this.metroStyleManager;
            this.Text = "回転剣舞 ver 1.0.0";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private SwordsDanceViewer.SwordsDanceBrowser SwordsDanceBrowser;
        private MetroFramework.Controls.MetroButton ScreenShotButton;
        private MetroFramework.Controls.MetroButton SettingButton;
        private MetroFramework.Controls.MetroButton ReloadButton;
        private MetroFramework.Controls.MetroButton MuteButton;
    }
}

