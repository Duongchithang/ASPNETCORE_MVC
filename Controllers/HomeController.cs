using Microsoft.AspNetCore.Mvc;

using System.Diagnostics;

using WebApplication4.Models;

namespace WebApplication4.Controllers
{
    public class Student
    {
        public int StudentID { set; get; }
        public string StudentName { set; get; }
        public int Age { set; get; }
    }
    public class HomeController : Controller
    {


        IList<Student> studentList = new List<Student>() {

            new Student() { StudentID=1, StudentName="Steve", Age = 21 },
            new Student() { StudentID=2, StudentName="Bill", Age = 25 },
            new Student() { StudentID=3, StudentName="Ram", Age = 20 },
            new Student() { StudentID=4, StudentName="Ron", Age = 31 },
            new Student() { StudentID=5, StudentName="Rob", Age = 19 }
        };

        // GET: Student

        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }


        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Contact()
        {
            ViewBag.ToTalStudents = studentList.Count();
            return View();
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}