using demo_pollo.Compartidos;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Drawing;
using System.Windows.Forms;

namespace demo_pollo
{
    public partial class EditDeleteFrm : Form
    {
        List<Producto> productos;
        Producto productoSeleccionado;

        string cadena = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Resources\\Db.pollos.accdb";
        
        public EditDeleteFrm()
        {
            InitializeComponent();
            CargarListaDeProductos();
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

        private void CargarListaDeProductos()
        {
            productos = BBDD.BuscarProductos();
            datosLb.DataSource = productos;
        }

        private void DatosLb_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (datosLb.SelectedItem != null)
            {
                // Obtengo el producto seleccionado
                productoSeleccionado = (Producto)datosLb.SelectedItem;

                CargarDatosProducto(productoSeleccionado);
            }
        }

        private void GuardarBtn_Click(object sender, EventArgs e)
        {
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
                string.IsNullOrWhiteSpace(textPathEtiqueta.Text) ||
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

            BBDD.GuardarProducto(productoSeleccionado);

            CargarListaDeProductos();
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

            ModificarBotonHabilitado();

            CargarListaDeCalibres(producto);
        }

        private void CargarListaDeCalibres(Producto producto)
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

        private void ModificarBotonHabilitado()
        {
            if (productoSeleccionado.getHabilitado())
            {
                habilitacionBtn.Text = "DESHABILITAR";
                habilitacionBtn.BackColor = Color.Red;
            }
            else
            {
                habilitacionBtn.Text = "HABILITAR";
                habilitacionBtn.BackColor = Color.Blue;
            }
        }

        private void CancelarBtn_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            productoSeleccionado.setHabilitado(!productoSeleccionado.getHabilitado());
            BBDD.ActualizarHabilitacionDeProducto(productoSeleccionado);
            CargarListaDeProductos();
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

        private void agregarCalibreBtn_Click(object sender, EventArgs e)
        {
            using (FormSeleccionCalibres formSeleccion = new FormSeleccionCalibres(productoSeleccionado.getCalibres()))
            {
                if (formSeleccion.ShowDialog() == DialogResult.OK)
                {
                    productoSeleccionado.setCalibres(formSeleccion.calibresSeleccionados);
                    CargarListaDeCalibres(productoSeleccionado);
                }
            }
        }

        private void removerCalibreBtn_Click(object sender, EventArgs e)
        {
            KeyValuePair<int, string> calibre = (KeyValuePair<int, string>)calibresLb.SelectedItem;

            productoSeleccionado.getCalibres().Remove(calibre.Key);

            CargarListaDeCalibres(productoSeleccionado);
        }

        private void agregarProductoBtn_Click(object sender, EventArgs e)
        {
            if(productos.FindAll(p => p.getHabilitado()).Count >= 15){
                MessageBox.Show("No puede haber mas de 15 productos habilitados", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                Producto nuevoProducto = new Producto();
                nuevoProducto.setHabilitado(true);
                nuevoProducto.setDescripcion("Nuevo producto");

                productos.Add(nuevoProducto);

                datosLb.ClearSelected();
                productoSeleccionado = nuevoProducto;
                CargarDatosProducto(productoSeleccionado);
            }
        }

        private void datosLb_DrawItem(object sender, DrawItemEventArgs e)
        {
            if (e.Index < 0) return;

            Producto producto = (Producto)datosLb.Items[e.Index];

            // Detectar si el ítem está seleccionado
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // Definir colores
            Color backColor = isSelected ? SystemColors.Highlight : (producto.getHabilitado() ? Color.White : Color.Orange);
            Color textColor = isSelected ? SystemColors.HighlightText : Color.Black;

            // Dibujar fondo del ítem
            e.Graphics.FillRectangle(new SolidBrush(backColor), e.Bounds);

            // Dibujar texto del ítem
            e.Graphics.DrawString(producto.getDescripcion(), e.Font, new SolidBrush(textColor), e.Bounds, StringFormat.GenericDefault);

            // Dibujar borde si el elemento está seleccionado
            e.DrawFocusRectangle();
        }
    }
}
        
