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
    public partial class sobre : Form
    {
        public sobre()
        {
            InitializeComponent();
        }

        private void voltarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Entrar Tela = new Entrar();
            Tela.Show();
            this.Hide();

        }

        private void sairToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
