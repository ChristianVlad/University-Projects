using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Web.Mvc;
using System.Web.Security;
using HelpDeskApp.Models;
using System.Configuration;
using System.Security.Claims;
using System.Web;

namespace HelpDeskApp.Controllers
{
    public class AccessController : Controller
    {
        private static string connect = ConfigurationManager.ConnectionStrings["conexion"].ConnectionString;

        // GET: Access
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(Users model)
        {
            bool loginSuccess = false;

            using (SqlConnection sqlconnect = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand("SP_ValidateUser", sqlconnect)
                { CommandType = CommandType.StoredProcedure };
                cmd.Connection.Open();
                cmd.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = model.name;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = model.password;

                // Execute the stored procedure to validate user and retrieve role
                SqlDataReader reader = cmd.ExecuteReader();
                if (reader.Read())
                {
                    string status = reader["Status"].ToString();
                    string userRole = reader["UserRole"].ToString();
                    reader.Close(); // Close the reader

                    if (status == "User Validated")
                    {
                        loginSuccess = true;

                        // Assign roles based on the user's role retrieved from the database
                        var roles = new List<string> { userRole };

                        // Create claims
                        var claims = new List<Claim>
                        {
                            new Claim(ClaimTypes.Name, model.name),
                            new Claim(ClaimTypes.Role, userRole)
                        };

                        // Create identity and ticket
                        var identity = new ClaimsIdentity(claims, "CookieAuth");

                        FormsAuthenticationTicket ticket = new FormsAuthenticationTicket(
                            1,
                            model.name,
                            DateTime.Now,
                            DateTime.Now.AddMinutes(5),
                            true, // persistent
                            userRole,
                            FormsAuthentication.FormsCookiePath);

                        string encryptedTicket = FormsAuthentication.Encrypt(ticket);
                        HttpCookie authCookie = new HttpCookie(FormsAuthentication.FormsCookieName, encryptedTicket);
                        HttpContext.Response.Cookies.Add(authCookie);

                        // Redirect the user after successful authentication
                        return RedirectToAction("Index", "Access");
                    }
                    else
                    {
                        // If the stored procedure doesn't return "User Validated"
                        return View();
                    }
                }
            }

            // If the user is not validated or the stored procedure doesn't return the expected result
            ViewBag.LoginMessage = "Invalid credentials. Please try again.";
            return View(model);
        }

        public ActionResult LogOut()
        {
            // Sign out the user
            FormsAuthentication.SignOut();

            return RedirectToAction("Index", "Access");
        }
    }
}
