using SistemaTHR.Controller.Login;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.DAO.Manutencao;
using SistemaTHR.dto.manutencao;
using SistemaTHR.Service.Exepction;
using SistemaTHR.Service.manutencao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Manutencao
{
    public partial class frmConversaoEstoquePecas : Form
    {
        private EstoquePecasRadarService RadarService;
        private EstoquePecasService service;

        public frmConversaoEstoquePecas(loginController loginController, modulosController modulosController)
        {
            InitializeComponent();
            RadarService = new EstoquePecasRadarService();
            service = new EstoquePecasService(loginController,modulosController); 
        }

        private void LoadGridView()
        {
            try
            {
                dataGridRadar.DataSource = RadarService.Table();
                dataGridThr.DataSource = service.table();
            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frmConversaoArquivoTxt_Load(object sender, EventArgs e)
        {

            LoadGridView();
        }


        private DateTime dataHora;
        private void btnVerificar_Click(object sender, EventArgs e)
        {
            try
            {
                var watch = new Stopwatch();

                var segundos =

                dataHora = DateTime.Now;

                var list = RadarService.Verificar((DataTable)dataGridRadar.DataSource, (DataTable)dataGridThr.DataSource);

                lblQuantidadeLinhas.Text = list.Count.ToString();

                var resultadoTempo = DateTime.Now - dataHora ;



                Console.WriteLine("Tempo percorrido = " + resultadoTempo.Seconds + ":" +  resultadoTempo.Milliseconds);


            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            try
            {
                this.Cursor = Cursors.WaitCursor;

                dataHora = DateTime.Now;

                var linhas = RadarService.Verificar((DataTable)dataGridRadar.DataSource, (DataTable)dataGridThr.DataSource);

                foreach (var iten in linhas )
                {
                    var obj = new EstoquePecasController()
                    {
                        Codigo = iten.Codigo,
                        Descricao = iten.Descricao,
                        Unidade = iten.Unidade,
                        Fornecedor1 = "",
                        CodFornecedor1 = "",
                        Fornecedor2 = "",
                        CodFornecedor2 = "",
                        Fornecedor3 = "",
                        CodFornecedor3 = "",
                        EstoqueMax = "0",
                        EstoqueMin = "0",
                        
                    };
                    service.Insert(obj);
                }

                var resultadoTempo = DateTime.Now - dataHora ;

                MessageBox.Show($"Lista incluída com sucesso! \r\n Tempo percorrido = {resultadoTempo.Seconds}:{resultadoTempo.Milliseconds} " +
                    $"\r\n Linhas afetadas = {linhas.Count()}","SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Information);

                LoadGridView();
            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            this.Cursor = Cursors.Default;

        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            LoadGridView();
        }
    }
}
