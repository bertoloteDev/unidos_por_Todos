using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace filtroCandidatos
{
    public partial class frmNorte : Form
    {
        public frmNorte()
        {
            InitializeComponent();
        }

        private void frmNorte_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            int x = (this.Width - groupBox80.Width) / 2;
            int y = (this.Height - groupBox80.Height) / 2;
            groupBox80.Location = new Point(x, y);

        }

        private void voltarATelaDeInicioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
