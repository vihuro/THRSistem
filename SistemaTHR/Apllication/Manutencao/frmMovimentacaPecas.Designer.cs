namespace SistemaTHR.Apllication.Manutencao
{
    partial class frmMovimentacaPecas
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMovimentacaPecas));
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnNMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNRequisicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAsu = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioAutorizador = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraAutorizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboUnidade = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtDescriao = new System.Windows.Forms.TextBox();
            this.btnEntrada = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnFiltro);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(975, 24);
            this.panel1.TabIndex = 0;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 521);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(975, 22);
            this.statusStrip1.TabIndex = 1;
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
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 24);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(975, 497);
            this.splitContainer1.SplitterDistance = 141;
            this.splitContainer1.TabIndex = 2;
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
            this.clnNMovimentacao,
            this.clnNRequisicao,
            this.clnCodigoPeca,
            this.clnDescricao,
            this.clnUnidade,
            this.clnQuantidade,
            this.clnAsu,
            this.clnTipoMovimentacao,
            this.clnStatus,
            this.clnUsuarioSolicitacao,
            this.clnDataHoraSolicitacao,
            this.clnUsuarioAutorizador,
            this.clnDataHoraAutorizacao,
            this.clnUsuarioMovimentacao,
            this.clnDataHoraMovimentacao});
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
            this.dataGridView1.Size = new System.Drawing.Size(975, 141);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // clnNMovimentacao
            // 
            this.clnNMovimentacao.DataPropertyName = "NMovimentacao";
            this.clnNMovimentacao.HeaderText = "Nº Mov.";
            this.clnNMovimentacao.Name = "clnNMovimentacao";
            this.clnNMovimentacao.ReadOnly = true;
            this.clnNMovimentacao.Width = 50;
            // 
            // clnNRequisicao
            // 
            this.clnNRequisicao.DataPropertyName = "NRequisicao";
            this.clnNRequisicao.HeaderText = "Nº Req.";
            this.clnNRequisicao.Name = "clnNRequisicao";
            this.clnNRequisicao.ReadOnly = true;
            this.clnNRequisicao.Width = 50;
            // 
            // clnCodigoPeca
            // 
            this.clnCodigoPeca.DataPropertyName = "CodigoPeca";
            this.clnCodigoPeca.HeaderText = "Código";
            this.clnCodigoPeca.Name = "clnCodigoPeca";
            this.clnCodigoPeca.ReadOnly = true;
            // 
            // clnDescricao
            // 
            this.clnDescricao.DataPropertyName = "DescricaoPeca";
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 180;
            // 
            // clnUnidade
            // 
            this.clnUnidade.DataPropertyName = "Unidade";
            this.clnUnidade.HeaderText = "U.N.D";
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            this.clnUnidade.Width = 50;
            // 
            // clnQuantidade
            // 
            this.clnQuantidade.DataPropertyName = "Qtd";
            this.clnQuantidade.HeaderText = "QTD.";
            this.clnQuantidade.Name = "clnQuantidade";
            this.clnQuantidade.ReadOnly = true;
            this.clnQuantidade.Width = 50;
            // 
            // clnAsu
            // 
            this.clnAsu.DataPropertyName = "Asu";
            this.clnAsu.HeaderText = "A.S.U";
            this.clnAsu.Name = "clnAsu";
            this.clnAsu.ReadOnly = true;
            this.clnAsu.Width = 80;
            // 
            // clnTipoMovimentacao
            // 
            this.clnTipoMovimentacao.DataPropertyName = "TipoMovimentacao";
            this.clnTipoMovimentacao.HeaderText = "Tipo/Mov.";
            this.clnTipoMovimentacao.Name = "clnTipoMovimentacao";
            this.clnTipoMovimentacao.ReadOnly = true;
            this.clnTipoMovimentacao.Width = 80;
            // 
            // clnStatus
            // 
            this.clnStatus.DataPropertyName = "Status";
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            this.clnStatus.Width = 80;
            // 
            // clnUsuarioSolicitacao
            // 
            this.clnUsuarioSolicitacao.DataPropertyName = "UsuarioSolicitacao";
            this.clnUsuarioSolicitacao.HeaderText = "Usuário/Solic.";
            this.clnUsuarioSolicitacao.Name = "clnUsuarioSolicitacao";
            this.clnUsuarioSolicitacao.ReadOnly = true;
            // 
            // clnDataHoraSolicitacao
            // 
            this.clnDataHoraSolicitacao.DataPropertyName = "DataHoraSolicitacao";
            this.clnDataHoraSolicitacao.HeaderText = "Data/Hora Sol.";
            this.clnDataHoraSolicitacao.Name = "clnDataHoraSolicitacao";
            this.clnDataHoraSolicitacao.ReadOnly = true;
            this.clnDataHoraSolicitacao.Width = 120;
            // 
            // clnUsuarioAutorizador
            // 
            this.clnUsuarioAutorizador.DataPropertyName = "UsuarioAutorizacao";
            this.clnUsuarioAutorizador.HeaderText = "Usuário Aut.";
            this.clnUsuarioAutorizador.Name = "clnUsuarioAutorizador";
            this.clnUsuarioAutorizador.ReadOnly = true;
            // 
            // clnDataHoraAutorizacao
            // 
            this.clnDataHoraAutorizacao.DataPropertyName = "DataHoraAutorizacao";
            this.clnDataHoraAutorizacao.HeaderText = "Data/Hora Aut.";
            this.clnDataHoraAutorizacao.Name = "clnDataHoraAutorizacao";
            this.clnDataHoraAutorizacao.ReadOnly = true;
            this.clnDataHoraAutorizacao.Width = 120;
            // 
            // clnUsuarioMovimentacao
            // 
            this.clnUsuarioMovimentacao.DataPropertyName = "UsuarioMovimentacao";
            this.clnUsuarioMovimentacao.HeaderText = "Usuário Mov.";
            this.clnUsuarioMovimentacao.Name = "clnUsuarioMovimentacao";
            this.clnUsuarioMovimentacao.ReadOnly = true;
            // 
            // clnDataHoraMovimentacao
            // 
            this.clnDataHoraMovimentacao.DataPropertyName = "DataHoraMovimentacao";
            this.clnDataHoraMovimentacao.HeaderText = "Data/Hora Mov.";
            this.clnDataHoraMovimentacao.Name = "clnDataHoraMovimentacao";
            this.clnDataHoraMovimentacao.ReadOnly = true;
            this.clnDataHoraMovimentacao.Width = 120;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(975, 352);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtQuantidade);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.cboUnidade);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.txtDescriao);
            this.tabPage1.Controls.Add(this.btnEntrada);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(967, 326);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Geral";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(472, 59);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(54, 20);
            this.txtQuantidade.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(433, 62);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(33, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "QTD:";
            // 
            // cboUnidade
            // 
            this.cboUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidade.FormattingEnabled = true;
            this.cboUnidade.Location = new System.Drawing.Point(362, 53);
            this.cboUnidade.Name = "cboUnidade";
            this.cboUnidade.Size = new System.Drawing.Size(55, 21);
            this.cboUnidade.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(321, 62);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(34, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "UND:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(84, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(102, 20);
            this.txtCodigo.TabIndex = 0;
            // 
            // txtDescriao
            // 
            this.txtDescriao.Location = new System.Drawing.Point(84, 55);
            this.txtDescriao.Name = "txtDescriao";
            this.txtDescriao.Size = new System.Drawing.Size(219, 20);
            this.txtDescriao.TabIndex = 1;
            // 
            // btnEntrada
            // 
            this.btnEntrada.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEntrada.Location = new System.Drawing.Point(867, 297);
            this.btnEntrada.Name = "btnEntrada";
            this.btnEntrada.Size = new System.Drawing.Size(75, 23);
            this.btnEntrada.TabIndex = 2;
            this.btnEntrada.Text = "Entrada";
            this.btnEntrada.UseVisualStyleBackColor = true;
            this.btnEntrada.Click += new System.EventHandler(this.btnEntrada_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Código:";
            // 
            // tabPage2
            // 
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(967, 326);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Histórico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFiltro.Image = global::SistemaTHR.Properties.Resources.filter;
            this.btnFiltro.Location = new System.Drawing.Point(0, 0);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(28, 24);
            this.btnFiltro.TabIndex = 0;
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // frmMovimentacaPecas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(975, 543);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmMovimentacaPecas";
            this.Text = "Movimentação de Peças";
            this.Load += new System.EventHandler(this.frmMovimentacaPecas_Load);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNRequisicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAsu;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioAutorizador;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraAutorizacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraMovimentacao;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboUnidade;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtDescriao;
        private System.Windows.Forms.Button btnEntrada;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFiltro;
    }
}