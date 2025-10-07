using Microsoft.Extensions.Options;
using System.ComponentModel.DataAnnotations;

namespace PlayerCoachApplication.Models
{
    public class CoachApplicationViewModel
    {
        public int? Id { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Date Of Birth is required")]
        public DateTime? DateOfBirth { get; set; }
        [Required(ErrorMessage = "Years Of Experience is required")]
        public int? YearsOfExperience { get; set; }

        public string? SelectedSportName { get; set; }

        public string? SelectedRole { get; set; }

        public List<string> Sports { get; set; } = new List<string>();
    }
}

//This code defines a view model called CoachApplicationViewModel for handling coach application data in your web app's forms.
//Properties:
//•	Id: The unique identifier(optional).
//•	FirstName: The coach's first name (required).
//•	LastName: The coach's last name (required).
//•	DateOfBirth: The coach's date of birth (required).
//•	YearsOfExperience: How many years the coach has worked (required).
//•	SelectedSportName: The sport the coach is applying for (optional).
//•	SelectedRole: The role the coach is applying for (optional).
//Attributes:
//•	[Required] ensures the property must be filled in, with a custom error message if not.
//In short:
//This class is used to collect and validate coach application data from the user before processing or saving it.
