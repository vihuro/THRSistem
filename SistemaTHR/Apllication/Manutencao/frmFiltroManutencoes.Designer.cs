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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
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
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.clnNumeroOrdemServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDescricaoServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnTipoServico = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraGeracao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioSolicitacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnAondeSeraExecutado = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnCategoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataideal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnPrioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnUsuarioPrioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraPrioridade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clnDataHoraFinalizacao = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cboAondeSeraExcecutado = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cboTipoServico = new System.Windows.Forms.ComboBox();
            this.cboUsuarioSolicitacao = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chbPecasAutorizadas = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.White;
            this.groupBox1.Controls.Add(this.chbPecasAutorizadas);
            this.groupBox1.Controls.Add(this.chbOsFinalizada);
            this.groupBox1.Controls.Add(this.chbManInc);
            this.groupBox1.Controls.Add(this.chbManFin);
            this.groupBox1.Controls.Add(this.chbAutPeca);
            this.groupBox1.Controls.Add(this.chbOsINC);
            this.groupBox1.Controls.Add(this.chbManIni);
            this.groupBox1.Controls.Add(this.chbEmAberto);
            this.groupBox1.Location = new System.Drawing.Point(493, 19);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(381, 181);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Status";
            // 
            // chbOsFinalizada
            // 
            this.chbOsFinalizada.AutoSize = true;
            this.chbOsFinalizada.Location = new System.Drawing.Point(255, 52);
            this.chbOsFinalizada.Name = "chbOsFinalizada";
            this.chbOsFinalizada.Size = new System.Drawing.Size(93, 17);
            this.chbOsFinalizada.TabIndex = 7;
            this.chbOsFinalizada.Text = "OS/Finalizada";
            this.chbOsFinalizada.UseVisualStyleBackColor = true;
            this.chbOsFinalizada.CheckedChanged += new System.EventHandler(this.chbOsFinalizada_CheckedChanged);
            // 
            // chbManInc
            // 
            this.chbManInc.AutoSize = true;
            this.chbManInc.Location = new System.Drawing.Point(255, 29);
            this.chbManInc.Name = "chbManInc";
            this.chbManInc.Size = new System.Drawing.Size(106, 17);
            this.chbManInc.TabIndex = 6;
            this.chbManInc.Text = "Manutenção/NC";
            this.chbManInc.UseVisualStyleBackColor = true;
            this.chbManInc.CheckedChanged += new System.EventHandler(this.chbManInc_CheckedChanged);
            // 
            // chbManFin
            // 
            this.chbManFin.AutoSize = true;
            this.chbManFin.Location = new System.Drawing.Point(19, 144);
            this.chbManFin.Name = "chbManFin";
            this.chbManFin.Size = new System.Drawing.Size(108, 17);
            this.chbManFin.TabIndex = 5;
            this.chbManFin.Text = "Manutenção/FIN";
            this.chbManFin.UseVisualStyleBackColor = true;
            this.chbManFin.CheckedChanged += new System.EventHandler(this.chbManFin_CheckedChanged);
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
            this.chbAutPeca.CheckedChanged += new System.EventHandler(this.chbAutPeca_CheckedChanged);
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
            this.chbOsINC.CheckedChanged += new System.EventHandler(this.chbOsINC_CheckedChanged);
            // 
            // chbManIni
            // 
            this.chbManIni.AutoSize = true;
            this.chbManIni.Location = new System.Drawing.Point(19, 52);
            this.chbManIni.Name = "chbManIni";
            this.chbManIni.Size = new System.Drawing.Size(105, 17);
            this.chbManIni.TabIndex = 1;
            this.chbManIni.Text = "Manutenção/INI";
            this.chbManIni.UseVisualStyleBackColor = true;
            this.chbManIni.CheckedChanged += new System.EventHandler(this.chbManIni_CheckedChanged);
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
            this.btnFiltrar.Location = new System.Drawing.Point(15, 633);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(75, 23);
            this.btnFiltrar.TabIndex = 1;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = true;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.Location = new System.Drawing.Point(827, 633);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(75, 23);
            this.btnLimpar.TabIndex = 2;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = true;
            this.btnLimpar.Click += new System.EventHandler(this.btnLimpar_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.AllowUserToResizeRows = false;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle10.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle10.SelectionForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle10.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle10;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clnNumeroOrdemServico,
            this.clnDescricaoServico,
            this.clnTipoServico,
            this.clnDataHoraGeracao,
            this.clnUsuarioSolicitacao,
            this.clnAondeSeraExecutado,
            this.clnCategoria,
            this.clnDataideal,
            this.clnPrioridade,
            this.clnUsuarioPrioridade,
            this.clnDataHoraPrioridade,
            this.clnStatus,
            this.clnDataHoraFinalizacao});
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle11;
            this.dataGridView1.EnableHeadersVisualStyles = false;
            this.dataGridView1.Location = new System.Drawing.Point(15, 255);
            this.dataGridView1.MultiSelect = false;
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView1.RowHeadersDefaultCellStyle = dataGridViewCellStyle12;
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView1.Size = new System.Drawing.Size(887, 338);
            this.dataGridView1.TabIndex = 3;
            // 
            // clnNumeroOrdemServico
            // 
            this.clnNumeroOrdemServico.DataPropertyName = "NOP";
            this.clnNumeroOrdemServico.HeaderText = "Nº OS";
            this.clnNumeroOrdemServico.Name = "clnNumeroOrdemServico";
            this.clnNumeroOrdemServico.ReadOnly = true;
            this.clnNumeroOrdemServico.Width = 70;
            // 
            // clnDescricaoServico
            // 
            this.clnDescricaoServico.DataPropertyName = "DescricaoServico";
            this.clnDescricaoServico.HeaderText = "Descrição";
            this.clnDescricaoServico.Name = "clnDescricaoServico";
            this.clnDescricaoServico.ReadOnly = true;
            // 
            // clnTipoServico
            // 
            this.clnTipoServico.DataPropertyName = "TipoServico";
            this.clnTipoServico.HeaderText = "Serviço";
            this.clnTipoServico.Name = "clnTipoServico";
            this.clnTipoServico.ReadOnly = true;
            this.clnTipoServico.Width = 80;
            // 
            // clnDataHoraGeracao
            // 
            this.clnDataHoraGeracao.DataPropertyName = "DataHoraGeracao";
            this.clnDataHoraGeracao.HeaderText = "Data/Hora Geração";
            this.clnDataHoraGeracao.Name = "clnDataHoraGeracao";
            this.clnDataHoraGeracao.ReadOnly = true;
            // 
            // clnUsuarioSolicitacao
            // 
            this.clnUsuarioSolicitacao.DataPropertyName = "UsuarioSolicitacao";
            this.clnUsuarioSolicitacao.HeaderText = "Usuário / Solic.";
            this.clnUsuarioSolicitacao.Name = "clnUsuarioSolicitacao";
            this.clnUsuarioSolicitacao.ReadOnly = true;
            // 
            // clnAondeSeraExecutado
            // 
            this.clnAondeSeraExecutado.DataPropertyName = "ASE";
            this.clnAondeSeraExecutado.HeaderText = "ASE.";
            this.clnAondeSeraExecutado.Name = "clnAondeSeraExecutado";
            this.clnAondeSeraExecutado.ReadOnly = true;
            // 
            // clnCategoria
            // 
            this.clnCategoria.DataPropertyName = "Categoria";
            this.clnCategoria.HeaderText = "Categoria";
            this.clnCategoria.Name = "clnCategoria";
            this.clnCategoria.ReadOnly = true;
            // 
            // clnDataideal
            // 
            this.clnDataideal.DataPropertyName = "DataIdeal";
            this.clnDataideal.HeaderText = "Data / Ideal";
            this.clnDataideal.Name = "clnDataideal";
            this.clnDataideal.ReadOnly = true;
            // 
            // clnPrioridade
            // 
            this.clnPrioridade.DataPropertyName = "Prioridade";
            this.clnPrioridade.HeaderText = "Priodade";
            this.clnPrioridade.Name = "clnPrioridade";
            this.clnPrioridade.ReadOnly = true;
            // 
            // clnUsuarioPrioridade
            // 
            this.clnUsuarioPrioridade.DataPropertyName = "UsuarioPrioridade";
            this.clnUsuarioPrioridade.HeaderText = "Usuário / Priori.";
            this.clnUsuarioPrioridade.Name = "clnUsuarioPrioridade";
            this.clnUsuarioPrioridade.ReadOnly = true;
            // 
            // clnDataHoraPrioridade
            // 
            this.clnDataHoraPrioridade.DataPropertyName = "DataHoraPrioridade";
            this.clnDataHoraPrioridade.HeaderText = "Data/Hora Priori.";
            this.clnDataHoraPrioridade.Name = "clnDataHoraPrioridade";
            this.clnDataHoraPrioridade.ReadOnly = true;
            // 
            // clnStatus
            // 
            this.clnStatus.DataPropertyName = "StatusOP";
            this.clnStatus.HeaderText = "Status";
            this.clnStatus.Name = "clnStatus";
            this.clnStatus.ReadOnly = true;
            // 
            // clnDataHoraFinalizacao
            // 
            this.clnDataHoraFinalizacao.DataPropertyName = "DataHoraFinalizacao";
            this.clnDataHoraFinalizacao.HeaderText = "Data/hora Fin";
            this.clnDataHoraFinalizacao.Name = "clnDataHoraFinalizacao";
            this.clnDataHoraFinalizacao.ReadOnly = true;
            this.clnDataHoraFinalizacao.Visible = false;
            // 
            // cboAondeSeraExcecutado
            // 
            this.cboAondeSeraExcecutado.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAondeSeraExcecutado.FormattingEnabled = true;
            this.cboAondeSeraExcecutado.Items.AddRange(new object[] {
            ""});
            this.cboAondeSeraExcecutado.Location = new System.Drawing.Point(141, 53);
            this.cboAondeSeraExcecutado.Name = "cboAondeSeraExcecutado";
            this.cboAondeSeraExcecutado.Size = new System.Drawing.Size(249, 21);
            this.cboAondeSeraExcecutado.TabIndex = 0;
            this.cboAondeSeraExcecutado.TextChanged += new System.EventHandler(this.cboAondeSeraExcecutado_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(6, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(117, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Aonde será executado:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(6, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Tipo de Serviço:";
            // 
            // cboTipoServico
            // 
            this.cboTipoServico.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoServico.FormattingEnabled = true;
            this.cboTipoServico.Items.AddRange(new object[] {
            ""});
            this.cboTipoServico.Location = new System.Drawing.Point(141, 99);
            this.cboTipoServico.Name = "cboTipoServico";
            this.cboTipoServico.Size = new System.Drawing.Size(249, 21);
            this.cboTipoServico.TabIndex = 1;
            this.cboTipoServico.TextChanged += new System.EventHandler(this.cboTipoServico_TextChanged);
            // 
            // cboUsuarioSolicitacao
            // 
            this.cboUsuarioSolicitacao.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboUsuarioSolicitacao.FormattingEnabled = true;
            this.cboUsuarioSolicitacao.Items.AddRange(new object[] {
            ""});
            this.cboUsuarioSolicitacao.Location = new System.Drawing.Point(141, 145);
            this.cboUsuarioSolicitacao.Name = "cboUsuarioSolicitacao";
            this.cboUsuarioSolicitacao.Size = new System.Drawing.Size(249, 21);
            this.cboUsuarioSolicitacao.TabIndex = 2;
            this.cboUsuarioSolicitacao.TextChanged += new System.EventHandler(this.cboUsuarioSolicitacao_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(101, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Usuário Solicitação:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.White;
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.groupBox1);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(890, 237);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filtro";
            // 
            // chbPecasAutorizadas
            // 
            this.chbPecasAutorizadas.AutoSize = true;
            this.chbPecasAutorizadas.Location = new System.Drawing.Point(19, 121);
            this.chbPecasAutorizadas.Name = "chbPecasAutorizadas";
            this.chbPecasAutorizadas.Size = new System.Drawing.Size(114, 17);
            this.chbPecasAutorizadas.TabIndex = 8;
            this.chbPecasAutorizadas.Text = "Peças Autorizadas";
            this.chbPecasAutorizadas.UseVisualStyleBackColor = true;
            this.chbPecasAutorizadas.CheckedChanged += new System.EventHandler(this.chbPecasAutorizadas_CheckedChanged);
            // 
            // frmFiltroManutencoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 681);
            this.Controls.Add(this.cboUsuarioSolicitacao);
            this.Controls.Add(this.cboTipoServico);
            this.Controls.Add(this.cboAondeSeraExcecutado);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.groupBox2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmFiltroManutencoes";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Filtrar Manutenções";
            this.Load += new System.EventHandler(this.frmFiltroManutencoes_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ComboBox cboAondeSeraExcecutado;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnNumeroOrdemServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDescricaoServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnTipoServico;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraGeracao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioSolicitacao;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnAondeSeraExecutado;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnCategoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataideal;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnPrioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnUsuarioPrioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraPrioridade;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn clnDataHoraFinalizacao;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cboTipoServico;
        private System.Windows.Forms.ComboBox cboUsuarioSolicitacao;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chbPecasAutorizadas;
    }
}