using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PlayerCoachApplication.Data.Context;
using PlayerCoachApplication.Data.Models;
using PlayerCoachApplication.Models;
using System.Linq;
using System.Numerics;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;

namespace PlayerCoachApplication.Controllers
{
    public class PlayerApplicationController : Controller
    {
        private readonly PlayerApplicationDBContext _context;
        public PlayerApplicationController(PlayerApplicationDBContext context)
        {
            _context = context;
        }


        public async Task<IActionResult> Index(PlayerApplicationViewModel playerApplicationViewModel)


        {
            if (!string.IsNullOrWhiteSpace(playerApplicationViewModel.FirstName))
            {
                var playerApplicationModel = new PlayerApplicationViewModel
                {
                    FirstName = playerApplicationViewModel.FirstName,
                    LastName = playerApplicationViewModel.LastName,
                    DateOfBirth = playerApplicationViewModel.DateOfBirth,
                    PreferredPosition = playerApplicationViewModel.PreferredPosition,
                    SelectedRole = playerApplicationViewModel.SelectedRole,
                    SelectedSportName = playerApplicationViewModel.SelectedSportName,
                };
                await _context.PlayerApplicationModel.AddAsync(MapplayerData(playerApplicationViewModel));
                await _context.SaveChangesAsync();
            }
            var Position = _context.SelectedPositionToSport.ToList();

            _context.SelectedPositionToSport
                .Where(x => x.Sport == playerApplicationViewModel.SelectedSportName)
                .ToList()
                .ForEach(x => playerApplicationViewModel.Sports.Add(x.Position));
            return View(playerApplicationViewModel);
        }
        private PlayerApplicationModel MapplayerData(PlayerApplicationViewModel playerApplicationViewModel)
        {
            return new PlayerApplicationModel
            {
                FirstName = playerApplicationViewModel.FirstName,
                LastName = playerApplicationViewModel.LastName,
                DateOfBirth = playerApplicationViewModel.DateOfBirth,
                PreferredPosition = playerApplicationViewModel.PreferredPosition,
                SelectedRole = playerApplicationViewModel.SelectedRole,
                SelectedSportName = playerApplicationViewModel.SelectedSportName
            };



        }


        public async Task<IActionResult> List(string selectedSport = "")
        {
            var applicationsQuery = _context.PlayerApplicationModel
                .OrderBy(a => a.SelectedSportName)
                .AsQueryable();

            if (!string.IsNullOrWhiteSpace(selectedSport))
            {
                applicationsQuery = applicationsQuery.Where(a => a.SelectedSportName == selectedSport);
            }

            var applications = await applicationsQuery.ToListAsync();
            return View(applications);
        }
        public async Task<IActionResult> Edit(int id)
        {
            var application = await _context.PlayerApplicationModel.FindAsync(id);
            if (application == null)
            {
                return NotFound();
            }
            var Position = _context.SelectedPositionToSport.ToList();

             var footballPositions = Position
                .Where(x => x.Sport == "Football")
                .ToList();
            var basketballPositions = _context.SelectedPositionToSport
                .Where(x => x.Sport == "Basketball")
                .ToList();
            //var baseballPositions = _context.SelectedPositionToSport
            //    .Where(x => x.Sport == "Baseball")
            //    .ToList();

            var editPlayerApplicationModel = new EditPlayerApplicationModel();
            editPlayerApplicationModel.PlayerApplicationModel= application;
            editPlayerApplicationModel.FootballPositions = footballPositions.Select(x => x.Position).ToList();
            editPlayerApplicationModel.BasketballPositions = basketballPositions.Select(x => x.Position).ToList();
            editPlayerApplicationModel.BaseballPositions = _context.SelectedPositionToSport.Where(x => x.Sport == "Baseball")
                .Select(x => x.Position)
                .ToList();
            editPlayerApplicationModel.HockeyPositions = _context.SelectedPositionToSport.Where(x => x.Sport == "Hockey")
                .Select(x => x.Position)
                .ToList();
            editPlayerApplicationModel.SoccerPositions = _context.SelectedPositionToSport.Where(x => x.Sport == "Soccer")
                .Select(x => x.Position)
                .ToList();
            // .ForEach(x =>application.Sports.Add(x.Position));
            return View(editPlayerApplicationModel);
            //return View(application);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, EditPlayerApplicationModel model)
        {
            if (id != model.PlayerApplicationModel.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                _context.Update(model.PlayerApplicationModel);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(List));
            }
            return View(model);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Delete(int id)
        {
            var application = await _context.PlayerApplicationModel.FindAsync(id);
            if (application != null)
            {
                _context.PlayerApplicationModel.Remove(application);
                await _context.SaveChangesAsync();
            }
            return RedirectToAction(nameof(List));
        }
    }
}

//This code is a controller for handling player applications in an ASP.NET Core web app.
//It connects to a database and provides actions for creating, listing, editing, and deleting player applications.
//Key points:
//•	The controller uses a database context (PlayerApplicationDBContext) to access player application data.
//•	Index:
//•	If a first name is provided, it creates a new player application and saves it to the database.
//•	It also loads available positions for the selected sport and adds them to the view model.
//•	List:
//•	Shows all player applications, or only those for a selected sport.
//•	Edit (GET):
//•	Loads a player application by ID.
//•	Loads all possible positions for each sport and adds them to the model for editing.
//•	Edit (POST):
//•	Updates a player application in the database if the submitted data is valid.
//•	Delete:
//•	Removes a player application from the database.
//In short:
//This controller lets you create, view, filter, edit, and delete player applications in your web app, and manages the available positions for each sport.









