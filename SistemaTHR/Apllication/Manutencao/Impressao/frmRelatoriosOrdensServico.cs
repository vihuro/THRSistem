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
    public partial class frmRelatoriosOrdensServico : Form
    {
        private DataTable dt;
        public frmRelatoriosOrdensServico(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void frmRelatoriosOrdensServico_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("bd_OrdensServico", dt.DefaultView));
            this.reportViewer1.LocalReport.SetParameters(new Microsoft.Reporting.WinForms.ReportParameter("dataHoraImpressao", DateTime.Now.ToString("dd/MM/yyyy HH:mm")));
            this.reportViewer1.RefreshReport();
        }
    }
}
