using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PV100521_Guia07.Models;
using static System.Runtime.InteropServices.JavaScript.JSType;


namespace PV100521_Guia07.Controllers
{
    public class EstudiantesController : Controller
    {
        // GET: EstudiantesController
        public ActionResult Index()
        {
            //return View();

            var Estudiantes = from estud in RecuperaEstudiante()
                              orderby estud.idEstudiante
                              select estud;
            return View(Estudiantes);
        }

        // GET: EstudiantesController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: EstudiantesController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: EstudiantesController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstudiantesController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: EstudiantesController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: EstudiantesController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: EstudiantesController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        [NonAction]
        public List<Estudiante> RecuperaEstudiante()
        {
            return new List<Estudiante>
                {
                    new Estudiante
                    {
                        idEstudiante = 1,
                        Nombre = "Carlos",
                        ApelPaterno = "Montoya",
                        ApelMaterno = "Figueroa",
                        FechaInscrip = DateTime.Parse(DateTime.Today.ToString()),
                        Edad = 20
                    },

                    new Estudiante
                    {
                        idEstudiante = 1,
                        Nombre = "Lourdes",
                        ApelPaterno = "Peña",
                        ApelMaterno = "Ardon",
                        FechaInscrip = DateTime.Parse(DateTime.Today.ToString()),
                        Edad = 28
                    }
                };
        }
    }
}
