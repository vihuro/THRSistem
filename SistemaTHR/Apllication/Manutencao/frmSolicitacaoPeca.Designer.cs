namespace SistemaTHR.Apllication
{
    partial class frmSolicitacaoPeca
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSolicitacaoPeca));
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.btnAutorizar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnGravar = new System.Windows.Forms.Button();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnAdicionar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnComprar = new System.Windows.Forms.Button();
            this.btnComprado = new System.Windows.Forms.Button();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeSolicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatusSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNomeAutorizador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraAutorizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioSolicitacaoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraSolicitacaoCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraCompraRealizada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1418, 101);
            this.panel1.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigo,
            this.clnDescricao,
            this.clnQuantidade,
            this.clnUnidade,
            this.clnNomeSolicitante,
            this.clnDataHoraSolicitacao,
            this.clnStatusSolicitacao,
            this.clnNomeAutorizador,
            this.clnDataHoraAutorizacao,
            this.clnUsuarioSolicitacaoCompra,
            this.clnDataHoraSolicitacaoCompra,
            this.clnDataHoraCompraRealizada});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1418, 101);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.statusStrip1.Location = new System.Drawing.Point(0, 427);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1422, 20);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 15);
            this.toolStripStatusLabel1.Text = "Usuário";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 0);
            // 
            // splitContainer1
            // 
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.btnComprado);
            this.splitContainer1.Panel2.Controls.Add(this.btnComprar);
            this.splitContainer1.Panel2.Controls.Add(this.btnAutorizar);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnGravar);
            this.splitContainer1.Panel2.Controls.Add(this.btnRemover);
            this.splitContainer1.Panel2.Controls.Add(this.btnAdicionar);
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1422, 402);
            this.splitContainer1.SplitterDistance = 105;
            this.splitContainer1.TabIndex = 20;
            this.splitContainer1.SplitterMoved += new System.Windows.Forms.SplitterEventHandler(this.splitContainer1_SplitterMoved);
            // 
            // btnAutorizar
            // 
            this.btnAutorizar.Location = new System.Drawing.Point(770, 260);
            this.btnAutorizar.Name = "btnAutorizar";
            this.btnAutorizar.Size = new System.Drawing.Size(75, 23);
            this.btnAutorizar.TabIndex = 6;
            this.btnAutorizar.Text = "Autorizar";
            this.btnAutorizar.UseVisualStyleBackColor = true;
            this.btnAutorizar.Click += new System.EventHandler(this.btnAutorizar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(976, 260);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 8;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnGravar
            // 
            this.btnGravar.Location = new System.Drawing.Point(881, 260);
            this.btnGravar.Name = "btnGravar";
            this.btnGravar.Size = new System.Drawing.Size(75, 23);
            this.btnGravar.TabIndex = 7;
            this.btnGravar.Text = "Gravar";
            this.btnGravar.UseVisualStyleBackColor = true;
            this.btnGravar.Click += new System.EventHandler(this.btnGravar_Click);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(779, 147);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 5;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnAdicionar
            // 
            this.btnAdicionar.Location = new System.Drawing.Point(684, 147);
            this.btnAdicionar.Name = "btnAdicionar";
            this.btnAdicionar.Size = new System.Drawing.Size(75, 23);
            this.btnAdicionar.TabIndex = 4;
            this.btnAdicionar.Text = "Adicionar";
            this.btnAdicionar.UseVisualStyleBackColor = true;
            this.btnAdicionar.Click += new System.EventHandler(this.btnAdicionar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtQuantidade);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtUnidade);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(10, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(856, 184);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Requisição";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(769, 65);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(69, 20);
            this.txtQuantidade.TabIndex = 3;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(20, 65);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Código:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(173, 65);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(465, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Descrição:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(769, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Quantidade:";
            // 
            // txtUnidade
            // 
            this.txtUnidade.Location = new System.Drawing.Point(674, 65);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(69, 20);
            this.txtUnidade.TabIndex = 2;
            this.txtUnidade.TextChanged += new System.EventHandler(this.txtUnidade_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(674, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(50, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Unidade:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnLimpar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1422, 25);
            this.panel2.TabIndex = 18;
            // 
            // btnLimpar
            // 
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Image = global::SistemaTHR.Properties.Resources.mais;
            this.btnLimpar.Location = new System.Drawing.Point(0, 0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(28, 25);
            this.btnLimpar.TabIndex = 1;
            this.btnLimpar.Text = "button1";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // btnComprar
            // 
            this.btnComprar.Enabled = false;
            this.btnComprar.Location = new System.Drawing.Point(881, 147);
            this.btnComprar.Name = "btnComprar";
            this.btnComprar.Size = new System.Drawing.Size(75, 23);
            this.btnComprar.TabIndex = 9;
            this.btnComprar.Text = "Comprar";
            this.btnComprar.UseVisualStyleBackColor = true;
            this.btnComprar.Click += new System.EventHandler(this.btnComprar_Click);
            // 
            // btnComprado
            // 
            this.btnComprado.Enabled = false;
            this.btnComprado.Location = new System.Drawing.Point(881, 185);
            this.btnComprado.Name = "btnComprado";
            this.btnComprado.Size = new System.Drawing.Size(75, 23);
            this.btnComprado.TabIndex = 10;
            this.btnComprado.Text = "Comprado";
            this.btnComprado.UseVisualStyleBackColor = true;
            // 
            // clnCodigo
            // 
            this.clnCodigo.DataPropertyName = "CodigoPeca";
            this.clnCodigo.HeaderText = "Código/Peça";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            // 
            // clnDescricao
            // 
            this.clnDescricao.DataPropertyName = "DescricaoPeca";
            this.clnDescricao.HeaderText = "Descrição/Peça";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 230;
            // 
            // clnQuantidade
            // 
            this.clnQuantidade.DataPropertyName = "Qtd";
            this.clnQuantidade.HeaderText = "QTD";
            this.clnQuantidade.Name = "clnQuantidade";
            this.clnQuantidade.ReadOnly = true;
            this.clnQuantidade.Width = 70;
            // 
            // clnUnidade
            // 
            this.clnUnidade.DataPropertyName = "Unidade";
            this.clnUnidade.HeaderText = "UND";
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            this.clnUnidade.Width = 70;
            // 
            // clnNomeSolicitante
            // 
            this.clnNomeSolicitante.DataPropertyName = "NomeSolicitante";
            this.clnNomeSolicitante.HeaderText = "Nome/Solicitante";
            this.clnNomeSolicitante.Name = "clnNomeSolicitante";
            this.clnNomeSolicitante.ReadOnly = true;
            // 
            // clnDataHoraSolicitacao
            // 
            this.clnDataHoraSolicitacao.DataPropertyName = "DataHoraSolicitacao";
            this.clnDataHoraSolicitacao.HeaderText = "Data/Hora Solicitação";
            this.clnDataHoraSolicitacao.Name = "clnDataHoraSolicitacao";
            this.clnDataHoraSolicitacao.ReadOnly = true;
            // 
            // clnStatusSolicitacao
            // 
            this.clnStatusSolicitacao.DataPropertyName = "StatusSolicitacao";
            this.clnStatusSolicitacao.HeaderText = "Status/Solicitação";
            this.clnStatusSolicitacao.Name = "clnStatusSolicitacao";
            this.clnStatusSolicitacao.ReadOnly = true;
            this.clnStatusSolicitacao.Width = 150;
            // 
            // clnNomeAutorizador
            // 
            this.clnNomeAutorizador.DataPropertyName = "NomeAutorizador";
            this.clnNomeAutorizador.HeaderText = "Nome/Autorizador";
            this.clnNomeAutorizador.Name = "clnNomeAutorizador";
            this.clnNomeAutorizador.ReadOnly = true;
            // 
            // clnDataHoraAutorizacao
            // 
            this.clnDataHoraAutorizacao.DataPropertyName = "DataHoraAutorizacao";
            this.clnDataHoraAutorizacao.HeaderText = "Data/Hora Autorizacao";
            this.clnDataHoraAutorizacao.Name = "clnDataHoraAutorizacao";
            this.clnDataHoraAutorizacao.ReadOnly = true;
            // 
            // clnUsuarioSolicitacaoCompra
            // 
            this.clnUsuarioSolicitacaoCompra.DataPropertyName = "dataHoraSolicitacaoCompra";
            this.clnUsuarioSolicitacaoCompra.HeaderText = "Usuario/Solic/Compr.";
            this.clnUsuarioSolicitacaoCompra.Name = "clnUsuarioSolicitacaoCompra";
            this.clnUsuarioSolicitacaoCompra.ReadOnly = true;
            // 
            // clnDataHoraSolicitacaoCompra
            // 
            this.clnDataHoraSolicitacaoCompra.DataPropertyName = "DataHoraSolicitacaoCompra";
            this.clnDataHoraSolicitacaoCompra.HeaderText = "Data/Hora Solic/Compr.";
            this.clnDataHoraSolicitacaoCompra.Name = "clnDataHoraSolicitacaoCompra";
            this.clnDataHoraSolicitacaoCompra.ReadOnly = true;
            this.clnDataHoraSolicitacaoCompra.Width = 200;
            // 
            // clnDataHoraCompraRealizada
            // 
            this.clnDataHoraCompraRealizada.DataPropertyName = "DataHoraCompraRealizada";
            this.clnDataHoraCompraRealizada.HeaderText = "DataHora/Compr. Rel";
            this.clnDataHoraCompraRealizada.Name = "clnDataHoraCompraRealizada";
            this.clnDataHoraCompraRealizada.ReadOnly = true;
            this.clnDataHoraCompraRealizada.Width = 200;
            // 
            // frmSolicitacaoPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1422, 447);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSolicitacaoPeca";
            this.Text = "Solicitação de peça";
            this.Load += new System.EventHandler(this.frmSolicitacaoPeca_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.StatusStrip statusStrip1;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnGravar;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.Button btnAdicionar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUnidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnAutorizar;
        private System.Windows.Forms.Button btnComprado;
        private System.Windows.Forms.Button btnComprar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeSolicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatusSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNomeAutorizador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraAutorizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioSolicitacaoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraSolicitacaoCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraCompraRealizada;
    }
}