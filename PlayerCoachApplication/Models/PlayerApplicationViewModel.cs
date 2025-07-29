using System.ComponentModel.DataAnnotations;

namespace PlayerCoachApplication.Models
{
    public class PlayerApplicationViewModel
    {

        public int? Id { get; set; }
        public string? FirstName { get; set; }
        [Required(ErrorMessage = "First Name is required")]
        public string? LastName { get; set; }
        [Required(ErrorMessage = "Last Name is required")]
        public DateTime? DateOfBirth { get; set; }
        [Required(ErrorMessage = "Date of Birth is required")]
        public string PreferredPosition { get; set; } = string.Empty;
        public string? SelectedSportName { get; set; }
        public string? SelectedPosition { get; set; }

        public string? SelectedRole { get; set; }

        public List<string> Sports { get; set; } = new List<string>();


    }
}
