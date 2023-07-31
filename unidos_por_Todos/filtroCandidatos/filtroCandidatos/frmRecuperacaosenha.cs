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
    }
}
