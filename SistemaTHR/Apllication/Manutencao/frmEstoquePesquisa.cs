using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTHR.Apllication.Estoque;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.Service.manutencao;
using SistemaTHR.Controller.Login;
using SistemaTHR.Apllication.Compras;

namespace SistemaTHR.Apllication.Manutencao
{
    public partial class frmEstoquePesquisa : Form
    {
        private frmEntradaSaidaPecas frmEntradaSaidaPecas;
        private frmRequisicoesPecas frmRequisicaoPecas;
        private frmManutencao frmManutencao;
        private frmEstoquePecas frmEstoquePecas;
        private frmRequisicaoCompra frmCompras;

        private EstoquePecasController controller;
        private EstoquePecasService service;


        private loginController loginController;
        private modulosController modulosController;


        public frmEstoquePesquisa(frmRequisicoesPecas frmRequisicaoPecas)
        {
            this.frmRequisicaoPecas = frmRequisicaoPecas;
            IniciarService();
            InitializeComponent();
            cboCampo.Text = "Descrição";
        }

        public frmEstoquePesquisa(frmRequisicaoCompra frmCompras)
        {
            this.frmCompras = frmCompras;
            IniciarService();
            InitializeComponent();
            cboCampo.Text = "Descrição";

        }

        public frmEstoquePesquisa(frmManutencao frmManutencao)
        {
            this.frmManutencao = frmManutencao;
            IniciarService();
            InitializeComponent();
            cboCampo.Text = "Descrição";
        }



        private EstoquePecasService IniciarService()
        {
            return service = new EstoquePecasService(loginController,modulosController);
        }


        public frmEstoquePesquisa(frmEstoquePecas frmEstoquePecas,loginController loginController, modulosController modulosController)
        {
            this.frmEstoquePecas = frmEstoquePecas;
            this.loginController = loginController;
            this.modulosController = modulosController;
            IniciarService();
            InitializeComponent();
            cboCampo.Text = "Descrição";

        }

        public frmEstoquePesquisa(frmEntradaSaidaPecas frmEntradaSaidaPecas, loginController loginController, modulosController modulosController)
        {
            this.frmEntradaSaidaPecas = frmEntradaSaidaPecas;
            this.loginController = loginController;
            this.modulosController = modulosController;
            IniciarService();
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
            string codigo = "";
            string descricao = "";
            string unidade = "";
            if(dataGridView1.SelectedRows.Count > 0)
            {
                codigo = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                descricao = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                unidade = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
            }

            if (frmCompras != null)
            {
                frmCompras.txtCodigo.Text = codigo;
                frmCompras.txtDescricao.Text = descricao;
                frmCompras.txtUnidade.Text = unidade;


                this.Close();
            }
            else if (frmEstoquePecas != null)
            {
                frmEstoquePecas.loadGridView1((DataTable)dataGridView1.DataSource);
                this.Close();
            }
            else if(frmManutencao != null)
            {
                frmManutencao.txtCodigo.Text = codigo;
                frmManutencao.txtDescricaoPeca.Text = descricao;
                frmManutencao.txtUnidade.Text = unidade;
                this.Close();
            }
            else if(frmRequisicaoPecas != null)
            {
                frmRequisicaoPecas.txtCodigoPeca.Text = codigo;
                frmRequisicaoPecas.txtDescricao.Text = descricao;
                frmRequisicaoPecas.txtUnidade.Text = unidade;
                this.Close();
            }

            /*if (Application.OpenForms.OfType<frmRequisicoesPecas>().Count() > 0)
            {
                frmRequisicaoPecas.txtCodigoPeca.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                frmRequisicaoPecas.txtDescricao.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                frmRequisicaoPecas.txtUnidade.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                this.Close();
            }
            else if(Application.OpenForms.OfType<frmEstoquePecas>().Count() > 0 || 
                Application.OpenForms.OfType<frmEntradaSaidaPecas>().Count() > 0)
            {
                if(frmEstoquePecas != null)
                {

                }
                else if(frmEntradaSaidaPecas != null)
                {
                    frmEntradaSaidaPecas.txtCodigo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                    frmEntradaSaidaPecas.txtDescricao.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                    frmEntradaSaidaPecas.txtUnidade.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                    this.Close();
                }

            }*/

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
