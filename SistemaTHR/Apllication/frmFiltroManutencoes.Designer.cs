namespace SistemaTHR.Apllication
{
    partial class frmFiltroManutencoes
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.chbOsFinalizada = new System.Windows.Forms.CheckBox();
            this.chbManInc = new System.Windows.Forms.CheckBox();
            this.chbManFin = new System.Windows.Forms.CheckBox();
            this.chbAutPeca = new System.Windows.Forms.CheckBox();
            this.chbOsINC = new System.Windows.Forms.CheckBox();
            this.chbManIni = new System.Windows.Forms.CheckBox();
            this.chbEmAberto = new System.Windows.Forms.CheckBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.chbOsFinalizada);
            this.groupBox1.Controls.Add(this.chbManInc);
            this.groupBox1.Controls.Add(this.chbManFin);
            this.groupBox1.Controls.Add(this.chbAutPeca);
            this.groupBox1.Controls.Add(this.chbOsINC);
            this.groupBox1.Controls.Add(this.chbManIni);
            this.groupBox1.Controls.Add(this.chbEmAberto);
            this.groupBox1.Location = new System.Drawing.Point(186, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 206);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // chbOsFinalizada
            // 
            this.chbOsFinalizada.AutoSize = true;
            this.chbOsFinalizada.Location = new System.Drawing.Point(19, 167);
            this.chbOsFinalizada.Name = "chbOsFinalizada";
            this.chbOsFinalizada.Size = new System.Drawing.Size(91, 17);
            this.chbOsFinalizada.TabIndex = 6;
            this.chbOsFinalizada.Text = "OS Finalizada";
            this.chbOsFinalizada.UseVisualStyleBackColor = true;
            // 
            // chbManInc
            // 
            this.chbManInc.AutoSize = true;
            this.chbManInc.Location = new System.Drawing.Point(19, 144);
            this.chbManInc.Name = "chbManInc";
            this.chbManInc.Size = new System.Drawing.Size(106, 17);
            this.chbManInc.TabIndex = 5;
            this.chbManInc.Text = "Manutenção/NC";
            this.chbManInc.UseVisualStyleBackColor = true;
            // 
            // chbManFin
            // 
            this.chbManFin.AutoSize = true;
            this.chbManFin.Location = new System.Drawing.Point(19, 121);
            this.chbManFin.Name = "chbManFin";
            this.chbManFin.Size = new System.Drawing.Size(136, 17);
            this.chbManFin.TabIndex = 4;
            this.chbManFin.Text = "Manutenção Finalizada";
            this.chbManFin.UseVisualStyleBackColor = true;
            // 
            // chbAutPeca
            // 
            this.chbAutPeca.AutoSize = true;
            this.chbAutPeca.Location = new System.Drawing.Point(19, 98);
            this.chbAutPeca.Name = "chbAutPeca";
            this.chbAutPeca.Size = new System.Drawing.Size(142, 17);
            this.chbAutPeca.TabIndex = 3;
            this.chbAutPeca.Text = "Aguardando/AUT. Peça";
            this.chbAutPeca.UseVisualStyleBackColor = true;
            // 
            // chbOsINC
            // 
            this.chbOsINC.AutoSize = true;
            this.chbOsINC.Location = new System.Drawing.Point(19, 75);
            this.chbOsINC.Name = "chbOsINC";
            this.chbOsINC.Size = new System.Drawing.Size(64, 17);
            this.chbOsINC.TabIndex = 2;
            this.chbOsINC.Text = "OS/INC";
            this.chbOsINC.UseVisualStyleBackColor = true;
            // 
            // chbManIni
            // 
            this.chbManIni.AutoSize = true;
            this.chbManIni.Location = new System.Drawing.Point(19, 52);
            this.chbManIni.Name = "chbManIni";
            this.chbManIni.Size = new System.Drawing.Size(126, 17);
            this.chbManIni.TabIndex = 1;
            this.chbManIni.Text = "Manutenção Iniciada";
            this.chbManIni.UseVisualStyleBackColor = true;
            // 
            // chbEmAberto
            // 
            this.chbEmAberto.AutoSize = true;
            this.chbEmAberto.Location = new System.Drawing.Point(19, 29);
            this.chbEmAberto.Name = "chbEmAberto";
            this.chbEmAberto.Size = new System.Drawing.Size(75, 17);
            this.chbEmAberto.TabIndex = 0;
            this.chbEmAberto.Text = "Em Aberto";
            this.chbEmAberto.UseVisualStyleBackColor = true;
            this.chbEmAberto.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(186, 346);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(311, 346);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // frmFiltroManutencoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(398, 381);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmFiltroManutencoes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtrar Manutenções";
            this.Load += new System.EventHandler(this.frmFiltroManutencoes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox chbEmAberto;
        private System.Windows.Forms.CheckBox chbManFin;
        private System.Windows.Forms.CheckBox chbAutPeca;
        private System.Windows.Forms.CheckBox chbOsINC;
        private System.Windows.Forms.CheckBox chbManIni;
        private System.Windows.Forms.CheckBox chbOsFinalizada;
        private System.Windows.Forms.CheckBox chbManInc;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnLimpar;
    }
}