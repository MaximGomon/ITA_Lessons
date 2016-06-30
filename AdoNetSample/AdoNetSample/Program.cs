using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoNetSample
{
    class Program
    {
        static void Main(string[] args)
        {
        }

        private void ReadFromBase()
        {
            var conString = ConfigurationManager.AppSettings["ConnectionString"];

            using (var connection = new SqlConnection(conString))
            {
                string commandText = @"SELECT DISTINCT
                                      e.Id, e.Name, e.Birthday, e.Email, e.Salary
                                    FROM
                                      Employees e
                                    WHERE 
                                      LEN(e.Name) > @len";
                var command = new SqlCommand(commandText);
                var parameter = new SqlParameter("@len", SqlDbType.Int);
                parameter.Value = 20;

                command.Parameters.Add(parameter);

                connection.Open();
                using (var reader = command.ExecuteReader())
                {
                    List<dynamic> dataFromDb = new List<dynamic>();
                    while (reader.Read())
                    {
                        var item = new
                        {
                            Id = int.Parse(reader[0].ToString()),
                            Name = reader[1].ToString(),
                            BirthDay = reader[2].GetType() != typeof (DBNull)
                                ? Convert.ToDateTime(reader[2])
                                : new DateTime(),
                            Email = reader[3].GetType() != typeof (DBNull)
                                ? reader[3].ToString()
                                : String.Empty,
                            Salary = reader[4].GetType() != typeof(DBNull)
                            ? reader[4].ToString()
                            : String.Empty
                        };
                        dataFromDb.Add(item);
                    }
                }
            }
        }
    }
}
