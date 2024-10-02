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
    public partial class ExtendedCounterForm : Form
    {
        public ExtendedCounterForm()
        {
            InitializeComponent();
        }

        private void ExtendedCounterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            CounterConfig.Count += (int)txtStep.Value;
            lblName.Text = CounterConfig.Count.ToString();
            CounterConfig.lblStatus.Text = "Plus";
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            CounterConfig.Count -= (int)txtStep.Value;
            lblName.Text = CounterConfig.Count.ToString();
            CounterConfig.lblStatus.Text = "Minus";
        }

        private void ExtendedCounterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ExtendedCounterForm_Enter(object sender, EventArgs e)
        {
            lblName.Text = CounterConfig.Count.ToString();
        }
    }
}

