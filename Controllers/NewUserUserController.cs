using Microsoft.AspNetCore.Mvc;

namespace API0103.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NewUserUserController : ControllerBase
    {
        private readonly INewUserRepository _taskRepository;

        public NewUserUserController(INewUserRepository taskRepository)
        {
            _taskRepository = taskRepository;
        }

        [HttpGet("id")]
        public NewUser GetUserData([FromQuery] int id)
        {
            return Users.Single(o => o.Id == id);
        }

        [HttpPost]
        public NewUser Create([FromBody] NewUser request)
        {
            var order = new User
            {
                Id = Users.Count + 1,
                Name = request.Name,
                Price = request.Price,
                Created = DateTime.Now
            };
            Users.Add(order);
            return order;
        }
}
