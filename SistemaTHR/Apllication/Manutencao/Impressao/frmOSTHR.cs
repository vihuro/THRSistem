using Microsoft.Reporting.WinForms;
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
           // Modelo.OSTHRController controller = new Modelo.OSTHRController();
           // controller.numeroOSTHR = numeroOS;
           // controller.selectImpOrdemServico();
           // dt = controller.dt;

        }

        private void exportar(LocalReport relatorio)
        {
            Warning[] warnings;
            limpar();
            relatorio.Render("image", criarDevice(relatorio), CreateStreamCallback, out warnings);
        }

        private void imprimir(LocalReport relatorio)
        {

        }

        private List<Stream> strem = new List<Stream>();
        public Stream CreateStreamCallback(string name, string extension, Encoding encoding, string mimeType, bool willSeek)
        {
            var stream = new MemoryStream();
            this.strem.Add(stream);
            return new MemoryStream();
        }

        private string criarDevice(LocalReport relatorio)
        {
            var pageSetting = relatorio.GetDefaultPageSettings();
            return string.Format(
                CultureInfo.InvariantCulture,
                @"<DeviceInfo>
                       <OutputFormat>EMF</OutputFormat>
                       <PageWidth>{0}in</PageWidth> 
                       <PageHeight>{1}in</PageHeight> 
                       <MarginTop>{2}in</MarginTop>
                       <MarginLeft>{3}in</MarginLeft>
                       <MarginRigth>{4}in</MarginRigth>
                       <MarginBottom>{5}in</MarginBottom>
                   </DeviceInfo>",
                pageSetting.PaperSize.Width / 100m, pageSetting.PaperSize.Height / 100m, pageSetting.Margins.Top / 100m, pageSetting.Margins.Left /
                pageSetting.Margins.Right / 100m, pageSetting.Margins.Bottom / 100m
                );
        }

        private void limpar()
        {
            foreach(var stream in this.strem)
            {
                stream.Dispose();
            }
            this.strem.Clear();
        }
    }
}
