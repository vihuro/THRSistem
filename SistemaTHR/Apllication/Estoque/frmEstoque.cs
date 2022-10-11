using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTHR.Controller.Login;
using SistemaTHR.Controller;
using SistemaTHR.Service.estoque;
using SistemaTHR.Controller.estoque;

namespace SistemaTHR.Apllication.Estoque
{
    public partial class frmEstoque : Form
    {
        private loginController loginController;
        private modulosController modulosController;
        private EstoqueController controller;
        private EstoqueService service;
        private MovimentacaoController movimentacaoController;
        private MovimentacaoSerivce movimentacaoService;
        private GrupoController grupoController;
        private GrupoService grupoService = new GrupoService();


        public frmEstoque(loginController loginController, modulosController modulosController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.modulosController = modulosController;
            IniciarEstoqueService(loginController);
            IniciarMovimentacaoService(loginController);
        }

        private MovimentacaoSerivce IniciarMovimentacaoService(loginController loginController)
        {
            return this.movimentacaoService = new MovimentacaoSerivce(loginController);
        }

        private EstoqueService IniciarEstoqueService(loginController loginController)
        {
            
            return this.service = new EstoqueService(loginController);
        }

        private void frmEstoque_Load(object sender, EventArgs e)
        {
            loadGridView();
            clearAll();
            loadComboBoxGrupo();
        }

