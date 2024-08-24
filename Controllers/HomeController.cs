using Microsoft.AspNetCore.Mvc;
using MiParcialitoC.Models;
using System.Diagnostics;

namespace MiParcialitoC.Controllers
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
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
        [HttpPost]
        public IActionResult Login(string email, string password, bool remember)
        {
            // Perform login logic here (e.g., authenticate user)

            // Redirect to another action/controller after successful login
            return RedirectToAction("Index", "Home");
        }
    }
}
