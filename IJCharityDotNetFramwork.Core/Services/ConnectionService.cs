using System.Configuration;
using System.Data.SqlClient;

namespace IJCharityDotNetFramwork.Core.Services
{
    public class ConnectionService : IConnectionService
    {
        private readonly Configuration _config;

        public ConnectionService()
        {
            _config = ConfigurationManager.
                OpenExeConfiguration(ConfigurationUserLevel.None);
        }

        public void SaveConnectionString(string connectionName, SqlConnectionStringBuilder connectionStringBuilder)
        {
            try
            {

                ConnectionStringsSection section =
                    _config.GetSection("connectionStrings")
                    as ConnectionStringsSection;

                //Decrypt connection String Section
                if (section.SectionInformation.IsProtected)
                {
                    //note: Remove encryption.
                    section.SectionInformation.UnprotectSection();
                }

                var connectionStringsSection = (ConnectionStringsSection)_config.GetSection("connectionStrings");
                connectionStringsSection.ConnectionStrings[connectionName].ConnectionString = connectionStringBuilder.ConnectionString;
                _config.Save();

                ConfigurationManager.RefreshSection("connectionStrings");
            }
            finally
            {
                EncryptConfigSection();
            }
        }

        public void Dispose()
        {
            this.Dispose();
        }

        //public void ToggleConfigEncryption()
        //{
        //    //note: Open the configuration file and retrieve
        //    //note: the connectionStrings section.

        //    ConnectionStringsSection section =
        //        _config.GetSection("connectionStrings")
        //        as ConnectionStringsSection;

        //    if (section.SectionInformation.IsProtected)
        //    {
        //        //note: Remove encryption.
        //        section.SectionInformation.UnprotectSection();
        //    }
        //    else
        //    {
        //        //note: Encrypt the section.
        //        section.SectionInformation.ProtectSection(
        //            "DataProtectionConfigurationProvider");
        //    }
        //    //note: Save the current configuration.
        //    _config.Save();

        //}

        public void EncryptConfigSection()
        {
            ConnectionStringsSection section =
                _config.GetSection("connectionStrings")
                as ConnectionStringsSection;

            section.SectionInformation.ProtectSection(
                   "DataProtectionConfigurationProvider");
            _config.Save();
        }

        public void DecryptConfigSection()
        {
            ConnectionStringsSection section =
                _config.GetSection("connectionStrings")
                as ConnectionStringsSection;

            section.SectionInformation.UnprotectSection();
            _config.Save();
        }

        public SqlConnectionStringBuilder connectionStringBuilder(string dataSource, string dbName, bool integratedSecurity, string sqlUsername, string sqlPassword)
        {
            SqlConnectionStringBuilder sqlConnectionStringBuilder = new SqlConnectionStringBuilder()
            {
                DataSource = dataSource,
                InitialCatalog = dbName,
                IntegratedSecurity = integratedSecurity,
                UserID = sqlUsername,
                Password = sqlPassword,
                MultipleActiveResultSets = true,
                ApplicationName = "EntityFramework"
            };

            return sqlConnectionStringBuilder;
        }
    }
}

