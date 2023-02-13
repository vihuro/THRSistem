namespace SistemaTHR.Apllication.Manutencao
{
    partial class frmConversaoEstoquePecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmConversaoEstoquePecas));
            this.dataGridRadar = new System.Windows.Forms.DataGridView();
            this.clnCodigoTxt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridThr = new System.Windows.Forms.DataGridView();
            this.clnNPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricaoPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidadePeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnQuantidadeEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstoqueMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstoqueMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFornecedor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoFornecedor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFornecedor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoFornecedor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFornecedor3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoFornecedor3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioGravacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraGravacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.btnIniciar = new System.Windows.Forms.Button();
            this.lblQuantidadeLinhas = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnVerificar = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRadar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThr)).BeginInit();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridRadar
            // 
            this.dataGridRadar.AllowUserToAddRows = false;
            this.dataGridRadar.AllowUserToDeleteRows = false;
            this.dataGridRadar.AllowUserToOrderColumns = true;
            this.dataGridRadar.AllowUserToResizeRows = false;
            this.dataGridRadar.BackgroundColor = System.Drawing.Color.White;
            this.dataGridRadar.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridRadar.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridRadar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridRadar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigoTxt,
            this.clnDescricao,
            this.clnUnidade});
            this.dataGridRadar.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridRadar.EnableHeadersVisualStyles = false;
            this.dataGridRadar.GridColor = System.Drawing.Color.White;
            this.dataGridRadar.Location = new System.Drawing.Point(0, 24);
            this.dataGridRadar.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridRadar.MultiSelect = false;
            this.dataGridRadar.Name = "dataGridRadar";
            this.dataGridRadar.ReadOnly = true;
            this.dataGridRadar.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridRadar.RowHeadersVisible = false;
            this.dataGridRadar.RowTemplate.Height = 24;
            this.dataGridRadar.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridRadar.Size = new System.Drawing.Size(513, 262);
            this.dataGridRadar.TabIndex = 0;
            // 
            // clnCodigoTxt
            // 
            this.clnCodigoTxt.DataPropertyName = "Código";
            this.clnCodigoTxt.HeaderText = "Código";
            this.clnCodigoTxt.Name = "clnCodigoTxt";
            this.clnCodigoTxt.ReadOnly = true;
            // 
            // clnDescricao
            // 
            this.clnDescricao.DataPropertyName = "Nome Produto";
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 300;
            // 
            // clnUnidade
            // 
            this.clnUnidade.DataPropertyName = "Un.";
            this.clnUnidade.HeaderText = "Unidade";
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.splitContainer2);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.btnIniciar);
            this.splitContainer1.Panel2.Controls.Add(this.lblQuantidadeLinhas);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.btnVerificar);
            this.splitContainer1.Size = new System.Drawing.Size(1024, 572);
            this.splitContainer1.SplitterDistance = 286;
            this.splitContainer1.SplitterWidth = 3;
            this.splitContainer1.TabIndex = 1;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Margin = new System.Windows.Forms.Padding(2);
            this.splitContainer2.Name = "splitContainer2";
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridRadar);
            this.splitContainer2.Panel1.Controls.Add(this.panel1);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridThr);
            this.splitContainer2.Panel2.Controls.Add(this.panel3);
            this.splitContainer2.Size = new System.Drawing.Size(1024, 286);
            this.splitContainer2.SplitterDistance = 513;
            this.splitContainer2.SplitterWidth = 3;
            this.splitContainer2.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(513, 24);
            this.panel1.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 6);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Estoque Radar";
            // 
            // dataGridThr
            // 
            this.dataGridThr.AllowUserToAddRows = false;
            this.dataGridThr.AllowUserToDeleteRows = false;
            this.dataGridThr.AllowUserToResizeRows = false;
            this.dataGridThr.BackgroundColor = System.Drawing.Color.White;
            this.dataGridThr.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridThr.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridThr.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridThr.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNPeca,
            this.clnCodigoPeca,
            this.clnDescricaoPeca,
            this.clnUnidadePeca,
            this.ClnQuantidadeEstoque,
            this.clnEstoqueMaximo,
            this.clnEstoqueMinimo,
            this.clnFornecedor1,
            this.clnCodigoFornecedor1,
            this.clnFornecedor2,
            this.clnCodigoFornecedor2,
            this.clnFornecedor3,
            this.clnCodigoFornecedor3,
            this.clnUsuarioGravacao,
            this.clnDataHoraGravacao});
            this.dataGridThr.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridThr.EnableHeadersVisualStyles = false;
            this.dataGridThr.Location = new System.Drawing.Point(0, 24);
            this.dataGridThr.Margin = new System.Windows.Forms.Padding(2);
            this.dataGridThr.MultiSelect = false;
            this.dataGridThr.Name = "dataGridThr";
            this.dataGridThr.ReadOnly = true;
            this.dataGridThr.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridThr.RowHeadersVisible = false;
            this.dataGridThr.RowTemplate.Height = 24;
            this.dataGridThr.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridThr.Size = new System.Drawing.Size(508, 262);
            this.dataGridThr.TabIndex = 1;
            // 
            // clnNPeca
            // 
            this.clnNPeca.DataPropertyName = "NPeca";
            this.clnNPeca.HeaderText = "Nº Peça";
            this.clnNPeca.Name = "clnNPeca";
            this.clnNPeca.ReadOnly = true;
            this.clnNPeca.Visible = false;
            // 
            // clnCodigoPeca
            // 
            this.clnCodigoPeca.DataPropertyName = "Codigo";
            this.clnCodigoPeca.HeaderText = "Código";
            this.clnCodigoPeca.Name = "clnCodigoPeca";
            this.clnCodigoPeca.ReadOnly = true;
            // 
            // clnDescricaoPeca
            // 
            this.clnDescricaoPeca.DataPropertyName = "Descricao";
            this.clnDescricaoPeca.HeaderText = "Descrição";
            this.clnDescricaoPeca.Name = "clnDescricaoPeca";
            this.clnDescricaoPeca.ReadOnly = true;
            this.clnDescricaoPeca.Width = 300;
            // 
            // clnUnidadePeca
            // 
            this.clnUnidadePeca.DataPropertyName = "Unidade";
            this.clnUnidadePeca.HeaderText = "Unidade";
            this.clnUnidadePeca.Name = "clnUnidadePeca";
            this.clnUnidadePeca.ReadOnly = true;
            // 
            // ClnQuantidadeEstoque
            // 
            this.ClnQuantidadeEstoque.DataPropertyName = "QtEstoque";
            this.ClnQuantidadeEstoque.HeaderText = "Quantidade/Estoque";
            this.ClnQuantidadeEstoque.Name = "ClnQuantidadeEstoque";
            this.ClnQuantidadeEstoque.ReadOnly = true;
            this.ClnQuantidadeEstoque.Visible = false;
            // 
            // clnEstoqueMaximo
            // 
            this.clnEstoqueMaximo.DataPropertyName = "EstoqueMax";
            this.clnEstoqueMaximo.HeaderText = "Estoque/Maximo";
            this.clnEstoqueMaximo.Name = "clnEstoqueMaximo";
            this.clnEstoqueMaximo.ReadOnly = true;
            this.clnEstoqueMaximo.Visible = false;
            // 
            // clnEstoqueMinimo
            // 
            this.clnEstoqueMinimo.DataPropertyName = "EstoqueMin";
            this.clnEstoqueMinimo.HeaderText = "EstoqueMinimo";
            this.clnEstoqueMinimo.Name = "clnEstoqueMinimo";
            this.clnEstoqueMinimo.ReadOnly = true;
            this.clnEstoqueMinimo.Visible = false;
            // 
            // clnFornecedor1
            // 
            this.clnFornecedor1.DataPropertyName = "Fornecedor1";
            this.clnFornecedor1.HeaderText = "Fornecedor - 1";
            this.clnFornecedor1.Name = "clnFornecedor1";
            this.clnFornecedor1.ReadOnly = true;
            this.clnFornecedor1.Visible = false;
            // 
            // clnCodigoFornecedor1
            // 
            this.clnCodigoFornecedor1.DataPropertyName = "CodigoFornecedor1";
            this.clnCodigoFornecedor1.HeaderText = "Codigo/Fornecedor -1";
            this.clnCodigoFornecedor1.Name = "clnCodigoFornecedor1";
            this.clnCodigoFornecedor1.ReadOnly = true;
            this.clnCodigoFornecedor1.Visible = false;
            // 
            // clnFornecedor2
            // 
            this.clnFornecedor2.DataPropertyName = "Fornecedor2";
            this.clnFornecedor2.HeaderText = "Fornecedor - 2";
            this.clnFornecedor2.Name = "clnFornecedor2";
            this.clnFornecedor2.ReadOnly = true;
            this.clnFornecedor2.Visible = false;
            // 
            // clnCodigoFornecedor2
            // 
            this.clnCodigoFornecedor2.DataPropertyName = "CodigoFornecedor2";
            this.clnCodigoFornecedor2.HeaderText = "Código/Fornecedor - 2";
            this.clnCodigoFornecedor2.Name = "clnCodigoFornecedor2";
            this.clnCodigoFornecedor2.ReadOnly = true;
            this.clnCodigoFornecedor2.Visible = false;
            // 
            // clnFornecedor3
            // 
            this.clnFornecedor3.DataPropertyName = "Fornecedor3";
            this.clnFornecedor3.HeaderText = "Fornecedor - 3";
            this.clnFornecedor3.Name = "clnFornecedor3";
            this.clnFornecedor3.ReadOnly = true;
            this.clnFornecedor3.Visible = false;
            // 
            // clnCodigoFornecedor3
            // 
            this.clnCodigoFornecedor3.DataPropertyName = "CodigoFornecedor3";
            this.clnCodigoFornecedor3.HeaderText = "Codigo/Fornecedor - 3";
            this.clnCodigoFornecedor3.Name = "clnCodigoFornecedor3";
            this.clnCodigoFornecedor3.ReadOnly = true;
            this.clnCodigoFornecedor3.Visible = false;
            // 
            // clnUsuarioGravacao
            // 
            this.clnUsuarioGravacao.DataPropertyName = "UsuarioGravacao";
            this.clnUsuarioGravacao.HeaderText = "Usuário/Gravação";
            this.clnUsuarioGravacao.Name = "clnUsuarioGravacao";
            this.clnUsuarioGravacao.ReadOnly = true;
            this.clnUsuarioGravacao.Visible = false;
            // 
            // clnDataHoraGravacao
            // 
            this.clnDataHoraGravacao.DataPropertyName = "DataHoraGravacao";
            this.clnDataHoraGravacao.HeaderText = "Data/Hora Gravação";
            this.clnDataHoraGravacao.Name = "clnDataHoraGravacao";
            this.clnDataHoraGravacao.ReadOnly = true;
            this.clnDataHoraGravacao.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Margin = new System.Windows.Forms.Padding(2);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(508, 24);
            this.panel3.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 6);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 13);
            this.label2.TabIndex = 0;
            this.label2.Text = "Estoque THR";
            // 
            // btnIniciar
            // 
            this.btnIniciar.Location = new System.Drawing.Point(12, 64);
            this.btnIniciar.Margin = new System.Windows.Forms.Padding(2);
            this.btnIniciar.Name = "btnIniciar";
            this.btnIniciar.Size = new System.Drawing.Size(125, 27);
            this.btnIniciar.TabIndex = 3;
            this.btnIniciar.Text = "Iniciar modificação";
            this.btnIniciar.UseVisualStyleBackColor = true;
            this.btnIniciar.Click += new System.EventHandler(this.btnIniciar_Click);
            // 
            // lblQuantidadeLinhas
            // 
            this.lblQuantidadeLinhas.AutoSize = true;
            this.lblQuantidadeLinhas.Location = new System.Drawing.Point(213, 24);
            this.lblQuantidadeLinhas.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.lblQuantidadeLinhas.Name = "lblQuantidadeLinhas";
            this.lblQuantidadeLinhas.Size = new System.Drawing.Size(13, 13);
            this.lblQuantidadeLinhas.TabIndex = 2;
            this.lblQuantidadeLinhas.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 24);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(209, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Quantidade de linhas a serem modificadas:";
            // 
            // btnVerificar
            // 
            this.btnVerificar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnVerificar.Location = new System.Drawing.Point(860, 217);
            this.btnVerificar.Margin = new System.Windows.Forms.Padding(2);
            this.btnVerificar.Name = "btnVerificar";
            this.btnVerificar.Size = new System.Drawing.Size(153, 27);
            this.btnVerificar.TabIndex = 0;
            this.btnVerificar.Text = "Verificar novos produtos";
            this.btnVerificar.UseVisualStyleBackColor = true;
            this.btnVerificar.Click += new System.EventHandler(this.btnVerificar_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnAtualizar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1024, 28);
            this.panel2.TabIndex = 3;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 578);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 10, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1024, 22);
            this.statusStrip1.TabIndex = 4;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(50, 17);
            this.toolStripStatusLabel1.Text = "Usuário:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAtualizar.FlatAppearance.BorderSize = 0;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.Image = global::SistemaTHR.Properties.Resources.refresh_button;
            this.btnAtualizar.Location = new System.Drawing.Point(0, 0);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(33, 28);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // frmConversaoEstoquePecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1024, 600);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "frmConversaoEstoquePecas";
            this.Text = "Conversão";
            this.Load += new System.EventHandler(this.frmConversaoArquivoTxt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridRadar)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridThr)).EndInit();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridRadar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoTxt;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidade;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridThr;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnIniciar;
        private System.Windows.Forms.Label lblQuantidadeLinhas;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnVerificar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricaoPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidadePeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnQuantidadeEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstoqueMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstoqueMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFornecedor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoFornecedor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFornecedor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoFornecedor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFornecedor3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoFornecedor3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioGravacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraGravacao;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Button btnAtualizar;
    }
}