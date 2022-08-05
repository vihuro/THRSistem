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
        TimeSpan diaResultAgora;
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
            timer1.Start();
            contagemTempo();
            
        }



        private void contagemTempo()
        {
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                //MessageBox.Show(dataGridView1.Rows[i].Cells[4].Value.ToString());

                dataLanc = Convert.ToDateTime(dataGridView1.Rows[i].Cells[4].Value.ToString());

                dataAgora = DateTime.Now;

                diaResult = dataLanc - dataAgora;


                diaResultString = Convert.ToString(diaResult.ToString("dd"));
                horaResultString = Convert.ToString(diaResult.ToString("hh"));
                minResultString = Convert.ToString(diaResult.ToString("mm"));
                segResultString = Convert.ToString(diaResult.ToString("ss"));

                //dias = Convert.ToDateTime(diaResultString.ToString())

                //MessageBox.Show(dataGridView1.Rows[i].Cells[9].Value.ToString());
                dataGridView1.Rows[i].Cells[10].Value = diaResultString + " D " + horaResultString + " HRS " + minResultString + " MIN " + segResultString + " SEG";
                
                int dias = 365;

                for(int i2 = 2; i2 < dias; i2++)
                {

                    if(diaResultString == "0" + i2)
                    {
                        if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "Aguardando")
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                            dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        }
                        else if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "Analisado")
                        {
                            dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                            dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                        }
                    }
                    else if (diaResultString == "00" && dataGridView1.Rows[i].Cells[11].Value.ToString() == "Aguardando" ||
                             diaResultString == "01" && dataGridView1.Rows[i].Cells[11].Value.ToString() == "Aguardando")
                    {
                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    }
                    else if (diaResultString == "00" && dataGridView1.Rows[i].Cells[11].Value.ToString() == "Analisado" ||
                             diaResultString == "01" && dataGridView1.Rows[i].Cells[11].Value.ToString() == "Analisado")
                    {

                        dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                        dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    }

                }

            }
            dataGridView1.ClearSelection();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;

            if(num < 59)
            {
                txtData.Text = DateTime.Now.ToString("dd/MM/yyyy   HH:mm:ss");
                contagemTempo();
            }  
            
            if(num == 60)
            {
                loadGrid();
                //MessageBox.Show("Atualizado");
                num = 0;
            }
        }


        int i;
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {


        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
