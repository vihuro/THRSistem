using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Printing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication
{
    public partial class frmSelectImp : Form
    {

        Controller.transferencia.movimentacaoController movimentacaoController;
        Controller.transferencia.fechamentoController fechamentoController;


        public frmSelectImp(Controller.transferencia.movimentacaoController movimentacaoController, Controller.transferencia.fechamentoController fechamentoController)
        {
            InitializeComponent();
            this.movimentacaoController = movimentacaoController;
            this.fechamentoController = fechamentoController;

        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if (cboSelect.Text == "Fechamento")
            {

                using (var relatorio = new LocalReport())
                {

                    relatorio.ReportPath = "C:\\Program Files (x86)\\Default Company Name\\Sistema THR\\Pedido de Transferencia N.rdlc";
                    //relatorio.ReportPath = "Apllication\\Transferencia\\Impressao\\Pedido de Transferencia.rdlc";
                    relatorio.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", fechamentoController.Dt));

                    exportar(relatorio);
                    imprimir(relatorio);
                }

            }
            else if (cboSelect.Text == "Movimentação")
            {
                using (var relatorio = new LocalReport())
                {
                    relatorio.ReportPath = "C:\\Program Files (x86)\\Default Company Name\\Sistema THR\\Movimentação.rdlc";
                    //relatorio.ReportPath = "Apllication\\Transferencia\\Impressao\\Movimentação.rdlc";
                    relatorio.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("DataSet1", movimentacaoController.Dt));

                    exportar(relatorio);
                    imprimir(relatorio);
                }
            }

            this.Close();
        }

        private void exportar(LocalReport relatorio)
        {
            Warning[] warnings;
            limpar();

            relatorio.Render("image", criarDevice(relatorio), CreateStreamCallback, out warnings);

        }

        private void imprimir(LocalReport relatorio)
        {
            using (var pd = new PrintDocument())
            {   
                if(cboSelect.Text == "Fechamento")
                {
                    pd.PrinterSettings.Copies = 2;
                    pd.DefaultPageSettings.Landscape = false;
                }
                else if(cboSelect.Text == "Movimentação")
                {
                    pd.PrinterSettings.Copies = 1;
                    pd.DefaultPageSettings.Landscape = true;
                }
                               
                var pageSettings = new PageSettings();
                var pageSettingsRelatorio = relatorio.GetDefaultPageSettings();
                pageSettings.PaperSize = pageSettingsRelatorio.PaperSize;
                pageSettings.Margins = pageSettingsRelatorio.Margins;

                pd.PrintPage += Pd_PrintPage;
                this.stremAtual = 0;
                pd.Print();

            }
        }

        private int stremAtual;

        private void Pd_PrintPage(object sender, PrintPageEventArgs e)
        {
            var stream = strem[this.stremAtual];
            stream.Seek(0, SeekOrigin.Begin);

            using (var metaData = new Metafile(stream))
            {
                e.Graphics.DrawImage(metaData, e.PageBounds);
            }

            stremAtual++;
            e.HasMorePages = stremAtual < strem.Count;
        }

        private List<System.IO.Stream> strem = new List<System.IO.Stream>();
        public System.IO.Stream CreateStreamCallback(string name, string extension, Encoding encoding, string mimeType, bool willSeek)
        {
            var stream = new MemoryStream();
            this.strem.Add(stream);
            return stream;
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
                    <MarginRight>{4}in</MarginRight>
                    <MarginBottom>{5}in</MarginBottom>
                </DeviceInfo>",

        pageSetting.PaperSize.Width == 8.26772m, pageSetting.PaperSize.Height == 11.69291m, pageSetting.Margins.Top == 0.787402m, pageSetting.Margins.Left 
        == 0.787402m, pageSetting.Margins.Right == 0.787402m, pageSetting.Margins.Bottom == 0.787402m);

        }

        private void limpar()
        {
            foreach (var stream in this.strem)
            {
                stream.Dispose();
            }
            this.strem.Clear();
        } 

        private void btnVizualizar_Click(object sender, EventArgs e)
        {
            if(cboSelect.Text == "Fechamento")
            {
                frmImp frmImp = new frmImp(fechamentoController.Dt);
                 frmImp.ShowDialog();
            }
            else if (cboSelect.Text == "Movimentação")
            {

                frmImpMovimento frmImp = new frmImpMovimento(movimentacaoController.Dt);
                frmImp.ShowDialog();
            }
        }
    }
}
