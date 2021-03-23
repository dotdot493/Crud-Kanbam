
namespace Kanban
{
    partial class Status
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label idstatusLabel;
            System.Windows.Forms.Label pendenteLabel;
            System.Windows.Forms.Label executandoLabel;
            System.Windows.Forms.Label feitoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Status));
            this.banco4DataSet = new Kanban.banco4DataSet();
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusTableAdapter = new Kanban.banco4DataSetTableAdapters.statusTableAdapter();
            this.tableAdapterManager = new Kanban.banco4DataSetTableAdapters.TableAdapterManager();
            this.statusBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.statusBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idstatusTextBox = new System.Windows.Forms.TextBox();
            this.pendenteTextBox = new System.Windows.Forms.TextBox();
            this.executandoTextBox = new System.Windows.Forms.TextBox();
            this.feitoTextBox = new System.Windows.Forms.TextBox();
            this.Voltar = new System.Windows.Forms.Button();
            this.btnsair = new System.Windows.Forms.Button();
            this.statusDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            idstatusLabel = new System.Windows.Forms.Label();
            pendenteLabel = new System.Windows.Forms.Label();
            executandoLabel = new System.Windows.Forms.Label();
            feitoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banco4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingNavigator)).BeginInit();
            this.statusBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idstatusLabel
            // 
            idstatusLabel.AutoSize = true;
            idstatusLabel.Location = new System.Drawing.Point(48, 79);
            idstatusLabel.Name = "idstatusLabel";
            idstatusLabel.Size = new System.Drawing.Size(47, 13);
            idstatusLabel.TabIndex = 1;
            idstatusLabel.Text = "Idstatus:";
            // 
            // pendenteLabel
            // 
            pendenteLabel.AutoSize = true;
            pendenteLabel.Location = new System.Drawing.Point(48, 105);
            pendenteLabel.Name = "pendenteLabel";
            pendenteLabel.Size = new System.Drawing.Size(56, 13);
            pendenteLabel.TabIndex = 3;
            pendenteLabel.Text = "Pendente:";
            // 
            // executandoLabel
            // 
            executandoLabel.AutoSize = true;
            executandoLabel.Location = new System.Drawing.Point(48, 131);
            executandoLabel.Name = "executandoLabel";
            executandoLabel.Size = new System.Drawing.Size(66, 13);
            executandoLabel.TabIndex = 5;
            executandoLabel.Text = "executando:";
            // 
            // feitoLabel
            // 
            feitoLabel.AutoSize = true;
            feitoLabel.Location = new System.Drawing.Point(48, 157);
            feitoLabel.Name = "feitoLabel";
            feitoLabel.Size = new System.Drawing.Size(33, 13);
            feitoLabel.TabIndex = 7;
            feitoLabel.Text = "Feito:";
            // 
            // banco4DataSet
            // 
            this.banco4DataSet.DataSetName = "banco4DataSet";
            this.banco4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "status";
            this.statusBindingSource.DataSource = this.banco4DataSet;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ResponsavelTableAdapter = null;
            this.tableAdapterManager.statusTableAdapter = this.statusTableAdapter;
            this.tableAdapterManager.TarefaTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Kanban.banco4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // statusBindingNavigator
            // 
            this.statusBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.statusBindingNavigator.BindingSource = this.statusBindingSource;
            this.statusBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.statusBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.statusBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.statusBindingNavigatorSaveItem});
            this.statusBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.statusBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.statusBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.statusBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.statusBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.statusBindingNavigator.Name = "statusBindingNavigator";
            this.statusBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.statusBindingNavigator.Size = new System.Drawing.Size(875, 25);
            this.statusBindingNavigator.TabIndex = 0;
            this.statusBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(37, 22);
            this.bindingNavigatorCountItem.Text = "de {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Número total de itens";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorDeleteItem.Text = "Excluir";
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveFirstItem.Text = "Mover primeiro";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMovePreviousItem.Text = "Mover anterior";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Posição";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 23);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Posição atual";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveNextItem.Text = "Mover próximo";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorMoveLastItem.Text = "Mover último";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // statusBindingNavigatorSaveItem
            // 
            this.statusBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.statusBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("statusBindingNavigatorSaveItem.Image")));
            this.statusBindingNavigatorSaveItem.Name = "statusBindingNavigatorSaveItem";
            this.statusBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.statusBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.statusBindingNavigatorSaveItem.Click += new System.EventHandler(this.statusBindingNavigatorSaveItem_Click);
            // 
            // idstatusTextBox
            // 
            this.idstatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Idstatus", true));
            this.idstatusTextBox.Location = new System.Drawing.Point(120, 76);
            this.idstatusTextBox.Name = "idstatusTextBox";
            this.idstatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.idstatusTextBox.TabIndex = 2;
            // 
            // pendenteTextBox
            // 
            this.pendenteTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Pendente", true));
            this.pendenteTextBox.Location = new System.Drawing.Point(120, 102);
            this.pendenteTextBox.Name = "pendenteTextBox";
            this.pendenteTextBox.Size = new System.Drawing.Size(100, 20);
            this.pendenteTextBox.TabIndex = 4;
            // 
            // executandoTextBox
            // 
            this.executandoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "executando", true));
            this.executandoTextBox.Location = new System.Drawing.Point(120, 128);
            this.executandoTextBox.Name = "executandoTextBox";
            this.executandoTextBox.Size = new System.Drawing.Size(100, 20);
            this.executandoTextBox.TabIndex = 6;
            // 
            // feitoTextBox
            // 
            this.feitoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.statusBindingSource, "Feito", true));
            this.feitoTextBox.Location = new System.Drawing.Point(120, 154);
            this.feitoTextBox.Name = "feitoTextBox";
            this.feitoTextBox.Size = new System.Drawing.Size(100, 20);
            this.feitoTextBox.TabIndex = 8;
            // 
            // Voltar
            // 
            this.Voltar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.Voltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Voltar.Location = new System.Drawing.Point(149, 226);
            this.Voltar.Name = "Voltar";
            this.Voltar.Size = new System.Drawing.Size(100, 42);
            this.Voltar.TabIndex = 29;
            this.Voltar.Text = "Voltar";
            this.Voltar.UseVisualStyleBackColor = false;
            this.Voltar.Click += new System.EventHandler(this.Voltar_Click);
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnsair.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(51, 226);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(86, 42);
            this.btnsair.TabIndex = 28;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // statusDataGridView
            // 
            this.statusDataGridView.AutoGenerateColumns = false;
            this.statusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.statusDataGridView.DataSource = this.statusBindingSource;
            this.statusDataGridView.Location = new System.Drawing.Point(296, 48);
            this.statusDataGridView.Name = "statusDataGridView";
            this.statusDataGridView.Size = new System.Drawing.Size(418, 220);
            this.statusDataGridView.TabIndex = 29;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Idstatus";
            this.dataGridViewTextBoxColumn1.HeaderText = "Idstatus";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Pendente";
            this.dataGridViewTextBoxColumn2.HeaderText = "Pendente";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "executando";
            this.dataGridViewTextBoxColumn3.HeaderText = "executando";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Feito";
            this.dataGridViewTextBoxColumn4.HeaderText = "Feito";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // Status
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(875, 450);
            this.Controls.Add(this.statusDataGridView);
            this.Controls.Add(this.Voltar);
            this.Controls.Add(this.btnsair);
            this.Controls.Add(idstatusLabel);
            this.Controls.Add(this.idstatusTextBox);
            this.Controls.Add(pendenteLabel);
            this.Controls.Add(this.pendenteTextBox);
            this.Controls.Add(executandoLabel);
            this.Controls.Add(this.executandoTextBox);
            this.Controls.Add(feitoLabel);
            this.Controls.Add(this.feitoTextBox);
            this.Controls.Add(this.statusBindingNavigator);
            this.Name = "Status";
            this.Text = "Status";
            this.Load += new System.EventHandler(this.Status_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingNavigator)).EndInit();
            this.statusBindingNavigator.ResumeLayout(false);
            this.statusBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private banco4DataSet banco4DataSet;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private banco4DataSetTableAdapters.statusTableAdapter statusTableAdapter;
        private banco4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator statusBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton statusBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox idstatusTextBox;
        private System.Windows.Forms.TextBox pendenteTextBox;
        private System.Windows.Forms.TextBox executandoTextBox;
        private System.Windows.Forms.TextBox feitoTextBox;
        private System.Windows.Forms.Button Voltar;
        private System.Windows.Forms.Button btnsair;
        private System.Windows.Forms.DataGridView statusDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
    }
}