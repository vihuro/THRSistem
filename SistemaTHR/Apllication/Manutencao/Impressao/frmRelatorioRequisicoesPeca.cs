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
        private DataTable dt;
        public frmRelatorioRequisicoesPeca(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;

        }

        private solictacaoPecaService IniciarService()
        {
            return service = new solictacaoPecaService();
        }

        private void frmRelatorioRequisicoesPeca_Load(object sender, EventArgs e)
        {


            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("RequisicoesPecas", dt.DefaultView));

            this.reportViewer1.RefreshReport();
        }


    }
}
