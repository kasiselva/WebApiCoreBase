using BaseWebApiCore.Data;
using BaseWebApiCore.Models;
using BaseWebApiCore.Repository.IService;
using System.Collections.Generic;
using System.Linq;

namespace BaseWebApiCore.Repository.Service
{
    public class UserRepository : IUserRepository
    {
         private DataContext _dataContext;

        public UserRepository(DataContext context)
        {
            _dataContext = context;
        }
        public User GetUser(long id)
        {
            return _dataContext.User.FirstOrDefault(ii=>ii.Id ==id);
        }
        public IEnumerable<User> GetAllUsers()
        {
            return _dataContext.User.ToList();
        }
        public User AddUser(User user)
        {
            _dataContext.Add(user);
            _dataContext.SaveChanges();
            return user;
        }
        public User UpdateUser(User user)
        {
            var userdetail = _dataContext.User.Attach(user);
            userdetail.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            _dataContext.SaveChanges();
            return user;
        }
        public User DeleteUser(long id)
        {
            User user = _dataContext.User.Find(id);
            if(user != null)
            {
                _dataContext.Remove(user);
                _dataContext.SaveChanges();
            }
            return user;
        }
    }
}