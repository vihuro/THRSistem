using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTHR.Controller.Producao;

namespace SistemaTHR.Apllication.Producao.Impressao
{
    public partial class frmImprimirPA : Form
    {
        private DataTable dt;
        public frmImprimirPA(DataTable dt)
        {
            InitializeComponent();


            this.dt = dt;

            ImprimirFicha();
        }

        private void ImprimirFicha()
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));

            this.reportViewer1.RefreshReport();
        }

        private void frmImprimirPA_Load(object sender, EventArgs e)
        {
            ImprimirFicha();
        }
    }
}
