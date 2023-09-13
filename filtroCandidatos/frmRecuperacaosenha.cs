using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;


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

            using (MyDbContext db = new MyDbContext())

            {

                string query = @"INSERT INTO Users (email, senha,tipo_de_cesso,id_cadastro) VALUES (@email,@senha,@confirmacao); SELECT LAST_INSERT_ID();";

                var parameters = new[]

                {

                    new MySqlParameter("@email",Email ),

                    new MySqlParameter("@senha",novasenha),
                    new MySqlParameter("@confirmacao",confirmacao),

           };

                int batatinha = db.Database.SqlQuery<int>(query, parameters).Single();

            }











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

        private void txtConfsenha_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblConf_Click(object sender, EventArgs e)
        {

        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vTelainicial = new frmLogin();
            vTelainicial.Show();
        }
    }
}

