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
    public partial class frmGeracaoOS : Form
    {
        Modelo.situacaoOSTHRController controllerSituacao;
        Modelo.geracaoOSTHRController geracaoController;
        Modelo.Manutencao.apontamentoController apontamentoController;

        private String codigoApontamento;
        private String apontamento;
        private String geracao;

        public frmGeracaoOS()
        {
            InitializeComponent();
        }

        private void loadGridView2()
        {
            controllerSituacao = new Modelo.situacaoOSTHRController();
            controllerSituacao.selectSit();
            dataGridView2.DataSource = controllerSituacao.dt;
            if (controllerSituacao.msg != null)
            {
                MessageBox.Show(controllerSituacao.msg);
            }
            dataGridView2.ClearSelection();
        }

        private void frmGeracaoOS_Load(object sender, EventArgs e)
        {
            controllerSituacao = new Modelo.situacaoOSTHRController();
            controllerSituacao.selectSit();
            dataGridView2.DataSource = controllerSituacao.dt;
            if(controllerSituacao.msg != null)
            {
                MessageBox.Show(controllerSituacao.msg);
            }
            dataGridView2.ClearSelection();

            geracaoController = new Modelo.geracaoOSTHRController();
            geracaoController.selectGrid();
            dataGridView1.DataSource = geracaoController.dt;
            if(geracaoController.msg != null)
            {
                MessageBox.Show(geracaoController.msg);
            }
        }

        private void btnAddApont_Click(object sender, EventArgs e)
        {
            controllerSituacao = new Modelo.situacaoOSTHRController();
            controllerSituacao.situacao = txtApontamento.Text;
            controllerSituacao.insert();
            if (controllerSituacao.msg != null)
            {
                MessageBox.Show(controllerSituacao.msg);
            }
            loadGridView2();
            txtApontamento.Text = string.Empty;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemovApont_Click(object sender, EventArgs e)
        {
            codigoApontamento = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[0].Value.ToString();

            controllerSituacao = new Modelo.situacaoOSTHRController();
            controllerSituacao.codigo = this.codigoApontamento;
            controllerSituacao.delete();
            if (controllerSituacao.msg != null)
            {
                MessageBox.Show(controllerSituacao.msg);
            }
            loadGridView2();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadGridView1()
        {


            geracaoController = new Modelo.geracaoOSTHRController();
            geracaoController.selectGrid();
            dataGridView1.DataSource = geracaoController.dt;
            if (geracaoController.msg != null)
            {
                MessageBox.Show(geracaoController.msg);
            }
            clear();
        }

        private void loadGridView3()
        {
            apontamentoController.geracao = dataGridView2.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
            apontamentoController.selectApont();
            dataGridView3.DataSource = apontamentoController.dt;
            if (apontamentoController.msg != null)
            {
                MessageBox.Show(apontamentoController.msg);
            }

        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {

            apontamentoController = new Modelo.Manutencao.apontamentoController();

            apontamentoController.geracao = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
            apontamentoController.apontamento = dataGridView2.Rows[dataGridView2.SelectedRows[0].Index].Cells[1].Value.ToString();
            apontamentoController.insertApont();
            if (apontamentoController.msg != null)
            {
                MessageBox.Show(apontamentoController.msg);
            }
            loadGridView3();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int i = dataGrid.SelectedRows.Count;
            if (i > 0)
            {
                apontamentoController = new Modelo.Manutencao.apontamentoController();

                geracao = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
      
                apontamentoController.geracao = this.geracao;
                apontamentoController.apontamento = this.apontamento;
                apontamentoController.selectApont();
                dataGridView3.DataSource = apontamentoController.dt;
                if (apontamentoController.msg != null)
                {
                    MessageBox.Show(apontamentoController.msg);
                }

                btnSalvar.Enabled = false;
                btnAtivar.Enabled = true;
                btnInativar.Enabled = true;
            }
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {
            geracaoController = new Modelo.geracaoOSTHRController();
            geracaoController.status = "Ativo";
            geracaoController.geracao = this.geracao;
            geracaoController.updateGer();
            if (geracaoController.msg != null)
            {
                MessageBox.Show(geracaoController.msg);
            }
            loadGridView1();
        }

        private void clear()
        {
            
            txtApontamento.Text = string.Empty;

            while (dataGridView3.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {

                    dataGridView3.Rows.Remove(dataGridView3.Rows[i]);

                }
            }
            dataGridView1.ClearSelection();
            btnSalvar.Enabled = true;
            btnAtivar.Enabled = false;
            btnInativar.Enabled = false;
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {
            geracaoController = new Modelo.geracaoOSTHRController();
            geracaoController.status = "Inativo";
            geracaoController.geracao = this.geracao;
            geracaoController.updateGer();
            if (geracaoController.msg != null)
            {
                MessageBox.Show(geracaoController.msg);
            }
            loadGridView1();
        }
    }
}
