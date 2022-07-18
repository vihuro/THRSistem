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
                manFin = "Manutenção/NC";
            }
            if(chbOsFinalizada.Checked == true)
            {
                osFin = "OS/Finalizada";
            }


        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            if(chbEmAberto.Checked == true || chbManIni.Checked == true || chbOsINC.Checked == true || 
                chbAutPeca.Checked == true || chbManFin.Checked == true || chbManInc.Checked == true || 
                chbOsFinalizada.Checked == true)
            {

                verificarCheked();

                Modelo.OSTHRController controller = new Modelo.OSTHRController();
                controller.emAberto = emAberto;
                controller.manIni = manIni;
                controller.osINC = osINC;
                controller.AutPeca = AutPeca;
                controller.manFin = manFin;
                controller.manINC = manINC;
                controller.osINC = osINC;
                controller.osFin = osFin;


                MessageBox.Show("Algum checked");
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
