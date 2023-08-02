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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
            string vcpf = txtCPF.Text;
            string vsenha = txtSenha.Text;

          if (vcpf != "" && vsenha != "")
            {
                Form vSelecao = new frmSeleção();
                vSelecao.Show();
            }
                else
            {
                MessageBox.Show(" Preencha os Campos ");
            }


        }

        private void recuperarSemhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vRecuperacao = new frmRecuperacaosenha();
            vRecuperacao.Show();
        }

        private void quemSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vQuemsomos = new frmQuemSomosNos();
            vQuemsomos.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form vFormulario = new frmCadastro();
            vFormulario.Show();
        }

        private void frmLogin_Load_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
