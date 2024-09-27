using System;
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
    /// Interaction logic for SquareCalcWindow.xaml
    /// </summary>
    public partial class SquareCalcWindow : Window
    {
        public SquareCalcWindow()
        {
            InitializeComponent();
        }
        private bool Isnum(string numstr)
        {
            try
            {
                int.Parse(numstr);
                return true;
            }
            catch { return false; }
        }
        private void btnSquare_Click(object sender, RoutedEventArgs e)
        {
            if (!Isnum(txtNumber.Text))
            {
                return;
            }
           
            int Number1 = int.Parse(txtNumber.Text);

            int Square = Number1 * Number1;
            txtResult.Text = Square.ToString();
            lblResult.Text = "Square";
        }

        private void btnCube_Click(object sender, RoutedEventArgs e)
        {
            if (!Isnum(txtNumber.Text))
            {
                return;
            }

            int Number1 = int.Parse(txtNumber.Text);

            int cube = Number1 * Number1*Number1;
            txtResult.Text = cube.ToString();
            lblResult.Text = "Cube";
        }
    }
}
