using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace PV100521_Laboratorio1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private double cumulativeSubtotal = 0.0;
        private double descuento = 0.0;
        private void button1_Click(object sender, EventArgs e)
        {
            String producto = comboBox1.Text;
            String cantidad = textBox1.Text;

            int rowIndex = dataGridView1.Rows.Add();

            dataGridView1.Rows[rowIndex].Cells[0].Value = producto;
            dataGridView1.Rows[rowIndex].Cells[2].Value = cantidad;

            int cantidadInt;
            if (!int.TryParse(cantidad, out cantidadInt))
            {
                // Handle the case where cantidad cannot be parsed to an integer
                // For example, display an error message or take appropriate action
                return;
            }



            double costo = 0.0;
            switch (producto)
            {
                case "Camisa":
                    costo = 15.00;
                    break;
                case "Cinturón":
                    costo = 8.00;
                    break;
                case "Zapatos":
                    costo = 40.00;
                    break;
                case "Pantalón":
                    costo = 25.00;
                    break;
                case "Calcetines":
                    costo = 2.50;
                    break;
                case "Faldas":
                    costo = 18.00;
                    break;
                case "Gorras":
                    costo = 9.00;
                    break;
                case "Suéter":
                    costo = 19.00;
                    break;
                case "Corbatas":
                    costo = 12.00;
                    break;
                case "Chaquetas":
                    costo = 35.00;
                    break;
                default:

                    break;
            }

            dataGridView1.Rows[rowIndex].Cells[1].Value = costo;


            double subtotal = costo * cantidadInt;
            dataGridView1.Rows[rowIndex].Cells[3].Value = subtotal;


            cumulativeSubtotal += subtotal;

            // Display cumulative subtotal in textBox2
            textBox2.Text = cumulativeSubtotal.ToString("C");


            if (subtotal < 100)
            {
                dataGridView1.Rows[rowIndex].Cells[4].Value = subtotal * 0;
                dataGridView1.Rows[rowIndex].Cells[5].Value = "0%";
                dataGridView1.Rows[rowIndex].Cells[6].Value = subtotal;
            }
            else if (subtotal >= 500)
            {
                dataGridView1.Rows[rowIndex].Cells[4].Value = subtotal * 0.30;
                dataGridView1.Rows[rowIndex].Cells[5].Value = "30%";
                dataGridView1.Rows[rowIndex].Cells[6].Value = subtotal - (subtotal * 0.30);
            }
            else if (subtotal >= 300)
            {
                dataGridView1.Rows[rowIndex].Cells[4].Value = subtotal * 0.25;
                dataGridView1.Rows[rowIndex].Cells[5].Value = "25%";
                dataGridView1.Rows[rowIndex].Cells[6].Value = subtotal - (subtotal * 0.25);
            }
            else if (subtotal >= 100)
            {
                dataGridView1.Rows[rowIndex].Cells[4].Value = subtotal * 0.15;
                dataGridView1.Rows[rowIndex].Cells[5].Value = "15%";
                dataGridView1.Rows[rowIndex].Cells[6].Value = subtotal - (subtotal * 0.15);
            }

            double cumulativeSum = 0.0;

            for (int i = 0; i <= rowIndex; i++)
            {
                double cellValue = Convert.ToDouble(dataGridView1.Rows[i].Cells[4].Value);
                cumulativeSum += cellValue;
            }

            // Set the cumulative sum to textBox3
            textBox3.Text = cumulativeSum.ToString();

            double difference = cumulativeSubtotal - cumulativeSum;

            textBox4.Text = difference.ToString();

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            double tasaDescuento = 0.0;

            if (cumulativeSubtotal < 100)
            {
                MessageBox.Show("Lo sentimos, el subtotal acumulado es menor que $100 y no califica para la promoción.");
            }
            else if (cumulativeSubtotal >= 500)
            {
                tasaDescuento = 0.30;
                MessageBox.Show("¡Felicidades, ha ganado un producto promocional!");
            }
            else if (cumulativeSubtotal >= 300)
            {
                tasaDescuento = 0.25;
            }
            else if (cumulativeSubtotal >= 100)
            {
                tasaDescuento = 0.15;
            }
        }
    }
}
