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
        private String numeroTransferencia;
        private String usuario;
        private String idFechamento;
        private String numeroPa;
        private String codigo;
        private String descricao;
        private String pesoBruto;
        private String pesoLiquido;
        private String qtBobinas;
        private DataTable dt;
        Modelo.transferenciaController transferenciaController = new Modelo.transferenciaController();
        Modelo.loadPaController loadPaController = new Modelo.loadPaController();

        public frmEditarTransferencia(String numeroTransferencia, string usuario)
        {
            InitializeComponent();
            this.numeroTransferencia = numeroTransferencia;
            this.usuario = usuario;
        }

        private void splitContainer2_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
 

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

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

        private void btnRemover_Click(object sender, EventArgs e)
        {

            if (dataGridView1.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {


                    if (dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[1].Value.ToString() == dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].Value.ToString())
                    {
                        this.i = i;

                        Subtrair();


                        String idMovimento = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();

                        Modelo.transferenciaController transferencia = new Modelo.transferenciaController();
                        transferencia.deletMovi(idMovimento);


                        if (pesoBrutoTotal == 0)
                        {
                            idFechamento = dataGridView2.Rows[0].Cells[0].Value.ToString();
                            transferencia.idFechamento = idFechamento;
                            transferencia.deleteFech();
                            dataGridView2.Rows.Remove(dataGridView2.Rows[i]);


                        }
                        else
                        {
                            dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[3].Value = pesoBrutoTotal.ToString("###,###.#0");
                            dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[4].Value = pesoLiquidoTotal.ToString("###,###.#0");
                            dataGridView2.Rows[dataGridView2.Rows[i].Index].Cells[5].Value = qtBobinasTotal.ToString("###,###.#0");

                            transferencia.pesoBruto = pesoBrutoTotal.ToString("###,###.#0");
                            transferencia.pesoLiquido = pesoLiquidoTotal.ToString("###,###.#0");
                            transferencia.bobinas = qtBobinasTotal.ToString("###,###.#0");
                            transferencia.numeroFech = dataGridView2.Rows[0].Cells[0].Value.ToString();
                            transferencia.updateFech();

                        }

                        break;
                    }


                }
                dataGridView1.Rows.Remove(dataGridView1.CurrentRow);
            }

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void somar()
        {
             pesoBrutoFech = Convert.ToDecimal(dataGridView2.Rows[i].Cells[3].Value.ToString());
             pesoLiquidoFech = Convert.ToDecimal(dataGridView2.Rows[i].Cells[4].Value.ToString());
             qtBobinasFech = Convert.ToDecimal(dataGridView2.Rows[i].Cells[5].Value.ToString());

             pesoBrutoResultado = pesoBrutoFech + Convert.ToDecimal(this.pesoBruto.ToString());
             pesoLiquidoResultado = pesoLiquidoFech + Convert.ToDecimal(this.pesoLiquido.ToString());
             qtBobinasResultado = qtBobinasFech + Convert.ToDecimal(this.qtBobinas.ToString());


        }


        private void loadPA()
        {
            loadPaController = new Modelo.loadPaController();

            if(rdbProdução.Checked == true)
            {
                loadPaController.selectPA(txtNumeroPA.Text);
            }
            if(rdbExpedicao.Checked == true)
            {
                loadPaController.selectExp(txtNumeroPA.Text);
            }


            if (loadPaController.codigo != null)
            {
                this.numeroPa = loadPaController.numeroPa;
                this.codigo = loadPaController.codigo;
                this.descricao = loadPaController.descricao;
                this.pesoBruto = loadPaController.pesoBruto.ToString("###,###.#0");
                this.pesoLiquido = loadPaController.pesoLiquido.ToString("###,###.#0");
                this.qtBobinas = loadPaController.qtBobinas.ToString();
            }

        }


        private void carregar()
        {
            if (dataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (dataGridView2.Rows[i].Cells[1].Value.ToString() == codigo)
                    {
                        this.i = i;
                        somar();


                        dataGridView2.Rows[i].Cells[3].Value = pesoBrutoResultado.ToString("###,###.#0");
                        dataGridView2.Rows[i].Cells[4].Value = pesoLiquidoResultado.ToString("###,###.#0");
                        dataGridView2.Rows[i].Cells[5].Value = qtBobinasResultado.ToString("###,###");

                        transferenciaController.numeroFech = dataGridView2.Rows[i].Cells[0].Value.ToString();
                        transferenciaController.pesoBruto = pesoBrutoResultado.ToString("###,###.#0");
                        transferenciaController.pesoLiquido = pesoLiquidoResultado.ToString("###,###.#0");
                        transferenciaController.bobinas = qtBobinasResultado.ToString("###,###");
                        transferenciaController.updateFech();


                        break;
                    }
                    if (i == dataGridView2.Rows.Count - 1)
                    {
                        transferenciaController.codigo = this.codigo;
                        transferenciaController.descricao = this.descricao;
                        transferenciaController.pesoBruto = this.pesoBruto;
                        transferenciaController.pesoLiquido = this.pesoLiquido;
                        transferenciaController.bobinas = this.qtBobinas;
                        transferenciaController.idTransferencia = this.numeroTransferencia;

                        transferenciaController.InsertFechamento();

                    }
                }

            }
            else
            {
                transferenciaController.codigo = this.codigo;
                transferenciaController.descricao = this.descricao;
                transferenciaController.pesoBruto = this.pesoBruto;
                transferenciaController.pesoLiquido = this.pesoLiquido;
                transferenciaController.bobinas = this.qtBobinas;
                transferenciaController.idTransferencia = this.numeroTransferencia;

                transferenciaController.InsertFechamento();

            }

            transferenciaController.insertMov(numeroPa, codigo, descricao, pesoBruto, pesoLiquido, qtBobinas, numeroTransferencia, usuario);

            loadGridView1();

            LoadGridSelectCodigo(codigo);
            txtNumeroPA.Text = string.Empty;
        }

        private void btnConectar_Click(object sender, EventArgs e)
        {
            loadPA();

            if(loadPaController.codigo != null)
            {
                carregar();
            }
            else
            {
                MessageBox.Show("P.A não encontrada. Tente alterar o local de estocagem!","SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }

        }



        private void loadGridView1()
        {
            Modelo.transferenciaController transferenciaController = new Modelo.transferenciaController();
            transferenciaController.selectMovi(numeroTransferencia);
            this.dt = transferenciaController.dt;

            dataGridView1.DataSource = dt;
            
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

        private void loadGridView2()
        {
            Modelo.transferenciaController controller = new Modelo.transferenciaController();
            controller.selectFech(numeroTransferencia);
            this.dt = controller.dt;

            dataGridView2.DataSource = dt;

            for (var i = 0; i < dataGridView2.Rows.Count; i++)
            {

                if (i == dataGridView2.Rows.Count -1)
                {
                    dataGridView2.CurrentCell = dataGridView2.Rows[i].Cells[1];

                    break;
                }

            }
            dataGridView2.ClearSelection();
        }

        private void LoadGridSelectCodigo(String codigo)
        {
            Modelo.transferenciaController controller = new Modelo.transferenciaController();
            controller.selectFech(numeroTransferencia);
            this.dt = controller.dt;

            dataGridView2.DataSource = dt;

            for (var i = 0; i < dataGridView2.Rows.Count; i++)
            {

                if (dataGridView2.Rows[i].Cells[1].Value.ToString() == codigo)
                {
                    dataGridView2.CurrentCell = dataGridView2.Rows[i].Cells[1];

                    break;
                }

            }

        }


        private void frmEditarTransferencia_Load(object sender, EventArgs e)
        {
            loadGridView1();
            loadGridView2();
        }

        private void txtNumeroPA_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                loadPA();

                if (loadPaController.codigo != null)
                {
                    carregar();
                }
                else
                {
                    MessageBox.Show("P.A não encontrada. Tente alterar o local de estocagem!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
