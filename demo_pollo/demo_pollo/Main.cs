using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_pollo
{
    public partial class Main : Form
    {
        private Rectangle buttonOriginalRectangle;
        private Rectangle originalFormSize;
        // Diccionario para asociar códigos con productos
        private Dictionary<int, string> productos = new Dictionary<int, string>
        {
            { 1, "Pollo refrigerado con menudos A" },
            { 2, "Pollo congelado con menudos A" },
            { 3, "Pata muslo" },
            { 4, "Pata muslo con lomo" },
            { 5, "Suprema" },
            { 6, "Alas" },
            { 7, "CMS" },
            { 8, "Piel" },
            { 9, "Menudo" },
            { 10, "Corazones" },
            { 11, "Garras" }
        };
        // Para almacenar temporalmente el código ingresado
        StringBuilder codigoActual = new StringBuilder();
        private Button ultimoBotonPresionado = null;
        public Main()
        {
            InitializeComponent();

            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;

        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //originalFormSize = this.Size;
            //buttonOriginalRectangle = new Rectangle(button1.Location.X, button1.Location.Y, button1.Width, button1.Height);
            // Cargar productos en el ListBox
            foreach (var producto in productos.Values)
            {
                listBoxItems.Items.Add(producto);
            }
        }
        private void btnExaminar_Click(object sender, EventArgs e)
        {

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                string filePath = openFileDialog1.FileName;
                MessageBox.Show($"Archivo seleccionado: {filePath}");
                // Mostrar el nombre del archivo seleccionado en el Label.
                lblNombreArchivo.Text = Path.GetFileName(openFileDialog1.FileName);
            }
        }


        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Obtén el producto seleccionado en el ListBox
            if (listBoxItems.SelectedItem != null)
            {
                string selectedItem = listBoxItems.SelectedItem.ToString();
                CargarDatosProducto(selectedItem);
            }
        }
        private void GenerarCodigo()
        {
            if (string.IsNullOrEmpty(txtPlanta.Text) ||
                string.IsNullOrEmpty(txtProducto.Text) ||
                string.IsNullOrEmpty(txtTipoProducto.Text) ||
                string.IsNullOrEmpty(txtConservacion.Text) ||
                string.IsNullOrEmpty(txtGrado.Text) ||
                string.IsNullOrEmpty(txtCalibre.Text) ||
                string.IsNullOrEmpty(txtRepeticion.Text))
            {
                // Si falta algún dato, no se genera el código
                txtCodigo.Text = "Datos incompletos";
                return;
            }

            // Mapeo de valores específicos para el código
            string tipoProductoCode = txtTipoProducto.Text == "Entero" ? "1" : "2";
            string conservacionCode = txtConservacion.Text == "Refrigerado" ? "1" : "2";

            // Genera el código
            txtCodigo.Text = $"{txtPlanta.Text}{txtProducto.Text}{tipoProductoCode}{conservacionCode}{txtGrado.Text}{txtCalibre.Text}{txtRepeticion.Text}";
        }

        private void btnCalibre_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; // El botón que disparó el evento.

            customButton1.BackColor = Color.DarkSeaGreen;
            customButton2.BackColor = Color.DarkSeaGreen;
            customButton3.BackColor = Color.DarkSeaGreen;
            customButton4.BackColor = Color.DarkSeaGreen;
            customButton5.BackColor = Color.DarkSeaGreen;
            customButton7.BackColor = Color.DarkSeaGreen;
            btn.BackColor = Color.OrangeRed;

            txtCalibre.Text = btn.Text; // Asigna el texto del botón al campo de calibre.
            GenerarCodigo(); // Regenera el código con la nueva información.

        }
        private void btnNumpad_Click(object sender, EventArgs e)
        {
            Button btn = sender as Button; // Obtener el botón presionado
            if (btn != null)
            {
                // Restaurar el color original del último botón presionado
                if (ultimoBotonPresionado != null)
                {
                    ultimoBotonPresionado.BackColor = SystemColors.AppWorkspace; // Color predeterminado
                }

                // Cambiar el color del botón actualmente presionado
                btn.BackColor = Color.OrangeRed;

                // Guardar el botón actual como último presionado
                ultimoBotonPresionado = btn;

                // Agregar el número presionado al código actual
                codigoActual.Append(btn.Text);

                // Si el código tiene 2 dígitos, buscar el producto
                if (codigoActual.Length == 2)
                {
                    BuscarProductoPorCodigo();
                    codigoActual.Clear(); // Limpiar el código después de buscar
                }
            }
        }
        // Buscar el producto por el código ingresado
        private void BuscarProductoPorCodigo()
        {
            if (int.TryParse(codigoActual.ToString(), out int codigo))
            {
                // Buscar el producto en el diccionario
                if (productos.TryGetValue(codigo, out string producto))
                {
                    MessageBox.Show($"Producto encontrado: {producto}", "Información");

                    // Seleccionar el producto en el ListBox
                    listBoxItems.SelectedItem = producto;

                    // Cargar los datos del producto
                    CargarDatosProducto(producto);
                }
                else
                {
                    MessageBox.Show("Código no válido. Intente nuevamente.", "Error");
                }
            }
        }



        private void CargarDatosProducto(string producto)
        {
            // Llena los campos de datos según el producto seleccionado
            switch (producto)
            {
                case "Pollo refrigerado con menudos A":
                    txtDescripcion.Text = "Pollo refrigerado con menudos A";
                    txtPlanta.Text = "1519";
                    txtProducto.Text = "01";
                    txtTipoProducto.Text = "Entero";
                    txtConservacion.Text = "Refrigerado";
                    txtGrado.Text = "1";
                    txtRepeticion.Text = "0001";
                    break;

                case "Pollo congelado con menudos A":
                    txtDescripcion.Text = "Pollo congelado con menudos A";
                    txtPlanta.Text = "1519";
                    txtProducto.Text = "02";
                    txtTipoProducto.Text = "Entero";
                    txtConservacion.Text = "Congelado";
                    txtGrado.Text = "1";
                    txtRepeticion.Text = "0003";
                    break;

                case "Pata muslo":
                    txtDescripcion.Text = "Pata muslo";
                    txtPlanta.Text = "1519";
                    txtProducto.Text = "03";
                    txtTipoProducto.Text = "Trozado";
                    txtConservacion.Text = "Refrigerado";
                    txtGrado.Text = "2";
                    txtRepeticion.Text = "0005";
                    break;

                case "Pata muslo con lomo":
                    txtDescripcion.Text = "Pata muslo con lomo";
                    txtPlanta.Text = "1519";
                    txtProducto.Text = "04";
                    txtTipoProducto.Text = "Trozado";
                    txtConservacion.Text = "Refrigerado";
                    txtGrado.Text = "2";
                    txtRepeticion.Text = "0006";
                    break;

                case "Suprema":
                    txtDescripcion.Text = "Suprema";
                    txtPlanta.Text = "1519";
                    txtProducto.Text = "05";
                    txtTipoProducto.Text = "Trozado";
                    txtConservacion.Text = "Refrigerado";
                    txtGrado.Text = "1";
                    txtRepeticion.Text = "0007";
                    break;

                case "Alas":
                    txtDescripcion.Text = "Alas";
                    txtPlanta.Text = "1519";
                    txtProducto.Text = "06";
                    txtTipoProducto.Text = "Trozado";
                    txtConservacion.Text = "Refrigerado";
                    txtGrado.Text = "2";
                    txtRepeticion.Text = "0008";
                    break;

                case "CMS":
                    txtDescripcion.Text = "CMS";
                    txtPlanta.Text = "1519";
                    txtProducto.Text = "07";
                    txtTipoProducto.Text = "Trozado";
                    txtConservacion.Text = "Congelado";
                    txtGrado.Text = "2";
                    txtRepeticion.Text = "0009";
                    break;

                case "Piel":
                    txtDescripcion.Text = "Piel";
                    txtPlanta.Text = "1519";
                    txtProducto.Text = "08";
                    txtTipoProducto.Text = "Trozado";
                    txtConservacion.Text = "Congelado";
                    txtGrado.Text = "2";
                    txtRepeticion.Text = "0010";
                    break;

                case "Menudo":
                    txtDescripcion.Text = "Menudo";
                    txtPlanta.Text = "1519";
                    txtProducto.Text = "09";
                    txtTipoProducto.Text = "Trozado";
                    txtConservacion.Text = "Congelado";
                    txtGrado.Text = "2";
                    txtRepeticion.Text = "0011";
                    break;

                case "Corazones":
                    txtDescripcion.Text = "Corazones";
                    txtPlanta.Text = "1519";
                    txtProducto.Text = "10";
                    txtTipoProducto.Text = "Trozado";
                    txtConservacion.Text = "Congelado";
                    txtGrado.Text = "2";
                    txtRepeticion.Text = "0012";
                    break;

                case "Garras":
                    txtDescripcion.Text = "Garras";
                    txtPlanta.Text = "1519";
                    txtProducto.Text = "11";
                    txtTipoProducto.Text = "Trozado";
                    txtConservacion.Text = "Congelado";
                    txtGrado.Text = "2";
                    txtRepeticion.Text = "0013";
                    break;
            }

            // Limpia el calibre y genera el código actualizado
            txtCalibre.Text = "";
            GenerarCodigo();
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == Keys.Escape)
            {
                this.Close(); // Cierra la aplicación
                return true; // Indica que se procesó la tecla
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }

        private void customButton5_Click(object sender, EventArgs e)
        {

        }

        private void customButton3_Click(object sender, EventArgs e)
        {

        }

        private void customButton7_Click(object sender, EventArgs e)
        {

        }

        private void customButton4_Click(object sender, EventArgs e)
        {

        }

        private void btnNumPad_Click(object sender, EventArgs e)
        {

        }

        private void btnMas_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Crear una instancia del formulario que deseas abrir
            FormMas Mas = new FormMas();

            Mas.ShowDialog(); // Abre como ventana independiente

            // Mostrar nuevamente el formulario principal después de cerrar el secundario
            this.Show();
        }
    }

}