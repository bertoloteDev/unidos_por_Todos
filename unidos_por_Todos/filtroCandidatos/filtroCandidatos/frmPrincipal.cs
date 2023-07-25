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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

        private void Result_Click(object sender, EventArgs e)
        {
            
            double orcamento = Convert.ToDouble(money.Text);
            string candidato1 = Candidate1.Text;
            string candidato2 = Candidate2.Text;
            double orcamento2 = Convert.ToDouble(cash.Text);

            if (orcamento >= orcamento2) 
            {
                Response.Text = " Responsavél pela área: " + candidato1;
            }
            else
            {
                Response.Text = " Rsponsável pela área: " + candidato2;
            }
            



        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
