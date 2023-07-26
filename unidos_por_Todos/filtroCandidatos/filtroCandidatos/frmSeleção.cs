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
    public partial class frmSeleção : Form
    {
        public frmSeleção()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui aparecerá os dados da região norte onde mostra locais com alto numero de pobreza");
        }

        private void btnCentroOeste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui aparecerá os dados da região Centro-Oeste onde mostra locais com alto numero de pobreza");
        }

        private void btnNordeste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui aparecerá os dados da região Nordeste onde mostra locais com alto numero de pobreza");
        }

        private void btnSul_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui aparecerá os dados da região Sul onde mostra locais com alto numero de pobreza");
        }

        private void btnSudeste_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Aqui aparecerá os dados da região Sudeste onde mostra locais com alto numero de pobreza");
        }
    }
}
