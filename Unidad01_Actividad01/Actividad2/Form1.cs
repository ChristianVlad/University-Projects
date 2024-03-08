namespace Actividad2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void var_a_TextChanged(object sender, EventArgs e)
        {
            string a = var_a.Text;
        }

        private void var_b_TextChanged(object sender, EventArgs e)
        {
            string b = var_b.Text;
        }

        private void var_c_TextChanged(object sender, EventArgs e)
        {
            string c = var_c.Text;
        }

        private void button1_Click(object sender, EventArgs e)
        {
 
            if (!double.TryParse(var_a.Text, out double a) ||
                !double.TryParse(var_b.Text, out double b) ||
                !double.TryParse(var_c.Text, out double c))
            {
                return;
            }

            double raiz1 = 0, raiz2 = 0;

            double discriminante = b * b - 4 * a * c;

            if (discriminante < 0)
            {

            }
            else if (discriminante == 0)
            {
                raiz1 = -b / (2 * a);
            }
            else
            {
                raiz1 = (-b + Math.Sqrt(discriminante)) / (2 * a);
                raiz2 = (-b - Math.Sqrt(discriminante)) / (2 * a);
            }

            txtResults1.Text = raiz1.ToString();
            txtResults2.Text = raiz2.ToString();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}
