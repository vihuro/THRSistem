using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.Service.manutencao;

namespace SistemaTHR.Apllication.Manutencao
{
    public partial class frmEstoquePesquisa : Form
    {
        private frmRequisicoesPecas requisicao;
        private frmManutencao manutencao;

        private EstoquePecasController controller;
        private EstoquePecasService service;
        private frmEstoquePecas frmEstoquePecas;

        public frmEstoquePesquisa(frmRequisicoesPecas requisicao)
        {
            this.requisicao = requisicao;
            IniviarService();
            InitializeComponent();
            cboCampo.Text = "Descrição";
        }

        private EstoquePecasService IniviarService()
        {
            return service = new EstoquePecasService();
        }

        public frmEstoquePesquisa(frmManutencao manutencao)
        {
            this.manutencao = manutencao;
            IniviarService();
            InitializeComponent();
            cboCampo.Text = "Descrição";
        }

        public frmEstoquePesquisa(frmEstoquePecas frmEstoquePecas)
        {
            this.frmEstoquePecas = frmEstoquePecas;
            IniviarService();
            InitializeComponent();
            cboCampo.Text = "Descrição";

        }

        private void frmEstoquePesquisa_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void loadGridView()
        {
            controller = new EstoquePecasController();

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
            if(Application.OpenForms.OfType<frmRequisicoesPecas>().Count() > 0)
            {
                requisicao.txtCodigoPeca.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                requisicao.txtDescricao.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                requisicao.txtUnidade.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                this.Close();
            }
            else if(Application.OpenForms.OfType<frmEstoquePecas>().Count() > 0)
            {
                frmEstoquePecas.loadGridView1(controller);
                this.Close();
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            for(int i = 0; i< dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if(cboCampo.Text == "Código")
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[Codigo] like '%{0}%'", txtFiltro.Text);
            }
            else if(cboCampo.Text == "Descrição")
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[Descricao] like '%{0}%'", txtFiltro.Text);
            }
        }
    }
}
