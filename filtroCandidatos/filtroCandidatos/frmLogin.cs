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
        }

        private void recuperarSemhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vRecuperacao = new frmRecuperacaosenha();
            vRecuperacao.Show();
        }
    }
}
