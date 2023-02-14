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
using SistemaTHR.Controller.manutencao;
using SistemaTHR.Service.Exepction;
using SistemaTHR.Service.manutencao;

namespace SistemaTHR.Apllication.Manutencao
{
    public partial class frmFiltroRequisicoesPeca : Form
    {
        private frmRequisicoesPecas requisicoes;
        private solicitacaoPecaoController controller;
        private aseController aondeSeraExecutadoController;
        private aseService aondeSeraExecutadoService;
        private EstoquePecasService estoqueService;

        private loginController loginController;
        private modulosController modulosController;

        private string Pesquisa = "";

        public frmFiltroRequisicoesPeca(frmRequisicoesPecas requisicoes, solicitacaoPecaoController controller, loginController loginController,modulosController modulosController)
        {
            this.requisicoes = requisicoes;
            this.controller = controller;
            this.loginController = loginController;
            this.modulosController = modulosController;
            InitializeComponent();
            cboAondeSeraUsado.Text = "Aguardando Autorização";
            aondeSeraExecutadoService = new aseService();
            estoqueService = new EstoquePecasService(loginController,modulosController);
        }

        private void frmFiltroRequisicoesPeca_Load(object sender, EventArgs e)
        {
            foreach(var item in aondeSeraExecutadoService.List())
            {
                cboAondeSeraUsado.Items.Add(item);
            }
        }


        public void Procurar()
        {
            var list = CriarLista();
            Pesquisa = "";
            for(int i = 0; i < list.Count; i++)
            {
                if (list[i].Checked)
                {
                    if(Pesquisa != string.Empty)
                    {
                        Pesquisa += string.Format(" OR [StatusSolicitacao] = '{0}'", list[i].Text);
                        if(cboAondeSeraUsado.Text != string.Empty)
                        {
                            Pesquisa += string.Format(" AND [ASU] = '{0}'",cboAondeSeraUsado.Text);
                        }
                        if(txtCodigo.Text != string.Empty)
                        {
                            Pesquisa += string.Format(" AND [CodigoPeca] = '{0}'", txtCodigo.Text);
                        }

                    }
                    else
                    {
                        Pesquisa += string.Format("[StatusSolicitacao] = '{0}'", list[i].Text);
                        if (cboAondeSeraUsado.Text != string.Empty)
                        {
                            Pesquisa += string.Format(" AND [ASU] = '{0}'", cboAondeSeraUsado.Text);
                        }
                        if (txtCodigo.Text != string.Empty)
                        {
                            Pesquisa += string.Format(" AND [CodigoPeca] = '{0}'", txtCodigo.Text);
                        }
                    }
                }
            }
            if(Pesquisa == string.Empty)
            {
                if(cboAondeSeraUsado.Text != string.Empty)
                {
                    Pesquisa = string.Format("[ASU] = '{0}'", cboAondeSeraUsado.Text);
                }
                if(txtCodigo.Text != string.Empty)
                {
                    if(Pesquisa != string.Empty)
                    {
                        Pesquisa += " AND ";
                    }
                    Pesquisa += string.Format("[CodigoPeca] = '{0}'", txtCodigo.Text);

                }
            }
        }

        public List<CheckBox> CriarLista()
        {
            var list = new List<CheckBox>();
            for(int i = 0; i < groupBox2.Controls.Count; i++)
            {
                list.Add((CheckBox)groupBox2.Controls[i]);
            }
            return list;
        }


        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            /*if(cboAondeSeraUsado.Text == "Aguardando Autorização")
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[StatusSolicitacao] = '{0}'", "AGUARDANDO/AUT. PEÇAS");
            }
            else if(cboAondeSeraUsado.Text == "Autorizado")
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[StatusSolicitacao] = '{0}'", "AUTORIZADO");
            }
            else
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[StatusSolicitacao] = '{0}'", "");
            }
            requisicoes.LoadGridViewFilter(controller);
            this.Close();*/

            requisicoes.Pesquisar = this.Pesquisa;
            requisicoes.loadGridView();
            this.Close();

            Console.WriteLine(Pesquisa);
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnPesquisar_Click(object sender, EventArgs e)
        {
            var filtro = new frmEstoquePesquisa(this);
            filtro.ShowDialog();
        }

        private void chbAguardandoAutorizacao_CheckedChanged(object sender, EventArgs e)
        {
            Procurar();
        }

        private void chbAutorizado_CheckedChanged(object sender, EventArgs e)
        {
            Procurar();

        }

        private void txtCodigo_TextChanged(object sender, EventArgs e)
        {
            if(txtCodigo.Text.Length > 0)
            {
                Procurar();
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if(txtCodigo.Text.Length > 0)
            {
                PesquisarCodigo();
                Procurar();
            }
        }

        private void PesquisarCodigo()
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

        private void cboAondeSeraUsado_SelectedValueChanged(object sender, EventArgs e)
        {
            Procurar();
        }
    }
}
