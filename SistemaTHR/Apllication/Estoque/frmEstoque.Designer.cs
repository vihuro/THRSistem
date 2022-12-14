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
            this.btnRelatorio = new System.Windows.Forms.Button();
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
            this.clnEstoqueMaximo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstoqueMinimo = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.statusStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 774);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Padding = new System.Windows.Forms.Padding(1, 0, 19, 0);
            this.statusStrip1.Size = new System.Drawing.Size(1332, 26);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(62, 20);
            this.toolStripStatusLabel1.Text = "Usuário:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 20);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnRelatorio);
            this.panel1.Controls.Add(this.btnSomar);
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1332, 30);
            this.panel1.TabIndex = 1;
            // 
            // btnRelatorio
            // 
            this.btnRelatorio.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnRelatorio.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRelatorio.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRelatorio.Image = global::SistemaTHR.Properties.Resources.document;
            this.btnRelatorio.Location = new System.Drawing.Point(116, 0);
            this.btnRelatorio.Margin = new System.Windows.Forms.Padding(4);
            this.btnRelatorio.Name = "btnRelatorio";
            this.btnRelatorio.Size = new System.Drawing.Size(36, 30);
            this.btnRelatorio.TabIndex = 3;
            this.btnRelatorio.UseVisualStyleBackColor = true;
            this.btnRelatorio.Click += new System.EventHandler(this.btnRelatorio_Click);
            // 
            // btnSomar
            // 
            this.btnSomar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnSomar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSomar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnSomar.Image = global::SistemaTHR.Properties.Resources.mais;
            this.btnSomar.Location = new System.Drawing.Point(80, 0);
            this.btnSomar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSomar.Name = "btnSomar";
            this.btnSomar.Size = new System.Drawing.Size(36, 30);
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
            this.btnFiltrar.Location = new System.Drawing.Point(41, 0);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(39, 30);
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
            this.btnLimpar.Margin = new System.Windows.Forms.Padding(4);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(41, 30);
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 30);
            this.splitContainer1.Margin = new System.Windows.Forms.Padding(4);
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
            this.splitContainer1.Size = new System.Drawing.Size(1332, 744);
            this.splitContainer1.SplitterDistance = 197;
            this.splitContainer1.SplitterWidth = 5;
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
            this.dataGridView1.ColumnHeadersHeight = 29;
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
            this.clnEstoqueMaximo,
            this.clnEstoqueMinimo,
            this.clnEstoqueSeguranca});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1330, 195);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // clnCodigoReferencia
            // 
            this.clnCodigoReferencia.DataPropertyName = "CodigoRef";
            this.clnCodigoReferencia.HeaderText = "Cod/Ref.";
            this.clnCodigoReferencia.MinimumWidth = 6;
            this.clnCodigoReferencia.Name = "clnCodigoReferencia";
            this.clnCodigoReferencia.ReadOnly = true;
            this.clnCodigoReferencia.Width = 80;
            // 
            // clnCodigo
            // 
            this.clnCodigo.DataPropertyName = "Codigo";
            this.clnCodigo.HeaderText = "Código";
            this.clnCodigo.MinimumWidth = 6;
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            this.clnCodigo.Width = 125;
            // 
            // clnDescricao
            // 
            this.clnDescricao.DataPropertyName = "Descricao";
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.MinimumWidth = 6;
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 320;
            // 
            // clnUnidade
            // 
            this.clnUnidade.DataPropertyName = "Unid";
            this.clnUnidade.HeaderText = "UND.";
            this.clnUnidade.MinimumWidth = 6;
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            this.clnUnidade.Width = 45;
            // 
            // clnGrupo
            // 
            this.clnGrupo.DataPropertyName = "Grupo";
            this.clnGrupo.HeaderText = "Grupo";
            this.clnGrupo.MinimumWidth = 6;
            this.clnGrupo.Name = "clnGrupo";
            this.clnGrupo.ReadOnly = true;
            this.clnGrupo.Width = 120;
            // 
            // clnFornecedor
            // 
            this.clnFornecedor.DataPropertyName = "Fornecedor";
            this.clnFornecedor.HeaderText = "Fornecedor";
            this.clnFornecedor.MinimumWidth = 6;
            this.clnFornecedor.Name = "clnFornecedor";
            this.clnFornecedor.ReadOnly = true;
            this.clnFornecedor.Width = 125;
            // 
            // clnRuaBox
            // 
            this.clnRuaBox.DataPropertyName = "RuaxBox";
            this.clnRuaBox.HeaderText = "Rua";
            this.clnRuaBox.MinimumWidth = 6;
            this.clnRuaBox.Name = "clnRuaBox";
            this.clnRuaBox.ReadOnly = true;
            this.clnRuaBox.Visible = false;
            this.clnRuaBox.Width = 125;
            // 
            // clnUsuario
            // 
            this.clnUsuario.DataPropertyName = "Usuario";
            this.clnUsuario.HeaderText = "Usuário";
            this.clnUsuario.MinimumWidth = 6;
            this.clnUsuario.Name = "clnUsuario";
            this.clnUsuario.ReadOnly = true;
            this.clnUsuario.Width = 125;
            // 
            // clnDataHora
            // 
            this.clnDataHora.DataPropertyName = "DataHora";
            this.clnDataHora.HeaderText = "Data/Hora";
            this.clnDataHora.MinimumWidth = 6;
            this.clnDataHora.Name = "clnDataHora";
            this.clnDataHora.ReadOnly = true;
            this.clnDataHora.Width = 150;
            // 
            // clnEstoqueDisponivel
            // 
            this.clnEstoqueDisponivel.DataPropertyName = "EstoqueDisponivel";
            this.clnEstoqueDisponivel.HeaderText = "Est/Dis.";
            this.clnEstoqueDisponivel.MinimumWidth = 6;
            this.clnEstoqueDisponivel.Name = "clnEstoqueDisponivel";
            this.clnEstoqueDisponivel.ReadOnly = true;
            this.clnEstoqueDisponivel.Width = 80;
            // 
            // clnEstoqueMaximo
            // 
            this.clnEstoqueMaximo.DataPropertyName = "EstoqueMinimo";
            this.clnEstoqueMaximo.HeaderText = "Est/Min.";
            this.clnEstoqueMaximo.MinimumWidth = 6;
            this.clnEstoqueMaximo.Name = "clnEstoqueMaximo";
            this.clnEstoqueMaximo.ReadOnly = true;
            this.clnEstoqueMaximo.Width = 50;
            // 
            // clnEstoqueMinimo
            // 
            this.clnEstoqueMinimo.DataPropertyName = "EstoqueMaximo";
            this.clnEstoqueMinimo.HeaderText = "Est/Max.";
            this.clnEstoqueMinimo.MinimumWidth = 6;
            this.clnEstoqueMinimo.Name = "clnEstoqueMinimo";
            this.clnEstoqueMinimo.ReadOnly = true;
            this.clnEstoqueMinimo.Width = 50;
            // 
            // clnEstoqueSeguranca
            // 
            this.clnEstoqueSeguranca.DataPropertyName = "EstoqueSeguranca";
            this.clnEstoqueSeguranca.HeaderText = "Est/Seg.";
            this.clnEstoqueSeguranca.MinimumWidth = 6;
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
            this.tabControl1.Margin = new System.Windows.Forms.Padding(4);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(1330, 540);
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
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage1.Size = new System.Drawing.Size(1322, 511);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Geral";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // txtEstoqueSegueranca
            // 
            this.txtEstoqueSegueranca.Location = new System.Drawing.Point(525, 170);
            this.txtEstoqueSegueranca.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstoqueSegueranca.Name = "txtEstoqueSegueranca";
            this.txtEstoqueSegueranca.Size = new System.Drawing.Size(79, 22);
            this.txtEstoqueSegueranca.TabIndex = 7;
            this.txtEstoqueSegueranca.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueSegueranca_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(420, 178);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(89, 16);
            this.label9.TabIndex = 35;
            this.label9.Text = "Estoque/Seg.";
            // 
            // btnAlterar
            // 
            this.btnAlterar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAlterar.Location = new System.Drawing.Point(1216, 472);
            this.btnAlterar.Margin = new System.Windows.Forms.Padding(4);
            this.btnAlterar.Name = "btnAlterar";
            this.btnAlterar.Size = new System.Drawing.Size(100, 28);
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
            this.btnCadastroGrupo.Location = new System.Drawing.Point(1177, 112);
            this.btnCadastroGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.btnCadastroGrupo.Name = "btnCadastroGrupo";
            this.btnCadastroGrupo.Size = new System.Drawing.Size(29, 28);
            this.btnCadastroGrupo.TabIndex = 33;
            this.btnCadastroGrupo.UseVisualStyleBackColor = true;
            this.btnCadastroGrupo.Click += new System.EventHandler(this.btnCadastroGrupo_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(1108, 472);
            this.btnSalvar.Margin = new System.Windows.Forms.Padding(4);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(100, 28);
            this.btnSalvar.TabIndex = 32;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(676, 122);
            this.label8.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(47, 16);
            this.label8.TabIndex = 31;
            this.label8.Text = "Grupo:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 70);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Código:";
            // 
            // cboGrupo
            // 
            this.cboGrupo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGrupo.FormattingEnabled = true;
            this.cboGrupo.Items.AddRange(new object[] {
            ""});
            this.cboGrupo.Location = new System.Drawing.Point(736, 111);
            this.cboGrupo.Margin = new System.Windows.Forms.Padding(4);
            this.cboGrupo.Name = "cboGrupo";
            this.cboGrupo.Size = new System.Drawing.Size(432, 24);
            this.cboGrupo.TabIndex = 4;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(19, 225);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(80, 16);
            this.label7.TabIndex = 29;
            this.label7.Text = "Fornecedor:";
            // 
            // txtFornecedor
            // 
            this.txtFornecedor.Location = new System.Drawing.Point(117, 217);
            this.txtFornecedor.Margin = new System.Windows.Forms.Padding(4);
            this.txtFornecedor.Name = "txtFornecedor";
            this.txtFornecedor.Size = new System.Drawing.Size(283, 22);
            this.txtFornecedor.TabIndex = 8;
            // 
            // txtEstoqueMaximo
            // 
            this.txtEstoqueMaximo.Location = new System.Drawing.Point(321, 170);
            this.txtEstoqueMaximo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstoqueMaximo.Name = "txtEstoqueMaximo";
            this.txtEstoqueMaximo.Size = new System.Drawing.Size(79, 22);
            this.txtEstoqueMaximo.TabIndex = 6;
            this.txtEstoqueMaximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueMaximo_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 178);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(89, 16);
            this.label6.TabIndex = 26;
            this.label6.Text = "Estoque/Max.";
            // 
            // txtEstoqueMinimo
            // 
            this.txtEstoqueMinimo.Location = new System.Drawing.Point(117, 170);
            this.txtEstoqueMinimo.Margin = new System.Windows.Forms.Padding(4);
            this.txtEstoqueMinimo.Name = "txtEstoqueMinimo";
            this.txtEstoqueMinimo.Size = new System.Drawing.Size(79, 22);
            this.txtEstoqueMinimo.TabIndex = 5;
            this.txtEstoqueMinimo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtEstoqueMinimo_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(15, 178);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(85, 16);
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
            this.cboUnidade.Location = new System.Drawing.Point(573, 112);
            this.cboUnidade.Margin = new System.Windows.Forms.Padding(4);
            this.cboUnidade.Name = "cboUnidade";
            this.cboUnidade.Size = new System.Drawing.Size(76, 24);
            this.cboUnidade.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(499, 121);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 16);
            this.label4.TabIndex = 22;
            this.label4.Text = "Unidade:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(15, 116);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 21;
            this.label3.Text = "Descrição:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(15, 26);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 16);
            this.label1.TabIndex = 20;
            this.label1.Text = "Código Ref:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(117, 112);
            this.txtDescricao.Margin = new System.Windows.Forms.Padding(4);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(359, 22);
            this.txtDescricao.TabIndex = 2;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(117, 62);
            this.txtCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(132, 22);
            this.txtCodigo.TabIndex = 1;
            // 
            // txtCodigoReferencia
            // 
            this.txtCodigoReferencia.Location = new System.Drawing.Point(117, 17);
            this.txtCodigoReferencia.Margin = new System.Windows.Forms.Padding(4);
            this.txtCodigoReferencia.Name = "txtCodigoReferencia";
            this.txtCodigoReferencia.Size = new System.Drawing.Size(132, 22);
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
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4);
            this.tabPage2.Size = new System.Drawing.Size(1322, 511);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Histórico";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // btnExportar
            // 
            this.btnExportar.Enabled = false;
            this.btnExportar.Location = new System.Drawing.Point(1169, 86);
            this.btnExportar.Margin = new System.Windows.Forms.Padding(4);
            this.btnExportar.Name = "btnExportar";
            this.btnExportar.Size = new System.Drawing.Size(100, 28);
            this.btnExportar.TabIndex = 6;
            this.btnExportar.Text = "Exportar";
            this.btnExportar.UseVisualStyleBackColor = true;
            // 
            // btnInserir
            // 
            this.btnInserir.Enabled = false;
            this.btnInserir.Location = new System.Drawing.Point(1053, 86);
            this.btnInserir.Margin = new System.Windows.Forms.Padding(4);
            this.btnInserir.Name = "btnInserir";
            this.btnInserir.Size = new System.Drawing.Size(100, 28);
            this.btnInserir.TabIndex = 5;
            this.btnInserir.Text = "Inserir";
            this.btnInserir.UseVisualStyleBackColor = true;
            this.btnInserir.Click += new System.EventHandler(this.btnInserir_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(108, 66);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(513, 22);
            this.textBox1.TabIndex = 4;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(19, 75);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(75, 16);
            this.label11.TabIndex = 3;
            this.label11.Text = "Buscar por:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 41);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(39, 16);
            this.label10.TabIndex = 2;
            this.label10.Text = "Filtro:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(108, 31);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(217, 24);
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
            this.dataGridView2.ColumnHeadersHeight = 29;
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
            this.dataGridView2.Location = new System.Drawing.Point(9, 122);
            this.dataGridView2.Margin = new System.Windows.Forms.Padding(4);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidth = 51;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(1260, 348);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            this.dataGridView2.CellStyleChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellStyleChanged);
            // 
            // clnNumeroMovimentacao
            // 
            this.clnNumeroMovimentacao.DataPropertyName = "Codigo";
            this.clnNumeroMovimentacao.HeaderText = "Nº/Mov.";
            this.clnNumeroMovimentacao.MinimumWidth = 6;
            this.clnNumeroMovimentacao.Name = "clnNumeroMovimentacao";
            this.clnNumeroMovimentacao.ReadOnly = true;
            this.clnNumeroMovimentacao.Width = 125;
            // 
            // clnCodigoMaterial
            // 
            this.clnCodigoMaterial.DataPropertyName = "CodProd";
            this.clnCodigoMaterial.HeaderText = "Código";
            this.clnCodigoMaterial.MinimumWidth = 6;
            this.clnCodigoMaterial.Name = "clnCodigoMaterial";
            this.clnCodigoMaterial.ReadOnly = true;
            this.clnCodigoMaterial.Visible = false;
            this.clnCodigoMaterial.Width = 125;
            // 
            // clnDescricaoMaterial
            // 
            this.clnDescricaoMaterial.DataPropertyName = "Descricao";
            this.clnDescricaoMaterial.HeaderText = "Descrição";
            this.clnDescricaoMaterial.MinimumWidth = 6;
            this.clnDescricaoMaterial.Name = "clnDescricaoMaterial";
            this.clnDescricaoMaterial.ReadOnly = true;
            this.clnDescricaoMaterial.Visible = false;
            this.clnDescricaoMaterial.Width = 125;
            // 
            // clnLote
            // 
            this.clnLote.DataPropertyName = "Lote";
            this.clnLote.HeaderText = "Lote";
            this.clnLote.MinimumWidth = 6;
            this.clnLote.Name = "clnLote";
            this.clnLote.ReadOnly = true;
            this.clnLote.Visible = false;
            this.clnLote.Width = 125;
            // 
            // clnMovimento
            // 
            this.clnMovimento.DataPropertyName = "Movimento";
            this.clnMovimento.HeaderText = "Tipo/Mov.";
            this.clnMovimento.MinimumWidth = 6;
            this.clnMovimento.Name = "clnMovimento";
            this.clnMovimento.ReadOnly = true;
            this.clnMovimento.Width = 120;
            // 
            // clnData
            // 
            this.clnData.DataPropertyName = "Data";
            this.clnData.HeaderText = "Data/Mov.";
            this.clnData.MinimumWidth = 6;
            this.clnData.Name = "clnData";
            this.clnData.ReadOnly = true;
            this.clnData.Width = 120;
            // 
            // clnQuantidade
            // 
            this.clnQuantidade.DataPropertyName = "Quantidade";
            this.clnQuantidade.HeaderText = "Quantidade";
            this.clnQuantidade.MinimumWidth = 6;
            this.clnQuantidade.Name = "clnQuantidade";
            this.clnQuantidade.ReadOnly = true;
            this.clnQuantidade.Visible = false;
            this.clnQuantidade.Width = 125;
            // 
            // clnQuantidadeBobinas
            // 
            this.clnQuantidadeBobinas.DataPropertyName = "QtdBobinas";
            this.clnQuantidadeBobinas.HeaderText = "QT.Bobinas";
            this.clnQuantidadeBobinas.MinimumWidth = 6;
            this.clnQuantidadeBobinas.Name = "clnQuantidadeBobinas";
            this.clnQuantidadeBobinas.ReadOnly = true;
            this.clnQuantidadeBobinas.Visible = false;
            this.clnQuantidadeBobinas.Width = 125;
            // 
            // clnOperacao
            // 
            this.clnOperacao.DataPropertyName = "Operacao";
            this.clnOperacao.HeaderText = "Operação";
            this.clnOperacao.MinimumWidth = 6;
            this.clnOperacao.Name = "clnOperacao";
            this.clnOperacao.ReadOnly = true;
            this.clnOperacao.Width = 210;
            // 
            // clnDocumento
            // 
            this.clnDocumento.DataPropertyName = "Documento";
            this.clnDocumento.HeaderText = "Documento";
            this.clnDocumento.MinimumWidth = 6;
            this.clnDocumento.Name = "clnDocumento";
            this.clnDocumento.ReadOnly = true;
            this.clnDocumento.Visible = false;
            this.clnDocumento.Width = 125;
            // 
            // clnObervacao
            // 
            this.clnObervacao.DataPropertyName = "Observacoes";
            this.clnObervacao.HeaderText = "Quantidade";
            this.clnObervacao.MinimumWidth = 6;
            this.clnObervacao.Name = "clnObervacao";
            this.clnObervacao.ReadOnly = true;
            this.clnObervacao.Width = 125;
            // 
            // clnUsuarioMovimentacao
            // 
            this.clnUsuarioMovimentacao.DataPropertyName = "Usuario";
            this.clnUsuarioMovimentacao.HeaderText = "Usuário";
            this.clnUsuarioMovimentacao.MinimumWidth = 6;
            this.clnUsuarioMovimentacao.Name = "clnUsuarioMovimentacao";
            this.clnUsuarioMovimentacao.ReadOnly = true;
            this.clnUsuarioMovimentacao.Width = 120;
            // 
            // clnBase
            // 
            this.clnBase.DataPropertyName = "Base";
            this.clnBase.HeaderText = "Base";
            this.clnBase.MinimumWidth = 6;
            this.clnBase.Name = "clnBase";
            this.clnBase.ReadOnly = true;
            this.clnBase.Visible = false;
            this.clnBase.Width = 125;
            // 
            // clnFornecedorMovimentado
            // 
            this.clnFornecedorMovimentado.DataPropertyName = "Fornecedor";
            this.clnFornecedorMovimentado.HeaderText = "Fornecedor";
            this.clnFornecedorMovimentado.MinimumWidth = 6;
            this.clnFornecedorMovimentado.Name = "clnFornecedorMovimentado";
            this.clnFornecedorMovimentado.ReadOnly = true;
            this.clnFornecedorMovimentado.Visible = false;
            this.clnFornecedorMovimentado.Width = 125;
            // 
            // frmEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1332, 800);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstoqueMaximo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstoqueMinimo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstoqueSeguranca;
        private System.Windows.Forms.Button btnRelatorio;
    }
}