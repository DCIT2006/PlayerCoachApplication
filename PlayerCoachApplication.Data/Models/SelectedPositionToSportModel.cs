using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayerCoachApplication.Data.Models
{
    public class SelectedPositionToSportModel
    {
        public string Position { get; set; }
        public string Sport { get; set; }
    }
}

//This code defines a simple data model called SelectedPositionToSportModel for your web app.
//Properties:
//•	Position: The name of a position (for example, "Goalkeeper" or "Forward").
//•	Sport: The name of the sport (for example, "Soccer" or "Basketball").
//Purpose:1
//This class is used to link positions to specific sports.
//It helps the app know which positions are available for each sport, such as showing the correct options when a user selects a sport.
//In short:
//It stores pairs of positions and sports, making it easy to manage and display sport-specific positions in your application.

