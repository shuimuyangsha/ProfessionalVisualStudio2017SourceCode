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

        private void btnSayHello_Click_1(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("Hello " + txtSayHello.Text);
        }

        #endregion


        public void Main()
        {
            var assignedAccounts = new List<Account>();

            foreach (Account account in assignedAccounts)
            {
                account.BeginEdit();
                account.DivisionId = 0;
                account.BranchId = 0;
                account.CostCentreId = 0;
                account.EndEdit();
            }

        }

    }
}
