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

namespace SistemaTHR.Apllication.Estoque
{
    public partial class frmMovimentacaoMaterial : Form
    {
        private loginController loginController;
        private MovimentacaoSerivce movimentacaoService;
        private MovimentacaoController movimentacaoController;
        private EstoqueController controller;
        private EstoqueService estoqueService;
        public string quantidadeDisponivel;
        public frmEstoque formularioEstoque;

        public frmMovimentacaoMaterial(loginController loginController, string quantidadeDisponivel)
        {
            this.loginController = loginController;
            this.quantidadeDisponivel = quantidadeDisponivel;
            InitializeComponent();
            IniciarService();
            IniciarEstoqueService();
        }

        public frmMovimentacaoMaterial(loginController loginController)
        {
            this.loginController = loginController;
            InitializeComponent();
            IniciarService();
            IniciarEstoqueService();
        }

        public frmMovimentacaoMaterial(frmEstoque formularioEstoque,loginController loginController, string quantidadeDisponivel)
        {
            this.loginController = loginController;
            this.quantidadeDisponivel = quantidadeDisponivel;
            this.formularioEstoque = formularioEstoque;
            InitializeComponent();
            IniciarService();
            IniciarEstoqueService();
        }

        private EstoqueService IniciarEstoqueService()
        {
            return this.estoqueService = new EstoqueService(loginController);
        }

        private MovimentacaoSerivce IniciarService()
        {
            return this.movimentacaoService = new MovimentacaoSerivce(loginController);
        }

        private void rdbEntrada_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEntrada.Checked)
            {
                cboTipoMovimentacao.Items.Clear();
                cboTipoMovimentacao.Items.Add("RECEBIMENTO DE FORNECEDORES");
                cboTipoMovimentacao.Items.Add("ENTRADA - AJUSTA DE ESTOQUE");

            }
        }

        private void rdbSaida_CheckedChanged(object sender, EventArgs e)
        {
            cboTipoMovimentacao.Items.Clear();
            cboTipoMovimentacao.Items.Add("AJUSTE DE ESTOQUE");
            cboTipoMovimentacao.Items.Add("TRANSFERÊNCIA PARA MATERIAIS");
        }

        private void frmMovimentacaoMaterial_Load(object sender, EventArgs e)
        {

        }
        string QuantidadeAntiga;
        string QuantidadeNova;
        string texto;
        private void IniciarMovimentacaoController()
        {
            movimentacaoController = new MovimentacaoController();
            movimentacaoController.Codigo = txtCodigo.Text;
            movimentacaoController.Descricao = txtDescricao.Text;
            movimentacaoController.Quantidade = txtQuantidade.Text;
            movimentacaoController.Operacao = cboTipoMovimentacao.Text;
        }

        public string textoMenssagem()
        {
            double antigo = Convert.ToDouble(quantidadeDisponivel);
            double total = 0;
            if (rdbEntrada.Checked)
            {
                total = Convert.ToDouble(quantidadeDisponivel) + Convert.ToDouble(txtQuantidade.Text);
            }
            else if (rdbSaida.Checked)
            {
                total = Convert.ToDouble(quantidadeDisponivel) - Convert.ToDouble(txtQuantidade.Text);
            }

            return texto = $"Quantidade anterior = {antigo.ToString("###,###.##")} \r\n" +
                           $"Nova quantidade     = {total.ToString("###,###.##")} ";
        }

        private void btnEntrada_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty || txtDescricao.Text != string.Empty || txtQuantidade.Text != string.Empty || 
                cboTipoMovimentacao.Text != string.Empty)
            {

                IniciarMovimentacaoController();

                movimentacaoController = new MovimentacaoController();
                movimentacaoController.Codigo = txtCodigo.Text;
                movimentacaoController.Descricao = txtDescricao.Text;
                movimentacaoController.Quantidade = txtQuantidade.Text;
                movimentacaoController.Operacao = cboTipoMovimentacao.Text;

                VerificarQuantidadeDisponivel();

                if (rdbEntrada.Checked)
                {
                    movimentacaoService.InsertEntradaManual(movimentacaoController,quantidadeDisponivel);
                    if (movimentacaoController.Msg != null)
                    {
                        MessageBox.Show(movimentacaoController.Msg,"SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        
                        MessageBox.Show("Entrada de material realizada com sucesso!\r\n" +
                            movimentacaoService.quantidadeDisponivel(), "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        
                        ClearAll();
                        if (Application.OpenForms.OfType<frmEstoque>().Count() > 0)
                        {
                            formularioEstoque.BuscarMovimentacao(movimentacaoController.Codigo);
                            
                        }

                    }

                }
                else if (rdbSaida.Checked)
                {

                    movimentacaoService.InsertSaidaManual(movimentacaoController,quantidadeDisponivel);
                    if(movimentacaoController.Msg != null)
                    {
                        MessageBox.Show(movimentacaoController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        ClearAll();
                    }
                    else
                    {

                        MessageBox.Show($"Saída de material realizada com sucesso!\r\n" +
                            movimentacaoService.quantidadeDisponivel(), "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Information); ;
                        if (Application.OpenForms.OfType<frmEstoque>().Count() > 0)
                        {
                            formularioEstoque.BuscarMovimentacao(movimentacaoController.Codigo);
                        }
                        ClearAll();
                    }

                }

                else
                {
                    MessageBox.Show("Escolha a forma de movimentação", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            else
            {
                MessageBox.Show("Campo(s) obrigatorio(s) vazio(s)!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void ClearAll()
        {
            txtCodigo.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtFornecedor.Text = string.Empty;
            rdbEntrada.Checked = false;
            rdbSaida.Checked = false;
            txtQuantidade.Text = string.Empty;
            quantidadeDisponivel = string.Empty;
            cboTipoMovimentacao.Text = string.Empty;
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmFilterEstoque filtro = new frmFilterEstoque(this,estoqueService);
            filtro.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void VerificarQuantidadeDisponivel()
        {
            controller = new EstoqueController();
            estoqueService.selectTable(controller);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(movimentacaoController == null)
                {
                    movimentacaoController = new MovimentacaoController();
                }
                else
                {
                    movimentacaoController.Msg = null;
                }


                movimentacaoService.SelectTable(movimentacaoController);
                if (movimentacaoController.Msg != null)
                {
                    MessageBox.Show(movimentacaoController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    var linha = controller.Dt.Select($"Codigo = '{txtCodigo.Text.ToUpper()}'");
                    if (linha.Count() > 0)
                    {
                        txtDescricao.Text = linha[0]["Descricao"].ToString();
                        txtFornecedor.Text = linha[0]["Fornecedor"].ToString();


                        quantidadeDisponivel = Convert.ToString(estoqueService.Count(movimentacaoController, txtCodigo.Text.ToUpper()));

                    }
                    else
                    {
                        MessageBox.Show("Código não encontrado!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        txtCodigo.Text = string.Empty;
                    }
                }

            }
        }

        private void txtCodigo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;


            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {

                VerificarQuantidadeDisponivel();

            }

            this.Cursor = Cursors.Default;
        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            quantidadeDisponivel = null;
        }

        private void frmMovimentacaoMaterial_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }
    }
}
