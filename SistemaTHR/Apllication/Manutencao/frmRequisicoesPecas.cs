using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTHR.Service.manutencao;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.Controller.Login;
using SistemaTHR.Apllication.Manutencao.Impressao;
using SistemaTHR.Apllication.Manutencao;

namespace SistemaTHR.Apllication
{
    public partial class frmRequisicoesPecas : Form
    {
        private modulosController modulosController;
        private loginController loginController;
        private solicitacaoPecaoController controller;
        private movimentacaoPecasService movimentacaoService;
        private EstoquePecasService estoqueService;
        private EstoquePecasController estoqueController;

        public frmRequisicoesPecas(modulosController modulosController, loginController loginController)
        {
            this.modulosController = modulosController;
            this.loginController = loginController;
            IniciarEstoqueService();
            IniciarMovimetacaoService();
            InitializeComponent();
        }

        private void frmMovimentacaoPecas_Load(object sender, EventArgs e)
        {
            loadGridView();
            listComboBox();



            if (modulosController.ManutencaoNivel != "1" && modulosController.ManutencaoNivel != "2")
            {
                btnRelatorio.Enabled = false;
            }
            else
            {
                btnRelatorio.Enabled = true;
            }
        }

        private movimentacaoPecasService IniciarMovimetacaoService()
        {
            return movimentacaoService = new movimentacaoPecasService(loginController,modulosController);
        }

        private EstoquePecasService IniciarEstoqueService()
        {
            return estoqueService = new EstoquePecasService(loginController,modulosController);
        }

        private void loadGridView2()
        {
            movimentacaoPecasController controller = new movimentacaoPecasController();

            controller.NRequisicao = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            movimentacaoService.export(controller);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                dataGridView2.DataSource = controller.Dt;
            }
            dataGridView2.ClearSelection();
            btnLiberar.Enabled = false;
        }

        public void LoadGridViewFilter(solicitacaoPecaoController controller)
        {
            dataGridView1.DataSource = controller.Dt;
        }

