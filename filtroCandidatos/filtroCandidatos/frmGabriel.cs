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
    public partial class frmGabriel : Form
    {
        public frmGabriel()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Result_Click(object sender, EventArgs e)
        {
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnAbrirSeleção_Click(object sender, EventArgs e)
        {
            Form frmSeleção = new frmSeleção();
            frmSeleção.Show();
        }

        private void richTextAboutUs_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form frmQuemSomosNos = new frmQuemSomosNos();
            frmQuemSomosNos.Show();
        }

        private void Matheus_Click(object sender, EventArgs e)
        {
            Form frmcadastro = new frmCadastro();
            frmcadastro.Show();
        }
    }
}
