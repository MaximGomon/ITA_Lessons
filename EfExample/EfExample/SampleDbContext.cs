using System.Data.Entity;
using EfExample;

namespace EfSample
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext() : base("sample")
        {
            //Set db initializer for default value of dictionary on create db
            Database.SetInitializer<SampleDbContext>(new SampleDbInitializer());
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
