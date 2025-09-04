using PlayerCoachApplication.Data.Models;

namespace PlayerCoachApplication.Models
{
    public class EditPlayerApplicationModel
    {
        public PlayerApplicationModel PlayerApplicationModel { get; set; }
        public List<string> FootballPositions { get; set; } = new List<string>();
        public List<string> BasketballPositions { get; set; } = new List<string>();
        public List<string> BaseballPositions { get; set; } = new List<string>();
        public List<string> HockeyPositions { get; set; } = new List<string>();
        public List<string> SoccerPositions { get; set; } = new List<string>();

    }
}

//This code defines a model called EditPlayerApplicationModel for editing a player's application in your web app.
//Properties:
//•	PlayerApplicationModel: Holds all the main details about the player (like name, date of birth, position, sport, and role).
//•	FootballPositions, BasketballPositions, BaseballPositions, HockeyPositions, SoccerPositions: Each is a list of possible positions for the corresponding sport.
//Purpose:
//This class is used when editing a player's application. It provides both the player's details and the available positions for each sport, so the user can select or change the player's preferred position.
//In short:
//It combines the player's info and lists of positions for each sport, making it easy to display and edit player applications in the web app.
