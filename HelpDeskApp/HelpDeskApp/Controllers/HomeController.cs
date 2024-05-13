using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace HelpDeskApp.Controllers
{
    [Authorize(Roles = "Admin, User, Technician")] 
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [Authorize(Roles = "Admin, User, Technician")] // Allow only users with role "User" to access Tickets action
        public ActionResult Tickets()
        {
            return View();
        }
    }
}
