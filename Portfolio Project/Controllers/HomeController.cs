using Microsoft.AspNetCore.Mvc;
using Portfolio_Project.Models;
using System.Diagnostics;

namespace Portfolio_Project.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly List<Projects>

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
        public IActionResult GetJsonDataTest()
        {
            var myList = new List<string>();
            myList.Add("Ali");
            myList.Add("Mohammad");
            myList.Add("Reaza");
            myList.Add("Nazanin");
            myList.Add("Neda");
            myList.Add("Parastoo");

            return Json(new { myList });
        }

        public IActionResult Shop()
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