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

namespace demo_pollo
{
    public partial class AbmProductosFrm : Form
    {
        private Settings settings = Settings.Default;

        public AbmProductosFrm()
        {
            InitializeComponent();
            LoadSettings();
        }

        private void volverBtn_Click(object sender, EventArgs e)
        {
            SaveSettings();
            this.Close();
        }

        private void crearBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            AltaProductoFrm altaProductoFrm = new AltaProductoFrm();

            altaProductoFrm.ShowDialog();

            this.Show();
        }

        private void editDeleteBtn_Click(object sender, EventArgs e)
        {
            this.Hide();

            EditDeleteFrm editDeleteFrm = new EditDeleteFrm();

            editDeleteFrm.ShowDialog();

            this.Show();
        }


        private void LoadSettings()
        {
            textBox1.Text = settings.senasa1;
            textBox2.Text = settings.senasa2;
            textBox3.Text = settings.senasa3;

        }

        private void SaveSettings()
        {
            settings.senasa1 = textBox1.Text;
            settings.senasa2 = textBox2.Text;
            settings.senasa3 = textBox3.Text;


            settings.Save();
        }
    }
}
