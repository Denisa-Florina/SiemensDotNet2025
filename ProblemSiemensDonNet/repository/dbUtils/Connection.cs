using System.Configuration;
using System.Data.SQLite;
using System;
using System.Data;

namespace ProblemSiemensDonNet.repository.dbUtils;

public class Connection
{
    private static SQLiteConnection _connection; 

    private Connection() { }

    /// <summary>
    /// Returns a singleton instance of the SQLite database connection.
    /// </summary>
    /// <remarks>
    /// If the connection does not already exist, it creates a new one using the connection string 
    /// specified in the application's configuration file under the name "SQLiteConnectionString".
    /// The connection is opened before being returned.
    /// </remarks>
    /// <returns>An open connection to the database.</returns>
    public static SQLiteConnection GetConnection()
    {

        if (_connection == null)
        {
            string connectionString = ConfigurationManager.ConnectionStrings["SQLiteConnectionString"].ConnectionString;

            _connection = new SQLiteConnection(connectionString);
            _connection.Open();
        }

        return _connection;
    }
}