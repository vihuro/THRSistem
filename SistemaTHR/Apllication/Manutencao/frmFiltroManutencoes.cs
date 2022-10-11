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
    public partial class frmFiltroManutencoes : Form
    {
        frmManutencao manutencao;

        String emAberto;
        String manIni;
        String osINC;
        String AutPeca;
        String manFin;
        String manINC;
        String osFin;

        public frmFiltroManutencoes(frmManutencao manutencao)
        {
            InitializeComponent();
            this.manutencao = manutencao;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void verificarCheked()
        {
            if(chbEmAberto.Checked == true)
            {
                emAberto = "EM ABERTO";
            }
            if (chbManIni.Checked == true)
            {
                manIni = "Manutenção/INI";
            }
            if(chbOsINC.Checked == true)
            {
                osINC = "OS/INC";
            }
            if (chbAutPeca.Checked == true)
            {
                AutPeca = "Aguardando/AUT. Peça";
            }
            if(chbManFin.Checked == true)
            {
                manFin = "Manutenção/FIN";
            }
            if(chbManInc.Checked == true)
            {
                manINC = "Manutenção/NC";
            }
            if(chbOsFinalizada.Checked == true)
            {
                osFin = "OS/Finalizada";
            }


            if (chbEmAberto.Checked == false)
            {
                emAberto = "";
            }
            if (chbManIni.Checked == false)
            {
                manIni = "";
            }
            if (chbOsINC.Checked == false)
            {
                osINC = "";
            }
            if (chbAutPeca.Checked == false)
            {
                AutPeca = "";
            }
            if (chbManFin.Checked == false)
            {
                manFin = "";
            }
            if (chbManInc.Checked == false)
            {
                manINC = "";
            }
            if (chbOsFinalizada.Checked == false)
            {
                osFin = "";
            }


        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(chbEmAberto.Checked == true || chbManIni.Checked == true || chbOsINC.Checked == true || 
                chbAutPeca.Checked == true || chbManFin.Checked == true || chbManInc.Checked == true || 
                chbOsFinalizada.Checked == true)
            {

                verificarCheked();

                /*  Modelo.OSTHRController controller = new Modelo.OSTHRController();
                controller.emAberto = emAberto;
                controller.ManIn = manIni;
                controller.OSINC = osINC;
                controller.AguardandoPeca = AutPeca;
                controller.ManFIN = manFin;
                controller.ManNC = manINC;
                controller.osINC = manINC;
                controller.OSFIN = osFin;
                controller.filtrarstatusOS();

                if(controller.msg != null)
                {
                    MessageBox.Show(controller.msg);
                }
                manutencao.dt = controller.dt;

                manutencao.loadFilter();
                this.Close();*/


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
