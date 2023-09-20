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
using filtroCandidatos.Models;

namespace filtroCandidatos
{
    public partial class frmbdcadastrados : Form
    {
        int id_cadastro;
        public frmbdcadastrados(int id_cadastro)
        {
            this.id_cadastro = id_cadastro;
            InitializeComponent();
        }

        private void bdcadastrados_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;

            using (MyDbContext db = new MyDbContext())
            {
                string query = "select * from Cadastrados;";
                List<Cadastro> cadastros = db.Database.SqlQuery<Cadastro>(query).ToList();
                bancodedados_cadastrados.DataSource = cadastros;
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form teladev = new frmTeladeDesenvolvedor(this.id_cadastro);
            teladev.Show();
            this.Hide();
        }
    }
}
