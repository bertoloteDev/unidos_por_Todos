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
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Birth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string nome = txtNome.Text;
            // Declarei a variável que é uma string e coloquei o "txtNome.Text" nessa variável
            string lastname = LastName.Text;
            // Declarei a variável que é uma string e coloquei o "LastName.Text" nessa variável
            string DatadeNascimento = Birth.Value.ToString("yyyy-MM-dd");
            // Declarei a variável que é uma string e coloquei o "Birth" nessa variável e como ela é um valor numérico ela acompanha o .Value e depois usei o ToString e depois eu coloquei o formato que eu quero que é "yyyy" que significa o ano em 4 digítos, o "MM" que significa o mês em 2 digítos e o "dd" que significa dias em 2 digítos
            string CPF = cpf.Text;
            // Declarei a variável que é uma string e coloquei o "cpf.Text" nessa variável
            string telefone = PhoneNumber.Text;
            // Declarei a variável que é uma string e coloquei o "PhoneNumber.Text" nessa variável
            string email = Email.Text;
            // Declarei a variável que é uma string e coloquei o "Email.Text" nessa variável
            string senha = Password.Text;
            // Declarei a variável que é uma string e coloquei o "Password.Text" nessa variável
          

            if (nome != "" && lastname != "" && DatadeNascimento != "" && CPF != "" && telefone != "" && email != "" && senha != "")
                // Declarei um if para verificar se os campos de cadastros estão preenchidos
            {
                MessageBox.Show("Usuário Cadastrado com Sucesso");
                // Se os campos estiverem preenchidos aparecerá um MessageBox escrito "Usuário Cadastrado com sucesso"
            }
            else 
            // Se todos os campos não estiverem preenchidos irá aparecer um MessageBox escrito "Informações Inválidas" 
            {
              MessageBox.Show(" Informações Inválidas ");
                // Se todos os campos não estiverem preenchidos irá aparecer um MessageBox escrito "Informações Inválidas" 
            }

            if (DatadeNascimento == "25-07-2005")
            {
                
            }
             else
            {
                MessageBox.Show("NÃO POSSUI A IDADE NECESSÁRIA");
            }


        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {

        }

        private void LastName_TextChanged(object sender, EventArgs e)
        {

        }

        private void Password_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }
    }
}
