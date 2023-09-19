using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using filtroCandidatos.Models;

namespace filtroCandidatos
{
    public partial class frmSelecao : Form
    {
        int plano;
        int id_user;
        public frmSelecao(int id_user)
        {
            
            this.id_user = id_user;

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


        private void btnCentroOeste_Click(object sender, EventArgs e)
        {
            if (plano == 3)
            {
                Form frmFiltro = new frmFiltro("CentroOeste");
                frmFiltro.Show();
                this.Hide();
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
                this.Hide();
            }
            else if (plano == 3)
            {
                Form frmFiltro = new frmFiltro("Nordeste");
                frmFiltro.Show();
                this.Hide();
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
                this.Hide();
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
                this.Hide();
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
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            /*Form editarcadastro = new frmEditarCadastro();
            editarcadastro.Show();
            this.Hide();*/
        }

        private void btnNorte_Click(object sender, EventArgs e)
        {
            if (plano == 3)
            {
                Form frmFiltro = new frmFiltro("CentroOeste");
                frmFiltro.Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Você não tem acesso a esta região com o plano selecionado.");
            }
        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDev = new frmTeladeDesenvolvedor();
            frmDev.Show();
            this.Hide();
        }

        private void oNGToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form cadastroong = new frmOngsCadastro(this.id_user);
            cadastroong.Show();
            this.Hide();
        }
    }
}
