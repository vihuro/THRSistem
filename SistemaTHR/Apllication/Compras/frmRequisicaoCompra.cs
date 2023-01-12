using SistemaTHR.Controller.Compras;
using SistemaTHR.Controller.Login;
using SistemaTHR.Service.Compras;
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

        public frmRequisicaoCompra(loginController loginController, modulosController modulosController)
        {
            this.loginController = loginController;
            this.modulosController = modulosController;
            service = new requisicaoCompraService(loginController, modulosController);
            acompanhamentoService = new AcompanhamentoRequisicaoCompraService(modulosController, loginController);
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPequisarEstoque pesquisar = new frmPequisarEstoque(this, loginController, modulosController);
            pesquisar.ShowDialog();
        }

        private void frmRequisicaoCompra_Load(object sender, EventArgs e)
        {
            loadGridView();
            clearAll();
        }

        private void clearAll()
        {
            txtCodigo.Text = string.Empty;
            dateTimePicker1.CustomFormat = "00/00/00";
            txtDescricao.Text = string.Empty;
            txtUnidade.Text = string.Empty;
            txtNRequisicao.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtUnidade.Text = string.Empty;
            cboPrioridade.Text = string.Empty;
            cboFreteIncluso.Text = string.Empty;
            dataGridView1.ClearSelection();
            var dt = (DataTable)dataGridView2.DataSource;
            dt.Rows.Clear();
            dataGridView2.DataSource = dt;
            btnSalvar.Enabled = true;


        }

        private void loadGridView()
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
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }


        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView1.SelectedRows.Count > 0)
            {

                // Aqui fica o relaciomento dos campos
                txtNRequisicao.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtCodigo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtDescricao.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                txtQuantidade.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                txtUnidade.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                cboPrioridade.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                dateTimePicker1.CustomFormat = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[6].Value).ToString("dd/MM/yyyy");
                txtValor.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                cboFreteIncluso.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();
                txtFornecedor.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                cboFrete.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                txtEstadoCompra.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();

                SearchForNumber(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());

                if (modulosController.ComprasNivel != "1" && modulosController.ComprasNivel != "2")
                {
                    if (dataGridView1.SelectedRows[0].Cells[7].Value.ToString() == "Autorizado")
                    {
                        btnSalvar.Enabled = true;
                    }
                    else
                    {
                        btnSalvar.Enabled = false;

                    }
                }
                else
                {
                    if (dataGridView1.SelectedRows[0].Cells[7].Value.ToString() == "Autorizado")
                    {
                        btnSalvar.Enabled = true;
                        btnAutorizar.Enabled = false;

                    }
                    else if (dataGridView1.SelectedRows[0].Cells[7].Value.ToString() == "Comprado")
                    {
                        btnSalvar.Enabled = false;
                        btnAutorizar.Enabled = false;
                    }
                    else
                    {
                        btnSalvar.Enabled = false;
                        btnAutorizar.Enabled = true;
                    }

                }
            }
        }

        private void SearchForNumber(string numeroRequisicao)
        {

            var dataTable = acompanhamentoService.Table();

            dataTable.DefaultView.RowFilter = string.Format("[numeroRequisicao] = '{0}'", numeroRequisicao);
            dataGridView2.DataSource = dataTable;
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
            loadGridView();
            clearAll();

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
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
                    service.verificarAberto(controller);

                    clearAll();
                    loadGridView();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.ToString(), "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campos obrigatórios em branco!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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

        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor; 
            if(dataGridView2.SelectedRows.Count > 0)
            {
                txtObservacao.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
            };
            this.Cursor = Cursors.Default;

        }
    }
}
