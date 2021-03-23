
namespace Kanban
{
    partial class Tarefas
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
            System.Windows.Forms.Label idtarefaLabel;
            System.Windows.Forms.Label vericar_pendenciasLabel;
            System.Windows.Forms.Label executar_TrabalhoLabel;
            System.Windows.Forms.Label superviosionar_TrabalhoLabel;
            System.Windows.Forms.Label fkstatusLabel;
            System.Windows.Forms.Label fkresponsavelLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Tarefas));
            this.btnsair = new System.Windows.Forms.Button();
            this.banco4DataSet = new Kanban.banco4DataSet();
            this.tarefaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tarefaTableAdapter = new Kanban.banco4DataSetTableAdapters.TarefaTableAdapter();
            this.tableAdapterManager = new Kanban.banco4DataSetTableAdapters.TableAdapterManager();
            this.responsavelTableAdapter = new Kanban.banco4DataSetTableAdapters.ResponsavelTableAdapter();
            this.statusTableAdapter = new Kanban.banco4DataSetTableAdapters.statusTableAdapter();
            this.tarefaBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.tarefaBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.idtarefaTextBox = new System.Windows.Forms.TextBox();
            this.vericar_pendenciasTextBox = new System.Windows.Forms.TextBox();
            this.executar_TrabalhoTextBox = new System.Windows.Forms.TextBox();
            this.superviosionar_TrabalhoTextBox = new System.Windows.Forms.TextBox();
            this.fkstatusTextBox = new System.Windows.Forms.TextBox();
            this.fkresponsavelTextBox = new System.Windows.Forms.TextBox();
            this.responsavelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.statusBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.btnvoltar = new System.Windows.Forms.Button();
            this.btncadastrar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btnmostrar = new System.Windows.Forms.Button();
            this.responsavelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtcadastrar = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            idtarefaLabel = new System.Windows.Forms.Label();
            vericar_pendenciasLabel = new System.Windows.Forms.Label();
            executar_TrabalhoLabel = new System.Windows.Forms.Label();
            superviosionar_TrabalhoLabel = new System.Windows.Forms.Label();
            fkstatusLabel = new System.Windows.Forms.Label();
            fkresponsavelLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.banco4DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingNavigator)).BeginInit();
            this.tarefaBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idtarefaLabel
            // 
            idtarefaLabel.AutoSize = true;
            idtarefaLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idtarefaLabel.Location = new System.Drawing.Point(13, 113);
            idtarefaLabel.Name = "idtarefaLabel";
            idtarefaLabel.Size = new System.Drawing.Size(52, 12);
            idtarefaLabel.TabIndex = 2;
            idtarefaLabel.Text = "Idtarefa:";
            // 
            // vericar_pendenciasLabel
            // 
            vericar_pendenciasLabel.AutoSize = true;
            vericar_pendenciasLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            vericar_pendenciasLabel.Location = new System.Drawing.Point(13, 139);
            vericar_pendenciasLabel.Name = "vericar_pendenciasLabel";
            vericar_pendenciasLabel.Size = new System.Drawing.Size(118, 12);
            vericar_pendenciasLabel.TabIndex = 4;
            vericar_pendenciasLabel.Text = "Vericar pendencias:";
            // 
            // executar_TrabalhoLabel
            // 
            executar_TrabalhoLabel.AutoSize = true;
            executar_TrabalhoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            executar_TrabalhoLabel.Location = new System.Drawing.Point(13, 165);
            executar_TrabalhoLabel.Name = "executar_TrabalhoLabel";
            executar_TrabalhoLabel.Size = new System.Drawing.Size(111, 12);
            executar_TrabalhoLabel.TabIndex = 6;
            executar_TrabalhoLabel.Text = "Executar Trabalho:";
            // 
            // superviosionar_TrabalhoLabel
            // 
            superviosionar_TrabalhoLabel.AutoSize = true;
            superviosionar_TrabalhoLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            superviosionar_TrabalhoLabel.Location = new System.Drawing.Point(13, 191);
            superviosionar_TrabalhoLabel.Name = "superviosionar_TrabalhoLabel";
            superviosionar_TrabalhoLabel.Size = new System.Drawing.Size(145, 12);
            superviosionar_TrabalhoLabel.TabIndex = 8;
            superviosionar_TrabalhoLabel.Text = "Superviosionar Trabalho:";
            // 
            // fkstatusLabel
            // 
            fkstatusLabel.AutoSize = true;
            fkstatusLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fkstatusLabel.Location = new System.Drawing.Point(13, 217);
            fkstatusLabel.Name = "fkstatusLabel";
            fkstatusLabel.Size = new System.Drawing.Size(52, 12);
            fkstatusLabel.TabIndex = 10;
            fkstatusLabel.Text = "fkstatus:";
            // 
            // fkresponsavelLabel
            // 
            fkresponsavelLabel.AutoSize = true;
            fkresponsavelLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fkresponsavelLabel.Location = new System.Drawing.Point(13, 243);
            fkresponsavelLabel.Name = "fkresponsavelLabel";
            fkresponsavelLabel.Size = new System.Drawing.Size(86, 12);
            fkresponsavelLabel.TabIndex = 12;
            fkresponsavelLabel.Text = "fkresponsavel:";
            // 
            // btnsair
            // 
            this.btnsair.BackColor = System.Drawing.SystemColors.ControlDark;
            this.btnsair.Font = new System.Drawing.Font("Arial", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnsair.Location = new System.Drawing.Point(289, 409);
            this.btnsair.Name = "btnsair";
            this.btnsair.Size = new System.Drawing.Size(159, 42);
            this.btnsair.TabIndex = 0;
            this.btnsair.Text = "Sair";
            this.btnsair.UseVisualStyleBackColor = false;
            this.btnsair.Click += new System.EventHandler(this.btnsair_Click);
            // 
            // banco4DataSet
            // 
            this.banco4DataSet.DataSetName = "banco4DataSet";
            this.banco4DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tarefaBindingSource
            // 
            this.tarefaBindingSource.DataMember = "Tarefa";
            this.tarefaBindingSource.DataSource = this.banco4DataSet;
            // 
            // tarefaTableAdapter
            // 
            this.tarefaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.ResponsavelTableAdapter = this.responsavelTableAdapter;
            this.tableAdapterManager.statusTableAdapter = this.statusTableAdapter;
            this.tableAdapterManager.TarefaTableAdapter = this.tarefaTableAdapter;
            this.tableAdapterManager.UpdateOrder = Kanban.banco4DataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // responsavelTableAdapter
            // 
            this.responsavelTableAdapter.ClearBeforeFill = true;
            // 
            // statusTableAdapter
            // 
            this.statusTableAdapter.ClearBeforeFill = true;
            // 
            // tarefaBindingNavigator
            // 
            this.tarefaBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.tarefaBindingNavigator.BindingSource = this.tarefaBindingSource;
            this.tarefaBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.tarefaBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.tarefaBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.tarefaBindingNavigatorSaveItem});
            this.tarefaBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.tarefaBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.tarefaBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.tarefaBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.tarefaBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.tarefaBindingNavigator.Name = "tarefaBindingNavigator";
            this.tarefaBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.tarefaBindingNavigator.Size = new System.Drawing.Size(800, 25);
            this.tarefaBindingNavigator.TabIndex = 1;
            this.tarefaBindingNavigator.Text = "bindingNavigator1";
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
            this.bindingNavigatorMoveLastItem.Click += new System.EventHandler(this.bindingNavigatorMoveLastItem_Click);
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // tarefaBindingNavigatorSaveItem
            // 
            this.tarefaBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.tarefaBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("tarefaBindingNavigatorSaveItem.Image")));
            this.tarefaBindingNavigatorSaveItem.Name = "tarefaBindingNavigatorSaveItem";
            this.tarefaBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.tarefaBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.tarefaBindingNavigatorSaveItem.Click += new System.EventHandler(this.tarefaBindingNavigatorSaveItem_Click);
            // 
            // idtarefaTextBox
            // 
            this.idtarefaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "Idtarefa", true));
            this.idtarefaTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.idtarefaTextBox.Location = new System.Drawing.Point(164, 110);
            this.idtarefaTextBox.Name = "idtarefaTextBox";
            this.idtarefaTextBox.Size = new System.Drawing.Size(100, 20);
            this.idtarefaTextBox.TabIndex = 3;
            // 
            // vericar_pendenciasTextBox
            // 
            this.vericar_pendenciasTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "Vericar pendencias", true));
            this.vericar_pendenciasTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vericar_pendenciasTextBox.Location = new System.Drawing.Point(164, 136);
            this.vericar_pendenciasTextBox.Name = "vericar_pendenciasTextBox";
            this.vericar_pendenciasTextBox.Size = new System.Drawing.Size(100, 20);
            this.vericar_pendenciasTextBox.TabIndex = 5;
            // 
            // executar_TrabalhoTextBox
            // 
            this.executar_TrabalhoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "Executar Trabalho", true));
            this.executar_TrabalhoTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.executar_TrabalhoTextBox.Location = new System.Drawing.Point(164, 162);
            this.executar_TrabalhoTextBox.Name = "executar_TrabalhoTextBox";
            this.executar_TrabalhoTextBox.Size = new System.Drawing.Size(100, 20);
            this.executar_TrabalhoTextBox.TabIndex = 7;
            // 
            // superviosionar_TrabalhoTextBox
            // 
            this.superviosionar_TrabalhoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "Superviosionar Trabalho", true));
            this.superviosionar_TrabalhoTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.superviosionar_TrabalhoTextBox.Location = new System.Drawing.Point(164, 188);
            this.superviosionar_TrabalhoTextBox.Name = "superviosionar_TrabalhoTextBox";
            this.superviosionar_TrabalhoTextBox.Size = new System.Drawing.Size(100, 20);
            this.superviosionar_TrabalhoTextBox.TabIndex = 9;
            // 
            // fkstatusTextBox
            // 
            this.fkstatusTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "fkstatus", true));
            this.fkstatusTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fkstatusTextBox.Location = new System.Drawing.Point(164, 214);
            this.fkstatusTextBox.Name = "fkstatusTextBox";
            this.fkstatusTextBox.Size = new System.Drawing.Size(100, 20);
            this.fkstatusTextBox.TabIndex = 11;
            // 
            // fkresponsavelTextBox
            // 
            this.fkresponsavelTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.tarefaBindingSource, "fkresponsavel", true));
            this.fkresponsavelTextBox.Font = new System.Drawing.Font("Arial Rounded MT Bold", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fkresponsavelTextBox.Location = new System.Drawing.Point(164, 240);
            this.fkresponsavelTextBox.Name = "fkresponsavelTextBox";
            this.fkresponsavelTextBox.Size = new System.Drawing.Size(100, 20);
            this.fkresponsavelTextBox.TabIndex = 13;
            // 
            // responsavelBindingSource
            // 
            this.responsavelBindingSource.DataMember = "Responsavel";
            this.responsavelBindingSource.DataSource = this.banco4DataSet;
            // 
            // statusBindingSource
            // 
            this.statusBindingSource.DataMember = "status";
            this.statusBindingSource.DataSource = this.banco4DataSet;
            // 
            // btnvoltar
            // 
            this.btnvoltar.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.btnvoltar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnvoltar.Location = new System.Drawing.Point(454, 408);
            this.btnvoltar.Name = "btnvoltar";
            this.btnvoltar.Size = new System.Drawing.Size(136, 42);
            this.btnvoltar.TabIndex = 27;
            this.btnvoltar.Text = "Voltar";
            this.btnvoltar.UseVisualStyleBackColor = false;
            this.btnvoltar.Click += new System.EventHandler(this.btnmostrar_Click);
            // 
            // btncadastrar
            // 
            this.btncadastrar.BackColor = System.Drawing.Color.CadetBlue;
            this.btncadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btncadastrar.Location = new System.Drawing.Point(19, 279);
            this.btncadastrar.Name = "btncadastrar";
            this.btncadastrar.Size = new System.Drawing.Size(174, 38);
            this.btncadastrar.TabIndex = 28;
            this.btncadastrar.Text = "Add. Funcionário";
            this.btncadastrar.UseVisualStyleBackColor = false;
            this.btncadastrar.Click += new System.EventHandler(this.btncadastrar_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.DarkCyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(18, 323);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 41);
            this.button1.TabIndex = 30;
            this.button1.Text = "Add. Status";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnmostrar
            // 
            this.btnmostrar.BackColor = System.Drawing.Color.DarkCyan;
            this.btnmostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnmostrar.Location = new System.Drawing.Point(19, 370);
            this.btnmostrar.Name = "btnmostrar";
            this.btnmostrar.Size = new System.Drawing.Size(174, 44);
            this.btnmostrar.TabIndex = 32;
            this.btnmostrar.Text = "Mostrar dados";
            this.btnmostrar.UseVisualStyleBackColor = false;
            this.btnmostrar.Click += new System.EventHandler(this.btnmostrar_Click_1);
            // 
            // responsavelDataGridView
            // 
            this.responsavelDataGridView.AllowUserToOrderColumns = true;
            this.responsavelDataGridView.AutoGenerateColumns = false;
            this.responsavelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.responsavelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2});
            this.responsavelDataGridView.DataSource = this.responsavelBindingSource;
            this.responsavelDataGridView.Location = new System.Drawing.Point(399, 110);
            this.responsavelDataGridView.Name = "responsavelDataGridView";
            this.responsavelDataGridView.Size = new System.Drawing.Size(300, 46);
            this.responsavelDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdResponsavel";
            this.dataGridViewTextBoxColumn1.HeaderText = "IdResponsavel";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Nome";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // statusDataGridView
            // 
            this.statusDataGridView.AllowUserToOrderColumns = true;
            this.statusDataGridView.AutoGenerateColumns = false;
            this.statusDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.statusDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.statusDataGridView.DataSource = this.statusBindingSource;
            this.statusDataGridView.Location = new System.Drawing.Point(399, 172);
            this.statusDataGridView.Name = "statusDataGridView";
            this.statusDataGridView.Size = new System.Drawing.Size(300, 88);
            this.statusDataGridView.TabIndex = 32;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Idstatus";
            this.dataGridViewTextBoxColumn3.HeaderText = "Idstatus";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Pendente";
            this.dataGridViewTextBoxColumn4.HeaderText = "Pendente";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "executando";
            this.dataGridViewTextBoxColumn5.HeaderText = "executando";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Feito";
            this.dataGridViewTextBoxColumn6.HeaderText = "Feito";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // txtcadastrar
            // 
            this.txtcadastrar.AutoSize = true;
            this.txtcadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcadastrar.Location = new System.Drawing.Point(10, 69);
            this.txtcadastrar.Name = "txtcadastrar";
            this.txtcadastrar.Size = new System.Drawing.Size(251, 25);
            this.txtcadastrar.TabIndex = 33;
            this.txtcadastrar.Text = "Cadastrar Nova Tarefa";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(390, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(309, 24);
            this.label1.TabIndex = 34;
            this.label1.Text = "Menu de Responsáveis e Status";
            // 
            // Tarefas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 477);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtcadastrar);
            this.Controls.Add(this.statusDataGridView);
            this.Controls.Add(this.responsavelDataGridView);
            this.Controls.Add(this.btnmostrar);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btncadastrar);
            this.Controls.Add(this.btnvoltar);
            this.Controls.Add(idtarefaLabel);
            this.Controls.Add(this.idtarefaTextBox);
            this.Controls.Add(vericar_pendenciasLabel);
            this.Controls.Add(this.vericar_pendenciasTextBox);
            this.Controls.Add(executar_TrabalhoLabel);
            this.Controls.Add(this.executar_TrabalhoTextBox);
            this.Controls.Add(superviosionar_TrabalhoLabel);
            this.Controls.Add(this.superviosionar_TrabalhoTextBox);
            this.Controls.Add(fkstatusLabel);
            this.Controls.Add(this.fkstatusTextBox);
            this.Controls.Add(fkresponsavelLabel);
            this.Controls.Add(this.fkresponsavelTextBox);
            this.Controls.Add(this.tarefaBindingNavigator);
            this.Controls.Add(this.btnsair);
            this.Name = "Tarefas";
            this.Text = "Tarefas Kanban";
            this.Load += new System.EventHandler(this.Tarefas_Load);
            ((System.ComponentModel.ISupportInitialize)(this.banco4DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tarefaBindingNavigator)).EndInit();
            this.tarefaBindingNavigator.ResumeLayout(false);
            this.tarefaBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.responsavelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.statusDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnsair;
        private banco4DataSet banco4DataSet;
        private System.Windows.Forms.BindingSource tarefaBindingSource;
        private banco4DataSetTableAdapters.TarefaTableAdapter tarefaTableAdapter;
        private banco4DataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator tarefaBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton tarefaBindingNavigatorSaveItem;
        private banco4DataSetTableAdapters.ResponsavelTableAdapter responsavelTableAdapter;
        private System.Windows.Forms.TextBox idtarefaTextBox;
        private System.Windows.Forms.TextBox vericar_pendenciasTextBox;
        private System.Windows.Forms.TextBox executar_TrabalhoTextBox;
        private System.Windows.Forms.TextBox superviosionar_TrabalhoTextBox;
        private System.Windows.Forms.TextBox fkstatusTextBox;
        private System.Windows.Forms.TextBox fkresponsavelTextBox;
        private System.Windows.Forms.BindingSource responsavelBindingSource;
        private banco4DataSetTableAdapters.statusTableAdapter statusTableAdapter;
        private System.Windows.Forms.BindingSource statusBindingSource;
        private System.Windows.Forms.Button btnvoltar;
        private System.Windows.Forms.Button btncadastrar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnmostrar;
        private System.Windows.Forms.DataGridView responsavelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridView statusDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Label txtcadastrar;
        private System.Windows.Forms.Label label1;
    }
}