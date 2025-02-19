using demo_pollo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace demo_pollo
{
    public partial class MasFrm : Form
    {
        private Settings settings = Settings.Default;
        public MasFrm()
        {
            InitializeComponent();

          //  this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
          //  this.WindowState = FormWindowState.Maximized;

        }

        private void EtiNuevaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta del ejecutable de Zebra Designer

                //string rutaZebraDesigner = @"C:\Program Files\Zebra Technologies\ZebraDesigner 3\bin.net\ZebraDesigner.exe";

                string rutaZebraDesigner =  settings.Ruta_ZD + "\\ZebraDesigner.exe";


                // Verificar si el archivo existe antes de abrirlo
                if (System.IO.File.Exists(rutaZebraDesigner))
                {
                    Process.Start(rutaZebraDesigner);
                }
                else
                {
                    MessageBox.Show("No se encontró Zebra Designer en la ruta especificada.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al abrir Zebra Designer: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void customButton3_Click(object sender, EventArgs e)
        {
            Config Con = new Config();
            Con.Show();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customButton1_Click(object sender, EventArgs e)
        {

        }

        private void abmBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
            // Crear una instancia del formulario que deseas abrir

            AbmProductosFrm abmProductos = new AbmProductosFrm();

            abmProductos.ShowDialog(); // Abre como ventana independiente

            // Mostrar nuevamente el formulario principal después de cerrar el secundario
            this.Show();
        }

        private void reportesBtn_Click(object sender, EventArgs e)
        {

        }
    }
}
