namespace Actividad1
{
    public partial class Actividad1 : Form
    {
        public Actividad1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
            string apellido = txtapellido.Text;

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
            string nombre = txtnombre.Text;

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            // variables
            double salario, descuento = 0, neto = 0;  // Initialize with default values

            salario = double.Parse(txtsalario.Text);

            //Calculos
            if (radioGerente.Checked == true)
            {
                descuento = salario * 0.2;
                neto = salario - descuento;
            }
            else if (RadioSub.Checked == true)
            {
                descuento = salario * 0.15;
                neto = salario - descuento;
            }
            else if (radioSecretaria.Checked == true)
            {
                descuento = salario * 0.05;
                neto = salario - descuento;
            }

            textDescuentos.Text = descuento.ToString();
            textNeto.Text = neto.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            string salario = txtsalario.Text;
        }
    }
}
