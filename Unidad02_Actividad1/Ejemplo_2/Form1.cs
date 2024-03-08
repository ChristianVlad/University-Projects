using Ejemplo_2.Models;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace Ejemplo_2
{
    public partial class Form1 : Form
    {
        private List<Producto> Productos = new List<Producto>();
        private int edit_indice = -1;

        public Form1()
        {
            InitializeComponent();
        }

        private void actualizarGrid()
        {
            dgvProductos.DataSource = null;
            dgvProductos.DataSource = Productos; 
        }
        private void reseteo()
        {
            tbxNombre.Clear();
            tbxDescripcion.Clear();
            tbxMarca.Clear();
            tbxPrecio.Clear();
            tbxStock.Clear();
            tbxImagenPath.Clear();
            tbxImagenPath.Enabled = true;
        }

        private void dgvProductos_DoubleClick(object sender, EventArgs e)
        {
            if (dgvProductos.CurrentRow == null) return;

            // Suponiendo que guardaste la ruta de la imagen en una columna del DataGridView o en el objeto de producto directamente
            string imagenPath = dgvProductos.CurrentRow.Cells["ImagenPath"].Value.ToString();

            if (!string.IsNullOrEmpty(imagenPath) && File.Exists(imagenPath))
            {
                Form formImagen = new Form
                {
                    Width = 600,
                    Height = 400,
                    FormBorderStyle = FormBorderStyle.FixedDialog
                };

                PictureBox pictureBox = new PictureBox
                {
                    Image = Image.FromFile(imagenPath),
                    Dock = DockStyle.Fill
                };

                formImagen.Controls.Add(pictureBox);
                formImagen.ShowDialog();
            }
            else
            {
                MessageBox.Show("Imagen no disponible.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        private void btnGuardar_Click(object sender, EventArgs e)
        {
            float.TryParse(tbxPrecio.Text, out float precio);
            int.TryParse(tbxStock.Text, out int stock);

            Producto product = new Producto();
            product.Nombre = tbxNombre.Text;
            product.Descripcion = tbxDescripcion.Text;
            product.Marca = tbxMarca.Text;
            product.Precio = precio;
            product.Stock = stock;
            product.ImagenPath = tbxImagenPath.Text;

            if (edit_indice > -1)
            {
                Productos[edit_indice] = product;
                edit_indice = -1;
            }
            else
            {
                Productos.Add(product); 
            }

            actualizarGrid();
            reseteo();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (edit_indice > -1)
            {
                string imagenPath = dgvProductos.Rows[edit_indice].Cells["ImagenPath"].Value?.ToString();

                // Validar si el path de la imagen es no nulo y si el archivo existe
                if (!string.IsNullOrEmpty(imagenPath) && File.Exists(imagenPath))
                {
                    try
                    {
                        // Intentar eliminar el archivo de imagen
                        File.Delete(imagenPath);
                    }
                    catch (Exception ex)
                    {
                        // Manejar el error, por ejemplo, no se pudo eliminar el archivo por estar en uso
                        MessageBox.Show($"No se pudo eliminar la imagen: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return; // Opcional: decidir si permitir la eliminación del producto si la imagen no se puede eliminar
                    }
                }

                // Eliminar el producto de la colección
                Productos.RemoveAt(edit_indice);
                edit_indice = -1; // Restablecer el índice seleccionado

                reseteo(); // Resetear la interfaz o cualquier estado relevante
                actualizarGrid(); // Actualizar el DataGridView para reflejar los cambios
            }
            else
            {
                MessageBox.Show("Dar click sobre elemento para seleccionar y borrar", "Seleccione un Producto", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnCargarImagen_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                // Configurar el OpenFileDialog
                openFileDialog.Title = "Seleccionar imagen del producto";
                openFileDialog.Filter = "Archivos de imagen (*.jpg;*.jpeg;*.png;*.bmp)|*.jpg;*.jpeg;*.png;*.bmp";

                // Mostrar el diálogo para seleccionar un archivo
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    // Obtener el nombre de archivo seleccionado
                    string archivoSeleccionado = openFileDialog.FileName;

                    // Definir la carpeta de destino para las imágenes
                    string carpetaDestino = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "Ejercicio_2", "ImagenesProductos");

                    // Crear la carpeta si no existe
                    Directory.CreateDirectory(carpetaDestino);

                    // Generar un nuevo nombre de archivo para evitar sobreescrituras
                    // Puedes ajustar esto para incluir identificadores únicos del producto
                    string nombreArchivoDestino = Guid.NewGuid().ToString() + Path.GetExtension(archivoSeleccionado);

                    // Ruta completa del nuevo archivo
                    string rutaCompletaDestino = Path.Combine(carpetaDestino, nombreArchivoDestino);

                    try
                    {
                        // Copiar el archivo seleccionado a la nueva ubicación
                        File.Copy(archivoSeleccionado, rutaCompletaDestino);

                        tbxImagenPath.Text = rutaCompletaDestino;
                        tbxImagenPath.Enabled = !File.Exists(rutaCompletaDestino);

                        MessageBox.Show("Imagen cargada con éxito.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error al cargar la imagen: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void dgvProductos_Click(object sender, EventArgs e)
        {
            DataGridViewRow selected = dgvProductos.SelectedRows[0];
            int posicion = dgvProductos.Rows.IndexOf(selected);
            edit_indice = posicion;
            Producto product = Productos[posicion];
            tbxNombre.Text = product.Nombre;
            tbxDescripcion.Text = product.Descripcion;
            tbxMarca.Text = product.Marca;
            tbxImagenPath.Text = product.ImagenPath;
            tbxPrecio.Text = Convert.ToString(product.Precio);
            tbxStock.Text = Convert.ToString(product.Stock);
        }
    }
}
