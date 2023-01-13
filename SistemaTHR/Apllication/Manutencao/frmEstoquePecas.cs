using System;
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
using SistemaTHR.Service.Exepction;

namespace SistemaTHR.Apllication.Manutencao
{
    public partial class frmEstoquePecas : Form
    {
        private loginController loginController;
        private modulosController modulosController;
        private movimentacaoPecasService movimentacaoService;
        private EstoquePecasService estoqueService;
        private EstoquePecasController controller;
        private movimentacaoPecasController movimentacaoController;
        public frmEstoquePecas(loginController loginController, modulosController modulosController)
        {
            this.loginController = loginController;
            this.modulosController = modulosController;
            IniciarMovimentacaoService();
            IniciarEstoqueService();
            InitializeComponent();
        }


        private EstoquePecasService IniciarEstoqueService()
        {
            return estoqueService = new EstoquePecasService(loginController, modulosController);
        }

        private movimentacaoPecasService IniciarMovimentacaoService()
        {
            return movimentacaoService = new movimentacaoPecasService(loginController, modulosController);
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
                    controller = new EstoquePecasController();

                    controller.Codigo = txtCodigo.Text;
                    controller.Descricao = txtDescricao.Text;
                    controller.Unidade = cboUnidade.Text;
                    controller.Fornecedor1 = txtFornecedor1.Text;
                    controller.CodFornecedor1 = txtCodFornecedor1.Text;
                    controller.Fornecedor2 = txtFornecedor2.Text;
                    controller.CodFornecedor2 = txtCodFornecedor2.Text;
                    controller.Fornecedor3 = txtFornecedor3.Text;
                    controller.CodFornecedor3 = txtCodFornecedor3.Text;
                    controller.EstoqueMin = txtEstoqueMin.Text;
                    controller.EstoqueMax = txtEstoqueMax.Text;

                    estoqueService.Insert(controller);
                    if (controller.Msg != null)
                    {
                        MessageBox.Show(controller.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Item adicionado com sucesso!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadGridView1();
                        clearAll();

                    }
                }
            }
            else
            {
                MessageBox.Show("Campo(s) obrigatório(s) vazio(s). Não é possível salvar itens em branco!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            this.Cursor = Cursors.Default;
        }

        private void clearAll()
        {


            dataGridView1.ClearSelection();

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2.Rows.Remove(dataGridView2.Rows[i]);
                if (i == dataGridView2.Rows.Count - 1)
                {
                    break;
                }
            }

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
            txtEstoqueMin.Text = string.Empty;
            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;


        }

        private void loadGridView1()
        {
            this.Cursor = Cursors.WaitCursor;

            try
            {
                dataGridView1.DataSource = estoqueService.table();
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (i == dataGridView1.Rows.Count - 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                    }
                }

                clearAll();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(), "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Cursor = Cursors.Default;
        }

        public void loadGridView1(DataTable dt)
        {
            this.Cursor = Cursors.WaitCursor;


            dataGridView1.DataSource = dt;

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
                btnAlterar.Enabled = true;

                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;

                movimentacaoController = new movimentacaoPecasController();

                movimentacaoController.CodigoPeca = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

                loadGridView2(movimentacaoController);

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

        private void loadGridView2(movimentacaoPecasController controller)
        {

            movimentacaoService.history(controller);
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

            frmEstoquePesquisa filtro = new frmEstoquePesquisa(this, loginController, modulosController);
            filtro.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        public void LoadGridViewFilter()
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            loadGridView1();
            clearAll();
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            frmEntradaSaidaPecas filtro = new frmEntradaSaidaPecas(this, loginController, modulosController);
            filtro.ShowDialog();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            controller = new EstoquePecasController();

            controller.Descricao = txtDescricao.Text;
            controller.Unidade = cboUnidade.Text;
            controller.Fornecedor1 = txtFornecedor1.Text;
            controller.CodFornecedor1 = txtCodFornecedor1.Text;
            controller.Fornecedor2 = txtFornecedor2.Text;
            controller.CodFornecedor2 = txtCodFornecedor2.Text;
            controller.Fornecedor3 = txtFornecedor3.Text;
            controller.CodFornecedor3 = txtCodFornecedor3.Text;
            controller.EstoqueMin = txtEstoqueMin.Text;
            controller.EstoqueMax = txtEstoqueMax.Text;

            controller.Codigo = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            estoqueService.Update(controller);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Alteração feita com sucesso!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                loadGridView1();
                clearAll();
            }

        }

        private void txtCodigo_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyCode == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                Procurar();
            }
        }

        private void Procurar()
        {
            try
            {
                var obj = estoqueService.BuscarPorCodigo(txtCodigo.Text);
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[1].Value.ToString() == obj.Codigo)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                        break;
                    }
                }


            }
            catch (ExceptionService ex)
            {
                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtDescricao.Text = string.Empty;
                cboUnidade.Text = string.Empty;
                txtFornecedor1.Text = string.Empty;
                txtFornecedor2.Text = string.Empty;
                txtFornecedor3.Text = string.Empty;
                txtCodFornecedor1.Text = string.Empty;
                txtCodFornecedor2.Text = string.Empty;
                txtCodFornecedor3.Text = string.Empty;
                txtEstoqueMax.Text = string.Empty;
                txtEstoqueMin.Text = string.Empty;
                btnSalvar.Enabled = true;
                btnAlterar.Enabled = false;

            }
        }


        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtCodigo.Text.Length > 0)
            {
                try
                {
                    var obj = estoqueService.BuscarPorCodigo(txtCodigo.Text);
                    
                    for(int i = 0; i < dataGridView1.Rows.Count; i++)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                        break;
                    }
                }
                catch (ExceptionService ex)
                {
                    if(ex.Message == "Código não encontrado!")
                    {
                        var result = DialogResult;
                        result = MessageBox.Show("Código não encontrado! Deseja cadastrar um novo material?", "SISTEMA THR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                        if(result == DialogResult.Yes)
                        {
                            dataGridView1.ClearSelection();

                            txtDescricao.Text = string.Empty;
                            cboUnidade.Text = string.Empty;
                            txtFornecedor1.Text = string.Empty;
                            txtFornecedor2.Text = string.Empty;
                            txtFornecedor3.Text = string.Empty;
                            txtCodFornecedor1.Text = string.Empty;
                            txtCodFornecedor2.Text = string.Empty;
                            txtCodFornecedor3.Text = string.Empty;
                            txtEstoqueMax.Text = string.Empty;
                            txtEstoqueMin.Text = string.Empty;
                            btnSalvar.Enabled = true;
                            btnAlterar.Enabled = false;
                        }
                        else
                        {
                            loadGridView1();
                            clearAll();
                        }
                    }
                    else
                    {
                        MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    }
                }
            }
        }
    }
}
