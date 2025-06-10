using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCoachApplication.Data.Models
{
    public class CoachApplicationModel
    {
        public int? Id { get; set; } = null;
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? YearsOfExperience { get; set; }
        public string? SelectedSportName { get; set; }
        public string? SelectedRole { get; set; }

    }
}
