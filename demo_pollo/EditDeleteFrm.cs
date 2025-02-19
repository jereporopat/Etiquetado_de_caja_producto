using demo_pollo.Compartidos;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Windows.Forms;

namespace demo_pollo
{
    public partial class EditDeleteFrm : Form
    {
        List<Producto> products = new List<Producto>();

        string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=" + Application.StartupPath + "\\Db.pollos.accdb";
        
        public EditDeleteFrm()
        {
            InitializeComponent();
            CargarProductosEnListBox();
            CargarListadosDeComboBox();
        }

        private void CargarListadosDeComboBox()
        {
            CargarComboBox(tipoProductoCb, "Tipo_de_producto");
            CargarComboBox(conservacionCb, "conservacion");
            CargarComboBox(gradoCb, "grado");
        }

        private void CargarComboBox(ComboBox comboBox, String tabla)
        {
            comboBox.DataSource = new BindingSource(BBDD.ObtenerDiccionarioDeOpciones(tabla), null);
            comboBox.DisplayMember = "value";
            comboBox.ValueMember = "key";
        }

        private void CargarProductosEnListBox()
        {
            datosLb.DataSource = BBDD.BuscarProductos();
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

            //Validar campos
            if (string.IsNullOrWhiteSpace(codigoDeProductoTb.Text) ||
                string.IsNullOrWhiteSpace(descripcionTb.Text) ||
                string.IsNullOrWhiteSpace(codigoDeProductoTb.Text) ||
                string.IsNullOrWhiteSpace(plantaTb.Text) ||
                string.IsNullOrWhiteSpace(repeticionTb.Text) ||
                tipoProductoCb.SelectedItem == null ||
                conservacionCb.SelectedItem == null ||
                gradoCb.SelectedItem == null)
            {
                MessageBox.Show("Por favor, complete todos los campos.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Obtener los valores actualizados de los controles del formulario
            productoSeleccionado.setCodigoProducto(codigoDeProductoTb.Text);
            productoSeleccionado.setDescripcion(descripcionTb.Text);
            productoSeleccionado.setPlanta(int.Parse(plantaTb.Text));
            productoSeleccionado.setRepeticion(repeticionTb.Text);
            productoSeleccionado.setCodigoProducto(codigoDeProductoTb.Text);
            productoSeleccionado.setPathEtiqueta(textPathEtiqueta.Text);

            productoSeleccionado.setTipoProducto((int)tipoProductoCb.SelectedValue);
            productoSeleccionado.setConservacion((int)conservacionCb.SelectedValue);
            productoSeleccionado.setGrado((int)gradoCb.SelectedValue);

            BBDD.ActualizarProducto(productoSeleccionado);

            datosLb.Refresh();
        }


        private void CargarDatosProducto(Producto producto)
        {
            // Llenar los campos con los datos obtenidos de la base de datos
            codigoDeProductoTb.Text = producto.getCodigoProducto();
            descripcionTb.Text = producto.getDescripcion();
            plantaTb.Text = producto.getPlanta().ToString();
            repeticionTb.Text = producto.getRepeticion();

            // Asignar valores a los ComboBox
            tipoProductoCb.SelectedValue = producto.getTipoProducto();
            conservacionCb.SelectedValue = producto.getConservacion();
            gradoCb.SelectedValue = producto.getGrado();

            textPathEtiqueta.Text = producto.getPathEtiqueta();

            CargarListBoxDeCalibres(producto);
        }

        private void CargarListBoxDeCalibres(Producto producto)
        {
            if (producto.getCalibres().Count > 0)
            {
                calibresLb.DataSource = new BindingSource(producto.getCalibres(), null);
                calibresLb.DisplayMember = "value";
                calibresLb.ValueMember = "key";
            }
            else
            {
                calibresLb.DataSource = null;
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
        }

        private void button1_Click(object sender, EventArgs e)
        {
           
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                    textPathEtiqueta.Text = openFileDialog1.FileName;
            }
        }

        private void agregarBtn_Click(object sender, EventArgs e)
        {
            Producto productoSeleccionado = (Producto)datosLb.SelectedItem;


            using (FormSeleccionCalibres formSeleccion = new FormSeleccionCalibres(productoSeleccionado.getCalibres()))
            {
                if (formSeleccion.ShowDialog() == DialogResult.OK)
                {
                    productoSeleccionado.setCalibres(formSeleccion.calibresSeleccionados);
                    CargarListBoxDeCalibres(productoSeleccionado);
                }
            }
        }

        private void removerBtn_Click(object sender, EventArgs e)
        {
            Producto productoSeleccionado = (Producto)datosLb.SelectedItem;

            KeyValuePair<int, string> calibre = (KeyValuePair<int, string>)calibresLb.SelectedItem;

            productoSeleccionado.getCalibres().Remove(calibre.Key);

            CargarListBoxDeCalibres(productoSeleccionado);
        }
    }
}
        
