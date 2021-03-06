using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using CoreEcommerce.Models;
using Microsoft.EntityFrameworkCore;
using System.Net.Http;
using System.Text;
using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Authorization;

namespace CoreEcommerce.Controllers
{
    [Produces("application/json")]
    [Route("api/Users")]
    public class UsersController : Controller
    {
        private ApplicationContext context;
        private IUserRepository userRepository;

        public UsersController(ApplicationContext context)
        {
            this.userRepository = new UserRepository(context);
            this.context = context;
        }

        // GET: api/Users
        [HttpGet(Name = "GetUsers")]
        public IEnumerable<User> Get()
        {
            return userRepository.GetUsers();
        }

        // GET: api/Users/5
        [HttpGet("{id}", Name = "GetUsersID")]
        public User Get(int id)
        {
            return userRepository.GetUserByID(id);
        }

        // POST: api/Users
        [HttpPost(Name = "PostUsers")]
        public ActionResult Post([FromBody]User user)
        {
            if (ModelState.IsValid)
            {
                user = userRepository.CreateUser(user);
                return Created(new Uri(Request.GetDisplayUrl() + "/" + user.userId), user);
            }
            return BadRequest(ModelState.Select(x => x.Value.Errors.ToList()));
        }

        // PUT: api/Users
        [HttpPut(Name = "PutUsers")]
        public void Put([FromBody]User user)
        {
            userRepository.UpdateUser(user);
        }

        // DELETE: api/ApiWithActions/5
        [HttpDelete("{id}", Name = "DeleteUser")]
        public void Delete(int id)
        {
            userRepository.DeleteUser(id);
        }

        [HttpPost(Name = "AuthUser")]
        [Route("Auth")]
        public bool Auth([FromQuery] string email, [FromQuery] string password)
        {
            return userRepository.Authenticate(email, password);
        }
    }
}
