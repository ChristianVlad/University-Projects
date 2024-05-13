using HelpDeskWebApp.Models;
using System.Web;
using System.Web.Mvc;

namespace HelpDeskWebApp.Permissions
{
    public class PermissionsRolAttribute : ActionFilterAttribute
    {
        private string role;

        public PermissionsRolAttribute(string _role)
        {
            role = _role;
        }

        public override void OnActionExecuted(ActionExecutedContext filterContext)
        {
            // Check if HttpContext.Current is not null and if Session["user"] is not null
            if (HttpContext.Current != null && HttpContext.Current.Session["user"] != null)
            {
                Users user = HttpContext.Current.Session["user"] as Users;

                if (user.rol != this.role)
                {
                    filterContext.Result = new RedirectResult("~/Home/AccessDenied");
                }
            }

            base.OnActionExecuted(filterContext);
        }
    }
}
