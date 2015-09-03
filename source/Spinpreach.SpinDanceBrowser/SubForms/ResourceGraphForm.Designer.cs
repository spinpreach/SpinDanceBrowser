namespace Spinpreach.SpinDanceBrowser.SubForms
{
    partial class ResourceGraphForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ResourceGraphForm));
            this.MonthLabel = new System.Windows.Forms.Label();
            this.NextMonthButton = new System.Windows.Forms.Button();
            this.PreviousMonthButton = new System.Windows.Forms.Button();
            this.chart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            ((System.ComponentModel.ISupportInitialize)(this.chart)).BeginInit();
            this.SuspendLayout();
            // 
            // MonthLabel
            // 
            this.MonthLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.MonthLabel.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.MonthLabel.Font = new System.Drawing.Font("Yu Gothic UI", 9F);
            this.MonthLabel.Location = new System.Drawing.Point(80, 12);
            this.MonthLabel.Name = "MonthLabel";
            this.MonthLabel.Size = new System.Drawing.Size(84, 31);
            this.MonthLabel.TabIndex = 7;
            this.MonthLabel.Text = "YYYY / MM";
            this.MonthLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.MonthLabel.TextChanged += new System.EventHandler(this.MonthLabel_TextChanged);
            this.MonthLabel.DoubleClick += new System.EventHandler(this.MonthLabel_DoubleClick);
            // 
            // NextMonthButton
            // 
            this.NextMonthButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.NextMonthButton.Location = new System.Drawing.Point(170, 12);
            this.NextMonthButton.Name = "NextMonthButton";
            this.NextMonthButton.Size = new System.Drawing.Size(62, 31);
            this.NextMonthButton.TabIndex = 9;
            this.NextMonthButton.TabStop = false;
            this.NextMonthButton.Text = "→";
            this.NextMonthButton.UseVisualStyleBackColor = true;
            this.NextMonthButton.Click += new System.EventHandler(this.NextMonthButton_Click);
            // 
            // PreviousMonthButton
            // 
            this.PreviousMonthButton.Font = new System.Drawing.Font("Yu Gothic UI", 9F, System.Drawing.FontStyle.Bold);
            this.PreviousMonthButton.Location = new System.Drawing.Point(12, 12);
            this.PreviousMonthButton.Name = "PreviousMonthButton";
            this.PreviousMonthButton.Size = new System.Drawing.Size(62, 31);
            this.PreviousMonthButton.TabIndex = 8;
            this.PreviousMonthButton.TabStop = false;
            this.PreviousMonthButton.Text = "←";
            this.PreviousMonthButton.UseVisualStyleBackColor = true;
            this.PreviousMonthButton.Click += new System.EventHandler(this.PreviousMonthButton_Click);
            // 
            // chart
            // 
            this.chart.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart.Location = new System.Drawing.Point(10, 49);
            this.chart.Margin = new System.Windows.Forms.Padding(1, 3, 1, 1);
            this.chart.Name = "chart";
            this.chart.Size = new System.Drawing.Size(469, 365);
            this.chart.TabIndex = 10;
            this.chart.TabStop = false;
            this.chart.Text = "chart";
            // 
            // ResourceGraphForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(489, 424);
            this.Controls.Add(this.chart);
            this.Controls.Add(this.MonthLabel);
            this.Controls.Add(this.NextMonthButton);
            this.Controls.Add(this.PreviousMonthButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ResourceGraphForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ResourceGraphForm";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.ResourceGraphForm_FormClosing);
            this.Shown += new System.EventHandler(this.ResourceGraphForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.chart)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        protected System.Windows.Forms.Label MonthLabel;
        protected System.Windows.Forms.Button NextMonthButton;
        protected System.Windows.Forms.Button PreviousMonthButton;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart;
    }
}