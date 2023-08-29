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
    public partial class frmSeleção : Form
    {
        int id_Usuario;
        public frmSeleção(int id_Usuario)
        {
            this.id_Usuario = id_Usuario;
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Maximized;
            int x = (this.Width - groupBox88.Width) / 2;
            int y = (this.Height - groupBox88.Height) / 2;
            groupBox88.Location = new Point(x, y);
        }

        private void button1_Click(object sender, EventArgs e)
        {         
            Form frmFiltro = new frmFiltro("Norte");
            frmFiltro.Show();
        }

        private void btnCentroOeste_Click(object sender, EventArgs e)
        {
            Form frmFiltro = new frmFiltro("CentroOeste");
            frmFiltro.Show();
        }

        private void btnNordeste_Click(object sender, EventArgs e)
        {
            Form frmFiltro = new frmFiltro("Nordeste");
            frmFiltro.Show();
        }

        private void btnSul_Click(object sender, EventArgs e)
        {
            Form frmFiltro = new frmFiltro("Sul");
            frmFiltro.Show(); ;
        }

        private void btnSudeste_Click(object sender, EventArgs e)
        {
            Form frmFiltro = new frmFiltro("Sudeste");
            frmFiltro.Show();
        }

        private void voltarATelaPricipalToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLogin();
            frmLogin.Show();
        }

        private void groupBox88_Enter(object sender, EventArgs e)
        {
            
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Form cadastroong = new frmOngsCadastro();
            cadastroong.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form editarcadastro = new frmEditarCadastro();
            editarcadastro.Show();
        }
    }
}
