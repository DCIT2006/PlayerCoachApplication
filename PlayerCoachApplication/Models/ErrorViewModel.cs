namespace PlayerCoachApplication.Models
{
    public class ErrorViewModel
    {
        public string? RequestId { get; set; }

        public bool ShowRequestId => !string.IsNullOrEmpty(RequestId);
    }
}

//This code defines a simple model called ErrorViewModel for displaying error information in your web app.
//Properties:
//•	RequestId: Stores the unique ID for the current request (optional).
//•	ShowRequestId: Returns true if RequestId is not empty, otherwise false.
//Purpose:
//This class is used to show error details to the user, such as a request ID that can help with troubleshooting or support.
//In short:
//It helps display error information, including a request ID, on error pages in your application.
