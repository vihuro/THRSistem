using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTHR.Controller.estoque;
using SistemaTHR.Controller.Login;
using SistemaTHR.Service.estoque;

namespace SistemaTHR.Apllication.Estoque
{
    public partial class frmFinalizarRequisicao : Form
    {
        private loginController loginController;
        private modulosController modulosController;
        private paController paController;
        private MpController mpController;
        private paEstoqueService paService = new paEstoqueService();
        private MpService mpService = new MpService();
        private SolicitacaoController solicitacaoController;
        private SolicitacaoService solicitacaoService;

        public frmFinalizarRequisicao(loginController loginController, modulosController modulosController)
        {
            this.loginController = loginController;
            this.modulosController = modulosController;
            InitializeComponent();
            IniciarService();
        }

        private SolicitacaoService IniciarService()
        {
            return this.solicitacaoService = new SolicitacaoService(loginController);
        }

        private void frmFinalizarRequisicao_Load(object sender, EventArgs e)
        {
            LoadGridView();
            ClearAll();
        }

        private void ClearAll()
        {
            txtDescricao.Text = string.Empty;
            txtNumero.Text = string.Empty;
            txtQuantidade.Text = string.Empty;

            txtLote.Text = string.Empty;
            dataGridView1.ClearSelection();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if(txtDescricao.Text == string.Empty || txtNumero.Text == string.Empty || txtLote.Text ==string.Empty || txtQuantidade.Text == 
                string.Empty)
            {
                MessageBox.Show("Não é possivel finalizar essa requisição!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (!rdbMp.Checked  && !rdbPA.Checked)
            {
                MessageBox.Show("Selecione o tipo de material!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (rdbMp.Checked)
                {
                    CarregarMP();
                }
                else
                {
                    CarregarPa();
                }

            }
            this.Cursor = Cursors.Default;

        }

        private void CarregarPa()
        {
            paController = new paController();
            paController.NumeroPa = txtNumero.Text;
            paController.Codigo = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            paService.VerificarCodigoPa(paController);
            if(paController.Msg != null)
            {
                MessageBox.Show(paController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if(paController.Descricao == null)
            {
                MessageBox.Show("P.A não localizada!","SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            else
            {
                FinalizarSolicitacao(paController.Codigo, paController.Descricao);
            }

        }

        public void FinalizarSolicitacao(string Codigo, string Descricao)
        {
            solicitacaoController = new SolicitacaoController();
            solicitacaoController.Data = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
            solicitacaoController.CodigoItem = Codigo;
            solicitacaoController.DescricaoItem = Descricao;
            solicitacaoController.Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            solicitacaoService.UpdateFinally(solicitacaoController, txtQuantidade.Text);
            if(solicitacaoController.Msg != null)
            {
                MessageBox.Show(solicitacaoController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Requisição finalizada com sucesso!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                LoadGridView();
                ClearAll();
            }

        }

        public void CarregarMP()
        {
            mpController = new MpController();
            mpController.NumeroMP = txtNumero.Text;
            mpController.CodigoMaterial = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
            mpController.Descricao = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
            mpService.ProcurarMp(mpController);
            if (mpController.Msg != null)
            {
                MessageBox.Show(mpController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (mpController.Exists)
            {

                FinalizarSolicitacao(mpController.CodigoMaterial, mpController.Descricao);

            }
            else
            {
                MessageBox.Show("Código não correspondente!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }


        private void LoadGridView()
        {
            this.Cursor = Cursors.WaitCursor;

            solicitacaoController = new SolicitacaoController();
            solicitacaoService.Table(solicitacaoController);
            if(solicitacaoController.Msg != null)
            {
                MessageBox.Show(solicitacaoController.Msg,"SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.DataSource = solicitacaoController.Dt;
            }

            this.Cursor = Cursors.Default;
        }



        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            LoadGridView();
            ClearAll();

            this.Cursor = Cursors.Default;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                txtDescricao.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                btnSalvar.Enabled = true;
                if(modulosController.EstoqueNivel == "1" || modulosController.EstoqueNivel == "2")
                {
                    btnExlcuir.Enabled = true;
                }
            }
        }

        private void txtQuantidade_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnExlcuir_Click(object sender, EventArgs e)
        {
            solicitacaoController = new SolicitacaoController();
            solicitacaoController.Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            solicitacaoService.Delete(solicitacaoController);
            if(solicitacaoController.Msg != null)
            {
                MessageBox.Show(solicitacaoController.Msg,"SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Solicitação excluida com sucesso!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                LoadGridView();
                ClearAll();
            }
        }
    }
}
