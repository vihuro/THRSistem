using SistemaTHR.Controller.Login;
using SistemaTHR.DAO.Manutencao;
using SistemaTHR.Service.Compras;
using SistemaTHR.Service.Exepction;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Compras
{
    public partial class frmPainelRequisicoesCompra : Form
    {
        private requisicaoCompraService service;
        private loginController loginController;
        private modulosController modulosController;

        private int num;
        public frmPainelRequisicoesCompra(loginController loginController, modulosController modulosController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.modulosController = modulosController;
            service = new requisicaoCompraService(loginController, modulosController);
        }

        private void frmPainelRequisicoesCompra_Load(object sender, EventArgs e)
        {
            LoadGridView();
            timer1.Start();

        }

        private void LoadGridView()
        {
            try
            {
                dataGridView1.DataSource = service.Painel();
                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;

                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if(i == dataGridView1.Rows.Count - 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        break;

                    }
                }
                dataGridView1.ClearSelection();

            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            num++;
            if(num == 50)
            {
                LoadGridView();
                num = 0;
            }
        }
        private void btnPlay_Click(object sender, EventArgs e)
        {
            if(panel1.BackColor == Color.FromArgb(156, 8, 8))
            {
                timer1.Start();
                panel1.BackColor = Color.FromArgb(0, 192, 0);
            }
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            if (panel1.BackColor == Color.FromArgb(0, 192, 0))
            {
                timer1.Stop();
                panel1.BackColor = Color.FromArgb(156,8,8);
            }
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for(int i = 0; i< dataGridView1.Rows.Count; i++)
            {
                var texto = dataGridView1.Rows[i].Cells[16].Value.ToString();
                if (texto == "Pendente")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(237,114,39);
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else if(texto == "Autorizado")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(22, 68, 216);
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else if (texto == "Comprado")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.FromArgb(58,234,100);
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
            }
        }
    }
}
