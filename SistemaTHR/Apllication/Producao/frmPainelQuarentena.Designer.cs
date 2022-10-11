namespace SistemaTHR.Apllication.Producao
{
    partial class frmPainelQuarentena
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPainelQuarentena));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clnNFicha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clndataIniAnalise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioLancamento = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraFinAnali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioFinAnalise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraFinProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioFinProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTempoAnalise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
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
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
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
            this.clnNFicha,
            this.clnLote,
            this.clnCodigo,
            this.clnDescricao,
            this.clndataIniAnalise,
            this.clnUsuarioLancamento,
            this.clnDataHoraFinAnali,
            this.clnUsuarioFinAnalise,
            this.clnDataHoraFinProd,
            this.clnUsuarioFinProd,
            this.clnTempoAnalise,
            this.clnStatus});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 61);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(1215, 389);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.txtData);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1215, 61);
            this.panel1.TabIndex = 1;
            // 
            // txtData
            // 
            this.txtData.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtData.Location = new System.Drawing.Point(348, 12);
            this.txtData.Name = "txtData";
            this.txtData.Size = new System.Drawing.Size(283, 32);
            this.txtData.TabIndex = 0;
            // 
            // 
            // clnNFicha
            // 
            this.clnNFicha.DataPropertyName = "id";
            this.clnNFicha.HeaderText = "Nº";
            this.clnNFicha.Name = "clnNFicha";
            this.clnNFicha.ReadOnly = true;
            this.clnNFicha.Width = 50;
            // 
            // clnLote
            // 
            this.clnLote.DataPropertyName = "Lote";
            this.clnLote.HeaderText = "Lote";
            this.clnLote.Name = "clnLote";
            this.clnLote.ReadOnly = true;
            this.clnLote.Visible = false;
            // 
            // clnCodigo
            // 
            this.clnCodigo.DataPropertyName = "codigo";
            this.clnCodigo.HeaderText = "Código";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            this.clnCodigo.Visible = false;
            // 
            // clnDescricao
            // 
            this.clnDescricao.DataPropertyName = "descricao";
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Visible = false;
            this.clnDescricao.Width = 250;
            // 
            // clndataIniAnalise
            // 
            this.clndataIniAnalise.DataPropertyName = "dataHoraIniAnalise";
            this.clndataIniAnalise.HeaderText = "Data/Hora Ini/Analise";
            this.clndataIniAnalise.Name = "clndataIniAnalise";
            this.clndataIniAnalise.ReadOnly = true;
            this.clndataIniAnalise.Width = 250;
            // 
            // clnUsuarioLancamento
            // 
            this.clnUsuarioLancamento.DataPropertyName = "UsuarioLancamento";
            this.clnUsuarioLancamento.HeaderText = "Usuario/Lancamento";
            this.clnUsuarioLancamento.Name = "clnUsuarioLancamento";
            this.clnUsuarioLancamento.ReadOnly = true;
            this.clnUsuarioLancamento.Visible = false;
            // 
            // clnDataHoraFinAnali
            // 
            this.clnDataHoraFinAnali.DataPropertyName = "dataHoraFinAnalise";
            this.clnDataHoraFinAnali.HeaderText = "Data/Hora Fin/Anali";
            this.clnDataHoraFinAnali.Name = "clnDataHoraFinAnali";
            this.clnDataHoraFinAnali.ReadOnly = true;
            this.clnDataHoraFinAnali.Width = 200;
            // 
            // clnUsuarioFinAnalise
            // 
            this.clnUsuarioFinAnalise.DataPropertyName = "UsuarioFinAnalise";
            this.clnUsuarioFinAnalise.HeaderText = "Usuario/Fin/Analise";
            this.clnUsuarioFinAnalise.Name = "clnUsuarioFinAnalise";
            this.clnUsuarioFinAnalise.ReadOnly = true;
            this.clnUsuarioFinAnalise.Visible = false;
            // 
            // clnDataHoraFinProd
            // 
            this.clnDataHoraFinProd.DataPropertyName = "dataHoraFinProd";
            this.clnDataHoraFinProd.HeaderText = "Data/Hora fin/Prod";
            this.clnDataHoraFinProd.Name = "clnDataHoraFinProd";
            this.clnDataHoraFinProd.ReadOnly = true;
            this.clnDataHoraFinProd.Visible = false;
            // 
            // clnUsuarioFinProd
            // 
            this.clnUsuarioFinProd.DataPropertyName = "UsuarioFinProd";
            this.clnUsuarioFinProd.HeaderText = "Usuario/Fin/Prod";
            this.clnUsuarioFinProd.Name = "clnUsuarioFinProd";
            this.clnUsuarioFinProd.ReadOnly = true;
            this.clnUsuarioFinProd.Visible = false;
            // 
            // clnTempoAnalise
            // 
            this.clnTempoAnalise.DataPropertyName = "tempoAnalise";
            this.clnTempoAnalise.HeaderText = "Tempo/Analise";
            this.clnTempoAnalise.Name = "clnTempoAnalise";
            this.clnTempoAnalise.ReadOnly = true;
            this.clnTempoAnalise.Width = 320;
            // 
            // clnStatus
            // 
            this.clnStatus.DataPropertyName = "Status";
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            this.clnStatus.Width = 150;
            // 
            // frmPainelQuarentena
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1215, 450);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.panel1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmPainelQuarentena";
            this.Text = "frmPainelQuarentena";
            this.Load += new System.EventHandler(this.frmPainelQuarentena_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox txtData;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNFicha;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnLote;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clndataIniAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioLancamento;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraFinAnali;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioFinAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraFinProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioFinProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTempoAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
    }
}