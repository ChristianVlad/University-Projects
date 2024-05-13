using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelpDeskWebApp.Models;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Reflection;
using System.Security.Claims;
using System.Web.Security;



namespace HelpDeskWebApp.Controllers
{
    public class AccessController : Controller
    {
        private static string connect = ConfigurationManager.ConnectionStrings["conexion"].ToString();

        
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Index(string txtEmail, string txtUser, string txtPassword)
        {
            if (string.IsNullOrEmpty(txtEmail) || string.IsNullOrEmpty(txtUser) || string.IsNullOrEmpty(txtPassword))
            {
                return RedirectToAction("Index", "Access");
            }

            using (SqlConnection sqlconnect = new SqlConnection(connect))
            {
                SqlCommand cmd = new SqlCommand("SP_ValidateUser", sqlconnect)
                {
                    CommandType = CommandType.StoredProcedure
                };
                cmd.Connection.Open();
                cmd.Parameters.Add("@email", SqlDbType.VarChar, 50).Value = txtEmail;
                cmd.Parameters.Add("@user", SqlDbType.VarChar, 50).Value = txtUser;
                cmd.Parameters.Add("@password", SqlDbType.VarChar, 50).Value = txtPassword;

                SqlDataReader reader = cmd.ExecuteReader();

                if (reader.Read())
                {
                    string status = reader["Status"].ToString();
                    string userRole = reader["UserRole"].ToString(); // Assuming "UserRole" is returned by the stored procedure

                    if (status == "User Validated")
                    {
                        Users user = new Users(); // Create a new instance of Users
                        user.rol = userRole; // Set the user role
                        Session["user"] = user; // Store the user in the session
                        FormsAuthentication.SetAuthCookie(status, false);
                        return RedirectToAction("Index", "Home");
                    }
                }
            }



            // If user not validated or other error, redirect to login
            return RedirectToAction("Index", "Access");
        }


    }
}

