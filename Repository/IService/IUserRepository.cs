using System.Collections.Generic;
using BaseWebApiCore.Models;

namespace BaseWebApiCore.Repository.IService
{
    public interface IUserRepository
    {
         User GetUser(long id);
         IEnumerable<User> GetAllUsers();
         User AddUser(User user);
         User UpdateUser(User user);
         User DeleteUser(long id);
    }
}