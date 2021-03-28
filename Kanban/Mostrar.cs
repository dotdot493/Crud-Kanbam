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
    public partial class Mostrar : Form
    {
        public Mostrar()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void responsavelBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.responsavelBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco4DataSet);

        }

        private void Mostrar_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco4DataSet.status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.banco4DataSet.status);
            // TODO: esta linha de código carrega dados na tabela 'banco4DataSet.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.banco4DataSet.Tarefa);
            // TODO: esta linha de código carrega dados na tabela 'banco4DataSet.Responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.responsavelTableAdapter.Fill(this.banco4DataSet.Responsavel);

        }

        private void btnvoltar_Click(object sender, EventArgs e)
        {
            Tarefas Tela = new Tarefas();
            Tela.Show();
            this.Hide();
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.tarefaTableAdapter.FillBy(this.banco4DataSet.Tarefa);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void sobreToolStripMenuItem_Click(object sender, EventArgs e)
        {
            sobre Tela = new sobre();
            Tela.Show();
            this.Hide();
        }
    }
}
