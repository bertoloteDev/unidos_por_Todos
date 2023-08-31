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
    public partial class pagamentos : Form
    {
        public pagamentos()
        {
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
        public void SelecionarRadioButton(int radioButtonIndex)
        { 
            if (radioButtonIndex == 1)
                radioButtonBasico.Checked = true;
            else if (radioButtonIndex == 2)
                radioButtonPadrao.Checked = true;
            else if (radioButtonIndex == 3)
                radioButtonPremium.Checked = true; }
    }
}
