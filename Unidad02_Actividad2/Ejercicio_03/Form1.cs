using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_Ejemplo3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            try
            {
                float numera = float.Parse(txtDividendo.Text);
                float denomina = float.Parse(txtDivisor.Text);

                float resultado = numera / denomina;
                txtResultado.Text = Convert.ToString(resultado);
            }
            catch(Exception error)
            {
                MessageBox.Show("El problema es: " + error.Message);
            }

        }

        private void btnReintentar_Click(object sender, EventArgs e)
        {
            txtDividendo.Clear();
            txtDivisor.Clear();
            txtResultado.Focus();
        }
    }
}
