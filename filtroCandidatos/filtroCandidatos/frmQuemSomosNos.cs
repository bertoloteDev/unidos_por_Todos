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
    public partial class frmQuemSomosNos : Form
    {
        public frmQuemSomosNos()
        {
            InitializeComponent();
            l2.Text = " Bem-vindo à Unidos por Todos, sua parceira em informações significativas para a mudança social. Somos uma\n empresa especializada em coletar e fornecer dados precisos e abrangentes sobre regiões com alta taxa de\n pobreza em todo o mundo. Nosso propósito é empoderar organizações não governamentais (ONGs) com\n informações valiosas que os ajudem a realizar impacto positivo e duradouro em comunidades desfavorecidas.";
            l4.Text = " Nossa missão é transformar dados em conhecimento para ação. Acreditamos que informações precisas e atualizadas\n são essenciais para abordar as desigualdades socioeconômicas e promover mudanças significativas em regiões\n afetadas pela pobreza. Nosso objetivo é capacitar ONGs com dados confiáveis e inteligência de mercado,\n possibilitando que elas implementem programas mais eficientes e bem-sucedidos.";
            l6.Text = " Nosso trabalho é pautado pela ética, transparência e responsabilidade. Compreendemos a importância dos dados\n que fornecemos e nos comprometemos em proteger a privacidade das comunidades envolvidas. Priorizamos\n parcerias de longo prazo com nossos clientes, trabalhando em conjunto para identificar soluções inovadoras e com\n alto impacto social.";
        }

        private void l2_Click(object sender, EventArgs e)
        {
            
        }

        private void frmQuemSomosNos_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            int x = (this.Width - groupBox85.Width) / 2;
            int y = (this.Height - groupBox85.Height) / 2;
            groupBox85.Location = new Point(x, y);

        }

        private void voltarATelaInicialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frmLogin = new frmLogin();
            frmLogin.Show();
        }
    }
}
