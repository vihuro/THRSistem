using SistemaTHR.Apllication.Manutencao.Impressao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Manutencao
{
    public partial class frmMovimentacaPecas : Form
    {
        private Controller.Login.loginController loginController;
        private Controller.Login.modulosController modulosController;
        public frmMovimentacaPecas(Controller.Login.loginController loginController, Controller.Login.modulosController modulosController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.modulosController = modulosController;
        }

        private void frmMovimentacaPecas_Load(object sender, EventArgs e)
        {
            loadGridView1();
            clearAll();
        }

        private void clearAll()
        {
            //throw new NotImplementedException();
            dataGridView1.ClearSelection();
        }

        private void loadGridView1()
        {
            Controller.manutencao.movimentacaoPecasController controller = new Controller.manutencao.movimentacaoPecasController();
            Service.manutencao.movimentacaoPecasService service = new Service.manutencao.movimentacaoPecasService(loginController,modulosController);
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
                        break;
                    }
                }
                clearAll();
            }
        }

        public void LoadGridViewFilter(DataTable dt)
        {
            dataGridView1.DataSource = dt;
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(i == dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                    break;
                }
            }
            clearAll();
        }



        private void btnEntrada_Click(object sender, EventArgs e)
        {
            Controller.manutencao.EstoquePecasController controller = new Controller.manutencao.EstoquePecasController();
            controller.Codigo = txtCodigo.Text;
            controller.QtEstoque = txtQuantidade.Text;
            verificarCodigo(controller);

        }

        private void verificarCodigo(Controller.manutencao.EstoquePecasController controller)
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
            var filtro = new frmFiltroMovimentacoesPeca(loginController,modulosController,this);
            filtro.ShowDialog();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for(int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
            }
        }

        private void btnRelatorio_Click(object sender, EventArgs e)
        {
            var relatorio = new frmRelatorioMovimentacaoPecas((DataTable)dataGridView1.DataSource, loginController.Nome);
            relatorio.Show();
        }
    }
}
