using DbEntity;

namespace BusinessLogic.Interfaces
{
    public interface IUserLogic : ICrudLogic<User>
    {
        /// <summary>
        /// Get user from database by login
        /// </summary>
        /// <param name="login">Login of user that need to find</param>
        /// <returns>User with same login if exists or null if not exists</returns>
        User GetUserByLogin(string login);
        bool CheckLoginUnique(string login);
    }
}