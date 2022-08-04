using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Producao
{
    public partial class frmPainelQuarentena : Form
    {
        Modelo.Producao.fichaController controller;

        DateTime dataLanc;
        DateTime dataAgora;

        TimeSpan diaResult;
        TimeSpan horaResult;
        TimeSpan minResult;
        TimeSpan segResult;



        int dias;

        String diaResultString;
        String horaResultString;
        String minResultString;
        String segResultString;


        int num;
        public frmPainelQuarentena()
        {
            InitializeComponent();
        }

        private void frmPainelQuarentena_Load(object sender, EventArgs e)
        {
            loadGrid();
        }

        private void loadGrid()
        {
            txtData.Text = DateTime.Now.ToString("dd/MM/yyyy   HH:mm:ss");
            controller = new Modelo.Producao.fichaController();
            controller.painel();
            dataGridView1.DataSource = controller.dt;
            if (controller.msg != null)
            {
                MessageBox.Show(controller.msg);
            }
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataLanc = Convert.ToDateTime(dataGridView1.Rows[i].Cells[5].Value.ToString());

                dataAgora = DateTime.Now;

                diaResult = dataLanc - dataAgora;


                diaResultString = Convert.ToString(diaResult.ToString("dd"));
                horaResultString = Convert.ToString(diaResult.ToString("hh"));
                minResultString = Convert.ToString(diaResult.ToString("mm"));
                segResultString = Convert.ToString(diaResult.ToString("ss"));

                //dias = Convert.ToDateTime(diaResultString.ToString())


                dataGridView1.Rows[i].Cells[8].Value = diaResultString + " dias " + horaResultString + " horas " + minResultString + " minutos " + segResultString + " segundos";

            }
            timer1.Start();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;

            if(num == 5)
            {
                txtData.Text = DateTime.Now.ToString("dd/MM/yyyy   HH:mm:ss");
                loadGrid();
                num = 0;
            }
        }
    }
}
