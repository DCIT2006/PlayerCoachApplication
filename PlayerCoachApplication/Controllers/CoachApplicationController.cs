using Microsoft.AspNetCore.Mvc;
using PlayerCoachApplication.Models;

namespace PlayerCoachApplication.Controllers
{
    public class CoachApplicationController : Controller
    {

        public IActionResult Index(CoachApplicationViewModel Model)
        {
            var model = new CoachApplicationViewModel
            {
                FirstName = Model.FirstName,
                LastName = Model.LastName,
                SelectedSportName = Model.SelectedSportName,
                SelectedRole = Model.SelectedRole,
                DateOfBirth = Model.DateOfBirth,
                YearsOfExperience = Model.YearsOfExperience,
            };
            return View(model);
        }



    }
}
