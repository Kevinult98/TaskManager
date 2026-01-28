using Microsoft.Data.Sqlite;
using System;
using System.Data;


namespace TaskManager.Data.Database
{
    public class SqliteConnectionFactory
    {
        private readonly string _connectionString; 

        public SqliteConnectionFactory(string connectionString)
        {
            _connectionString = connectionString;
        }

        public IDbConnection CreateConnection() //siempre devuelve una conexión nueva
        {
            return new SqliteConnection(_connectionString);
        }
        public void InitializeDatabase()
        {
            using var connection = CreateConnection();
            connection.Open();

            var command = connection.CreateCommand();
            command.CommandText = @"
                        CREATE TABLE IF NOT EXISTS Tasks (
                        Id INTEGER PRIMARY KEY AUTOINCREMENT,
                        Description TEXT NOT NULL,
                        User TEXT NOT NULL,
                        Status INTEGER NOT NULL,
                        Priority INTEGER NOT NULL,
                        DueDate TEXT NOT NULL,
                        Notes TEXT,
                        IsActive INTEGER NOT NULL DEFAULT 1);";

            command.ExecuteNonQuery();
            //abstracción (Dapper trabaja con esto)
        }
    }
}
