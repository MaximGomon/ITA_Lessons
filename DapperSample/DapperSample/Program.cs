using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;

namespace DapperSample
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch t = new Stopwatch();

            t.Start();
            var result = QueryData<StudentDetailed>(ResolveQueryByName("students.detailed.get.all"));
            t.Stop();

            DisplayResult(result);

            Console.WriteLine(t.ElapsedMilliseconds);
            t.Start();
            var searchResult = QueryData<StudentDetailed>(ResolveQueryByName("students.detailed.get.by.id"), new { SearchId = 2 });
            t.Stop();

            DisplayResult(searchResult);
            Console.WriteLine(t.ElapsedMilliseconds);

            t.Start();
            var fullSearchResult = QueryData<StudentDetailed>(
                ResolveQueryByName("students.detailed.search"), 
                new
                {
                    SearchId = 3,
                    SearchCourse = "Programming"
                });
            t.Stop();

            DisplayResult(fullSearchResult);
            Console.WriteLine(t.ElapsedMilliseconds);
            Console.ReadKey();
        }

        private static IEnumerable<T> QueryData<T>(string query, object parameters = null)
        {
            string connectionString = ConfigurationManager.AppSettings["dbconnection"];

            using (var connection = new SqlConnection(connectionString))
            {
                connection.Open();
                return connection.Query<T>(query, parameters, commandType: CommandType.Text);
            }
        }

        private static void DisplayResult<T>(IEnumerable<T> result)
        {
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
        }

        private static string ResolveQueryByName(string queryName)
        {
            var currentDirectory = Directory.GetCurrentDirectory();
            var sqlDirectory = Path.Combine(currentDirectory, "sql");
            if (!Directory.Exists(sqlDirectory))
                throw new DirectoryNotFoundException($"Can`t find directory: {sqlDirectory}");

            var fileName = $"{queryName}.sql";
            var fullFilePath = Path.Combine(sqlDirectory, fileName);
            if (!File.Exists(fullFilePath))
                throw new FileNotFoundException($"Can`t find file: {fullFilePath}");

            return File.ReadAllText(fullFilePath);
        }
    }
}
