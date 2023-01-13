namespace SistemaTHR.Apllication.Manutencao
{
    partial class frmEstoquePesquisa
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnNPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQuantidadeEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstoqueMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstoqueMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFornecedor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoFornecedor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFornecedor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoFornecedor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFornecedor3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoForn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioGravacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraGravacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Código:";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(86, 40);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(354, 20);
            this.txtFiltro.TabIndex = 0;
            this.txtFiltro.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(587, 359);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 1;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(21, 359);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboCampo);
            this.groupBox1.Controls.Add(this.txtFiltro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(502, 73);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 47);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Buscar por:";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Items.AddRange(new object[] {
            "Código",
            "Descrição"});
            this.cboCampo.Location = new System.Drawing.Point(86, 13);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(121, 21);
            this.cboCampo.TabIndex = 5;
            // 
            // dataGridView1
            // 
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
            this.clnNPeca,
            this.clnCodigo,
            this.clnDescricao,
            this.clnUnidade,
            this.clnQuantidadeEstoque,
            this.clnEstoqueMax,
            this.clnEstoqueMin,
            this.clnFornecedor1,
            this.clnCodigoFornecedor1,
            this.clnFornecedor2,
            this.clnCodigoFornecedor2,
            this.clnFornecedor3,
            this.clnCodigoForn3,
            this.clnUsuarioGravacao,
            this.clnDataHoraGravacao});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(21, 91);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(641, 246);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // clnNPeca
            // 
            this.clnNPeca.DataPropertyName = "NPeca";
            this.clnNPeca.HeaderText = "Nº Peça";
            this.clnNPeca.Name = "clnNPeca";
            this.clnNPeca.ReadOnly = true;
            this.clnNPeca.Visible = false;
            // 
            // clnCodigo
            // 
            this.clnCodigo.DataPropertyName = "Codigo";
            this.clnCodigo.HeaderText = "Código";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            this.clnCodigo.Width = 180;
            // 
            // clnDescricao
            // 
            this.clnDescricao.DataPropertyName = "Descricao";
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 320;
            // 
            // clnUnidade
            // 
            this.clnUnidade.DataPropertyName = "Unidade";
            this.clnUnidade.HeaderText = "UND.";
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            this.clnUnidade.Width = 50;
            // 
            // clnQuantidadeEstoque
            // 
            this.clnQuantidadeEstoque.DataPropertyName = "QtEstoque";
            this.clnQuantidadeEstoque.HeaderText = "QTD.";
            this.clnQuantidadeEstoque.Name = "clnQuantidadeEstoque";
            this.clnQuantidadeEstoque.ReadOnly = true;
            this.clnQuantidadeEstoque.Width = 50;
            // 
            // clnEstoqueMax
            // 
            this.clnEstoqueMax.DataPropertyName = "EstoqueMax";
            this.clnEstoqueMax.HeaderText = "Estoque Max.";
            this.clnEstoqueMax.Name = "clnEstoqueMax";
            this.clnEstoqueMax.ReadOnly = true;
            this.clnEstoqueMax.Visible = false;
            // 
            // clnEstoqueMin
            // 
            this.clnEstoqueMin.DataPropertyName = "EstoqueMin";
            this.clnEstoqueMin.HeaderText = "Estoque Min.";
            this.clnEstoqueMin.Name = "clnEstoqueMin";
            this.clnEstoqueMin.ReadOnly = true;
            this.clnEstoqueMin.Visible = false;
            // 
            // clnFornecedor1
            // 
            this.clnFornecedor1.DataPropertyName = "Fornecedor1";
            this.clnFornecedor1.HeaderText = "Fornecedor 1";
            this.clnFornecedor1.Name = "clnFornecedor1";
            this.clnFornecedor1.ReadOnly = true;
            this.clnFornecedor1.Visible = false;
            // 
            // clnCodigoFornecedor1
            // 
            this.clnCodigoFornecedor1.DataPropertyName = "CodigoFornecedor1";
            this.clnCodigoFornecedor1.HeaderText = "Codigo/For.1";
            this.clnCodigoFornecedor1.Name = "clnCodigoFornecedor1";
            this.clnCodigoFornecedor1.ReadOnly = true;
            this.clnCodigoFornecedor1.Visible = false;
            // 
            // clnFornecedor2
            // 
            this.clnFornecedor2.DataPropertyName = "Fornecedor2";
            this.clnFornecedor2.HeaderText = "Fornecedor 2";
            this.clnFornecedor2.Name = "clnFornecedor2";
            this.clnFornecedor2.ReadOnly = true;
            this.clnFornecedor2.Visible = false;
            // 
            // clnCodigoFornecedor2
            // 
            this.clnCodigoFornecedor2.DataPropertyName = "CodigoFornecedor2";
            this.clnCodigoFornecedor2.HeaderText = "Codigo/For.2";
            this.clnCodigoFornecedor2.Name = "clnCodigoFornecedor2";
            this.clnCodigoFornecedor2.ReadOnly = true;
            this.clnCodigoFornecedor2.Visible = false;
            // 
            // clnFornecedor3
            // 
            this.clnFornecedor3.DataPropertyName = "Fornecedor3";
            this.clnFornecedor3.HeaderText = "Forncedor 3";
            this.clnFornecedor3.Name = "clnFornecedor3";
            this.clnFornecedor3.ReadOnly = true;
            this.clnFornecedor3.Visible = false;
            // 
            // clnCodigoForn3
            // 
            this.clnCodigoForn3.DataPropertyName = "CodigoFornecedor3";
            this.clnCodigoForn3.HeaderText = "Codigo/For.3";
            this.clnCodigoForn3.Name = "clnCodigoForn3";
            this.clnCodigoForn3.ReadOnly = true;
            this.clnCodigoForn3.Visible = false;
            // 
            // clnUsuarioGravacao
            // 
            this.clnUsuarioGravacao.DataPropertyName = "UsuarioGravacao";
            this.clnUsuarioGravacao.HeaderText = "Usuario/Gravacao";
            this.clnUsuarioGravacao.Name = "clnUsuarioGravacao";
            this.clnUsuarioGravacao.ReadOnly = true;
            this.clnUsuarioGravacao.Visible = false;
            // 
            // clnDataHoraGravacao
            // 
            this.clnDataHoraGravacao.DataPropertyName = "DataHoraGravacao";
            this.clnDataHoraGravacao.HeaderText = "Data/Hora Gravacao";
            this.clnDataHoraGravacao.Name = "clnDataHoraGravacao";
            this.clnDataHoraGravacao.ReadOnly = true;
            this.clnDataHoraGravacao.Visible = false;
            // 
            // frmEstoquePesquisa
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(681, 394);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEstoquePesquisa";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.frmEstoquePesquisa_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQuantidadeEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstoqueMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstoqueMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFornecedor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoFornecedor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFornecedor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoFornecedor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFornecedor3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoForn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioGravacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraGravacao;
    }
}