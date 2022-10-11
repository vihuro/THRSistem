using System;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Compras
{
    public partial class frmPequisarEstoque : Form
    {
        Compras.frmRequisicaoCompra compras;
        public frmPequisarEstoque(Compras.frmRequisicaoCompra compras)
        {
            this.compras = compras;
            InitializeComponent();
        }

        private void frmPequisarEstoque_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void loadGridView()
        {
            Controller.manutencao.EstoquePecasController controller = new Controller.manutencao.EstoquePecasController();
            Service.manutencao.EstoquePecasService service = new Service.manutencao.EstoquePecasService();
            service.table(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                dataGridView1.DataSource = controller.Dt;
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
