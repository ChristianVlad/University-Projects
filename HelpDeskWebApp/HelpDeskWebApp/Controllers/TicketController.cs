using HelpDeskWebApp.Models;
using HelpDeskWebApp.Permissions;
using Microsoft.Ajax.Utilities;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Sockets;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace HelpDeskWebApp.Controllers
{
    [Authorize]
    public class TicketController : Controller
    {
        private static string connect = ConfigurationManager.ConnectionStrings["conexion"].ToString();
        private static List<Ticket> ticketList = new List<Ticket>();

        public ActionResult Index()
        {
            ticketList = new List<Ticket>();
            using (SqlConnection oconexion = new SqlConnection(connect)) {

                SqlCommand cmd = new SqlCommand("SELECT * FROM TicketsMaster", oconexion);
                cmd.CommandType = CommandType.Text;
                oconexion.Open();
                using (SqlDataReader dr = cmd.ExecuteReader()) {

                    while (dr.Read())
                    {
                        Ticket t = new Ticket();
                        t.Id_Ticket = Convert.ToInt32(dr["Id_Ticket"]);
                        t.Date_Generation = Convert.ToDateTime(dr["Date_Generation"]);
                        t.Ticket_Status = dr["Ticket_Name"].ToString();
                        t.department = dr["department"].ToString();
                        t.user_name = dr["user_name"].ToString();
                        t.Ticket_Description = dr["Ticket_Description"].ToString();
                        t.Ticket_Resolution = dr["Ticket_Resolution"].ToString();

                        ticketList.Add(t);
                    }
                }
            }

            return View(ticketList);
        }

        [HttpGet]
        public ActionResult AddTicket() 
        { 
            return View();
        }

        [HttpPost]
        public ActionResult AddTicket(Ticket ticket)
        {
            using (SqlConnection oconexion = new SqlConnection(connect))
            {
                oconexion.Open();
                SqlCommand cmd = new SqlCommand("SP_InsertTicket", oconexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Ticket_Status", ticket.Ticket_Status);
                cmd.Parameters.AddWithValue("@Id_department", ticket.Id_department); // Corrected typo here
                cmd.Parameters.AddWithValue("@Id_User", ticket.Id_User);
                cmd.Parameters.AddWithValue("@Ticket_Description", ticket.Ticket_Description);
                cmd.Parameters.AddWithValue("@Ticket_Resolution", ticket.Ticket_Resolution);
                // ExecuteNonQuery for INSERT
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index", "Ticket"); // Redirect to the ticket index page
        }

        [HttpGet]
        public ActionResult ModifyTicket(int id)
        {
            Ticket ticketToUpdate = ticketList.FirstOrDefault(t => t.Id_Ticket == id);
            if (ticketToUpdate == null)
            {
                return HttpNotFound(); 
            }
            return View(ticketToUpdate);
        }

        [HttpPost]
        public ActionResult ModifyTicket(Ticket modifiedTicket)
        {
            // Update the ticket in the database based on the modifiedTicket object
            using (SqlConnection oconexion = new SqlConnection(connect))
            {
                oconexion.Open();
                SqlCommand cmd = new SqlCommand("SP_UpdateTicket", oconexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Ticket", modifiedTicket.Id_Ticket);
                cmd.Parameters.AddWithValue("@Ticket_Status", modifiedTicket.Ticket_Status);
                cmd.Parameters.AddWithValue("@Id_department", modifiedTicket.Id_department);
                cmd.Parameters.AddWithValue("@Id_User", modifiedTicket.Id_User);
                cmd.Parameters.AddWithValue("@Ticket_Description", modifiedTicket.Ticket_Description);
                cmd.Parameters.AddWithValue("@Ticket_Resolution", modifiedTicket.Ticket_Resolution);
                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Index", "Ticket");
        }

        [PermissionsRol("Admin")]
        [HttpGet]
        public ActionResult DeleteTicket(int id)
        {
            Ticket ticketToDelete = ticketList.FirstOrDefault(t => t.Id_Ticket == id);
            if (ticketToDelete == null)
            {
                return HttpNotFound();
            }
            return View(ticketToDelete);
        }

        [HttpPost]
        public ActionResult DeleteTicket(Ticket deleteTicket)
        {
            // Delete the ticket from the database based on the ticket's ID
            using (SqlConnection oconexion = new SqlConnection(connect))
            {
                oconexion.Open();
                SqlCommand cmd = new SqlCommand("SP_DeleteTicket", oconexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@Id_Ticket", deleteTicket.Id_Ticket);
                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Index", "Ticket");
        }

    }
}