using IJCharityDotNetFramwork.Core.Services;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace IJCharityDotNetFramwork.App.SettingsForm
{
    public partial class DbConnectionsForm : Form
    {
        private readonly IConnectionService _connectionService;

        public DbConnectionsForm()
        {
            InitializeComponent();
            _connectionService = new ConnectionService();
        }

        private void btnOpenStartupPath_Click(object sender, EventArgs e)
        {
            string path = Path.Combine(Application.StartupPath, "PrintFiles");
            Process.Start(path);
        }

        private void btnSaveSettings_Click(object sender, EventArgs e)
        {
            string error = "خطا در مقادیر ورودی";

            if (!String.IsNullOrWhiteSpace(txtServerAddress.Text)
                && !String.IsNullOrWhiteSpace(comboDbAnbar.Text)
                && !String.IsNullOrWhiteSpace(comboDbManategh.Text)
                && !String.IsNullOrWhiteSpace(comboDbNozorat.Text)
                && !String.IsNullOrWhiteSpace(comboDbOffice.Text))
            {
                if (ConnectionStringIsValid(txtServerAddress.Text, checkSqlAuth.Checked,
                txtSqlUserName.Text, txtSqlPassword.Text, comboDbAnbar.Text,
                comboDbManategh.Text, comboDbNozorat.Text, comboDbOffice.Text)
                    )
                {
                    Application.Restart();
                }
                MessageBox.Show(error);
            }

            else
            {
                MessageBox.Show(error);
            }


            bool ConnectionStringIsValid(string serverAddress, bool checkSqlAuth, string sqlUserName, string sqlPassword, string dbNameAnbar, string dbNameManategh, string dbNameNozorat, string dbNameOffice)
            {
                SqlConnectionStringBuilder connectionStringAnbar = null;
                SqlConnectionStringBuilder connectionStringManategh = null;
                SqlConnectionStringBuilder connectionStringNozorat = null;
                SqlConnectionStringBuilder connectionStringOffice = null;

                if (checkSqlAuth)
                {
                    if (!String.IsNullOrWhiteSpace(txtSqlUserName.Text)
                        && !String.IsNullOrWhiteSpace(txtSqlPassword.Text))
                    {
                        connectionStringAnbar = _connectionService.connectionStringBuilder(
                           serverAddress,
                           dbNameAnbar,
                           !checkSqlAuth,
                           sqlUserName,
                           sqlPassword);

                        connectionStringManategh = _connectionService.connectionStringBuilder(
                           serverAddress,
                           dbNameManategh,
                            !checkSqlAuth,
                           sqlUserName,
                           sqlPassword);

                        connectionStringNozorat = _connectionService.connectionStringBuilder(
                           serverAddress,
                           dbNameNozorat,
                           !checkSqlAuth,
                           sqlUserName,
                           sqlPassword);

                        connectionStringOffice = _connectionService.connectionStringBuilder(
                           serverAddress,
                          dbNameOffice,
                          !checkSqlAuth,
                           sqlUserName,
                           sqlPassword);
                    }
                }
                else
                {
                    connectionStringAnbar = _connectionService.connectionStringBuilder(
                           serverAddress,
                           dbNameAnbar,
                           !checkSqlAuth,
                           sqlUserName,
                           sqlPassword);

                    connectionStringManategh = _connectionService.connectionStringBuilder(
                       serverAddress,
                       dbNameManategh,
                        !checkSqlAuth,
                       sqlUserName,
                       sqlPassword);

                    connectionStringNozorat = _connectionService.connectionStringBuilder(
                       serverAddress,
                       dbNameNozorat,
                       !checkSqlAuth,
                       sqlUserName,
                       sqlPassword);

                    connectionStringOffice = _connectionService.connectionStringBuilder(
                       serverAddress,
                      dbNameOffice,
                      !checkSqlAuth,
                       sqlUserName,
                       sqlPassword);
                }

                try
                {
                    _connectionService.SaveConnectionString("NozoratContext", connectionStringNozorat);
                    _connectionService.SaveConnectionString("OfficeContext", connectionStringOffice);
                    _connectionService.SaveConnectionString("AnbarContext", connectionStringAnbar);
                    _connectionService.SaveConnectionString("ManateghContext", connectionStringManategh);
                    return true;
                }
                catch (Exception)
                {
                    return false;
                }

            }

        }

        private void checkSqlAuth_CheckedChanged(object sender, EventArgs e)
        {
            if (checkSqlAuth.Checked)
            {
                txtSqlUserName.Enabled = true;
                txtSqlPassword.Enabled = true;
            }
            else
            {
                txtSqlUserName.Enabled = false;
                txtSqlPassword.Enabled = false;
                txtSqlPassword.Text = "";
            }
        }

        private void txtServerAddress_Leave(object sender, EventArgs e)
        {
            if (!String.IsNullOrWhiteSpace(txtServerAddress.Text))
            {
                SqlConnectionStringBuilder connectionString = new SqlConnectionStringBuilder
                {
                    DataSource = txtServerAddress.Text,
                    IntegratedSecurity = !checkSqlAuth.Checked,
                    UserID = txtSqlUserName.Text,
                    Password = txtSqlPassword.Text
                };

                List<string> GetDatabaseList(string newconnectionString)
                {
                    List<string> list = new List<string>();

                    using (SqlConnection con = new SqlConnection(newconnectionString))
                    {

                        try
                        {
                            con.Open();

                            // Set up a command with the given query and associate
                            // this with the current connection.
                            using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases where database_id>4 order by name", con))
                            {
                                using (IDataReader dr = cmd.ExecuteReader())
                                {
                                    while (dr.Read())
                                    {
                                        list.Add(dr[0].ToString());
                                    }
                                }
                            }
                        }
                        finally
                        {
                            con.Close();
                        }
                        return list;
                    }
                }

                try
                {
                    comboDbAnbar.DataSource = GetDatabaseList(connectionString.ToString());
                    comboDbManategh.DataSource = GetDatabaseList(connectionString.ToString());
                    comboDbNozorat.DataSource = GetDatabaseList(connectionString.ToString());
                    comboDbOffice.DataSource = GetDatabaseList(connectionString.ToString());
                }
                catch (Exception)
                {
                    MessageBox.Show("خطا در اتصال به سرور");
                }

            }

        }
    }
}
