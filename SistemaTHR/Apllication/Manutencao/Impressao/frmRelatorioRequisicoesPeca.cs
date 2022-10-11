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
using SistemaTHR.Controller.Login;

namespace SistemaTHR.Apllication.Manutencao.Impressao
{
    public partial class frmRelatorioRequisicoesPeca : Form
    {
        private solicitacaoPecaoController controller;
        private solictacaoPecaService service;
        public frmRelatorioRequisicoesPeca()
        {
            IniciarService();
            InitializeComponent();

        }

        private solictacaoPecaService IniciarService()
        {
            return service = new solictacaoPecaService();
        }

        private void frmRelatorioRequisicoesPeca_Load(object sender, EventArgs e)
        {


            controller = new solicitacaoPecaoController();
            service.table(controller);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("RequisicoesPecas", controller.Dt));

            this.reportViewer1.RefreshReport();
        }


    }
}
