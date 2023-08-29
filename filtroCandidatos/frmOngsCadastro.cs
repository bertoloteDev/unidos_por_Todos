using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySql.Data.MySqlClient;
using filtroCandidatos.Models;

namespace filtroCandidatos
{
    public partial class frmOngsCadastro : Form
    {
        public frmOngsCadastro()
        {
            InitializeComponent();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] caractersexc = { ' ', '/', '-', '.', '_', ':' };
            string nomeong = NameONG.Text;
            string cnpj = CPNJ.Text.Trim(caractersexc);
            string email = EmailONG.Text;
            string phone = PhoneONG.Text.Trim(caractersexc);
            string responsavel = Response.Text;
            string CPFresponsavel = cpfResponse.Text.Trim(caractersexc);
            string orçamento = orcamento.Text;


            if (!(nomeong != "" && cnpj != "" && email != "" && phone != "" && phone != "" && responsavel != "" && CPFresponsavel != ""))// Declarei um if para verificar se os campos de cadastros estão preenchidos           
                                                                                                                                         // Se todos os campos não estiverem preenchidos irá aparecer um MessageBox escrito "Informações Inválidas"
            {
                MessageBox.Show(" Informações Inválidas ");  // Se todos os campos não estiverem preenchidos irá aparecer um MessageBox escrito "Informações Inválidas"
                return;
            }
            else
            {
                MessageBox.Show(" ONG cadastrada com Sucesso! ");
            }

            using (MyDbContext db = new MyDbContext())

            {
                string query = @"INSERT INTO cadastrados (nome_de_ongs, responsavel_ongs, cnpj, cpf_responsavel, telefone, orcamento) VALUES (@nome_de_ongs, @responsavel_ongs, @cnpj, @cpf_responsavel, @telefone, @orcamento)";

                var parameters = new[]

                {

                    new MySqlParameter("@nome_de_ongs", nomeong),

                    new MySqlParameter("@responsavel_ongs", responsavel),

                    new MySqlParameter("@cnpj", cnpj),

                    new MySqlParameter("@cpf_responsavel", cpfResponse),

                    new MySqlParameter("@telefone", phone),

                    new MySqlParameter("@orcamento", orçamento),

                    new MySqlParameter("emailong", email)

                };

                int rowsAffected = db.Database.ExecuteSqlCommand(query, parameters);

            }
        }

         private void EmailONG_Validated(object sender, EventArgs e)

         { 
            string email = EmailONG.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");//Declarei a classe "Regex" e declarei uma variável chamada "Regex". Para eu conseguir usar essa variável eu preciso usar o "new". O Regex serve para validar a máscara de email.
            if (!regex.IsMatch(email)) // o If serve para verificar se o email tem a estrutura necessária para ser considerado valido
            {
                MessageBox.Show("Email Inválido");
                EmailONG.Focus();// Estou focando o textbox( name - "Email")
            }


          

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmOngsCadastro_Load(object sender, EventArgs e)
        {

        }

        private void CPNJ_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void NameONG_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmailONG_TextChanged(object sender, EventArgs e)
        {

        }

        private void PhoneONG_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void cpfResponse_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
