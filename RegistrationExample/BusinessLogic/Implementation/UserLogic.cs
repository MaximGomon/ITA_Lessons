using BusinessLogic.Interfaces;
using DataAccess.Repositories;
using DbEntity;

namespace BusinessLogic.Implementation
{
    public class UserLogic : CrudLogic<User, IUserRepository>, IUserLogic
    {
        public UserLogic(IUserRepository repository) : base(repository)
        {
        }

        public User GetUserByLogin(string login)
        {
            return Repository.GetUserByLogin(login);
        }

        public bool CheckLoginUnique(string login)
        {
            return Repository.CheckLoginUnique(login);
        }
    }
}