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
        int id_cadastro;
        public frmTeladeDesenvolvedor(int id_cadastro)
        {
            this.id_cadastro = id_cadastro;
            InitializeComponent();
        }

        private void logoff_Click(object sender, EventArgs e)
        {
            /*
            Form frmlogin = new frmLogin();
            frmlogin.Show();*/
        }

        private void frmTeladeDesenvolvedor_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;




        }

        private void voltarParaTelaAnteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vtelaant = new frmLogin();
            vtelaant.Show();
            MessageBox.Show(" LogOff Realizado ");
            this.Hide();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void consult_Click(object sender, EventArgs e)
        {
            Form bdcadastrados = new frmbdcadastrados(this.id_cadastro);
            bdcadastrados.Show();
            this.Hide();
        }

        private void consult2_Click(object sender, EventArgs e)
        {
            Form bdong = new frmbdongs(this.id_cadastro);
            bdong.Show();
            this.Close();
        }

        private void lbl1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form vSelecao = new frmSelecao(this.id_cadastro, 3);
            vSelecao.Show();
            this.Hide();
        }
    }
}
