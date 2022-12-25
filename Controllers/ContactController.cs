using Microsoft.AspNetCore.Mvc;

namespace WebApplication4.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
