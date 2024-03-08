using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Ejemplo_1
{
    partial class ContactosForm : Form
    {
        private List<Persona> Personas = new List<Persona>();
        private int edit_indice = -1;

        public ContactosForm()
        {
            InitializeComponent();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Persona per = new Persona();
            per.Nombre = tbxNombre.Text;
            per.Apellido = tbxApellido.Text;
            per.Telefono = tbxTelefono.Text;
            per.Correo = tbxCorreo.Text;
            
            if (edit_indice > -1)
            {
                Personas[edit_indice] = per;
                edit_indice = -1;
            }
            else
            {
                Personas.Add(per);
            }

            actualizarGrid();
            limpiar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1)
            {
                Personas.RemoveAt(edit_indice);
                edit_indice = -1;
                limpiar();
                actualizarGrid();
            }
            else
            {
                MessageBox.Show("Debe dar doble click primero sobre contacto");
            }
        }

        private void actualizarGrid()
        {
            gridContacto.DataSource = null;
            gridContacto.DataSource = Personas; 
        }

        private void limpiar()
        {
            tbxNombre.Clear();
            tbxApellido.Clear();
            tbxTelefono.Clear();
            tbxCorreo.Clear();
        }

        private void gridContacto_DoubleClick(object sender, EventArgs e)
        {
            DataGridViewRow seleccion = gridContacto.SelectedRows[0];
            int pos = gridContacto.Rows.IndexOf(seleccion);
            edit_indice = pos;
            Persona per = Personas[pos];
            tbxNombre.Text = per.Nombre;
            tbxApellido.Text = per.Apellido;
            tbxTelefono.Text = per.Telefono;
            tbxCorreo.Text = per.Correo;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FrmRecibe formulario = new FrmRecibe();
            formulario.PersonaRecibe = Personas;
            formulario.Show();
        }
    }
}
