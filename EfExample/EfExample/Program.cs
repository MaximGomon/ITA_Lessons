using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
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
                // = Console.Out;
                ////add new employee to context
                //context.Employees.Add(new Employee
                //{
                //    Position = context.Positions.First(),
                //    Department = context.Departments.First(),
                //    BirthDate = new DateTime(1989, 12, 19),
                //    FirstName = "Oleg",
                //    LastName = "Korewat",
                //    Salary = 5000.0
                //});

                ////save changes from context to db
                //context.SaveChanges();

                IQueryable<Employee> emp = 
                        from e in context.Employees
                        where e.FirstName.Length > 3
                        select e;

                //List<Employee> empList = new List<Employee>();

                //IEnumerable<Employee> lEmp = empList.Where(x => x.Department.Code == 4);

                Employee firstEmpl = emp.FirstOrDefault();

                var empl = context.Employees
                    .Include(x => x.Department)
                    .Include(x => x.Position)
                    .FirstOrDefault();

                //foreach (var employee in context.Employees
                //    .Include(x => x.Department)
                //    .Include(x => x.Position))
                //{
                //    Console.WriteLine(employee);
                //}

                //string depName = firstEmpl?.Department.Name;
            }
            Console.ReadKey();
        }
    }
}
