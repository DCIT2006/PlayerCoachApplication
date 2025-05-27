namespace PlayerCoachApplication.Models
{
    public class PlayerApplicationViewModel
    {
        
            public int? Id { get; set; }
            public string? FirstName { get; set; }
            public string? LastName { get; set; }
            public DateTime? DateOfBirth { get; set; }
            public string PreferredPosition { get; set; } = string.Empty;
            public string? SelectedSportName { get; set; }
            public string? SelectedPosition { get; set; }

            public string? SelectedRole { get; set; }

        public List<string> Sports { get; set; } = new List<string>();
    }
}
