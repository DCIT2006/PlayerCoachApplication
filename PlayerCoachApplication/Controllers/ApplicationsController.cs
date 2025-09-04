using Azure.Core;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace PlayerCoachApplication.Controllers
{
    public class ApplicationsController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}

////This code defines a controller called ApplicationsController for an ASP.NET Core application.
//It has one method, Index, which returns a view when someone visits the corresponding page.
//•	public class ApplicationsController : Controller — This creates a controller for handling web requests.
//•	public IActionResult Index() — This method responds to requests for the "Index" page.
//•	return View(); — This tells ASP.NET to show the default view for this page.
//In short:
//When a user goes to the "Applications" section of the site, this code shows them the main page for that section.
