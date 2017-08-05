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
        public ActionResult Post([FromBody]User user)
        {
            HttpResponseMessage response = new HttpResponseMessage();
            if (ModelState.IsValid)
            {
                user = userRepository.CreateUser(user);
                return Created(new Uri(Request.GetDisplayUrl() + "/" + user.userId), user);
            }
            return BadRequest(ModelState.Select(x => x.Value.Errors.ToList()));
        }
        
        // PUT: api/Users
        [HttpPut]
        public void Put([FromBody]User user)
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
