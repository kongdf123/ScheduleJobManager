using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Odbc;
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
            OleDbConnection conn = new OleDbConnection($"Provider=SQLOLEDB;PWD=;UID={txtUserName.Text};Database={txtDBName.Text};Server={txtDBServerIP.Text}");
            //OdbcConnection conn = new OdbcConnection("");
            try {
                conn.Open();
                OleDbCommand comm = new OleDbCommand(txtSqlText.Text, conn);
                //OdbcCommand comm = new OdbcCommand("SELECT COUNT(*) FROM syscolumns", conn);
                MessageBox.Show(comm.ExecuteScalar().ToString());
                conn.Close();
            }
            catch ( Exception ex ) {
                conn.Close();
                MessageBox.Show(ex.ToString());
            }
            finally {
                conn.Close();
            }
        }
    }
}
