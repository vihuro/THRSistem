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
    public partial class frmSolicitacaoPeca : Form
    {
        String usuario;
        String numeroOS;
        String numeroRequisicao;
        public String manutencaoNivel;

        public frmSolicitacaoPeca(String usuario, String numeroOS)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.numeroOS = numeroOS;
            loadDataGridView1();
        }

        private void loadDataGridView1()
        {
            Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.numeroOSTHR = numeroOS;
            controller.selectPecas();
            dataGridView1.DataSource = controller.dt;

            loadStyleGridView1();

            dataGridView1.ClearSelection();
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (i == dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[3];

                    break;
                }

            }
            dataGridView1.ClearSelection();
        }

        private void loadStyleGridView1()
        {
            dataGridView1.Columns["NRequisicao"].Visible = false;
            dataGridView1.Columns["NOS"].Visible = false;

        }
        private void frmSolicitacaoPeca_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            txtCodigo.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtUnidade.Text = string.Empty;
            txtQuantidade.Text = string.Empty;


        }

        private void clearall()
        {
            txtCodigo.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtUnidade.Text = string.Empty;
            txtQuantidade.Text = string.Empty;

            loadDataGridView1();
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            DateTime dataHora;

            dataHora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

            if (txtDescricao.Text != string.Empty && txtUnidade.Text != string.Empty && txtQuantidade.Text != string.Empty)
            {
                Modelo.OSTHRController controller = new Modelo.OSTHRController();
                controller.numeroOSTHR = numeroOS;
                controller.codigoPeca = txtCodigo.Text;
                controller.descricaoPeca = txtDescricao.Text;
                controller.QTD = txtQuantidade.Text;
                controller.unidade = txtUnidade.Text;
                controller.nomeSolicitante = usuario;
                controller.dataHoraSolicitacao = dataHora.ToString();
                controller.statusSolicitacao = "AGUARDANDO/AUT. PEÇAS";

                controller.insertRequisicaoPecas();

                clearall();
            }
            else
            {
                MessageBox.Show("Campo(s) obrigatório(s) vazio(s)!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int i = dataGrid.SelectedRows.Count;

            if (i > 0)
            {
                numeroRequisicao = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();

                loadInfoDataGrid();

            }
        }
        private void loadInfoDataGrid()
        {
            Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.numeroRequisicao = numeroRequisicao;
            controller.selectInfoRequi();
            txtCodigo.Text = controller.codigoPeca;
            txtDescricao.Text = controller.descricaoPeca;
            txtUnidade.Text = controller.unidade;
            txtQuantidade.Text = controller.QTD;
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            DateTime dataHora;

            dataHora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

            Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.numeroRequisicao = numeroRequisicao;
            controller.nomeAutorizador = usuario;
            controller.dataHoraAutorizacao = dataHora.ToString();
            controller.autorizarRequisicao();

            clearall();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clearall();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
