using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PV100521_Guia7
{
    public partial class FrmTabla : Form
    {
        public FrmTabla()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void BtnGuardar_Click(object sender, EventArgs e)
        {
            using (BDD_UFGEntities db = new BDD_UFGEntities())
            {
                // creamos un objeto del tipo de la tabla de la base
                if (id == null)
                {
                    personas = new Persona();
                    //lo llenamos con información desde el formulario
                    personas.id = int.Parse(TxtId.Text);
                    personas.nombre = TxtNombre.Text;
                    personas.correo = TxtCorreo.Text;
                    personas.fecha_nacimiento = DtpFecha.Value;
                    //agregamos ese nuevo objeto a la entidad
                    db.Persona.Add(personas);
                }
                else
                {
                    db.Entry(personas).State = System.Data.Entity.EntityState.Modified;
                }
                //guardamos cambios en la base
                db.SaveChanges();
                this.Close();
            }
        }

    }
