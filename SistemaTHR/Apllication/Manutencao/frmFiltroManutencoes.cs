using System;
using System.Windows.Forms;
using SistemaTHR.Controller.manutencao;

namespace SistemaTHR.Apllication
{
    public partial class frmFiltroManutencoes : Form
    {
        frmManutencao manutencao;



        private osThrController controller;

        public frmFiltroManutencoes(frmManutencao manutencao)
        {
            InitializeComponent();
            this.manutencao = manutencao;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private osThrController verificarCheked()
        {
            controller = new osThrController();

            if (chbEmAberto.Checked == true)
            {
                controller.EmAberto = "EM ABERTO";
            }
            if (chbManIni.Checked == true)
            {
                controller.ManutenacaoIniciada = "Manutenção/INI";
            }
            if (chbOsINC.Checked == true)
            {
                controller.OrdemINC = "OS/INC";
            }
            if (chbAutPeca.Checked == true)
            {
                controller.AguardandoPeca = "Aguardando/AUT. Peça";
            }
            if (chbManFin.Checked == true)
            {
                controller.AguardandoPeca = "Manutenção/FIN";
            }
            if (chbManInc.Checked == true)
            {
                controller.ManutencaoNC = "Manutenção/NC";
            }
            if (chbOsFinalizada.Checked == true)
            {
                controller.ManutencaoFinalizada = "OS/Finalizada";
            }


            if (chbEmAberto.Checked == false)
            {
                controller.EmAberto = "";
            }
            if (chbManIni.Checked == false)
            {
                controller.ManutenacaoIniciada = "";
            }
            if (chbOsINC.Checked == false)
            {
                controller.OrdemINC = "";
            }
            if (chbAutPeca.Checked == false)
            {
                controller.AguardandoPeca = "";
            }
            if (chbManFin.Checked == false)
            {
                controller.AguardandoPeca = "";
            }
            if (chbManInc.Checked == false)
            {
                controller.ManutencaoNC = "";
            }
            if (chbOsFinalizada.Checked == false)
            {
                controller.ManutencaoFinalizada = "";
            }


            return controller;
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if (chbEmAberto.Checked == true || chbManIni.Checked == true || chbOsINC.Checked == true ||
                chbAutPeca.Checked == true || chbManFin.Checked == true || chbManInc.Checked == true ||
                chbOsFinalizada.Checked == true)
            {

                verificarCheked();

                manutencao.loadFilter(verificarCheked());
                this.Close();



            }
            else
            {
                this.Close();
            }
        }

        private void frmFiltroManutencoes_Load(object sender, EventArgs e)
        {

        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            chbEmAberto.Checked = false;
            chbManIni.Checked = false;
            chbOsINC.Checked = false;
            chbAutPeca.Checked = false;
            chbManFin.Checked = false;
            chbManInc.Checked = false;
            chbOsFinalizada.Checked = false;
        }
    }
}
