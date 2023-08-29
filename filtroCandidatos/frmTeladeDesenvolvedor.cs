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
    public partial class frmTeladeDesenvolvedor : Form
    {
        public frmTeladeDesenvolvedor()
        {
            InitializeComponent();
        }

        private void logoff_Click(object sender, EventArgs e)
        {
            MessageBox.Show(" LogOff Realizado ");
            Form frmlogin = new frmLogin();
            frmlogin.Show();
        }

        private void frmTeladeDesenvolvedor_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;


            using (MyDbContext db = new MyDbContext())
            {
                string query = "select * from ongs;";
                List<ong> ongs = db.Database.SqlQuery<ong>(query).ToList();
                bdong.DataSource = ongs;
            }


        }

        private void voltarParaTelaAnteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vtelaant = new frmLogin();
            vtelaant.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form bdcadastrados = new frmbdcadastrados();
            bdcadastrados.Show();
        }
    }
}
