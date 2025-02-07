﻿using SistemaTHR.Apllication.Manutencao;
using SistemaTHR.Apllication.Manutencao.Impressao;
using SistemaTHR.Controller.Compras;
using SistemaTHR.Controller.Login;
using SistemaTHR.Service.Compras;
using SistemaTHR.Service.Exepction;
using SistemaTHR.Service.manutencao;
using System;
using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace SistemaTHR.Apllication.Compras
{
    public partial class frmRequisicaoCompra : Form
    {
        private loginController loginController;
        private modulosController modulosController;
        private requisicaoCompraController controller;
        private requisicaoCompraService service;
        private AcompanhamentoRequisicaoCompraService acompanhamentoService;
        private EstoquePecasService estoqueService;
        private movimentacaoPecasService movimentacaoService;

        public string pesquisar = "";

        public frmRequisicaoCompra(loginController loginController, modulosController modulosController)
        {
            this.loginController = loginController;
            this.modulosController = modulosController;
            service = new requisicaoCompraService(loginController, modulosController);
            acompanhamentoService = new AcompanhamentoRequisicaoCompraService(modulosController, loginController, service);
            estoqueService = new EstoquePecasService(loginController, modulosController);
            movimentacaoService = new movimentacaoPecasService(loginController, modulosController);

            InitializeComponent();
        }

        public frmRequisicaoCompra()
        {
            InitializeComponent();

        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmEstoquePesquisa pesquisa = new frmEstoquePesquisa(this);
            pesquisa.ShowDialog();
        }

        private void frmRequisicaoCompra_Load(object sender, EventArgs e)
        {
            loadGridView();
            loadGridViewHistorico();
            clearAll();
        }

        private void loadGridViewHistorico()
        {
            try
            {
                dataGridMovimentacoes.DataSource = movimentacaoService.Table();
            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void clearAll()
        {
            dataGridView1.ClearSelection();

            pesquisar = string.Empty;

            txtCodigo.Text = string.Empty;
            dateTimePicker1.CustomFormat = "00/00/00";
            txtDescricao.Text = string.Empty;
            txtUnidade.Text = string.Empty;
            txtNRequisicao.Text = string.Empty;
            txtFornecedor.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtUnidade.Text = string.Empty;
            cboPrioridade.Text = string.Empty;
            cboFreteIncluso.Text = string.Empty;
            cboFrete.Text = string.Empty;
            txtEstadoCompra.Text = string.Empty;
            txtValor.Text = string.Empty;

            cboPrioridade.Enabled = true;
            txtQuantidade.Enabled = true;
            var dtApontamentos = (DataTable)dataGridView2.DataSource;
            if (dataGridView2.Rows.Count > 0)
            {
                dtApontamentos.Rows.Clear();

            }
            var dtMovimentacaoes = (DataTable)dataGridMovimentacoes.DataSource;
            if (dataGridMovimentacoes.Rows.Count > 0)
            {
                dtMovimentacaoes.Rows.Clear();
            }
            btnSalvar.Enabled = true;
            btnApontar.Enabled = false;
            btnDesfazer.Enabled = false;
            btnAutorizar.Enabled = false;


        }

        public void loadGridView()
        {
            controller = new requisicaoCompraController();

            try
            {
                dataGridView1.DataSource = service.Table();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (i == dataGridView1.Rows.Count - 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        break;
                    }
                }
                if (pesquisar != string.Empty)
                {
                    var dt = (DataTable)dataGridView1.DataSource;
                    dt.DefaultView.RowFilter = pesquisar;
                }
            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            controller = new requisicaoCompraController();
            controller.NRequisicao = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            try
            {
                service.updateAuth(controller);

                loadGridView();
                clearAll();
            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnApontar.Enabled = true;


                // Aqui fica o relacionamento dos campos
                txtNRequisicao.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtCodigo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtDescricao.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtQuantidade.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtUnidade.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                cboPrioridade.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                ValidarCampos();

                // Apenas para teste
                //btnAutorizar.Enabled = true;

                //IF ternario, se data for igual a 00/00/0000, irá lançar a data custom, se não, irá mostrar a data prevista
                dateTimePicker1.CustomFormat =
                    dataGridView1.SelectedRows[0].Cells[6].Value.ToString() == "00/00/0000" ?
                    dateTimePicker1.CustomFormat = "00/00/0000" :
                        dateTimePicker1.CustomFormat =
                        Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[6].Value)
                        .ToString("dd/MM/yyyy");

                txtValor.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                cboFreteIncluso.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                txtFornecedor.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                cboFrete.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                txtEstadoCompra.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();


                //Buscar no DataGridView de acompanhando, o acompanhamento da requisição de compra

                SearchForNumber(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                SearchForCod(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());


                //Verifica liberação de botões conform as roles do usuário.

                if (modulosController.ComprasNivel != "1" && modulosController.ComprasNivel != "2")
                {
                    if (dataGridView1.SelectedRows[0].Cells[16].Value.ToString() == "Autorizado")
                    {
                        //btnSalvar.Enabled = true;
                    }
                    else
                    {
                        //btnSalvar.Enabled = false;

                    }
                }
                else
                {


                    var texto = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
                    if (texto == "Autorizado")
                    {
                        btnSalvar.Enabled = true;
                        btnAutorizar.Enabled = false;

                    }
                    else if (texto == "Comprado")
                    {
                        btnSalvar.Enabled = false;
                        btnAutorizar.Enabled = false;
                    }
                    else if (texto == "Pendente" && modulosController.ComprasNivel == "1" ||
                            texto == "Pendente" && modulosController.ComprasNivel == "2")
                    {

                        btnAutorizar.Enabled = true;



                    }



                }
            }
            this.Cursor = Cursors.Default;

        }

        private void ValidarCampos()
        {
            var status = dataGridView1.SelectedRows[0].Cells[16].Value.ToString();
            if (status == "Comprado" && modulosController.ComprasNivel != "1" && modulosController.ComprasNivel != "2")
            {
                txtCodigo.Enabled = false;
                txtQuantidade.Enabled = false;
                cboPrioridade.Enabled = false;
                txtFornecedor.Enabled = false;
                txtValor.Enabled = false;
                cboFrete.Enabled = false;
                cboFreteIncluso.Enabled = false;
                txtEstadoCompra.Enabled = false;
                btnSalvar.Enabled = false;
                btnAutorizar.Enabled = false;
            }
            else if (status == "Entregue" && modulosController.ComprasNivel != "1" && modulosController.ComprasNivel != "2")
            {
                txtCodigo.Enabled = false;
                txtQuantidade.Enabled = false;
                cboPrioridade.Enabled = false;
                txtFornecedor.Enabled = false;
                txtValor.Enabled = false;
                cboFrete.Enabled = false;
                cboFreteIncluso.Enabled = false;
                txtEstadoCompra.Enabled = false;
                btnSalvar.Enabled = false;
                btnAutorizar.Enabled = false;
            }
            else if (status == "Autorizado" && modulosController.ComprasNivel != "1" && modulosController.ComprasNivel != "2")
            {
                txtCodigo.Enabled = false;
                txtQuantidade.Enabled = false;
                cboPrioridade.Enabled = false;
                txtFornecedor.Enabled = false;
                txtValor.Enabled = false;
                cboFrete.Enabled = false;
                cboFreteIncluso.Enabled = false;
                txtEstadoCompra.Enabled = false;
                btnSalvar.Enabled = false;
                btnAutorizar.Enabled = false;

            }
            else if (modulosController.ComprasNivel == "3" && status == "Pendente")
            {
                txtFornecedor.Enabled = true;
                txtValor.Enabled = true;
                cboFrete.Enabled = true;
                cboFreteIncluso.Enabled = true;
                txtEstadoCompra.Enabled = true;
                btnAutorizar.Enabled = false;

            }
            else if(modulosController.ComprasNivel == "4")
            {
                txtFornecedor.Enabled = false;
                txtValor.Enabled = false;
                cboFrete.Enabled = false;
                cboFreteIncluso.Enabled = false;
                txtEstadoCompra.Enabled = false;
                btnAbrirObervacao.Enabled = false;
            }
            else
            {
                txtCodigo.Enabled = true;
                txtQuantidade.Enabled = true;
                cboPrioridade.Enabled = true;
                txtFornecedor.Enabled = true;
                txtValor.Enabled = true;
                cboFrete.Enabled = true;
                cboFreteIncluso.Enabled = true;
                txtEstadoCompra.Enabled = true;
                btnSalvar.Enabled = true;
            }

            if (modulosController.ComprasNivel != "1" &&
                status != "Autorizado" &&
                status != "Comprado" &&
                status != "Entregue")
            {
                btnAutorizar.Enabled = false;
            }


        }

        private void SearchForCod(string codigoPeca)
        {
            try
            {
                var dataTable = movimentacaoService.Table();
                dataTable.DefaultView.RowFilter = string.Format("codigoPeca = '{0}'", codigoPeca);
                dataGridMovimentacoes.DataSource = dataTable;
                dataGridMovimentacoes.ClearSelection();

            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void SearchForNumber(string numeroRequisicao)
        {

            try
            {
                var dataTable = acompanhamentoService.Table();

                dataTable.DefaultView.RowFilter = string.Format("[numeroRequisicao] = '{0}'", numeroRequisicao);
                dataGridView2.DataSource = dataTable;
                dataGridView2.ClearSelection();
                txtObservacao.Text = string.Empty;
            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
                if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "Autorizado")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Yellow;
                }
                if (dataGridView1.Rows[i].Cells[7].Value.ToString() == "Comprado")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.HotPink;
                }
            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            loadGridView();
            clearAll();
            this.Cursor = Cursors.Default;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txtCodigo.Text != string.Empty && txtDescricao.Text != string.Empty &&
                txtQuantidade.Text != string.Empty)
            {
                controller = new requisicaoCompraController();
                controller.Codigo = txtCodigo.Text;
                controller.Descricao = txtDescricao.Text;
                controller.Quantidade = txtQuantidade.Text;
                controller.Unidade = txtUnidade.Text;
                controller.DataHoraEsperadaEntrega = verificarData();
                controller.Prioridade = cboPrioridade.Text;
                try
                {

                    if (txtNRequisicao.Text != string.Empty)
                    {
                        controller.NRequisicao = txtNRequisicao.Text;
                        controller.Fornecedor = txtFornecedor.Text;
                        controller.ValorProduto = txtValor.Text;
                        controller.Frete = cboFrete.Text;
                        controller.FreteIncluso = cboFreteIncluso.Text;
                        controller.EstadoDaCompra = txtEstadoCompra.Text;

                        service.Update(controller);
                        LoadGridViewForNumber(txtNRequisicao.Text);
                    }
                    else
                    {
                        service.verificarAberto(controller);

                    }
                    MessageBox.Show("Requisição de compra realizada com sucesso!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadGridView();
                    clearAll();


                }
                catch (ExceptionService ex)
                {

                    MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campos obrigatório(s) em branco!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Cursor = Cursors.Default;
        }

        private void LoadGridViewForNumber(string text)
        {
            try
            {
                dataGridView1.DataSource = service.Table();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == text)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        break;
                    }
                }
                clearAll();
            }
            catch (ExceptionService ex)
            {
                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value >= DateTime.Today)
            {
                dateTimePicker1.Format = DateTimePickerFormat.Short;
            }
            else
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
            }
        }

        private string verificarData()
        {

            if (dateTimePicker1.Format == DateTimePickerFormat.Custom)
            {
                return "00/00/0000";
            }
            else
            {
                return Convert.ToString(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            }
        }

        private void btnApontar_Click(object sender, EventArgs e)
        {
            Apontar("APONTAMENTO");
        }

        private void btnDesfazer_Click(object sender, EventArgs e)
        {
            Apontar("DESFAZER");
        }

        private void Apontar(string tipoApontamento)
        {
            this.Cursor = Cursors.WaitCursor;
            var obj = new AcompanhamentoRequisicaoCompra()
            {
                Id = dataGridView2.SelectedRows[0].Cells[0].Value.ToString(),
                NumeroRequisicao = dataGridView2.SelectedRows[0].Cells[1].Value.ToString(),
                Observacao = txtObservacao.Text,

            };

            try
            {
                var newObj = acompanhamentoService.InsertApontamento(obj, tipoApontamento);
                dataGridView2.SelectedRows[0].Cells[3].Value = newObj.DataHoraApontamento;
                dataGridView2.SelectedRows[0].Cells[4].Value = newObj.UsuarioApontamento;
                dataGridView2.SelectedRows[0].Cells[5].Value = newObj.DataHoraAlteracao;
                dataGridView2.SelectedRows[0].Cells[6].Value = newObj.UsuarioAlteracao;
                dataGridView2.SelectedRows[0].Cells[7].Value = newObj.Observacao;
                txtObservacao.Text = newObj.Observacao;
                if (dataGridView2.SelectedRows[0].Cells[1].Value.ToString() != "DÍARIO")
                {
                    AtualizarStatusRequisicao();
                }


            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Cursor = Cursors.Default;

        }

        private void AtualizarStatusRequisicao()
        {
            try
            {
                var obj = service.SelectRequisicao(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                dataGridView1.SelectedRows[0].Cells[16].Value = obj.Status;

            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (dataGridView2.SelectedRows.Count > 0)
            {
                btnApontar.Enabled = true;
                txtObservacao.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
                if (modulosController.ComprasNivel == "1")
                {
                    btnDesfazer.Enabled = true;
                }
                else
                {
                    btnDesfazer.Enabled = false;
                }
            }
            else
            {
                btnApontar.Enabled = false;

            }

            this.Cursor = Cursors.Default;

        }

        private void txtNRequisicao_KeyDown(object sender, KeyEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                var linha = SearcInDataGriView1(txtNRequisicao.Text);

                if (linha > 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[linha].Cells[0];
                }
                else
                {
                    MessageBox.Show("Requisição de compra não localizada!");
                }
            }

            this.Cursor = Cursors.Default;

        }

        private int SearcInDataGriView1(string text)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == text)
                {
                    return i;
                }
            }
            return -1;
        }

        private void txtNRequisicao_Leave(object sender, EventArgs e)
        {

            if (txtNRequisicao.Text.Length > 0)
            {
                var linha = SearcInDataGriView1(txtNRequisicao.Text);
                if (linha > 0)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[linha].Cells[0];
                }
                else
                {
                    clearAll();
                }
            }

        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {

                Procurar();
            }
        }

        private void Procurar()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                var obj = estoqueService.BuscarPorCodigo(txtCodigo.Text);
                txtCodigo.Text = obj.Codigo;
                txtDescricao.Text = obj.Descricao;
                txtUnidade.Text = obj.Unidade;


            }
            catch (ExceptionService ex)
            {
                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Text = "";
                txtDescricao.Text = "";
                txtUnidade.Text = "";

            }
            finally
            {
                this.Cursor = Cursors.Default;
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length > 0)
            {
                Procurar();
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            var relatorio = new frmRelatorioMovimentacaoPecas((DataTable)dataGridMovimentacoes.DataSource, loginController.Nome);
            relatorio.Show();
        }

        private void txtValor_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            var filtro = new frmFiltroRequisicoesCompra(this, loginController, modulosController);
            filtro.ShowDialog();
        }
    }
}
