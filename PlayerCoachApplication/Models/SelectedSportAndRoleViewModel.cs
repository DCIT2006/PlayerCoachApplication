namespace PlayerCoachApplication.Models
{
    internal class SelectedSportAndRoleViewModel
    {
        public string SelectedSportName { get; set; }
        public string? SelectedRole { get; set; }

        public List<string> AvailableSports { get; set; } = new();
        
    }
}

//This code defines a simple view model called SelectedSportAndRoleViewModel for your web app.
//Properties:
//•	SelectedSportName: Stores the name of the sport selected by the user.
//•	SelectedRole: Stores the role selected by the user (optional).
//Purpose:
//This class is used to pass the user's selected sport and role between the backend and the view, typically after a form submission.
//In short:
//It helps keep track of which sport and role a user has chosen in the application.