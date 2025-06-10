using Microsoft.AspNetCore.Mvc;
using PlayerCoachApplication.Data.Context;
using PlayerCoachApplication.Data.Models;
using PlayerCoachApplication.Models;

namespace PlayerCoachApplication.Controllers
{
    public class CoachApplicationController : Controller
    {
        private readonly PlayerApplicationDBContext _context;
        public CoachApplicationController(PlayerApplicationDBContext context)
        {
            _context = context;
        }
        public async Task<IActionResult> Index(CoachApplicationViewModel coachApplicationViewModel)
        {
            if (!string.IsNullOrWhiteSpace(coachApplicationViewModel.FirstName))
            {
                var coachApplicationModel = new CoachApplicationModel
                {
                    FirstName = coachApplicationViewModel.FirstName,
                    LastName = coachApplicationViewModel.LastName,
                    DateOfBirth = coachApplicationViewModel.DateOfBirth,
                    YearsOfExperience = coachApplicationViewModel.YearsOfExperience,
                    SelectedSportName = coachApplicationViewModel.SelectedSportName,
                    SelectedRole = coachApplicationViewModel.SelectedRole
                };
                await _context.CoachApplications.AddAsync(coachApplicationModel);
                await _context.SaveChangesAsync();
            }

            var model = new CoachApplicationViewModel
            {
                FirstName = coachApplicationViewModel.FirstName,
                LastName = coachApplicationViewModel.LastName,
                SelectedSportName = coachApplicationViewModel.SelectedSportName,
                SelectedRole = coachApplicationViewModel.SelectedRole,
                DateOfBirth = coachApplicationViewModel.DateOfBirth,
                YearsOfExperience = coachApplicationViewModel.YearsOfExperience,
            };
            return View(model);
        }
        



    }
}
