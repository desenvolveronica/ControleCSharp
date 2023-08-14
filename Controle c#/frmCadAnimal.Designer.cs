namespace Controle_c_
{
    partial class frmCadAnimal
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
            System.Windows.Forms.Label ani_codigoLabel;
            System.Windows.Forms.Label ani_nomeLabel;
            System.Windows.Forms.Label ani_sexoLabel;
            System.Windows.Forms.Label ani_agressivoLabel;
            System.Windows.Forms.Label ani_corLabel;
            System.Windows.Forms.Label ani_idadeLabel;
            System.Windows.Forms.Label ani_alergiaLabel;
            System.Windows.Forms.Label ani_clienteLabel;
            System.Windows.Forms.Label ani_racaLabel;
            System.Windows.Forms.Label ani_fotoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCadAnimal));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnFoto_ani = new System.Windows.Forms.Button();
            this.ani_codigoLabel1 = new System.Windows.Forms.Label();
            this.animalBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new Controle_c_.masterDataSet();
            this.ani_nomeTextBox = new System.Windows.Forms.TextBox();
            this.ani_sexoComboBox = new System.Windows.Forms.ComboBox();
            this.ani_agressivoComboBox = new System.Windows.Forms.ComboBox();
            this.ani_corComboBox = new System.Windows.Forms.ComboBox();
            this.ani_idadeTextBox = new System.Windows.Forms.TextBox();
            this.ani_alergiaTextBox = new System.Windows.Forms.TextBox();
            this.ani_clienteComboBox = new System.Windows.Forms.ComboBox();
            this.clienteBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.ani_racaComboBox = new System.Windows.Forms.ComboBox();
            this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ani_fotoPictureBox = new System.Windows.Forms.PictureBox();
            this.animalTableAdapter = new Controle_c_.masterDataSetTableAdapters.animalTableAdapter();
            this.tableAdapterManager = new Controle_c_.masterDataSetTableAdapters.TableAdapterManager();
            this.clienteTableAdapter = new Controle_c_.masterDataSetTableAdapters.clienteTableAdapter();
            this.racaTableAdapter = new Controle_c_.masterDataSetTableAdapters.racaTableAdapter();
            this.animalBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.animalBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.clienteBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.clienteBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            ani_codigoLabel = new System.Windows.Forms.Label();
            ani_nomeLabel = new System.Windows.Forms.Label();
            ani_sexoLabel = new System.Windows.Forms.Label();
            ani_agressivoLabel = new System.Windows.Forms.Label();
            ani_corLabel = new System.Windows.Forms.Label();
            ani_idadeLabel = new System.Windows.Forms.Label();
            ani_alergiaLabel = new System.Windows.Forms.Label();
            ani_clienteLabel = new System.Windows.Forms.Label();
            ani_racaLabel = new System.Windows.Forms.Label();
            ani_fotoLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ani_fotoPictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).BeginInit();
            this.animalBindingNavigator.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ani_codigoLabel
            // 
            ani_codigoLabel.AutoSize = true;
            ani_codigoLabel.Location = new System.Drawing.Point(175, 93);
            ani_codigoLabel.Name = "ani_codigoLabel";
            ani_codigoLabel.Size = new System.Drawing.Size(85, 20);
            ani_codigoLabel.TabIndex = 0;
            ani_codigoLabel.Text = "ani codigo:";
            // 
            // ani_nomeLabel
            // 
            ani_nomeLabel.AutoSize = true;
            ani_nomeLabel.Location = new System.Drawing.Point(175, 122);
            ani_nomeLabel.Name = "ani_nomeLabel";
            ani_nomeLabel.Size = new System.Drawing.Size(78, 20);
            ani_nomeLabel.TabIndex = 2;
            ani_nomeLabel.Text = "ani nome:";
            // 
            // ani_sexoLabel
            // 
            ani_sexoLabel.AutoSize = true;
            ani_sexoLabel.Location = new System.Drawing.Point(175, 154);
            ani_sexoLabel.Name = "ani_sexoLabel";
            ani_sexoLabel.Size = new System.Drawing.Size(71, 20);
            ani_sexoLabel.TabIndex = 4;
            ani_sexoLabel.Text = "ani sexo:";
            // 
            // ani_agressivoLabel
            // 
            ani_agressivoLabel.AutoSize = true;
            ani_agressivoLabel.Location = new System.Drawing.Point(175, 188);
            ani_agressivoLabel.Name = "ani_agressivoLabel";
            ani_agressivoLabel.Size = new System.Drawing.Size(105, 20);
            ani_agressivoLabel.TabIndex = 6;
            ani_agressivoLabel.Text = "ani agressivo:";
            // 
            // ani_corLabel
            // 
            ani_corLabel.AutoSize = true;
            ani_corLabel.Location = new System.Drawing.Point(175, 222);
            ani_corLabel.Name = "ani_corLabel";
            ani_corLabel.Size = new System.Drawing.Size(60, 20);
            ani_corLabel.TabIndex = 8;
            ani_corLabel.Text = "ani cor:";
            // 
            // ani_idadeLabel
            // 
            ani_idadeLabel.AutoSize = true;
            ani_idadeLabel.Location = new System.Drawing.Point(175, 256);
            ani_idadeLabel.Name = "ani_idadeLabel";
            ani_idadeLabel.Size = new System.Drawing.Size(77, 20);
            ani_idadeLabel.TabIndex = 10;
            ani_idadeLabel.Text = "ani idade:";
            // 
            // ani_alergiaLabel
            // 
            ani_alergiaLabel.AutoSize = true;
            ani_alergiaLabel.Location = new System.Drawing.Point(175, 288);
            ani_alergiaLabel.Name = "ani_alergiaLabel";
            ani_alergiaLabel.Size = new System.Drawing.Size(85, 20);
            ani_alergiaLabel.TabIndex = 12;
            ani_alergiaLabel.Text = "ani alergia:";
            // 
            // ani_clienteLabel
            // 
            ani_clienteLabel.AutoSize = true;
            ani_clienteLabel.Location = new System.Drawing.Point(176, 383);
            ani_clienteLabel.Name = "ani_clienteLabel";
            ani_clienteLabel.Size = new System.Drawing.Size(84, 20);
            ani_clienteLabel.TabIndex = 14;
            ani_clienteLabel.Text = "ani cliente:";
            // 
            // ani_racaLabel
            // 
            ani_racaLabel.AutoSize = true;
            ani_racaLabel.Location = new System.Drawing.Point(175, 413);
            ani_racaLabel.Name = "ani_racaLabel";
            ani_racaLabel.Size = new System.Drawing.Size(69, 20);
            ani_racaLabel.TabIndex = 16;
            ani_racaLabel.Text = "ani raca:";
            // 
            // ani_fotoLabel
            // 
            ani_fotoLabel.AutoSize = true;
            ani_fotoLabel.Location = new System.Drawing.Point(738, 98);
            ani_fotoLabel.Name = "ani_fotoLabel";
            ani_fotoLabel.Size = new System.Drawing.Size(66, 20);
            ani_fotoLabel.TabIndex = 18;
            ani_fotoLabel.Text = "ani foto:";
            ani_fotoLabel.Click += new System.EventHandler(this.ani_fotoLabel_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnFoto_ani);
            this.groupBox1.Controls.Add(ani_codigoLabel);
            this.groupBox1.Controls.Add(this.ani_codigoLabel1);
            this.groupBox1.Controls.Add(ani_nomeLabel);
            this.groupBox1.Controls.Add(this.ani_nomeTextBox);
            this.groupBox1.Controls.Add(ani_sexoLabel);
            this.groupBox1.Controls.Add(this.ani_sexoComboBox);
            this.groupBox1.Controls.Add(ani_agressivoLabel);
            this.groupBox1.Controls.Add(this.ani_agressivoComboBox);
            this.groupBox1.Controls.Add(ani_corLabel);
            this.groupBox1.Controls.Add(this.ani_corComboBox);
            this.groupBox1.Controls.Add(ani_idadeLabel);
            this.groupBox1.Controls.Add(this.ani_idadeTextBox);
            this.groupBox1.Controls.Add(ani_alergiaLabel);
            this.groupBox1.Controls.Add(this.ani_alergiaTextBox);
            this.groupBox1.Controls.Add(ani_clienteLabel);
            this.groupBox1.Controls.Add(this.ani_clienteComboBox);
            this.groupBox1.Controls.Add(ani_racaLabel);
            this.groupBox1.Controls.Add(this.ani_racaComboBox);
            this.groupBox1.Controls.Add(ani_fotoLabel);
            this.groupBox1.Controls.Add(this.ani_fotoPictureBox);
            this.groupBox1.Location = new System.Drawing.Point(0, 28);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1309, 737);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados do animal";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnFoto_ani
            // 
            this.btnFoto_ani.BackgroundImage = global::Controle_c_.Properties.Resources.bicho_de_estimacao;
            this.btnFoto_ani.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnFoto_ani.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFoto_ani.Location = new System.Drawing.Point(734, 151);
            this.btnFoto_ani.Name = "btnFoto_ani";
            this.btnFoto_ani.Size = new System.Drawing.Size(70, 57);
            this.btnFoto_ani.TabIndex = 20;
            this.btnFoto_ani.UseVisualStyleBackColor = true;
            this.btnFoto_ani.Click += new System.EventHandler(this.btnFoto_ani_Click);
            // 
            // ani_codigoLabel1
            // 
            this.ani_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_codigo", true));
            this.ani_codigoLabel1.Location = new System.Drawing.Point(286, 93);
            this.ani_codigoLabel1.Name = "ani_codigoLabel1";
            this.ani_codigoLabel1.Size = new System.Drawing.Size(121, 23);
            this.ani_codigoLabel1.TabIndex = 1;
            this.ani_codigoLabel1.Text = "label1";
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
            // ani_nomeTextBox
            // 
            this.ani_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_nome", true));
            this.ani_nomeTextBox.Location = new System.Drawing.Point(286, 119);
            this.ani_nomeTextBox.Name = "ani_nomeTextBox";
            this.ani_nomeTextBox.Size = new System.Drawing.Size(283, 26);
            this.ani_nomeTextBox.TabIndex = 3;
            // 
            // ani_sexoComboBox
            // 
            this.ani_sexoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_sexo", true));
            this.ani_sexoComboBox.FormattingEnabled = true;
            this.ani_sexoComboBox.Items.AddRange(new object[] {
            "F",
            "M"});
            this.ani_sexoComboBox.Location = new System.Drawing.Point(286, 151);
            this.ani_sexoComboBox.Name = "ani_sexoComboBox";
            this.ani_sexoComboBox.Size = new System.Drawing.Size(62, 28);
            this.ani_sexoComboBox.TabIndex = 5;
            // 
            // ani_agressivoComboBox
            // 
            this.ani_agressivoComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_agressivo", true));
            this.ani_agressivoComboBox.FormattingEnabled = true;
            this.ani_agressivoComboBox.Items.AddRange(new object[] {
            "S",
            "N"});
            this.ani_agressivoComboBox.Location = new System.Drawing.Point(286, 185);
            this.ani_agressivoComboBox.Name = "ani_agressivoComboBox";
            this.ani_agressivoComboBox.Size = new System.Drawing.Size(62, 28);
            this.ani_agressivoComboBox.TabIndex = 7;
            // 
            // ani_corComboBox
            // 
            this.ani_corComboBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_cor", true));
            this.ani_corComboBox.FormattingEnabled = true;
            this.ani_corComboBox.Items.AddRange(new object[] {
            "BRANCO",
            "PRETO",
            "COLORIDO",
            "CARAMELO"});
            this.ani_corComboBox.Location = new System.Drawing.Point(286, 219);
            this.ani_corComboBox.Name = "ani_corComboBox";
            this.ani_corComboBox.Size = new System.Drawing.Size(192, 28);
            this.ani_corComboBox.TabIndex = 9;
            // 
            // ani_idadeTextBox
            // 
            this.ani_idadeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_idade", true));
            this.ani_idadeTextBox.Location = new System.Drawing.Point(286, 253);
            this.ani_idadeTextBox.Name = "ani_idadeTextBox";
            this.ani_idadeTextBox.Size = new System.Drawing.Size(121, 26);
            this.ani_idadeTextBox.TabIndex = 11;
            // 
            // ani_alergiaTextBox
            // 
            this.ani_alergiaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.animalBindingSource, "ani_alergia", true));
            this.ani_alergiaTextBox.Location = new System.Drawing.Point(286, 288);
            this.ani_alergiaTextBox.MaxLength = 50;
            this.ani_alergiaTextBox.Multiline = true;
            this.ani_alergiaTextBox.Name = "ani_alergiaTextBox";
            this.ani_alergiaTextBox.Size = new System.Drawing.Size(283, 86);
            this.ani_alergiaTextBox.TabIndex = 13;
            this.ani_alergiaTextBox.TextChanged += new System.EventHandler(this.ani_alergiaTextBox_TextChanged);
            // 
            // ani_clienteComboBox
            // 
            this.ani_clienteComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animalBindingSource, "ani_cliente", true));
            this.ani_clienteComboBox.DataSource = this.clienteBindingSource2;
            this.ani_clienteComboBox.DisplayMember = "cli_nome";
            this.ani_clienteComboBox.FormattingEnabled = true;
            this.ani_clienteComboBox.Location = new System.Drawing.Point(286, 380);
            this.ani_clienteComboBox.Name = "ani_clienteComboBox";
            this.ani_clienteComboBox.Size = new System.Drawing.Size(192, 28);
            this.ani_clienteComboBox.TabIndex = 15;
            this.ani_clienteComboBox.ValueMember = "cli_codigo";
            // 
            // clienteBindingSource2
            // 
            this.clienteBindingSource2.DataMember = "cliente";
            this.clienteBindingSource2.DataSource = this.masterDataSet;
            // 
            // ani_racaComboBox
            // 
            this.ani_racaComboBox.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.animalBindingSource, "ani_raca", true));
            this.ani_racaComboBox.DataSource = this.racaBindingSource;
            this.ani_racaComboBox.DisplayMember = "raca_nome";
            this.ani_racaComboBox.FormattingEnabled = true;
            this.ani_racaComboBox.Location = new System.Drawing.Point(286, 414);
            this.ani_racaComboBox.Name = "ani_racaComboBox";
            this.ani_racaComboBox.Size = new System.Drawing.Size(192, 28);
            this.ani_racaComboBox.TabIndex = 17;
            this.ani_racaComboBox.ValueMember = "raca_codigo";
            this.ani_racaComboBox.SelectedIndexChanged += new System.EventHandler(this.ani_racaComboBox_SelectedIndexChanged);
            // 
            // racaBindingSource
            // 
            this.racaBindingSource.DataMember = "raca";
            this.racaBindingSource.DataSource = this.masterDataSet;
            // 
            // ani_fotoPictureBox
            // 
            this.ani_fotoPictureBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.ani_fotoPictureBox.DataBindings.Add(new System.Windows.Forms.Binding("Image", this.animalBindingSource, "ani_foto", true));
            this.ani_fotoPictureBox.Location = new System.Drawing.Point(826, 98);
            this.ani_fotoPictureBox.Name = "ani_fotoPictureBox";
            this.ani_fotoPictureBox.Size = new System.Drawing.Size(121, 115);
            this.ani_fotoPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.ani_fotoPictureBox.TabIndex = 19;
            this.ani_fotoPictureBox.TabStop = false;
            // 
            // animalTableAdapter
            // 
            this.animalTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = this.animalTableAdapter;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = this.clienteTableAdapter;
            this.tableAdapterManager.racaTableAdapter = this.racaTableAdapter;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Controle_c_.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // clienteTableAdapter
            // 
            this.clienteTableAdapter.ClearBeforeFill = true;
            // 
            // racaTableAdapter
            // 
            this.racaTableAdapter.ClearBeforeFill = true;
            // 
            // animalBindingNavigator
            // 
            this.animalBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.animalBindingNavigator.BindingSource = this.animalBindingSource;
            this.animalBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.animalBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.animalBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.animalBindingNavigatorSaveItem});
            this.animalBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.animalBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.animalBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.animalBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.animalBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.animalBindingNavigator.Name = "animalBindingNavigator";
            this.animalBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.animalBindingNavigator.Size = new System.Drawing.Size(1604, 25);
            this.animalBindingNavigator.TabIndex = 1;
            this.animalBindingNavigator.Text = "bindingNavigator1";
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
            // animalBindingNavigatorSaveItem
            // 
            this.animalBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.animalBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("animalBindingNavigatorSaveItem.Image")));
            this.animalBindingNavigatorSaveItem.Name = "animalBindingNavigatorSaveItem";
            this.animalBindingNavigatorSaveItem.Size = new System.Drawing.Size(23, 22);
            this.animalBindingNavigatorSaveItem.Text = "Salvar Dados";
            this.animalBindingNavigatorSaveItem.Click += new System.EventHandler(this.animalBindingNavigatorSaveItem_Click);
            // 
            // clienteBindingSource
            // 
            this.clienteBindingSource.DataMember = "cliente";
            this.clienteBindingSource.DataSource = this.masterDataSet;
            // 
            // clienteBindingSource1
            // 
            this.clienteBindingSource1.DataMember = "cliente";
            this.clienteBindingSource1.DataSource = this.masterDataSet;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            this.openFileDialog1.Title = "Escolha a foto do seu pet";
            // 
            // frmCadAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.animalBindingNavigator);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "frmCadAnimal";
            this.Text = "frmCadAnimal";
            this.Load += new System.EventHandler(this.frmCadAnimal_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ani_fotoPictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.animalBindingNavigator)).EndInit();
            this.animalBindingNavigator.ResumeLayout(false);
            this.animalBindingNavigator.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.clienteBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource animalBindingSource;
        private masterDataSetTableAdapters.animalTableAdapter animalTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator animalBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton animalBindingNavigatorSaveItem;
        private System.Windows.Forms.Label ani_codigoLabel1;
        private System.Windows.Forms.TextBox ani_nomeTextBox;
        private System.Windows.Forms.ComboBox ani_sexoComboBox;
        private System.Windows.Forms.ComboBox ani_agressivoComboBox;
        private System.Windows.Forms.ComboBox ani_corComboBox;
        private System.Windows.Forms.TextBox ani_idadeTextBox;
        private System.Windows.Forms.TextBox ani_alergiaTextBox;
        private System.Windows.Forms.ComboBox ani_clienteComboBox;
        private System.Windows.Forms.ComboBox ani_racaComboBox;
        private System.Windows.Forms.PictureBox ani_fotoPictureBox;
        private masterDataSetTableAdapters.clienteTableAdapter clienteTableAdapter;
        private System.Windows.Forms.BindingSource clienteBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource1;
        private masterDataSetTableAdapters.racaTableAdapter racaTableAdapter;
        private System.Windows.Forms.BindingSource racaBindingSource;
        private System.Windows.Forms.BindingSource clienteBindingSource2;
        private System.Windows.Forms.Button btnFoto_ani;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}