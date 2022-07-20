namespace SistemaTHR.Apllication
{
    partial class frmManutencao
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmManutencao));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnCompra = new System.Windows.Forms.Button();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clNOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTipoServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataHoraGeracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsuarioSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioPrioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraPrioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataIdeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnObservaco = new System.Windows.Forms.Button();
            this.btnDesfazer = new System.Windows.Forms.Button();
            this.btnApontar = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.txtObservacao = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraApontamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsuarioApontamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsuarioAlteracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cboPrioridade = new System.Windows.Forms.ComboBox();
            this.txtOrdemServico = new System.Windows.Forms.TextBox();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.BtnSalvar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 690);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1337, 22);
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
            this.lblUsuario.Size = new System.Drawing.Size(118, 17);
            this.lblUsuario.Text = "toolStripStatusLabel2";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnCompra);
            this.panel1.Controls.Add(this.btnFiltrar);
            this.panel1.Controls.Add(this.btnLimpar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1337, 25);
            this.panel1.TabIndex = 1;
            // 
            // btnCompra
            // 
            this.btnCompra.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCompra.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCompra.ForeColor = System.Drawing.SystemColors.Control;
            this.btnCompra.Image = global::SistemaTHR.Properties.Resources.order;
            this.btnCompra.Location = new System.Drawing.Point(56, 0);
            this.btnCompra.Name = "btnCompra";
            this.btnCompra.Size = new System.Drawing.Size(28, 25);
            this.btnCompra.TabIndex = 2;
            this.btnCompra.UseVisualStyleBackColor = true;
            this.btnCompra.Click += new System.EventHandler(this.btnCompra_Click);
            this.btnCompra.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnCompra_MouseMove);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFiltrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltrar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFiltrar.Image = global::SistemaTHR.Properties.Resources.filtro__1_;
            this.btnFiltrar.Location = new System.Drawing.Point(28, 0);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(28, 25);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            this.btnFiltrar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnFiltrar_MouseMove);
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
            this.btnLimpar.TabIndex = 0;
            this.btnLimpar.Text = "button1";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            this.btnLimpar.MouseMove += new System.Windows.Forms.MouseEventHandler(this.btnLimpar_MouseMove);
            // 
            // splitContainer1
            // 
            this.splitContainer1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            this.splitContainer1.Panel1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.AutoScroll = true;
            this.splitContainer1.Panel2.Controls.Add(this.groupBox1);
            this.splitContainer1.Panel2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.splitContainer1.Panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer1_Panel2_Paint);
            this.splitContainer1.Size = new System.Drawing.Size(1337, 629);
            this.splitContainer1.SplitterDistance = 187;
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
            this.clNOP,
            this.clTipoServico,
            this.clDataHoraGeracao,
            this.clUsuarioSolicitacao,
            this.clnASE,
            this.clPrioridade,
            this.clnUsuarioPrioridade,
            this.clnDataHoraPrioridade,
            this.clStatus,
            this.clnDataIdeal});
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
            this.dataGridView1.Size = new System.Drawing.Size(1333, 183);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            this.dataGridView1.KeyDown += new System.Windows.Forms.KeyEventHandler(this.dataGridView1_KeyDown);
            // 
            // clNOP
            // 
            this.clNOP.DataPropertyName = "NOP";
            this.clNOP.HeaderText = "Nº Ordem/Serviço";
            this.clNOP.Name = "clNOP";
            this.clNOP.ReadOnly = true;
            this.clNOP.Width = 150;
            // 
            // clTipoServico
            // 
            this.clTipoServico.DataPropertyName = "TipoServico";
            this.clTipoServico.HeaderText = "Tipo de Serviço";
            this.clTipoServico.Name = "clTipoServico";
            this.clTipoServico.ReadOnly = true;
            this.clTipoServico.Width = 130;
            // 
            // clDataHoraGeracao
            // 
            this.clDataHoraGeracao.DataPropertyName = "dataHoraGeracao";
            this.clDataHoraGeracao.HeaderText = "Data/Hora Geração";
            this.clDataHoraGeracao.Name = "clDataHoraGeracao";
            this.clDataHoraGeracao.ReadOnly = true;
            this.clDataHoraGeracao.Width = 220;
            // 
            // clUsuarioSolicitacao
            // 
            this.clUsuarioSolicitacao.DataPropertyName = "usuarioSolicitacao";
            this.clUsuarioSolicitacao.HeaderText = "Usuário da Solicitação";
            this.clUsuarioSolicitacao.Name = "clUsuarioSolicitacao";
            this.clUsuarioSolicitacao.ReadOnly = true;
            this.clUsuarioSolicitacao.Width = 150;
            // 
            // clnASE
            // 
            this.clnASE.DataPropertyName = "ASE";
            this.clnASE.HeaderText = "ASE";
            this.clnASE.Name = "clnASE";
            this.clnASE.ReadOnly = true;
            // 
            // clPrioridade
            // 
            this.clPrioridade.DataPropertyName = "Prioridade";
            this.clPrioridade.HeaderText = "Prioridade";
            this.clPrioridade.Name = "clPrioridade";
            this.clPrioridade.ReadOnly = true;
            this.clPrioridade.Width = 130;
            // 
            // clnUsuarioPrioridade
            // 
            this.clnUsuarioPrioridade.DataPropertyName = "UsuarioPrioridade";
            this.clnUsuarioPrioridade.HeaderText = "Usuário/Prioridade";
            this.clnUsuarioPrioridade.Name = "clnUsuarioPrioridade";
            this.clnUsuarioPrioridade.ReadOnly = true;
            // 
            // clnDataHoraPrioridade
            // 
            this.clnDataHoraPrioridade.DataPropertyName = "DataHoraPrioridade";
            this.clnDataHoraPrioridade.HeaderText = "Data/Hora Prioridade";
            this.clnDataHoraPrioridade.Name = "clnDataHoraPrioridade";
            this.clnDataHoraPrioridade.ReadOnly = true;
            // 
            // clStatus
            // 
            this.clStatus.DataPropertyName = "StatusOP";
            this.clStatus.HeaderText = "StatusOS";
            this.clStatus.Name = "clStatus";
            this.clStatus.ReadOnly = true;
            this.clStatus.Width = 130;
            // 
            // clnDataIdeal
            // 
            this.clnDataIdeal.DataPropertyName = "DataIdeal";
            this.clnDataIdeal.HeaderText = "Data Ideal";
            this.clnDataIdeal.Name = "clnDataIdeal";
            this.clnDataIdeal.ReadOnly = true;
            // 
            // groupBox1
            // 
            this.groupBox1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.groupBox1.Controls.Add(this.btnObservaco);
            this.groupBox1.Controls.Add(this.btnDesfazer);
            this.groupBox1.Controls.Add(this.btnApontar);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtObservacao);
            this.groupBox1.Controls.Add(this.panel2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboPrioridade);
            this.groupBox1.Controls.Add(this.txtOrdemServico);
            this.groupBox1.Location = new System.Drawing.Point(12, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox1.Size = new System.Drawing.Size(1311, 421);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ordem de Serviço";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnObservaco
            // 
            this.btnObservaco.Location = new System.Drawing.Point(1209, 337);
            this.btnObservaco.Name = "btnObservaco";
            this.btnObservaco.Size = new System.Drawing.Size(15, 61);
            this.btnObservaco.TabIndex = 12;
            this.btnObservaco.UseVisualStyleBackColor = true;
            this.btnObservaco.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnDesfazer
            // 
            this.btnDesfazer.Location = new System.Drawing.Point(1209, 291);
            this.btnDesfazer.Name = "btnDesfazer";
            this.btnDesfazer.Size = new System.Drawing.Size(75, 23);
            this.btnDesfazer.TabIndex = 4;
            this.btnDesfazer.Text = "Desfazer";
            this.btnDesfazer.UseVisualStyleBackColor = true;
            this.btnDesfazer.Click += new System.EventHandler(this.btnDesfazer_Click);
            // 
            // btnApontar
            // 
            this.btnApontar.Location = new System.Drawing.Point(1209, 262);
            this.btnApontar.Name = "btnApontar";
            this.btnApontar.Size = new System.Drawing.Size(75, 23);
            this.btnApontar.TabIndex = 3;
            this.btnApontar.Text = "Apontar";
            this.btnApontar.UseVisualStyleBackColor = true;
            this.btnApontar.Click += new System.EventHandler(this.btnApontar_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(467, 321);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 13);
            this.label6.TabIndex = 11;
            this.label6.Text = "Obsevação:";
            // 
            // txtObservacao
            // 
            this.txtObservacao.Location = new System.Drawing.Point(470, 337);
            this.txtObservacao.MaxLength = 1000;
            this.txtObservacao.Multiline = true;
            this.txtObservacao.Name = "txtObservacao";
            this.txtObservacao.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObservacao.Size = new System.Drawing.Size(733, 61);
            this.txtObservacao.TabIndex = 10;
            this.txtObservacao.DoubleClick += new System.EventHandler(this.txtObservacao_DoubleClick);
            this.txtObservacao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrdemServico_KeyDown);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView2);
            this.panel2.Location = new System.Drawing.Point(470, 133);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(733, 181);
            this.panel2.TabIndex = 9;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView2.AllowDrop = true;
            this.dataGridView2.AllowUserToAddRows = false;
            this.dataGridView2.AllowUserToDeleteRows = false;
            this.dataGridView2.AllowUserToOrderColumns = true;
            this.dataGridView2.AllowUserToResizeRows = false;
            this.dataGridView2.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView2.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView2.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView2.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnStatus,
            this.clnDataHoraApontamento,
            this.clUsuarioApontamento,
            this.clnDataHoraAlteracao,
            this.clUsuarioAlteracao});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(733, 181);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.TabStop = false;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            this.dataGridView2.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView2_CellFormatting);
            this.dataGridView2.SelectionChanged += new System.EventHandler(this.dataGridView2_SelectionChanged);
            this.dataGridView2.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrdemServico_KeyDown);
            // 
            // clnStatus
            // 
            this.clnStatus.DataPropertyName = "Andamento";
            this.clnStatus.HeaderText = "Situação";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            this.clnStatus.Width = 150;
            // 
            // clnDataHoraApontamento
            // 
            this.clnDataHoraApontamento.DataPropertyName = "DataHoraApontamento";
            this.clnDataHoraApontamento.HeaderText = "Data/Hora Apontamento";
            this.clnDataHoraApontamento.Name = "clnDataHoraApontamento";
            this.clnDataHoraApontamento.ReadOnly = true;
            this.clnDataHoraApontamento.Width = 150;
            // 
            // clUsuarioApontamento
            // 
            this.clUsuarioApontamento.DataPropertyName = "UsuarioApontamento";
            this.clUsuarioApontamento.HeaderText = "Usuário Apont.";
            this.clUsuarioApontamento.Name = "clUsuarioApontamento";
            this.clUsuarioApontamento.ReadOnly = true;
            // 
            // clnDataHoraAlteracao
            // 
            this.clnDataHoraAlteracao.DataPropertyName = "DataHoraAlteracao";
            this.clnDataHoraAlteracao.HeaderText = "Data/Hora Alteração";
            this.clnDataHoraAlteracao.Name = "clnDataHoraAlteracao";
            this.clnDataHoraAlteracao.ReadOnly = true;
            this.clnDataHoraAlteracao.Width = 150;
            // 
            // clUsuarioAlteracao
            // 
            this.clUsuarioAlteracao.DataPropertyName = "UsuarioAlteracao";
            this.clUsuarioAlteracao.HeaderText = "Usuário Alteração";
            this.clUsuarioAlteracao.Name = "clUsuarioAlteracao";
            this.clUsuarioAlteracao.ReadOnly = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(17, 198);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(110, 13);
            this.label4.TabIndex = 7;
            this.label4.Text = "Descrição do serviço:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.BackColor = System.Drawing.Color.White;
            this.txtDescricao.Location = new System.Drawing.Point(13, 217);
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(339, 181);
            this.txtDescricao.TabIndex = 2;
            this.txtDescricao.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrdemServico_KeyDown);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 105);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Prioridade:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Nº/Ordem de Serviço:";
            // 
            // cboPrioridade
            // 
            this.cboPrioridade.FormattingEnabled = true;
            this.cboPrioridade.Items.AddRange(new object[] {
            "Baixa",
            "Normal",
            "Alta"});
            this.cboPrioridade.Location = new System.Drawing.Point(129, 97);
            this.cboPrioridade.Name = "cboPrioridade";
            this.cboPrioridade.Size = new System.Drawing.Size(100, 21);
            this.cboPrioridade.TabIndex = 1;
            this.cboPrioridade.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrdemServico_KeyDown);
            // 
            // txtOrdemServico
            // 
            this.txtOrdemServico.Location = new System.Drawing.Point(129, 25);
            this.txtOrdemServico.Name = "txtOrdemServico";
            this.txtOrdemServico.Size = new System.Drawing.Size(100, 20);
            this.txtOrdemServico.TabIndex = 0;
            this.txtOrdemServico.TextChanged += new System.EventHandler(this.txtOrdemServico_TextChanged);
            this.txtOrdemServico.KeyDown += new System.Windows.Forms.KeyEventHandler(this.txtOrdemServico_KeyDown);
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(1250, 10);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 7;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(1175, 10);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 6;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // BtnSalvar
            // 
            this.BtnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnSalvar.Location = new System.Drawing.Point(1094, 10);
            this.BtnSalvar.Name = "BtnSalvar";
            this.BtnSalvar.Size = new System.Drawing.Size(75, 23);
            this.BtnSalvar.TabIndex = 5;
            this.BtnSalvar.Text = "Salvar";
            this.BtnSalvar.UseVisualStyleBackColor = true;
            this.BtnSalvar.Click += new System.EventHandler(this.BtnSalvar_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnImprimir);
            this.panel3.Controls.Add(this.BtnSalvar);
            this.panel3.Controls.Add(this.btnCancelar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 654);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1337, 36);
            this.panel3.TabIndex = 14;
            // 
            // frmManutencao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1337, 712);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "frmManutencao";
            this.Text = "Ordem de Serviço";
            this.Load += new System.EventHandler(this.frmManutencao_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmManutencao_KeyDown);
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmManutencao_KeyPress);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnImprimir;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button BtnSalvar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtOrdemServico;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnApontar;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraApontamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsuarioApontamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraAlteracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsuarioAlteracao;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTipoServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataHoraGeracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsuarioSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioPrioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraPrioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataIdeal;
        public System.Windows.Forms.Button btnLimpar;
        public System.Windows.Forms.Button btnCompra;
        public System.Windows.Forms.Button btnDesfazer;
        public System.Windows.Forms.ComboBox cboPrioridade;
        private System.Windows.Forms.Button btnObservaco;
        public System.Windows.Forms.TextBox txtObservacao;
    }
}