using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Entity;

using System.Data.Entity.ModelConfiguration.Conventions;

using MySql.Data.MySqlClient;

namespace filtroCandidatos
{
    public partial class frmPagamentos : Form
    {
        int plano;
        int id_cadastros;

        public frmPagamentos(int plano, int id_cadastros)
        {
            this.plano = plano;
            this.id_cadastros = id_cadastros;
            InitializeComponent();
        }


        private void pagamentos_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void radioButton6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radCredito_CheckedChanged(object sender, EventArgs e)
        {
            gbCard.Visible = true;
            pBPix.Visible = false;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radDebito_CheckedChanged(object sender, EventArgs e)
        {
            gbCard.Visible = true;
            pBPix.Visible = false;
        }

        private void radPix_CheckedChanged(object sender, EventArgs e)
        {
            gbCard.Visible = false;
            pBPix.Visible = true;
        }

        private void groupBox1_Enter_1(object sender, EventArgs e)
        {


        }

        private void btnPaga_Click(object sender, EventArgs e)
        {
            string nome = txtnome.Text;
            string CPF = maskCpf.Text;
            string num = maskNume.Text;
            string vali = maskvali.Text;
            string ccc = txtcvv.Text;
            





            using (MyDbContext db = new MyDbContext())

            {

                string query = @"INSERT INTO pagamentos (numero_do_cartao, cvc, nome_cartao, cpf_cartao, pacote, validade_do_cartao, id_cadastros) VALUES (@pnumero_do_cartao, @pcvc, @pnome_cartao, @pcpf_cartao, @ppacote, @pvaliadade_do_cartao, @pid_cadastros ); SELECT LAST_INSERT_ID();";

                var parameters = new[]

                {

                    new MySqlParameter("@pnumero_do_cartao", num),

                    new MySqlParameter("@pcvc", ccc),

                    new MySqlParameter("@pnome_cartao", nome),

                    new MySqlParameter("@pcpf_cartao", CPF),

                    new MySqlParameter("@ppacote", this.plano),

                    new MySqlParameter("@pvaliadade_do_cartao", vali ),

                    new MySqlParameter("@pid_cadastros", this.id_cadastros),

                   


                };

               // int batatinha = db.Database.SqlQuery<int>(query, parameters).Single();

            }


            Form vRecuperacao = new frmSeleção(this.plano);
            vRecuperacao.Show();
        }

        private void menuToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void voltarParaTelaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vRecuperacao = new frmPlanos();
            vRecuperacao.Show();
        
         }
    }
}
