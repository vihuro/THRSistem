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

namespace SistemaTHR.Apllication.Manutencao
{
    public partial class frmFiltroRequisicoesPeca : Form
    {
        private frmRequisicoesPecas requisicoes;
        private solicitacaoPecaoController controller;

        public frmFiltroRequisicoesPeca(frmRequisicoesPecas requisicoes, solicitacaoPecaoController controller)
        {
            this.requisicoes = requisicoes;
            this.controller = controller;
            InitializeComponent();
            cboFiltro.Text = "Aguardando Autorização";
        }

        private void frmFiltroRequisicoesPeca_Load(object sender, EventArgs e)
        {

        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(cboFiltro.Text == "Aguardando Autorização")
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[StatusSolicitacao] = '{0}'", "AGUARDANDO/AUT. PEÇAS");
            }
            else if(cboFiltro.Text == "Autorizado")
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[StatusSolicitacao] = '{0}'", "AUTORIZADO");
            }
            else
            {
                controller.Dt.DefaultView.RowFilter = string.Format("[StatusSolicitacao] = '{0}'", "");
            }
            requisicoes.LoadGridViewFilter(controller);
            this.Close();
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
