using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Ejemplo_1
{
    public partial class FrmRecibe : Form
    {
        public List<Persona> PersonaRecibe = null; //creación de una lista que reciba
        public FrmRecibe()
        {
            InitializeComponent();
            ConfigFilter();
        }

        private void ConfigFilter()
        {
            tbxFiltro.GotFocus += tbxFiltro_Enter;
            tbxFiltro.LostFocus += tbxFiltro_Leave;
            tbxFiltro.Text = "Buscar..."; // Establece el texto inicial del placeholder
            tbxFiltro.ForeColor = Color.Gray;
            dgvRecibe.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvRecibe.AllowUserToOrderColumns = false;
        }

        private void actualizarGrid() //función que llena el DGV del formulario 2
        {
            dgvRecibe.DataSource = null;
            dgvRecibe.DataSource = PersonaRecibe;
        }

        private void tbxFiltro_Enter(object sender, EventArgs e)
        {
            if (tbxFiltro.Text == "Buscar...") // Considera "Buscar..." como el texto del placeholder
            {
                tbxFiltro.Text = "";
                tbxFiltro.ForeColor = Color.Black; // Cambia el color del texto a negro (o cualquier color que prefieras)
            }
        }

        private void tbxFiltro_Leave(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbxFiltro.Text))
            {
                tbxFiltro.Text = "Buscar...";
                tbxFiltro.ForeColor = Color.Gray; // Cambia el color del texto a gris para el placeholder
            }
        }


        private void btnLlenar_Click_1(object sender, EventArgs e)
        {
            actualizarGrid();
        }

        private void tbxFiltro_TextChanged(object sender, EventArgs e)
        {
            if (PersonaRecibe == null) return; // Asegúrate de que la lista no esté vacía

            string filtro = tbxFiltro.Text.ToLower(); // Obtén el texto del filtro en minúsculas para una comparación no sensible a mayúsculas/minúsculas

            if (string.IsNullOrWhiteSpace(filtro))
            {
                actualizarGrid(); // Si el filtro está vacío, muestra la lista completa
            }
            else
            {
                var filtrado = PersonaRecibe.Where(p => p.Nombre.ToLower().Contains(filtro)
                                                    || p.Apellido.ToLower().Contains(filtro)
                                                    || p.Telefono.ToLower().Contains(filtro)
                                                    || p.Correo.ToLower().Contains(filtro)).ToList();

                dgvRecibe.DataSource = null;
                dgvRecibe.DataSource = filtrado; // Actualiza el DataGridView con la lista filtrada
            }
        }

    }
}
