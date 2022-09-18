using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Legionite.Web.Controllers;
using RoverCore.BreadCrumbs.Services;

namespace Legionite.Web.Areas.Admin.Controllers
{
    [Area("Admin")]
    [Authorize(Roles="Admin")]
    public class JobController : BaseController<JobController>
    {
        public IActionResult Index()
        {
	        _breadcrumbs.StartAtAction("Dashboard", "Index", "Home", new { Area = "Dashboard" })
		        .Then("Admin")
		        .ThenAction("Hangfire Dashboard", "Index", "Job", new { Area = "Admin" });

            return View();
        }
    }
}
