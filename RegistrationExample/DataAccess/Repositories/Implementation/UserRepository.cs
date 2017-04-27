using System;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using DbEntity;

namespace DataAccess.Repositories
{
    public class UserRepository : CrudRepository<User>, IUserRepository
    {
        public override IQueryable<User> Get(Expression<Func<User, bool>> predicate)
        {
            return base.Get(predicate).Include(x => x.Role);
        }

        public override User GetById(Guid id)
        {
            return Context.Set<User>().Include(x => x.Role)
                .FirstOrDefault(x => x.Id == id);
        }

        public User GetUserByLogin(string login)
        {
            return Context.Set<User>().Include(x => x.Role)
                .FirstOrDefault(x => x.Login == login);
        }

        public bool CheckLoginUnique(string login)
        {
            return !Context.Set<User>().Any(x => x.Login == login);
        }

        public UserRepository(RegDbContext context) : base(context)
        {

        }
    }
}