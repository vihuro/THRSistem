namespace SistemaTHR.Apllication.Estoque
{
    partial class frmEstoque
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEstoque));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSomar = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnCodigoReferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.txtEstoqueSegueranca = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.btnAlterar = new System.Windows.Forms.Button();
            this.btnCadastroGrupo = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label8 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboGrupo = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtFornecedor = new System.Windows.Forms.TextBox();
            this.txtEstoqueMaximo = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtEstoqueMinimo = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cboUnidade = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.txtCodigoReferencia = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btnExportar = new System.Windows.Forms.Button();
            this.btnInserir = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clnNumeroMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricaoMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMovimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQuantidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQuantidadeBobinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnOperacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDocumento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnObervacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioMovimentacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBase = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFornecedorMovimentado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 628);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(999, 22);
            this.statusStrip1.TabIndex = 0;
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
            // panel1
            // 
            this.panel1.Controls.Add(this.btnSomar);
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(999, 24);
            this.panel1.TabIndex = 1;
            // 
            // btnSomar
            // 
            this.btnSomar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSomar.Image = global::SistemaTHR.Properties.Resources.mais;
            this.btnSomar.Location = new System.Drawing.Point(60, 0);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(27, 24);
            this.btnSomar.TabIndex = 2;
            this.btnSomar.UseVisualStyleBackColor = true;
            this.btnSomar.Click += new System.EventHandler(this.btnSomar_Click);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFiltrar.Image = global::SistemaTHR.Properties.Resources.filter;
            this.btnFiltrar.Location = new System.Drawing.Point(31, 0);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(29, 24);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnLimpar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLimpar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnLimpar.Image = global::SistemaTHR.Properties.Resources.refresh_button;
            this.btnLimpar.Location = new System.Drawing.Point(0, 0);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(31, 24);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
            this.splitContainer1.Panel2.CausesValidation = false;
            this.splitContainer1.Panel2.Controls.Add(this.tabControl1);
            this.splitContainer1.Size = new System.Drawing.Size(999, 604);
            this.splitContainer1.SplitterDistance = 160;
            this.splitContainer1.TabIndex = 2;
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
            this.clnCodigoReferencia,
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
            this.dataGridView1.Size = new System.Drawing.Size(997, 158);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // clnCodigoReferencia
            // 
            this.clnCodigoReferencia.DataPropertyName = "CodigoRef";
            this.clnCodigoReferencia.HeaderText = "Cod/Ref.";
            this.clnCodigoReferencia.Name = "clnCodigoReferencia";
            this.clnCodigoReferencia.ReadOnly = true;
            this.clnCodigoReferencia.Width = 80;
            // 
            // clnCodigo
            // 
            this.clnCodigo.DataPropertyName = "Codigo";
            this.clnCodigo.HeaderText = "Código";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            // 
            // clnDescricao
            // 
            this.clnDescricao.DataPropertyName = "Descricao";
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 200;
            // 
            // clnUnidade
            // 
            this.clnUnidade.DataPropertyName = "Unid";
            this.clnUnidade.HeaderText = "UND.";
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            this.clnUnidade.Width = 50;
            // 
            // clnGrupo
            // 
            this.clnGrupo.DataPropertyName = "Grupo";
            this.clnGrupo.HeaderText = "Grupo";
            this.clnGrupo.Name = "clnGrupo";
            this.clnGrupo.ReadOnly = true;
            this.clnGrupo.Width = 120;
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
            this.clnRuaBox.HeaderText = "Rua";
            this.clnRuaBox.Name = "clnRuaBox";
            this.clnRuaBox.ReadOnly = true;
            this.clnRuaBox.Visible = false;
            // 
            // clnUsuario
            // 
            this.clnUsuario.DataPropertyName = "Usuario";
            this.clnUsuario.HeaderText = "Usuário";
            this.clnUsuario.Name = "clnUsuario";
            this.clnUsuario.ReadOnly = true;
            // 
            // clnDataHora
            // 
            this.clnDataHora.DataPropertyName = "DataHora";
            this.clnDataHora.HeaderText = "Data/Hora";
            this.clnDataHora.Name = "clnDataHora";
            this.clnDataHora.ReadOnly = true;
            // 
            // clnEstoqueDisponivel
            // 
            this.clnEstoqueDisponivel.DataPropertyName = "EstoqueDisponivel";
            this.clnEstoqueDisponivel.HeaderText = "Est/Dis.";
            this.clnEstoqueDisponivel.Name = "clnEstoqueDisponivel";
            this.clnEstoqueDisponivel.ReadOnly = true;
            this.clnEstoqueDisponivel.Width = 80;
            // 
            // clnEstoqueMinimo
            // 
            this.clnEstoqueMinimo.DataPropertyName = "EstoqueMinimo";
            this.clnEstoqueMinimo.HeaderText = "Est/Max.";
            this.clnEstoqueMinimo.Name = "clnEstoqueMinimo";
            this.clnEstoqueMinimo.ReadOnly = true;
            this.clnEstoqueMinimo.Width = 50;
            // 
            // clnEstoqueMaximo
            // 
            this.clnEstoqueMaximo.DataPropertyName = "EstoqueMaximo";
            this.clnEstoqueMaximo.HeaderText = "Est/Min.";
            this.clnEstoqueMaximo.Name = "clnEstoqueMaximo";
            this.clnEstoqueMaximo.ReadOnly = true;
            this.clnEstoqueMaximo.Width = 50;
            // 
            // clnEstoqueSeguranca
            // 
            this.clnEstoqueSeguranca.DataPropertyName = "EstoqueSeguranca";
            this.clnEstoqueSeguranca.HeaderText = "Est/Seg.";
            this.clnEstoqueSeguranca.Name = "clnEstoqueSeguranca";
            this.clnEstoqueSeguranca.ReadOnly = true;
            this.clnEstoqueSeguranca.Width = 50;
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(997, 438);
            this.tabControl1.TabIndex = 17;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.txtEstoqueSegueranca);
            this.tabPage1.Controls.Add(this.label9);
            this.tabPage1.Controls.Add(this.btnAlterar);
            this.tabPage1.Controls.Add(this.btnCadastroGrupo);
            this.tabPage1.Controls.Add(this.btnSalvar);
            this.tabPage1.Controls.Add(this.label8);
            this.tabPage1.Controls.Add(this.label2);
            this.tabPage1.Controls.Add(this.cboGrupo);
            this.tabPage1.Controls.Add(this.label7);
            this.tabPage1.Controls.Add(this.txtFornecedor);
            this.tabPage1.Controls.Add(this.txtEstoqueMaximo);
            this.tabPage1.Controls.Add(this.label6);
            this.tabPage1.Controls.Add(this.txtEstoqueMinimo);
            this.tabPage1.Controls.Add(this.label5);
            this.tabPage1.Controls.Add(this.cboUnidade);
            this.tabPage1.Controls.Add(this.label4);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.label1);
            this.tabPage1.Controls.Add(this.txtDescricao);
            this.tabPage1.Controls.Add(this.txtCodigo);
            this.tabPage1.Controls.Add(this.txtCodigoReferencia);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(989, 412);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Geral";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtEstoqueSegueranca
            // 
            this.txtEstoqueSegueranca.Location = new System.Drawing.Point(394, 138);
            this.txtEstoqueSegueranca.Name = "txtEstoqueSegueranca";
            this.txtEstoqueSegueranca.Size = new System.Drawing.Size(60, 20);
            this.txtEstoqueSegueranca.TabIndex = 7;
            this.txtEstoqueSegueranca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueSegueranca_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(315, 145);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(73, 13);
            this.label9.TabIndex = 35;
            this.label9.Text = "Estoque/Seg.";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Location = new System.Drawing.Point(911, 383);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(75, 23);
            this.btnAlterar.TabIndex = 34;
            this.btnAlterar.Text = "Alterar";
            this.btnAlterar.UseVisualStyleBackColor = true;
            this.btnAlterar.Click += new System.EventHandler(this.btnAlterar_Click);
            // 
            // btnCadastroGrupo
            // 
            this.btnCadastroGrupo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCadastroGrupo.ForeColor = System.Drawing.Color.White;
            this.btnCadastroGrupo.Image = global::SistemaTHR.Properties.Resources.seo;
            this.btnCadastroGrupo.Location = new System.Drawing.Point(883, 91);
            this.btnCadastroGrupo.Name = "btnCadastroGrupo";
            this.btnCadastroGrupo.Size = new System.Drawing.Size(22, 23);
            this.btnCadastroGrupo.TabIndex = 33;
            this.btnCadastroGrupo.UseVisualStyleBackColor = true;
            this.btnCadastroGrupo.Click += new System.EventHandler(this.btnCadastroGrupo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(830, 383);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(507, 99);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 31;
            this.label8.Text = "Grupo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(31, 57);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código:";
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Items.AddRange(new object[] {
            ""});
            this.cboGrupo.Location = new System.Drawing.Point(552, 90);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(325, 21);
            this.cboGrupo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 183);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(64, 13);
            this.label7.TabIndex = 29;
            this.label7.Text = "Fornecedor:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(88, 176);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(213, 20);
            this.txtFornecedor.TabIndex = 8;
            // 
            // txtEstoqueMaximo
            // 
            this.txtEstoqueMaximo.Location = new System.Drawing.Point(241, 138);
            this.txtEstoqueMaximo.Name = "txtEstoqueMaximo";
            this.txtEstoqueMaximo.Size = new System.Drawing.Size(60, 20);
            this.txtEstoqueMaximo.TabIndex = 6;
            this.txtEstoqueMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueMaximo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(164, 145);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Estoque/Max.";
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(88, 138);
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(60, 20);
            this.txtEstoqueMinimo.TabIndex = 5;
            this.txtEstoqueMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueMinimo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(11, 145);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(71, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "Estoque/Min.";
            // 
            // cboUnidade
            // 
            this.cboUnidade.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUnidade.FormattingEnabled = true;
            this.cboUnidade.Items.AddRange(new object[] {
            "",
            "KG",
            "ROLO",
            "PC",
            "MI"});
            this.cboUnidade.Location = new System.Drawing.Point(430, 91);
            this.cboUnidade.Name = "cboUnidade";
            this.cboUnidade.Size = new System.Drawing.Size(58, 21);
            this.cboUnidade.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(374, 98);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 22;
            this.label4.Text = "Unidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 94);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 21;
            this.label3.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 20;
            this.label1.Text = "Código Ref:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(88, 91);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(270, 20);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(88, 50);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(100, 20);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtCodigoReferencia
            // 
            this.txtCodigoReferencia.Location = new System.Drawing.Point(88, 14);
            this.txtCodigoReferencia.Name = "txtCodigoReferencia";
            this.txtCodigoReferencia.Size = new System.Drawing.Size(100, 20);
            this.txtCodigoReferencia.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnExportar);
            this.tabPage2.Controls.Add(this.btnInserir);
            this.tabPage2.Controls.Add(this.textBox1);
            this.tabPage2.Controls.Add(this.label11);
            this.tabPage2.Controls.Add(this.label10);
            this.tabPage2.Controls.Add(this.comboBox1);
            this.tabPage2.Controls.Add(this.dataGridView2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(989, 412);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Histórico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Enabled = false;
            this.btnExportar.Location = new System.Drawing.Point(877, 70);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(75, 23);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Enabled = false;
            this.btnInserir.Location = new System.Drawing.Point(790, 70);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(75, 23);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(81, 54);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(386, 20);
            this.textBox1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(14, 61);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(61, 13);
            this.label11.TabIndex = 3;
            this.label11.Text = "Buscar por:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(39, 33);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(32, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Filtro:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(81, 25);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(164, 21);
            this.comboBox1.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView2.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumeroMovimentacao,
            this.clnCodigoMaterial,
            this.clnDescricaoMaterial,
            this.clnLote,
            this.clnMovimento,
            this.clnData,
            this.clnQuantidade,
            this.clnQuantidadeBobinas,
            this.clnOperacao,
            this.clnDocumento,
            this.clnObervacao,
            this.clnUsuarioMovimentacao,
            this.clnBase,
            this.clnFornecedorMovimentado});
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(7, 99);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(945, 283);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            this.dataGridView2.CellStyleChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellStyleChanged);
            // 
            // clnNumeroMovimentacao
            // 
            this.clnNumeroMovimentacao.DataPropertyName = "Codigo";
            this.clnNumeroMovimentacao.HeaderText = "Nº/Mov.";
            this.clnNumeroMovimentacao.Name = "clnNumeroMovimentacao";
            this.clnNumeroMovimentacao.ReadOnly = true;
            // 
            // clnCodigoMaterial
            // 
            this.clnCodigoMaterial.DataPropertyName = "CodProd";
            this.clnCodigoMaterial.HeaderText = "Código";
            this.clnCodigoMaterial.Name = "clnCodigoMaterial";
            this.clnCodigoMaterial.ReadOnly = true;
            this.clnCodigoMaterial.Visible = false;
            // 
            // clnDescricaoMaterial
            // 
            this.clnDescricaoMaterial.DataPropertyName = "Descricao";
            this.clnDescricaoMaterial.HeaderText = "Descrição";
            this.clnDescricaoMaterial.Name = "clnDescricaoMaterial";
            this.clnDescricaoMaterial.ReadOnly = true;
            this.clnDescricaoMaterial.Visible = false;
            // 
            // clnLote
            // 
            this.clnLote.DataPropertyName = "Lote";
            this.clnLote.HeaderText = "Lote";
            this.clnLote.Name = "clnLote";
            this.clnLote.ReadOnly = true;
            this.clnLote.Visible = false;
            // 
            // clnMovimento
            // 
            this.clnMovimento.DataPropertyName = "Movimento";
            this.clnMovimento.HeaderText = "Tipo/Mov.";
            this.clnMovimento.Name = "clnMovimento";
            this.clnMovimento.ReadOnly = true;
            this.clnMovimento.Width = 120;
            // 
            // clnData
            // 
            this.clnData.DataPropertyName = "Data";
            this.clnData.HeaderText = "Data/Mov.";
            this.clnData.Name = "clnData";
            this.clnData.ReadOnly = true;
            this.clnData.Width = 120;
            // 
            // clnQuantidade
            // 
            this.clnQuantidade.DataPropertyName = "Quantidade";
            this.clnQuantidade.HeaderText = "Quantidade";
            this.clnQuantidade.Name = "clnQuantidade";
            this.clnQuantidade.ReadOnly = true;
            this.clnQuantidade.Visible = false;
            // 
            // clnQuantidadeBobinas
            // 
            this.clnQuantidadeBobinas.DataPropertyName = "QtdBobinas";
            this.clnQuantidadeBobinas.HeaderText = "QT.Bobinas";
            this.clnQuantidadeBobinas.Name = "clnQuantidadeBobinas";
            this.clnQuantidadeBobinas.ReadOnly = true;
            this.clnQuantidadeBobinas.Visible = false;
            // 
            // clnOperacao
            // 
            this.clnOperacao.DataPropertyName = "Operacao";
            this.clnOperacao.HeaderText = "Operação";
            this.clnOperacao.Name = "clnOperacao";
            this.clnOperacao.ReadOnly = true;
            this.clnOperacao.Width = 210;
            // 
            // clnDocumento
            // 
            this.clnDocumento.DataPropertyName = "Documento";
            this.clnDocumento.HeaderText = "Documento";
            this.clnDocumento.Name = "clnDocumento";
            this.clnDocumento.ReadOnly = true;
            this.clnDocumento.Visible = false;
            // 
            // clnObervacao
            // 
            this.clnObervacao.DataPropertyName = "Observacoes";
            this.clnObervacao.HeaderText = "Quantidade";
            this.clnObervacao.Name = "clnObervacao";
            this.clnObervacao.ReadOnly = true;
            // 
            // clnUsuarioMovimentacao
            // 
            this.clnUsuarioMovimentacao.DataPropertyName = "Usuario";
            this.clnUsuarioMovimentacao.HeaderText = "Usuário";
            this.clnUsuarioMovimentacao.Name = "clnUsuarioMovimentacao";
            this.clnUsuarioMovimentacao.ReadOnly = true;
            this.clnUsuarioMovimentacao.Width = 120;
            // 
            // clnBase
            // 
            this.clnBase.DataPropertyName = "Base";
            this.clnBase.HeaderText = "Base";
            this.clnBase.Name = "clnBase";
            this.clnBase.ReadOnly = true;
            this.clnBase.Visible = false;
            // 
            // clnFornecedorMovimentado
            // 
            this.clnFornecedorMovimentado.DataPropertyName = "Fornecedor";
            this.clnFornecedorMovimentado.HeaderText = "Fornecedor";
            this.clnFornecedorMovimentado.Name = "clnFornecedorMovimentado";
            this.clnFornecedorMovimentado.ReadOnly = true;
            this.clnFornecedorMovimentado.Visible = false;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(999, 650);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEstoque";
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.frmEstoque_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtFornecedor;
        private System.Windows.Forms.TextBox txtEstoqueMaximo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtEstoqueMinimo;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cboUnidade;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox txtCodigoReferencia;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCadastroGrupo;
        public System.Windows.Forms.ComboBox cboGrupo;
        private System.Windows.Forms.Button btnAlterar;
        private System.Windows.Forms.TextBox txtEstoqueSegueranca;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoReferencia;
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
        private System.Windows.Forms.Button btnSomar;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button btnInserir;
        private System.Windows.Forms.Button btnExportar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricaoMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMovimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQuantidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQuantidadeBobinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnOperacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDocumento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnObervacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioMovimentacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBase;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFornecedorMovimentado;
    }
}