using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace G2_Ejercicio1
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
            dgvNotas.Enabled = false;
        }

        private void CargarNotas()
        {
            string materia = txtMateria.Text;

            if (AppContext.MateriasNotas.ContainsKey(materia))
            {
                var notas = AppContext.MateriasNotas[materia].NotasCiclo1;

                dgvNotas.ColumnCount = notas.Count * 2 + 1;
                for (int i = 0; i < notas.Count; i++)
                {
                    dgvNotas.Columns[i * 2].HeaderText = $"L{i + 1}";
                    dgvNotas.Columns[i * 2 + 1].HeaderText = $"P{i + 1}";
                }
                dgvNotas.Columns[notas.Count * 2].HeaderText = "Nota Final";

                dgvNotas.Rows.Clear();
                dgvNotas.Rows.Add();
                for (int i = 0; i < notas.Count; i++)
                {
                    dgvNotas.Rows[0].Cells[i * 2].Value = notas[i].Laboratorio;
                    dgvNotas.Rows[0].Cells[i * 2 + 1].Value = notas[i].Parcial;
                }
                dgvNotas.Rows[0].Cells[notas.Count * 2].Value = CalcularPromedio(notas);

                dgvNotas.Enabled = true;
            }
            else
            {
                // Deshabilitar el DataGridView
                dgvNotas.Enabled = false;
            }
        }


        private double CalcularPromedio(List<Nota> notas)
        {
            double sum = 0;
            int count = 0;
            foreach (var nota in notas)
            {
                if (nota.Laboratorio.HasValue)
                {
                    sum += nota.Laboratorio.Value;
                    count++;
                }
                if (nota.Parcial.HasValue)
                {
                    sum += nota.Parcial.Value;
                    count++;
                }
            }
            return count > 0 ? sum / count : 0;
        }

        // Manejo de errores ante valores no numéricos
        private void dgvNotas_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCell cell = dgvNotas.Rows[e.RowIndex].Cells[e.ColumnIndex];
            double value;
            if (!double.TryParse(cell.Value?.ToString(), out value))
            {
                MessageBox.Show("Por favor, introduzca un valor numérico válido.");
                cell.Value = DBNull.Value;
            }
            else if (value < 0 || value > 10)
            {
                MessageBox.Show("La nota debe estar entre 0 y 10.");
                cell.Value = DBNull.Value;
            }
            else if (e.ColumnIndex < dgvNotas.ColumnCount - 1)
            {
                var fila = dgvNotas.Rows[e.RowIndex];
                var notas = ObtenerNotasDesdeFila(fila);
                dgvNotas.Rows[e.RowIndex].Cells[dgvNotas.ColumnCount - 1].Value = CalcularPromedio(notas);
            }
        }

        private List<Nota> ObtenerNotasDesdeFila(DataGridViewRow fila)
        {
            List<Nota> notas = new List<Nota>();
            int numColumnas = fila.Cells.Count;

            for (int i = 0; i < numColumnas - 1; i += 2)
            {
                double? lab = double.Parse(fila.Cells[i].Value.ToString());
                double? parcial = double.Parse(fila.Cells[i + 1].Value.ToString());
                notas.Add(new Nota { Laboratorio = lab, Parcial = parcial });
            }

            return notas;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            string nuevaMateria = txtMateria.Text.Trim();

            if (string.IsNullOrEmpty(nuevaMateria))
            {
                MessageBox.Show("Por favor, ingrese un nombre de materia.");
                return;
            }

            if (!AppContext.MateriasNotas.ContainsKey(nuevaMateria))
            {
                AppContext.MateriasNotas.Add(nuevaMateria, new ClaseNotas());


                // Limpiar DataGridView
                dgvNotas.Rows.Clear();
                dgvNotas.Columns.Clear();

                // Actualizar la interfaz para mostrar las notas de la nueva materia
                CargarNotas();
            }
            else
            {
                var fila = dgvNotas.Rows[0];
                var notas = ObtenerNotasDesdeFila(fila);
                AppContext.MateriasNotas[nuevaMateria] = new ClaseNotas() { NotasCiclo1 = notas };

                MessageBox.Show("Notas Guardadas");
            }
        }

        private void txbNombreMateria_TextChanged(object sender, EventArgs e)
        {
            CargarNotas();
        }
    }

    public class Nota
    {
        public double? Laboratorio { get; set; } = 0;
        public double? Parcial { get; set; } = 0;
    }

    public class ClaseNotas
    {
        public List<Nota> NotasCiclo1 { get; set; } = new List<Nota>()
        {
            new Nota(),
            new Nota(),
            new Nota(),
            new Nota()
        };
    }

    public static class AppContext
    {
        public static Dictionary<string, ClaseNotas> MateriasNotas { get; set; } = new Dictionary<string, ClaseNotas>();
    }

}
