namespace SistemaTHR.Apllication.Manutencao
{
    partial class frmFiltroMovimentacoesPeca
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFiltroMovimentacoesPeca));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.txtBuscarPor = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnNumeroMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroRequisicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricaoPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAondeSeraUsada = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioAutorizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraAutorizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.txtBuscarPor);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboCampo);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(556, 83);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // txtBuscarPor
            // 
            this.txtBuscarPor.Location = new System.Drawing.Point(76, 49);
            this.txtBuscarPor.Name = "txtBuscarPor";
            this.txtBuscarPor.Size = new System.Drawing.Size(437, 20);
            this.txtBuscarPor.TabIndex = 3;
            this.txtBuscarPor.TextChanged += new System.EventHandler(this.txtBuscarPor_TextChanged);
            this.txtBuscarPor.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtBuscarPor_KeyDown);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Buscar por:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Campo:";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Items.AddRange(new object[] {
            "CÓDIGO",
            "DESCRIÇÃO",
            "UNIDADE",
            "QUANTIDADE",
            "AONDE SERÁ USADO",
            "STATUS"});
            this.cboCampo.Location = new System.Drawing.Point(76, 19);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(223, 21);
            this.cboCampo.TabIndex = 0;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumeroMovimento,
            this.clnNumeroRequisicao,
            this.clnCodigoPeca,
            this.clnDescricaoPeca,
            this.clnUnidade,
            this.clnQuantidade,
            this.clnAondeSeraUsada,
            this.clnTipoMovimentacao,
            this.clnStatus,
            this.clnUsuarioSolicitacao,
            this.clnDataHoraSolicitacao,
            this.clnUsuarioAutorizacao,
            this.clnDataHoraAutorizacao,
            this.clnUsuarioMovimentacao,
            this.clnDataHoraMovimentacao});
            this.dataGridView1.Location = new System.Drawing.Point(12, 111);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(751, 241);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // clnNumeroMovimento
            // 
            this.clnNumeroMovimento.DataPropertyName = "NMovimentacao";
            this.clnNumeroMovimento.HeaderText = "ID";
            this.clnNumeroMovimento.Name = "clnNumeroMovimento";
            this.clnNumeroMovimento.ReadOnly = true;
            this.clnNumeroMovimento.Visible = false;
            // 
            // clnNumeroRequisicao
            // 
            this.clnNumeroRequisicao.DataPropertyName = "NRequisicao";
            this.clnNumeroRequisicao.HeaderText = "Requisição";
            this.clnNumeroRequisicao.Name = "clnNumeroRequisicao";
            this.clnNumeroRequisicao.ReadOnly = true;
            this.clnNumeroRequisicao.Width = 70;
            // 
            // clnCodigoPeca
            // 
            this.clnCodigoPeca.DataPropertyName = "CodigoPeca";
            this.clnCodigoPeca.HeaderText = "Código";
            this.clnCodigoPeca.Name = "clnCodigoPeca";
            this.clnCodigoPeca.ReadOnly = true;
            this.clnCodigoPeca.Width = 80;
            // 
            // clnDescricaoPeca
            // 
            this.clnDescricaoPeca.DataPropertyName = "DescricaoPeca";
            this.clnDescricaoPeca.HeaderText = "Descrição";
            this.clnDescricaoPeca.Name = "clnDescricaoPeca";
            this.clnDescricaoPeca.ReadOnly = true;
            this.clnDescricaoPeca.Width = 200;
            // 
            // clnUnidade
            // 
            this.clnUnidade.DataPropertyName = "Unidade";
            this.clnUnidade.HeaderText = "Unidade";
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            this.clnUnidade.Width = 80;
            // 
            // clnQuantidade
            // 
            this.clnQuantidade.DataPropertyName = "Qtd";
            this.clnQuantidade.HeaderText = "QT.";
            this.clnQuantidade.Name = "clnQuantidade";
            this.clnQuantidade.ReadOnly = true;
            this.clnQuantidade.Width = 50;
            // 
            // clnAondeSeraUsada
            // 
            this.clnAondeSeraUsada.DataPropertyName = "Asu";
            this.clnAondeSeraUsada.HeaderText = "A.S.U";
            this.clnAondeSeraUsada.Name = "clnAondeSeraUsada";
            this.clnAondeSeraUsada.ReadOnly = true;
            // 
            // clnTipoMovimentacao
            // 
            this.clnTipoMovimentacao.DataPropertyName = "TipoMovimentacao";
            this.clnTipoMovimentacao.HeaderText = "Movim.";
            this.clnTipoMovimentacao.Name = "clnTipoMovimentacao";
            this.clnTipoMovimentacao.ReadOnly = true;
            this.clnTipoMovimentacao.Visible = false;
            // 
            // clnStatus
            // 
            this.clnStatus.DataPropertyName = "Status";
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            // 
            // clnUsuarioSolicitacao
            // 
            this.clnUsuarioSolicitacao.DataPropertyName = "UsuarioSolicitacao";
            this.clnUsuarioSolicitacao.HeaderText = "Usuário/Solic.";
            this.clnUsuarioSolicitacao.Name = "clnUsuarioSolicitacao";
            this.clnUsuarioSolicitacao.ReadOnly = true;
            this.clnUsuarioSolicitacao.Visible = false;
            // 
            // clnDataHoraSolicitacao
            // 
            this.clnDataHoraSolicitacao.DataPropertyName = "DataHoraSolicitacao";
            this.clnDataHoraSolicitacao.HeaderText = "Data/Hora Solic.";
            this.clnDataHoraSolicitacao.Name = "clnDataHoraSolicitacao";
            this.clnDataHoraSolicitacao.ReadOnly = true;
            this.clnDataHoraSolicitacao.Visible = false;
            // 
            // clnUsuarioAutorizacao
            // 
            this.clnUsuarioAutorizacao.DataPropertyName = "UsuarioAutorizacao";
            this.clnUsuarioAutorizacao.HeaderText = "Usuário/Aut.";
            this.clnUsuarioAutorizacao.Name = "clnUsuarioAutorizacao";
            this.clnUsuarioAutorizacao.ReadOnly = true;
            this.clnUsuarioAutorizacao.Visible = false;
            // 
            // clnDataHoraAutorizacao
            // 
            this.clnDataHoraAutorizacao.DataPropertyName = "DataHoraAutorizacao";
            this.clnDataHoraAutorizacao.HeaderText = "Data/Hora Aut.";
            this.clnDataHoraAutorizacao.Name = "clnDataHoraAutorizacao";
            this.clnDataHoraAutorizacao.ReadOnly = true;
            this.clnDataHoraAutorizacao.Visible = false;
            // 
            // clnUsuarioMovimentacao
            // 
            this.clnUsuarioMovimentacao.DataPropertyName = "UsuarioMovimentacao";
            this.clnUsuarioMovimentacao.HeaderText = "Usuário/Mov.";
            this.clnUsuarioMovimentacao.Name = "clnUsuarioMovimentacao";
            this.clnUsuarioMovimentacao.ReadOnly = true;
            this.clnUsuarioMovimentacao.Visible = false;
            // 
            // clnDataHoraMovimentacao
            // 
            this.clnDataHoraMovimentacao.DataPropertyName = "DataHoraMovimentacao";
            this.clnDataHoraMovimentacao.HeaderText = "Data/Hora Mov.";
            this.clnDataHoraMovimentacao.Name = "clnDataHoraMovimentacao";
            this.clnDataHoraMovimentacao.ReadOnly = true;
            this.clnDataHoraMovimentacao.Visible = false;
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(12, 376);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 2;
            this.btnCarregar.Text = "Filtrar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(688, 376);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // frmFiltroMovimentacoesPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(776, 420);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFiltroMovimentacoesPeca";
            this.Text = "frmFiltroMovimentacoesPeca";
            this.Load += new System.EventHandler(this.frmFiltroMovimentacoesPeca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtBuscarPor;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroMovimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroRequisicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricaoPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAondeSeraUsada;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioAutorizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraAutorizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraMovimentacao;
    }
}