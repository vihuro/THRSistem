using SistemaTHR.Apllication.Manutencao.Impressao;
using SistemaTHR.Controller.Login;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.Service.Exepction;
using SistemaTHR.Service.manutencao;
using System;

using System.Data;
using System.Drawing;

using System.Windows.Forms;

namespace SistemaTHR.Apllication.Manutencao
{
    public partial class frmMovimentacaPecas : Form
    {
        private loginController loginController;
        private modulosController modulosController;
        private movimentacaoPecasService service;
        private movimentacaoPecasController controller;
        private asuService usadoService;
        private asuController usadoController;
        public frmMovimentacaPecas(loginController loginController, modulosController modulosController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.modulosController = modulosController;
            service = new movimentacaoPecasService(loginController,modulosController);
            usadoService = new asuService();
        }

        private void frmMovimentacaPecas_Load(object sender, EventArgs e)
        {
            loadGridView1();
            clearAll();
        }

        private void clearAll()
        {
            //throw new NotImplementedException();
            txtNumeroMovimentacao.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtDescriao.Text = string.Empty;
            cboUnidade.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(i == dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                    break;
                }
            }
            dataGridView1.ClearSelection();
        }

        private void loadGridView1()
        {
            movimentacaoPecasController controller = new Controller.manutencao.movimentacaoPecasController();
            movimentacaoPecasService service = new Service.manutencao.movimentacaoPecasService(loginController, modulosController);
            try
            {
                dataGridView1.DataSource = service.Table();


                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (i == dataGridView1.Rows.Count - 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
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

        public void LoadGridViewFilter(DataTable dt)
        {
            dataGridView1.DataSource = dt;
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i == dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                    break;
                }
            }
            clearAll();
        }



        private void btnEntrada_Click(object sender, EventArgs e)
        {
            MovimentacaoMaterial("Entrada");

        }

        private void btnSaida_Click(object sender, EventArgs e)
        {
            MovimentacaoMaterial("Saída");
        }

        private void MovimentacaoMaterial(string TipoMovimentacao)
        {
            if(txtCodigo.Text != string.Empty && txtDescriao.Text != string.Empty && txtQuantidade.Text != string.Empty)
            {
                controller = new movimentacaoPecasController()
                {
                    CodigoPeca = txtCodigo.Text,
                    Asu = cboAondeSeraUsado.Text,
                    DescricaoPeca = txtDescriao.Text,
                    Unidade = cboUnidade.Text,
                    Qtd = txtQuantidade.Text,
                    TipoMovimentacao = TipoMovimentacao
                };

                try
                {
                    service.insertMovimentacao(controller);
                    MessageBox.Show("Movimentação realizada com sucesso!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    loadGridView1();
                    clearAll();

                }
                catch (ExceptionService ex)
                {

                    MessageBox.Show(ex.Message,"SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }

            }
        }

        private void verificarCodigo(EstoquePecasController controller)
        {
            alterarEstoque(controller);
            if (controller.Exists == true)
            {
                movimentacao();
            }
            else
            {
                MessageBox.Show("Código ainda não cadastrado. Não é possivel dar entrada de um item sem" +
                    " seu cadastro!", "SISTEMA THR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void movimentacao()
        {
            /*Controller.manutencao.movimentacaoPecasController controller = new Controller.manutencao.movimentacaoPecasController();
            Service.manutencao.movimentacaoPecasService service = new Service.manutencao.movimentacaoPecasService(loginController,modulosController);
            controller.CodigoPeca = txtCodigo.Text;
            controller.DescricaoPeca = txtDescriao.Text;
            controller.Unidade = cboUnidade.Text;
            controller.Qtd = txtQuantidade.Text;
            controller.TipoMovimentacao = "Entrada";
            controller.Status = "Finalizado";
            controller.UsuarioMovimentacao = loginController.Nome;
            controller.DataHoraMovimentacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            service.InsertSaida(controller);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }*/
        }
        private void alterarEstoque(Controller.manutencao.EstoquePecasController controller)
        {
            //Service.manutencao.EstoquePecasService service = new Service.manutencao.EstoquePecasService();
            //service.entradaEstoque(controller);
            //if (controller.Msg != null)
            //{
            //  MessageBox.Show(controller.Msg);
            //}
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            var filtro = new frmFiltroMovimentacoesPeca(loginController, modulosController, this);
            filtro.ShowDialog();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            var relatorio = new frmRelatorioMovimentacaoPecas((DataTable)dataGridView1.DataSource, loginController.Nome);
            relatorio.Show();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                txtNumeroMovimentacao.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtCodigo.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtDescriao.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                cboUnidade.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                txtQuantidade.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                txtCodigo.Enabled = false;

            }
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var filtro = new frmEstoquePesquisa(this);
            filtro.ShowDialog();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            loadGridView1();
            clearAll();
        }
    }
}