        private void loadGridView()
        {
            this.Cursor = Cursors.WaitCursor;


            controller = new solicitacaoPecaoController();
            solictacaoPecaService service = new solictacaoPecaService(loginController,modulosController, estoqueService ,movimentacaoService);
            service.table(controller);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                dataGridView1.DataSource = controller.Dt;
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if(i == dataGridView1.Rows.Count - 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                    }
                }
            }
            clearAll();

            this.Cursor = Cursors.Default;
        }
        private void listComboBox()
        {
            asuController controller = new asuController();
            asuService service = new asuService();
            service.list(controller);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                foreach (var asu in controller.AsuList)
                {
                    cboAsu.Items.Add(asu);
                }
            }
        }
        private void clearAll()
        {
            this.Cursor = Cursors.WaitCursor;


            txtCodigoPeca.ReadOnly = false;
            txtDescricao.ReadOnly = false;
            txtUnidade.ReadOnly = false;
            cboAsu.Enabled = true;

            txtDescricao.Text = string.Empty;
            txtCodigoPeca.Text = string.Empty;
            txtUnidade.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            cboAsu.Text = string.Empty;
            txtRequisicao.Text = string.Empty;

            txtRequisicao.ReadOnly = false;
            btnSalvar.Enabled = true;
            dataGridView1.ClearSelection();


            this.Cursor = Cursors.Default;
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txtCodigoPeca.Text != string.Empty && txtDescricao.Text != string.Empty && txtUnidade.Text != string.Empty &&
                txtQuantidade.Text != string.Empty)
            {
                Controller.manutencao.solicitacaoPecaoController controller = new Controller.manutencao.solicitacaoPecaoController();
                Service.manutencao.solictacaoPecaService service = new Service.manutencao.solictacaoPecaService(loginController,modulosController,estoqueService,movimentacaoService);
                controller.NOs = "";
                controller.CodigoPeca = txtCodigoPeca.Text;
                controller.DescricaoPeca = txtDescricao.Text;
                controller.Qtd = txtQuantidade.Text;
                controller.Unidade = txtUnidade.Text;
                controller.ASU = cboAsu.Text;
                service.insert(controller);
                if (controller.Msg != null)
                {
                    MessageBox.Show(controller.Msg,"SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                }
                else
                {
                    loadGridView();
                }
            }
            else
            {
                MessageBox.Show("Campo(s) obrigatório(s) vazio(s)!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Cursor = Cursors.Default;
        }
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                loadGridView2();

                btnSalvar.Enabled = false;
                txtCodigoPeca.ReadOnly = true;
                txtDescricao.ReadOnly = true;
                txtUnidade.ReadOnly = true;
                cboAsu.Enabled = false;

                txtRequisicao.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtCodigoPeca.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtDescricao.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtQuantidade.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtUnidade.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                cboAsu.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();

                if (dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "AGUARDANDO/AUT. PEÇAS" && 
                    modulosController.ManutencaoNivel == "1" &&
                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == "" ||
                    dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "AGUARDANDO/AUT. PEÇAS" && 
                    modulosController.ManutencaoNivel == "2" &&
                    dataGridView1.SelectedRows[0].Cells[1].Value.ToString() == "")
                {
                    btnAutorizar.Enabled = true;

                }
                else
                {
                    btnAutorizar.Enabled = true;
                }
            }
            this.Cursor = Cursors.Default;
        }
        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            solicitacaoPecaoController controller = new solicitacaoPecaoController();
            solictacaoPecaService service = new solictacaoPecaService(loginController,modulosController,
                estoqueService,movimentacaoService);
            controller.CodigoPeca = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            controller.DescricaoPeca = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            controller.Qtd = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
            controller.Unidade = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            controller.ASU = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();
            controller.UsuarioSolicitacao = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            controller.DataHoraSolicitacao = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();


            controller.NRequisicao = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            service.authorizeRequisicao(controller);

            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg,"SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {

                loadGridView();
            }
            this.Cursor = Cursors.Default;
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            loadGridView();
            clearAll();

            this.Cursor = Cursors.Default;
        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;

                if (dataGridView1.Rows[i].Cells[9].Value.ToString() == "AUTORIZADO")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Yellow;
                }
            }

        }
        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;

                if (dataGridView2.Rows[i].Cells[8].Value.ToString() == "Liberado")
                {
                    dataGridView2.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Yellow;
                    dataGridView2.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                }

            }
        }
        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView2.SelectedRows.Count > 0)
            {

                this.Cursor = Cursors.WaitCursor;

                if (modulosController.ManutencaoNivel != "1")
                {
                    if(modulosController.ManutencaoNivel != "2")
                    {
                        if(modulosController.AlmoxarifadoNivel == "2" || modulosController.AlmoxarifadoNivel == "1")
                        {

                            btnLiberar.Enabled = true;
                        }
                        else
                        {
                            btnLiberar.Enabled = false;
                        }
                    }
                    else
                    {
                        btnLiberar.Enabled = false;
                    }
                }
                else
                {

                    btnLiberar.Enabled = true;
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void insertRequisicaoCompra()
        {
            Controller.Compras.requisicaoCompraController controller = new Controller.Compras.requisicaoCompraController();
            Service.Compras.requisicaoCompraService service = new Service.Compras.requisicaoCompraService();
            controller.Codigo = txtCodigoPeca.Text;
            controller.Descricao = txtDescricao.Text;
            controller.Quantidade = txtQuantidade.Text;
            controller.Unidade = txtUnidade.Text;
            controller.UsuarioSolicitacao = loginController.Nome;
            controller.DataHoraSolicitacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

            service.insert(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
        }
        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Manutencao.frmEstoquePesquisa pesquisa = new Manutencao.frmEstoquePesquisa(this);
            pesquisa.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        private void txtCodigoPeca_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                estoqueController = new EstoquePecasController();
                estoqueService.table(estoqueController);
                if(controller.Msg != null)
                {
                    MessageBox.Show(controller.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    estoqueController.Codigo = txtCodigoPeca.Text;
                    estoqueService.BuscarInformacao(estoqueController);
                    if(controller.Msg != null)
                    {
                        MessageBox.Show(controller.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        txtDescricao.Text = estoqueController.Descricao;
                        txtUnidade.Text = estoqueController.Unidade;
                    }
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmRelatorioRequisicoesPeca relatorio = new frmRelatorioRequisicoesPeca();
            relatorio.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmFiltroRequisicoesPeca requisicoes = new frmFiltroRequisicoesPeca(this, controller); ;
            requisicoes.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        private void txtRequisicao_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                for(int i =0; i< dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtRequisicao.Text)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        break;
                    }
                    else if(i == dataGridView1.Rows.Count - 1)
                    {
                        MessageBox.Show("Requisição não econtrada!", "SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
                        clearAll();
                    }
                }
            }
        }
    }
}
