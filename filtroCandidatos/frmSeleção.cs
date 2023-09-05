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
        int plano;
        public frmSeleção(int plano)
        {
            this.plano = plano;

            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            this.WindowState = FormWindowState.Maximized;
            int x = (this.Width - groupBox88.Width) / 2;
            int y = (this.Height - groupBox88.Height) / 2;
            groupBox88.Location = new Point(x, y);

            //A FAZER: select nos cadastrados e planos para verificar quem ´já pagou e e então mostrar o groupBox se não vai mandar para a tela de planos
        }


        private void btnCentroOeste_Click(object sender, EventArgs e)
        {
            if (plano == 3)
            {
                Form frmFiltro = new frmFiltro("CentroOeste");
                frmFiltro.Show();
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esta região com o plano selecionado.");
            }
        }

        private void btnNordeste_Click(object sender, EventArgs e)
        {
            if (plano == 2 && "Nordeste".Equals(btnNordeste.Text, StringComparison.OrdinalIgnoreCase))
            {
                Form frmFiltro = new frmFiltro("Nordeste");
                frmFiltro.Show();
            }
            else if (plano == 3)
            {
                Form frmFiltro = new frmFiltro("Nordeste");
                frmFiltro.Show();
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esta região com o plano selecionado.");
            }
        }

        private void btnSul_Click(object sender, EventArgs e)
        {
            if (plano == 3)
            {
                Form frmFiltro = new frmFiltro("Sul");
                frmFiltro.Show();
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esta região com o plano selecionado.");
            }
        }

        private void btnSudeste_Click(object sender, EventArgs e)
        {
            if (plano == 3)
            {
                Form frmFiltro = new frmFiltro("Sudeste");
                frmFiltro.Show();
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esta região com o plano selecionado.");
            }
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

        private void btnNorte_Click(object sender, EventArgs e)
        {
            if (plano == 3)
            {
                Form frmFiltro = new frmFiltro("CentroOeste");
                frmFiltro.Show();
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esta região com o plano selecionado.");
            }
        }
    }
}
