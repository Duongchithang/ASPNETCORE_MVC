using Microsoft.AspNetCore.Mvc;

using WebApplication4.Services;

namespace WebApplication4.Controllers
{

    public class PlanetController : Controller
    {
        public readonly PlanetService _planetService;
        public PlanetController(PlanetService planetService)
        {
            _planetService = planetService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [BindProperty(SupportsGet = true, Name = "action")]
        public string Name { get; set; }
        [HttpGet("/sao-moc")]
        public IActionResult Mercury()
        {
            var planet = _planetService.Where(p => p.Name == Name).FirstOrDefault();
            return View("Detail", planet);
        }
        [Route("hanhtinh/{id:int}")]
        public IActionResult PlanetSTT(int id)
        {
            var planet = _planetService.Where(p => p.Id == id).FirstOrDefault();
            return View("Detail", planet);
        }
    }
}
