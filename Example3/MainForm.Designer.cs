namespace Example3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.mnubar = new System.Windows.Forms.MenuStrip();
            this.mnuSimpleCounter = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuEnabledCounter = new System.Windows.Forms.ToolStripMenuItem();
            this.stsBar = new System.Windows.Forms.StatusStrip();
            this.lblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.mnubar.SuspendLayout();
            this.stsBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // mnubar
            // 
            this.mnubar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.mnubar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuSimpleCounter,
            this.mnuEnabledCounter});
            this.mnubar.Location = new System.Drawing.Point(0, 0);
            this.mnubar.Name = "mnubar";
            this.mnubar.Padding = new System.Windows.Forms.Padding(13, 3, 0, 3);
            this.mnubar.Size = new System.Drawing.Size(1300, 30);
            this.mnubar.TabIndex = 0;
            this.mnubar.Text = "menuStrip1";
            // 
            // mnuSimpleCounter
            // 
            this.mnuSimpleCounter.Name = "mnuSimpleCounter";
            this.mnuSimpleCounter.Size = new System.Drawing.Size(125, 24);
            this.mnuSimpleCounter.Text = "&Simple Counter";
            this.mnuSimpleCounter.Click += new System.EventHandler(this.mnuSimpleCounter_Click);
            // 
            // mnuEnabledCounter
            // 
            this.mnuEnabledCounter.Name = "mnuEnabledCounter";
            this.mnuEnabledCounter.Size = new System.Drawing.Size(141, 24);
            this.mnuEnabledCounter.Text = "&Extended Counter";
            this.mnuEnabledCounter.Click += new System.EventHandler(this.mnuEnabledCounter_Click);
            // 
            // stsBar
            // 
            this.stsBar.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.stsBar.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblStatus});
            this.stsBar.Location = new System.Drawing.Point(0, 677);
            this.stsBar.Name = "stsBar";
            this.stsBar.Padding = new System.Windows.Forms.Padding(2, 0, 23, 0);
            this.stsBar.Size = new System.Drawing.Size(1300, 26);
            this.stsBar.TabIndex = 1;
            // 
            // lblStatus
            // 
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(71, 20);
            this.lblStatus.Text = "Welcome";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1300, 703);
            this.Controls.Add(this.stsBar);
            this.Controls.Add(this.mnubar);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.mnubar;
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "MainForm";
            this.Text = "Counter App";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.mnubar.ResumeLayout(false);
            this.mnubar.PerformLayout();
            this.stsBar.ResumeLayout(false);
            this.stsBar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip mnubar;
        private System.Windows.Forms.ToolStripMenuItem mnuSimpleCounter;
        private System.Windows.Forms.ToolStripMenuItem mnuEnabledCounter;
        private System.Windows.Forms.StatusStrip stsBar;
        private System.Windows.Forms.ToolStripStatusLabel lblStatus;
    }
}

