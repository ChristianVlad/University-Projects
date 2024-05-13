using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using PV100521_GUIA8.Models;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using Microsoft.Ajax.Utilities;
using System.Diagnostics.Contracts;

namespace PV100521_GUIA8.Controllers
{
    public class ContactoController : Controller
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["cadena"].ToString();

        private static List<Contacto> olista = new List<Contacto>();
        // GET: Contacto
        public ActionResult Inicio()
        {
            olista = new List<Contacto>();
            using (SqlConnection oconexion = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM LIBRO", oconexion);
                cmd.CommandType = CommandType.Text;
                oconexion.Open();
                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Contacto nuevocontacto = new Contacto();

                        nuevocontacto.codigo_libro = Convert.ToInt32(dr["codigo_libro"]);
                        nuevocontacto.titulo_libro = dr["titulo_libro"].ToString();
                        nuevocontacto.isbn = dr["isbn"].ToString();
                        nuevocontacto.fecha_edicion = dr["fecha_edicion"].ToString();
                        nuevocontacto.nombre_autor_libro = dr["nombre_autor_libro"].ToString();
                        nuevocontacto.apellido_autor_libro = dr["apellido_autor_libro"].ToString();
                        nuevocontacto.fecha_nacimiento_autor = dr["fecha_nacimiento_autor"].ToString();
                        nuevocontacto.descripcion_libro = dr["descripcion_libro"].ToString();

                        olista.Add(nuevocontacto);
                    }
                }
            }
            return View(olista);
        }

        [HttpGet]
        public ActionResult Registrar()
        {
            // Your action method logic here
            return View();
        }

        [HttpPost]
        public ActionResult Registrar(Contacto ocontaco)
        {
            using (SqlConnection oconexion = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_Registrar", oconexion);
                cmd.Parameters.AddWithValue("Titulos", ocontaco.titulo_libro);
                cmd.Parameters.AddWithValue("ISBN", ocontaco.isbn);
                cmd.Parameters.AddWithValue("Fecha Ediccion", ocontaco.fecha_edicion);
                cmd.Parameters.AddWithValue("Nombre del Autor(es) del Libro", ocontaco.nombre_autor_libro);
                cmd.Parameters.AddWithValue("Apellido", ocontaco.apellido_autor_libro);
                cmd.Parameters.AddWithValue("Correo", ocontaco.fecha_nacimiento_autor);
                cmd.Parameters.AddWithValue("Correo", ocontaco.descripcion_libro);
                cmd.CommandType = CommandType.StoredProcedure;
                oconexion.Open();

                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Inicio", "Contacto");
        }

        [HttpGet]
        public ActionResult Editar(int? idcontacto)
        {
            if (idcontacto == null)
                return RedirectToAction("Inicio", "Contacto");

            Contacto contacto = olista.Where(c => c.codigo_libro == idcontacto).FirstOrDefault();
            if (contacto == null)
                return HttpNotFound(); // Or another appropriate action if the contact is not found

            return View(contacto); // Pass the Contacto object to the view
        }

        [HttpPost]
        public ActionResult Editar(Contacto ocontaco)
        {
            using (SqlConnection oconexion = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_editar", oconexion);
                cmd.Parameters.AddWithValue("IdContacto", ocontaco.codigo_libro);
                cmd.Parameters.AddWithValue("Nombres", ocontaco.Nombres);
                cmd.Parameters.AddWithValue("Apellidos", ocontaco.Apellidos);
                cmd.Parameters.AddWithValue("Telefono", ocontaco.Telefono);
                cmd.Parameters.AddWithValue("Correo", ocontaco.Correo);
                cmd.CommandType = CommandType.StoredProcedure;
                oconexion.Open();

                cmd.ExecuteNonQuery();
            }
            return RedirectToAction("Inicio", "Contacto");
        }

        [HttpGet]
        public ActionResult Eliminar(int? idcontacto)
        {
            if (idcontacto == null)
                return RedirectToAction("Inicio", "Contacto");

            Contacto ocontacto = olista.Where(c => c.codigo_libro == idcontacto).FirstOrDefault();

            return View(ocontacto);
        }

        [HttpPost]
        public ActionResult Eliminar(string IdContacto) 
        {
            using (SqlConnection oconexion = new SqlConnection(conexion)) 
            { 
                SqlCommand cmd = new SqlCommand("sp_Eliminar", oconexion);
                cmd.Parameters.AddWithValue("IdContacto", IdContacto);
                cmd.CommandType = CommandType.StoredProcedure;
                oconexion.Open();

                cmd.ExecuteNonQuery();  

            }

            return RedirectToAction("Inicio", "Contacto");
        
        }

    }
}