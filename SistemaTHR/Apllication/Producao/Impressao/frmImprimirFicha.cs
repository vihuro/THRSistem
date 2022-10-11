using Microsoft.Reporting.WebForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Producao.Impressao
{
    public partial class frmImprimirFicha : Form
    {
        DataTable dt = new DataTable();
        public frmImprimirFicha(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
            imprimirFicha();

        }

        private void frmImprimirFicha_Load(object sender, EventArgs e)
        {
            imprimirFicha();
 


        }

        private void imprimirFicha()
        {

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("fichaQuarentena", dt));

            this.reportViewer1.RefreshReport();

        }


        private void reportViewer1_Load(object sender, EventArgs e)
        {
            imprimirFicha();

        }

    }
}
