using Microsoft.Data.SqlClient;
using FischotterFinanceManager.Envs;

namespace TaskTracker.Data;

#region Interface

public interface IDbConnectionFactory
{
    Task<SqlConnection> CreateOpenConnectionAsync();
}

#endregion Interface

public class SqlConnectionFactory(string connectionString = Envs.ConnectionString) : IDbConnectionFactory
{
    #region properties

    private readonly string _connectionString = connectionString;

    #endregion properties

    #region methods

    public async Task<SqlConnection> CreateOpenConnectionAsync()
    {
        SqlConnection sqlConnection = new(_connectionString);
        await sqlConnection.OpenAsync();
        return sqlConnection;
    }

    #endregion methods
}