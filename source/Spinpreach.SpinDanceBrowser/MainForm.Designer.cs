﻿namespace Spinpreach.SpinDanceBrowser
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.MenuBar = new System.Windows.Forms.ToolStrip();
            this.ReloadButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.ScreenShotButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.MuteButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.SettingButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
            this.SubFormDropDownButton = new System.Windows.Forms.ToolStripDropDownButton();
            this.ResourceGraphMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
            this.panel1 = new System.Windows.Forms.Panel();
            this.SwordsDanceBrowser = new Spinpreach.SwordsDancePlayer.SwordsDanceBrowser();
            this.MissionNotify = new System.Windows.Forms.NotifyIcon(this.components);
            this.MenuBar.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuBar
            // 
            this.MenuBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ReloadButton,
            this.toolStripSeparator1,
            this.ScreenShotButton,
            this.toolStripSeparator2,
            this.MuteButton,
            this.toolStripSeparator3,
            this.SettingButton,
            this.toolStripSeparator4,
            this.SubFormDropDownButton,
            this.toolStripSeparator5});
            this.MenuBar.Location = new System.Drawing.Point(0, 0);
            this.MenuBar.Name = "MenuBar";
            this.MenuBar.RenderMode = System.Windows.Forms.ToolStripRenderMode.System;
            this.MenuBar.Size = new System.Drawing.Size(964, 39);
            this.MenuBar.TabIndex = 1;
            this.MenuBar.Text = "MenuBar";
            // 
            // ReloadButton
            // 
            this.ReloadButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ReloadButton.Image = global::Spinpreach.SpinDanceBrowser.Properties.Resources.ReloadImage;
            this.ReloadButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ReloadButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ReloadButton.Name = "ReloadButton";
            this.ReloadButton.Size = new System.Drawing.Size(36, 36);
            this.ReloadButton.Text = "Reload";
            this.ReloadButton.ToolTipText = "Reload";
            this.ReloadButton.Click += new System.EventHandler(this.ReloadButton_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 39);
            // 
            // ScreenShotButton
            // 
            this.ScreenShotButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.ScreenShotButton.Image = global::Spinpreach.SpinDanceBrowser.Properties.Resources.ScreenShotImage;
            this.ScreenShotButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ScreenShotButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.ScreenShotButton.Name = "ScreenShotButton";
            this.ScreenShotButton.Size = new System.Drawing.Size(36, 36);
            this.ScreenShotButton.Text = "ScreenShot";
            this.ScreenShotButton.ToolTipText = "ScreenShot";
            this.ScreenShotButton.Click += new System.EventHandler(this.ScreenShotButton_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 39);
            // 
            // MuteButton
            // 
            this.MuteButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.MuteButton.Image = global::Spinpreach.SpinDanceBrowser.Properties.Resources.MuteoffImage;
            this.MuteButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.MuteButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.MuteButton.Name = "MuteButton";
            this.MuteButton.Size = new System.Drawing.Size(36, 36);
            this.MuteButton.Text = "Mute";
            this.MuteButton.ToolTipText = "Mute";
            this.MuteButton.Click += new System.EventHandler(this.MuteButton_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 39);
            // 
            // SettingButton
            // 
            this.SettingButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.SettingButton.Image = global::Spinpreach.SpinDanceBrowser.Properties.Resources.SettingImage;
            this.SettingButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SettingButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SettingButton.Name = "SettingButton";
            this.SettingButton.Size = new System.Drawing.Size(36, 36);
            this.SettingButton.Text = "Setting";
            this.SettingButton.ToolTipText = "Setting";
            this.SettingButton.Click += new System.EventHandler(this.SettingButton_Click);
            // 
            // toolStripSeparator4
            // 
            this.toolStripSeparator4.Name = "toolStripSeparator4";
            this.toolStripSeparator4.Size = new System.Drawing.Size(6, 39);
            // 
            // SubFormDropDownButton
            // 
            this.SubFormDropDownButton.AutoToolTip = false;
            this.SubFormDropDownButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.SubFormDropDownButton.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ResourceGraphMenuItem});
            this.SubFormDropDownButton.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.SubFormDropDownButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.SubFormDropDownButton.Name = "SubFormDropDownButton";
            this.SubFormDropDownButton.Size = new System.Drawing.Size(72, 36);
            this.SubFormDropDownButton.Text = "SubForms";
            // 
            // ResourceGraphMenuItem
            // 
            this.ResourceGraphMenuItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Text;
            this.ResourceGraphMenuItem.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.ResourceGraphMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.ResourceGraphMenuItem.Name = "ResourceGraphMenuItem";
            this.ResourceGraphMenuItem.Size = new System.Drawing.Size(157, 22);
            this.ResourceGraphMenuItem.Text = "Resource Graph";
            this.ResourceGraphMenuItem.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.ResourceGraphMenuItem.Click += new System.EventHandler(this.ResourceGraphMenuItem_Click);
            // 
            // toolStripSeparator5
            // 
            this.toolStripSeparator5.Name = "toolStripSeparator5";
            this.toolStripSeparator5.Size = new System.Drawing.Size(6, 39);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SwordsDanceBrowser);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 39);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(964, 702);
            this.panel1.TabIndex = 2;
            // 
            // SwordsDanceBrowser
            // 
            this.SwordsDanceBrowser.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SwordsDanceBrowser.Location = new System.Drawing.Point(0, 0);
            this.SwordsDanceBrowser.login = null;
            this.SwordsDanceBrowser.MinimumSize = new System.Drawing.Size(20, 20);
            this.SwordsDanceBrowser.Name = "SwordsDanceBrowser";
            this.SwordsDanceBrowser.Size = new System.Drawing.Size(964, 702);
            this.SwordsDanceBrowser.TabIndex = 0;
            // 
            // MissionNotify
            // 
            this.MissionNotify.Icon = ((System.Drawing.Icon)(resources.GetObject("MissionNotify.Icon")));
            this.MissionNotify.Visible = true;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(964, 741);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.MenuBar);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MainForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Shown += new System.EventHandler(this.MainForm_Shown);
            this.MenuBar.ResumeLayout(false);
            this.MenuBar.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private SwordsDancePlayer.SwordsDanceBrowser SwordsDanceBrowser;
        private System.Windows.Forms.ToolStrip MenuBar;
        private System.Windows.Forms.ToolStripButton ReloadButton;
        private System.Windows.Forms.ToolStripButton ScreenShotButton;
        private System.Windows.Forms.ToolStripButton MuteButton;
        private System.Windows.Forms.ToolStripButton SettingButton;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator4;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.NotifyIcon MissionNotify;
        private System.Windows.Forms.ToolStripDropDownButton SubFormDropDownButton;
        private System.Windows.Forms.ToolStripMenuItem ResourceGraphMenuItem;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator5;
    }
}