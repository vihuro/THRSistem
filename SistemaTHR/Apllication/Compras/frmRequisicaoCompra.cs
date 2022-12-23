using SistemaTHR.Controller.Compras;
using SistemaTHR.Controller.Login;
using SistemaTHR.Service.Compras;
using System;

using System.Drawing;

using System.Windows.Forms;

namespace SistemaTHR.Apllication.Compras
{
    public partial class frmRequisicaoCompra : Form
    {
        private loginController loginController;
        private modulosController modulosController;
        private requisicaoCompraController controller;
        requisicaoCompraService service;

        public frmRequisicaoCompra(loginController loginController, modulosController modulosController)
        {
            this.loginController = loginController;
            this.modulosController = modulosController;
            service = new requisicaoCompraService(loginController,modulosController);
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            frmPequisarEstoque pesquisar = new frmPequisarEstoque(this,loginController,modulosController);
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
            txtDescricao.Text = string.Empty;
            txtUnidade.Text = string.Empty;
            txtNRequisicao.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            txtUnidade.Text = string.Empty;
            dataGridView1.ClearSelection();
            btnSalvar.Enabled = true;

        }

        private void loadGridView()
        {
            controller = new requisicaoCompraController();

            try
            {
                dataGridView1.DataSource = service.Table();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            controller = new requisicaoCompraController();
            controller.NRequisicao = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            service.updateAuth(controller);
            try
            {
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
 
            if ( dataGridView1.SelectedRows.Count > 0)
            {


                if (modulosController.ComprasNivel != "1")
                {
                    if(dataGridView1.SelectedRows[0].Cells[7].Value.ToString() == "Autorizado")
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
                    else if(dataGridView1.SelectedRows[0].Cells[7].Value.ToString() == "Comprado")
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
            if(txtCodigo.Text != string.Empty && txtDescricao.Text != string.Empty && 
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
                MessageBox.Show("Campos obrigatórios em branco!", "SISTEMA THR", MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
                return  "00/00/0000";
            }
            else
            {

                return Convert.ToString(dateTimePicker1.Value.ToString("dd/MM/yyyy"));
            }
        }
    }
}
