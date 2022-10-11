namespace SistemaTHR.Apllication.Estoque
{
    partial class frmFinalizarRequisicao
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFinalizarRequisicao));
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnAtualizar = new System.Windows.Forms.Button();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnData = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ClnRequerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DescricaoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnForn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HorarioSolicitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHoraEntrega = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnResponsavelEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTempoEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnObs = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rdbPA = new System.Windows.Forms.RadioButton();
            this.rdbMp = new System.Windows.Forms.RadioButton();
            this.btnExlcuir = new System.Windows.Forms.Button();
            this.txtNumero = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnFechar = new System.Windows.Forms.Button();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.txtLote = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtQuantidade = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.Panel1.SuspendLayout();
            this.splitContainer1.Panel2.SuspendLayout();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 481);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(967, 22);
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
            this.panel1.Controls.Add(this.btnAtualizar);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(967, 26);
            this.panel1.TabIndex = 1;
            // 
            // btnAtualizar
            // 
            this.btnAtualizar.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnAtualizar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAtualizar.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAtualizar.Image = global::SistemaTHR.Properties.Resources.refresh_button;
            this.btnAtualizar.Location = new System.Drawing.Point(0, 0);
            this.btnAtualizar.Name = "btnAtualizar";
            this.btnAtualizar.Size = new System.Drawing.Size(31, 26);
            this.btnAtualizar.TabIndex = 0;
            this.btnAtualizar.UseVisualStyleBackColor = true;
            this.btnAtualizar.Click += new System.EventHandler(this.btnAtualizar_Click);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(0, 26);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer1.Panel1
            // 
            this.splitContainer1.Panel1.Controls.Add(this.dataGridView1);
            // 
            // splitContainer1.Panel2
            // 
            this.splitContainer1.Panel2.Controls.Add(this.rdbPA);
            this.splitContainer1.Panel2.Controls.Add(this.rdbMp);
            this.splitContainer1.Panel2.Controls.Add(this.btnExlcuir);
            this.splitContainer1.Panel2.Controls.Add(this.txtNumero);
            this.splitContainer1.Panel2.Controls.Add(this.label4);
            this.splitContainer1.Panel2.Controls.Add(this.btnFechar);
            this.splitContainer1.Panel2.Controls.Add(this.btnSalvar);
            this.splitContainer1.Panel2.Controls.Add(this.txtLote);
            this.splitContainer1.Panel2.Controls.Add(this.label3);
            this.splitContainer1.Panel2.Controls.Add(this.txtQuantidade);
            this.splitContainer1.Panel2.Controls.Add(this.label2);
            this.splitContainer1.Panel2.Controls.Add(this.txtDescricao);
            this.splitContainer1.Panel2.Controls.Add(this.label1);
            this.splitContainer1.Size = new System.Drawing.Size(967, 455);
            this.splitContainer1.SplitterDistance = 259;
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
            this.clnId,
            this.clnData,
            this.clnOP,
            this.ClnRequerente,
            this.clnMaquina,
            this.clnItem,
            this.DescricaoItem,
            this.clnCodigoItem,
            this.clnForn,
            this.HorarioSolicitado,
            this.clnHoraEntrega,
            this.clnResponsavelEstoque,
            this.clnStatus,
            this.clnTempoEspera,
            this.clnObs});
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
            this.dataGridView1.Size = new System.Drawing.Size(967, 259);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // clnId
            // 
            this.clnId.DataPropertyName = "ID";
            this.clnId.HeaderText = "N/Req.";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 50;
            // 
            // clnData
            // 
            this.clnData.DataPropertyName = "Data";
            this.clnData.HeaderText = "Data/Req.";
            this.clnData.Name = "clnData";
            this.clnData.ReadOnly = true;
            this.clnData.Width = 80;
            // 
            // clnOP
            // 
            this.clnOP.DataPropertyName = "Ordem";
            this.clnOP.HeaderText = "O.P";
            this.clnOP.Name = "clnOP";
            this.clnOP.ReadOnly = true;
            this.clnOP.Width = 80;
            // 
            // ClnRequerente
            // 
            this.ClnRequerente.DataPropertyName = "Requerente";
            this.ClnRequerente.HeaderText = "Reque.";
            this.ClnRequerente.Name = "ClnRequerente";
            this.ClnRequerente.ReadOnly = true;
            // 
            // clnMaquina
            // 
            this.clnMaquina.DataPropertyName = "Maquina";
            this.clnMaquina.HeaderText = "MQ.";
            this.clnMaquina.Name = "clnMaquina";
            this.clnMaquina.ReadOnly = true;
            this.clnMaquina.Width = 50;
            // 
            // clnItem
            // 
            this.clnItem.DataPropertyName = "Item";
            this.clnItem.HeaderText = "Item";
            this.clnItem.Name = "clnItem";
            this.clnItem.ReadOnly = true;
            this.clnItem.Width = 240;
            // 
            // DescricaoItem
            // 
            this.DescricaoItem.DataPropertyName = "Descricao_Item";
            this.DescricaoItem.HeaderText = "Des.Item";
            this.DescricaoItem.Name = "DescricaoItem";
            this.DescricaoItem.ReadOnly = true;
            this.DescricaoItem.Visible = false;
            // 
            // clnCodigoItem
            // 
            this.clnCodigoItem.DataPropertyName = "Codigo_Item";
            this.clnCodigoItem.HeaderText = "Cod/Item.";
            this.clnCodigoItem.Name = "clnCodigoItem";
            this.clnCodigoItem.ReadOnly = true;
            // 
            // clnForn
            // 
            this.clnForn.DataPropertyName = "Fornecedor";
            this.clnForn.HeaderText = "Forn.";
            this.clnForn.Name = "clnForn";
            this.clnForn.ReadOnly = true;
            // 
            // HorarioSolicitado
            // 
            this.HorarioSolicitado.DataPropertyName = "HorarioSolicitado";
            this.HorarioSolicitado.HeaderText = "Hor/Sol.";
            this.HorarioSolicitado.Name = "HorarioSolicitado";
            this.HorarioSolicitado.ReadOnly = true;
            // 
            // clnHoraEntrega
            // 
            this.clnHoraEntrega.DataPropertyName = "HorarioEntrega";
            this.clnHoraEntrega.HeaderText = "Hor/Ent.";
            this.clnHoraEntrega.Name = "clnHoraEntrega";
            this.clnHoraEntrega.ReadOnly = true;
            this.clnHoraEntrega.Visible = false;
            // 
            // clnResponsavelEstoque
            // 
            this.clnResponsavelEstoque.DataPropertyName = "RespEstoque";
            this.clnResponsavelEstoque.HeaderText = "Resp/Est.";
            this.clnResponsavelEstoque.Name = "clnResponsavelEstoque";
            this.clnResponsavelEstoque.ReadOnly = true;
            this.clnResponsavelEstoque.Visible = false;
            // 
            // clnStatus
            // 
            this.clnStatus.DataPropertyName = "Status";
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            this.clnStatus.Width = 150;
            // 
            // clnTempoEspera
            // 
            this.clnTempoEspera.DataPropertyName = "TempoEspera";
            this.clnTempoEspera.HeaderText = "Tem/Esp.";
            this.clnTempoEspera.Name = "clnTempoEspera";
            this.clnTempoEspera.ReadOnly = true;
            this.clnTempoEspera.Visible = false;
            // 
            // clnObs
            // 
            this.clnObs.DataPropertyName = "Observacoes";
            this.clnObs.HeaderText = "OBS:";
            this.clnObs.Name = "clnObs";
            this.clnObs.ReadOnly = true;
            this.clnObs.Visible = false;
            // 
            // rdbPA
            // 
            this.rdbPA.AutoSize = true;
            this.rdbPA.Location = new System.Drawing.Point(151, 57);
            this.rdbPA.Name = "rdbPA";
            this.rdbPA.Size = new System.Drawing.Size(39, 17);
            this.rdbPA.TabIndex = 12;
            this.rdbPA.TabStop = true;
            this.rdbPA.Text = "PA";
            this.rdbPA.UseVisualStyleBackColor = true;
            // 
            // rdbMp
            // 
            this.rdbMp.AutoSize = true;
            this.rdbMp.Location = new System.Drawing.Point(102, 57);
            this.rdbMp.Name = "rdbMp";
            this.rdbMp.Size = new System.Drawing.Size(41, 17);
            this.rdbMp.TabIndex = 11;
            this.rdbMp.TabStop = true;
            this.rdbMp.Text = "MP";
            this.rdbMp.UseVisualStyleBackColor = true;
            // 
            // btnExlcuir
            // 
            this.btnExlcuir.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnExlcuir.Enabled = false;
            this.btnExlcuir.Location = new System.Drawing.Point(880, 119);
            this.btnExlcuir.Name = "btnExlcuir";
            this.btnExlcuir.Size = new System.Drawing.Size(75, 23);
            this.btnExlcuir.TabIndex = 10;
            this.btnExlcuir.Text = "Excluir";
            this.btnExlcuir.UseVisualStyleBackColor = true;
            this.btnExlcuir.Click += new System.EventHandler(this.btnExlcuir_Click);
            // 
            // txtNumero
            // 
            this.txtNumero.Location = new System.Drawing.Point(101, 80);
            this.txtNumero.Name = "txtNumero";
            this.txtNumero.Size = new System.Drawing.Size(86, 20);
            this.txtNumero.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 87);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "Nº P.A / M.P:";
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Location = new System.Drawing.Point(880, 154);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 6;
            this.btnFechar.Text = "Cancelar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Enabled = false;
            this.btnSalvar.Location = new System.Drawing.Point(799, 154);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 5;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // txtLote
            // 
            this.txtLote.Location = new System.Drawing.Point(242, 119);
            this.txtLote.Name = "txtLote";
            this.txtLote.Size = new System.Drawing.Size(169, 20);
            this.txtLote.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(205, 126);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(31, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Lote:";
            // 
            // txtQuantidade
            // 
            this.txtQuantidade.Location = new System.Drawing.Point(101, 119);
            this.txtQuantidade.Name = "txtQuantidade";
            this.txtQuantidade.Size = new System.Drawing.Size(86, 20);
            this.txtQuantidade.TabIndex = 3;
            this.txtQuantidade.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQuantidade_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 126);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Quantidade:";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Location = new System.Drawing.Point(101, 22);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.ReadOnly = true;
            this.txtDescricao.Size = new System.Drawing.Size(503, 20);
            this.txtDescricao.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Descrição:";
            // 
            // frmFinalizarRequisicao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(967, 503);
            this.Controls.Add(this.splitContainer1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmFinalizarRequisicao";
            this.Text = "Requisições em Aberto";
            this.Load += new System.EventHandler(this.frmFinalizarRequisicao_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.splitContainer1.Panel1.ResumeLayout(false);
            this.splitContainer1.Panel2.ResumeLayout(false);
            this.splitContainer1.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnAtualizar;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.TextBox txtLote;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantidade;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNumero;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnData;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClnRequerente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn DescricaoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnForn;
        private System.Windows.Forms.DataGridViewTextBoxColumn HorarioSolicitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHoraEntrega;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnResponsavelEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTempoEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnObs;
        private System.Windows.Forms.Button btnExlcuir;
        private System.Windows.Forms.RadioButton rdbPA;
        private System.Windows.Forms.RadioButton rdbMp;
    }
}