using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_pollo
{
    public partial class AltaProductoFrm : Form
    {
        public AltaProductoFrm()
        {
            InitializeComponent();
        }

        private void CrearProductoBtn_Click(object sender, EventArgs e)
        {
            // Cadena de conexión a la base de datos Access
            string cadenaConexion = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Resources\\Db.pollos.accdb";

            // Validar campos de texto
            if (string.IsNullOrWhiteSpace(txtDescripcion.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtPlanta.Text) ||
                string.IsNullOrWhiteSpace(txtRepeticion.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos de texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar selección única en cada grupo de CheckBox
            if (!ValidarSeleccionUnica(grpConservacion) ||
                !ValidarSeleccionUnica(grpGrado) ||
                !ValidarSeleccionUnica(grpTipoProducto))
            {
                MessageBox.Show("Debe seleccionar una única opción en cada categoría (Conservación, Grado y Tipo de Producto).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener valores de los CheckBox seleccionados
            string conservacion = ObtenerSeleccion(grpConservacion);
            string grado = ObtenerSeleccion(grpGrado);
            string tipoProducto = ObtenerSeleccion(grpTipoProducto);

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadenaConexion))
                {
                    conexion.Open();

                    // Consulta SQL para insertar los datos
                    string query = "INSERT INTO Producto (descripcion, codigo_producto, planta, tipo_producto, conservacion, grado, repeticion, habilitado, pathEtiqueta) " +
                                    "VALUES (@descripcion, @codigo_producto, @planta, @tipo_producto, @conservacion, @grado, @repeticion, @habilitado, @pathEtiqueta)";

                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        // Agregar los valores
                        comando.Parameters.AddWithValue("@descripcion", txtDescripcion.Text);
                        comando.Parameters.AddWithValue("@codigo_producto", txtCodigo.Text);
                        comando.Parameters.AddWithValue("@planta", txtPlanta.Text);
                        comando.Parameters.AddWithValue("@tipo_producto", tipoProducto);
                        comando.Parameters.AddWithValue("@conservacion", conservacion);
                        comando.Parameters.AddWithValue("@grado", grado);
                        comando.Parameters.AddWithValue("@repeticion", txtRepeticion.Text);
                        comando.Parameters.AddWithValue("@habilitado", true);
                        comando.Parameters.AddWithValue("@pathEtiqueta", textPathEtiqueta.Text);

                        // Ejecutar la consulta
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto agregado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            LimpiarCampos();
                        }
                        else
                        {
                            MessageBox.Show("No se pudo agregar el producto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    conexion.Close();
                    Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al insertar datos en la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        // Función para validar que solo un CheckBox esté seleccionado en un GroupBox
        private bool ValidarSeleccionUnica(GroupBox groupBox)
        {
            int seleccionados = 0;
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    seleccionados++;
                }
            }
            return seleccionados == 1; // Solo debe haber uno seleccionado
        }

        // Función para obtener el texto del CheckBox seleccionado en un GroupBox
        private string ObtenerSeleccion(GroupBox groupBox)
        {
            foreach (Control control in groupBox.Controls)
            {
                if (control is RadioButton radioButton && radioButton.Checked)
                {
                    return radioButton.Text; // Devuelve el texto del CheckBox seleccionado
                }
            }
            return string.Empty; // Si no hay ninguno seleccionado
        }

        // Función para limpiar los campos después de la inserción
        private void LimpiarCampos()
        {
            txtDescripcion.Clear();
            txtCodigo.Clear();
            txtPlanta.Clear();
            txtRepeticion.Clear();

            // Desmarcar todos los CheckBox
            foreach (Control control in grpConservacion.Controls) if (control is RadioButton cb) cb.Checked = false;
            foreach (Control control in grpGrado.Controls) if (control is RadioButton cb) cb.Checked = false;
            foreach (Control control in grpTipoProducto.Controls) if (control is RadioButton cb) cb.Checked = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bunSelEtq_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                textPathEtiqueta.Text = openFileDialog1.FileName;
            }
        }
    }
}