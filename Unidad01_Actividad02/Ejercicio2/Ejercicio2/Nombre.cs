using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    public class Nombre
    {
        private string nombre;
        public string Nombre1 // Propiedad para 'nombre'
        {
            get { return nombre; }
            set { nombre = value; }
        }
        private string apellido;
        public string Apellido // Propiedad para 'apellido'
        {
            get { return apellido; }
            set { apellido = value; }
        }
        private string dui;
        public string Dui // Propiedad para 'dui'
        {
            get { return dui; }
            set { dui = value; }
        }
        private string nit;
        public string Nit // Propiedad para 'nit'
        {
            get { return nit; }
            set { nit = value; }
        }
    }
}
