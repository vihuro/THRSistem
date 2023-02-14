namespace SistemaTHR.Apllication.Manutencao
{
    partial class frmFiltroRequisicoesPeca
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
            this.cboAondeSeraUsado = new System.Windows.Forms.ComboBox();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnPesquisar = new System.Windows.Forms.Button();
            this.txtUnidade = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtDescricao = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbAutorizado = new System.Windows.Forms.CheckBox();
            this.chbAguardandoAutorizacao = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // cboAondeSeraUsado
            // 
            this.cboAondeSeraUsado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAondeSeraUsado.FormattingEnabled = true;
            this.cboAondeSeraUsado.Items.AddRange(new object[] {
            ""});
            this.cboAondeSeraUsado.Location = new System.Drawing.Point(137, 91);
            this.cboAondeSeraUsado.Margin = new System.Windows.Forms.Padding(4);
            this.cboAondeSeraUsado.Name = "cboAondeSeraUsado";
            this.cboAondeSeraUsado.Size = new System.Drawing.Size(387, 24);
            this.cboAondeSeraUsado.TabIndex = 4;
            this.cboAondeSeraUsado.SelectedValueChanged += new System.EventHandler(this.cboAondeSeraUsado_SelectedValueChanged);
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.Location = new System.Drawing.Point(16, 338);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(100, 28);
            this.btnFiltrar.TabIndex = 7;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Location = new System.Drawing.Point(490, 338);
            this.btnFechar.Margin = new System.Windows.Forms.Padding(4);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(100, 28);
            this.btnFechar.TabIndex = 8;
            this.btnFechar.Text = "Fechar";
            this.btnFechar.UseVisualStyleBackColor = true;
            this.btnFechar.Click += new System.EventHandler(this.btnFechar_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.btnPesquisar);
            this.groupBox1.Controls.Add(this.txtUnidade);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.txtDescricao);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.txtCodigo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.cboAondeSeraUsado);
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4);
            this.groupBox1.Size = new System.Drawing.Size(574, 168);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Filtro";
            // 
            // btnPesquisar
            // 
            this.btnPesquisar.FlatAppearance.BorderSize = 0;
            this.btnPesquisar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPesquisar.Image = global::SistemaTHR.Properties.Resources.seo;
            this.btnPesquisar.Location = new System.Drawing.Point(283, 16);
            this.btnPesquisar.Name = "btnPesquisar";
            this.btnPesquisar.Size = new System.Drawing.Size(36, 23);
            this.btnPesquisar.TabIndex = 2;
            this.btnPesquisar.UseVisualStyleBackColor = true;
            this.btnPesquisar.Click += new System.EventHandler(this.btnPesquisar_Click);
            // 
            // txtUnidade
            // 
            this.txtUnidade.Enabled = false;
            this.txtUnidade.Location = new System.Drawing.Point(470, 48);
            this.txtUnidade.Name = "txtUnidade";
            this.txtUnidade.Size = new System.Drawing.Size(54, 22);
            this.txtUnidade.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(40, 16);
            this.label4.TabIndex = 6;
            this.label4.Text = "UND.";
            // 
            // txtDescricao
            // 
            this.txtDescricao.Enabled = false;
            this.txtDescricao.Location = new System.Drawing.Point(137, 45);
            this.txtDescricao.Name = "txtDescricao";
            this.txtDescricao.Size = new System.Drawing.Size(282, 22);
            this.txtDescricao.TabIndex = 2;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Descrição:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(137, 17);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(142, 22);
            this.txtCodigo.TabIndex = 0;
            this.txtCodigo.TextChanged += new System.EventHandler(this.txtCodigo_TextChanged);
            this.txtCodigo.Leave += new System.EventHandler(this.txtCodigo_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 16);
            this.label2.TabIndex = 2;
            this.label2.Text = "Código:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(121, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Aonde será usado:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.chbAutorizado);
            this.groupBox2.Controls.Add(this.chbAguardandoAutorizacao);
            this.groupBox2.Location = new System.Drawing.Point(16, 199);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(574, 92);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // chbAutorizado
            // 
            this.chbAutorizado.AutoSize = true;
            this.chbAutorizado.Location = new System.Drawing.Point(302, 40);
            this.chbAutorizado.Name = "chbAutorizado";
            this.chbAutorizado.Size = new System.Drawing.Size(117, 20);
            this.chbAutorizado.TabIndex = 6;
            this.chbAutorizado.Text = "AUTORIZADO";
            this.chbAutorizado.UseVisualStyleBackColor = true;
            this.chbAutorizado.CheckedChanged += new System.EventHandler(this.chbAutorizado_CheckedChanged);
            // 
            // chbAguardandoAutorizacao
            // 
            this.chbAguardandoAutorizacao.AutoSize = true;
            this.chbAguardandoAutorizacao.Location = new System.Drawing.Point(21, 40);
            this.chbAguardandoAutorizacao.Name = "chbAguardandoAutorizacao";
            this.chbAguardandoAutorizacao.Size = new System.Drawing.Size(209, 20);
            this.chbAguardandoAutorizacao.TabIndex = 5;
            this.chbAguardandoAutorizacao.Text = "AGUARDANDO/AUT. PEÇAS";
            this.chbAguardandoAutorizacao.UseVisualStyleBackColor = true;
            this.chbAguardandoAutorizacao.CheckedChanged += new System.EventHandler(this.chbAguardandoAutorizacao_CheckedChanged);
            // 
            // frmFiltroRequisicoesPeca
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 393);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnFiltrar);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFiltroRequisicoesPeca";
            this.ShowIcon = false;
            this.Text = "Filtro";
            this.Load += new System.EventHandler(this.frmFiltroRequisicoesPeca_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox cboAondeSeraUsado;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbAutorizado;
        private System.Windows.Forms.CheckBox chbAguardandoAutorizacao;
        private System.Windows.Forms.Button btnPesquisar;
        public System.Windows.Forms.TextBox txtUnidade;
        public System.Windows.Forms.TextBox txtDescricao;
        public System.Windows.Forms.TextBox txtCodigo;
    }
}