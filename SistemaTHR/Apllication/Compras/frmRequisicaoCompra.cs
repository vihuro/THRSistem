using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Compras
{
    public partial class frmRequisicaoCompra : Form
    {
        Controller.Login.loginController loginController;
        Controller.Login.modulosController modulosController;

        public frmRequisicaoCompra(Controller.Login.loginController loginController, Controller.Login.modulosController modulosController)
        {
            this.loginController = loginController;
            this.modulosController = modulosController;
            InitializeComponent();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            Compras.frmPequisarEstoque pesquisar = new frmPequisarEstoque(this);
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
            Controller.Compras.requisicaoCompraController controller = new Controller.Compras.requisicaoCompraController();
            Service.Compras.requisicaoCompraService service = new Service.Compras.requisicaoCompraService();
            service.table(controller);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                dataGridView1.DataSource = controller.Dt;
            }
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            Controller.Compras.requisicaoCompraController controller = new Controller.Compras.requisicaoCompraController();
            Service.Compras.requisicaoCompraService service = new Service.Compras.requisicaoCompraService();
            controller.UsuarioAutorizador = loginController.Nome;
            controller.DataHoraAutorizacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            controller.Status = "Autorizado";
            controller.NRequisicao = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            service.auth(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                loadGridView();
                clearAll();
            }
        }

        private void btnComprado_Click(object sender, EventArgs e)
        {
            Controller.Compras.requisicaoCompraController controller = new Controller.Compras.requisicaoCompraController();
            Service.Compras.requisicaoCompraService service = new Service.Compras.requisicaoCompraService();
            controller.UsuarioCompra = loginController.Nome;
            controller.DataHotaCompra = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            controller.Status = "Comprado";
            controller.NRequisicao = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            service.compra(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                loadGridView();
                clearAll();
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
                        btnComprado.Enabled = true;
                    }
                    else
                    {
                        btnComprado.Enabled = false;

                    }
                }
                else
                {
                    if (dataGridView1.SelectedRows[0].Cells[7].Value.ToString() == "Autorizado")
                    {
                        btnComprado.Enabled = true;
                        btnAutorizar.Enabled = false;

                    }
                    else if(dataGridView1.SelectedRows[0].Cells[7].Value.ToString() == "Comprado")
                    {
                        btnComprado.Enabled = false;
                        btnAutorizar.Enabled = false;
                    }
                    else
                    {
                        btnComprado.Enabled = false;
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
                Controller.Compras.requisicaoCompraController controller = new Controller.Compras.requisicaoCompraController();
                Service.Compras.requisicaoCompraService service = new Service.Compras.requisicaoCompraService();
                controller.Codigo = txtCodigo.Text;
                controller.Descricao = txtDescricao.Text;
                controller.Quantidade = txtQuantidade.Text;
                controller.Unidade = txtUnidade.Text;
                controller.UsuarioSolicitacao = loginController.Nome;
                controller.DataHoraSolicitacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                service.insert(controller);
                if (controller.Msg != null)
                {
                    MessageBox.Show(controller.Msg);
                }
                else
                {
                    clearAll();
                    loadGridView();
                }
            }
            else
            {
                MessageBox.Show("Campos obrigatórios em branco!", "SISTEMA THR", MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }
    }
}
