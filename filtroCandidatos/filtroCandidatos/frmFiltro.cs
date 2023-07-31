using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filtroCandidatos
{
    public partial class frmFiltro : Form
    {
        public frmFiltro()
        {
            InitializeComponent();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string vCategorias = "";
            if (cbxCategorias.SelectedItem != null)
            {
                vCategorias = cbxCategorias.SelectedItem.ToString();
            }

            string vLocalidades = txtLocalidades.Text;
            string vQuant = txtQuant.Text;

            if (vCategorias == "" && vLocalidades == "" && vQuant == "")
            {
                MessageBox.Show(" precisa filtrar por algum campo");
                return;
            }


            MessageBox.Show("cbxCategoria: " + vCategorias +
                " txtLocalidades: " + vLocalidades + " txtQuant: " + vQuant);
        }
    }
}
