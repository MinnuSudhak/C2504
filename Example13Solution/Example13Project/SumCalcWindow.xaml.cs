﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Example13Project
{
    /// <summary>
    /// Interaction logic for SumCalcWindow.xaml
    /// </summary>
    public partial class SumCalcWindow : Window
    {
        public SumCalcWindow()
        {
            InitializeComponent();
        }
        private bool IsNum(string numstr)
        {
            try
            {
                int.Parse(numstr);
                    return true;
            }
            catch
            {
                return false;
            }
        }
        private void btnFindSum_Click(object sender, RoutedEventArgs e)
        {
            if (!IsNum(txtNumber1.Text))
            {
                MessageBox.Show("Please enter number 1");
                txtNumber1.Focus();
                txtNumber1.SelectAll();
                return;
            }
            if (!IsNum(txtNumber2.Text))
            {
                MessageBox.Show("Please enter number 2");
                txtNumber2.Focus();
                txtNumber2.SelectAll();
                return;
            }
            int Number1= int.Parse(txtNumber1.Text);
            int Number2= int.Parse(txtNumber2.Text);
            int sum= Number1 + Number2; 
            txtSum.Text = sum.ToString();

        }
    }
}
