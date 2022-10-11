namespace SistemaTHR.Apllication.Producao.Impressao
{
    partial class frmControleQuarentena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmControleQuarentena));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraLanc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioLanc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraFinAnalise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioFinAnalise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraFinProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnusuarioFinProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTempoAnalise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFicha = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.statusStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1160, 22);
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
            // splitContainer1
            // 
            this.splitContainer1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 28);
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
            this.splitContainer1.Panel2.Controls.Add(this.btnExcluir);
            this.splitContainer1.Panel2.Controls.Add(this.btnCancelar);
            this.splitContainer1.Panel2.Controls.Add(this.btnSalvar);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Panel2.Controls.Add(this.txtFicha);
            this.splitContainer1.Size = new System.Drawing.Size(1160, 400);
            this.splitContainer1.SplitterDistance = 153;
            this.splitContainer1.TabIndex = 1;
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
            this.clId,
            this.clnLote,
            this.clnCodigo,
            this.clnDescricao,
            this.clnDataHoraLanc,
            this.clnUsuarioLanc,
            this.clnDataHoraFinAnalise,
            this.clnUsuarioFinAnalise,
            this.clnDataHoraFinProd,
            this.clnusuarioFinProd,
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
            this.dataGridView1.Size = new System.Drawing.Size(1156, 149);
            this.dataGridView1.TabIndex = 0;

            // 
            // clId
            // 
            this.clId.DataPropertyName = "ID";
            this.clId.HeaderText = "Nº";
            this.clId.Name = "clId";
            this.clId.ReadOnly = true;
            this.clId.Width = 50;
            // 
            // clnLote
            // 
            this.clnLote.DataPropertyName = "Lote";
            this.clnLote.HeaderText = "Lote";
            this.clnLote.Name = "clnLote";
            this.clnLote.ReadOnly = true;
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
            this.clnDescricao.Visible = false;
            // 
            // clnDataHoraLanc
            // 
            this.clnDataHoraLanc.DataPropertyName = "DataHoraIniAnalise";
            this.clnDataHoraLanc.HeaderText = "Data/Hora Lanç.";
            this.clnDataHoraLanc.Name = "clnDataHoraLanc";
            this.clnDataHoraLanc.ReadOnly = true;
            this.clnDataHoraLanc.Width = 150;
            // 
            // clnUsuarioLanc
            // 
            this.clnUsuarioLanc.DataPropertyName = "UsuarioLancamento";
            this.clnUsuarioLanc.HeaderText = "Usuário/Lanç.";
            this.clnUsuarioLanc.Name = "clnUsuarioLanc";
            this.clnUsuarioLanc.ReadOnly = true;
            this.clnUsuarioLanc.Width = 80;
            // 
            // clnDataHoraFinAnalise
            // 
            this.clnDataHoraFinAnalise.DataPropertyName = "DataHoraFinAnalise";
            this.clnDataHoraFinAnalise.HeaderText = "Data/Hora Fim/Anali.";
            this.clnDataHoraFinAnalise.Name = "clnDataHoraFinAnalise";
            this.clnDataHoraFinAnalise.ReadOnly = true;
            this.clnDataHoraFinAnalise.Width = 150;
            // 
            // clnUsuarioFinAnalise
            // 
            this.clnUsuarioFinAnalise.DataPropertyName = "UsuarioFinAnalise";
            this.clnUsuarioFinAnalise.HeaderText = "Usuario Fim/Anali.";
            this.clnUsuarioFinAnalise.Name = "clnUsuarioFinAnalise";
            this.clnUsuarioFinAnalise.ReadOnly = true;
            this.clnUsuarioFinAnalise.Width = 80;
            // 
            // clnDataHoraFinProd
            // 
            this.clnDataHoraFinProd.DataPropertyName = "dataHoraFinProd";
            this.clnDataHoraFinProd.HeaderText = "Data/Hora Fim/Prod.";
            this.clnDataHoraFinProd.Name = "clnDataHoraFinProd";
            this.clnDataHoraFinProd.ReadOnly = true;
            this.clnDataHoraFinProd.Width = 150;
            // 
            // clnusuarioFinProd
            // 
            this.clnusuarioFinProd.DataPropertyName = "UsuarioFinProd";
            this.clnusuarioFinProd.HeaderText = "Usuário/Prod.";
            this.clnusuarioFinProd.Name = "clnusuarioFinProd";
            this.clnusuarioFinProd.ReadOnly = true;
            this.clnusuarioFinProd.Width = 80;
            // 
            // clnTempoAnalise
            // 
            this.clnTempoAnalise.DataPropertyName = "tempoAnalise";
            this.clnTempoAnalise.HeaderText = "Tempo/Analise";
            this.clnTempoAnalise.Name = "clnTempoAnalise";
            this.clnTempoAnalise.ReadOnly = true;
            this.clnTempoAnalise.Width = 200;
            // 
            // clnStatus
            // 
            this.clnStatus.DataPropertyName = "Status";
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            // 
            // btnExcluir
            // 
            this.btnExcluir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExcluir.Enabled = false;
            this.btnExcluir.Location = new System.Drawing.Point(977, 204);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(75, 23);
            this.btnExcluir.TabIndex = 4;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = true;
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(1058, 204);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 3;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(896, 204);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 2;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nº Ficha:";
            // 
            // txtFicha
            // 
            this.txtFicha.Location = new System.Drawing.Point(84, 29);
            this.txtFicha.Name = "txtFicha";
            this.txtFicha.Size = new System.Drawing.Size(100, 20);
            this.txtFicha.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1160, 28);
            this.panel1.TabIndex = 2;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAtualizar.Image = global::SistemaTHR.Properties.Resources.refresh_button;
            this.btnAtualizar.Location = new System.Drawing.Point(0, 0);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(28, 28);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            // 
            // frmControleQuarentena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1160, 450);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmControleQuarentena";
            this.Text = "Controle de Quarentena";
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFicha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraLanc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioLanc;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraFinAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioFinAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraFinProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnusuarioFinProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTempoAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAtualizar;
    }
}