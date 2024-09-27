using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CdmdProject
{
    public partial class MainPage : Form
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private lblLoginPage frmlogin=new lblLoginPage();
        private DashboardOverview frmdash=new DashboardOverview();
        private PatientProfile frmpatientProfile=new PatientProfile();  
        private HealthMetrics frmHealth=new HealthMetrics();
        private ALertsAndNotifications frmAlerts=new ALertsAndNotifications();
        private DataInput frmData=new DataInput();
        private PatientProgress frmPatientProgress=new PatientProgress();
        private TreatmentPlan frmTreatment=new TreatmentPlan();
        private ReportsAndAnalytics frmReportsAndAnalytics=new ReportsAndAnalytics();   
        private SettingsAndDeviceManagement frmSettings=new SettingsAndDeviceManagement();
        private UserManagement frmUserManagement=new UserManagement();
        
        private void mnuLogin_Click(object sender, EventArgs e)
        {
            frmlogin.MdiParent = this;
            frmlogin.Show();
            frmlogin.Activate();
        }

        private void mnuDash_Click(object sender, EventArgs e)
        {
            frmdash.MdiParent = this;
            frmdash.Show();
            frmdash.Activate();
        }

        private void mnuPatientProfile_Click(object sender, EventArgs e)
        {
            frmpatientProfile.MdiParent = this;
            frmpatientProfile.Show();
            frmpatientProfile.Activate();
        }

        private void mnuHealth_Click(object sender, EventArgs e)
        {
            frmHealth.MdiParent = this;
            frmHealth.Show();
            frmHealth.Activate();
        }

        private void mnuAlerts_Click(object sender, EventArgs e)
        {
            frmAlerts.MdiParent = this;
            frmAlerts.Show();
            frmAlerts.Activate();
        }

        private void mnuData_Click(object sender, EventArgs e)
        {

            frmData.MdiParent = this;
            frmData.Show();
            frmData.Activate();
        }

        private void mnuPatientProgress_Click(object sender, EventArgs e)
        {
            frmPatientProgress.MdiParent = this;
            frmPatientProgress.Show();
            frmPatientProgress.Activate();
        }

        private void mnuTreatmentPlan_Click(object sender, EventArgs e)
        {
            frmTreatment.MdiParent = this;
            frmTreatment.Show();
            frmTreatment.Activate();
        }

        private void mnuReport_Click(object sender, EventArgs e)
        {
            frmReportsAndAnalytics.MdiParent = this;
            frmReportsAndAnalytics.Show();
            frmReportsAndAnalytics.Activate();
        }

        private void mnuDevice_Click(object sender, EventArgs e)
        {
            frmSettings.MdiParent = this;
            frmSettings.Show();
            frmSettings.Activate();
        }

        private void mnuUser_Click(object sender, EventArgs e)
        {
            frmUserManagement.MdiParent = this;
            frmUserManagement.Show();
            frmUserManagement.Activate();
        }
    }
}
