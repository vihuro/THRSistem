namespace SistemaTHR.Apllication.Compras
{
    partial class frmPequisarEstoque
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnNPeca = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUnidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnQtd = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstoqueMax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnEstoqueMin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoFornencedor1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoFornecedor2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCodigoFornecedor3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioGravacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraGravacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel3 = new System.Windows.Forms.Panel();
            this.Cancelar = new System.Windows.Forms.Button();
            this.btnCarregar = new System.Windows.Forms.Button();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(443, 84);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.dataGridView1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 84);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(443, 280);
            this.panel2.TabIndex = 1;
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
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.DisableResizing;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNPeca,
            this.clnCodigo,
            this.clnDescricao,
            this.clnUnidade,
            this.clnQtd,
            this.clnEstoqueMax,
            this.clnEstoqueMin,
            this.clnCodigoFornencedor1,
            this.clnCodigoFornecedor2,
            this.clnCodigoFornecedor3,
            this.clnUsuarioGravacao,
            this.clnDataHoraGravacao});
            this.dataGridView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(0, 0);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(443, 280);
            this.dataGridView1.TabIndex = 0;
            // 
            // clnNPeca
            // 
            this.clnNPeca.DataPropertyName = "NPeca";
            this.clnNPeca.HeaderText = "Nº Peça";
            this.clnNPeca.Name = "clnNPeca";
            this.clnNPeca.ReadOnly = true;
            this.clnNPeca.Visible = false;
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
            this.clnDescricao.Width = 180;
            // 
            // clnUnidade
            // 
            this.clnUnidade.DataPropertyName = "Unidade";
            this.clnUnidade.HeaderText = "UND.";
            this.clnUnidade.Name = "clnUnidade";
            this.clnUnidade.ReadOnly = true;
            this.clnUnidade.Width = 50;
            // 
            // clnQtd
            // 
            this.clnQtd.DataPropertyName = "QtEstoque";
            this.clnQtd.HeaderText = "QTD.";
            this.clnQtd.Name = "clnQtd";
            this.clnQtd.ReadOnly = true;
            this.clnQtd.Width = 50;
            // 
            // clnEstoqueMax
            // 
            this.clnEstoqueMax.DataPropertyName = "EstoqueMax";
            this.clnEstoqueMax.HeaderText = "Estoque Max";
            this.clnEstoqueMax.Name = "clnEstoqueMax";
            this.clnEstoqueMax.ReadOnly = true;
            this.clnEstoqueMax.Visible = false;
            // 
            // clnEstoqueMin
            // 
            this.clnEstoqueMin.DataPropertyName = "EstoqueMin";
            this.clnEstoqueMin.HeaderText = "Estoque/Min.";
            this.clnEstoqueMin.Name = "clnEstoqueMin";
            this.clnEstoqueMin.ReadOnly = true;
            this.clnEstoqueMin.Visible = false;
            // 
            // clnCodigoFornencedor1
            // 
            this.clnCodigoFornencedor1.DataPropertyName = "CodigoFornecedor1";
            this.clnCodigoFornencedor1.HeaderText = "Código/Forn. 1";
            this.clnCodigoFornencedor1.Name = "clnCodigoFornencedor1";
            this.clnCodigoFornencedor1.ReadOnly = true;
            this.clnCodigoFornencedor1.Visible = false;
            // 
            // clnCodigoFornecedor2
            // 
            this.clnCodigoFornecedor2.DataPropertyName = "CodigoFornecedor2";
            this.clnCodigoFornecedor2.HeaderText = "Código/Forn. 2";
            this.clnCodigoFornecedor2.Name = "clnCodigoFornecedor2";
            this.clnCodigoFornecedor2.ReadOnly = true;
            this.clnCodigoFornecedor2.Visible = false;
            // 
            // clnCodigoFornecedor3
            // 
            this.clnCodigoFornecedor3.DataPropertyName = "CodigoFornecedor3";
            this.clnCodigoFornecedor3.HeaderText = "Código/Forn. 3";
            this.clnCodigoFornecedor3.Name = "clnCodigoFornecedor3";
            this.clnCodigoFornecedor3.ReadOnly = true;
            this.clnCodigoFornecedor3.Visible = false;
            // 
            // clnUsuarioGravacao
            // 
            this.clnUsuarioGravacao.DataPropertyName = "UsuarioGravacao";
            this.clnUsuarioGravacao.HeaderText = "Usuário/Grav.";
            this.clnUsuarioGravacao.Name = "clnUsuarioGravacao";
            this.clnUsuarioGravacao.ReadOnly = true;
            this.clnUsuarioGravacao.Visible = false;
            // 
            // clnDataHoraGravacao
            // 
            this.clnDataHoraGravacao.DataPropertyName = "DataHoraGravacao";
            this.clnDataHoraGravacao.HeaderText = "Data/Hora Grav.";
            this.clnDataHoraGravacao.Name = "clnDataHoraGravacao";
            this.clnDataHoraGravacao.ReadOnly = true;
            this.clnDataHoraGravacao.Visible = false;
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.Cancelar);
            this.panel3.Controls.Add(this.btnCarregar);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel3.Location = new System.Drawing.Point(0, 364);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(443, 61);
            this.panel3.TabIndex = 2;
            // 
            // Cancelar
            // 
            this.Cancelar.Location = new System.Drawing.Point(365, 26);
            this.Cancelar.Name = "Cancelar";
            this.Cancelar.Size = new System.Drawing.Size(75, 23);
            this.Cancelar.TabIndex = 1;
            this.Cancelar.Text = "Cancelar";
            this.Cancelar.UseVisualStyleBackColor = true;
            this.Cancelar.Click += new System.EventHandler(this.Cancelar_Click);
            // 
            // btnCarregar
            // 
            this.btnCarregar.Location = new System.Drawing.Point(284, 26);
            this.btnCarregar.Name = "btnCarregar";
            this.btnCarregar.Size = new System.Drawing.Size(75, 23);
            this.btnCarregar.TabIndex = 0;
            this.btnCarregar.Text = "Carregar";
            this.btnCarregar.UseVisualStyleBackColor = true;
            this.btnCarregar.Click += new System.EventHandler(this.btnCarregar_Click);
            // 
            // frmPequisarEstoque
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 425);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmPequisarEstoque";
            this.ShowIcon = false;
            this.Text = "Estoque";
            this.Load += new System.EventHandler(this.frmPequisarEstoque_Load);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Button Cancelar;
        private System.Windows.Forms.Button btnCarregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNPeca;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUnidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnQtd;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstoqueMax;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnEstoqueMin;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoFornencedor1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoFornecedor2;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCodigoFornecedor3;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioGravacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraGravacao;
    }
}