using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MySql.Data.MySqlClient;
using filtroCandidatos.Models;

namespace filtroCandidatos
{
    public partial class frmbdongs : Form
    {
        public frmbdongs()
        {
            InitializeComponent();
        }

        private void frmbdongs_Load(object sender, EventArgs e)
        {

            using (MyDbContext db = new MyDbContext())
            {
                string query = "select * from ongs;";
                List<ong> ongs = db.Database.SqlQuery<ong>(query).ToList();
                bdong.DataSource = ongs;
                
            }
        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            
            Form teladevbd = new frmTeladeDesenvolvedor();
            teladevbd.Show();
            
        }

        private void bdong_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
