using Microsoft.AspNetCore.Mvc;
using UserStore.Core;
using System.Threading.Tasks;

namespace WebAPIWithMongoDB.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UsersController : ControllerBase
    {
        private readonly IUserService userService;
        public UsersController(IUserService _userService)
        {
            userService = _userService;
        }

        [HttpGet]
        public ActionResult<IEnumerable<User>> GetAllUsers()
        {
            return Ok(userService.GetAllUsers());
        }

        [HttpGet("{Id}", Name = "GeUser")]
        public ActionResult<User> GetUser(int Id)
        {
            return Ok(userService.GetUser(Id));
        }


        [HttpPost]

        public ActionResult<User> EditUser(User user)
        {
            userService.EditUser(user);
            return CreatedAtRoute("GetUser", new { Id = user.Id }, user);
        }

        [HttpDelete("{Id}")]
        public ActionResult DeleteUser(int id)
        {
            userService.DeleteUser(id);
            return NoContent();
        }


    }
}


