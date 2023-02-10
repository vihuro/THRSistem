using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTHR.Controller.Login;
using SistemaTHR.Controller.estoque;
using SistemaTHR.Service.estoque;
using SistemaTHR.Service.Exepction;

namespace SistemaTHR.Apllication.Estoque
{
    public partial class frmRequisicaoMaterial : Form
    {
        private loginController loginController;
        private modulosController modulosController;
        private SolicitacaoController controller;
        private EstoqueService estoqueService;
        private SolicitacaoService service;
        private MovimentacaoController movimentacoController;
        private MovimentacaoSerivce movimentacoService;
        private string quantidadeDisponivel;
        public frmRequisicaoMaterial(loginController loginController, modulosController modulosController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.modulosController = modulosController;
            IniciarMovimentacaoService();
            IniciarEstoqueService();
            movimentacoService = new MovimentacaoSerivce(loginController);

        }

        private EstoqueService IniciarEstoqueService()
        {
            return this.estoqueService = new EstoqueService(loginController);
        }

        private SolicitacaoService IniciarMovimentacaoService()
        {
            return this.service = new SolicitacaoService(loginController);
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txtCodigo.Text != string.Empty && txtDescricao.Text != string.Empty && txtOrdemProducao.Text != string.Empty &&
                txtFornecedor.Text != string.Empty && cboMaquina.Text != string.Empty)
            {
                controller = new SolicitacaoController();
                controller.OrdemProducao = txtOrdemProducao.Text;
                controller.Maquina = cboMaquina.Text;
                controller.DescricaoItem = txtDescricao.Text;
                controller.Item = txtDescricao.Text;
                controller.CodigoItem = txtCodigo.Text;
                controller.Fornecedor = txtFornecedor.Text;

                decimal disponivel = Convert.ToDecimal(quantidadeDisponivel);
               

                try
                {
                    if (disponivel <= 0)
                    {
                        throw new ExceptionService("Não é possivel requisitar um material com saldo igual a 0");
                    }

                    service.Insert(controller);

                    MessageBox.Show("Solicitação realizada com sucesso!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Close();

                }
                catch (ExceptionService ex)
                {

                    MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

            }
            else
            {
                MessageBox.Show("Campo(s) obrigatório(s) vazio(s)!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Cursor = Cursors.Default;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmRequisicaoMaterial_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmFilterEstoque filterEstoque = new frmFilterEstoque(this, estoqueService);
            filterEstoque.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length > 0)
            {
                BuscarCodigo();
            }
        }

        private void BuscarCodigo()
        {
            var estoqueController = new EstoqueController();
            estoqueService.selectTable(estoqueController);
            if (estoqueController.Msg != null)
            {
                MessageBox.Show(estoqueController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (movimentacoController == null)
                {
                    movimentacoController = new MovimentacaoController();
                }
                else
                {
                    movimentacoController.Msg = null;
                }
                movimentacoService.SelectTable(movimentacoController);
                if (movimentacoController.Msg != null)
                {
                    MessageBox.Show(movimentacoController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var linha = estoqueController.Dt.Select($"Codigo = '{txtCodigo.Text.ToUpper()}'");
                    if (linha.Count() > 0)
                    {
                        txtCodigo.Text = linha[0]["Codigo"].ToString();
                        txtDescricao.Text = linha[0]["Descricao"].ToString();
                        txtFornecedor.Text = linha[0]["Fornecedor"].ToString();

                        quantidadeDisponivel = estoqueService.Count(movimentacoController, txtCodigo.Text.ToUpper()).ToString();
                    }
                    else
                    {
                        MessageBox.Show("Código não econtrado!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtCodigo.Text = string.Empty;
                        txtDescricao.Text = string.Empty;
                        txtFornecedor.Text = string.Empty;
                    }
                }
            }
        }
    }
}
