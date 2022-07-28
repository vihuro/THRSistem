namespace SistemaTHR.Apllication
{
    partial class frmEditarTransferencia
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmEditarTransferencia));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnNumeroPA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPesoBruto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPesoLiquido = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtBobinas = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdTransferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioTransferencia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.splitContainer2 = new System.Windows.Forms.SplitContainer();
            this.label1 = new System.Windows.Forms.Label();
            this.txtNumeroPA = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdbExpedicao = new System.Windows.Forms.RadioButton();
            this.rdbProdução = new System.Windows.Forms.RadioButton();
            this.btnRemover = new System.Windows.Forms.Button();
            this.btnConectar = new System.Windows.Forms.Button();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.clnIdFech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoFech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricaoFech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPesoBrutoFech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPesoLiquidoFech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtBobFech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnIdTransfFech = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).BeginInit();
            this.splitContainer2.Panel1.SuspendLayout();
            this.splitContainer2.Panel2.SuspendLayout();
            this.splitContainer2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 545);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(949, 22);
            this.statusStrip1.TabIndex = 0;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 0);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.splitContainer2);
            this.splitContainer1.Size = new System.Drawing.Size(949, 545);
            this.splitContainer1.SplitterDistance = 206;
            this.splitContainer1.TabIndex = 1;
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
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnID,
            this.clnNumeroPA,
            this.clnCodigo,
            this.clnDescricao,
            this.clnPesoBruto,
            this.clnPesoLiquido,
            this.clnQtBobinas,
            this.clnIdTransferencia,
            this.clnUsuarioTransferencia});
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
            this.dataGridView1.Size = new System.Drawing.Size(949, 206);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // clnID
            // 
            this.clnID.DataPropertyName = "id";
            this.clnID.HeaderText = "ID";
            this.clnID.Name = "clnID";
            this.clnID.ReadOnly = true;
            this.clnID.Visible = false;
            // 
            // clnNumeroPA
            // 
            this.clnNumeroPA.DataPropertyName = "numeroPa";
            this.clnNumeroPA.FillWeight = 46.90353F;
            this.clnNumeroPA.HeaderText = "Numero/PA";
            this.clnNumeroPA.Name = "clnNumeroPA";
            this.clnNumeroPA.ReadOnly = true;
            this.clnNumeroPA.Width = 120;
            // 
            // clnCodigo
            // 
            this.clnCodigo.DataPropertyName = "Codigo";
            this.clnCodigo.FillWeight = 365.4821F;
            this.clnCodigo.HeaderText = "Código";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            this.clnCodigo.Width = 180;
            // 
            // clnDescricao
            // 
            this.clnDescricao.DataPropertyName = "Descricao";
            this.clnDescricao.FillWeight = 46.90353F;
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 350;
            // 
            // clnPesoBruto
            // 
            this.clnPesoBruto.DataPropertyName = "PesoBruto";
            this.clnPesoBruto.FillWeight = 46.90353F;
            this.clnPesoBruto.HeaderText = "Peso Bruto";
            this.clnPesoBruto.Name = "clnPesoBruto";
            this.clnPesoBruto.ReadOnly = true;
            // 
            // clnPesoLiquido
            // 
            this.clnPesoLiquido.DataPropertyName = "pesoLiquido";
            this.clnPesoLiquido.FillWeight = 46.90353F;
            this.clnPesoLiquido.HeaderText = "Peso Liquido";
            this.clnPesoLiquido.Name = "clnPesoLiquido";
            this.clnPesoLiquido.ReadOnly = true;
            // 
            // clnQtBobinas
            // 
            this.clnQtBobinas.DataPropertyName = "Bobinas";
            this.clnQtBobinas.FillWeight = 46.90353F;
            this.clnQtBobinas.HeaderText = "QT/Bobinas";
            this.clnQtBobinas.Name = "clnQtBobinas";
            this.clnQtBobinas.ReadOnly = true;
            this.clnQtBobinas.Width = 80;
            // 
            // clnIdTransferencia
            // 
            this.clnIdTransferencia.DataPropertyName = "idTransferencia";
            this.clnIdTransferencia.HeaderText = "Numero/Transferencia";
            this.clnIdTransferencia.Name = "clnIdTransferencia";
            this.clnIdTransferencia.ReadOnly = true;
            this.clnIdTransferencia.Visible = false;
            // 
            // clnUsuarioTransferencia
            // 
            this.clnUsuarioTransferencia.DataPropertyName = "usuarioTransferencia";
            this.clnUsuarioTransferencia.HeaderText = "Usuário/Transferencia";
            this.clnUsuarioTransferencia.Name = "clnUsuarioTransferencia";
            this.clnUsuarioTransferencia.ReadOnly = true;
            this.clnUsuarioTransferencia.Visible = false;
            // 
            // splitContainer2
            // 
            this.splitContainer2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer2.Location = new System.Drawing.Point(0, 0);
            this.splitContainer2.Name = "splitContainer2";
            this.splitContainer2.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer2.Panel1
            // 
            this.splitContainer2.Panel1.AutoScroll = true;
            this.splitContainer2.Panel1.Controls.Add(this.label1);
            this.splitContainer2.Panel1.Controls.Add(this.txtNumeroPA);
            this.splitContainer2.Panel1.Controls.Add(this.groupBox1);
            this.splitContainer2.Panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer2_Panel1_Paint);
            // 
            // splitContainer2.Panel2
            // 
            this.splitContainer2.Panel2.Controls.Add(this.dataGridView2);
            this.splitContainer2.Size = new System.Drawing.Size(949, 335);
            this.splitContainer2.SplitterDistance = 168;
            this.splitContainer2.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(8, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Nº PA";
            // 
            // txtNumeroPA
            // 
            this.txtNumeroPA.Location = new System.Drawing.Point(47, 25);
            this.txtNumeroPA.Name = "txtNumeroPA";
            this.txtNumeroPA.Size = new System.Drawing.Size(100, 20);
            this.txtNumeroPA.TabIndex = 9;
            this.txtNumeroPA.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtNumeroPA_KeyUp);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdbExpedicao);
            this.groupBox1.Controls.Add(this.rdbProdução);
            this.groupBox1.Controls.Add(this.btnRemover);
            this.groupBox1.Controls.Add(this.btnConectar);
            this.groupBox1.Location = new System.Drawing.Point(12, 51);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(342, 111);
            this.groupBox1.TabIndex = 15;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Selecione a origem...";
            // 
            // rdbExpedicao
            // 
            this.rdbExpedicao.AutoSize = true;
            this.rdbExpedicao.Location = new System.Drawing.Point(144, 19);
            this.rdbExpedicao.Name = "rdbExpedicao";
            this.rdbExpedicao.Size = new System.Drawing.Size(75, 17);
            this.rdbExpedicao.TabIndex = 17;
            this.rdbExpedicao.TabStop = true;
            this.rdbExpedicao.Text = "Expedição";
            this.rdbExpedicao.UseVisualStyleBackColor = true;
            // 
            // rdbProdução
            // 
            this.rdbProdução.AutoSize = true;
            this.rdbProdução.Location = new System.Drawing.Point(35, 19);
            this.rdbProdução.Name = "rdbProdução";
            this.rdbProdução.Size = new System.Drawing.Size(71, 17);
            this.rdbProdução.TabIndex = 16;
            this.rdbProdução.TabStop = true;
            this.rdbProdução.Text = "Produção";
            this.rdbProdução.UseVisualStyleBackColor = true;
            this.rdbProdução.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // btnRemover
            // 
            this.btnRemover.Location = new System.Drawing.Point(144, 72);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(75, 23);
            this.btnRemover.TabIndex = 14;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = true;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // btnConectar
            // 
            this.btnConectar.Location = new System.Drawing.Point(35, 72);
            this.btnConectar.Name = "btnConectar";
            this.btnConectar.Size = new System.Drawing.Size(75, 23);
            this.btnConectar.TabIndex = 11;
            this.btnConectar.Text = "Carregar";
            this.btnConectar.UseVisualStyleBackColor = true;
            this.btnConectar.Click += new System.EventHandler(this.btnConectar_Click);
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
            this.clnIdFech,
            this.clnCodigoFech,
            this.clnDescricaoFech,
            this.clnPesoBrutoFech,
            this.clnPesoLiquidoFech,
            this.clnQtBobFech,
            this.clnIdTransfFech});
            this.dataGridView2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView2.EnableHeadersVisualStyles = false;
            this.dataGridView2.Location = new System.Drawing.Point(0, 0);
            this.dataGridView2.MultiSelect = false;
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.ReadOnly = true;
            this.dataGridView2.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView2.RowHeadersVisible = false;
            this.dataGridView2.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView2.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView2.Size = new System.Drawing.Size(949, 163);
            this.dataGridView2.TabIndex = 0;
            this.dataGridView2.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView2_CellContentClick);
            // 
            // clnIdFech
            // 
            this.clnIdFech.DataPropertyName = "id";
            this.clnIdFech.HeaderText = "ID";
            this.clnIdFech.Name = "clnIdFech";
            this.clnIdFech.ReadOnly = true;
            this.clnIdFech.Visible = false;
            // 
            // clnCodigoFech
            // 
            this.clnCodigoFech.DataPropertyName = "codigo";
            this.clnCodigoFech.FillWeight = 34.26931F;
            this.clnCodigoFech.HeaderText = "Código";
            this.clnCodigoFech.Name = "clnCodigoFech";
            this.clnCodigoFech.ReadOnly = true;
            this.clnCodigoFech.Width = 150;
            // 
            // clnDescricaoFech
            // 
            this.clnDescricaoFech.DataPropertyName = "descricao";
            this.clnDescricaoFech.FillWeight = 449.2385F;
            this.clnDescricaoFech.HeaderText = "Decrição";
            this.clnDescricaoFech.Name = "clnDescricaoFech";
            this.clnDescricaoFech.ReadOnly = true;
            this.clnDescricaoFech.Width = 400;
            // 
            // clnPesoBrutoFech
            // 
            this.clnPesoBrutoFech.DataPropertyName = "pesoBruto";
            this.clnPesoBrutoFech.FillWeight = 5.497368F;
            this.clnPesoBrutoFech.HeaderText = "Peso Bruto";
            this.clnPesoBrutoFech.Name = "clnPesoBrutoFech";
            this.clnPesoBrutoFech.ReadOnly = true;
            this.clnPesoBrutoFech.Width = 120;
            // 
            // clnPesoLiquidoFech
            // 
            this.clnPesoLiquidoFech.DataPropertyName = "pesoLiquido";
            this.clnPesoLiquidoFech.FillWeight = 5.497368F;
            this.clnPesoLiquidoFech.HeaderText = "Peso Liquido";
            this.clnPesoLiquidoFech.Name = "clnPesoLiquidoFech";
            this.clnPesoLiquidoFech.ReadOnly = true;
            this.clnPesoLiquidoFech.Width = 120;
            // 
            // clnQtBobFech
            // 
            this.clnQtBobFech.DataPropertyName = "qtBobinas";
            this.clnQtBobFech.FillWeight = 5.497368F;
            this.clnQtBobFech.HeaderText = "Qt/Bobinas";
            this.clnQtBobFech.Name = "clnQtBobFech";
            this.clnQtBobFech.ReadOnly = true;
            this.clnQtBobFech.Width = 120;
            // 
            // clnIdTransfFech
            // 
            this.clnIdTransfFech.DataPropertyName = "idTransferencia";
            this.clnIdTransfFech.HeaderText = "N/Transferencia";
            this.clnIdTransfFech.Name = "clnIdTransfFech";
            this.clnIdTransfFech.ReadOnly = true;
            this.clnIdTransfFech.Visible = false;
            // 
            // frmEditarTransferencia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 567);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmEditarTransferencia";
            this.Text = "Editar Transferencia";
            this.Load += new System.EventHandler(this.frmEditarTransferencia_Load);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.splitContainer2.Panel1.ResumeLayout(false);
            this.splitContainer2.Panel1.PerformLayout();
            this.splitContainer2.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer2)).EndInit();
            this.splitContainer2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.SplitContainer splitContainer2;
        private System.Windows.Forms.Button btnConectar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumeroPA;
        public System.Windows.Forms.DataGridView dataGridView1;
        public System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdbProdução;
        private System.Windows.Forms.RadioButton rdbExpedicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroPA;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPesoBruto;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPesoLiquido;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQtBobinas;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdTransferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioTransferencia;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdFech;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoFech;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricaoFech;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPesoBrutoFech;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPesoLiquidoFech;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQtBobFech;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnIdTransfFech;
    }
}