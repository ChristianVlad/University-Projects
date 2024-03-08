using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio2
{
    public partial class Form1 : Form
    {
        Nombre miNombre = new Nombre();
        public Form1()
        {
            InitializeComponent();
            // Suscribir los RadioButton del tipo de cuenta
            corriente.CheckedChanged += new EventHandler(TipoCuenta_CheckedChanged);
            ahorros.CheckedChanged += new EventHandler(TipoCuenta_CheckedChanged);
            plazos.CheckedChanged += new EventHandler(TipoCuenta_CheckedChanged);

            checkSanSalvador.CheckedChanged += new EventHandler(chkSucursal_CheckedChanged);
            checkSoyapango.CheckedChanged += new EventHandler(chkSucursal_CheckedChanged);
            checkLourdes.CheckedChanged += new EventHandler(chkSucursal_CheckedChanged);
            checkMejicanos.CheckedChanged += new EventHandler(chkSucursal_CheckedChanged);
            checkSonsonate.CheckedChanged += new EventHandler(chkSucursal_CheckedChanged);
            // Repite lo mismo para los demás CheckBox de sucursales
        }


        private void TipoCuenta_CheckedChanged(object sender, EventArgs e)
        {
            RadioButton radioButton = sender as RadioButton;
            if (radioButton != null && radioButton.Checked)
            {
                switch (radioButton.Name)
                {
                    case "corriente":
                        txtNumeroCuenta.Text = "CC-00001";
                        break;
                    case "ahorros":
                        txtNumeroCuenta.Text = "CA-00001";
                        break;
                    case "plazos":
                        txtNumeroCuenta.Text = "CP-00001";
                        break;
                }
            }
        }
        private void chkSucursal_CheckedChanged(object sender, EventArgs e)
        {
            CheckBox checkBox = sender as CheckBox;
            if (checkBox != null && checkBox.Checked)
            {
                // Desmarca todos los CheckBox
                foreach (var control in this.Controls)
                {
                    if (control is CheckBox && control != checkBox)
                    {
                        ((CheckBox)control).Checked = false;
                    }
                }
            }
        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            miNombre.Nombre1 = txtnombre.Text;  // Cambiado de Nombre1 a Nombre
            miNombre.Apellido = txtapellido.Text;
            miNombre.Dui = txtDUI.Text;
            miNombre.Nit = txtNIT.Text;
            MessageBox.Show("Datos ingresados con éxito");
            // Cambiado de NIT a Nit para coincidir con la clase Nombre
            // Aquí debería ir la lógica para persistir los datos de miNombre.
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void txtNumeroCuenta_TextChanged(object sender, EventArgs e)
        {

        }

       
    }
}
