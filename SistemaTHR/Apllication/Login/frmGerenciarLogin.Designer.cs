namespace SistemaTHR.Apllication
{
    partial class frmGerenciarLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGerenciarLogin));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnUsuario = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmpilhadeiras = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRecebimento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnExpedicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAdm = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnManutencao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEmpNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRecebNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnExpNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAdmNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnManutencaoNivel = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.panel1 = new System.Windows.Forms.Panel();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboProducao = new System.Windows.Forms.ComboBox();
            this.rdbProducaoNao = new System.Windows.Forms.RadioButton();
            this.rdbProducaoSim = new System.Windows.Forms.RadioButton();
            this.button1 = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cboManutencao = new System.Windows.Forms.ComboBox();
            this.rdbManutencaoNao = new System.Windows.Forms.RadioButton();
            this.rdbManutencaoSim = new System.Windows.Forms.RadioButton();
            this.grpAdm = new System.Windows.Forms.GroupBox();
            this.cboAdm = new System.Windows.Forms.ComboBox();
            this.rbAdmNao = new System.Windows.Forms.RadioButton();
            this.rbAdmSim = new System.Windows.Forms.RadioButton();
            this.grpExpedicao = new System.Windows.Forms.GroupBox();
            this.cboExp = new System.Windows.Forms.ComboBox();
            this.rbExpNao = new System.Windows.Forms.RadioButton();
            this.rbExpSim = new System.Windows.Forms.RadioButton();
            this.grpRecebimento = new System.Windows.Forms.GroupBox();
            this.cboReceb = new System.Windows.Forms.ComboBox();
            this.rbRecebeNao = new System.Windows.Forms.RadioButton();
            this.rbEmpRecebSim = new System.Windows.Forms.RadioButton();
            this.txtSenha = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.grpEmpilhadeiras = new System.Windows.Forms.GroupBox();
            this.cboEmp = new System.Windows.Forms.ComboBox();
            this.rbEmpNao = new System.Windows.Forms.RadioButton();
            this.rbEmpSim = new System.Windows.Forms.RadioButton();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.panel3 = new System.Windows.Forms.Panel();
            this.btnLimpar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.grpAdm.SuspendLayout();
            this.grpExpedicao.SuspendLayout();
            this.grpRecebimento.SuspendLayout();
            this.grpEmpilhadeiras.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnUsuario,
            this.clnEmpilhadeiras,
            this.clnRecebimento,
            this.clnExpedicao,
            this.clnAdm,
            this.clnManutencao,
            this.clnEmpNivel,
            this.clnRecebNivel,
            this.clnExpNivel,
            this.clnAdmNivel,
            this.clnManutencaoNivel,
            this.clnCodigo});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1043, 104);
            this.dataGridView1.TabIndex = 2;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // clnUsuario
            // 
            this.clnUsuario.DataPropertyName = "Usuario";
            this.clnUsuario.HeaderText = "Usuário";
            this.clnUsuario.Name = "clnUsuario";
            this.clnUsuario.ReadOnly = true;
            // 
            // clnEmpilhadeiras
            // 
            this.clnEmpilhadeiras.DataPropertyName = "Empilhadeiras";
            this.clnEmpilhadeiras.HeaderText = "Empilhadeira";
            this.clnEmpilhadeiras.Name = "clnEmpilhadeiras";
            this.clnEmpilhadeiras.ReadOnly = true;
            // 
            // clnRecebimento
            // 
            this.clnRecebimento.DataPropertyName = "Recebimento";
            this.clnRecebimento.HeaderText = "Recebimento";
            this.clnRecebimento.Name = "clnRecebimento";
            this.clnRecebimento.ReadOnly = true;
            // 
            // clnExpedicao
            // 
            this.clnExpedicao.DataPropertyName = "Expedicao";
            this.clnExpedicao.HeaderText = "Expedição";
            this.clnExpedicao.Name = "clnExpedicao";
            this.clnExpedicao.ReadOnly = true;
            // 
            // clnAdm
            // 
            this.clnAdm.DataPropertyName = "Adm";
            this.clnAdm.HeaderText = "Administrativo";
            this.clnAdm.Name = "clnAdm";
            this.clnAdm.ReadOnly = true;
            // 
            // clnManutencao
            // 
            this.clnManutencao.DataPropertyName = "Manutencao";
            this.clnManutencao.HeaderText = "Manutenção";
            this.clnManutencao.Name = "clnManutencao";
            this.clnManutencao.ReadOnly = true;
            // 
            // clnEmpNivel
            // 
            this.clnEmpNivel.DataPropertyName = "EmpNivel";
            this.clnEmpNivel.HeaderText = "EmpNivel";
            this.clnEmpNivel.Name = "clnEmpNivel";
            this.clnEmpNivel.ReadOnly = true;
            this.clnEmpNivel.Visible = false;
            // 
            // clnRecebNivel
            // 
            this.clnRecebNivel.DataPropertyName = "RecebNivel";
            this.clnRecebNivel.HeaderText = "RecebNivel";
            this.clnRecebNivel.Name = "clnRecebNivel";
            this.clnRecebNivel.ReadOnly = true;
            this.clnRecebNivel.Visible = false;
            // 
            // clnExpNivel
            // 
            this.clnExpNivel.DataPropertyName = "expNivel";
            this.clnExpNivel.HeaderText = "ExpNivel";
            this.clnExpNivel.Name = "clnExpNivel";
            this.clnExpNivel.ReadOnly = true;
            this.clnExpNivel.Visible = false;
            // 
            // clnAdmNivel
            // 
            this.clnAdmNivel.DataPropertyName = "admNivel";
            this.clnAdmNivel.HeaderText = "AdmNivel";
            this.clnAdmNivel.Name = "clnAdmNivel";
            this.clnAdmNivel.ReadOnly = true;
            this.clnAdmNivel.Visible = false;
            // 
            // clnManutencaoNivel
            // 
            this.clnManutencaoNivel.DataPropertyName = "manutencaoNivel";
            this.clnManutencaoNivel.HeaderText = "Manutenção Nivel";
            this.clnManutencaoNivel.Name = "clnManutencaoNivel";
            this.clnManutencaoNivel.ReadOnly = true;
            this.clnManutencaoNivel.Visible = false;
            // 
            // clnCodigo
            // 
            this.clnCodigo.DataPropertyName = "Código";
            this.clnCodigo.HeaderText = "Codigo";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            this.clnCodigo.Visible = false;
            // 
            // splitContainer1
            // 
            this.splitContainer1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.splitContainer1.AllowDrop = true;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 25);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.AllowDrop = true;
            this.splitContainer1.Panel1.AutoScroll = true;
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.statusStrip1);
            this.splitContainer1.Panel2.Controls.Add(this.panel1);
            this.splitContainer1.Size = new System.Drawing.Size(1043, 463);
            this.splitContainer1.SplitterDistance = 104;
            this.splitContainer1.TabIndex = 10;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 333);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1043, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // panel1
            // 
            this.panel1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.panel1.AutoScroll = true;
            this.panel1.AutoScrollMargin = new System.Drawing.Size(40, 40);
            this.panel1.Controls.Add(this.groupBox2);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.btnExcluir);
            this.panel1.Controls.Add(this.txtNome);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.groupBox1);
            this.panel1.Controls.Add(this.grpAdm);
            this.panel1.Controls.Add(this.grpExpedicao);
            this.panel1.Controls.Add(this.grpRecebimento);
            this.panel1.Controls.Add(this.txtSenha);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.grpEmpilhadeiras);
            this.panel1.Controls.Add(this.txtUsuario);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btnSalvar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1043, 355);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.cboProducao);
            this.groupBox2.Controls.Add(this.rdbProducaoNao);
            this.groupBox2.Controls.Add(this.rdbProducaoSim);
            this.groupBox2.Location = new System.Drawing.Point(719, 132);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(227, 59);
            this.groupBox2.TabIndex = 14;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Produção";
            // 
            // cboProducao
            // 
            this.cboProducao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProducao.FormattingEnabled = true;
            this.cboProducao.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4"});
            this.cboProducao.Location = new System.Drawing.Point(144, 19);
            this.cboProducao.Name = "cboProducao";
            this.cboProducao.Size = new System.Drawing.Size(77, 21);
            this.cboProducao.TabIndex = 4;
            // 
            // rdbProducaoNao
            // 
            this.rdbProducaoNao.AutoSize = true;
            this.rdbProducaoNao.Location = new System.Drawing.Point(55, 19);
            this.rdbProducaoNao.Name = "rdbProducaoNao";
            this.rdbProducaoNao.Size = new System.Drawing.Size(45, 17);
            this.rdbProducaoNao.TabIndex = 1;
            this.rdbProducaoNao.TabStop = true;
            this.rdbProducaoNao.Text = "Não";
            this.rdbProducaoNao.UseVisualStyleBackColor = true;
            // 
            // rdbProducaoSim
            // 
            this.rdbProducaoSim.AutoSize = true;
            this.rdbProducaoSim.Location = new System.Drawing.Point(7, 20);
            this.rdbProducaoSim.Name = "rdbProducaoSim";
            this.rdbProducaoSim.Size = new System.Drawing.Size(42, 17);
            this.rdbProducaoSim.TabIndex = 0;
            this.rdbProducaoSim.TabStop = true;
            this.rdbProducaoSim.Text = "Sim";
            this.rdbProducaoSim.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.ForeColor = System.Drawing.SystemColors.Control;
            this.button1.Image = global::SistemaTHR.Properties.Resources.show;
            this.button1.Location = new System.Drawing.Point(163, 123);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(21, 19);
            this.button1.TabIndex = 19;
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnExcluir
            // 
            this.btnExcluir.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnExcluir.Location = new System.Drawing.Point(930, 272);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 18;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            this.btnExcluir.Click += new System.EventHandler(this.btnExcluir_Click);
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(57, 86);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(5, 93);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(38, 13);
            this.label3.TabIndex = 15;
            this.label3.Text = "Nome:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.cboManutencao);
            this.groupBox1.Controls.Add(this.rdbManutencaoNao);
            this.groupBox1.Controls.Add(this.rdbManutencaoSim);
            this.groupBox1.Location = new System.Drawing.Point(453, 132);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(227, 59);
            this.groupBox1.TabIndex = 13;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manutenção";
            // 
            // cboManutencao
            // 
            this.cboManutencao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboManutencao.FormattingEnabled = true;
            this.cboManutencao.Items.AddRange(new object[] {
            "",
            "1",
            "2",
            "3",
            "4"});
            this.cboManutencao.Location = new System.Drawing.Point(144, 19);
            this.cboManutencao.Name = "cboManutencao";
            this.cboManutencao.Size = new System.Drawing.Size(77, 21);
            this.cboManutencao.TabIndex = 4;
            // 
            // rdbManutencaoNao
            // 
            this.rdbManutencaoNao.AutoSize = true;
            this.rdbManutencaoNao.Location = new System.Drawing.Point(55, 19);
            this.rdbManutencaoNao.Name = "rdbManutencaoNao";
            this.rdbManutencaoNao.Size = new System.Drawing.Size(45, 17);
            this.rdbManutencaoNao.TabIndex = 1;
            this.rdbManutencaoNao.TabStop = true;
            this.rdbManutencaoNao.Text = "Não";
            this.rdbManutencaoNao.UseVisualStyleBackColor = true;
            this.rdbManutencaoNao.CheckedChanged += new System.EventHandler(this.rdbManutencaoNao_CheckedChanged);
            // 
            // rdbManutencaoSim
            // 
            this.rdbManutencaoSim.AutoSize = true;
            this.rdbManutencaoSim.Location = new System.Drawing.Point(7, 20);
            this.rdbManutencaoSim.Name = "rdbManutencaoSim";
            this.rdbManutencaoSim.Size = new System.Drawing.Size(42, 17);
            this.rdbManutencaoSim.TabIndex = 0;
            this.rdbManutencaoSim.TabStop = true;
            this.rdbManutencaoSim.Text = "Sim";
            this.rdbManutencaoSim.UseVisualStyleBackColor = true;
            this.rdbManutencaoSim.Click += new System.EventHandler(this.rdbManutencaoSim_Click);
            // 
            // grpAdm
            // 
            this.grpAdm.BackColor = System.Drawing.Color.White;
            this.grpAdm.Controls.Add(this.cboAdm);
            this.grpAdm.Controls.Add(this.rbAdmNao);
            this.grpAdm.Controls.Add(this.rbAdmSim);
            this.grpAdm.Location = new System.Drawing.Point(199, 132);
            this.grpAdm.Name = "grpAdm";
            this.grpAdm.Size = new System.Drawing.Size(227, 59);
            this.grpAdm.TabIndex = 12;
            this.grpAdm.TabStop = false;
            this.grpAdm.Text = "Administrativo";
            // 
            // cboAdm
            // 
            this.cboAdm.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAdm.FormattingEnabled = true;
            this.cboAdm.Items.AddRange(new object[] {
            "",
            "1",
            "2"});
            this.cboAdm.Location = new System.Drawing.Point(144, 19);
            this.cboAdm.Name = "cboAdm";
            this.cboAdm.Size = new System.Drawing.Size(77, 21);
            this.cboAdm.TabIndex = 4;
            // 
            // rbAdmNao
            // 
            this.rbAdmNao.AutoSize = true;
            this.rbAdmNao.Location = new System.Drawing.Point(55, 19);
            this.rbAdmNao.Name = "rbAdmNao";
            this.rbAdmNao.Size = new System.Drawing.Size(45, 17);
            this.rbAdmNao.TabIndex = 1;
            this.rbAdmNao.TabStop = true;
            this.rbAdmNao.Text = "Não";
            this.rbAdmNao.UseVisualStyleBackColor = true;
            this.rbAdmNao.Click += new System.EventHandler(this.rbAdmNao_Click);
            // 
            // rbAdmSim
            // 
            this.rbAdmSim.AutoSize = true;
            this.rbAdmSim.Location = new System.Drawing.Point(7, 20);
            this.rbAdmSim.Name = "rbAdmSim";
            this.rbAdmSim.Size = new System.Drawing.Size(42, 17);
            this.rbAdmSim.TabIndex = 0;
            this.rbAdmSim.TabStop = true;
            this.rbAdmSim.Text = "Sim";
            this.rbAdmSim.UseVisualStyleBackColor = true;
            this.rbAdmSim.Click += new System.EventHandler(this.rbAdmSim_Click);
            // 
            // grpExpedicao
            // 
            this.grpExpedicao.BackColor = System.Drawing.Color.White;
            this.grpExpedicao.Controls.Add(this.cboExp);
            this.grpExpedicao.Controls.Add(this.rbExpNao);
            this.grpExpedicao.Controls.Add(this.rbExpSim);
            this.grpExpedicao.Location = new System.Drawing.Point(712, 46);
            this.grpExpedicao.Name = "grpExpedicao";
            this.grpExpedicao.Size = new System.Drawing.Size(227, 59);
            this.grpExpedicao.TabIndex = 10;
            this.grpExpedicao.TabStop = false;
            this.grpExpedicao.Text = "Expedição";
            // 
            // cboExp
            // 
            this.cboExp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboExp.FormattingEnabled = true;
            this.cboExp.Items.AddRange(new object[] {
            "",
            "1",
            "2"});
            this.cboExp.Location = new System.Drawing.Point(144, 19);
            this.cboExp.Name = "cboExp";
            this.cboExp.Size = new System.Drawing.Size(77, 21);
            this.cboExp.TabIndex = 4;
            // 
            // rbExpNao
            // 
            this.rbExpNao.AutoSize = true;
            this.rbExpNao.Location = new System.Drawing.Point(55, 19);
            this.rbExpNao.Name = "rbExpNao";
            this.rbExpNao.Size = new System.Drawing.Size(45, 17);
            this.rbExpNao.TabIndex = 1;
            this.rbExpNao.TabStop = true;
            this.rbExpNao.Text = "Não";
            this.rbExpNao.UseVisualStyleBackColor = true;
            this.rbExpNao.CheckedChanged += new System.EventHandler(this.rbExpNao_CheckedChanged);
            this.rbExpNao.Click += new System.EventHandler(this.rbExpNao_Click);
            // 
            // rbExpSim
            // 
            this.rbExpSim.AutoSize = true;
            this.rbExpSim.Location = new System.Drawing.Point(7, 20);
            this.rbExpSim.Name = "rbExpSim";
            this.rbExpSim.Size = new System.Drawing.Size(42, 17);
            this.rbExpSim.TabIndex = 0;
            this.rbExpSim.TabStop = true;
            this.rbExpSim.Text = "Sim";
            this.rbExpSim.UseVisualStyleBackColor = true;
            this.rbExpSim.Click += new System.EventHandler(this.rbExpSim_Click);
            // 
            // grpRecebimento
            // 
            this.grpRecebimento.BackColor = System.Drawing.Color.White;
            this.grpRecebimento.Controls.Add(this.cboReceb);
            this.grpRecebimento.Controls.Add(this.rbRecebeNao);
            this.grpRecebimento.Controls.Add(this.rbEmpRecebSim);
            this.grpRecebimento.Location = new System.Drawing.Point(453, 46);
            this.grpRecebimento.Name = "grpRecebimento";
            this.grpRecebimento.Size = new System.Drawing.Size(227, 59);
            this.grpRecebimento.TabIndex = 11;
            this.grpRecebimento.TabStop = false;
            this.grpRecebimento.Text = "Recebimento";
            // 
            // cboReceb
            // 
            this.cboReceb.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboReceb.FormattingEnabled = true;
            this.cboReceb.Items.AddRange(new object[] {
            "",
            "1",
            "2"});
            this.cboReceb.Location = new System.Drawing.Point(144, 19);
            this.cboReceb.Name = "cboReceb";
            this.cboReceb.Size = new System.Drawing.Size(77, 21);
            this.cboReceb.TabIndex = 3;
            // 
            // rbRecebeNao
            // 
            this.rbRecebeNao.AutoSize = true;
            this.rbRecebeNao.Location = new System.Drawing.Point(55, 19);
            this.rbRecebeNao.Name = "rbRecebeNao";
            this.rbRecebeNao.Size = new System.Drawing.Size(45, 17);
            this.rbRecebeNao.TabIndex = 1;
            this.rbRecebeNao.TabStop = true;
            this.rbRecebeNao.Text = "Não";
            this.rbRecebeNao.UseVisualStyleBackColor = true;
            this.rbRecebeNao.Click += new System.EventHandler(this.rbRecebeNao_Click);
            // 
            // rbEmpRecebSim
            // 
            this.rbEmpRecebSim.AutoSize = true;
            this.rbEmpRecebSim.Location = new System.Drawing.Point(7, 20);
            this.rbEmpRecebSim.Name = "rbEmpRecebSim";
            this.rbEmpRecebSim.Size = new System.Drawing.Size(42, 17);
            this.rbEmpRecebSim.TabIndex = 0;
            this.rbEmpRecebSim.TabStop = true;
            this.rbEmpRecebSim.Text = "Sim";
            this.rbEmpRecebSim.UseVisualStyleBackColor = true;
            this.rbEmpRecebSim.Click += new System.EventHandler(this.rbEmpRecebSim_Click);
            // 
            // txtSenha
            // 
            this.txtSenha.Location = new System.Drawing.Point(57, 122);
            this.txtSenha.Name = "txtSenha";
            this.txtSenha.PasswordChar = '•';
            this.txtSenha.Size = new System.Drawing.Size(100, 20);
            this.txtSenha.TabIndex = 14;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(5, 129);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(41, 13);
            this.label2.TabIndex = 13;
            this.label2.Text = "Senha:";
            // 
            // grpEmpilhadeiras
            // 
            this.grpEmpilhadeiras.BackColor = System.Drawing.Color.White;
            this.grpEmpilhadeiras.Controls.Add(this.cboEmp);
            this.grpEmpilhadeiras.Controls.Add(this.rbEmpNao);
            this.grpEmpilhadeiras.Controls.Add(this.rbEmpSim);
            this.grpEmpilhadeiras.Location = new System.Drawing.Point(199, 46);
            this.grpEmpilhadeiras.Name = "grpEmpilhadeiras";
            this.grpEmpilhadeiras.Size = new System.Drawing.Size(227, 59);
            this.grpEmpilhadeiras.TabIndex = 9;
            this.grpEmpilhadeiras.TabStop = false;
            this.grpEmpilhadeiras.Text = "Empilhadeiras";
            // 
            // cboEmp
            // 
            this.cboEmp.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEmp.FormattingEnabled = true;
            this.cboEmp.Items.AddRange(new object[] {
            "",
            "1",
            "2"});
            this.cboEmp.Location = new System.Drawing.Point(144, 18);
            this.cboEmp.Name = "cboEmp";
            this.cboEmp.Size = new System.Drawing.Size(77, 21);
            this.cboEmp.TabIndex = 2;
            // 
            // rbEmpNao
            // 
            this.rbEmpNao.AutoSize = true;
            this.rbEmpNao.Location = new System.Drawing.Point(55, 19);
            this.rbEmpNao.Name = "rbEmpNao";
            this.rbEmpNao.Size = new System.Drawing.Size(45, 17);
            this.rbEmpNao.TabIndex = 1;
            this.rbEmpNao.TabStop = true;
            this.rbEmpNao.Text = "Não";
            this.rbEmpNao.UseVisualStyleBackColor = true;
            this.rbEmpNao.CheckedChanged += new System.EventHandler(this.rbEmpNao_CheckedChanged_2);
            this.rbEmpNao.Click += new System.EventHandler(this.rbEmpNao_Click);
            // 
            // rbEmpSim
            // 
            this.rbEmpSim.AutoSize = true;
            this.rbEmpSim.Location = new System.Drawing.Point(7, 20);
            this.rbEmpSim.Name = "rbEmpSim";
            this.rbEmpSim.Size = new System.Drawing.Size(42, 17);
            this.rbEmpSim.TabIndex = 0;
            this.rbEmpSim.TabStop = true;
            this.rbEmpSim.Text = "Sim";
            this.rbEmpSim.UseVisualStyleBackColor = true;
            this.rbEmpSim.Click += new System.EventHandler(this.rbEmpSim_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(57, 50);
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(100, 20);
            this.txtUsuario.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(5, 57);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Usuário:";
            // 
            // btnSalvar
            // 
            this.btnSalvar.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.btnSalvar.Location = new System.Drawing.Point(849, 272);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 17;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click_1);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.btnLimpar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1043, 25);
            this.panel3.TabIndex = 11;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
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
            // frmGerenciarLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1043, 488);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGerenciarLogin";
            this.Text = "Gerenciar Login";
            this.Load += new System.EventHandler(this.frmGerenciarLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpAdm.ResumeLayout(false);
            this.grpAdm.PerformLayout();
            this.grpExpedicao.ResumeLayout(false);
            this.grpExpedicao.PerformLayout();
            this.grpRecebimento.ResumeLayout(false);
            this.grpRecebimento.PerformLayout();
            this.grpEmpilhadeiras.ResumeLayout(false);
            this.grpEmpilhadeiras.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        public System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox grpAdm;
        private System.Windows.Forms.ComboBox cboAdm;
        private System.Windows.Forms.RadioButton rbAdmNao;
        private System.Windows.Forms.RadioButton rbAdmSim;
        private System.Windows.Forms.GroupBox grpExpedicao;
        private System.Windows.Forms.ComboBox cboExp;
        private System.Windows.Forms.RadioButton rbExpNao;
        private System.Windows.Forms.RadioButton rbExpSim;
        private System.Windows.Forms.GroupBox grpRecebimento;
        private System.Windows.Forms.ComboBox cboReceb;
        private System.Windows.Forms.RadioButton rbRecebeNao;
        private System.Windows.Forms.RadioButton rbEmpRecebSim;
        private System.Windows.Forms.TextBox txtSenha;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox grpEmpilhadeiras;
        private System.Windows.Forms.ComboBox cboEmp;
        private System.Windows.Forms.RadioButton rbEmpNao;
        private System.Windows.Forms.RadioButton rbEmpSim;
        private System.Windows.Forms.TextBox txtUsuario;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cboManutencao;
        private System.Windows.Forms.RadioButton rdbManutencaoNao;
        private System.Windows.Forms.RadioButton rdbManutencaoSim;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmpilhadeiras;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRecebimento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnExpedicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAdm;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnManutencao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEmpNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRecebNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnExpNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAdmNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnManutencaoNivel;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ComboBox cboProducao;
        private System.Windows.Forms.RadioButton rdbProducaoNao;
        private System.Windows.Forms.RadioButton rdbProducaoSim;
    }
}