using System.Data.Entity;

namespace ExampleWithEntityFramework
{
    public class OrganizationDbContext : DbContext
    {
        public OrganizationDbContext() : base ("DbConnection")
        {
            
        }

        public DbSet<Employee> Employees { get; set; }
        public DbSet<Position> Positions { get; set; }
    }
}