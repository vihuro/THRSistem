namespace SistemaTHR.Apllication.Estoque
{
    partial class frmPainelSolicitacoes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPainelSolicitacoes));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cboFiltro = new System.Windows.Forms.ComboBox();
            this.txtDataHora = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clnId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataRequisicao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnRequerente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnMaquina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricaoMaterial = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoItem = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnFornecedor = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHorarioSolicitado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnHorarioSolicitaco = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnResponsavelEstoque = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTempoEspera = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnObervacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
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
            this.clnDataRequisicao,
            this.clnOP,
            this.clnRequerente,
            this.clnMaquina,
            this.clnItem,
            this.clnDescricaoMaterial,
            this.clnCodigoItem,
            this.clnFornecedor,
            this.clnHorarioSolicitado,
            this.clnHorarioSolicitaco,
            this.clnResponsavelEstoque,
            this.clnStatus,
            this.clnTempoEspera,
            this.clnObervacao});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 39);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(914, 493);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            this.dataGridView1.CellStyleChanged += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellStyleChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.cboFiltro);
            this.panel1.Controls.Add(this.txtDataHora);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(914, 39);
            this.panel1.TabIndex = 1;
            // 
            // cboFiltro
            // 
            this.cboFiltro.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboFiltro.FormattingEnabled = true;
            this.cboFiltro.Items.AddRange(new object[] {
            "WIND",
            "TODOS"});
            this.cboFiltro.Location = new System.Drawing.Point(3, 12);
            this.cboFiltro.Name = "cboFiltro";
            this.cboFiltro.Size = new System.Drawing.Size(182, 21);
            this.cboFiltro.TabIndex = 1;
            // 
            // txtDataHora
            // 
            this.txtDataHora.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.txtDataHora.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDataHora.Location = new System.Drawing.Point(331, 3);
            this.txtDataHora.Name = "txtDataHora";
            this.txtDataHora.ReadOnly = true;
            this.txtDataHora.Size = new System.Drawing.Size(211, 32);
            this.txtDataHora.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // clnId
            // 
            this.clnId.DataPropertyName = "ID";
            this.clnId.HeaderText = "Nº/Sol.";
            this.clnId.Name = "clnId";
            this.clnId.ReadOnly = true;
            this.clnId.Width = 40;
            // 
            // clnDataRequisicao
            // 
            this.clnDataRequisicao.DataPropertyName = "Data";
            this.clnDataRequisicao.HeaderText = "Data/Requi.";
            this.clnDataRequisicao.Name = "clnDataRequisicao";
            this.clnDataRequisicao.ReadOnly = true;
            this.clnDataRequisicao.Visible = false;
            // 
            // clnOP
            // 
            this.clnOP.DataPropertyName = "Ordem";
            this.clnOP.HeaderText = "OP";
            this.clnOP.Name = "clnOP";
            this.clnOP.ReadOnly = true;
            this.clnOP.Width = 80;
            // 
            // clnRequerente
            // 
            this.clnRequerente.DataPropertyName = "Requerente";
            this.clnRequerente.HeaderText = "Solicitante";
            this.clnRequerente.Name = "clnRequerente";
            this.clnRequerente.ReadOnly = true;
            // 
            // clnMaquina
            // 
            this.clnMaquina.DataPropertyName = "Maquina";
            this.clnMaquina.HeaderText = "Maquina";
            this.clnMaquina.Name = "clnMaquina";
            this.clnMaquina.ReadOnly = true;
            // 
            // clnItem
            // 
            this.clnItem.DataPropertyName = "Item";
            this.clnItem.HeaderText = "Item";
            this.clnItem.Name = "clnItem";
            this.clnItem.ReadOnly = true;
            this.clnItem.Visible = false;
            // 
            // clnDescricaoMaterial
            // 
            this.clnDescricaoMaterial.DataPropertyName = "Descricao_Item";
            this.clnDescricaoMaterial.HeaderText = "Descrição/Material";
            this.clnDescricaoMaterial.Name = "clnDescricaoMaterial";
            this.clnDescricaoMaterial.ReadOnly = true;
            this.clnDescricaoMaterial.Width = 120;
            // 
            // clnCodigoItem
            // 
            this.clnCodigoItem.DataPropertyName = "Codigo_Item";
            this.clnCodigoItem.HeaderText = "Cód/Material";
            this.clnCodigoItem.Name = "clnCodigoItem";
            this.clnCodigoItem.ReadOnly = true;
            this.clnCodigoItem.Width = 130;
            // 
            // clnFornecedor
            // 
            this.clnFornecedor.DataPropertyName = "Fornecedor";
            this.clnFornecedor.HeaderText = "For.";
            this.clnFornecedor.Name = "clnFornecedor";
            this.clnFornecedor.ReadOnly = true;
            this.clnFornecedor.Visible = false;
            // 
            // clnHorarioSolicitado
            // 
            this.clnHorarioSolicitado.DataPropertyName = "HorarioSolicitado";
            this.clnHorarioSolicitado.HeaderText = "Hora/Sol.";
            this.clnHorarioSolicitado.Name = "clnHorarioSolicitado";
            this.clnHorarioSolicitado.ReadOnly = true;
            // 
            // clnHorarioSolicitaco
            // 
            this.clnHorarioSolicitaco.DataPropertyName = "HorarioEntrega";
            this.clnHorarioSolicitaco.HeaderText = "HorarioEntrega";
            this.clnHorarioSolicitaco.Name = "clnHorarioSolicitaco";
            this.clnHorarioSolicitaco.ReadOnly = true;
            this.clnHorarioSolicitaco.Visible = false;
            // 
            // clnResponsavelEstoque
            // 
            this.clnResponsavelEstoque.DataPropertyName = "RespEstoque";
            this.clnResponsavelEstoque.HeaderText = "Resp/Esto.";
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
            this.clnStatus.Width = 170;
            // 
            // clnTempoEspera
            // 
            this.clnTempoEspera.DataPropertyName = "TempoEspera";
            this.clnTempoEspera.HeaderText = "Tempo/Espera";
            this.clnTempoEspera.Name = "clnTempoEspera";
            this.clnTempoEspera.ReadOnly = true;
            // 
            // clnObervacao
            // 
            this.clnObervacao.DataPropertyName = "Observacoes";
            this.clnObervacao.HeaderText = "Obsersvação";
            this.clnObervacao.Name = "clnObervacao";
            this.clnObervacao.ReadOnly = true;
            this.clnObervacao.Visible = false;
            // 
            // frmPainelSolicitacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 532);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPainelSolicitacoes";
            this.Text = "Solicitações de Material";
            this.Load += new System.EventHandler(this.frmPainelSolicitacoesWind_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtDataHora;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.ComboBox cboFiltro;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataRequisicao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnRequerente;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnMaquina;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricaoMaterial;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnFornecedor;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHorarioSolicitado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnHorarioSolicitaco;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnResponsavelEstoque;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTempoEspera;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnObervacao;
    }
}