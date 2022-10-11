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
    public partial class frmEditarTransferencia : Form
    {


        Controller.transferencia.fechamentoController fechamentoController;
        Controller.transferencia.movimentacaoController movimentacaoController;
        Controller.Login.loginController loginController;

        Service.transferencia.fechamentoService fechamentoService = new Service.transferencia.fechamentoService();
        Service.transferencia.movimentacaoService movimentacaoService = new Service.transferencia.movimentacaoService();


        int i;
        decimal pesoBrutoMovi;
        decimal pesoLiquidoMovi;
        decimal qtBobinasMovi;
        decimal pesoBrutoFech;
        decimal pesoLiquidoFech;
        decimal qtBobinasFech;
        decimal pesoBrutoResultado;
        decimal pesoLiquidoResultado;
        decimal qtBobinasResultado;
        decimal pesoBrutoTotal;
        decimal pesoLiquidoTotal;
        decimal qtBobinasTotal;

        public frmEditarTransferencia
            (Controller.transferencia.fechamentoController fechamentoController,
            Controller.transferencia.movimentacaoController movimentacaoController,
            Controller.Login.loginController loginController)
        {
            InitializeComponent();
            this.fechamentoController = fechamentoController;
            this.movimentacaoController = movimentacaoController;
            this.loginController = loginController;


        }

        private void frmEditarTransferencia_Load(object sender, EventArgs e)
        {
            loadGridView1(this.movimentacaoController);
            loadGridView2(fechamentoController);
        }

        private void txtNumeroPA_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                loadPA();

            }
        }

        private void loadGridView1(Controller.transferencia.movimentacaoController movimentacaoController)
        {


            dataGridView1.DataSource = movimentacaoController.Dt;

            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (i == dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];

                    break;
                }

            }
            dataGridView1.ClearSelection();
        }

        private void loadGridView2(Controller.transferencia.fechamentoController fechamentoController)
        {


            dataGridView2.DataSource = fechamentoController.Dt;

            for (var i = 0; i < dataGridView2.Rows.Count; i++)
            {

                if (i == dataGridView2.Rows.Count - 1)
                {
                    dataGridView2.CurrentCell = dataGridView2.Rows[i].Cells[1];

                    break;
                }

            }
            dataGridView2.ClearSelection();
        }

        private void LoadGridSelectCodigo(Controller.transferencia.fechamentoController fechamentoController)
        {


            dataGridView2.DataSource = fechamentoController.Dt;

            for (var i = 0; i < dataGridView2.Rows.Count; i++)
            {

                if (dataGridView2.Rows[i].Cells[1].Value.ToString() == fechamentoController.Codigo)
                {
                    dataGridView2.CurrentCell = dataGridView2.Rows[i].Cells[1];

                    break;
                }

            }

        }


        private void btnRemover_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {

                    if (dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[1].Value.ToString() == dataGridView1.SelectedRows[0].Cells[2].Value.ToString())
                    {
                        this.i = i;

                        Subtrair();


                        if (pesoBrutoTotal == 0)
                        {

                            fechamentoController.Id = dataGridView2.Rows[i].Cells[0].Value.ToString();

                            fechamentoController.Id = dataGridView2.Rows[i].Cells[0].Value.ToString();
                            fechamentoService = new Service.transferencia.fechamentoService();
                            fechamentoService.delete(fechamentoController);
                            if(fechamentoController.Msg != null)
                            {
                                MessageBox.Show(fechamentoController.Msg);
                            }
                            else
                            {
                                dataGridView2.Rows.Remove(dataGridView2.Rows[i]);
                            }

                        }
                        else
                        {
                            dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[3].Value = pesoBrutoTotal.ToString("###,###.#0");
                            dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[4].Value = pesoLiquidoTotal.ToString("###,###.#0");
                            dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[5].Value = qtBobinasTotal.ToString("###,###.#0");

                            fechamentoController.Id = dataGridView2.Rows[0].Cells[0].Value.ToString();
                            fechamentoController.PesoBruto = pesoBrutoTotal.ToString("###,###.#0");
                            fechamentoController.PesoLiquido = pesoLiquidoTotal.ToString("###,###.#0");
                            fechamentoController.Bobinas = qtBobinasTotal.ToString("###,###.#0");

                            fechamentoService = new Service.transferencia.fechamentoService();
                            fechamentoService.update(fechamentoController);
                            if(fechamentoController.Msg != null)
                            {
                                MessageBox.Show(fechamentoController.Msg);
                            }

                        }

                        break;
                    }


                }
                movimentacaoController.Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                movimentacaoService = new Service.transferencia.movimentacaoService();
                movimentacaoService.delete(movimentacaoController);
                if(movimentacaoController.Msg != null)
                {
                    MessageBox.Show(movimentacaoController.Msg);
                }
                else
                {
                    dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
                }

            }

        }

        private void Subtrair()
        {
            pesoBrutoMovi = Convert.ToDecimal(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[4].Value.ToString());
            pesoLiquidoMovi = Convert.ToDecimal(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[5].Value.ToString());
            qtBobinasMovi = Convert.ToDecimal(dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[6].Value.ToString());

            pesoBrutoFech = Convert.ToDecimal(dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[3].Value.ToString());
            pesoLiquidoFech = Convert.ToDecimal(dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[4].Value.ToString());
            qtBobinasFech = Convert.ToDecimal(dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[5].Value.ToString());

            pesoBrutoResultado = pesoBrutoMovi - pesoBrutoFech;
            pesoLiquidoResultado = pesoLiquidoMovi - pesoLiquidoFech;
            qtBobinasResultado = qtBobinasMovi - qtBobinasFech;

            pesoBrutoTotal = pesoBrutoResultado * -1;
            pesoLiquidoTotal = pesoLiquidoResultado * -1;
            qtBobinasTotal = qtBobinasResultado * -1;
        }

        private void loadPA()
        {

            Controller.estoque.paController controller = new Controller.estoque.paController();
            Service.estoque.paEstoqueService service = new Service.estoque.paEstoqueService();

            controller.NumeroPa = txtNumeroPA.Text;
            if (rdbProdução.Checked == true)
            {
                service.PaEstoque(controller);
            }
            if (rdbExpedicao.Checked == true)
            {
                service.PaExpedicao(controller);
            }

            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else if (controller.Codigo != null)
            {
                movimentacaoController.NumeroPa = controller.NumeroPa;
                movimentacaoController.Codigo = controller.Codigo;
                movimentacaoController.Descricao = controller.Descricao;
                movimentacaoController.PesoBruto = controller.PesoBruto.ToString("###,###.#0");
                movimentacaoController.PesoLiquido = controller.PesoLiquido.ToString("###,###.#0");
                movimentacaoController.Bobinas = controller.Bobinas.ToString("###,###");
                movimentacaoController.Usuario = loginController.Nome;

                movimentacaoService.insert(this.movimentacaoController);

                if (this.movimentacaoController.Msg != null)
                {
                    MessageBox.Show(movimentacaoController.Msg);
                }
                else
                {
                    carregar();
                    movimentacaoService.table(movimentacaoController);
                    loadGridView1(movimentacaoController);
                }

            }
            else
            {
                MessageBox.Show("P.A não localizada. Tente alterar o local de estocagem!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void somar()
        {
            pesoBrutoFech = Convert.ToDecimal(dataGridView2.Rows[i].Cells[3].Value.ToString());
            pesoLiquidoFech = Convert.ToDecimal(dataGridView2.Rows[i].Cells[4].Value.ToString());
            qtBobinasFech = Convert.ToDecimal(dataGridView2.Rows[i].Cells[5].Value.ToString());

            pesoBrutoResultado = pesoBrutoFech + Convert.ToDecimal(movimentacaoController.PesoBruto.ToString());
            pesoLiquidoResultado = pesoLiquidoFech + Convert.ToDecimal(movimentacaoController.PesoLiquido.ToString());
            qtBobinasResultado = qtBobinasFech + Convert.ToDecimal(movimentacaoController.Bobinas.ToString());


        }

        private void carregar()
        {
            if (dataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (dataGridView2.Rows[i].Cells[1].Value.ToString() == movimentacaoController.Codigo)
                    {
                        this.i = i;
                        somar();


                        fechamentoController.Id = dataGridView2.Rows[i].Cells[0].Value.ToString();
                        fechamentoController.PesoBruto = pesoBrutoResultado.ToString("###,###.#0");
                        fechamentoController.PesoLiquido = pesoLiquidoResultado.ToString("###,###.#0");
                        fechamentoController.Bobinas = qtBobinasResultado.ToString("###,###");

                        fechamentoService.update(fechamentoController);
                        if(fechamentoController.Msg != null)
                        {
                            MessageBox.Show(fechamentoController.Msg);
                        }

                        break;
                    }
                    if (i == dataGridView2.Rows.Count - 1)
                    {
                        fechamentoController.Codigo = movimentacaoController.Codigo;
                        fechamentoController.Descricao = movimentacaoController.Descricao;
                        fechamentoController.PesoBruto = movimentacaoController.PesoBruto;
                        fechamentoController.PesoLiquido = movimentacaoController.PesoLiquido;
                        fechamentoController.Bobinas = movimentacaoController.Bobinas;
                        fechamentoService.insert(fechamentoController);
                        if (fechamentoController.Msg != null)
                        {
                            MessageBox.Show(fechamentoController.Msg);
                        }

                        break;
                    }
                }

            }


            loadGridView1(this.movimentacaoController);
            fechamentoService.table(fechamentoController);
            LoadGridSelectCodigo(fechamentoController);
            txtNumeroPA.Text = string.Empty;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            loadPA();

        }

    }
}
