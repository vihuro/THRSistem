using System;
using System.Windows.Forms;
using SistemaTHR.Controller.estoque;
using SistemaTHR.Service.estoque;
using SistemaTHR.Controller.Login;
using System.Drawing;

namespace SistemaTHR.Apllication.Estoque
{
    public partial class frmPainelSolicitacoes : Form
    {
        private SolicitacaoController controller;
        private SolicitacaoService service;
        private loginController loginController;

        public frmPainelSolicitacoes(loginController loginController)
        {
            this.loginController = loginController;
            InitializeComponent();
            IniciarService();
            cboFiltro.Text = "TODOS";

        }

        private SolicitacaoService IniciarService()
        {
            return this.service = new SolicitacaoService(loginController);
        }

        private void frmPainelSolicitacoesWind_Load(object sender, EventArgs e)
        {
            LoadGridView();
            TempoEspera();

            timer1.Start();
        }

        private void LoadGridView()
        {
            string filtro = "";

            controller = new SolicitacaoController();
            service.Table(controller);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if(cboFiltro.Text == "WIND")
                {
                    filtro = "WNDN";
                }

                controller.Dt.DefaultView.RowFilter = string.Format("[Codigo_Item] like '%{0}%'", filtro);

                dataGridView1.DataSource = controller.Dt;


                dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True;
                dataGridView1.ClearSelection();
            }
        }

        public void TempoEspera()
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {


                var tempoEspera = CarregarTempoEspera(Convert.ToDateTime(dataGridView1.Rows[i].Cells[9].Value.ToString()));
                dataGridView1.Rows[i].Cells[13].Value = tempoEspera;

                if(Convert.ToDateTime(tempoEspera.ToString()).Hour > 0)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else if(Convert.ToDateTime(tempoEspera.ToString()).Minute >= 30)
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Red;
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }
                else
                {
                    dataGridView1.Rows[i].DefaultCellStyle.BackColor = Color.Green;

                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.White;
                }

            }
        }


        private string CarregarTempoEspera(DateTime HoraRequisicao)
        {

            return service.TempoEspera(HoraRequisicao,DateTime.Now);
        }


        int num;
        private void timer1_Tick(object sender, EventArgs e)
        {

            num++;

            if(num < 119)
            {
                txtDataHora.Text = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            
               TempoEspera();

            }
            else if(num == 120)
            {
                LoadGridView();
                num = 0;
            }

        }

        private void dataGridView1_CellStyleChanged(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

        }
    }
}
