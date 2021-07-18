using System;
using System.Windows;

namespace CSWpfApp
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            string connectionString = Properties.Settings.Default.ConnectionString;
            connectionString = NewMethod(connectionString);
            MessageBox.Show(connectionString);
            /* ... Much longer method ... */
        }

        private static string NewMethod(string connectionString)
        {
            if (connectionString == null)
            {
                connectionString = "DefaultConnectionString";
            }

            return connectionString;
        }
    }

}
