using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PV100521_GUIA8.Models
{
    public class Contacto
    {
        public int codigo_libro {  get; set; }
        public string titulo_libro { get; set; }
        public string isbn { get; set; }
        public string fecha_edicion { get; set; }
        public string nombre_autor_libro { get; set; }
        public string apellido_autor_libro { get; set; }

        public string fecha_nacimiento_autor { get; set; }
        public string descripcion_libro { get; set; }
    }
}