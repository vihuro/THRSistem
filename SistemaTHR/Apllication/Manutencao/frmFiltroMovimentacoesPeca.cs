using SistemaTHR.Controller.Login;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.Service.manutencao;
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
    public partial class frmFiltroMovimentacoesPeca : Form
    {

        private loginController loginController;
        private modulosController modulosController;
        private movimentacaoPecasService movimentacaoService;
        private movimentacaoPecasController controller;
        private frmMovimentacaPecas movimentacoes;
        
        public frmFiltroMovimentacoesPeca(loginController loginController, modulosController modulosController, frmMovimentacaPecas movimentacoes)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.modulosController = modulosController;
            movimentacaoService = new movimentacaoPecasService(loginController, modulosController);
            this.movimentacoes = movimentacoes;
        }

        private void frmFiltroMovimentacoesPeca_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void LoadGridView()
        {

            try
            {
                controller = new movimentacaoPecasController();
                dataGridView1.DataSource = movimentacaoService.Table();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message,"SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtBuscarPor_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtBuscarPor_TextChanged(object sender, EventArgs e)
        {
            if(cboCampo.Text == "CÓDIGO")
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[CodigoPeca] like '%{0}%'", txtBuscarPor.Text);
            }
            else if(cboCampo.Text == "DESCRIÇÃO")
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[DescricaoPeca] like '%{0}%'", txtBuscarPor.Text);
            }
            else if(cboCampo.Text == "UNIDADE")
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[Unidade] like '%{0}%'", txtBuscarPor.Text);
            }
            else if (cboCampo.Text == "STATUS")
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[status] like '%{0}%'", txtBuscarPor.Text);
            }
            else if(cboCampo.Text == "AONDE SERÁ USADO")
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[Asu] like '%{0}%'", txtBuscarPor.Text);
            }
            else
            {
                MessageBox.Show("Escolha um filtro!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            movimentacoes.LoadGridViewFilter((DataTable)dataGridView1.DataSource);
            this.Close();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
            }
        }
    }
}
