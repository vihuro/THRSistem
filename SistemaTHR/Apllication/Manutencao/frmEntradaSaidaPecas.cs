using SistemaTHR.Apllication.Manutencao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.Service.manutencao;
using Autofac.Core;
using SistemaTHR.Controller.Login;

namespace SistemaTHR.Apllication.Estoque
{
    public partial class frmEntradaSaidaPecas : Form
    {
        private frmEstoquePecas estoquePecas;
        private EstoquePecasController controller;
        private EstoquePecasService service;
        private loginController loginController;
        private modulosController modulosController;
        private movimentacaoPecasController movimentacaoController;
        private movimentacaoPecasService movimentacaoService;

        public frmEntradaSaidaPecas(loginController loginController, modulosController modulosController)
        {
            this.loginController = loginController;
            this.modulosController = modulosController;
            IniciarService();
            IniciarMovimentacaoService();
            InitializeComponent();
        }

        private movimentacaoPecasService IniciarMovimentacaoService()
        {
            return movimentacaoService = new movimentacaoPecasService(loginController, modulosController);
        }

        private EstoquePecasService IniciarService()
        {
            return service = new EstoquePecasService(loginController, modulosController); ;
        }

        public frmEntradaSaidaPecas(frmEstoquePecas estoquePecas, loginController loginController, modulosController modulosController)
        {
            this.estoquePecas = estoquePecas;
            this.loginController = loginController;
            this.modulosController = modulosController;
            IniciarService();
            IniciarMovimentacaoService();
            InitializeComponent();
        }


        private void frmEntradaSaidaPecas_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            frmEstoquePesquisa filtro = new frmEstoquePesquisa(this, loginController, modulosController);
            filtro.ShowDialog();
        }

        private string getCheckdRaddioButton(Control c)
        {
            //Enteder se é uma entrada ou uma saída
            int index = -1;
            for (int i = 0; i < c.Controls.Count && index == -1; i++)
            {
                if (c.Controls[i] is RadioButton)
                {
                    if (((RadioButton)c.Controls[i]).Checked)
                    {
                        return ((RadioButton)c.Controls[i]).Text;
                    }
                }
            }
            return "";

        }


        private void btnLancar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            controller = new EstoquePecasController();
            controller.Codigo = txtCodigo.Text;
            controller.Descricao = txtDescricao.Text;
            controller.QtEstoque = txtQuantidade.Text;
            controller.Unidade = txtUnidade.Text;

            var TipoMovimentacao = getCheckdRaddioButton(this);

            service.VerificarCodigo(controller, TipoMovimentacao);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                movimentacaoController = new movimentacaoPecasController();
                movimentacaoController.NRequisicao = "";
                movimentacaoController.CodigoPeca = txtCodigo.Text;
                movimentacaoController.DescricaoPeca = txtDescricao.Text;
                movimentacaoController.Unidade = txtUnidade.Text;
                movimentacaoController.Asu = "MOVIMENTAÇÂO - MANUAL";
                movimentacaoController.TipoMovimentacao = TipoMovimentacao;
                movimentacaoController.UsuarioSolicitacao = "";
                movimentacaoController.DataHoraSolicitacao = "";
                movimentacaoController.UsuarioAutorizacao = "";
                movimentacaoController.DataHoraAutorizacao = "";
                movimentacaoController.Qtd = txtQuantidade.Text;

                movimentacaoService.insertMovimentacao(movimentacaoController);
                if(movimentacaoController.Msg != null)
                {
                    MessageBox.Show(movimentacaoController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    MessageBox.Show("Lançamento realizado com sucesso!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearAll();
                }


            }

            this.Cursor = Cursors.Default;
        }

        private void ClearAll()
        {
            txtCodigo.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtUnidade.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            rdbEntrada.Checked = false;
            rdbSaida.Checked = false;
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }
    }
}
