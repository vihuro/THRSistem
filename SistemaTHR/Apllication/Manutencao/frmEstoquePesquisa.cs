﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTHR.Apllication.Estoque;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.Service.manutencao;
using SistemaTHR.Controller.Login;
using SistemaTHR.Apllication.Compras;

namespace SistemaTHR.Apllication.Manutencao
{
    public partial class frmEstoquePesquisa : Form
    {
        private frmEntradaSaidaPecas frmEntradaSaidaPecas;
        private frmRequisicoesPecas frmRequisicaoPecas;
        private frmManutencao frmManutencao;
        private frmEstoquePecas frmEstoquePecas;
        private frmRequisicaoCompra frmCompras;
        private frmMovimentacaPecas frmMovimentacao;

        private EstoquePecasController controller;
        private EstoquePecasService service;


        private loginController loginController;
        private modulosController modulosController;
        private frmFiltroRequisicoesCompra frmFiltroRequisicoesCompra;
        private frmFiltroRequisicoesPeca frmFiltroRequisicaoPeca;

        public frmEstoquePesquisa(frmRequisicoesPecas frmRequisicaoPecas)
        {
            this.frmRequisicaoPecas = frmRequisicaoPecas;
            IniciarService();
            InitializeComponent();
            cboCampo.Text = "Descrição";
        }

        public frmEstoquePesquisa(frmFiltroRequisicoesPeca frmFiltroRequisicaoPeca)
        {
            this.frmFiltroRequisicaoPeca = frmFiltroRequisicaoPeca;
            IniciarService();
            InitializeComponent();
            cboCampo.Text = "Descrição";

        }
        public frmEstoquePesquisa(frmRequisicaoCompra frmCompras)
        {
            this.frmCompras = frmCompras;
            IniciarService();
            InitializeComponent();
            cboCampo.Text = "Descrição";

        }

        public frmEstoquePesquisa(frmManutencao frmManutencao)
        {
            this.frmManutencao = frmManutencao;
            IniciarService();
            InitializeComponent();
            cboCampo.Text = "Descrição";
        }

        public frmEstoquePesquisa(frmMovimentacaPecas frmMovimentacao)
        {
            this.frmMovimentacao = frmMovimentacao;
            IniciarService();
            InitializeComponent();
            cboCampo.Text = "Descrição";
        }



        private EstoquePecasService IniciarService()
        {
            return service = new EstoquePecasService(loginController,modulosController);
        }


        public frmEstoquePesquisa(frmEstoquePecas frmEstoquePecas,loginController loginController, modulosController modulosController)
        {
            this.frmEstoquePecas = frmEstoquePecas;
            this.loginController = loginController;
            this.modulosController = modulosController;
            IniciarService();
            InitializeComponent();
            cboCampo.Text = "Descrição";

        }

        public frmEstoquePesquisa(frmEntradaSaidaPecas frmEntradaSaidaPecas, loginController loginController, modulosController modulosController)
        {
            this.frmEntradaSaidaPecas = frmEntradaSaidaPecas;
            this.loginController = loginController;
            this.modulosController = modulosController;
            IniciarService();
            InitializeComponent();
            cboCampo.Text = "Descrição";
        }

        public frmEstoquePesquisa(frmFiltroRequisicoesCompra frmFiltroRequisicoesCompra,loginController loginController, modulosController modulosController)
        {
            this.loginController = loginController;
            this.modulosController = modulosController;
            this.frmFiltroRequisicoesCompra = frmFiltroRequisicoesCompra;
            IniciarService();
            InitializeComponent();
            cboCampo.Text = "Descrição";
        }

        private void frmEstoquePesquisa_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void loadGridView()
        {
            controller = new EstoquePecasController();
            try
            {
                dataGridView1.DataSource = service.table();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            string codigo = "";
            string descricao = "";
            string unidade = "";
            if(dataGridView1.SelectedRows.Count > 0)
            {
                codigo = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                descricao = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                unidade = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }

            if (frmCompras != null)
            {
                frmCompras.txtCodigo.Text = codigo;
                frmCompras.txtDescricao.Text = descricao;
                frmCompras.txtUnidade.Text = unidade;


                this.Close();
            }
            else if (frmEstoquePecas != null)
            {
                frmEstoquePecas.loadGridView1((DataTable)dataGridView1.DataSource);
                this.Close();
            }
            else if(frmManutencao != null)
            {
                frmManutencao.txtCodigo.Text = codigo;
                frmManutencao.txtDescricaoPeca.Text = descricao;
                frmManutencao.txtUnidade.Text = unidade;
                this.Close();
            }
            else if(frmRequisicaoPecas != null)
            {
                frmRequisicaoPecas.txtCodigoPeca.Text = codigo;
                frmRequisicaoPecas.txtDescricao.Text = descricao;
                frmRequisicaoPecas.txtUnidade.Text = unidade;
                this.Close();
            }
            else if(frmMovimentacao != null)
            {
                frmMovimentacao.txtCodigo.Text = codigo;
                frmMovimentacao.txtDescriao.Text = descricao;
                frmMovimentacao.cboUnidade.Text = unidade;
                this.Close();
            }
            else if(frmFiltroRequisicoesCompra != null)
            {
                frmFiltroRequisicoesCompra.txtCodigo.Text = codigo;
                frmFiltroRequisicoesCompra.txtDescricao.Text = descricao;
                frmFiltroRequisicoesCompra.txtUnidade.Text = unidade;
                this.Close();
            }
            else if(frmFiltroRequisicaoPeca != null)
            {
                frmFiltroRequisicaoPeca.txtCodigo.Text = codigo;
                frmFiltroRequisicaoPeca.txtDescricao.Text = descricao;
                frmFiltroRequisicaoPeca.txtUnidade.Text = unidade;
                this.Close();
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            for(int i = 0; i< dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            var dt = (DataTable)dataGridView1.DataSource;
            if (cboCampo.Text == "Código")
            {

                dt.DefaultView.RowFilter = string.Format("[Codigo] like '%{0}%'", txtFiltro.Text);
            }
            else if(cboCampo.Text == "Descrição")
            {
                dt.DefaultView.RowFilter = string.Format("[Descricao] like '%{0}%'", txtFiltro.Text);
            }
        }
    }
}
