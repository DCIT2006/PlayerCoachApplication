using Microsoft.AspNetCore.Mvc;
using PlayerCoachApplication.Models;
using PlayerCoachApplication.Data.Context;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using PlayerCoachApplication.Data.Models;

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

             var positions = _context.SelectedPositionToSport
                .Where(x => x.Sport == application.SelectedSportName)
                .ToList();
            var temp = _context.SelectedPositionToSport
                .Where(x => x.Sport == "Basketball")
                .ToList();

            var editPlayerApplicationModel = new EditPlayerApplicationModel();
            editPlayerApplicationModel.PlayerApplicationModel= application;
            editPlayerApplicationModel.FootballPositions = positions.Select(x => x.Position).ToList();
            editPlayerApplicationModel.BasketballPositions = temp.Select(x => x.Position).ToList();
            // .ForEach(x =>application.Sports.Add(x.Position));
            return View(editPlayerApplicationModel);
            //return View(application);
        }
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, PlayerApplicationModel model)
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
       

                
        
        
   


