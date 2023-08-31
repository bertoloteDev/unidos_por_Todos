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
    public partial class frmPagamentos : Form
    {
        int plano;
        public frmPagamentos(int plano)
        {
            this.plano = plano;
            InitializeComponent();
        }


        private void pagamentos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radCredito_CheckedChanged(object sender, EventArgs e)
        {
            gbCard.Visible = true;
            pBPix.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radDebito_CheckedChanged(object sender, EventArgs e)
        {
            gbCard.Visible = true;
            pBPix.Visible = false;
        }

        private void radPix_CheckedChanged(object sender, EventArgs e)
        {
            gbCard.Visible = false;
            pBPix.Visible = true;
        }
    }
}
