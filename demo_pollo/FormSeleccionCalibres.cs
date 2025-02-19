using demo_pollo.Compartidos;
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
    public partial class FormSeleccionCalibres : Form
    {
        public Dictionary<int, string> calibresSeleccionados;

        public FormSeleccionCalibres(Dictionary<int, string> calibresSeleccionados)
        {
            InitializeComponent();
            calibresLb.CheckOnClick = true;

            this.calibresSeleccionados = calibresSeleccionados;

            cargarCalibres();
        }

        private void cargarCalibres()
        {
            Dictionary<int, string> calibresDisponibles = BBDD.ObtenerDiccionarioDeOpciones("calibre");
            calibresLb.DataSource = new BindingSource(calibresDisponibles, null);
            calibresLb.DisplayMember = "value";
            calibresLb.ValueMember = "key";

            foreach (var calibre in calibresSeleccionados)
            {
                int indice = calibresLb.Items.IndexOf(calibre);
                calibresLb.SetItemCheckState(indice, CheckState.Checked);
            }

            calibresLb.Refresh();
        }

        private void aceptar_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            agregarMarcados();
            this.Close();
        }

        private void agregarMarcados()
        {
            calibresSeleccionados = new Dictionary<int, string>();
            foreach (var itemMarcado in calibresLb.CheckedItems)
            {
                var calibre = (KeyValuePair<int, string>)itemMarcado;
                calibresSeleccionados.Add(calibre.Key, calibre.Value);
            }
        }
    }
}
