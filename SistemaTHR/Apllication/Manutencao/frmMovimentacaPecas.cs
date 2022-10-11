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
        }

        private void loadGridView1()
        {
            Controller.manutencao.movimentacaoPecasController controller = new Controller.manutencao.movimentacaoPecasController();
            Service.manutencao.movimentacaoPecasService service = new Service.manutencao.movimentacaoPecasService(loginController);
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
            Controller.manutencao.movimentacaoPecasController controller = new Controller.manutencao.movimentacaoPecasController();
            Service.manutencao.movimentacaoPecasService service = new Service.manutencao.movimentacaoPecasService(loginController);
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
            }
        }
        private void alterarEstoque(Controller.manutencao.EstoquePecasController controller)
        {
            Service.manutencao.EstoquePecasService service = new Service.manutencao.EstoquePecasService();
            service.entradaEstoque(controller);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
        }
    }
}
