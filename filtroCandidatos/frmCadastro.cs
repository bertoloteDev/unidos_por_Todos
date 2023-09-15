using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions; // Serve para importar uma determinada biblioteca para conseguir usar a classe regex
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;
using MySql.Data.MySqlClient;
using filtroCandidatos.Models;

namespace filtroCandidatos
{
    public partial class frmCadastro : Form
    {
        public frmCadastro()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            char[] caractersexc = {' ', '/', '-', '.','_', ':' };

            string nome = txtNome.Text; // Declarei a variável que é uma string e coloquei o "txtNome.Text" nessa variável
            
            string lastname = LastName.Text;// Declarei a variável que é uma string e coloquei o "LastName.Text" nessa variável
            
            string DatadeNasimento = Birth.Value.ToString("yyyy-MM-dd"); // Declarei a variável que é uma string e coloquei o "Birth" nessa variável e como ela é um valor numérico ela acompanha o .Value e depois usei o ToString e depois eu coloquei o formato que eu quero que é "yyyy" que significa o ano em 4 digítos, o "MM" que significa o mês em 2 digítos e o "dd" que significa dias em 2 digítos
            
            string CPF = cpf.Text.Trim(caractersexc);// Declarei a variável que é uma string e coloquei o "cpf.Text" nessa variável
            
            string telefone = PhoneNumber.Text.Trim(caractersexc);// Declarei a variável que é uma string e coloquei o "PhoneNumber.Text" nessa variável
            
            string email = Email.Text;// Declarei a variável que é uma string e coloquei o "Email.Text" nessa variável
            
            string senha = Password.Text;// Declarei a variável que é uma string e coloquei o "Password.Text" nessa variável

            string senha2 = Password2.Text;// Declarei a variável que é uma string e coloquei o "Password2.Text" nessa variável

            
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");//Declarei a classe "Regex" e declarei uma variável chamada "Regex". Para eu conseguir usar essa variável eu preciso usar o "new". O Regex serve para validar a máscara de email.
            if (!regex.IsMatch(email)) // o If serve para verificar se o email tem a estrutura necessária para ser considerado valido
            {
                MessageBox.Show("Email Inválido");
                return;
            }



            string opcao = "";
            if (Woman.Checked)
            {
                opcao = "Feminino";
            }
            else if (Men.Checked)
            {
                opcao = "Masculino";
            }
            else // Se nenhuma das opções estiverem selecionadas irá aparecer a mensagem 
            {
                MessageBox.Show("Selecione seu gênero");
                return;
            }

            DateTime today = DateTime.Now; // DateTime é um tipo de váriavel que marca o dia e a hora,  declarei a variável chamda "today", chamei uma classe nativa do C# ("DateTime") e peguei um atributo dela que retorna o dia de hoje("Now")

            DateTime birthdate = Birth.Value; // Chamei a classe nativa do c# "DateTime", declarei a variável "birthdate" e atribui o valor da string "Birth.Value" dentro da variável

            int age = (int)((today - birthdate).TotalDays / 365.25); // Declarei a variável "age" e especifiquei que a classe dela é inteira "int" e subtrai as variáveis "today" e "birthdate" multiplicando com o total dias do ano dividindo por 365.25

            if (age < 18)// Verificar se o usuário tem 18 anos para efetuar o cadastro. SE Variável "age" for menor que 18 irá aparecer uma mensagem dizendo que o usuário não possui a idade necessária
            {
                MessageBox.Show(" Não tem a idade necessária ");
                return; //retorna ao inicio da ação
               
            }

            if (!(nome != "" && lastname != "" && DatadeNasimento != "" && CPF != "" && telefone != "" && email != "" && senha != ""))// Declarei um if para verificar se os campos de cadastros estão preenchidos           
               // Se todos os campos não estiverem preenchidos irá aparecer um MessageBox escrito "Informações Inválidas"
            {
              MessageBox.Show(" Informações Inválidas ");  // Se todos os campos não estiverem preenchidos irá aparecer um MessageBox escrito "Informações Inválidas"
                return;
            }


