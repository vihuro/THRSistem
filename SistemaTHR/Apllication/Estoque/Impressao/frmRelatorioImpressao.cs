﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Estoque.Impressao
{
    public partial class frmRelatorioImpressao : Form
    {
        private DataTable dt;
        public frmRelatorioImpressao(DataTable dt)
        {
            InitializeComponent();
            this.dt = dt;
        }

        private void frmRelatorioImpressao_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(new Microsoft.Reporting.WinForms.ReportDataSource("Estoque", dt.DefaultView));

            this.reportViewer1.RefreshReport();
        }
    }
}
