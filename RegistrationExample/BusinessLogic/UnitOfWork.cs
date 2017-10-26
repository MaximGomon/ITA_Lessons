using BusinessLogic.Implementation;
using BusinessLogic.Interfaces;
using DataAccess;
using DataAccess.Repositories;
using DbEntity;

namespace BusinessLogic
{
    public class UnitOfWork
    {
        private readonly RegDbContext _context = new RegDbContext();
        private readonly IUserLogic _userLogic;
        private readonly ICrudLogic<Role> _roleLogic;

        public UnitOfWork()
        {
            _roleLogic = new CrudLogic<Role, ICrudRepository<Role>>(new CrudRepository<Role>(_context));
            _userLogic = new UserLogic(new UserRepository(_context));
        }

        public IUserLogic User => _userLogic;
        public ICrudLogic<Role> Role => _roleLogic;
    }
}