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

//This code defines a view model called PlayerApplicationViewModel for handling player application data in your web app's forms.
//Properties:
//•	Id: The unique identifier for the player application (optional).
//•	FirstName: The player's first name (optional).
//•	LastName: The player's last name (required, with a custom error message).
//•	DateOfBirth: The player's date of birth (required, with a custom error message).
//•	PreferredPosition: The player's preferred position (required, defaults to an empty string).
//•	SelectedSportName: The sport the player is applying for (optional).
//•	SelectedPosition: The position selected by the player (optional).
//•	SelectedRole: The role selected by the player (optional).
//•	Sports: A list of available sports or positions (used to populate dropdowns in the UI).
//Purpose:
//This class is used to collect, validate, and transfer player application data between the user interface and the backend logic.
//In short:
//It helps manage and validate the information a player enters when applying, making it easier to display, process, and save their application in the web app.
