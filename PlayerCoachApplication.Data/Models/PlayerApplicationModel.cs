using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCoachApplication.Data.Models
{
    public class PlayerApplicationModel
    {
        public int Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public string? PreferredPosition { get; set; }
        public string? SelectedSportName { get; set; }
        public string? SelectedRole { get; set; }

        
    }
}
