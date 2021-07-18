using Microsoft.Synchronization;
using Microsoft.Synchronization.Data;
using Microsoft.Synchronization.Data.SqlServer;
using Quick_CRM.Properties;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace Quick_CRM
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

        private void ServerButton_Click(object sender, RoutedEventArgs e)
        {
            (new ServerForm()).ShowDialog();
        }

        private void LocalButton_Click(object sender, RoutedEventArgs e)
        {
            (new LocalForm()).ShowDialog();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            var scopeName = "CRMScope";
            var serverConn = new SqlConnection(Settings.Default.CRMConnectionString);
            var clientConn = new SqlConnection(Settings.Default.LocalCRMConnectionString);
            var serverProvision = new SqlSyncScopeProvisioning(serverConn);
            if (!serverProvision.ScopeExists(scopeName))
            {
                var serverScopeDesc = new DbSyncScopeDescription(scopeName);
                var serverTableDesc = SqlSyncDescriptionBuilder.GetDescriptionForTable("Customer",
                   serverConn);
                serverScopeDesc.Tables.Add(serverTableDesc);
                serverProvision.PopulateFromScopeDescription(serverScopeDesc);
                serverProvision.Apply();
            }

            var clientProvision = new SqlSyncScopeProvisioning(clientConn);
            if (!clientProvision.ScopeExists(scopeName))
            {
                var clientScopeDesc = new DbSyncScopeDescription(scopeName);
                var clientTableDesc = SqlSyncDescriptionBuilder.GetDescriptionForTable("Customer",
                   clientConn);
                clientScopeDesc.Tables.Add(clientTableDesc);
                clientProvision.PopulateFromScopeDescription(clientScopeDesc);
                clientProvision.Apply();
            }

            var syncOrchestrator = new SyncOrchestrator();
            var localProvider = new SqlSyncProvider(scopeName, clientConn);
            var remoteProvider = new SqlSyncProvider(scopeName, serverConn);
            syncOrchestrator.LocalProvider = localProvider;
            syncOrchestrator.RemoteProvider = remoteProvider;
            syncOrchestrator.Direction = SyncDirectionOrder.Download;

            var syncStats = syncOrchestrator.Synchronize();

        }
    }
}
