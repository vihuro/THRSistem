using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTHR.Service.estoque;
using SistemaTHR.Controller.estoque;
using SistemaTHR.Controller.Login;

namespace SistemaTHR.Apllication.Estoque
{
    public partial class frmFilterEstoque : Form
    {
        private loginController loginController;
        private EstoqueController controller;
        private EstoqueService service;
        private frmEstoque formularioEstoque;
        private frmRequisicaoMaterial requisicaoMaterial;
        private frmMovimentacaoMaterial movimentacaoMaterial;
        private MovimentacaoController movController;
        private MovimentacaoSerivce movService;

        public frmFilterEstoque(frmEstoque formularioEstoque, EstoqueService service,loginController loginCotroller)
        {
            this.formularioEstoque = formularioEstoque;
            this.service = service;
            this.loginController = loginCotroller;
            IniciarMovService();
            InitializeComponent();
            btnCarregar.Enabled = false;

        }

        private MovimentacaoSerivce IniciarMovService()
        {
            return this.movService = new MovimentacaoSerivce(loginController);
        }

        public frmFilterEstoque(frmRequisicaoMaterial requisicaoMaterial, EstoqueService service)
        {
            this.requisicaoMaterial = requisicaoMaterial;
            this.service = service;
            IniciarMovService();
            InitializeComponent();
            btnFiltrar.Enabled = false;

        }

        public frmFilterEstoque(frmMovimentacaoMaterial movimentacaoMaterial, EstoqueService service)
        {
            this.movimentacaoMaterial = movimentacaoMaterial;
            this.service = service;
            IniciarMovService();
            InitializeComponent();
            btnFiltrar.Enabled = false;

        }



        private void frmFilterEstoque_Load(object sender, EventArgs e)
        {
            LoadGridView();
            cboCampo.Text = "Descrição";

        }


        private void LoadGridView()
        {
            controller = new EstoqueController();
            service.selectTable(controller);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg,"SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.DataSource = controller.Dt;
                for (var i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (i == dataGridView1.Rows.Count - 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[2];
                        break;
                    }
                }
            }
        }

        private void LoadGridViewFilter()
        {
            controller = new EstoqueController();
            controller.Descricao = txtDescricao.Text;
            service.FilterTableDescricao(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg,"SISTEMA THR");
            }
            else
            {
                dataGridView1.DataSource = controller.Dt;
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == string.Empty ||
                dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "0,00")
            {

                if(requisicaoMaterial != null)
                {
                    MessageBox.Show("Não é possivel requisitar um material com o saldo zero!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if(movimentacaoMaterial != null)
                {
                    movimentacaoMaterial.txtCodigo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    movimentacaoMaterial.txtDescricao.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    movimentacaoMaterial.quantidadeDisponivel = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                    movimentacaoMaterial.txtFornecedor.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                    this.Close();
                }

            }
            else if (movimentacaoMaterial != null)
            {
                movimentacaoMaterial.txtCodigo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                movimentacaoMaterial.txtDescricao.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                movimentacaoMaterial.quantidadeDisponivel = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                movimentacaoMaterial.txtFornecedor.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                this.Close();

            }
            else if (requisicaoMaterial != null)
            {
                requisicaoMaterial.txtCodigo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                requisicaoMaterial.txtDescricao.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                requisicaoMaterial.txtFornecedor.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();

                this.Close();
            }
            else
            {
                MessageBox.Show("Não é possivel movimentar um material com o saldo zero!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            this.Cursor = Cursors.Default;
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            if(cboCampo.Text == "Descrição")
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[Descricao] like '%{0}%'", txtDescricao.Text);

                dataGridView1.DataSource = controller.Dt;
            }
            else if(cboCampo.Text == "Código")
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[Codigo] like '%{0}%'", txtDescricao.Text);

                dataGridView1.DataSource = controller.Dt;
            }
            else if(cboCampo.Text == "Grupo")
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[Grupo] like '%{0}%'", txtDescricao.Text);

                dataGridView1.DataSource = controller.Dt;
            }
            else
            {
                MessageBox.Show("Escolha um filtro!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            movController = new MovimentacaoController();
            movService.SelectTable(movController);
            if(movController.Msg != null)
            {
                MessageBox.Show(movController.Msg);
            }
            else
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var soma = service.Count(movController, dataGridView1.Rows[i].Cells[1].Value.ToString());
                    if(soma == 0)
                    {
                        dataGridView1.Rows[i].Cells[9].Value = "0,00";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[9].Value = soma.ToString("###,###.##");
                    }

                }
            }
            this.Cursor = Cursors.Default;

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            formularioEstoque.LoadWithFilter(controller);
            this.Close();
        }

    }
}
