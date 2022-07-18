namespace SistemaTHR.Apllication
{
    partial class frmObservacoes
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
            this.txtObservaco = new System.Windows.Forms.TextBox();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnFechar = new System.Windows.Forms.Button();
            this.lblCaractere = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtObservaco
            // 
            this.txtObservaco.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtObservaco.Location = new System.Drawing.Point(0, 0);
            this.txtObservaco.MaxLength = 1000;
            this.txtObservaco.Multiline = true;
            this.txtObservaco.Name = "txtObservaco";
            this.txtObservaco.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtObservaco.Size = new System.Drawing.Size(412, 205);
            this.txtObservaco.TabIndex = 0;
            this.txtObservaco.TextChanged += new System.EventHandler(this.txtObservaco_TextChanged);
            // 
            // btnSalvar
            // 
            this.btnSalvar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSalvar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnSalvar.Location = new System.Drawing.Point(260, 245);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(75, 23);
            this.btnSalvar.TabIndex = 1;
            this.btnSalvar.Text = "Ok";
            this.btnSalvar.UseVisualStyleBackColor = true;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnFechar
            // 
            this.btnFechar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnFechar.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.btnFechar.Location = new System.Drawing.Point(349, 245);
            this.btnFechar.Name = "btnFechar";
            this.btnFechar.Size = new System.Drawing.Size(75, 23);
            this.btnFechar.TabIndex = 2;
            this.btnFechar.Text = "Cancelar";
            this.btnFechar.UseVisualStyleBackColor = true;
            // 
            // lblCaractere
            // 
            this.lblCaractere.AutoSize = true;
            this.lblCaractere.Location = new System.Drawing.Point(9, 255);
            this.lblCaractere.Name = "lblCaractere";
            this.lblCaractere.Size = new System.Drawing.Size(134, 13);
            this.lblCaractere.TabIndex = 8;
            this.lblCaractere.Text = "Caracteres restantes: 1000";
            this.lblCaractere.Click += new System.EventHandler(this.lblCaractere_Click);
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.Controls.Add(this.txtObservaco);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(412, 205);
            this.panel1.TabIndex = 9;
            // 
            // frmObservacoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(436, 280);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.lblCaractere);
            this.Controls.Add(this.btnFechar);
            this.Controls.Add(this.btnSalvar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmObservacoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Observação";
            this.Load += new System.EventHandler(this.frmObservacoes_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.TextBox txtObservaco;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnFechar;
        private System.Windows.Forms.Label lblCaractere;
        private System.Windows.Forms.Panel panel1;
    }
}