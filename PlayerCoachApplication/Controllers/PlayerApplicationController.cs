using Microsoft.AspNetCore.Mvc;
using PlayerCoachApplication.Models;
using PlayerCoachApplication.Data.Context;
using System.Linq;

namespace PlayerCoachApplication.Controllers
{
    public class PlayerApplicationController : Controller
    {
        private readonly PlayerApplicationDBContext _context;
        public PlayerApplicationController(PlayerApplicationDBContext context)
        {
            _context = context;
        }

       
        public IActionResult Index(PlayerApplicationViewModel Model)
        {
            var model = new PlayerApplicationViewModel
            {
               FirstName = Model.FirstName,
               LastName = Model.LastName,
               DateOfBirth = Model.DateOfBirth,
               PreferredPosition = Model.PreferredPosition,
               SelectedRole = Model.SelectedRole,
               SelectedSportName = Model.SelectedSportName,
            };
            var Position =_context.SelectedPositionToSport.ToList();
            
            _context.SelectedPositionToSport
                .Where(x => x.Sport == model.SelectedSportName)
                .ToList()
                .ForEach(x => model.Sports.Add(x.Position));
            return View(model);
        }
    }
}
