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
    public partial class frmPrincipal : Form
    {
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            


        }

       

       
        private void Register_Click(object sender, EventArgs e)
        {
            Form frmCadastro = new frmCadastro();
            frmCadastro.Show();
            
        }
    }
}
