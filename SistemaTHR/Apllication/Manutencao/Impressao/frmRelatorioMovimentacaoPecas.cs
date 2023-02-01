using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Manutencao.Impressao
{
    public partial class frmRelatorioMovimentacaoPecas : Form
    {
        private DataTable dt;
        private string nomeUsuario;
        public frmRelatorioMovimentacaoPecas(DataTable dt, string nomeUsuario)
        {
            InitializeComponent();
            this.dt = dt;
            this.nomeUsuario = nomeUsuario;
        }

        private void frmRelatorioMovimentacaoPecas_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("movimentacaoPecas", dt.DefaultView));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("nomeUsuario", nomeUsuario));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataHoraImpressao", DateTime.Now.ToString("dd/MM/yyyy HH:mm")));
            this.reportViewer1.RefreshReport();
        }
    }
}
