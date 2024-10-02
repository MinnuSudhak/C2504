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
    public partial class CounterForm : Form
    {
        public CounterForm()
        {
            InitializeComponent();
            lblName.Text= CounterConfig.Count.ToString();
        }

        private void CounterForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            e.Cancel = true;
            this.Hide();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            CounterConfig.Count++;
            lblName.Text= CounterConfig.Count.ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            CounterConfig.Count--;
            lblName.Text= CounterConfig.Count.ToString();
        }

        private void CounterForm_Load(object sender, EventArgs e)
        {
            
        }

        private void CounterForm_Enter(object sender, EventArgs e)
        {
            lblName.Text= CounterConfig.Count.ToString();
        }
    }
}
