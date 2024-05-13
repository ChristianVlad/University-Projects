using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Helpers;
using System.Xml.Linq;
using HelpDeskWebApp.Models;

namespace HelpDeskWebApp.Models
{
    public class Users
    {
        public string name { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public string rol { get; set; }
        public Rol id_rol { get; set; }
    }
}