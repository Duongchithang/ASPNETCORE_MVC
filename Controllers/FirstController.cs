using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class FirstController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        [AcceptVerbs("POST", "GET")]
        public IActionResult Contact()
        {
            return View();
        }
    }
}
