using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCoachApplication.Data.Models
{
    public class CoachApplicationModel
    {
        public int? Id { get; set; } 
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        public int? YearsOfExperience { get; set; }
        public string SelectedSportName { get; set; }
        public string? SelectedRole { get; set; }

       

    }
}

//This code defines a data model called CoachApplicationModel for storing coach application details in your web app.
//Properties:
//•	Id: The unique identifier for each coach application (optional).
//•	FirstName: The coach's first name (optional).
//•	LastName: The coach's last name (optional).
//•	DateOfBirth: The coach's date of birth (optional).
//•	YearsOfExperience: How many years the coach has worked (optional).
//•	SelectedSportName: The sport the coach is applying for (optional).
//•	SelectedRole: The role the coach is applying for (optional).
//Purpose:
//This class is used to represent and transfer coach application data between the database and your application.
//In short:
//It stores all the main details about a coach's application, making it easy to save, retrieve, and display this information in your app.
