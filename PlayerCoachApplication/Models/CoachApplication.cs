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

//This code defines a data model called CoachApplication for storing coach application details in your web app.
//Properties:
//•	Id: The unique identifier for each coach application.
//•	FirstName: The coach's first name (up to 100 characters).
//•	LastName: The coach's last name (required, up to 100 characters).
//•	DateOfBirth: The coach's date of birth (required, must be a date).
//•	YearsOfExperience: How many years the coach has worked (required, must be between 0 and 100).
//Attributes:
//•	[Required] means the property must have a value.
//•	[StringLength(100)] limits text to 100 characters.
//•	[Column(TypeName = "nvarchar(100)")] sets the database column type.
//•	[Range(0, 100)] restricts the value to between 0 and 100.
//In short:
//This class is used to store and validate information about coaches who apply, ensuring the data is correct before saving to the database.

