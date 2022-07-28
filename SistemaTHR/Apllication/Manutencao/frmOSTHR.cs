using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication
{
    public partial class frmOSTHR : Form
    {
        DataTable dt = new DataTable();
        String numeroOS;
        
        public frmOSTHR(String numeroOS)
        {
            InitializeComponent();
            this.numeroOS = numeroOS;

        }

        private void frmOSTHR_Load(object sender, EventArgs e)
        {
            loadInfoDataGridView1();

            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", dt));

            this.reportViewer1.RefreshReport();
        }

        private void loadInfoDataGridView1()
        {
            Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.numeroOSTHR = numeroOS;
            controller.selectImpOrdemServico();
            dt = controller.dt;

        }
    }
}
