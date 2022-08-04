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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPainelQuarentena));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtData = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.clnNFicha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnLote = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clndataIniAnalise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraFinAnali = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraFinProd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTempoAnalise = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToOrderColumns = true;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNFicha,
            this.clnLote,
            this.clnDescricao,
            this.clnCodigo,
            this.clndataIniAnalise,
            this.clnDataHoraFinAnali,
            this.clnDataHoraFinProd,
            this.clnTempoAnalise,
            this.clnStatus});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.Location = new System.Drawing.Point(0, 61);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
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
            this.txtData.Size = new System.Drawing.Size(328, 32);
            this.txtData.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
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
            // clnDescricao
            // 
            this.clnDescricao.DataPropertyName = "descricao";
            this.clnDescricao.HeaderText = "Descrição";
            this.clnDescricao.Name = "clnDescricao";
            this.clnDescricao.ReadOnly = true;
            this.clnDescricao.Width = 250;
            // 
            // clnCodigo
            // 
            this.clnCodigo.DataPropertyName = "codigo";
            this.clnCodigo.HeaderText = "Código";
            this.clnCodigo.Name = "clnCodigo";
            this.clnCodigo.ReadOnly = true;
            this.clnCodigo.Visible = false;
            // 
            // clndataIniAnalise
            // 
            this.clndataIniAnalise.DataPropertyName = "dataHoraIniAnalise";
            this.clndataIniAnalise.HeaderText = "Data/Hora Ini/Analise";
            this.clndataIniAnalise.Name = "clndataIniAnalise";
            this.clndataIniAnalise.ReadOnly = true;
            this.clndataIniAnalise.Width = 200;
            // 
            // clnDataHoraFinAnali
            // 
            this.clnDataHoraFinAnali.DataPropertyName = "dataHoraFinAnalise";
            this.clnDataHoraFinAnali.HeaderText = "Data/Hora Fin/Anali";
            this.clnDataHoraFinAnali.Name = "clnDataHoraFinAnali";
            this.clnDataHoraFinAnali.ReadOnly = true;
            this.clnDataHoraFinAnali.Width = 200;
            // 
            // clnDataHoraFinProd
            // 
            this.clnDataHoraFinProd.HeaderText = "Data/Hora fin/Prod";
            this.clnDataHoraFinProd.Name = "clnDataHoraFinProd";
            this.clnDataHoraFinProd.ReadOnly = true;
            this.clnDataHoraFinProd.Visible = false;
            // 
            // clnTempoAnalise
            // 
            this.clnTempoAnalise.DataPropertyName = "tempoAnalise";
            this.clnTempoAnalise.HeaderText = "Tempo/Analise";
            this.clnTempoAnalise.Name = "clnTempoAnalise";
            this.clnTempoAnalise.ReadOnly = true;
            this.clnTempoAnalise.Width = 250;
            // 
            // clnStatus
            // 
            this.clnStatus.DataPropertyName = "Status";
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
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
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clndataIniAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraFinAnali;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraFinProd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTempoAnalise;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
    }
}