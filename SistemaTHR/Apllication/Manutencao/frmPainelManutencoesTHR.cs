using SistemaTHR.Service.Exepction;
using SistemaTHR.Service.manutencao;
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

        private int num;
        private osThrService service;
        public frmPainelManutencoesTHR()
        {
            InitializeComponent();
            service = new osThrService();
        }
        private void frmPainelManutencoesTHR_Load(object sender, EventArgs e)
        {
            loadGridView1();

        }
        private void loadGridView1()
        {

            try
            {
                dataGridView1.DataSource = service.Painel();
                for(int i =0; i< dataGridView1.Rows.Count; i++)
                {
                    if (i == dataGridView1.Rows.Count - 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        break;
                    }
                }
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.ClearSelection();
                timer1.Start();
            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "EM ABERTO")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.LightPink;

                }
                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "Manutenção/INI")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Yellow;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.LightPink;

                }

                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "Aguardando/AUT. Peça")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Purple;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.LightPink;

                }



                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "Manutenção/FIN")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.OrangeRed;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.LightPink;

                }

                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "OS/INC" || dataGridView1.Rows[i].Cells[11].Value.ToString() == "Manutenção/NC")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.DarkRed;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.White;

                }
                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "Peças Autorizadas")
                {

                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Blue;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Yellow;

                }

                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "EM ABERTO (G 2)")
                {

                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.HotPink;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;

                }

                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "Solicitado/Compra")
                {

                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Aqua;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;

                }

                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "Comprado")
                {

                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.MediumBlue;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Yellow;

                }

            }
        }
        private void timer1_Tick(object sender, EventArgs e)
        {
    
            num++;
            if (num == 150)
            {

               loadGridView1();

                num = 0;
            }
            

        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if(panel2.BackColor == Color.FromArgb(0,192,0))
            {
                timer1.Stop();
                panel2.BackColor = Color.FromArgb(156, 8, 8);
            }
        }

        private void btnPlay_Click(object sender, EventArgs e)
        {
            if (panel2.BackColor == Color.FromArgb(156, 8, 8))
            {
                timer1.Start();
                panel2.BackColor = Color.FromArgb(0, 192, 0);
            }
        }
    }
}
