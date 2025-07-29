using Microsoft.AspNetCore.Mvc;

namespace PlayerCoachApplication.Controllers
{
    public class ApplicationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
