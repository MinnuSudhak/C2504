using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Example3
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            CounterConfig.lblStatus = lblStatus;
        }
        private CounterForm frmCounter=new CounterForm();
        private ExtendedCounterForm frmExtendedCounter=new ExtendedCounterForm();

        private void mnuSimpleCounter_Click(object sender, EventArgs e)
        {
            CounterConfig.ShowChild(this,frmCounter);
        }

        private void mnuEnabledCounter_Click(object sender, EventArgs e)
        {
            CounterConfig.ShowChild(this, frmExtendedCounter);
        }
    }
}
