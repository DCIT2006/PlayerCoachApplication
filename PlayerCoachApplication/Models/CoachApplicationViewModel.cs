namespace PlayerCoachApplication.Models
{
    public class CoachApplicationViewModel
    {
        public int? Id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? YearsOfExperience { get; set; }
        public string? SelectedSportName { get; set; }
        public string? SelectedRole { get; set; }
    }
}
