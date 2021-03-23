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
    public partial class Status : Form
    {
        public Status()
        {
            InitializeComponent();
        }

        private void statusBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.statusBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco4DataSet);

        }

        private void Status_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco4DataSet.status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.banco4DataSet.status);

        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Voltar_Click(object sender, EventArgs e)
        {
            Tarefas Tela = new Tarefas();
            Tela.Show();
            this.Hide();
        }
    }
}
