using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanArchitecture.Common.Config.App
{
    public static class EnvironmentVariables
    {


        public static string GetDatabaseConnection()
        {
            List<string> parameters = new List<string>();


            string? server = Environment.GetEnvironmentVariable("ATLAS_DB_HOST");
            string? database = Environment.GetEnvironmentVariable("HCM_IMP_DB_NAME");
            string? user = Environment.GetEnvironmentVariable("ATLAS_DB_USER");
            string? password = Environment.GetEnvironmentVariable("ATLAS_DB_PASSWORD");
            string? port = Environment.GetEnvironmentVariable("ATLAS_DB_PORT");



            parameters.Add($"Server={server}");
            parameters.Add($"Database={database}");
            parameters.Add($"User Id={user}");
            parameters.Add($"Password={password}");

            var connectionString = $"data source={server};initial catalog={database};persist security info=True;user id={user};password={password};MultipleActiveResultSets=True;pooling = true; min pool size = 100;max pool size = 200;";


            return connectionString;
        }
    }
}
