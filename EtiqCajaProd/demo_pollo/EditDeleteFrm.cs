using demo_pollo.Compartidos;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace demo_pollo
{
    public partial class EditDeleteFrm : Form
    {
        string filePath="";
        List<Producto> products = new List<Producto>();

        string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Db.pollos.accdb";
        public EditDeleteFrm()
        {
            InitializeComponent();
            CargarProductosEnListBox();
        }
        private void CargarProductosEnListBox()
        {
            List<Producto> productos = BBDD.BuscarProductos();

            foreach (Producto producto in productos)
            {
                datosLb.Items.Add(producto);
            }
        }

        private void DatosLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (datosLb.SelectedItem != null)
            {
                // Obtengo el producto seleccionado
                Producto productoSeleccionado = (Producto)datosLb.SelectedItem;

                CargarDatosProducto(productoSeleccionado);
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
            Producto productoSeleccionado = (Producto)datosLb.SelectedItem;

            if (productoSeleccionado == null)
            {
                MessageBox.Show("Debe seleccionar un producto antes de guardar.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //Validar campos de texto
            if (string.IsNullOrWhiteSpace(codigoDeProductoTb.Text) ||
                string.IsNullOrWhiteSpace(descripcionTb.Text) ||
                string.IsNullOrWhiteSpace(codigoDeProductoTb.Text) ||
                string.IsNullOrWhiteSpace(plantaTb.Text) ||
                string.IsNullOrWhiteSpace(repeticionTb.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }


            if (!ValidarSeleccionUnica(conservacionGb) ||
                !ValidarSeleccionUnica(gradoGb) ||
                !ValidarSeleccionUnica(tipoProductoGb))
            {
                MessageBox.Show("Debe seleccionar una única opción en cada categoría (Conservación, Grado y Tipo de Producto).",
                                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Obtener los valores actualizados de los controles del formulario
            productoSeleccionado.setCodigoProducto(codigoDeProductoTb.Text);
            productoSeleccionado.setDescripcion(descripcionTb.Text);
            productoSeleccionado.setPlanta(int.Parse(plantaTb.Text));
            productoSeleccionado.setRepeticion(repeticionTb.Text);
            productoSeleccionado.setCodigoProducto(codigoDeProductoTb.Text);

            // Determinamos los valores según los checkboxes
            productoSeleccionado.setTipoProducto(chkTipo1.Checked ? 1 : chkTipo2.Checked ? 2 : 0);
            productoSeleccionado.setConservacion(chkConservacion1.Checked ? 1 : chkConservacion2.Checked ? 2 : 0);
            productoSeleccionado.setGrado(chkGrado1.Checked ? 1 : chkGrado2.Checked ? 2 : 0);

            // Asignamos la etiqueta
            productoSeleccionado.setPathEtiqueta(filePath);

            BBDD.ActualizarProducto(productoSeleccionado);


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

        private void CargarDatosProducto(Producto producto)
        {
            // Llenar los campos con los datos obtenidos de la base de datos
            codigoDeProductoTb.Text = producto.getCodigoProducto();
            descripcionTb.Text = producto.getDescripcion();
            plantaTb.Text = producto.getPlanta().ToString();
            repeticionTb.Text = producto.getRepeticion();

            // Limpiar los CheckBoxes antes de marcar los correspondientes
            chkTipo1.Checked = false;
            chkTipo2.Checked = false;
            chkConservacion1.Checked = false;
            chkConservacion2.Checked = false;
            chkGrado1.Checked = false;
            chkGrado2.Checked = false;

            // Asignar valores a los CheckBoxes
            int tipoProducto = producto.getTipoProducto();
            int conservacion = producto.getConservacion();
            int grado = producto.getGrado();

            chkTipo1.Checked = (tipoProducto == 1);
            chkTipo2.Checked = (tipoProducto == 2);
            chkConservacion1.Checked = (conservacion == 1);
            chkConservacion2.Checked = (conservacion == 2);
            chkGrado1.Checked = (grado == 1);
            chkGrado2.Checked = (grado == 2);

            textPathEtiqueta.Text = producto.getPathEtiqueta();
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
                            MessageBox.Show("Producto deshabilitado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
                MessageBox.Show("Error al deshabilitar el producto: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)  
                {
                    filePath = openFileDialog1.FileName;
                    textPathEtiqueta.Text = filePath;
                }
        }
    }
}
        
