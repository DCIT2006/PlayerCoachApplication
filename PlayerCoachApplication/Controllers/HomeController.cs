using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using PlayerCoachApplication.Models;

namespace PlayerCoachApplication.Controllers
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
    }
}

//This code defines a controller for the home page of your web app.
//•	HomeController handles requests for the main pages.
//•	Index() shows the home page.
//•	Privacy() shows the privacy page.
//•	Error() shows an error page if something goes wrong.
//It also uses logging to help track what happens in the app.

