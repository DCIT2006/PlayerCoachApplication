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
    }
}
