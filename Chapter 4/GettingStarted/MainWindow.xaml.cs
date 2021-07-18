using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace GettingStarted
{
    public partial class MainWindow : Window
    {
        #region Constructor

        /// <summary>
        /// Constructs the MainWindow page
        /// </summary>
        public MainWindow()
        {
            InitializeComponent();
            
        }

        #endregion

        #region Event Handlers

        #region Helpers

        private void BindAccountDetailsToForm(Account account)
        {
            isBindingData = true;

            account.EnableValidation();
            GetAccountDetails(accountId);
            currentAccount = account;
            DataContext = currentAccount;
        }

        private void GetAccountDetails(int accountId)
        { }

        #endregion

        private bool isBindingData = false;
        private Account currentAccount;

        private void btnSayHello_Click_1(object sender, RoutedEventArgs e)
        {
            HelperClass helper = new HelperClass();
            var result = helper.MoreHelpWithNumbers(2, 3, 4);
            MessageBox.Show(result.ToString());

            int accountId = 0;
            var assignedAccounts = new List<Account>();

            foreach (Account account in assignedAccounts)
            {
                account.BeginEdit();
                account.DivisionID = 0;
                account.BranchID = 0;
                account.CostCentreID = 0;
                account.EndEdit();


                // Now that the dictionary has been retrieved, we 
                // need to get the account definition
                if (accountId != 0)
                    GetAccountDetails(accountId);
                else
                    BindAccountDetailsToForm(account);

            }
        }

        #endregion

    }
}
