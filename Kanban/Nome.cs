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
    public partial class Nome : Form
    {
        public Nome()
        {
            InitializeComponent();
        }

        private void responsavelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.responsavelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco4DataSet);

        }

        private void Nome_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco4DataSet.Responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.responsavelTableAdapter.Fill(this.banco4DataSet.Responsavel);

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
           Tarefas Tela = new Tarefas();
            Tela.Show();
            this.Hide();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
