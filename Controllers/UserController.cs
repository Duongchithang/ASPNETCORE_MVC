using Microsoft.AspNetCore.Mvc;

using WebApplication4.Services;

namespace WebApplication4.Controllers
{
    public class UserController : Controller
    {
        public readonly UserService userService;

        public UserController(UserService _userService)
        {

            userService = _userService;
        }
        public IActionResult Index()
        {
            var user = userService.GetUser();
            return View(user);
        }
    }
}
