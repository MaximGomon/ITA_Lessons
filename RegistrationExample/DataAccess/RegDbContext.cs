using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DbEntity;

namespace DataAccess
{
    public class RegDbContext : DbContext
    {
        public RegDbContext() : base("dbconnection")
        {
            
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Role> Roles { get; set; }
    }
}
