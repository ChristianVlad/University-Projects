using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace LABORATORIO03_PV100521.Models
{
    public class Libro
    {
        public int CodigoLibro { get; set; }
        public string TituloLibro { get; set; }
        public string ISBN { get; set; }
        public string FechaEdicion { get; set; }
        public string NombreAutorLibro { get; set; }
        public string ApellidoAutorLibro { get; set; }
        public string FechaNacimientoAutor { get; set; }
        public string DescripcionLibro { get; set; }

    }
}