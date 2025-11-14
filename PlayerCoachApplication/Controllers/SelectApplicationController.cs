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
            if (selectedRole == "Coach")
            {
                return RedirectToAction("Index", "CoachApplication", model );
            }
            else if (selectedRole == "Player")
            {
                return RedirectToAction("Index", "PlayerApplication", model );
            }


            return View(model);
        }
    }
}

//This code defines a controller for selecting a sport and role in your web app.
//•	SelectApplicationController handles requests for the selection page.
//•	Index() (GET): Shows the selection page.
//•	Index() (POST): Receives the selected sport and role from the form, creates a view model with those values, and returns the view with that model.
//In short:
//This controller lets users choose a sport and (optionally) a role, then passes their choices to the view for further use.

