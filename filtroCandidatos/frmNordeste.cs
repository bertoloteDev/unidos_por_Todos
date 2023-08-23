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
    public partial class frmNordeste : Form
    {
        public frmNordeste()
        {
            InitializeComponent();
        }

        private void frmNordeste_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            int x = (this.Width - groupBox82.Width) / 2;
            int y = (this.Height - groupBox82.Height) / 2;
            groupBox82.Location = new Point(x, y);

        }

        private void voltarATelaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
