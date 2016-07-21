using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
                //context.Employees.Add(new Employee
                //{
                //    Position = context.Positions.First(x => x.Code == 1),
                //    Department = context.Departments.First(x => x.Code == 1),
                //    BirthDate = new DateTime(1976, 08, 14),
                //    FirstName = "Oleg",
                //    LastName = "Korewat",
                //    Salary = 5000.0
                //});

                //save changes from context to db
                //context.SaveChanges();

                var emp = from e in context.Employees
                    where e.FirstName.Length > 3 select e ;

                foreach (var employee in context.Employees
                    .Include(x => x.Department)
                    .Include(x => x.Position))
                {
                    Console.WriteLine(employee);
                }
                emp.ToList();
            }
            Console.ReadKey();
        }
    }
}
