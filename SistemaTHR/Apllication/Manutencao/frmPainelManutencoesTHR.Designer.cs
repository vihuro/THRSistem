namespace SistemaTHR.Apllication
{
    partial class frmPainelManutencoesTHR
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPainelManutencoesTHR));
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnPause = new System.Windows.Forms.Button();
            this.btnPlay = new System.Windows.Forms.Button();
            this.clNOP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clTipoServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clDataHoraGeracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clUsuarioSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnASE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataIdeal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clPrioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioPrioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraPrioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraFin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCellsExceptHeaders;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dataGridView1.ClipboardCopyMode = System.Windows.Forms.DataGridViewClipboardCopyMode.Disable;
            this.dataGridView1.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(0, 15, 0, 15);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(19)))), ((int)(((byte)(35)))), ((int)(((byte)(103)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clNOP,
            this.clnDescricao,
            this.clTipoServico,
            this.clDataHoraGeracao,
            this.clUsuarioSolicitacao,
            this.clnASE,
            this.clnCategoria,
            this.clnDataIdeal,
            this.clPrioridade,
            this.clnUsuarioPrioridade,
            this.clnDataHoraPrioridade,
            this.clStatus,
            this.clnDataHoraFin});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(41, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1278, 576);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.TabStop = false;
            this.dataGridView1.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView1_CellFormatting);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.panel2.Controls.Add(this.btnPause);
            this.panel2.Controls.Add(this.btnPlay);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(41, 576);
            this.panel2.TabIndex = 2;
            // 
            // btnPause
            // 
            this.btnPause.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPause.FlatAppearance.BorderSize = 0;
            this.btnPause.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPause.Image = global::SistemaTHR.Properties.Resources.pause;
            this.btnPause.Location = new System.Drawing.Point(0, 41);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(41, 32);
            this.btnPause.TabIndex = 2;
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnPlay
            // 
            this.btnPlay.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnPlay.FlatAppearance.BorderSize = 0;
            this.btnPlay.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
            this.btnPlay.Location = new System.Drawing.Point(0, 0);
            this.btnPlay.Name = "btnPlay";
            this.btnPlay.Size = new System.Drawing.Size(41, 41);
            this.btnPlay.TabIndex = 1;
            this.btnPlay.UseVisualStyleBackColor = true;
            this.btnPlay.Click += new System.EventHandler(this.btnPlay_Click);
            // 
            // clNOP
            // 
            this.clNOP.DataPropertyName = "NOP";
            this.clNOP.HeaderText = "OS";
            this.clNOP.Name = "clNOP";
            this.clNOP.ReadOnly = true;
            this.clNOP.Width = 50;
            // 
            // clnDescricao
            // 
            this.clnDescricao.DataPropertyName = "DescricaoServico";
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Visible = false;
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
            this.clDataHoraGeracao.Width = 150;
            // 
            // clUsuarioSolicitacao
            // 
            this.clUsuarioSolicitacao.DataPropertyName = "usuarioSolicitacao";
            this.clUsuarioSolicitacao.HeaderText = "Usuário/ Solic.";
            this.clUsuarioSolicitacao.Name = "clUsuarioSolicitacao";
            this.clUsuarioSolicitacao.ReadOnly = true;
            this.clUsuarioSolicitacao.Width = 120;
            // 
            // clnASE
            // 
            this.clnASE.DataPropertyName = "ASE";
            this.clnASE.HeaderText = "ASE";
            this.clnASE.Name = "clnASE";
            this.clnASE.ReadOnly = true;
            this.clnASE.Visible = false;
            // 
            // clnCategoria
            // 
            this.clnCategoria.DataPropertyName = "Categoria";
            this.clnCategoria.HeaderText = "Categ.";
            this.clnCategoria.Name = "clnCategoria";
            this.clnCategoria.ReadOnly = true;
            // 
            // clnDataIdeal
            // 
            this.clnDataIdeal.DataPropertyName = "DataIdeal";
            this.clnDataIdeal.HeaderText = "Data Ideal";
            this.clnDataIdeal.Name = "clnDataIdeal";
            this.clnDataIdeal.ReadOnly = true;
            this.clnDataIdeal.Visible = false;
            this.clnDataIdeal.Width = 150;
            // 
            // clPrioridade
            // 
            this.clPrioridade.DataPropertyName = "Prioridade";
            this.clPrioridade.HeaderText = "Prior.";
            this.clPrioridade.Name = "clPrioridade";
            this.clPrioridade.ReadOnly = true;
            // 
            // clnUsuarioPrioridade
            // 
            this.clnUsuarioPrioridade.DataPropertyName = "UsuarioPrioridade";
            this.clnUsuarioPrioridade.HeaderText = "Usuário/Prioridade";
            this.clnUsuarioPrioridade.Name = "clnUsuarioPrioridade";
            this.clnUsuarioPrioridade.ReadOnly = true;
            this.clnUsuarioPrioridade.Visible = false;
            // 
            // clnDataHoraPrioridade
            // 
            this.clnDataHoraPrioridade.DataPropertyName = "DataHoraPrioridade";
            this.clnDataHoraPrioridade.HeaderText = "Data/Hora Prioridade";
            this.clnDataHoraPrioridade.Name = "clnDataHoraPrioridade";
            this.clnDataHoraPrioridade.ReadOnly = true;
            this.clnDataHoraPrioridade.Visible = false;
            // 
            // clStatus
            // 
            this.clStatus.DataPropertyName = "StatusOP";
            this.clStatus.HeaderText = "Status";
            this.clStatus.Name = "clStatus";
            this.clStatus.ReadOnly = true;
            this.clStatus.Width = 200;
            // 
            // clnDataHoraFin
            // 
            this.clnDataHoraFin.DataPropertyName = "DataHoraFinalizacao";
            this.clnDataHoraFin.HeaderText = "Data/Hora Fin.";
            this.clnDataHoraFin.Name = "clnDataHoraFin";
            this.clnDataHoraFin.ReadOnly = true;
            this.clnDataHoraFin.Visible = false;
            // 
            // frmPainelManutencoesTHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1319, 576);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPainelManutencoesTHR";
            this.Text = "Painel de Manutenções";
            this.Load += new System.EventHandler(this.frmPainelManutencoesTHR_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.Button btnPlay;
        private System.Windows.Forms.DataGridViewTextBoxColumn clNOP;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clTipoServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn clDataHoraGeracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clUsuarioSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnASE;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataIdeal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clPrioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioPrioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraPrioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraFin;
    }
}