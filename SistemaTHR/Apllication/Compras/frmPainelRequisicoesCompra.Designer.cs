namespace SistemaTHR.Apllication.Compras
{
    partial class frmPainelRequisicoesCompra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPainelRequisicoesCompra));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnPlay = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clnNumeroRequisicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataEsperadaEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnValor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFreteIncluso = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFrete = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstadoDaCompra = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioSolicitante = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioAutorizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraAutorizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(0, 5, 0, 5);
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumeroRequisicao,
            this.clnCodigoPeca,
            this.clnDescricao,
            this.clnQuantidade,
            this.clnUnidade,
            this.clnPrioridade,
            this.clnDataEsperadaEntrega,
            this.clnValor,
            this.clnFreteIncluso,
            this.clnFornecedor,
            this.clnStatus,
            this.clnFrete,
            this.clnEstadoDaCompra,
            this.clnUsuarioSolicitante,
            this.clnDataHoraSolicitacao,
            this.clnUsuarioAutorizacao,
            this.clnDataHoraAutorizacao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(37, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1225, 825);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel1.Controls.Add(this.btnPause);
            this.panel1.Controls.Add(this.btnPlay);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(37, 825);
            this.panel1.TabIndex = 1;
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = global::SistemaTHR.Properties.Resources.play_button;
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(37, 36);
            this.btnPlay.TabIndex = 0;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // btnPause
            // 
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = global::SistemaTHR.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(0, 36);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(37, 36);
            this.btnPause.TabIndex = 1;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clnNumeroRequisicao
            // 
            this.clnNumeroRequisicao.DataPropertyName = "NRequisicaoCompra";
            this.clnNumeroRequisicao.HeaderText = "Nº";
            this.clnNumeroRequisicao.Name = "clnNumeroRequisicao";
            this.clnNumeroRequisicao.ReadOnly = true;
            this.clnNumeroRequisicao.Width = 70;
            // 
            // clnCodigoPeca
            // 
            this.clnCodigoPeca.DataPropertyName = "Codigo";
            this.clnCodigoPeca.HeaderText = "Código";
            this.clnCodigoPeca.Name = "clnCodigoPeca";
            this.clnCodigoPeca.ReadOnly = true;
            // 
            // clnDescricao
            // 
            this.clnDescricao.DataPropertyName = "Descricao";
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Visible = false;
            // 
            // clnQuantidade
            // 
            this.clnQuantidade.DataPropertyName = "Quantidade";
            this.clnQuantidade.HeaderText = "QTD.";
            this.clnQuantidade.Name = "clnQuantidade";
            this.clnQuantidade.ReadOnly = true;
            this.clnQuantidade.Width = 70;
            // 
            // clnUnidade
            // 
            this.clnUnidade.DataPropertyName = "Unidade";
            this.clnUnidade.HeaderText = "Un.";
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            this.clnUnidade.Width = 70;
            // 
            // clnPrioridade
            // 
            this.clnPrioridade.DataPropertyName = "Prioridade";
            this.clnPrioridade.HeaderText = "Prior.";
            this.clnPrioridade.Name = "clnPrioridade";
            this.clnPrioridade.ReadOnly = true;
            this.clnPrioridade.Width = 80;
            // 
            // clnDataEsperadaEntrega
            // 
            this.clnDataEsperadaEntrega.DataPropertyName = "DataEsperadaEntrega";
            this.clnDataEsperadaEntrega.HeaderText = "Data/ Esper.";
            this.clnDataEsperadaEntrega.Name = "clnDataEsperadaEntrega";
            this.clnDataEsperadaEntrega.ReadOnly = true;
            // 
            // clnValor
            // 
            this.clnValor.DataPropertyName = "Valor";
            this.clnValor.HeaderText = "Valor";
            this.clnValor.Name = "clnValor";
            this.clnValor.ReadOnly = true;
            this.clnValor.Visible = false;
            // 
            // clnFreteIncluso
            // 
            this.clnFreteIncluso.DataPropertyName = "FreteIncluso";
            this.clnFreteIncluso.HeaderText = "Frete/Incluso";
            this.clnFreteIncluso.Name = "clnFreteIncluso";
            this.clnFreteIncluso.ReadOnly = true;
            this.clnFreteIncluso.Visible = false;
            // 
            // clnFornecedor
            // 
            this.clnFornecedor.DataPropertyName = "Fornecedor";
            this.clnFornecedor.HeaderText = "Forn.";
            this.clnFornecedor.Name = "clnFornecedor";
            this.clnFornecedor.ReadOnly = true;
            this.clnFornecedor.Visible = false;
            // 
            // clnStatus
            // 
            this.clnStatus.DataPropertyName = "Status";
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            // 
            // clnFrete
            // 
            this.clnFrete.DataPropertyName = "Frete";
            this.clnFrete.HeaderText = "Frete";
            this.clnFrete.Name = "clnFrete";
            this.clnFrete.ReadOnly = true;
            this.clnFrete.Visible = false;
            // 
            // clnEstadoDaCompra
            // 
            this.clnEstadoDaCompra.DataPropertyName = "EstadoDaCompra";
            this.clnEstadoDaCompra.HeaderText = "Est./ Compra";
            this.clnEstadoDaCompra.Name = "clnEstadoDaCompra";
            this.clnEstadoDaCompra.ReadOnly = true;
            // 
            // clnUsuarioSolicitante
            // 
            this.clnUsuarioSolicitante.DataPropertyName = "UsuarioSolicitante";
            this.clnUsuarioSolicitante.HeaderText = "Usuário/Solicitante";
            this.clnUsuarioSolicitante.Name = "clnUsuarioSolicitante";
            this.clnUsuarioSolicitante.ReadOnly = true;
            this.clnUsuarioSolicitante.Visible = false;
            // 
            // clnDataHoraSolicitacao
            // 
            this.clnDataHoraSolicitacao.DataPropertyName = "DataHoraSolicitacao";
            this.clnDataHoraSolicitacao.HeaderText = "Data/ Hora Soli.";
            this.clnDataHoraSolicitacao.Name = "clnDataHoraSolicitacao";
            this.clnDataHoraSolicitacao.ReadOnly = true;
            // 
            // clnUsuarioAutorizacao
            // 
            this.clnUsuarioAutorizacao.DataPropertyName = "UsuarioAutorizacao";
            this.clnUsuarioAutorizacao.HeaderText = "Usuário/Aut";
            this.clnUsuarioAutorizacao.Name = "clnUsuarioAutorizacao";
            this.clnUsuarioAutorizacao.ReadOnly = true;
            this.clnUsuarioAutorizacao.Visible = false;
            // 
            // clnDataHoraAutorizacao
            // 
            this.clnDataHoraAutorizacao.DataPropertyName = "DataHoraAutorizacao";
            this.clnDataHoraAutorizacao.HeaderText = "Data/ Hora Aut.";
            this.clnDataHoraAutorizacao.Name = "clnDataHoraAutorizacao";
            this.clnDataHoraAutorizacao.ReadOnly = true;
            // 
            // frmPainelRequisicoesCompra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1262, 825);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPainelRequisicoesCompra";
            this.Text = "Requisições de Compra";
            this.Load += new System.EventHandler(this.frmPainelRequisicoesCompra_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroRequisicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataEsperadaEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnValor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFreteIncluso;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFrete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstadoDaCompra;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioSolicitante;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioAutorizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraAutorizacao;
    }
}