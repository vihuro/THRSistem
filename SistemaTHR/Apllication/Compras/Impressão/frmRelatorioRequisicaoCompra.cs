using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Compras.Impressão
{
    public partial class frmRelatorioRequisicaoCompra : Form
    {
        public frmRelatorioRequisicaoCompra()
        {
            InitializeComponent();
        }

        private void frmRelatorioRequisicaoCompra_Load(object sender, EventArgs e)
        {

            this.reportViewer1.RefreshReport();
        }
    }
}
