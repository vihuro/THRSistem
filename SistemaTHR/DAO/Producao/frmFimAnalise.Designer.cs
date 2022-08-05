namespace SistemaTHR.DAO.Producao
{
    partial class frmFimAnalise
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFimAnalise));
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnBaixa = new System.Windows.Forms.Button();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraIniAnalise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraFinAnalise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioFinAnalise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraFinProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioFinProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTempoAnalise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
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
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnBaixa);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.textBox1);
            this.splitContainer1.Size = new System.Drawing.Size(1237, 428);
            this.splitContainer1.SplitterDistance = 174;
            this.splitContainer1.TabIndex = 0;
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
            this.clnId,
            this.clnLote,
            this.clnDescricao,
            this.clnCodigo,
            this.clnDataHoraIniAnalise,
            this.clnUsuarioLancamento,
            this.clnDataHoraFinAnalise,
            this.clnUsuarioFinAnalise,
            this.clnDataHoraFinProd,
            this.clnUsuarioFinProd,
            this.clnTempoAnalise,
            this.clnStatus});
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
            this.dataGridView1.Size = new System.Drawing.Size(1237, 174);
            this.dataGridView1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(91, 36);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(37, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº Ficha";
            // 
            // btnBaixa
            // 
            this.btnBaixa.Location = new System.Drawing.Point(797, 211);
            this.btnBaixa.Name = "btnBaixa";
            this.btnBaixa.Size = new System.Drawing.Size(75, 23);
            this.btnBaixa.TabIndex = 2;
            this.btnBaixa.Text = "Analisado";
            this.btnBaixa.UseVisualStyleBackColor = true;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1237, 22);
            this.statusStrip1.TabIndex = 1;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(47, 17);
            this.toolStripStatusLabel1.Text = "Usuário";
            // 
            // lblUsuario
            // 
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 17);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Location = new System.Drawing.Point(878, 211);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // clnId
            // 
            this.clnId.HeaderText = "Nº";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 50;
            // 
            // clnLote
            // 
            this.clnLote.HeaderText = "Lote";
            this.clnLote.Name = "clnLote";
            this.clnLote.ReadOnly = true;
            this.clnLote.Width = 80;
            // 
            // clnDescricao
            // 
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Visible = false;
            // 
            // clnCodigo
            // 
            this.clnCodigo.HeaderText = "Código";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            // 
            // clnDataHoraIniAnalise
            // 
            this.clnDataHoraIniAnalise.HeaderText = "Data/Hora Ini/Analise";
            this.clnDataHoraIniAnalise.Name = "clnDataHoraIniAnalise";
            this.clnDataHoraIniAnalise.ReadOnly = true;
            this.clnDataHoraIniAnalise.Width = 150;
            // 
            // clnUsuarioLancamento
            // 
            this.clnUsuarioLancamento.HeaderText = "Usuario/Lanc.";
            this.clnUsuarioLancamento.Name = "clnUsuarioLancamento";
            this.clnUsuarioLancamento.ReadOnly = true;
            // 
            // clnDataHoraFinAnalise
            // 
            this.clnDataHoraFinAnalise.HeaderText = "Data/Hora Fim/Anali.";
            this.clnDataHoraFinAnalise.Name = "clnDataHoraFinAnalise";
            this.clnDataHoraFinAnalise.ReadOnly = true;
            this.clnDataHoraFinAnalise.Width = 150;
            // 
            // clnUsuarioFinAnalise
            // 
            this.clnUsuarioFinAnalise.HeaderText = "Usuario Fim/Anali.";
            this.clnUsuarioFinAnalise.Name = "clnUsuarioFinAnalise";
            this.clnUsuarioFinAnalise.ReadOnly = true;
            // 
            // clnDataHoraFinProd
            // 
            this.clnDataHoraFinProd.HeaderText = "Data/Hora Fim/Prod.";
            this.clnDataHoraFinProd.Name = "clnDataHoraFinProd";
            this.clnDataHoraFinProd.ReadOnly = true;
            this.clnDataHoraFinProd.Width = 150;
            // 
            // clnUsuarioFinProd
            // 
            this.clnUsuarioFinProd.HeaderText = "Usuário Fim/Prod";
            this.clnUsuarioFinProd.Name = "clnUsuarioFinProd";
            this.clnUsuarioFinProd.ReadOnly = true;
            // 
            // clnTempoAnalise
            // 
            this.clnTempoAnalise.HeaderText = "Tempo/Analise";
            this.clnTempoAnalise.Name = "clnTempoAnalise";
            this.clnTempoAnalise.ReadOnly = true;
            // 
            // clnStatus
            // 
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            // 
            // frmFimAnalise
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1237, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFimAnalise";
            this.Text = "Quarentena";
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnBaixa;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraIniAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraFinAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioFinAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraFinProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioFinProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTempoAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
    }
}