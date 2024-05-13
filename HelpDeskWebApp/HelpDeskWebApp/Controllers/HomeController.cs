using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;
using HelpDeskWebApp.Permissions;

namespace HelpDeskWebApp.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        [PermissionsRol("Admin")]
        public ActionResult About()
        {
            ViewBag.Message = "Your application description about.";

            return View();
        }

        public ActionResult LogOut()
        {
            Session["user"] = null;
            FormsAuthentication.SignOut();
            return RedirectToAction("Index", "Access");
        }

        public ActionResult AccessDenied()
        {
            ViewBag.Message = "You are not authorized to access this page";

            return View();
        }
    }
}