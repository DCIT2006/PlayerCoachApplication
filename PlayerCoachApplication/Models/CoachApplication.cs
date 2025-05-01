using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace PlayerCoachApplication.Models
{
    public class CoachApplication
    {
        public int Id { get; set; }
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string FirstName { get; set; }

        [Required]
        [StringLength(100)]
        [Column(TypeName = "nvarchar(100)")]
        public string LastName { get; set; }

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateOfBirth { get; set; }

        [Required]
        [Range(0, 100, ErrorMessage = "Years of experience must be between 0 and 100.")]
        public int YearsOfExperience { get; set; }
    }
}
