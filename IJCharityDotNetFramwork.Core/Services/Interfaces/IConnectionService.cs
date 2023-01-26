using System;
using System.Data.SqlClient;

namespace IJCharityDotNetFramwork.Core.Services
{
    public interface IConnectionService : IDisposable
    {
        void SaveConnectionString(string connectionName, SqlConnectionStringBuilder connectionStringBuilder);
        SqlConnectionStringBuilder connectionStringBuilder
            (
            string dataSource,
            string dbName,
            bool integratedSecurity,
            string sqlUsername,
            string sqlPassword
            );
        void EncryptConfigSection();
        void DecryptConfigSection();
    }
}
