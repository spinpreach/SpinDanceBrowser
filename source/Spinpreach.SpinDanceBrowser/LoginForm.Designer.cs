namespace Spinpreach.SpinDanceBrowser
{
    partial class LoginForm
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
            this.metroStyleManager = new MetroFramework.Components.MetroStyleManager(this.components);
            this.UseridTextBox = new MetroFramework.Controls.MetroTextBox();
            this.PasswordTextBox = new MetroFramework.Controls.MetroTextBox();
            this.LoginButton = new MetroFramework.Controls.MetroButton();
            this.UseridLabel = new MetroFramework.Controls.MetroLabel();
            this.PasswordLabel = new MetroFramework.Controls.MetroLabel();
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).BeginInit();
            this.SuspendLayout();
            // 
            // metroStyleManager
            // 
            this.metroStyleManager.Owner = this;
            this.metroStyleManager.Style = MetroFramework.MetroColorStyle.Pink;
            this.metroStyleManager.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // UseridTextBox
            // 
            this.UseridTextBox.Lines = new string[0];
            this.UseridTextBox.Location = new System.Drawing.Point(23, 93);
            this.UseridTextBox.MaxLength = 32767;
            this.UseridTextBox.Name = "UseridTextBox";
            this.UseridTextBox.PasswordChar = '\0';
            this.UseridTextBox.PromptText = "***";
            this.UseridTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.UseridTextBox.SelectedText = "";
            this.UseridTextBox.Size = new System.Drawing.Size(270, 23);
            this.UseridTextBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.UseridTextBox.TabIndex = 0;
            this.UseridTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.UseridTextBox.UseSelectable = true;
            this.UseridTextBox.UseStyleColors = true;
            // 
            // PasswordTextBox
            // 
            this.PasswordTextBox.Lines = new string[0];
            this.PasswordTextBox.Location = new System.Drawing.Point(23, 158);
            this.PasswordTextBox.MaxLength = 32767;
            this.PasswordTextBox.Name = "PasswordTextBox";
            this.PasswordTextBox.PasswordChar = '*';
            this.PasswordTextBox.PromptText = "***";
            this.PasswordTextBox.ScrollBars = System.Windows.Forms.ScrollBars.None;
            this.PasswordTextBox.SelectedText = "";
            this.PasswordTextBox.Size = new System.Drawing.Size(270, 23);
            this.PasswordTextBox.Style = MetroFramework.MetroColorStyle.Pink;
            this.PasswordTextBox.TabIndex = 1;
            this.PasswordTextBox.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.PasswordTextBox.UseSelectable = true;
            this.PasswordTextBox.UseStyleColors = true;
            // 
            // LoginButton
            // 
            this.LoginButton.Highlight = true;
            this.LoginButton.Location = new System.Drawing.Point(184, 196);
            this.LoginButton.Name = "LoginButton";
            this.LoginButton.Size = new System.Drawing.Size(109, 30);
            this.LoginButton.Style = MetroFramework.MetroColorStyle.Pink;
            this.LoginButton.TabIndex = 2;
            this.LoginButton.Text = "OK";
            this.LoginButton.Theme = MetroFramework.MetroThemeStyle.Dark;
            this.LoginButton.UseSelectable = true;
            this.LoginButton.Click += new System.EventHandler(this.LoginButton_Click);
            // 
            // UseridLabel
            // 
            this.UseridLabel.AutoSize = true;
            this.UseridLabel.Location = new System.Drawing.Point(23, 71);
            this.UseridLabel.Name = "UseridLabel";
            this.UseridLabel.Size = new System.Drawing.Size(93, 19);
            this.UseridLabel.Style = MetroFramework.MetroColorStyle.Pink;
            this.UseridLabel.TabIndex = 3;
            this.UseridLabel.Text = "DMMアカウント";
            this.UseridLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.UseridLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.Location = new System.Drawing.Point(23, 136);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(64, 19);
            this.PasswordLabel.Style = MetroFramework.MetroColorStyle.Pink;
            this.PasswordLabel.TabIndex = 4;
            this.PasswordLabel.Text = "パスワード";
            this.PasswordLabel.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.PasswordLabel.Theme = MetroFramework.MetroThemeStyle.Dark;
            // 
            // LoginForm
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BorderStyle = MetroFramework.Forms.MetroFormBorderStyle.FixedSingle;
            this.ClientSize = new System.Drawing.Size(316, 249);
            this.Controls.Add(this.PasswordLabel);
            this.Controls.Add(this.UseridLabel);
            this.Controls.Add(this.LoginButton);
            this.Controls.Add(this.PasswordTextBox);
            this.Controls.Add(this.UseridTextBox);
            this.Font = new System.Drawing.Font("メイリオ", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "LoginForm";
            this.Resizable = false;
            this.Style = MetroFramework.MetroColorStyle.Pink;
            this.Text = "Login";
            this.Theme = MetroFramework.MetroThemeStyle.Dark;
            ((System.ComponentModel.ISupportInitialize)(this.metroStyleManager)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MetroFramework.Components.MetroStyleManager metroStyleManager;
        private MetroFramework.Controls.MetroTextBox PasswordTextBox;
        private MetroFramework.Controls.MetroTextBox UseridTextBox;
        private MetroFramework.Controls.MetroButton LoginButton;
        private MetroFramework.Controls.MetroLabel UseridLabel;
        private MetroFramework.Controls.MetroLabel PasswordLabel;
    }
}