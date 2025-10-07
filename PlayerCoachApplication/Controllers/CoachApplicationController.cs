using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using PlayerCoachApplication.Data.Context;
using PlayerCoachApplication.Data.Models;
using PlayerCoachApplication.Models;
using System.Collections.Generic;

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
                await _context.CoachApplicationModel.AddAsync(coachApplicationModel);
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
                Sports = await _context.SelectedPositionToSport
                    .Select(x => x.Sport)
                    .Distinct()
                    .OrderBy(s => s)
                    .ToListAsync()
            };
            return View(model);
        }
        public async Task<IActionResult> List(string selectedSport = "")
        {
            var applicationsQuery = await _context.CoachApplicationModel
                .OrderBy(a => a.SelectedSportName)
                .ToListAsync();

            if (!string.IsNullOrWhiteSpace(selectedSport))
            {
                applicationsQuery = (List<CoachApplicationModel>)applicationsQuery.Where(a => a.SelectedSportName == selectedSport);
            }
            //var applications = new List<CoachApplicationModel>();
            //try
            //{
            //    applications = await applicationsQuery.ToListAsync();
            //}
            //catch (Exception ex)
            //{
            //    // Log the exception (you can use a logging framework here)
            //    Console.WriteLine($"An error occurred while fetching applications: {ex.Message}");
            //}
            //var applications = await applicationsQuery.ToListAsync();
            return View(applicationsQuery);
        }


        //public async Task<IActionResult> List(string SportsName)
        //{
        //    var applications = await _context.CoachApplicationModel
        //        .OrderBy(a => a.SelectedSportName)
        //        .ToListAsync();
        //    return View(applications);
        //}

        public async Task<IActionResult> FilteredList(string sport)
        {
            var sports = await _context.CoachApplicationModel
                .Select(a => a.SelectedSportName)
                .Distinct()
                .OrderBy(s => s)
                .ToListAsync();

            var applicationsQuery = _context.CoachApplicationModel.AsQueryable();
            if (!string.IsNullOrEmpty(sport))
            {
                applicationsQuery = applicationsQuery.Where(a => a.SelectedSportName == sport);
            }
            var applications = await applicationsQuery
                .OrderBy(a => a.SelectedSportName)
                .ToListAsync();

            ViewBag.Sports = sports;
            ViewBag.SelectedSport = sport;

            return View(applications);
        }

        public async Task<IActionResult> Edit(int id)
        {
            var application = await _context.CoachApplicationModel.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }

            // Get sports from database or a static list
            var sports = await _context.SelectedPositionToSport
                .Select(x => x.Sport)
                .Distinct()
                .OrderBy(s => s)
                .ToListAsync();
            ViewBag.Sports = sports;
            

            return View(application);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, CoachApplicationModel model)
        {
            if (id != model.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(model);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var application = await _context.CoachApplicationModel.FindAsync(id);
            if (application != null)
            {
                _context.CoachApplicationModel.Remove(application);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(List));
        }
    }
}

//•	The controller uses a database context (PlayerApplicationDBContext) to access coach application data.
//•	Index: Adds a new coach application if a first name is provided, then shows the form.
//•	List: Shows all coach applications, or only those for a selected sport.
//•	FilteredList: Shows applications filtered by sport, and provides a list of available sports.
//•	Edit: Lets you edit an existing coach application.
//•	Delete: Removes a coach application from the database.
//In short:
//This controller lets you create, view, filter, edit, and delete coach applications in your web app.



