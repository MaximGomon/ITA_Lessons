using System.Runtime.CompilerServices;
using DbEntity;

namespace DataAccess.Repositories
{
    public interface IUserRepository : ICrudRepository<User>
    {
        User GetUserByLogin(string login);
        bool CheckLoginUnique(string login);
    }
}