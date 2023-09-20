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

namespace filtroCandidatos
{
    public partial class frmFiltro : Form
    {
        string regiao;
        int id_user;
        int id_plano;
        public frmFiltro( string regiao, int id_user, int id_plano)
        {
            this.id_plano = id_plano;
            this.id_user = id_user;
            this.regiao = regiao;
            InitializeComponent();

            encontrar_localidades();
        }
        

        private void encontrar_localidades(string vEstado=null, string vCidade=null)
        {
            using (MyDbContext db = new MyDbContext())

            {

                string query = "SELECT * FROM localidades where regiao like '" + this.regiao + "'";

                if(vEstado != null)
                {
                    query += " OR '" + vEstado + "'";
                }

                if (vCidade != null)
                {
                    query += " OR '" + vCidade + "'";
                }

                query += ";";

                MessageBox.Show(query);

                List<Localidade> localidades = db.Database.SqlQuery<Localidade>(query).ToList();

                dgvLocalidades.DataSource = localidades;

            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            string vEstado = txtEstado.Text.Replace("ESTADO", "");
            string vCidade = txtCidade.Text.Replace("CIDADE", "");

            if (vEstado == "" && vCidade == "")
            {
                MessageBox.Show("Precisa filtrar por algum campo");
                return;
            }

            encontrar_localidades(vEstado, vCidade);


        }

        private void voltarParaTelaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vInicial = new frmSelecao(id_user, id_plano);
            vInicial.Show();
            this.Hide();
        }

        private void voltarParaTelaAnteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form vVoltaranterior = new frmSeleção();
            vVoltaranterior.Show();*/
        }

        private void alteraçãoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form vAlteracaodados = new frmEditarCadastro();
            vAlteracaodados.Show();
            this.Hide();*/
        }

        private void txtQuant_TextChanged(object sender, EventArgs e)
        {

        }

        private void frmFiltro_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            int x = (this.Width - groupBox1.Width) / 2;
            int y = (this.Height - groupBox1.Height) / 2;
            groupBox1.Location = new Point(x, y);
        }

        private void cbxCategorias_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