            if( senha == senha2)
            {
                MessageBox.Show("Usuário Cadastrado com Sucesso\n");// Se os campos estiverem preenchidos aparecerá um MessageBox escrito "Usuário Cadastrado com sucesso"
                using (MyDbContext db = new MyDbContext())

                {

                    string query = @"INSERT INTO cadastrados (nome, sobrenome, cpf,data_de_nascimento, idade, genero, telefone_usuario) VALUES (@nome, @sobrenome, @cpf, @data_de_nascimento, @idade, @genero, @telefone_usuario); SELECT LAST_INSERT_ID();";

                    var parameters = new[]

                    {

                    new MySqlParameter("@nome", nome),

                    new MySqlParameter("@sobrenome", lastname),

                    new MySqlParameter("@cpf", CPF),

                    new MySqlParameter("@data_de_nascimento", DatadeNasimento),

                    new MySqlParameter("@idade", age),

                    new MySqlParameter("@genero", opcao),

                    new MySqlParameter("@telefone_usuario", telefone)

                   

                    };


                    
                    int id_cadastrados = db.Database.SqlQuery<int>(query, parameters).Single();

                    query = @"INSERT INTO login (email, tipo_de_acesso, senha, id_cadastrados) VALUES (@email, @tipo_de_acesso, @senha, @id_cadastrados);";

                    parameters = new[]

                   {

                    new MySqlParameter ("@email", email),

                    new MySqlParameter("@senha", senha),

                    new MySqlParameter("@tipo_de_acesso", "clientes"),

                    new MySqlParameter("@id_cadastrados", id_cadastrados)

                    };

                    int rowsAffected = db.Database.ExecuteSqlCommand(query, parameters);

                }

                Form planos = new frmPlanos();
                planos.Show();
                this.Close();

                //A FAZER: chamar a tela de planos passando o id do login

            }
            else
            {
                MessageBox.Show("Senhas não Conferem!");

            }







        }

        private void Email_Validated(object sender, EventArgs e)
        {
            string email = Email.Text;
            Regex regex = new Regex(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");//Declarei a classe "Regex" e declarei uma variável chamada "Regex". Para eu conseguir usar essa variável eu preciso usar o "new". O Regex serve para validar a máscara de email.
            if (!regex.IsMatch(email)) // o If serve para verificar se o email tem a estrutura necessária para ser considerado valido
            {
                MessageBox.Show("Email Inválido");
                //Email.Focus();// Estou focando o textbox( name - "Email")
            }

        }

        private void cpf_Validated(object sender, EventArgs e)
        {
            string CPF = cpf.Text;
            Regex regex1 = new Regex(@"^\d{3}\.\d{3}\.\d{3}-\d{2}$");// Regex para máscara de CPF
            if(!regex1.IsMatch(CPF))// Verifica se o CPF está digitado corretamente. Se não estiver aparecerá a mensagem "CPF inválido
            {
                MessageBox.Show("CPF Inválido");
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            if (Password.PasswordChar == '*')
            {
                Password.PasswordChar = '\0'; // Mostrar a senha
                Image.Image = System.Drawing.Image.FromFile(@"..\..\Resources\view.png");
            }
            else
            {
                Password.PasswordChar = '*'; // Ocultar a senha
                Image.Image = System.Drawing.Image.FromFile(@"..\..\Resources\hide.png");
            }
        }

        private void frmCadastro_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            
            int x = (this.Width - groupBox1.Width) / 2;
            int y = (this.Height - groupBox1.Height) / 2;
            groupBox1.Location = new Point(x, y);
        }

        private void Birth_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Image2_Click(object sender, EventArgs e)
        {
            if (Password2.PasswordChar == '*')
            {
                Password2.PasswordChar = '\0'; // Mostrar a senha
                Image2.Image = System.Drawing.Image.FromFile(@"..\..\Resources\view.png");
            }
            else
            {
                Password2.PasswordChar = '*'; // Ocultar a senha
                Image2.Image = System.Drawing.Image.FromFile(@"..\..\Resources\hide.png");
            }
        }

        private void Password2_TextChanged(object sender, EventArgs e)
        {

        }

        private void idade_TextChanged(object sender, EventArgs e)
        {

        }

        private void voltar_Click(object sender, EventArgs e)
        {
            Form login = new frmLogin();
            login.Show();
            this.Close();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void Men_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
