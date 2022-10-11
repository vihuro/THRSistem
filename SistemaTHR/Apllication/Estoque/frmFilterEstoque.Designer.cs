namespace SistemaTHR.Apllication.Estoque
{
    partial class frmFilterEstoque
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnCodigoReferecia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnGrupo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRuaBox = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHora = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstoqueDisponivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstoqueMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstoqueMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstoqueSeguranca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cboCampo = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnCodigoReferecia,
            this.clnCodigo,
            this.clnDescricao,
            this.clnUnidade,
            this.clnGrupo,
            this.clnFornecedor,
            this.clnRuaBox,
            this.clnUsuario,
            this.clnDataHora,
            this.clnEstoqueDisponivel,
            this.clnEstoqueMinimo,
            this.clnEstoqueMaximo,
            this.clnEstoqueSeguranca});
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(12, 112);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(610, 273);
            this.dataGridView1.TabIndex = 0;
            // 
            // clnCodigoReferecia
            // 
            this.clnCodigoReferecia.DataPropertyName = "CodigoRef";
            this.clnCodigoReferecia.HeaderText = "Código/Ref.";
            this.clnCodigoReferecia.Name = "clnCodigoReferecia";
            this.clnCodigoReferecia.ReadOnly = true;
            this.clnCodigoReferecia.Visible = false;
            this.clnCodigoReferecia.Width = 90;
            // 
            // clnCodigo
            // 
            this.clnCodigo.DataPropertyName = "Codigo";
            this.clnCodigo.HeaderText = "Código";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            this.clnCodigo.Width = 120;
            // 
            // clnDescricao
            // 
            this.clnDescricao.DataPropertyName = "Descricao";
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 250;
            // 
            // clnUnidade
            // 
            this.clnUnidade.DataPropertyName = "Unid";
            this.clnUnidade.HeaderText = "Und.";
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            this.clnUnidade.Width = 40;
            // 
            // clnGrupo
            // 
            this.clnGrupo.DataPropertyName = "Grupo";
            this.clnGrupo.HeaderText = "Grupo";
            this.clnGrupo.Name = "clnGrupo";
            this.clnGrupo.ReadOnly = true;
            this.clnGrupo.Visible = false;
            // 
            // clnFornecedor
            // 
            this.clnFornecedor.DataPropertyName = "Fornecedor";
            this.clnFornecedor.HeaderText = "Fornecedor";
            this.clnFornecedor.Name = "clnFornecedor";
            this.clnFornecedor.ReadOnly = true;
            // 
            // clnRuaBox
            // 
            this.clnRuaBox.DataPropertyName = "RuaxBox";
            this.clnRuaBox.HeaderText = "Rua/Box";
            this.clnRuaBox.Name = "clnRuaBox";
            this.clnRuaBox.ReadOnly = true;
            this.clnRuaBox.Visible = false;
            // 
            // clnUsuario
            // 
            this.clnUsuario.DataPropertyName = "Usuario";
            this.clnUsuario.HeaderText = "Usuario";
            this.clnUsuario.Name = "clnUsuario";
            this.clnUsuario.ReadOnly = true;
            this.clnUsuario.Visible = false;
            // 
            // clnDataHora
            // 
            this.clnDataHora.DataPropertyName = "DataHora";
            this.clnDataHora.HeaderText = "Data/Hora";
            this.clnDataHora.Name = "clnDataHora";
            this.clnDataHora.ReadOnly = true;
            this.clnDataHora.Visible = false;
            // 
            // clnEstoqueDisponivel
            // 
            this.clnEstoqueDisponivel.DataPropertyName = "EstoqueDisponivel";
            this.clnEstoqueDisponivel.HeaderText = "Est.Disp.";
            this.clnEstoqueDisponivel.Name = "clnEstoqueDisponivel";
            this.clnEstoqueDisponivel.ReadOnly = true;
            // 
            // clnEstoqueMinimo
            // 
            this.clnEstoqueMinimo.DataPropertyName = "EstoqueMinimo";
            this.clnEstoqueMinimo.HeaderText = "Estoque/Minimo";
            this.clnEstoqueMinimo.Name = "clnEstoqueMinimo";
            this.clnEstoqueMinimo.ReadOnly = true;
            this.clnEstoqueMinimo.Visible = false;
            // 
            // clnEstoqueMaximo
            // 
            this.clnEstoqueMaximo.DataPropertyName = "EstoqueMaximo";
            this.clnEstoqueMaximo.HeaderText = "Estoque/Maximo";
            this.clnEstoqueMaximo.Name = "clnEstoqueMaximo";
            this.clnEstoqueMaximo.ReadOnly = true;
            this.clnEstoqueMaximo.Visible = false;
            // 
            // clnEstoqueSeguranca
            // 
            this.clnEstoqueSeguranca.DataPropertyName = "EstoqueSeguranca";
            this.clnEstoqueSeguranca.HeaderText = "Estoque/Seg";
            this.clnEstoqueSeguranca.Name = "clnEstoqueSeguranca";
            this.clnEstoqueSeguranca.ReadOnly = true;
            this.clnEstoqueSeguranca.Visible = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cboCampo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(521, 94);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 67);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Buscar por:";
            // 
            // cboCampo
            // 
            this.cboCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCampo.FormattingEnabled = true;
            this.cboCampo.Items.AddRange(new object[] {
            "Descrição",
            "Código",
            "Grupo"});
            this.cboCampo.Location = new System.Drawing.Point(77, 18);
            this.cboCampo.Name = "cboCampo";
            this.cboCampo.Size = new System.Drawing.Size(180, 21);
            this.cboCampo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(43, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Campo:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(77, 60);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(438, 20);
            this.txtDescricao.TabIndex = 1;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(13, 391);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 3;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Location = new System.Drawing.Point(547, 79);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(75, 23);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.Text = "Somar";
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(548, 391);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 4;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // frmFilterEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(635, 426);
            this.Controls.Add(this.btnCarregar);
            this.Controls.Add(this.btnSomar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.dataGridView1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFilterEstoque";
            this.ShowIcon = false;
            this.Text = "Filtro Estoque";
            this.Load += new System.EventHandler(this.frmFilterEstoque_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboCampo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoReferecia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnGrupo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRuaBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHora;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstoqueDisponivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstoqueMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstoqueMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstoqueSeguranca;
    }
}