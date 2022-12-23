using SistemaTHR.Controller.Login;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.Service.manutencao;
using System;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Compras
{
    public partial class frmPequisarEstoque : Form
    {
        private frmRequisicaoCompra compras;
        private EstoquePecasController controller;
        private EstoquePecasService service;
        private loginController loginController;
        private modulosController modulosController;
        public frmPequisarEstoque(frmRequisicaoCompra compras, loginController loginController, modulosController modulosController)
        {
            this.compras = compras;
            service = new EstoquePecasService(loginController,modulosController);
            InitializeComponent();
        }

        private void frmPequisarEstoque_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void loadGridView()
        {
            controller = new EstoquePecasController();
            try
            {
                dataGridView1.DataSource = service.table();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString(),"SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            compras.txtCodigo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            compras.txtDescricao.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
            compras.txtUnidade.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            this.Close();

        }

        private void Cancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
