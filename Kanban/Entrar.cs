using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kanban
{
    public partial class Entrar : Form
    {
        public Entrar()
        {
            InitializeComponent();
        }

        private void btsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnentrar_Click(object sender, EventArgs e)
        {
            Mostrar Tela = new Mostrar();
            Tela.Show();
            this.Hide();
        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobre Tela = new sobre();
            Tela.Show();
            this.Hide();
        }
    }
}
