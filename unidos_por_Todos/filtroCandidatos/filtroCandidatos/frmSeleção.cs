﻿using System;
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
            Form frmNorte = new frmNorte();
            frmNorte.Show();
        }

        private void btnCentroOeste_Click(object sender, EventArgs e)
        {
            Form frmCentroOeste = new frmCentroOeste();
            frmCentroOeste.Show();
        }

        private void btnNordeste_Click(object sender, EventArgs e)
        {
            Form frmNordeste = new frmNordeste();
            frmNordeste.Show();
        }

        private void btnSul_Click(object sender, EventArgs e)
        {
            Form frmSul = new frmSul();
            frmSul.Show();
        }

        private void btnSudeste_Click(object sender, EventArgs e)
        {
            Form frmSudeste = new frmSudeste();
            frmSudeste.Show();
        }
    }
}
