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

namespace SistemaTHR.Apllication.Manutencao
{
    public partial class frmEstoquePecas : Form
    {
        Controller.Login.loginController loginController;
        Controller.Login.modulosController modulosController;
        public frmEstoquePecas(Controller.Login.loginController loginController, Controller.Login.modulosController modulosController)
        {
            this.loginController = loginController;
            this.modulosController = modulosController;
            InitializeComponent();
        }

        private void frmEstoquePecas_Load(object sender, EventArgs e)
        {
            loadGridView1();
            clearAll();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txtCodigo.Text != string.Empty && txtDescricao.Text != string.Empty && cboUnidade.Text != string.Empty)
            {
                if (Convert.ToDecimal(txtEstoqueMax.Text.ToString()) < Convert.ToDecimal(txtEstoqueMin.Text.ToString()))
                {
                    MessageBox.Show("Estoque mínimo não pode ser menor que o estoque máximo!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Controller.manutencao.EstoquePecasController controller = new Controller.manutencao.EstoquePecasController();
                    Service.manutencao.EstoquePecasService service = new Service.manutencao.EstoquePecasService();
                    controller.Codigo = txtCodigo.Text;
                    controller.Descricao = txtDescricao.Text;
                    controller.Unidade = cboUnidade.Text;
                    controller.QtEstoque = "0";
                    controller.Fornecedor1 = txtFornecedor1.Text;
                    controller.CodFornecedor1 = txtCodFornecedor1.Text;
                    controller.Fornecedor2 = txtFornecedor2.Text;
                    controller.CodFornecedor2 = txtCodFornecedor2.Text;
                    controller.Fornecedor3 = txtFornecedor3.Text;
                    controller.CodFornecedor3 = txtCodFornecedor3.Text;
                    controller.EstoqueMin = txtEstoqueMin.Text;
                    controller.EstoqueMax = txtEstoqueMax.Text;
                    controller.UsuarioGravacao = loginController.Nome;
                    controller.DataHoraGravacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:sss"));
                    service.insert(controller);
                    if (controller.Msg != null)
                    {
                        MessageBox.Show(controller.Msg);
                    }
                    else
                    {
                        clearAll();

                    }
                }
            }
            else
            {
                MessageBox.Show("Iten(s) obrigatório(s) vazio(s). Não é possível salvar itens em braco!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Cursor = Cursors.Default;
        }

        private void clearAll()
        {


            dataGridView1.ClearSelection();

            txtCodigo.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            cboUnidade.Text = string.Empty;
            txtFornecedor1.Text = string.Empty;
            txtFornecedor2.Text = string.Empty;
            txtFornecedor3.Text = string.Empty;
            txtCodFornecedor1.Text = string.Empty;
            txtCodFornecedor2.Text = string.Empty;
            txtCodFornecedor3.Text = string.Empty;
            txtEstoqueMax.Text = string.Empty;
            txtEstoqueMax.Text = string.Empty;
            btnSalvar.Enabled = true;


        }

        private void loadGridView1()
        {
            this.Cursor = Cursors.WaitCursor;
            Controller.manutencao.EstoquePecasController controller = new Controller.manutencao.EstoquePecasController();
            Service.manutencao.EstoquePecasService service = new Service.manutencao.EstoquePecasService();
            service.table(controller);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                dataGridView1.DataSource = controller.Dt;

                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (i == dataGridView1.Rows.Count - 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                    }
                }
            }
            clearAll();
            this.Cursor = Cursors.Default;
        }

        public void loadGridView1(EstoquePecasController controller)
        {
            this.Cursor = Cursors.WaitCursor;


            dataGridView1.DataSource = controller.Dt;

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (i == dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnSalvar.Enabled = false;

                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
                Controller.manutencao.movimentacaoPecasController controller = new Controller.manutencao.movimentacaoPecasController();
                controller.CodigoPeca = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                loadGridView2(controller);

                txtCodigo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();


                txtDescricao.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                cboUnidade.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                txtFornecedor1.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                txtCodFornecedor1.Text = dataGridView1.SelectedRows[0].Cells[8].Value.ToString();

                txtFornecedor2.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                txtCodFornecedor2.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();

                txtFornecedor3.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                txtCodFornecedor3.Text = dataGridView1.SelectedRows[0].Cells[12].Value.ToString();


                txtEstoqueMax.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtEstoqueMin.Text = dataGridView1.SelectedRows[0].Cells[6].Value.ToString();


            }
        }

        private void loadGridView2(Controller.manutencao.movimentacaoPecasController controller)
        {
            Service.manutencao.movimentacaoPecasService service = new Service.manutencao.movimentacaoPecasService(loginController);
            service.history(controller);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                dataGridView2.DataSource = controller.Dt;
            }
        }

        private void txtEstoqueMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmEstoquePesquisa filtro = new frmEstoquePesquisa(this);
            filtro.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        public void LoadGridViewFilter()
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            clearAll();
        }
    }
}
