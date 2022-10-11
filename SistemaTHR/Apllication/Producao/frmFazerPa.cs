using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTHR.Apllication.Producao.Impressao;
using SistemaTHR.Controller.Producao;
using SistemaTHR.Service.Producao;

namespace SistemaTHR.Apllication.Producao
{
    public partial class frmFazerPa : Form
    {
        private OrdenProducaoService service = new OrdenProducaoService();
        private OrdensProducaoController controller;

        public frmFazerPa()
        {
            InitializeComponent();
        }

        private void txtLote_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            frmImprimirPA pa = new frmImprimirPA(controller.Dt);

            pa.ShowDialog();
        }



        private void txtLote_PreviewKeyDown(object sender, PreviewKeyDownEventArgs e)
        {
            if (e.KeyData == Keys.Tab || e.KeyCode == Keys.Enter)
            {
                controller = new OrdensProducaoController();
                controller.NumeroOp = txtLote.Text;

                service.VerificarLote(controller);
                if (controller.Msg != null)
                {
                    MessageBox.Show(controller.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    ClearAll();

                }
                else
                {
                    txtCodigo.Text = controller.CodigoMaterial;
                    txtDescricao.Text = controller.DescricaoMaterial;

                }

            }
        }

        private void ClearAll()
        {
            txtDescricao.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            txtPesoBruto.Text = string.Empty;
            txtPesoLiquido.Text = string.Empty;
            txtQuantidadeRolos.Text = string.Empty;
        }
    }
}
