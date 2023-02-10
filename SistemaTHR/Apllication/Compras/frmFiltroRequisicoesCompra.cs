using SistemaTHR.Apllication.Manutencao;
using SistemaTHR.Controller.Login;
using SistemaTHR.Service.Exepction;
using SistemaTHR.Service.manutencao;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Compras
{
    public partial class frmFiltroRequisicoesCompra : Form
    {
        private loginController loginController;
        private modulosController modulosController;
        private EstoquePecasService estoqueService;
        private frmRequisicaoCompra frmRequisicao;
        private string pesquisa;
        public frmFiltroRequisicoesCompra(frmRequisicaoCompra frmRequisicao,loginController loginController, modulosController modulosController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.modulosController = modulosController;
            this.frmRequisicao = frmRequisicao;
            this.estoqueService = new EstoquePecasService(loginController,modulosController) ;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {
            var filtro = new frmEstoquePesquisa(this,loginController, modulosController);
            filtro.ShowDialog();
        }

        private void frmFiltroRequisicoesCompra_Load(object sender, EventArgs e)
        {
            
        }

        private List<CheckBox> ComecarListaCheckd()
        {
            var list = new List<CheckBox>();
            for(int i =0; i< groupBox1.Controls.Count; i++)
            {
                list.Add((CheckBox)groupBox1.Controls[i]);
            }

            return list;
        }

        private void LoadFilter()
        {
            var list = ComecarListaCheckd();
            pesquisa = "";
            for(int i =0; i < list.Count; i++)
            {
                if (list[i].Checked)
                {

                    if(pesquisa != string.Empty)
                    {
                        pesquisa += string.Format( " OR [Status] = '{0}'",list[i].Text);
                        if(txtCodigo.Text != string.Empty)
                        {
                            pesquisa += string.Format(" AND [Codigo] = '{0}'", txtCodigo.Text);
                        }
                    }
                    else
                    {
                        pesquisa += string.Format("[Status] ='{0}'", list[i].Text);
                        if (txtCodigo.Text != string.Empty)
                        {
                            pesquisa += string.Format(" AND [Codigo] = '{0}'", txtCodigo.Text);
                        }
                    }
                }
            }
            if(pesquisa == string.Empty && txtCodigo.Text != string.Empty)
            {
                pesquisa += string.Format("[Codigo] = '{0}'", txtCodigo.Text);
            }

            Console.WriteLine(pesquisa);
        }

        private void chbPendente_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilter();
        }

        private void chbAutorizado_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilter();
        }

        private void chbComprado_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilter();
        }

        private void Entregue_CheckedChanged(object sender, EventArgs e)
        {
            LoadFilter();
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if(txtCodigo.Text.Length > 0)
            {
                Procurar();
            }
        }

        private void Procurar()
        {
            try
            {
                var obj = estoqueService.BuscarPorCodigo(txtCodigo.Text);
                txtCodigo.Text = obj.Codigo;
                txtDescricao.Text = obj.Descricao;
                txtUnidade.Text = obj.Unidade;
            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCodigo.Text = string.Empty;
                txtDescricao.Text = string.Empty;
                txtUnidade.Text = string.Empty;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            pesquisa = string.Empty;
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            frmRequisicao.pesquisar = pesquisa;
            frmRequisicao.loadGridView();
            this.Close();
        }
    }
}
