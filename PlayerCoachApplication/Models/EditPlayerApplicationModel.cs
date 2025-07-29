using PlayerCoachApplication.Data.Models;

namespace PlayerCoachApplication.Models
{
    public class EditPlayerApplicationModel
    {
        public PlayerApplicationModel PlayerApplicationModel { get; set; }
        public List<string> FootballPositions { get; set; } = new List<string>();
        public List<string> BasketballPositions { get; set; } = new List<string>();
    }
}
