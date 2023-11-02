using Microsoft.AspNetCore.Mvc;
using Portfolio_Project.Models;
using System.Diagnostics;

namespace Portfolio_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<Projects> _projects = new List<Projects>
        {
            new Projects()
            {
                Id = 1,
                Name = "پروژه تست",
                Description = "این محصول فوق العاده برای این وب سایت طراحی و آماده شده",
                Image = "01.jpg"
            },
            new Projects()
            {
                Id = 2,
                Name = "2پروژه تست",
                Description = "2این محصول فوق العاده برای این وب سایت طراحی و آماده شده",
                Image = "02.jpg"
            },
            new Projects()
            {
                Id = 3,
                Name = "پروژه تست3",
                Description = "این محصول فوق العاده برای این وب سایت طراحی و آماده شده",
                Image = "03.jpg"
            },
            new Projects()
            {
                Id = 4,
                Name = "پروژه تست4",
                Description = "این محصول فوق العاده برای این وب سایت طراحی و آماده شده",
                Image = "04.jpg"
            }
        };

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {

            return View(_projects);
        }

        public IActionResult Privacy()
        {
            return View();
        }

        public IActionResult Create()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}