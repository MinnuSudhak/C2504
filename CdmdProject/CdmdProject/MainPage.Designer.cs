namespace CdmdProject
{
    partial class MainPage
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.mnuLogin = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDash = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPatientProfile = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuHealth = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuAlerts = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuData = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuPatientProgress = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuTreatmentPlan = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuReport = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuDevice = new System.Windows.Forms.ToolStripMenuItem();
            this.mnuUser = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnuLogin,
            this.mnuDash,
            this.mnuPatientProfile,
            this.mnuHealth,
            this.mnuAlerts,
            this.mnuData,
            this.mnuPatientProgress,
            this.mnuTreatmentPlan,
            this.mnuReport,
            this.mnuDevice,
            this.mnuUser});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1359, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // mnuLogin
            // 
            this.mnuLogin.Name = "mnuLogin";
            this.mnuLogin.Size = new System.Drawing.Size(60, 24);
            this.mnuLogin.Text = "&Login";
            this.mnuLogin.Click += new System.EventHandler(this.mnuLogin_Click);
            // 
            // mnuDash
            // 
            this.mnuDash.Name = "mnuDash";
            this.mnuDash.Size = new System.Drawing.Size(96, 24);
            this.mnuDash.Text = "&Dashboard";
            this.mnuDash.Click += new System.EventHandler(this.mnuDash_Click);
            // 
            // mnuPatientProfile
            // 
            this.mnuPatientProfile.Name = "mnuPatientProfile";
            this.mnuPatientProfile.Size = new System.Drawing.Size(115, 24);
            this.mnuPatientProfile.Text = "&Patient Profile";
            this.mnuPatientProfile.Click += new System.EventHandler(this.mnuPatientProfile_Click);
            // 
            // mnuHealth
            // 
            this.mnuHealth.Name = "mnuHealth";
            this.mnuHealth.Size = new System.Drawing.Size(67, 24);
            this.mnuHealth.Text = "&Health";
            this.mnuHealth.Click += new System.EventHandler(this.mnuHealth_Click);
            // 
            // mnuAlerts
            // 
            this.mnuAlerts.Name = "mnuAlerts";
            this.mnuAlerts.Size = new System.Drawing.Size(173, 24);
            this.mnuAlerts.Text = "&Alerts and Notification";
            this.mnuAlerts.Click += new System.EventHandler(this.mnuAlerts_Click);
            // 
            // mnuData
            // 
            this.mnuData.Name = "mnuData";
            this.mnuData.Size = new System.Drawing.Size(93, 24);
            this.mnuData.Text = "&Data Input";
            this.mnuData.Click += new System.EventHandler(this.mnuData_Click);
            // 
            // mnuPatientProgress
            // 
            this.mnuPatientProgress.Name = "mnuPatientProgress";
            this.mnuPatientProgress.Size = new System.Drawing.Size(132, 24);
            this.mnuPatientProgress.Text = "&Patient  Progress";
            this.mnuPatientProgress.Click += new System.EventHandler(this.mnuPatientProgress_Click);
            // 
            // mnuTreatmentPlan
            // 
            this.mnuTreatmentPlan.Name = "mnuTreatmentPlan";
            this.mnuTreatmentPlan.Size = new System.Drawing.Size(126, 24);
            this.mnuTreatmentPlan.Text = "&Treatment  Plan";
            this.mnuTreatmentPlan.Click += new System.EventHandler(this.mnuTreatmentPlan_Click);
            // 
            // mnuReport
            // 
            this.mnuReport.Name = "mnuReport";
            this.mnuReport.Size = new System.Drawing.Size(166, 24);
            this.mnuReport.Text = "&Reports and Analytics";
            this.mnuReport.Click += new System.EventHandler(this.mnuReport_Click);
            // 
            // mnuDevice
            // 
            this.mnuDevice.Name = "mnuDevice";
            this.mnuDevice.Size = new System.Drawing.Size(164, 24);
            this.mnuDevice.Text = "&Device  Management";
            this.mnuDevice.Click += new System.EventHandler(this.mnuDevice_Click);
            // 
            // mnuUser
            // 
            this.mnuUser.Name = "mnuUser";
            this.mnuUser.Size = new System.Drawing.Size(148, 24);
            this.mnuUser.Text = "&User  Management";
            this.mnuUser.Click += new System.EventHandler(this.mnuUser_Click);
            // 
            // MainPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(13F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1359, 370);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(5, 5, 5, 5);
            this.Name = "MainPage";
            this.Text = "MainPage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mnuLogin;
        private System.Windows.Forms.ToolStripMenuItem mnuDash;
        private System.Windows.Forms.ToolStripMenuItem mnuPatientProfile;
        private System.Windows.Forms.ToolStripMenuItem mnuHealth;
        private System.Windows.Forms.ToolStripMenuItem mnuAlerts;
        private System.Windows.Forms.ToolStripMenuItem mnuData;
        private System.Windows.Forms.ToolStripMenuItem mnuPatientProgress;
        private System.Windows.Forms.ToolStripMenuItem mnuTreatmentPlan;
        private System.Windows.Forms.ToolStripMenuItem mnuReport;
        private System.Windows.Forms.ToolStripMenuItem mnuDevice;
        private System.Windows.Forms.ToolStripMenuItem mnuUser;
    }
}