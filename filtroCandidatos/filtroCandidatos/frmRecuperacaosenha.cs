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
    public partial class frmRecuperacaosenha : Form
    {
        public frmRecuperacaosenha()
        {
            InitializeComponent();
        }

        private void btnRecuperar_Click(object sender, EventArgs e)
        {
            
                string recuperar = "";
                if (rbtnEmail.Checked == true)
                {
                    recuperar = "E-mail";
                    MessageBox.Show("Código enviado via E-mail");

                }
                else
                {
                    recuperar = "Mensagem";
                    MessageBox.Show("Código enviado via SMS");

                }

                string Email = lblEmail.Text;

                string novasenha = lblSenha.Text;

                string confisenha = lblSenhaconf.Text;

                string confirmacao = lblConf.Text;

            }

            private void btnMsenha_Click(object sender, EventArgs e)
        {
            if (txtNsenha.UseSystemPasswordChar)
            {
                txtNsenha.UseSystemPasswordChar = false;
                txtConfsenha.UseSystemPasswordChar = false;
            }
            else
            {
                txtNsenha.UseSystemPasswordChar = true;
                txtConfsenha.UseSystemPasswordChar = true;
            }
        }

        private void frmRecuperacaosenha_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            this.WindowState = FormWindowState.Maximized;
            int x = (this.Width - groupBox1.Width) / 2;
            int y = (this.Height - groupBox1.Height) / 2;
            groupBox1.Location = new Point(x, y);

        }

        private void pbPass_Click(object sender, EventArgs e)
        {
            if (txtConfsenha.PasswordChar == '*')
            {
                txtConfsenha.PasswordChar = '\0'; // Mostrar a senha
                pbPass.Image = Image.FromFile(@"..\..\Resources\view.png");
            }
            else
            {
                txtConfsenha.PasswordChar = '*'; // Ocultar a senha
                pbPass.Image = Image.FromFile(@"..\..\Resources\\hide.png");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (txtNsenha.PasswordChar == '*')
            {
                txtNsenha.PasswordChar = '\0'; // Mostrar a senha
                pbPass.Image = Image.FromFile(@"..\..\Resources\view.png");
            }
            else
            {
                txtNsenha.PasswordChar = '*'; // Ocultar a senha
                pbPass.Image = Image.FromFile(@"..\..\Resources\\hide.png");
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
