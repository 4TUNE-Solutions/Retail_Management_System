using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using Dapper;
using Microsoft.Extensions.Configuration;

namespace API.Library.Internal.DataAccess
{
    public class SqlDataAccess
    {
        private string _connectionString = string.Empty;

        public string GetConnectionString(string name)
        {
            var path = Path.Combine(Directory.GetCurrentDirectory(), "appsettings.json");
            var root = new ConfigurationBuilder()
                .AddJsonFile(path, false)
                .AddEnvironmentVariables()
                .Build();

            _connectionString = root.GetSection("ConnectionStrings").GetSection(name).Value;
            var appSetting = root.GetSection("ApplicationSettings");

            return _connectionString;
        }

        public void SetData<T>(string storedProcedure, T parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public List<T> LoadData<T, U>(string storedProcedure, U parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                List<T> rows = connection.Query<T>(storedProcedure, parameters,
                    commandType: CommandType.StoredProcedure).ToList();

                return rows;
            }
        }

        public void DeleteData<U>(string storedProcedure, U parameters, string connectionStringName)
        {

            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }

        public void ChangeData<T>(string storedProcedure, T parameters, string connectionStringName)
        {
            string connectionString = GetConnectionString(connectionStringName);

            using (IDbConnection connection = new SqlConnection(connectionString))
            {
                connection.Execute(storedProcedure, parameters, commandType: CommandType.StoredProcedure);
            }
        }
    }
}
