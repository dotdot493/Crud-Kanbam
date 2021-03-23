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
    public partial class Tarefas : Form
    {
        public Tarefas()
        {
            InitializeComponent();
        }

        private void btnsair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void tarefaBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tarefaBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.banco4DataSet);

        }

        private void Tarefas_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'banco4DataSet.status'. Você pode movê-la ou removê-la conforme necessário.
            this.statusTableAdapter.Fill(this.banco4DataSet.status);
            // TODO: esta linha de código carrega dados na tabela 'banco4DataSet.Responsavel'. Você pode movê-la ou removê-la conforme necessário.
            this.responsavelTableAdapter.Fill(this.banco4DataSet.Responsavel);
            // TODO: esta linha de código carrega dados na tabela 'banco4DataSet.Tarefa'. Você pode movê-la ou removê-la conforme necessário.
            this.tarefaTableAdapter.Fill(this.banco4DataSet.Tarefa);

        }

        private void btnmostrar_Click(object sender, EventArgs e)
        {
            Tarefas Tela = new Tarefas();
            Tela.Show();
            this.Hide();
        }

        private void bindingNavigatorMoveLastItem_Click(object sender, EventArgs e)
        {

        }

        private void btncadastrar_Click(object sender, EventArgs e)
        {
            Nome Tela = new Nome();
            Tela.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Status Tela = new Status();
            Tela.Show();
            this.Hide();
        }

        private void btnmostrar_Click_1(object sender, EventArgs e)
        {
            Mostrar Tela = new Mostrar();
            Tela.Show();
            this.Hide();
        }
    }
}
