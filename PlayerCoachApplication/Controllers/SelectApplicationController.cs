using Microsoft.AspNetCore.Mvc;
using PlayerCoachApplication.Models;

namespace PlayerCoachApplication.Controllers
{
    public class SelectApplicationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Index(string selectedSport, string? selectedRole = null)
        {

            var model = new SelectedSportAndRoleViewModel
            {
                SelectedSportName = selectedSport,
                SelectedRole = selectedRole
            };

            return View(model);
        }
    }
}
