using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace HelpDeskWebApp.Models
{
    public class Ticket
    {
        public int Id_Ticket { get; set; }
        public DateTime Date_Generation { get; set; }
        public string Ticket_Status { get; set; }
        public string department { get; set; }
        public string user_name { get; set; }
        public string Ticket_Description { get; set; }
        public string Ticket_Resolution { get; set; }

        public int Id_asginated { get; set; }
        public int Id_User { get; set; }

        public int Id_department { get; set; }

    }
}