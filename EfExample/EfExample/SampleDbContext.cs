using System.Data.Entity;

namespace EfExample
{
    public class SampleDbContext : DbContext
    {
        public SampleDbContext() : base("sample")
        {
            //Set db initializer for default value of dictionary on create db
            Database.SetInitializer(new SampleDbInitializer());
            Database.Initialize(true);
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
        public DbSet<Department> Departments { get; set; }
    }
}
