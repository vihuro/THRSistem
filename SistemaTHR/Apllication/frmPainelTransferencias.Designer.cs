namespace SistemaTHR.Apllication
{
    partial class frmPainelTransferencias
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPainelTransferencias));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnFiltro = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnImprimir = new System.Windows.Forms.Button();
            this.btnEditar = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraTransf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioTransf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdFecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoFech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricaoFech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPesoBrutoFech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPesoLiquidoFech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtBobinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnidTransfFech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdMovi = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPesoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPesoLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnBobinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdTransferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioTransferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 529);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1214, 22);
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
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.btnFiltro);
            this.panel1.Cursor = System.Windows.Forms.Cursors.Default;
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1214, 28);
            this.panel1.TabIndex = 1;
            // 
            // btnFiltro
            // 
            this.btnFiltro.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnFiltro.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFiltro.ForeColor = System.Drawing.SystemColors.Control;
            this.btnFiltro.Image = global::SistemaTHR.Properties.Resources.filtro__1_;
            this.btnFiltro.Location = new System.Drawing.Point(0, 0);
            this.btnFiltro.Name = "btnFiltro";
            this.btnFiltro.Size = new System.Drawing.Size(29, 28);
            this.btnFiltro.TabIndex = 0;
            this.btnFiltro.UseVisualStyleBackColor = true;
            this.btnFiltro.Click += new System.EventHandler(this.btnFiltro_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnImprimir);
            this.panel2.Controls.Add(this.btnEditar);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 445);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1214, 84);
            this.panel2.TabIndex = 2;
            // 
            // btnImprimir
            // 
            this.btnImprimir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnImprimir.Location = new System.Drawing.Point(1046, 58);
            this.btnImprimir.Name = "btnImprimir";
            this.btnImprimir.Size = new System.Drawing.Size(75, 23);
            this.btnImprimir.TabIndex = 1;
            this.btnImprimir.Text = "Imprimir";
            this.btnImprimir.UseVisualStyleBackColor = true;
            this.btnImprimir.Click += new System.EventHandler(this.btnImprimir_Click);
            // 
            // btnEditar
            // 
            this.btnEditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEditar.Location = new System.Drawing.Point(1127, 58);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(75, 23);
            this.btnEditar.TabIndex = 0;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
            this.splitContainer1.Name = "splitContainer1";
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(1214, 417);
            this.splitContainer1.SplitterDistance = 431;
            this.splitContainer1.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
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
            this.clnID,
            this.clnDataHoraTransf,
            this.clnUsuarioTransf});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(427, 413);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // splitContainer2
            // 
            this.splitContainer2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.Controls.Add(this.dataGridView2);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView3);
            this.splitContainer2.Size = new System.Drawing.Size(779, 417);
            this.splitContainer2.SplitterDistance = 161;
            this.splitContainer2.TabIndex = 0;
            // 
            // dataGridView2
            // 
            this.dataGridView2.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
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
            this.clnIdMovi,
            this.clnNumeroPA,
            this.clnCodigo,
            this.clnDescricao,
            this.clnPesoBruto,
            this.clnPesoLiquido,
            this.clnBobinas,
            this.clnIdTransferencia,
            this.clnUsuarioTransferencia});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(775, 157);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // dataGridView3
            // 
            this.dataGridView3.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.AllowUserToDeleteRows = false;
            this.dataGridView3.AllowUserToOrderColumns = true;
            this.dataGridView3.AllowUserToResizeRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView3.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            this.dataGridView3.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView3.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView3.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnIdFecha,
            this.clnCodigoFech,
            this.clnDescricaoFech,
            this.clnPesoBrutoFech,
            this.clnPesoLiquidoFech,
            this.clnQtBobinas,
            this.clnidTransfFech});
            this.dataGridView3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView3.EnableHeadersVisualStyles = false;
            this.dataGridView3.Location = new System.Drawing.Point(0, 0);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView3.RowHeadersVisible = false;
            this.dataGridView3.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(775, 248);
            this.dataGridView3.TabIndex = 0;
            this.dataGridView3.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView3_CellContentClick);
            // 
            // clnID
            // 
            this.clnID.DataPropertyName = "ID";
            this.clnID.HeaderText = "Nº Transferencia";
            this.clnID.Name = "clnID";
            this.clnID.ReadOnly = true;
            // 
            // clnDataHoraTransf
            // 
            this.clnDataHoraTransf.DataPropertyName = "dataHoraTransf";
            this.clnDataHoraTransf.HeaderText = "Data/Hora Transferencia";
            this.clnDataHoraTransf.Name = "clnDataHoraTransf";
            this.clnDataHoraTransf.ReadOnly = true;
            this.clnDataHoraTransf.Width = 180;
            // 
            // clnUsuarioTransf
            // 
            this.clnUsuarioTransf.DataPropertyName = "usuarioTransf";
            this.clnUsuarioTransf.HeaderText = "Usuário/Transferencia";
            this.clnUsuarioTransf.Name = "clnUsuarioTransf";
            this.clnUsuarioTransf.ReadOnly = true;
            this.clnUsuarioTransf.Width = 131;
            // 
            // clnIdFecha
            // 
            this.clnIdFecha.DataPropertyName = "id";
            this.clnIdFecha.HeaderText = "ID/Fehcamento";
            this.clnIdFecha.Name = "clnIdFecha";
            this.clnIdFecha.ReadOnly = true;
            this.clnIdFecha.Visible = false;
            // 
            // clnCodigoFech
            // 
            this.clnCodigoFech.DataPropertyName = "codigo";
            this.clnCodigoFech.HeaderText = "Código";
            this.clnCodigoFech.Name = "clnCodigoFech";
            this.clnCodigoFech.ReadOnly = true;
            this.clnCodigoFech.Width = 127;
            // 
            // clnDescricaoFech
            // 
            this.clnDescricaoFech.DataPropertyName = "Descricao";
            this.clnDescricaoFech.HeaderText = "Descrição";
            this.clnDescricaoFech.Name = "clnDescricaoFech";
            this.clnDescricaoFech.ReadOnly = true;
            this.clnDescricaoFech.Width = 300;
            // 
            // clnPesoBrutoFech
            // 
            this.clnPesoBrutoFech.DataPropertyName = "PesoBruto";
            this.clnPesoBrutoFech.HeaderText = "Peso Bruto";
            this.clnPesoBrutoFech.Name = "clnPesoBrutoFech";
            this.clnPesoBrutoFech.ReadOnly = true;
            this.clnPesoBrutoFech.Width = 127;
            // 
            // clnPesoLiquidoFech
            // 
            this.clnPesoLiquidoFech.DataPropertyName = "PesoLiquido";
            this.clnPesoLiquidoFech.HeaderText = "Peso Liquido";
            this.clnPesoLiquidoFech.Name = "clnPesoLiquidoFech";
            this.clnPesoLiquidoFech.ReadOnly = true;
            this.clnPesoLiquidoFech.Width = 127;
            // 
            // clnQtBobinas
            // 
            this.clnQtBobinas.DataPropertyName = "QtBobinas";
            this.clnQtBobinas.HeaderText = "QT/Bobinas";
            this.clnQtBobinas.Name = "clnQtBobinas";
            this.clnQtBobinas.ReadOnly = true;
            this.clnQtBobinas.Width = 127;
            // 
            // clnidTransfFech
            // 
            this.clnidTransfFech.DataPropertyName = "IdTransferencia";
            this.clnidTransfFech.HeaderText = "ID/Transferencia";
            this.clnidTransfFech.Name = "clnidTransfFech";
            this.clnidTransfFech.ReadOnly = true;
            this.clnidTransfFech.Visible = false;
            this.clnidTransfFech.Width = 127;
            // 
            // clnIdMovi
            // 
            this.clnIdMovi.DataPropertyName = "id";
            this.clnIdMovi.HeaderText = "ID/Movimento";
            this.clnIdMovi.Name = "clnIdMovi";
            this.clnIdMovi.ReadOnly = true;
            this.clnIdMovi.Visible = false;
            // 
            // clnNumeroPA
            // 
            this.clnNumeroPA.DataPropertyName = "numeroPa";
            this.clnNumeroPA.HeaderText = "Nº P.A";
            this.clnNumeroPA.Name = "clnNumeroPA";
            this.clnNumeroPA.ReadOnly = true;
            this.clnNumeroPA.Width = 80;
            // 
            // clnCodigo
            // 
            this.clnCodigo.DataPropertyName = "codigo";
            this.clnCodigo.HeaderText = "Código";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            this.clnCodigo.Width = 127;
            // 
            // clnDescricao
            // 
            this.clnDescricao.DataPropertyName = "Descricao";
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 250;
            // 
            // clnPesoBruto
            // 
            this.clnPesoBruto.DataPropertyName = "PesoBruto";
            this.clnPesoBruto.HeaderText = "Peso Bruto";
            this.clnPesoBruto.Name = "clnPesoBruto";
            this.clnPesoBruto.ReadOnly = true;
            this.clnPesoBruto.Width = 95;
            // 
            // clnPesoLiquido
            // 
            this.clnPesoLiquido.DataPropertyName = "PesoLiquido";
            this.clnPesoLiquido.HeaderText = "Peso Liquido";
            this.clnPesoLiquido.Name = "clnPesoLiquido";
            this.clnPesoLiquido.ReadOnly = true;
            this.clnPesoLiquido.Width = 95;
            // 
            // clnBobinas
            // 
            this.clnBobinas.DataPropertyName = "Bobinas";
            this.clnBobinas.HeaderText = "QT/Bobinas";
            this.clnBobinas.Name = "clnBobinas";
            this.clnBobinas.ReadOnly = true;
            this.clnBobinas.Width = 95;
            // 
            // clnIdTransferencia
            // 
            this.clnIdTransferencia.DataPropertyName = "IdTransferencia";
            this.clnIdTransferencia.HeaderText = "Id Transferencia";
            this.clnIdTransferencia.Name = "clnIdTransferencia";
            this.clnIdTransferencia.ReadOnly = true;
            this.clnIdTransferencia.Visible = false;
            // 
            // clnUsuarioTransferencia
            // 
            this.clnUsuarioTransferencia.DataPropertyName = "usuarioTransferencia";
            this.clnUsuarioTransferencia.HeaderText = "Usuário/Transf";
            this.clnUsuarioTransferencia.Name = "clnUsuarioTransferencia";
            this.clnUsuarioTransferencia.ReadOnly = true;
            this.clnUsuarioTransferencia.Visible = false;
            // 
            // frmPainelTransferencias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1214, 551);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPainelTransferencias";
            this.Text = "Historico de Transferencias";
            this.Load += new System.EventHandler(this.frmPainelTransferencias_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFiltro;
        private System.Windows.Forms.Button btnImprimir;
        public System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraTransf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioTransf;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdFecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoFech;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricaoFech;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPesoBrutoFech;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPesoLiquidoFech;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQtBobinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnidTransfFech;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdMovi;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPesoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPesoLiquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnBobinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdTransferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioTransferencia;
    }
}