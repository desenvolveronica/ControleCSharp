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
            this.PanelTop = new System.Windows.Forms.Panel();
            this.btnMax = new System.Windows.Forms.Button();
            this.btnMaxi = new System.Windows.Forms.Button();
            this.btnSair = new System.Windows.Forms.Button();
            this.PanelLateral = new System.Windows.Forms.Panel();
            this.panelSelecao = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.btnAgendamentos = new System.Windows.Forms.Button();
            this.btnServicos = new System.Windows.Forms.Button();
            this.btnRacas = new System.Windows.Forms.Button();
            this.btnAnimais = new System.Windows.Forms.Button();
            this.btnClientes = new System.Windows.Forms.Button();
            this.PanelCentral = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.PanelTop.SuspendLayout();
            this.PanelLateral.SuspendLayout();
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
            // groupBox1
            // 
            this.groupBox1.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.White;
            this.groupBox1.Location = new System.Drawing.Point(56, 466);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(192, 113);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Agendamentos";
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
            this.PanelTop.ResumeLayout(false);
            this.PanelLateral.ResumeLayout(false);
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
    }
}

