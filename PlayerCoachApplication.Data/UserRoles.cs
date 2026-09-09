using System;

namespace PlayerCoachApplication.Data
{
    // Defines the core structural model for a Player entity
    public class Player
    {
        public int PlayerId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Position { get; set; }
        public int JerseyNumber { get; set; }
        public int AssignedCoachId { get; set; }
    }

    // Defines the core structural model for a Coach entity
    public class Coach
    {
        public int CoachId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Specialization { get; set; } // e.g., Offense, Defense
    }
}