        public void loadComboBoxGrupo()
        {
            this.Cursor = Cursors.WaitCursor;

            grupoController = new GrupoController();
            grupoService.List(grupoController);
            if(grupoController.Msg != null)
            {
                MessageBox.Show(grupoController.Msg);
            }
            else
            {
                foreach(var item in grupoController.Lista)
                {
                    cboGrupo.Items.Add(item);
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void loadGridView()
        {
            this.Cursor = Cursors.WaitCursor;

            controller = new EstoqueController();
            service.selectTable(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                dataGridView1.DataSource = controller.Dt;
                for(var i = 0; i< dataGridView1.Rows.Count; i++)
                {
                    if(i == dataGridView1.Rows.Count - 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                        break;
                    }
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            loadGridView();
            clearAll();

            this.Cursor = Cursors.Default;

        }

        private void clearAll()
        {
            this.Cursor = Cursors.WaitCursor;

            dataGridView1.ClearSelection();


            btnSalvar.Enabled = true;
            btnAlterar.Enabled = false;
            btnInserir.Enabled = false;

            txtCodigoReferencia.Text = string.Empty;
            txtCodigo.Text = string.Empty; ;
            txtDescricao.Text = string.Empty;
            txtEstoqueMinimo.Text = string.Empty;
            txtEstoqueMaximo.Text = string.Empty;
            txtEstoqueSegueranca.Text = string.Empty;
            cboUnidade.Text = string.Empty;
            txtCodigo.ReadOnly = false;

            this.Cursor = Cursors.Default;

        }

        private void btnCadastroGrupo_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmGrupo grupo = new frmGrupo(this ,loginController, modulosController);
            grupo.Show();

            this.Cursor = Cursors.Default;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (dataGridView1.SelectedRows.Count > 0)
            {
                btnSalvar.Enabled = false;
                btnAlterar.Enabled = true;
                txtCodigo.ReadOnly = true;
                btnInserir.Enabled = true;

                txtCodigoReferencia.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                txtCodigo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                txtDescricao.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();
                cboUnidade.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();

                txtFornecedor.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                txtEstoqueMinimo.Text = dataGridView1.SelectedRows[0].Cells[10].Value.ToString();
                txtEstoqueMaximo.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();

                BuscarMovimentacao(dataGridView1.SelectedRows[0].Cells[1].Value.ToString());

                if(!cboGrupo.Items.Contains(dataGridView1.SelectedRows[0].Cells[4].Value.ToString()))
                {
                    cboGrupo.Text = "";
                }
                else
                {
                    cboGrupo.Text = dataGridView1.SelectedRows[0].Cells[4].Value.ToString();
                }

            }


            this.Cursor = Cursors.Default;
        }

        public void BuscarMovimentacao(string codigo)
        {
            movimentacaoController = new MovimentacaoController();
            movimentacaoService.SelectTable(movimentacaoController);
            if(movimentacaoController.Msg != null)
            {
                MessageBox.Show(movimentacaoController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                movimentacaoController.Dt.DefaultView.RowFilter = string.Format("[CodProd] like '%{0}%'", codigo);
                dataGridView2.DataSource = movimentacaoController.Dt;

                for(int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    double quantidadeMovimentada =  Convert.ToDouble(dataGridView2.Rows[i].Cells[6].Value.ToString());
                    
                    string quantidadeFormatada = quantidadeMovimentada.ToString("###,###.##");

                    if(quantidadeMovimentada == 0)
                    {
                        quantidadeFormatada = "0,00";
                    }

                    dataGridView2.Rows[i].Cells[10].Value = quantidadeFormatada;


                }

                dataGridView2.ClearSelection();
            }
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            double estoqueMinimo = Convert.ToDouble(txtEstoqueMinimo.Text);
            double estoqueMaximo = Convert.ToDouble(txtEstoqueMaximo.Text);
            
            if(estoqueMinimo > estoqueMaximo)
            {
                MessageBox.Show("Estoque mínimo maior que o estoque máximo!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtCodigo.Text != string.Empty && txtCodigoReferencia.Text != string.Empty && txtDescricao.Text != string.Empty &&
                    cboGrupo.Text != string.Empty && txtFornecedor.Text != string.Empty && txtEstoqueMinimo.Text != string.Empty
                    && txtEstoqueMinimo.Text != string.Empty && txtEstoqueSegueranca.Text != string.Empty)
                {
                    controller = new EstoqueController();
                    controller.CodRef = txtCodigoReferencia.Text;
                    controller.Codigo = txtCodigo.Text;
                    service.FilterWithCodigo(controller);
                    if(controller.Msg != null)
                    {
                        MessageBox.Show(controller.Msg);
                    }
                    else
                    {
                        if (controller.Dt.Rows.Count > 0)
                        {
                            MessageBox.Show("Código já cadastrado!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        }
                        else
                        {
                            controller.Descricao = txtDescricao.Text;
                            controller.Unidade = cboUnidade.Text;
                            controller.Grupo = cboGrupo.Text;
                            controller.Fornecedor = txtFornecedor.Text;
                            controller.EstoqueMinimo = txtEstoqueMinimo.Text;
                            controller.EstoqueMaximo = txtEstoqueMaximo.Text;
                            controller.EstoqueSeguranca = txtEstoqueSegueranca.Text;
                            service.Insert(controller);
                            if (controller.Msg != null)
                            {
                                MessageBox.Show(controller.Msg);
                            }
                            else
                            {
                                MessageBox.Show("Cadastro realizado com sucesso!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                loadGridView();
                                clearAll();
                            }
                        }

                    }

                }
                else
                {
                    MessageBox.Show("Campo(s) obrigatório(s) vazio(s)!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }

            this.Cursor = Cursors.Default;
        }

        public void LoadWithFilter(EstoqueController controller)
        {
            this.Cursor = Cursors.WaitCursor;
            dataGridView1.DataSource = controller.Dt;
            for(var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if(i == dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                    break;
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmFilterEstoque estoque = new frmFilterEstoque(this,service,loginController);
            estoque.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void btnSomar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            controller = new EstoqueController();
            MovimentacaoSerivce movService = new MovimentacaoSerivce(loginController);
            MovimentacaoController movController = new MovimentacaoController();
            movService.SelectTable(movController);
            if(movController.Msg != null)
            {
                MessageBox.Show(movController.Msg);
            }
            else
            {
                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    var soma = service.Count(movController, dataGridView1.Rows[i].Cells[1].Value.ToString());
                    if (soma == 0)
                    {
                        dataGridView1.Rows[i].Cells[9].Value = "0,00";
                    }
                    else
                    {
                        dataGridView1.Rows[i].Cells[9].Value = soma.ToString("###,###.##");
                    }
                }

            }

        
            this.Cursor = Cursors.Default;
        }

        private void txtEstoqueMinimo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEstoqueMaximo_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtEstoqueSegueranca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnAlterar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            double estoqueMinimo = Convert.ToDouble(txtEstoqueMinimo.Text);
            double estoqueMaximo = Convert.ToDouble(txtEstoqueMaximo.Text);

            if (estoqueMinimo > estoqueMaximo)
            {
                MessageBox.Show("Estoque mínimo maior que o estoque máximo!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                if (txtCodigo.Text != string.Empty && txtCodigoReferencia.Text != string.Empty && txtDescricao.Text != string.Empty &&
                    cboGrupo.Text != string.Empty && txtFornecedor.Text != string.Empty && txtEstoqueMinimo.Text != string.Empty
                    && txtEstoqueMinimo.Text != string.Empty && txtEstoqueSegueranca.Text != string.Empty)
                {

                    controller.Codigo = txtCodigo.Text;
                    controller.CodRef = txtCodigoReferencia.Text;
                    controller.Descricao = txtDescricao.Text;
                    controller.Unidade = cboUnidade.Text;
                    controller.Grupo = cboGrupo.Text;
                    controller.Fornecedor = txtFornecedor.Text;
                    controller.EstoqueMinimo = txtEstoqueMinimo.Text;
                    controller.EstoqueMaximo = txtEstoqueMaximo.Text;
                    controller.EstoqueSeguranca = txtEstoqueSegueranca.Text;

                    service.Update(controller);
                    if(controller.Msg != null)
                    {
                        MessageBox.Show(controller.Msg,"SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Cadastro alterado com sucesso!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        loadGridView();
                        clearAll();
                    }
                }
            }

            this.Cursor = Cursors.Default;
        }

        private void dataGridView2_CellStyleChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {
                    if (Convert.ToDecimal(dataGridView2.Rows[i].Cells[6].Value.ToString()) > 0)
                    {
                        dataGridView2.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                    }
                    else
                    {
                        dataGridView2.Rows[i].DefaultCellStyle.ForeColor = Color.Red;
                    }
                }
            }
        }

        private void btnInserir_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmMovimentacaoMaterial movimentacao = new frmMovimentacaoMaterial(this,loginController, dataGridView1.SelectedRows[0].Cells[9].Value.ToString());
            if(dataGridView1.SelectedRows[0].Cells[9].Value.ToString() == "")
            {
                MessageBox.Show("Antes de inserir uma movimentação, verifique a quantidade disponivel em estoque!", "SISTEMA THR",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                movimentacao.txtCodigo.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                movimentacao.txtDescricao.Text = dataGridView1.SelectedRows[0].Cells[2].Value.ToString();

                movimentacao.ShowDialog();
            }

            this.Cursor = Cursors.Default;

        }
    }
}
