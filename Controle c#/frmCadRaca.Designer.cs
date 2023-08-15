namespace Controle_c_
{
    partial class frmCadRaca
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
            System.Windows.Forms.Label raca_codigoLabel;
            System.Windows.Forms.Label raca_nomeLabel;
            System.Windows.Forms.Label raca_pais_origemLabel;
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.raca_codigoLabel1 = new System.Windows.Forms.Label();
            this.racaBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.masterDataSet = new Controle_c_.masterDataSet();
            this.raca_nomeTextBox = new System.Windows.Forms.TextBox();
            this.raca_pais_origemTextBox = new System.Windows.Forms.TextBox();
            this.racaTableAdapter = new Controle_c_.masterDataSetTableAdapters.racaTableAdapter();
            this.tableAdapterManager = new Controle_c_.masterDataSetTableAdapters.TableAdapterManager();
            this.btnPrimeiro = new System.Windows.Forms.Button();
            this.btnAnterior = new System.Windows.Forms.Button();
            this.btnProximo = new System.Windows.Forms.Button();
            this.btnUltimo = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            raca_codigoLabel = new System.Windows.Forms.Label();
            raca_nomeLabel = new System.Windows.Forms.Label();
            raca_pais_origemLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // raca_codigoLabel
            // 
            raca_codigoLabel.AutoSize = true;
            raca_codigoLabel.Location = new System.Drawing.Point(42, 78);
            raca_codigoLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            raca_codigoLabel.Name = "raca_codigoLabel";
            raca_codigoLabel.Size = new System.Drawing.Size(95, 20);
            raca_codigoLabel.TabIndex = 0;
            raca_codigoLabel.Text = "raca codigo:";
            raca_codigoLabel.Click += new System.EventHandler(this.raca_codigoLabel_Click);
            // 
            // raca_nomeLabel
            // 
            raca_nomeLabel.AutoSize = true;
            raca_nomeLabel.Location = new System.Drawing.Point(42, 134);
            raca_nomeLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            raca_nomeLabel.Name = "raca_nomeLabel";
            raca_nomeLabel.Size = new System.Drawing.Size(88, 20);
            raca_nomeLabel.TabIndex = 2;
            raca_nomeLabel.Text = "raca nome:";
            // 
            // raca_pais_origemLabel
            // 
            raca_pais_origemLabel.AutoSize = true;
            raca_pais_origemLabel.Location = new System.Drawing.Point(42, 186);
            raca_pais_origemLabel.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            raca_pais_origemLabel.Name = "raca_pais_origemLabel";
            raca_pais_origemLabel.Size = new System.Drawing.Size(129, 20);
            raca_pais_origemLabel.TabIndex = 4;
            raca_pais_origemLabel.Text = "raca pais origem:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.groupBox1.Controls.Add(raca_codigoLabel);
            this.groupBox1.Controls.Add(this.raca_codigoLabel1);
            this.groupBox1.Controls.Add(raca_nomeLabel);
            this.groupBox1.Controls.Add(this.raca_nomeTextBox);
            this.groupBox1.Controls.Add(raca_pais_origemLabel);
            this.groupBox1.Controls.Add(this.raca_pais_origemTextBox);
            this.groupBox1.Enabled = false;
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(96, 76);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(6);
            this.groupBox1.Size = new System.Drawing.Size(1174, 788);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados da Raça";
            // 
            // raca_codigoLabel1
            // 
            this.raca_codigoLabel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.raca_codigoLabel1.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racaBindingSource, "raca_codigo", true));
            this.raca_codigoLabel1.Location = new System.Drawing.Point(183, 77);
            this.raca_codigoLabel1.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.raca_codigoLabel1.Name = "raca_codigoLabel1";
            this.raca_codigoLabel1.Size = new System.Drawing.Size(200, 42);
            this.raca_codigoLabel1.TabIndex = 1;
            this.raca_codigoLabel1.Text = "label1";
            // 
            // racaBindingSource
            // 
            this.racaBindingSource.DataMember = "raca";
            this.racaBindingSource.DataSource = this.masterDataSet;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // raca_nomeTextBox
            // 
            this.raca_nomeTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.raca_nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racaBindingSource, "raca_nome", true));
            this.raca_nomeTextBox.Location = new System.Drawing.Point(183, 134);
            this.raca_nomeTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.raca_nomeTextBox.Name = "raca_nomeTextBox";
            this.raca_nomeTextBox.Size = new System.Drawing.Size(270, 26);
            this.raca_nomeTextBox.TabIndex = 3;
            // 
            // raca_pais_origemTextBox
            // 
            this.raca_pais_origemTextBox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.raca_pais_origemTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.racaBindingSource, "raca_pais_origem", true));
            this.raca_pais_origemTextBox.Location = new System.Drawing.Point(183, 183);
            this.raca_pais_origemTextBox.Margin = new System.Windows.Forms.Padding(6);
            this.raca_pais_origemTextBox.Name = "raca_pais_origemTextBox";
            this.raca_pais_origemTextBox.Size = new System.Drawing.Size(270, 26);
            this.raca_pais_origemTextBox.TabIndex = 5;
            // 
            // racaTableAdapter
            // 
            this.racaTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.racaTableAdapter = this.racaTableAdapter;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Controle_c_.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // btnPrimeiro
            // 
            this.btnPrimeiro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPrimeiro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrimeiro.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnPrimeiro.Location = new System.Drawing.Point(119, 15);
            this.btnPrimeiro.Margin = new System.Windows.Forms.Padding(6);
            this.btnPrimeiro.Name = "btnPrimeiro";
            this.btnPrimeiro.Size = new System.Drawing.Size(91, 42);
            this.btnPrimeiro.TabIndex = 1;
            this.btnPrimeiro.Text = "<<|";
            this.btnPrimeiro.UseVisualStyleBackColor = true;
            this.btnPrimeiro.Click += new System.EventHandler(this.btnPrimeiro_Click);
            // 
            // btnAnterior
            // 
            this.btnAnterior.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnterior.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnterior.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAnterior.Location = new System.Drawing.Point(222, 15);
            this.btnAnterior.Margin = new System.Windows.Forms.Padding(6);
            this.btnAnterior.Name = "btnAnterior";
            this.btnAnterior.Size = new System.Drawing.Size(91, 42);
            this.btnAnterior.TabIndex = 2;
            this.btnAnterior.Text = "<";
            this.btnAnterior.UseVisualStyleBackColor = true;
            this.btnAnterior.Click += new System.EventHandler(this.btnAnterior_Click);
            // 
            // btnProximo
            // 
            this.btnProximo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnProximo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProximo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnProximo.Location = new System.Drawing.Point(325, 15);
            this.btnProximo.Margin = new System.Windows.Forms.Padding(6);
            this.btnProximo.Name = "btnProximo";
            this.btnProximo.Size = new System.Drawing.Size(91, 42);
            this.btnProximo.TabIndex = 3;
            this.btnProximo.Text = ">";
            this.btnProximo.UseVisualStyleBackColor = true;
            this.btnProximo.Click += new System.EventHandler(this.btnProximo_Click);
            // 
            // btnUltimo
            // 
            this.btnUltimo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUltimo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUltimo.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnUltimo.Location = new System.Drawing.Point(428, 15);
            this.btnUltimo.Margin = new System.Windows.Forms.Padding(6);
            this.btnUltimo.Name = "btnUltimo";
            this.btnUltimo.Size = new System.Drawing.Size(91, 42);
            this.btnUltimo.TabIndex = 4;
            this.btnUltimo.Text = "|>>";
            this.btnUltimo.UseVisualStyleBackColor = true;
            this.btnUltimo.Click += new System.EventHandler(this.btnUltimo_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAdicionar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdicionar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnAdicionar.Location = new System.Drawing.Point(525, 15);
            this.btnAdicionar.Margin = new System.Windows.Forms.Padding(6);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(91, 42);
            this.btnAdicionar.TabIndex = 6;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSalvar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalvar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnSalvar.Location = new System.Drawing.Point(623, 15);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(6);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 42);
            this.btnSalvar.TabIndex = 7;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnExcluir.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExcluir.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnExcluir.Location = new System.Drawing.Point(725, 15);
            this.btnExcluir.Margin = new System.Windows.Forms.Padding(6);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 42);
            this.btnExcluir.TabIndex = 8;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnEditar.Location = new System.Drawing.Point(824, 15);
            this.btnEditar.Margin = new System.Windows.Forms.Padding(6);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(91, 42);
            this.btnEditar.TabIndex = 9;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.btnCancelar.Location = new System.Drawing.Point(927, 15);
            this.btnCancelar.Margin = new System.Windows.Forms.Padding(6);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(91, 42);
            this.btnCancelar.TabIndex = 10;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmCadRaca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 24F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1604, 881);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnEditar);
            this.Controls.Add(this.btnProximo);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnAnterior);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.btnPrimeiro);
            this.Controls.Add(this.btnAdicionar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUltimo);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6);
            this.Name = "frmCadRaca";
            this.Text = "frmCadRaca";
            this.Load += new System.EventHandler(this.frmCadRaca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.racaBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource racaBindingSource;
        private masterDataSetTableAdapters.racaTableAdapter racaTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Label raca_codigoLabel1;
        private System.Windows.Forms.TextBox raca_nomeTextBox;
        private System.Windows.Forms.TextBox raca_pais_origemTextBox;
        private System.Windows.Forms.Button btnPrimeiro;
        private System.Windows.Forms.Button btnAnterior;
        private System.Windows.Forms.Button btnProximo;
        private System.Windows.Forms.Button btnUltimo;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.Button btnCancelar;
    }
}