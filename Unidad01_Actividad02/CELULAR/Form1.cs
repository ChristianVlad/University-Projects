using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CELULAR
{
    public partial class Form1 : Form
    {
        private Celular miCelular;

        public Form1()
        {
           InitializeComponent();
           
         miCelular = new Celular("Marca", "Modelo", "Color", 1500);
        }
        private void btnEncender_Click(object sender, EventArgs e)
        {
            if (!miCelular.Encendido)
            {
                miCelular.Encender();
                MessageBox.Show("Celular encendido.");
            }
            else
            {
                MessageBox.Show("El celular ya está encendido.");
            }
        }

        private void btnApagar_Click(object sender, EventArgs e)
        {
            if (miCelular.Encendido)
            {
                miCelular.Apagar();
                MessageBox.Show("Celular apagado.");
            }
            else
            {
                MessageBox.Show("El celular ya está apagado.");
            }
        }

        private void btnLlamar_Click(object sender, EventArgs e)
        {
            if (miCelular.Encendido)
            {
                string numero = txtNumero.Text;
                miCelular.Llamar(numero);
                MessageBox.Show($"Llamando al número: {numero}");
            }
            else
            {
                MessageBox.Show("El celular está apagado.");
            }
        }

        private void btnEnviarMensaje_Click(object sender, EventArgs e)
        { 
            if (miCelular.Encendido)
            {
                string numero = txtNumero.Text;
                string mensaje = txtMensaje.Text;
                miCelular.EnviarMensaje(numero, mensaje);
                MessageBox.Show($"Mensaje enviado a {numero}: {mensaje}");
            }
            else
            {
                MessageBox.Show("El celular está apagado.");
            }
        }
    }
}

