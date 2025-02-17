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
    public partial class EditDeleteFrm : Form
    {
        string filePath="";

        string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Db.pollos.accdb";
        public EditDeleteFrm()
        {
            InitializeComponent();
            CargarProductosEnListBox();
        }
        private void CargarProductosEnListBox()
        {
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    conexion.Open();
                    string consulta = "SELECT codigo_producto, descripcion FROM Producto";

                    using (OleDbCommand comando = new OleDbCommand(consulta, conexion))
                    using (OleDbDataReader lector = comando.ExecuteReader())
                    {
                        datosLb.Items.Clear();

                        while (lector.Read())
                        {
                            string codigo = lector["codigo_producto"].ToString();
                            string descripcion = lector["descripcion"].ToString();
                            datosLb.Items.Add($"{codigo} - {descripcion}");
                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar productos: " + ex.Message);
            }
        }

        private void DatosLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (datosLb.SelectedItem != null)
            {
                // Obtener el texto seleccionado
                string seleccionado = datosLb.SelectedItem.ToString();

                // Extraer el código del producto antes del guion "-"
                string codigoProducto = seleccionado.Split('-')[0].Trim();

                // Cargar los datos del producto en base al código seleccionado
                CargarDatosProducto(codigoProducto);
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            // Validar que el código de producto no esté vacío
            if (string.IsNullOrWhiteSpace(codigoDeProductoTb.Text))
            {
                MessageBox.Show("Debe seleccionar un producto antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener los valores actualizados de los controles del formulario
            string codigoProducto = codigoDeProductoTb.Text;
            string descripcion = descripcionTb.Text;
            string planta = plantaTb.Text;
            string repeticion = repeticionTb.Text;
            int tipoProducto = chkTipo1.Checked ? 1 : chkTipo2.Checked ? 2 : 0;
            int conservacion = chkConservacion1.Checked ? 1 : chkConservacion2.Checked ? 2 : 0;
            int grado = chkGrado1.Checked ? 1 : chkGrado2.Checked ? 2 : 0;

            string etiqueta;
            if (filePath != "")
                etiqueta = filePath;

            //Validar campos de texto
            if (string.IsNullOrWhiteSpace(descripcionTb.Text) ||
                string.IsNullOrWhiteSpace(codigoDeProductoTb.Text) ||
                string.IsNullOrWhiteSpace(plantaTb.Text) ||
                string.IsNullOrWhiteSpace(repeticionTb.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos de texto.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Validar selección única en cada grupo de CheckBox
            if (!ValidarSeleccionUnica(conservacionGb) ||
                !ValidarSeleccionUnica(gradoGb) ||
                !ValidarSeleccionUnica(tipoProductoGb))
            {
                MessageBox.Show("Debe seleccionar una única opción en cada categoría (Conservación, Grado y Tipo de Producto).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string query = @"UPDATE Producto 
                     SET descripcion = @descripcion, 
                         planta = @planta, 
                         repeticion = @repeticion, 
                         tipo_producto = @tipoProducto, 
                         conservacion = @conservacion, 
                         grado = @grado, 
                         pathEtiqueta = @etiqueta

                     WHERE codigo_producto = @codigoProducto";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    conexion.Open();
                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        // Agregar parámetros
                        comando.Parameters.AddWithValue("@descripcion", descripcion);
                        comando.Parameters.AddWithValue("@planta", planta);
                        comando.Parameters.AddWithValue("@repeticion", repeticion);
                        comando.Parameters.AddWithValue("@tipoProducto", tipoProducto);
                        comando.Parameters.AddWithValue("@conservacion", conservacion);
                        comando.Parameters.AddWithValue("@grado", grado);
                        comando.Parameters.AddWithValue("@codigoProducto", codigoProducto);
                        comando.Parameters.AddWithValue("@etiqueta",filePath);

                        // Ejecutar actualización
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto actualizado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Recargar los productos en la lista para reflejar los cambios
                            CargarDatosProducto(codigoProducto);
                        }
                        else
                        {
                            MessageBox.Show("No se encontró el producto para actualizar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al actualizar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private bool ValidarSeleccionUnica(GroupBox groupBox)
        {
            int seleccionados = 0;
            foreach (Control control in groupBox.Controls)
            {
                if (control is CheckBox checkBox && checkBox.Checked)
                {
                    seleccionados++;
                }
            }
            return seleccionados == 1; // Solo debe haber uno seleccionado
        }

        private void CargarDatosProducto(string codigoProducto)
        {
            string query = "SELECT * FROM Producto WHERE codigo_producto = @codigo";

            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    conexion.Open();
                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        comando.Parameters.AddWithValue("@codigo", codigoProducto);

                        using (OleDbDataReader lector = comando.ExecuteReader())
                        {
                            if (lector.Read())
                            {
                                // Llenar los campos con los datos obtenidos de la base de datos
                                codigoDeProductoTb.Text = lector["codigo_producto"].ToString();
                                descripcionTb.Text = lector["descripcion"].ToString();
                                plantaTb.Text = lector["planta"].ToString();
                                repeticionTb.Text = lector["repeticion"].ToString();

                                // Limpiar los CheckBoxes antes de marcar los correspondientes
                                chkTipo1.Checked = false;
                                chkTipo2.Checked = false;
                                chkConservacion1.Checked = false;
                                chkConservacion2.Checked = false;
                                chkGrado1.Checked = false;
                                chkGrado2.Checked = false;

                                // Asignar valores a los CheckBoxes
                                int tipoProducto = Convert.ToInt32(lector["tipo_producto"]);
                                int conservacion = Convert.ToInt32(lector["conservacion"]);
                                int grado = Convert.ToInt32(lector["grado"]);

                                chkTipo1.Checked = (tipoProducto == 1);
                                chkTipo2.Checked = (tipoProducto == 2);
                                chkConservacion1.Checked = (conservacion == 1);
                                chkConservacion2.Checked = (conservacion == 2);
                                chkGrado1.Checked = (grado == 1);
                                chkGrado2.Checked = (grado == 2);

                                textNomEtiqueta.Text = lector["pathEtiqueta"].ToString();

                                
                                int i = textNomEtiqueta.Text.LastIndexOf("\\");
                                textNomEtiqueta.Text = textNomEtiqueta.Text.Substring(i + 1);
                                i = textNomEtiqueta.Text.LastIndexOf('.');
                                textNomEtiqueta.Text = textNomEtiqueta.Text.Remove(i, 4);

                                // Habilitar los botones de edición y eliminación
                                //btnGuardar.Enabled = true;
                                //btnEliminar.Enabled = true;
                            }
                            else
                            {
                                MessageBox.Show("Producto no encontrado en la base de datos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar el producto desde la base de datos: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            // Validar que haya un producto seleccionado
            if (string.IsNullOrWhiteSpace(codigoDeProductoTb.Text))
            {
                MessageBox.Show("Debe seleccionar un producto antes de eliminar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigoProducto = codigoDeProductoTb.Text;
            bool habilitado = false;

            string query = @"UPDATE Producto 
                     SET habilitado = @habilitado
                     WHERE codigo_producto = @codigoProducto";
            try
            {
                using (OleDbConnection conexion = new OleDbConnection(cadena))
                {
                    conexion.Open();
                    using (OleDbCommand comando = new OleDbCommand(query, conexion))
                    {
                        // Agregar parámetros
                        comando.Parameters.AddWithValue("@habilitado", habilitado);
                        comando.Parameters.AddWithValue("@codigoProducto", codigoProducto);

                        // Ejecutar la consulta
                        int filasAfectadas = comando.ExecuteNonQuery();

                        if (filasAfectadas > 0)
                        {
                            MessageBox.Show("Producto eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            // Limpiar los campos del formulario
                            LimpiarFormulario();

                            // Recargar la lista de productos
                            CargarProductosEnListBox();
                        }
                    }
                    conexion.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al eliminar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private void LimpiarFormulario()
        {
            codigoDeProductoTb.Clear();
            descripcionTb.Clear();
            plantaTb.Clear();
            repeticionTb.Clear();
            chkTipo1.Checked = false;
            chkTipo2.Checked = false;
            chkConservacion1.Checked = false;
            chkConservacion2.Checked = false;
            chkGrado1.Checked = false;
            chkGrado2.Checked = false;
        }

        private void plantaTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void plantaLbl_Click(object sender, EventArgs e)
        {

        }

        private void descripcionTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void descripcionLbl_Click(object sender, EventArgs e)
        {

        }

        private void codigoDeProductoTb_TextChanged(object sender, EventArgs e)
        {

        }

        private void codigoProductoLbl_Click(object sender, EventArgs e)
        {

        }

        private void chkConservacion1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void conservacionGb_Enter(object sender, EventArgs e)
        {

        }

        private void gradoGb_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)  
                {
                    filePath = openFileDialog1.FileName;
                }
        }
    }
}
        
