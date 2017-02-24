using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExampleWithEntityFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (var context = new OrganizationDbContext())
                {
                    context.Employees.Add(new Employee
                    {
                        Position = context.Positions.OrderBy(x => x.Id).First(),
                        Name = "Max",
                        Birthdate = new DateTime(1991, 11,19),
                        IsMan = true
                    });
                    context.SaveChanges();
                }
                Console.WriteLine("All good");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
            Console.ReadKey();
        }
    }
}
