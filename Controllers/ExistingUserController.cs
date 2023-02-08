using Azure.Core;
using Microsoft.AspNetCore.Mvc;

namespace API0103.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ExistingUserController : ControllerBase
    {
        private static List<User> Users = new List<User>();

        public ExistingUserController() {
        
        }
        [HttpGet]
        public List<User> Get()
        {
            return Users;
        }

        [HttpGet("id")]
        public User GetUserData([FromBody] User reques) 
        {
            var user = Users.Single(x => x.Id == request.Id);
            user.UserName = request.UserName;
            user.Pass = request.Pass;
            user.Role = request.Role;
            return order;
        }
        [HttpDelete("id")]
        public User Delete(int id)
        {
            var order = Users.Single(x => x.Id == id);
            Users.Remove(order);
            return order;
        }

        [HttpPost]
        public User Create([FromBody] Passwords request)
        {
            var order = new User 
            {
                Id = Users.Count+1, 
                Name = request.Name, 
                Price = request.Price, 
                Created = DateTime.Now
            };
            Users.Add(order);
            return order;
        }


    }
}
