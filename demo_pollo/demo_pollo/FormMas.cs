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
    public partial class FormMas : Form
    {
        public FormMas()
        {
            InitializeComponent();

            this.MaximumSize = SystemInformation.PrimaryMonitorMaximizedWindowSize;
            this.WindowState = FormWindowState.Maximized;
        }

        private void EtiNuevaBtn_Click(object sender, EventArgs e)
        {
            try
            {
                // Ruta del ejecutable de Zebra Designer
                string rutaZebraDesigner = @"D:\Zebra Technologies\ZebraDesigner 3\bin.net\ZebraDesigner.exe";

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
    }
}
