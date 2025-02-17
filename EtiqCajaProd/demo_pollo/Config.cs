using demo_pollo.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;


namespace demo_pollo
{
    public partial class Config : Form
    {
        private Settings settings = Settings.Default;

        public Config()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void LoadSettings()
        {
            tB_IP_Zebra.Text = settings.IP_Zebra;
            tB_Mask_Z.Text = settings.Mask_Z;
            //tB_Ruta_ZD.Text. = "C:\\Program Files\\Zebra Technologies\\ZebraDesigner 3\\bin.net";//settings.Ruta_ZD;
           // tB_Ruta_ZD.AppendText("C:\\Program Files\\Zebra Technologies\\ZebraDesigner 3\\bin.net");
           tB_Ruta_ZD.AppendText(settings.Ruta_ZD.ToString());
        }



        private void SaveSettings()
        {
            settings.IP_Zebra = tB_IP_Zebra.Text;
            settings.Mask_Z = tB_Mask_Z.Text;
            settings.Ruta_ZD = tB_Ruta_ZD.Text;


            settings.Save();
        }

        private void bt_cancelar_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }

        private void bt_Terminar_Click(object sender, EventArgs e)
        {
            SaveSettings();

            DialogResult res = MessageBox.Show("Se Actualizarán los cambios de la Configuración.", "Información sobre la Configuración", MessageBoxButtons.OKCancel, MessageBoxIcon.Information);

            DialogResult = res;
            Close();
        }
    }
}
