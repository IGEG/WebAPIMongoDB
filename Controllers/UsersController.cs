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
          



    }
}


