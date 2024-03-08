using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace G2_Ejercicio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (!ValidateUserData())
            {
                MessageBox.Show("Asegurar que todos los datos sean correctos", "Error al guardar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            btnNotas.Enabled = true;
            btnGuardar.Enabled = false;
            txtCarnet.Enabled = false;
            txtCorreo.Enabled = false;
            dtpFecha.Enabled = false;
            txtNombres.Enabled = false;
            txtResponsable.Enabled = false;
        }
        private void btnNotas_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();

            form2.ShowDialog();
        }
        private bool ValidateUserData()
        {
            var itsOk = true;
            errorProvider1.Clear();

            var carnet = txtCarnet.Text;
            Regex regexCarnet = new Regex(@"^[A-Z]{2}\d{6}$");
            if (string.IsNullOrEmpty(carnet))
            {
                itsOk = false;
                errorProvider1.SetError(txtCarnet, "Ingresar carnet");
            }
            else if (!regexCarnet.IsMatch(carnet))
            {
                itsOk = false;
                errorProvider1.SetError(txtCarnet, "El carnet no posee el formato adecuado (AA999999)");
            }

            var nombre = txtNombres.Text;    
            if (string.IsNullOrEmpty(nombre))
            {
                itsOk = false;
                errorProvider1.SetError(txtNombres, "Ingresar nombres");
            }

            var fecha = dtpFecha.Value;    
            if (fecha == null || fecha == DateTime.MinValue || fecha > DateTime.Now)
            {
                itsOk = false;
                errorProvider1.SetError(dtpFecha, "Ingresar fecha valida");
            }

            var correo = txtCorreo.Text;
            Regex regexCorreo = new Regex(@"^\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$");

            if (string.IsNullOrEmpty(correo))
            {
                itsOk = false;
                errorProvider1.SetError(txtCorreo, "Ingresar correo válido");
            }
            else if (!regexCorreo.IsMatch(correo))
            {
                itsOk = false;
                errorProvider1.SetError(txtCorreo, "El correo no posee el formato adecuado");
            }

            var responsables = txtResponsable.Text;
            if (string.IsNullOrEmpty(responsables))
            {
                itsOk = false;
                errorProvider1.SetError(txtResponsable, "Ingresar responsables");
            }

            return itsOk;
        }

        
    }
}
