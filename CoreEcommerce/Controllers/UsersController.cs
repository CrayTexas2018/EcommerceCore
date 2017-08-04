using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreEcommerce.Models;

namespace CoreEcommerce.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private IUserRepository userRepository;

        public UsersController()
        {
            this.userRepository = new UserRepository(new ApplicationContext());
        }

        public UsersController(IUserRepository userRepository)
        {
            this.userRepository = userRepository;
        }

        // GET: api/Users
        [HttpGet]
        public IEnumerable<User> Get()
        {
            return userRepository.GetUsers();
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "Get")]
        public User Get(int id)
        {
            return userRepository.GetUserByID(id);
        }
        
        // POST: api/Users
        [HttpPost]
        public void Post([FromBody]User user)
        {
            userRepository.CreateUser(user);
        }
        
        // PUT: api/Users/5
        [HttpPut("{id}")]
        public void Put(User user)
        {
            userRepository.UpdateUser(user);
        }
        
        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            userRepository.DeleteUser(id);
        }
    }
}
