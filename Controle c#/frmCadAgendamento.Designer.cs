namespace Controle_c_
{
    partial class frmCadAgendamento
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
            System.Windows.Forms.Label ag_codigoLabel;
            System.Windows.Forms.Label ag_dataLabel;
            System.Windows.Forms.Label ag_horarioLabel;
            System.Windows.Forms.Label ag_animalLabel;
            System.Windows.Forms.Label ag_situacaoLabel;
            System.Windows.Forms.Label ag_totalLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadAgendamento));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new Controle_c_.masterDataSet();
            this.ag_situacaoComboBox = new System.Windows.Forms.ComboBox();
            this.agendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ag_codigoTextBox = new System.Windows.Forms.TextBox();
            this.ag_dataMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ag_horarioMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.ag_animalComboBox = new System.Windows.Forms.ComboBox();
            this.ag_totalTextBox = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.agendamentoTableAdapter = new Controle_c_.masterDataSetTableAdapters.agendamentoTableAdapter();
            this.tableAdapterManager = new Controle_c_.masterDataSetTableAdapters.TableAdapterManager();
            this.agendamento_servicosTableAdapter = new Controle_c_.masterDataSetTableAdapters.agendamento_servicosTableAdapter();
            this.animalTableAdapter = new Controle_c_.masterDataSetTableAdapters.animalTableAdapter();
            this.agendamentoBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.agendamentoBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.btnCancelar = new System.Windows.Forms.ToolStripButton();
            this.btnEditar = new System.Windows.Forms.ToolStripButton();
            this.agendamentoservicosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.agendamentoBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.view_ServicosAgendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ServicosAgendamentoTableAdapter = new Controle_c_.masterDataSetTableAdapters.View_ServicosAgendamentoTableAdapter();
            this.view_ServicosAgendamentoDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ag_codigoLabel = new System.Windows.Forms.Label();
            ag_dataLabel = new System.Windows.Forms.Label();
            ag_horarioLabel = new System.Windows.Forms.Label();
            ag_animalLabel = new System.Windows.Forms.Label();
            ag_situacaoLabel = new System.Windows.Forms.Label();
            ag_totalLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingNavigator)).BeginInit();
            this.agendamentoBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoservicosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicosAgendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicosAgendamentoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // ag_codigoLabel
            // 
            ag_codigoLabel.AutoSize = true;
            ag_codigoLabel.Location = new System.Drawing.Point(53, 46);
            ag_codigoLabel.Name = "ag_codigoLabel";
            ag_codigoLabel.Size = new System.Drawing.Size(63, 20);
            ag_codigoLabel.TabIndex = 0;
            ag_codigoLabel.Text = "Código:";
            // 
            // ag_dataLabel
            // 
            ag_dataLabel.AutoSize = true;
            ag_dataLabel.Location = new System.Drawing.Point(53, 95);
            ag_dataLabel.Name = "ag_dataLabel";
            ag_dataLabel.Size = new System.Drawing.Size(48, 20);
            ag_dataLabel.TabIndex = 2;
            ag_dataLabel.Text = "Data:";
            // 
            // ag_horarioLabel
            // 
            ag_horarioLabel.AutoSize = true;
            ag_horarioLabel.Location = new System.Drawing.Point(51, 138);
            ag_horarioLabel.Name = "ag_horarioLabel";
            ag_horarioLabel.Size = new System.Drawing.Size(61, 20);
            ag_horarioLabel.TabIndex = 4;
            ag_horarioLabel.Text = "Horário";
            // 
            // ag_animalLabel
            // 
            ag_animalLabel.AutoSize = true;
            ag_animalLabel.Location = new System.Drawing.Point(353, 87);
            ag_animalLabel.Name = "ag_animalLabel";
            ag_animalLabel.Size = new System.Drawing.Size(55, 20);
            ag_animalLabel.TabIndex = 8;
            ag_animalLabel.Text = "Nome:";
            // 
            // ag_situacaoLabel
            // 
            ag_situacaoLabel.AutoSize = true;
            ag_situacaoLabel.Location = new System.Drawing.Point(353, 43);
            ag_situacaoLabel.Name = "ag_situacaoLabel";
            ag_situacaoLabel.Size = new System.Drawing.Size(76, 20);
            ag_situacaoLabel.TabIndex = 11;
            ag_situacaoLabel.Text = "Situação:";
            // 
            // ag_totalLabel
            // 
            ag_totalLabel.AutoSize = true;
            ag_totalLabel.Location = new System.Drawing.Point(353, 135);
            ag_totalLabel.Name = "ag_totalLabel";
            ag_totalLabel.Size = new System.Drawing.Size(48, 20);
            ag_totalLabel.TabIndex = 10;
            ag_totalLabel.Text = "Total:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(ag_situacaoLabel);
            this.groupBox1.Controls.Add(this.ag_situacaoComboBox);
            this.groupBox1.Controls.Add(ag_codigoLabel);
            this.groupBox1.Controls.Add(this.ag_codigoTextBox);
            this.groupBox1.Controls.Add(ag_dataLabel);
            this.groupBox1.Controls.Add(this.ag_dataMaskedTextBox);
            this.groupBox1.Controls.Add(ag_horarioLabel);
            this.groupBox1.Controls.Add(this.ag_horarioMaskedTextBox);
            this.groupBox1.Controls.Add(ag_animalLabel);
            this.groupBox1.Controls.Add(this.ag_animalComboBox);
            this.groupBox1.Controls.Add(ag_totalLabel);
            this.groupBox1.Controls.Add(this.ag_totalTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Location = new System.Drawing.Point(81, 60);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(835, 207);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do Agendamento";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.animalBindingSource, "ani_foto", true));
            this.pictureBox1.Location = new System.Drawing.Point(682, 63);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 77);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // animalBindingSource
            // 
            this.animalBindingSource.DataMember = "animal";
            this.animalBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // ag_situacaoComboBox
            // 
            this.ag_situacaoComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ag_situacaoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_situacao", true));
            this.ag_situacaoComboBox.FormattingEnabled = true;
            this.ag_situacaoComboBox.Items.AddRange(new object[] {
            "INICIADO",
            "CONCLUIDO",
            "PAUSADO",
            "AGENDADO"});
            this.ag_situacaoComboBox.Location = new System.Drawing.Point(454, 40);
            this.ag_situacaoComboBox.Name = "ag_situacaoComboBox";
            this.ag_situacaoComboBox.Size = new System.Drawing.Size(180, 28);
            this.ag_situacaoComboBox.TabIndex = 12;
            // 
            // agendamentoBindingSource
            // 
            this.agendamentoBindingSource.DataMember = "agendamento";
            this.agendamentoBindingSource.DataSource = this.masterDataSet;
            // 
            // ag_codigoTextBox
            // 
            this.ag_codigoTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ag_codigoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_codigo", true));
            this.ag_codigoTextBox.Location = new System.Drawing.Point(154, 43);
            this.ag_codigoTextBox.Name = "ag_codigoTextBox";
            this.ag_codigoTextBox.Size = new System.Drawing.Size(121, 26);
            this.ag_codigoTextBox.TabIndex = 1;
            // 
            // ag_dataMaskedTextBox
            // 
            this.ag_dataMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ag_dataMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_data", true));
            this.ag_dataMaskedTextBox.Location = new System.Drawing.Point(154, 87);
            this.ag_dataMaskedTextBox.Mask = "00/00/0000";
            this.ag_dataMaskedTextBox.Name = "ag_dataMaskedTextBox";
            this.ag_dataMaskedTextBox.Size = new System.Drawing.Size(121, 26);
            this.ag_dataMaskedTextBox.TabIndex = 3;
            this.ag_dataMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // ag_horarioMaskedTextBox
            // 
            this.ag_horarioMaskedTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ag_horarioMaskedTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_horario", true));
            this.ag_horarioMaskedTextBox.Location = new System.Drawing.Point(154, 135);
            this.ag_horarioMaskedTextBox.Mask = "00:00";
            this.ag_horarioMaskedTextBox.Name = "ag_horarioMaskedTextBox";
            this.ag_horarioMaskedTextBox.Size = new System.Drawing.Size(121, 26);
            this.ag_horarioMaskedTextBox.TabIndex = 5;
            this.ag_horarioMaskedTextBox.ValidatingType = typeof(System.DateTime);
            // 
            // ag_animalComboBox
            // 
            this.ag_animalComboBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ag_animalComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.agendamentoBindingSource, "ag_animal", true));
            this.ag_animalComboBox.DataSource = this.animalBindingSource;
            this.ag_animalComboBox.DisplayMember = "ani_nome";
            this.ag_animalComboBox.FormattingEnabled = true;
            this.ag_animalComboBox.Location = new System.Drawing.Point(454, 84);
            this.ag_animalComboBox.Name = "ag_animalComboBox";
            this.ag_animalComboBox.Size = new System.Drawing.Size(180, 28);
            this.ag_animalComboBox.TabIndex = 9;
            this.ag_animalComboBox.ValueMember = "ani_codigo";
            // 
            // ag_totalTextBox
            // 
            this.ag_totalTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ag_totalTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.agendamentoBindingSource, "ag_total", true));
            this.ag_totalTextBox.Location = new System.Drawing.Point(454, 132);
            this.ag_totalTextBox.Multiline = true;
            this.ag_totalTextBox.Name = "ag_totalTextBox";
            this.ag_totalTextBox.Size = new System.Drawing.Size(180, 26);
            this.ag_totalTextBox.TabIndex = 11;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.view_ServicosAgendamentoDataGridView);
            this.groupBox2.Location = new System.Drawing.Point(81, 309);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(835, 287);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Serviços";
            // 
            // agendamentoTableAdapter
            // 
            this.agendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = this.agendamento_servicosTableAdapter;
            this.tableAdapterManager.agendamentoTableAdapter = this.agendamentoTableAdapter;
            this.tableAdapterManager.animalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Controle_c_.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // agendamento_servicosTableAdapter
            // 
            this.agendamento_servicosTableAdapter.ClearBeforeFill = true;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // agendamentoBindingNavigator
            // 
            this.agendamentoBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.agendamentoBindingNavigator.BindingSource = this.agendamentoBindingSource;
            this.agendamentoBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.agendamentoBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.agendamentoBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.agendamentoBindingNavigatorSaveItem,
            this.btnCancelar,
            this.btnEditar});
            this.agendamentoBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.agendamentoBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.agendamentoBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.agendamentoBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.agendamentoBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.agendamentoBindingNavigator.Name = "agendamentoBindingNavigator";
            this.agendamentoBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.agendamentoBindingNavigator.Size = new System.Drawing.Size(1588, 25);
            this.agendamentoBindingNavigator.TabIndex = 2;
            this.agendamentoBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(23, 22);
            this.bindingNavigatorAddNewItem.Text = "Adicionar novo";
            this.bindingNavigatorAddNewItem.Click += new System.EventHandler(this.bindingNavigatorAddNewItem_Click);
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
            this.bindingNavigatorDeleteItem.Click += new System.EventHandler(this.bindingNavigatorDeleteItem_Click);
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
            // agendamentoBindingNavigatorSaveItem
            // 
            this.agendamentoBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.agendamentoBindingNavigatorSaveItem.Image = global::Controle_c_.Properties.Resources.salvar_arquivo1;
            this.agendamentoBindingNavigatorSaveItem.Name = "agendamentoBindingNavigatorSaveItem";
            this.agendamentoBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.agendamentoBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.agendamentoBindingNavigatorSaveItem.Click += new System.EventHandler(this.agendamentoBindingNavigatorSaveItem_Click_2);
            // 
            // btnCancelar
            // 
            this.btnCancelar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnCancelar.Image = global::Controle_c_.Properties.Resources.cancelar1;
            this.btnCancelar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(23, 22);
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btnEditar.Image = global::Controle_c_.Properties.Resources.editar_texto2;
            this.btnEditar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(23, 22);
            this.btnEditar.Text = "Editar";
            this.btnEditar.TextImageRelation = System.Windows.Forms.TextImageRelation.Overlay;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // agendamentoservicosBindingSource
            // 
            this.agendamentoservicosBindingSource.DataMember = "agendamento_servicos";
            this.agendamentoservicosBindingSource.DataSource = this.masterDataSet;
            // 
            // agendamentoBindingSource1
            // 
            this.agendamentoBindingSource1.DataMember = "agendamento";
            this.agendamentoBindingSource1.DataSource = this.masterDataSet;
            // 
            // view_ServicosAgendamentoBindingSource
            // 
            this.view_ServicosAgendamentoBindingSource.DataMember = "View_ServicosAgendamento";
            this.view_ServicosAgendamentoBindingSource.DataSource = this.masterDataSet;
            // 
            // view_ServicosAgendamentoTableAdapter
            // 
            this.view_ServicosAgendamentoTableAdapter.ClearBeforeFill = true;
            // 
            // view_ServicosAgendamentoDataGridView
            // 
            this.view_ServicosAgendamentoDataGridView.AllowUserToAddRows = false;
            this.view_ServicosAgendamentoDataGridView.AllowUserToDeleteRows = false;
            this.view_ServicosAgendamentoDataGridView.AutoGenerateColumns = false;
            this.view_ServicosAgendamentoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.view_ServicosAgendamentoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8});
            this.view_ServicosAgendamentoDataGridView.DataSource = this.view_ServicosAgendamentoBindingSource;
            this.view_ServicosAgendamentoDataGridView.Location = new System.Drawing.Point(6, 47);
            this.view_ServicosAgendamentoDataGridView.Name = "view_ServicosAgendamentoDataGridView";
            this.view_ServicosAgendamentoDataGridView.ReadOnly = true;
            this.view_ServicosAgendamentoDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.view_ServicosAgendamentoDataGridView.Size = new System.Drawing.Size(824, 183);
            this.view_ServicosAgendamentoDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "ag_serv_numero";
            this.dataGridViewTextBoxColumn1.HeaderText = "ag_serv_numero";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 200;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "ag_serv_agendamento";
            this.dataGridViewTextBoxColumn2.HeaderText = "ag_serv_agendamento";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Visible = false;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "ag_serv_servico";
            this.dataGridViewTextBoxColumn3.HeaderText = "ag_serv_servico";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Visible = false;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "serv_descricao";
            this.dataGridViewTextBoxColumn4.HeaderText = "serv_descricao";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 220;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "serv_tempo";
            this.dataGridViewTextBoxColumn5.HeaderText = "serv_tempo";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "ag_serv_quantidade";
            this.dataGridViewTextBoxColumn6.HeaderText = "ag_serv_quantidade";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "ag_serv_valor_unitario";
            this.dataGridViewTextBoxColumn7.HeaderText = "ag_serv_valor_unitario";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "Subtotal";
            this.dataGridViewTextBoxColumn8.HeaderText = "Subtotal";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // frmCadAgendamento
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1588, 842);
            this.Controls.Add(this.agendamentoBindingNavigator);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadAgendamento";
            this.Text = "frmCadAgendamento";
            this.Load += new System.EventHandler(this.frmCadAgendamento_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingNavigator)).EndInit();
            this.agendamentoBindingNavigator.ResumeLayout(false);
            this.agendamentoBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoservicosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.agendamentoBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicosAgendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicosAgendamentoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource agendamentoBindingSource;
        private masterDataSetTableAdapters.agendamentoTableAdapter agendamentoTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator agendamentoBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton agendamentoBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox ag_codigoTextBox;
        private System.Windows.Forms.MaskedTextBox ag_dataMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox ag_horarioMaskedTextBox;
        private System.Windows.Forms.ComboBox ag_animalComboBox;
        private System.Windows.Forms.ComboBox ag_situacaoComboBox;
        private masterDataSetTableAdapters.agendamento_servicosTableAdapter agendamento_servicosTableAdapter;
        private System.Windows.Forms.BindingSource agendamentoservicosBindingSource;
        private System.Windows.Forms.BindingSource agendamentoBindingSource1;
        private masterDataSetTableAdapters.animalTableAdapter animalTableAdapter;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox ag_totalTextBox;
        private System.Windows.Forms.ToolStripButton btnCancelar;
        private System.Windows.Forms.ToolStripButton btnEditar;
        private System.Windows.Forms.BindingSource view_ServicosAgendamentoBindingSource;
        private masterDataSetTableAdapters.View_ServicosAgendamentoTableAdapter view_ServicosAgendamentoTableAdapter;
        private System.Windows.Forms.DataGridView view_ServicosAgendamentoDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
    }
}