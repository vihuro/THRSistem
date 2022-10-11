using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Produção
{
    public partial class frmFichaQuarentena : Form
    {

        public DataTable dt = new DataTable();
        String usuario;
        String id;
        private Controller.Login.loginController loginController;
        private Controller.Login.modulosController modulosController;

        public frmFichaQuarentena(Controller.Login.loginController loginController, Controller.Login.modulosController modulosController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.modulosController = modulosController;

        }

        private void txtLote_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
               /* controller = new Modelo.Producao.selectLoteController();
                controller.lote = txtLote.Text;
                controller.selectLot();
                if (controller.msg != null)
                {
                    MessageBox.Show(controller.msg);
                }
                else
                {
                    if(controller.codigo != null)
                    {
                        txtDescricao.Text = controller.descricao;
                        txtCodigo.Text = controller.codigo;
                    }
                    else
                    {
                        MessageBox.Show("Lote não encontrado!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLote.Text = string.Empty;
                        txtDescricao.Text = string.Empty;
                        txtCodigo.Text = string.Empty;
                    }
                }*/
            }
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            salvarFicha();
            imprimirFicha();
            this.Close();
        }

        

        private void salvarFicha()
        {


        }

        private void imprimirFicha()
        {

            

            Producao.Impressao.frmImprimirFicha ficha = new Producao.Impressao.frmImprimirFicha(dt);
            ficha.ShowDialog();

        }

        private void frmFichaQuarentena_Load(object sender, EventArgs e)
        {

        }

        private void txtLote_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
