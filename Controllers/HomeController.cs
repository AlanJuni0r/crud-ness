using CRUD_NESS_ALAN.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace CRUD_NESS_ALAN.Controllers
{
    public class HomeController : Controller
    {
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

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new Startup { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}