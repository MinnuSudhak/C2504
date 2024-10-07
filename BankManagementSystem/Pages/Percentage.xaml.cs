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

namespace BankManagementSystem.Pages
{
    /// <summary>
    /// Interaction logic for Percentage.xaml
    /// </summary>
    public partial class Percentage : Window
    {
        
        
            public Percentage()
            {
                InitializeComponent();
            }

        // Event handler for showing accounts with selected interest percentage
        private void btnShowAccounts_Click(object sender, RoutedEventArgs e)
        {

            double selectedInterestRate = 0;

                // Determine which radio button is selected
                if (A10per.IsChecked == true)
                    selectedInterestRate = 0;
                else if (A5per.IsChecked == true)
                    selectedInterestRate = 10;

                else if (B10per.IsChecked == true)
                    selectedInterestRate = 10;
                else if (C15per.IsChecked == true)
                    selectedInterestRate = 15;

                // Filter the accounts with the selected interest rate
                var filteredAccounts = FormConfig.accountViewModel.Accounts
                    .Where(account => account.InterestRate == selectedInterestRate)
                    .ToList();

            //// Show the filtered accounts in the AccountListWindow
            //AccountListWindow accountListWindow = (AccountListWindow)Application.Current.Windows
            //    .OfType<AccountListWindow>().FirstOrDefault();
            //if (accountListWindow != null)
            //{
            //    accountListWindow.grdAccounts.ItemsSource = filteredAccounts;
            //}

            //// Close the interest selection window after filtering
            //this.Close();
            grdaccount.ItemsSource = filteredAccounts;
            }
        }
    }




