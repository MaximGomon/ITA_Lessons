using DbEntity;

namespace DataAccess.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<DataAccess.RegDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(DataAccess.RegDbContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //if (!context.Roles.Any(x => x.Name == "Admin"))
            //{
            //    context.Roles.AddOrUpdate(
            //        new Role { Name = "Admin", Id = Guid.NewGuid()},
            //        new Role { Name = "User", Id = Guid.NewGuid() },
            //        new Role { Name = "Trusted user", Id = Guid.NewGuid() }
            //    );
            //}
            //
        }
    }
}
