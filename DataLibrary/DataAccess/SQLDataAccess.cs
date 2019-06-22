using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace DataLibrary.DataAccess
{
    public static class SQLDataAccess
    {
        public static string getConnectionString(string connectionName = "MoodTrackerDB")
        {
            return ConfigurationManager.ConnectionStrings[connectionName].ConnectionString;
        }

        public static List<T> LoadData<T> (string sql)
        {
            using (IDbConnection cnn = new SqlConnection(getConnectionString()))
            {
                return cnn.Query<T>(sql).ToList();
            }
        }

        //Returns number of rows affected
        public static int SaveData<T>(string sql, T data)
        {
            using (IDbConnection cnn = new SqlConnection(getConnectionString()))
            {
                // Should Return 1 row affected on success
                return cnn.Execute(sql, data);
            }
        }
    }
}
