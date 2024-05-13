using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV100521_Laboratorio_2_Unidad_2
{
    public partial class Nuevos_Registros : Form
    {
        private int? CodigoProd;
        public Nuevos_Registros()
        {
            InitializeComponent();

        }
        


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Nuevos_Registros_Load(object sender, EventArgs e)
        {

        }

        private void Guardar_Click(object sender, EventArgs e)
        {
            Datos eData = new Datos();

            try
            {
                // Parse input values from text boxes
                int codigo = int.Parse(Codigo_txt.Text);
                string producto = Producto_txt.Text;
                decimal precio = decimal.Parse(Precio_txt.Text);
                int unidades = int.Parse(Unidades_txt.Text);

                // Call the AddData method with parsed values
                eData.AddData(codigo, producto, precio, unidades);

                // Optionally, clear the text boxes after successful addition
                Codigo_txt.Text = "";
                Producto_txt.Text = "";
                Precio_txt.Text = "";
                Unidades_txt.Text = "";

                MessageBox.Show("Completado");
            }
            catch (FormatException ex)
            {
                MessageBox.Show("Por favor, ingrese valores numéricos válidos en los campos correspondientes. " + ex.Message);
            }
        }


    }
}
