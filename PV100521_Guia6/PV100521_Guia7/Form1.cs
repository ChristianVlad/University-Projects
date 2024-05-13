namespace PV100521_Guia7
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Refrescar()
        {
            using (BDD_UFGEntities db = new BDD_UFGEntities())
            {
                // selecciona los datos disponibles en la tabla Persona
                var lista = from datos in db.Persona
                            select datos;

                // se carga el DataGridView con la información recopilada desde
                // la base de datos
                DgvDatos.DataSource = lista.ToList();
            }
        }

        private void Form1_Load(object sender, EventArgs e) { 
        
           Refrescar();
        }


        private void splitContainer1_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BtnNuevo_Click(object sender, EventArgs e)
        {
            // creamos un objeto del formulario FrmTabla
            FrmTabla frmtabla = new FrmTabla();
            // abrimos con ShowDialog
            frmtabla.ShowDialog();
            // refrescamos los datos
            Refrescar();
        }


        private void BtnEliminar_Click(object sender, EventArgs e)
        {
            int? id = ObtenerId();
            if (id = null)
            {
                using (BDD_UFGEntities db = new BDD_UFGEntities())
                {
                    Persona personas = db.Persona.Find(id);
                    db.Persona.Remove(personas);
                    db.SaveChanges();
                }
            }
            Refrescar();
        }

        private void CargarDatos()
        {
            using (BDD_UFGEntities db = new BDD_UFGEntities())
            {
                personas = db.Persona.Find(id);
                TxtId.Text = personas.id.ToString();
                TxtNombre.Text = personas.nombre;
                TxtCorreo.Text = personas.correo;
                DtpFecha.Value = (DateTime)personas.fecha_nacimiento;
            }
        }

    }
}
