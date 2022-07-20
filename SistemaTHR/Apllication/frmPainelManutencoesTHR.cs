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
    public partial class frmPainelManutencoesTHR : Form
    {
        DataTable dt = new DataTable();
        int num;
        public frmPainelManutencoesTHR()
        {
            InitializeComponent();
        }

        private void frmPainelManutencoesTHR_Load(object sender, EventArgs e)
        {
            loadGridView1();


        }

        private void loadGridView1()
        {
            Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.selectOSTHRemAberto();
            this.dt = controller.dt;

            if(controller.msg != null)
            {
                MessageBox.Show(controller.msg);
            }

            dataGridView1.DataSource = dt;

            loadStyleGridView1();

            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (i == dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];

                    break;
                }

            }
            dataGridView1.ClearSelection();
            timer1.Start();

        }
        private void loadStyleGridView1()
        {

            dataGridView1.Columns["descricaoServico"].Visible = false;

            dataGridView1.Columns["DataHoraFinalizacao"].Visible = false;

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
                if (dataGridView1.Rows[i].Cells[10].Value.ToString() == "EM ABERTO")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.LightPink;

                }
                if (dataGridView1.Rows[i].Cells[10].Value.ToString() == "Manutenção/INI")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.LightPink;

                }

                if (dataGridView1.Rows[i].Cells[10].Value.ToString() == "Aguardando/AUT. Peça")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.LightPink;

                }

                if (dataGridView1.Rows[i].Cells[10].Value.ToString() == "Manutenção/FIN")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.LightPink;

                }

                if (dataGridView1.Rows[i].Cells[10].Value.ToString() == "OS/INC" || dataGridView1.Rows[i].Cells[10].Value.ToString() == "Manutenção/NC")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkRed;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;

                }


            }
        }

        

        private void timer1_Tick(object sender, EventArgs e)
        {
    
            num++;

            lblSegundos.Text = num.ToString();

            if (num == 60)
            {

               loadGridView1();

                num = 0;
            }
            

        }

        private void dataGridView1_DefaultCellStyleChanged(object sender, EventArgs e)
        {
        

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
