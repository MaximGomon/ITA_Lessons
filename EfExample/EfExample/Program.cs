using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EfSample;

namespace EfExample
{
    class Program
    {
        static void Main(string[] args)
        {
            
            //using context for doing something with db
            using (var context = new SampleDbContext())
            {
                //add new employee to context
                context.Employees.Add(new Employee
                {
                    Position = context.Positions.First(x => x.Code == 1),
                    Department = context.Departments.First(x => x.Code == 1),
                    BirthDate = new DateTime(1976, 08, 14),
                    FirstName = "Oleg",
                    LastName = "Korewat",
                    Salary = 5000.0
                });

                //save changes from context to db
                context.SaveChanges();

                foreach (var employee in context.Employees)
                {
                    Console.WriteLine(employee);
                }
            }
            Console.ReadKey();
        }
    }
}
