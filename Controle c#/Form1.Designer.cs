namespace Controle_c_
{
    partial class Form1
    {
        /// <summary>
        /// Variável de designer necessária.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpar os recursos que estão sendo usados.
        /// </summary>
        /// <param name="disposing">true se for necessário descartar os recursos gerenciados; caso contrário, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código gerado pelo Windows Form Designer

        /// <summary>
        /// Método necessário para suporte ao Designer - não modifique 
        /// o conteúdo deste método com o editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.PanelTop = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMaxi = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblAgandado = new System.Windows.Forms.Label();
            this.lblAndamento = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelSelecao = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAgendamentos = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnRacas = new System.Windows.Forms.Button();
            this.btnAnimais = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.masterDataSet = new Controle_c_.masterDataSet();
            this.view_ServicosAgendamentoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_ServicosAgendamentoTableAdapter = new Controle_c_.masterDataSetTableAdapters.View_ServicosAgendamentoTableAdapter();
            this.tableAdapterManager = new Controle_c_.masterDataSetTableAdapters.TableAdapterManager();
            this.view_DetalhesAgendamentosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.view_DetalhesAgendamentosTableAdapter = new Controle_c_.masterDataSetTableAdapters.View_DetalhesAgendamentosTableAdapter();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PanelTop.SuspendLayout();
            this.PanelLateral.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicosAgendamentoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DetalhesAgendamentosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelTop
            // 
            this.PanelTop.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PanelTop.Controls.Add(this.btnMax);
            this.PanelTop.Controls.Add(this.btnMaxi);
            this.PanelTop.Controls.Add(this.btnSair);
            this.PanelTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelTop.Location = new System.Drawing.Point(0, 0);
            this.PanelTop.Name = "PanelTop";
            this.PanelTop.Size = new System.Drawing.Size(1467, 43);
            this.PanelTop.TabIndex = 0;
            // 
            // btnMax
            // 
            this.btnMax.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMax.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMax.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMax.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMax.Location = new System.Drawing.Point(1227, 6);
            this.btnMax.Name = "btnMax";
            this.btnMax.Size = new System.Drawing.Size(75, 34);
            this.btnMax.TabIndex = 2;
            this.btnMax.Text = "MAX";
            this.btnMax.UseVisualStyleBackColor = true;
            this.btnMax.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // btnMaxi
            // 
            this.btnMaxi.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMaxi.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMaxi.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMaxi.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnMaxi.Location = new System.Drawing.Point(1308, 6);
            this.btnMaxi.Name = "btnMaxi";
            this.btnMaxi.Size = new System.Drawing.Size(75, 34);
            this.btnMaxi.TabIndex = 1;
            this.btnMaxi.Text = "MIN";
            this.btnMaxi.UseVisualStyleBackColor = true;
            this.btnMaxi.Click += new System.EventHandler(this.btnMaxi_Click);
            // 
            // btnSair
            // 
            this.btnSair.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Location = new System.Drawing.Point(1389, 6);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(75, 34);
            this.btnSair.TabIndex = 0;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // PanelLateral
            // 
            this.PanelLateral.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.PanelLateral.Controls.Add(this.groupBox1);
            this.PanelLateral.Controls.Add(this.panelSelecao);
            this.PanelLateral.Controls.Add(this.btnHome);
            this.PanelLateral.Controls.Add(this.btnAgendamentos);
            this.PanelLateral.Controls.Add(this.btnServicos);
            this.PanelLateral.Controls.Add(this.btnRacas);
            this.PanelLateral.Controls.Add(this.btnAnimais);
            this.PanelLateral.Controls.Add(this.btnClientes);
            this.PanelLateral.Dock = System.Windows.Forms.DockStyle.Left;
            this.PanelLateral.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PanelLateral.Location = new System.Drawing.Point(0, 43);
            this.PanelLateral.Name = "PanelLateral";
            this.PanelLateral.Size = new System.Drawing.Size(276, 684);
            this.PanelLateral.TabIndex = 1;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.lblAgandado);
            this.groupBox1.Controls.Add(this.lblAndamento);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.groupBox1.Location = new System.Drawing.Point(56, 459);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 144);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendamentos";
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold);
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(93, 106);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(93, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Detalhes";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_2);
            // 
            // lblAgandado
            // 
            this.lblAgandado.AutoSize = true;
            this.lblAgandado.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAgandado.Location = new System.Drawing.Point(146, 76);
            this.lblAgandado.Name = "lblAgandado";
            this.lblAgandado.Size = new System.Drawing.Size(17, 17);
            this.lblAgandado.TabIndex = 3;
            this.lblAgandado.Text = "0";
            // 
            // lblAndamento
            // 
            this.lblAndamento.AutoSize = true;
            this.lblAndamento.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAndamento.Location = new System.Drawing.Point(146, 44);
            this.lblAndamento.Name = "lblAndamento";
            this.lblAndamento.Size = new System.Drawing.Size(17, 17);
            this.lblAndamento.TabIndex = 2;
            this.lblAndamento.Text = "0";
            this.lblAndamento.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 76);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Agendado";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Courier New", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 44);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Em Andamento";
            // 
            // panelSelecao
            // 
            this.panelSelecao.BackColor = System.Drawing.Color.DarkSlateBlue;
            this.panelSelecao.Location = new System.Drawing.Point(26, 75);
            this.panelSelecao.Name = "panelSelecao";
            this.panelSelecao.Size = new System.Drawing.Size(24, 50);
            this.panelSelecao.TabIndex = 6;
            this.panelSelecao.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // btnHome
            // 
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHome.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnHome.Location = new System.Drawing.Point(56, 75);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(192, 50);
            this.btnHome.TabIndex = 5;
            this.btnHome.Text = "Home";
            this.btnHome.UseVisualStyleBackColor = true;
            this.btnHome.Click += new System.EventHandler(this.btnHome_Click_1);
            // 
            // btnAgendamentos
            // 
            this.btnAgendamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAgendamentos.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgendamentos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAgendamentos.Location = new System.Drawing.Point(56, 393);
            this.btnAgendamentos.Name = "btnAgendamentos";
            this.btnAgendamentos.Size = new System.Drawing.Size(192, 46);
            this.btnAgendamentos.TabIndex = 4;
            this.btnAgendamentos.Text = "Agendamentos";
            this.btnAgendamentos.UseVisualStyleBackColor = true;
            this.btnAgendamentos.Click += new System.EventHandler(this.btnAgendamentos_Click);
            // 
            // btnServicos
            // 
            this.btnServicos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnServicos.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnServicos.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnServicos.Location = new System.Drawing.Point(56, 330);
            this.btnServicos.Name = "btnServicos";
            this.btnServicos.Size = new System.Drawing.Size(192, 46);
            this.btnServicos.TabIndex = 3;
            this.btnServicos.Text = "Serviços";
            this.btnServicos.UseVisualStyleBackColor = true;
            this.btnServicos.Click += new System.EventHandler(this.btnServicos_Click);
            // 
            // btnRacas
            // 
            this.btnRacas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRacas.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRacas.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnRacas.Location = new System.Drawing.Point(56, 268);
            this.btnRacas.Name = "btnRacas";
            this.btnRacas.Size = new System.Drawing.Size(192, 46);
            this.btnRacas.TabIndex = 2;
            this.btnRacas.Text = "Raças";
            this.btnRacas.UseVisualStyleBackColor = true;
            this.btnRacas.Click += new System.EventHandler(this.btnRacas_Click);
            // 
            // btnAnimais
            // 
            this.btnAnimais.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAnimais.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAnimais.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAnimais.Location = new System.Drawing.Point(56, 205);
            this.btnAnimais.Name = "btnAnimais";
            this.btnAnimais.Size = new System.Drawing.Size(192, 46);
            this.btnAnimais.TabIndex = 1;
            this.btnAnimais.Text = "Animais";
            this.btnAnimais.UseVisualStyleBackColor = true;
            this.btnAnimais.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnClientes
            // 
            this.btnClientes.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClientes.Font = new System.Drawing.Font("Courier New", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClientes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.btnClientes.Location = new System.Drawing.Point(56, 143);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(192, 47);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Clientes";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // PanelCentral
            // 
            this.PanelCentral.BackColor = System.Drawing.Color.White;
            this.PanelCentral.BackgroundImage = global::Controle_c_.Properties.Resources._4ffaface5622100f56e41a6d4f8e7631eff815af;
            this.PanelCentral.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.PanelCentral.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelCentral.Location = new System.Drawing.Point(276, 43);
            this.PanelCentral.Name = "PanelCentral";
            this.PanelCentral.Size = new System.Drawing.Size(1191, 684);
            this.PanelCentral.TabIndex = 2;
            // 
            // masterDataSet
            // 
            this.masterDataSet.DataSetName = "masterDataSet";
            this.masterDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
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
            // tableAdapterManager
            // 
            this.tableAdapterManager.agendamento_servicosTableAdapter = null;
            this.tableAdapterManager.agendamentoTableAdapter = null;
            this.tableAdapterManager.animalTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.clienteTableAdapter = null;
            this.tableAdapterManager.Connection = null;
            this.tableAdapterManager.racaTableAdapter = null;
            this.tableAdapterManager.servicoTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Controle_c_.masterDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            // 
            // view_DetalhesAgendamentosBindingSource
            // 
            this.view_DetalhesAgendamentosBindingSource.DataMember = "View_DetalhesAgendamentos";
            this.view_DetalhesAgendamentosBindingSource.DataSource = this.masterDataSet;
            // 
            // view_DetalhesAgendamentosTableAdapter
            // 
            this.view_DetalhesAgendamentosTableAdapter.ClearBeforeFill = true;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 5000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1467, 727);
            this.Controls.Add(this.PanelCentral);
            this.Controls.Add(this.PanelLateral);
            this.Controls.Add(this.PanelTop);
            this.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(6, 5, 6, 5);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.PanelTop.ResumeLayout(false);
            this.PanelLateral.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.masterDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_ServicosAgendamentoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.view_DetalhesAgendamentosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PanelTop;
        private System.Windows.Forms.Panel PanelLateral;
        private System.Windows.Forms.Panel PanelCentral;
        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnAnimais;
        private System.Windows.Forms.Button btnAgendamentos;
        private System.Windows.Forms.Button btnServicos;
        private System.Windows.Forms.Button btnRacas;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnMaxi;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Button btnMax;
        private System.Windows.Forms.Panel panelSelecao;
        private System.Windows.Forms.GroupBox groupBox1;
        private masterDataSet masterDataSet;
        private System.Windows.Forms.BindingSource view_ServicosAgendamentoBindingSource;
        private masterDataSetTableAdapters.View_ServicosAgendamentoTableAdapter view_ServicosAgendamentoTableAdapter;
        private masterDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource view_DetalhesAgendamentosBindingSource;
        private masterDataSetTableAdapters.View_DetalhesAgendamentosTableAdapter view_DetalhesAgendamentosTableAdapter;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblAgandado;
        private System.Windows.Forms.Label lblAndamento;
        private System.Windows.Forms.Button button1;
    }
}

