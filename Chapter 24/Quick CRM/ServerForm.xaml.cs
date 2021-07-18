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

namespace Quick_CRM
{
    /// <summary>
    /// Interaction logic for ServerForm.xaml
    /// </summary>
    public partial class ServerForm : Window
    {
        public ServerForm()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            Quick_CRM.CRMDataSet cRMDataSet = ((Quick_CRM.CRMDataSet)(this.FindResource("cRMDataSet")));
            // Load data into the table Customer. You can modify this code as needed.
            Quick_CRM.CRMDataSetTableAdapters.CustomerTableAdapter cRMDataSetCustomerTableAdapter = new Quick_CRM.CRMDataSetTableAdapters.CustomerTableAdapter();
            cRMDataSetCustomerTableAdapter.Fill(cRMDataSet.Customer);
            System.Windows.Data.CollectionViewSource customerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerViewSource")));
            customerViewSource.View.MoveCurrentToFirst();
        }

        private void Previous_Click(object sender, RoutedEventArgs e)
        {
            System.Windows.Data.CollectionViewSource customerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerViewSource")));
            if (customerViewSource.View.CurrentPosition > 0)
                customerViewSource.View.MoveCurrentToPrevious();
        }

        private void Next_Click(object sender, RoutedEventArgs e)
        {
            Quick_CRM.CRMDataSet cRMDataSet = ((Quick_CRM.CRMDataSet)(this.FindResource("cRMDataSet")));
            System.Windows.Data.CollectionViewSource customerViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("customerViewSource")));
            if (customerViewSource.View.CurrentPosition < cRMDataSet.Customer.Count - 1)
                customerViewSource.View.MoveCurrentToNext();
        }
    }
}
