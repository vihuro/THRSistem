using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication
{
    public partial class frmPainelTransferencias : Form
    {

        private Controller.Login.loginController loginController;
        private Controller.Login.modulosController modulosController;

        private Controller.transferencia.transferenciaController transferenciaController = new Controller.transferencia.transferenciaController();
        private Controller.transferencia.movimentacaoController movimentacaoController;
        private Controller.transferencia.fechamentoController fechamentoController;
        private Service.transferencia.transferenciaService transferenciaService = new Service.transferencia.transferenciaService();
        public frmPainelTransferencias(Controller.Login.loginController loginController, Controller.Login.modulosController modulosController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.modulosController = modulosController;
 
        }

        private void loadGridView1()
        {
            
            transferenciaService.historico(transferenciaController);
            if(transferenciaController.Msg != null)
            {
                MessageBox.Show(transferenciaController.Msg);
            }
            else
            {
                dataGridView1.DataSource = transferenciaController.Dt;
            }
        }

        private void frmPainelTransferencias_Load(object sender, EventArgs e)
        {
            loadGridView1();
        }


        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.Value != null && e.Value.Equals("26/06/2022 12:20:43"))
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ToString();
            }

            if (e.Value != null && e.Value.Equals("vitor"))
            {

                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.BlueViolet;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Black;
                
            }
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            DataGridView dataGridView = (DataGridView)sender;
            int i = dataGridView.SelectedRows.Count;

            if(i > 0)
            {
                Controller.transferencia.movimentacaoController movimentacaoController = new Controller.transferencia.movimentacaoController();
                Controller.transferencia.fechamentoController fechamentoController = new Controller.transferencia.fechamentoController();

                movimentacaoController.IdTansferencia = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
                fechamentoController.IdTransferencia = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();

                this.movimentacaoController = movimentacaoController;
                this.fechamentoController = fechamentoController;

                loadDataGridView2(movimentacaoController);
                loadDataGridView3(fechamentoController);
            }
            this.Cursor = Cursors.Default;
        }


        private void loadDataGridView2(Controller.transferencia.movimentacaoController movimentacaoController) 
        {
            this.movimentacaoController = movimentacaoController;
            Service.transferencia.movimentacaoService movimentacaoService = new Service.transferencia.movimentacaoService();
            movimentacaoService.table(movimentacaoController);
            if(movimentacaoController.Msg != null)
            {
                MessageBox.Show(movimentacaoController.Msg);
            }
            else
            {
                dataGridView2.DataSource = movimentacaoController.Dt;
            }

        }

        private void loadDataGridView3(Controller.transferencia.fechamentoController fechamentoController)
        {
            this.fechamentoController = fechamentoController;
            Service.transferencia.fechamentoService fechamentoService = new Service.transferencia.fechamentoService();
            fechamentoService.table(fechamentoController);
            if(fechamentoController.Msg != null)
            {
                MessageBox.Show(fechamentoController.Msg);
            }
            else
            {
                dataGridView3.DataSource = fechamentoController.Dt;
            }

        }


        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarTransferencia frmEditarTransferencia = new frmEditarTransferencia(fechamentoController,movimentacaoController,loginController);
            frmEditarTransferencia.Show();

        }

        

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            frmSelectImp selectImp = new frmSelectImp(movimentacaoController, fechamentoController);
            selectImp.ShowDialog();
        }

    }
}
