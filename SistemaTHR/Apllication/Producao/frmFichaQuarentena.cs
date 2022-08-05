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
        Modelo.Producao.selectLoteController controller;
        Modelo.Producao.fichaController fichaController;
        public DataTable dt = new DataTable();
        String usuario;
        String id;

        public frmFichaQuarentena(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void txtLote_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {
                controller = new Modelo.Producao.selectLoteController();
                controller.lote = txtLote.Text;
                controller.selectLot();
                txtDescricao.Text = controller.descricao;
                txtCodigo.Text = controller.codigo;
                if(controller.msg != null)
                {
                    MessageBox.Show(controller.msg);
                }
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
            String dataHora = DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss");

            fichaController = new Modelo.Producao.fichaController();
            fichaController.lote = txtLote.Text;
            fichaController.codigo = txtCodigo.Text;
            fichaController.descricao = txtDescricao.Text;
            fichaController.dataHoraInicio = dataHora;
            fichaController.usuarioLancamento = usuario;
            fichaController.status = "Aguardando";
            fichaController.insert();
            if(fichaController.msg != null)
            {
                MessageBox.Show(fichaController.msg);
            }

        }

        private void imprimirFicha()
        {
            fichaController = new Modelo.Producao.fichaController();
            fichaController.selectId();
            this.id = fichaController.id;
            if(fichaController.msg != null)
            {
                MessageBox.Show(fichaController.msg);
            }
            else
            {
                fichaController = new Modelo.Producao.fichaController();
                fichaController.id = this.id;
                fichaController.selectFicha();
                this.dt = fichaController.dt;
                if (fichaController.msg != null)
                {
                    MessageBox.Show(fichaController.msg);
                }
            }

            Producao.Impressao.frmImprimirFicha ficha = new Producao.Impressao.frmImprimirFicha(dt);
            ficha.Show();
        }

        private void frmFichaQuarentena_Load(object sender, EventArgs e)
        {

        }
    }
}
