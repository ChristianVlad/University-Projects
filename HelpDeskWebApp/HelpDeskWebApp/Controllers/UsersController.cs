using HelpDeskWebApp.Models;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using HelpDeskWebApp.Permissions;

namespace HelpDeskWebApp.Controllers
{

    [Authorize]
    public class UsersController : Controller
    {
        // GET: Users
        private static string connect = ConfigurationManager.ConnectionStrings["conexion"].ToString();
        private static List<Users> UserList = new List<Users>();

        [PermissionsRol("Admin")]
        public ActionResult Index()
        {
            List<Users> userList = new List<Users>();

            using (SqlConnection connection = new SqlConnection(connect))
            {
                string query = "SELECT * FROM Users";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.CommandType = CommandType.Text;

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        while (reader.Read())
                        {
                            Users user = new Users
                            {
                                id = Convert.ToInt32(reader["id"]),
                                name = reader["name"].ToString(),
                                email = reader["email"].ToString(),
                                password = reader["password"].ToString(),
                                rol = reader["rol"].ToString()
                            };

                            // Convert the string value of rol to Rol enum
                            user.id_rol = ConvertToRolEnum(reader["id_rol"].ToString());

                            userList.Add(user);
                        }
                    }
                }
            }

            return View(userList);
        }

        // Helper method to convert GUID to Rol enum
        private Rol ConvertToRolEnum(string guidString)
        {
            switch (guidString)
            {
                case "A0196DB6-F8F6-4D13-886F-84C1AA78AB83":
                    return Rol.User;
                case "12066C60-3401-4551-AF49-D3D98C0FF735":
                    return Rol.Admin;
                // Add more cases for other possible GUID values
                default:
                    return Rol.User; // Or any default value you prefer
            }
        }

        private static readonly Dictionary<string, int> RoleMapping = new Dictionary<string, int>
        {
            { "Admin", 1 },
            { "User", 2 },
            { "Technician", 3 }
        };

        [PermissionsRol("Admin")]
        [HttpGet]
        public ActionResult AddUser()
        {
            Users newUser = new Users(); // Initialize a new Users object
            return View(newUser);
        }

        [HttpPost]
        public ActionResult AddUser(Users user)
        {
            // Check if the role exists in the dictionary and set id_rol
            if (RoleMapping.TryGetValue(user.rol, out int idRol))
            {
                user.id_rol = (Rol)idRol; // Cast int to Rol
            }
            else
            {
                // Handle the case where the role is not found
                ModelState.AddModelError("rol", "Invalid role selected");
                return View(user);
            }

            // Now proceed with inserting the user data into the database
            using (SqlConnection oconexion = new SqlConnection(connect))
            {
                oconexion.Open();
                SqlCommand cmd = new SqlCommand("SP_Add_User", oconexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@user", user.name); 
                cmd.Parameters.AddWithValue("@email", user.email);
                cmd.Parameters.AddWithValue("@password", user.password);
                cmd.Parameters.AddWithValue("@rol", user.rol);
                cmd.Parameters.AddWithValue("@id_rol", (int)user.id_rol); 
                                                              
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index", "Users");
        }

        [PermissionsRol("Admin")]
        [HttpGet]
        public ActionResult ModifyUser(int id)
        {
            Users userToUpdate = null;

            using (SqlConnection connection = new SqlConnection(connect))
            {
                string query = "SELECT * FROM Users WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            userToUpdate = new Users
                            {
                                id = Convert.ToInt32(reader["id"]),
                                name = reader["name"].ToString(),
                                email = reader["email"].ToString(),
                                password = reader["password"].ToString(),
                                rol = reader["rol"].ToString(),
                                id_rol = (Rol)Convert.ToInt32(reader["id_rol"])
                            };
                        }
                    }
                }
            }

            if (userToUpdate == null)
            {
                return HttpNotFound();
            }
            return View(userToUpdate);
        }

        // POST: ModifyUser
        [HttpPost]
        public ActionResult ModifyUser(Users modifiedUser)
        {
            if (RoleMapping.TryGetValue(modifiedUser.rol, out int idRol))
            {
                modifiedUser.id_rol = (Rol)idRol;
            }
            else
            {
                ModelState.AddModelError("rol", "Invalid role selected");
                return View(modifiedUser);
            }

            if (string.IsNullOrEmpty(modifiedUser.name) || string.IsNullOrEmpty(modifiedUser.email) || string.IsNullOrEmpty(modifiedUser.password) || string.IsNullOrEmpty(modifiedUser.rol))
            {
                // Redirect to the index action of the Access controller if any of the required fields are empty
                return RedirectToAction("Index", "Users");
            }


            using (SqlConnection oconexion = new SqlConnection(connect))
            {
                oconexion.Open();
                SqlCommand cmd = new SqlCommand("SP_Update_User", oconexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", modifiedUser.id);
                cmd.Parameters.AddWithValue("@name", modifiedUser.name);
                cmd.Parameters.AddWithValue("@email", modifiedUser.email);
                cmd.Parameters.AddWithValue("@password", modifiedUser.password);
                cmd.Parameters.AddWithValue("@rol", modifiedUser.rol);
                cmd.Parameters.AddWithValue("@id_rol", (int)modifiedUser.id_rol);
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index", "Users");
        }

        [PermissionsRol("Admin")]
        [HttpGet]
        public ActionResult DeleteUser(int id)
        {
            Users deleteUser = null;

            using (SqlConnection connection = new SqlConnection(connect))
            {
                string query = "SELECT * FROM Users WHERE id = @id";

                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@id", id);
                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            deleteUser = new Users
                            {
                                id = Convert.ToInt32(reader["id"]),
                                name = reader["name"].ToString(),
                                email = reader["email"].ToString(),
                                password = reader["password"].ToString(),
                                rol = reader["rol"].ToString(),
                                id_rol = (Rol)Convert.ToInt32(reader["id_rol"])
                            };
                        }
                    }
                }
            }

            if (deleteUser == null)
            {
                return HttpNotFound();
            }
            return View(deleteUser);
        }

        // POST: Users/Delete/5
        [HttpPost, ActionName("DeleteUser")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteUserConfirmed(int id)
        {
            using (SqlConnection connection = new SqlConnection(connect))
            {
                connection.Open();
                SqlCommand cmd = new SqlCommand("SP_Delete_User", connection);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@id", id);
                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Index", "Users");
        }
    }

}

