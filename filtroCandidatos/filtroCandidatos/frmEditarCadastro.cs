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
    public partial class frmEditarCadastro : Form
    {
        public frmEditarCadastro()
        {
            InitializeComponent();
        }

        private void Confirmar_Click(object sender, EventArgs e)
        {
            string nome = TxtNomedeConfirmação.Text;

            string DatadeNacimento = DTPNacimento.Value.ToString("yyyy-MM-dd");
            string CPF = TxtCPF.Text;
            string telefone = TxtTelefone.Text;
            string Email = TxtEmail.Text;
            string Senha = TxtSenha.Text;
            string Mesag = $"Nome de Confirmação:{nome}\n " +
             $"Data de Nacimento: {DatadeNacimento} \n" +
             $"CPF: {CPF} \n" +
             $"Telefone: {telefone} \n" +
             $"Email:{Email}\n" +
             $"Senha:{Senha} \n";
            MessageBox.Show(Mesag);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (TxtSenha.PasswordChar == '*')
            {
                TxtSenha.PasswordChar = '\0'; // Mostrar a senha
                PbOcutar.Image = Image.FromFile(@"..\..\Resources\view.png");
            }
            else
            {
                TxtSenha.PasswordChar = '*'; // Ocultar a senha
                PbOcutar.Image = Image.FromFile(@"..\..\Resources\hide.png");
            }
        }

        private void frmEditarCadastro_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

        }
    }
}
