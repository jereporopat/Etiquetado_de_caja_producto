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
    public partial class Reporte : Form
    {
        public Reporte()
        {
            InitializeComponent();
        }

        private void Reporte_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla '_Db_pollosDataSet.Etiquetas_impresas' Puede moverla o quitarla según sea necesario.
            this.etiquetas_impresasTableAdapter.Fill(this._Db_pollosDataSet.Etiquetas_impresas);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.etiquetas_impresasTableAdapter.FillBy(this._Db_pollosDataSet.Etiquetas_impresas);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sin Implementar.");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Sin Implementar.");
        }
    }
}
