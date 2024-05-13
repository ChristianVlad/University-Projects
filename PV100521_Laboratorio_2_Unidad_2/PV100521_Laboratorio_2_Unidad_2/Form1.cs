using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace PV100521_Laboratorio_2_Unidad_2
{
    public partial class Form1 : Form


    {
        public Form1()
        {
            InitializeComponent();

        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Datos datos_con = new Datos();
            if (datos_con.Ok())
                MessageBox.Show("test");
            else
                MessageBox.Show("test 2");
        }

        private void Refresh()
        {
            Datos adatosDB = new Datos();
            dataGridView1.DataSource = adatosDB.Get();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Refresh();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Nuevos_Registros frm = new Nuevos_Registros();
            frm.ShowDialog();
            Refresh();
        }

        private void Modificar_Click(object sender, EventArgs e)
        {

        }

        private int? GetId()
        {
            try
            {
                return int.Parse(dataGridView1.Rows[dataGridView1.CurrentRow.Index].Cells[0].Value.ToString());
            }
            catch
            {
                return null;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

        }
    }
}
