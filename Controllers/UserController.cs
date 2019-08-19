using System.Collections.Generic;
using System.Linq;
using BaseWebApiCore.Data;
using BaseWebApiCore.Models;
using BaseWebApiCore.Repository.IService;
using Microsoft.AspNetCore.Mvc;

namespace BaseWebApiCore.Controllers
{
     [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserRepository _userRepository;

        public UserController(IUserRepository userRepository)
        {
            _userRepository = userRepository;
        }

        // GET api/values
        [HttpGet]
        public IEnumerable<User> GetAllUser()
        {
            return _userRepository.GetAllUsers();
        }
        [HttpGet("{id}")]
        public User GetUser(long id)
        {
            return _userRepository.GetUser(id);
        }

        [HttpPost("/AddUser")]
        public User AddUser(User user)
        {
            return _userRepository.AddUser(user);
        }
        [HttpPost("/UpdateUser")]
        public User UpdateUser(User user)
        {
            return _userRepository.UpdateUser(user);
        }

        [HttpDelete("/DeleteUser/{id}")]
        public User DeleteUser(long id)
        {
            return _userRepository.DeleteUser(id);
        }
    }
}