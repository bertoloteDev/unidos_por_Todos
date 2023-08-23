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
            int x = (this.Width - groupBox1.Width)/2;
            int y = (this.Height - groupBox1.Height) / 2;
            groupBox1.Location = new Point(x, y);
        }

        private void pbPass_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar == '*')
            {
                txtSenha.PasswordChar = '\0'; // Mostrar a senha
                pbPass.Image = Image.FromFile(@"..\..\Resources\view.png");
            }
            else
            {
                txtSenha.PasswordChar = '*'; // Ocultar a senha
                pbPass.Image = Image.FromFile(@"..\..\Resources\\hide.png");
            }
        }

        private void cadastrosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void loginToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmDev = new frmTeladeDesenvolvedor();
            frmDev.Show();
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
    }
}
