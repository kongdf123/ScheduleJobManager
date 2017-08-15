using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
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

namespace TestSqlServerConnect
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow() {
            InitializeComponent();
        }

        private void TestBtn_Click(object sender, RoutedEventArgs e) {
            string connectionStr = ConfigurationManager.AppSettings["SqlServer70"];
            OleDbConnection conn = new OleDbConnection(connectionStr);
            try {
                conn.Open();
                OleDbCommand comm = new OleDbCommand("SELECT COUNT(*) FROM syscolumns", conn);
                MessageBox.Show(comm.ExecuteScalar().ToString());
                conn.Close();
            }
            catch ( Exception ex ) {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
