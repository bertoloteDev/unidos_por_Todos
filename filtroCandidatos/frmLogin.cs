using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using filtroCandidatos.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Configuration;
using MySql.Data.MySqlClient;






namespace filtroCandidatos
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
            using (MyDbContext db = new MyDbContext())
            {
                string query = "select * from cadastrados;";
                

            }

        }

        private bool planos = false;
        
        
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btn_Entrar_Click(object sender, EventArgs e)
        {
           
          
            
            string vLogin = txtCPF.Text;
            string vsenha = txtSenha.Text;

          if (vLogin != "" && vsenha != "")
            {

                using (MyDbContext db = new MyDbContext())

                {

                    string query = @"SELECT l.id, l.email, l.senha, l.tipo_de_acesso, l.id_cadastrados FROM login AS l WHERE l.email = @email AND l.senha = @senha LIMIT 1;";

                    var parameters = new[]

                    {
                        new MySqlParameter("@email", vLogin),
                        new MySqlParameter("@senha", vsenha)
                   };


                   Login login = db.Database.SqlQuery<Login>(query, parameters).SingleOrDefault();

                    if(login == null)
                    {
                        MessageBox.Show("Usuario não encontrado");
                        return;
                    }


                    
                     bool fezPagamento = VerificarPagamento(login);

                    if (fezPagamento)
                    {
                        Form vSelecao = new frmSelecao(login.id_cadastro);
                        vSelecao.Show();
                    }
                    else
                    {
                        Form vPlano = new frmPlanos(login.id_cadastro);
                        vPlano.Show();
                    }
                    this.Hide();


                }

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
            this.Hide();
        }

        private void quemSomosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vQuemsomos = new frmQuemSomosNos();
            vQuemsomos.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form vFormulario = new frmCadastro();
            vFormulario.Show();
            this.Hide();
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
            
        }

        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
        private bool VerificarPagamento(Login login)
        {
            using (MyDbContext db = new MyDbContext())
            {
            string query = "SELECT * FROM pagamentos WHERE id_cadastros = @id_cadastro LIMIT 1;";
            var parameters = new[]
            {
            new MySqlParameter("@id_cadastro", login.id_cadastro)
            };
        
            Pagamento pagamento = db.Database.SqlQuery<Pagamento>(query, parameters).SingleOrDefault();

            if (pagamento != null)
            {
            return true; // O usuário fez o pagamento
            }
            else
            {
            return false; // O usuário não fez o pagamento
            }
        }
    
    }
}}
