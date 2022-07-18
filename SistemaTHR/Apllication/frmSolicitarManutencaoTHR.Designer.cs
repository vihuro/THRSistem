namespace SistemaTHR.Apllication
{
    partial class frmSolicitarManutencaoTHR
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
            this.label1 = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.lblUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoServico = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.lblCaractere = new System.Windows.Forms.Label();
            this.cboAondeSera = new System.Windows.Forms.ComboBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.txtDataIdeal = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(166, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Aonde o serviço será executado?";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.lblUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 424);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(315, 22);
            this.statusStrip1.TabIndex = 2;
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
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Tipo de Serviço:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // cboTipoServico
            // 
            this.cboTipoServico.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboTipoServico.FormattingEnabled = true;
            this.cboTipoServico.Items.AddRange(new object[] {
            "Elétrico",
            "Mecânico",
            "Serralheria",
            "Jardinagem",
            "Alvenaria"});
            this.cboTipoServico.Location = new System.Drawing.Point(19, 94);
            this.cboTipoServico.Name = "cboTipoServico";
            this.cboTipoServico.Size = new System.Drawing.Size(121, 21);
            this.cboTipoServico.TabIndex = 1;
            this.cboTipoServico.SelectedIndexChanged += new System.EventHandler(this.cboTipoServico_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(16, 212);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Descreva o serviço:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // txtDescricao
            // 
            this.txtDescricao.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDescricao.Location = new System.Drawing.Point(16, 229);
            this.txtDescricao.MaxLength = 1000;
            this.txtDescricao.Multiline = true;
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(287, 121);
            this.txtDescricao.TabIndex = 3;
            this.txtDescricao.TextChanged += new System.EventHandler(this.txtDescricao_TextChanged);
            // 
            // lblCaractere
            // 
            this.lblCaractere.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCaractere.AutoSize = true;
            this.lblCaractere.Location = new System.Drawing.Point(16, 357);
            this.lblCaractere.Name = "lblCaractere";
            this.lblCaractere.Size = new System.Drawing.Size(134, 13);
            this.lblCaractere.TabIndex = 7;
            this.lblCaractere.Text = "Caracteres restantes: 1000";
            this.lblCaractere.Click += new System.EventHandler(this.lblCaractere_Click);
            // 
            // cboAondeSera
            // 
            this.cboAondeSera.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cboAondeSera.FormattingEnabled = true;
            this.cboAondeSera.Items.AddRange(new object[] {
            "EXT-PP 01",
            "EXT-PP 02",
            "EXT-PP 03",
            "EXT-PP 04",
            "EXT-PP 05",
            "EXT-FITILHO ",
            "EXT-PET 12",
            "EXT-PET 13",
            "EXT-PET 14",
            "EXT-RECUP. 06",
            "EXT-BALÂO MONO",
            "EXT-BALÂO COEX",
            "EXT-PLANA",
            "REBOB. 12",
            "REBOB. 13",
            "REBOB. 14",
            "REBOB. 15",
            "REBOB. 16",
            "REBOB. 17",
            "REBOB. 18",
            "REBOB. 19",
            "REBOB. 20",
            "REBOB. 21",
            "REBOB. 22",
            "REBOB. 23",
            "CORTE. 01",
            "CORTE. 02",
            "CORTE. 03",
            "CORTE. 04",
            "MOINHO",
            "CQ",
            "PCP",
            "EXPEDIÇÂO",
            "ESTOQUE",
            "ADMINISTRATIVO",
            "REFEITORIO",
            "AREA EXTERNA"});
            this.cboAondeSera.Location = new System.Drawing.Point(19, 30);
            this.cboAondeSera.Name = "cboAondeSera";
            this.cboAondeSera.Size = new System.Drawing.Size(121, 21);
            this.cboAondeSera.TabIndex = 0;
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Location = new System.Drawing.Point(16, 388);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 4;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCancelar.Location = new System.Drawing.Point(228, 388);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(75, 23);
            this.btnCancelar.TabIndex = 5;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // txtDataIdeal
            // 
            this.txtDataIdeal.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDataIdeal.Location = new System.Drawing.Point(19, 155);
            this.txtDataIdeal.Name = "txtDataIdeal";
            this.txtDataIdeal.Size = new System.Drawing.Size(100, 20);
            this.txtDataIdeal.TabIndex = 2;
            this.txtDataIdeal.TextChanged += new System.EventHandler(this.txtDataIdeal_TextChanged);
            // 
            // label4
            // 
            this.label4.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(16, 139);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(185, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Data ideal para realização do serviço:";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // frmSolicitarManutencaoTHR
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(315, 446);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtDataIdeal);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.cboAondeSera);
            this.Controls.Add(this.lblCaractere);
            this.Controls.Add(this.txtDescricao);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cboTipoServico);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSolicitarManutencaoTHR";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Solicitar Manutenção";
            this.Load += new System.EventHandler(this.frmSolicitarManutencaoTHR_Load);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        public System.Windows.Forms.ToolStripStatusLabel lblUsuario;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoServico;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtDescricao;
        private System.Windows.Forms.Label lblCaractere;
        private System.Windows.Forms.ComboBox cboAondeSera;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.TextBox txtDataIdeal;
        private System.Windows.Forms.Label label4;
    }
}