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

namespace CSWpfApplication
{
    /// <summary>
    /// Interaction logic for DragAndDropBinding.xaml
    /// </summary>
    public partial class DragAndDropBinding : Window
    {
        public DragAndDropBinding()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

        }

        private void Window_Loaded_1(object sender, RoutedEventArgs e)
        {

            System.Windows.Data.CollectionViewSource contactViewModelViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("contactViewModelViewSource")));
            // Load data by setting the CollectionViewSource.Source property:
            // contactViewModelViewSource.Source = [generic data source]
        }
    }
}
