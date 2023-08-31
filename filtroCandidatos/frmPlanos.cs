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
    public partial class frmPlanos : Form
    {
        public frmPlanos()
        {
            InitializeComponent();
        }

        private void frmPlanos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            int x = (this.Width - groupBox1.Width) / 2;
            int y = (this.Height - groupBox1.Height) / 2;
            groupBox1.Location = new Point(x, y);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void voltarATelaPrincipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void btnPadrao_Click(object sender, EventArgs e)
        {
            AbrirpagamentosESelecionarRadioButton(2);
        }

        private void btnBasico_Click(object sender, EventArgs e)
        {
            AbrirpagamentosESelecionarRadioButton(1);
        }

        private void btnPremium_Click(object sender, EventArgs e)
        {
            AbrirpagamentosESelecionarRadioButton(3);
        }
        private void AbrirForm2ESelecionarRadioButton(int radioButtonIndex)
        {
            Form pagamentos = new pagamentos();
            pagamentos.SelecionarRadioButton(radioButtonIndex);
            pagamentos.Show();
        }
    }
}
