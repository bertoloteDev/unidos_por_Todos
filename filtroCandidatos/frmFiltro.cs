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
        public frmFiltro( string regiao)
        {
            this.regiao = regiao;
            InitializeComponent();

            using (MyDbContext db = new MyDbContext())

            {

                string query = "SELECT * FROM localidades where regiao like '"+this.regiao+"';";

                List<Localidade> localidades = db.Database.SqlQuery<Localidade>(query).ToList();

                dgvLocalidades.DataSource = localidades;

            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            string vCategorias = "";
            if (cbxCategorias.SelectedItem != null)
            {
                vCategorias = cbxCategorias.SelectedItem.ToString();
            }

            string vLocalidades = txtLocalidades.Text;
            string vQuant = txtQuant.Text;

            if (vCategorias == "" && vLocalidades == "" && vQuant == "")
            {
                MessageBox.Show(" precisa filtrar por algum campo");
                return;
            }


            MessageBox.Show("cbxCategoria: " + vCategorias +
                " txtLocalidades: " + vLocalidades + " txtQuant: " + vQuant);
        }

        private void voltarParaTelaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vInicial = new frmLogin();
            vInicial.Show();
        }

        private void voltarParaTelaAnteriorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*Form vVoltaranterior = new frmSeleção();
            vVoltaranterior.Show();*/
        }

        private void alteraçãoDeDadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form vAlteracaodados = new frmEditarCadastro();
            vAlteracaodados.Show();
            this.Hide();
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
