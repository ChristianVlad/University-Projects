using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Diagnostics.Contracts;
using LABORATORIO03_PV100521.Models;
using System.Net.Http.Headers;

namespace LABORATORIO03_PV100521.Controllers
{
    public class LibroController : Controller
    {
        private static string conexion = ConfigurationManager.ConnectionStrings["cadena"].ToString();
        private static List<Libro> olista = new List<Libro>();
        // GET: Libro
        public ActionResult Inicio()
        {

            using (SqlConnection oconexion = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM LIBROS", oconexion);
                cmd.CommandType = CommandType.Text;
                oconexion.Open();

                using (SqlDataReader dr = cmd.ExecuteReader())
                {
                    while (dr.Read())
                    {
                        Libro nuevoLibro = new Libro();
                        nuevoLibro.CodigoLibro = Convert.ToInt32(dr["codigo_libro"]);
                        nuevoLibro.TituloLibro = dr["titulo_libro"].ToString();
                        nuevoLibro.ISBN = dr["isbn"].ToString();
                        nuevoLibro.FechaEdicion = dr["fecha_edicion"].ToString();
                        nuevoLibro.NombreAutorLibro = dr["nombre_autor_libro"].ToString();
                        nuevoLibro.ApellidoAutorLibro = dr["apellido_autor_libro"].ToString();
                        nuevoLibro.FechaNacimientoAutor = dr["fecha_nacimiento_autor"].ToString();
                        nuevoLibro.DescripcionLibro = dr["descripcion_libro"].ToString();
                        olista.Add(nuevoLibro);
                    }
                }
            }

            return View(olista);
        }

        [HttpGet]
        public ActionResult Registrar()
        { 
            return View();  
        }

        [HttpPost]
        public ActionResult Registrar(Libro olibro) {

            using (SqlConnection oconexion = new SqlConnection(conexion)){
                SqlCommand cmd = new SqlCommand("sp_RegistrarLibro", oconexion);
                cmd.Parameters.AddWithValue("codigo_libro", olibro.CodigoLibro);
                cmd.Parameters.AddWithValue("titulo_libro", olibro.TituloLibro);
                cmd.Parameters.AddWithValue("isbn", olibro.ISBN);
                cmd.Parameters.AddWithValue("fecha_edicion", olibro.FechaEdicion);
                cmd.Parameters.AddWithValue("nombre_autor_libro", olibro.NombreAutorLibro);
                cmd.Parameters.AddWithValue("apellido_autor_libro", olibro.ApellidoAutorLibro);
                cmd.Parameters.AddWithValue("fecha_nacimiento_autor", olibro.FechaNacimientoAutor);
                cmd.Parameters.AddWithValue("descripcion_libro", olibro.DescripcionLibro);
                cmd.CommandType = CommandType.StoredProcedure;
                oconexion.Open();


                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Inicio", "Libro");
        }

        [HttpGet]
        public ActionResult Edit(int? CodigoLibro)
        {
            if (CodigoLibro == null)
                return RedirectToAction("Inicio", "Libro");

            Libro olibro = olista.Where(c=> c.CodigoLibro == CodigoLibro).FirstOrDefault();

            return View(olibro);

        }

        [HttpPost]
        public ActionResult Edit(Libro olibro)
        {

            using (SqlConnection oconexion = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_EditarLibro", oconexion);
                cmd.Parameters.AddWithValue("codigo_libro", olibro.CodigoLibro);
                cmd.Parameters.AddWithValue("titulo_libro", olibro.TituloLibro);
                cmd.Parameters.AddWithValue("isbn", olibro.ISBN);
                cmd.Parameters.AddWithValue("fecha_edicion", olibro.FechaEdicion);
                cmd.Parameters.AddWithValue("nombre_autor_libro", olibro.NombreAutorLibro);
                cmd.Parameters.AddWithValue("apellido_autor_libro", olibro.ApellidoAutorLibro);
                cmd.Parameters.AddWithValue("fecha_nacimiento_autor", olibro.FechaNacimientoAutor);
                cmd.Parameters.AddWithValue("descripcion_libro", olibro.DescripcionLibro);
                cmd.CommandType = CommandType.StoredProcedure;
                oconexion.Open();


                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Inicio", "Libro");
        }

        [HttpGet]
        public ActionResult Eliminar(int? CodigoLibro)
        {
            if (CodigoLibro == null)
                return RedirectToAction("Inicio", "Libro");

            Libro olibro = olista.Where(c => c.CodigoLibro == CodigoLibro).FirstOrDefault();

            return View(olibro);
        }

        [HttpPost]
        public ActionResult Eliminar(Libro olibro)
        {

            using (SqlConnection oconexion = new SqlConnection(conexion))
            {
                SqlCommand cmd = new SqlCommand("sp_EliminarLibro", oconexion);
                cmd.Parameters.AddWithValue("codigo_libro", olibro.CodigoLibro);
                cmd.CommandType = CommandType.StoredProcedure;
                oconexion.Open();


                cmd.ExecuteNonQuery();
            }

            return RedirectToAction("Inicio", "Libro");
        }
    }
}