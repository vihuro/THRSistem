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

namespace SistemaTHR.Apllication
{
    public partial class frmSolicitarManutencaoTHR : Form
    {

        private Controller.Login.loginController loginController;
        private Controller.manutencao.osThrController controller;
        private Service.manutencao.osThrService service = new Service.manutencao.osThrService();

        private Controller.manutencao.geracaoOsTHRController geracaoController;
        private Service.manutencao.geracaoOsThrService geracaoService;

        private Controller.manutencao.apontamentoOsThrController apontamentoController;
        private Service.manutencao.apontamentoOsThrService apontamentoService;

        private Controller.manutencao.statusOsThrController statusController;
        private Service.manutencao.statusOsThrService statusService;

        private Controller.manutencao.aseController aseController;
        private Service.manutencao.aseService asService;

        public frmSolicitarManutencaoTHR(Controller.Login.loginController loginController)
        {
            InitializeComponent();
            this.loginController = loginController;
        }

        public String dataServico;
        public DateTime data;
        private void verificarData()
        {


            if (dateTimePicker1.Format == DateTimePickerFormat.Custom)
            {
                dataServico = "00/00/0000";
            }
            else
            {
                dateTimePicker1.Value = dateTimePicker1.Value.Date;

                data = Convert.ToDateTime(dateTimePicker1.Value.ToString());

                dataServico = data.ToString("dd/MM/yyyy");

            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (cboAondeSera.Text != string.Empty && cboTipoServico.Text != string.Empty && txtDescricao.Text != string.Empty)
            {
                DateTime dataHora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                String horaAgora = dataHora.ToString();

                statusController = new Controller.manutencao.statusOsThrController();
                statusService = new Service.manutencao.statusOsThrService();

                controller = new Controller.manutencao.osThrController();
                controller.Descricao = txtDescricao.Text;
                controller.TipoServico = cboTipoServico.Text;
                controller.DataHora = horaAgora;
                controller.Usuario = loginController.Nome;
                controller.Categoria = cboCategoria.Text;
                controller.Ase = cboAondeSera.Text;
                verificarData();
                controller.DataIdeal = dataServico.ToString();
                controller.StatusOs = "EM ABERTO";


                service.insert(controller);
                if (controller.Msg != null)
                {
                    MessageBox.Show(controller.Msg);
                }

                else
                {

                    service.selectOS(controller);
                    if (controller.Msg != null)
                    {
                        MessageBox.Show(controller.Msg, "ERRO COM BANCO DE DADOS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        geracaoController = new Controller.manutencao.geracaoOsTHRController();
                        geracaoService = new Service.manutencao.geracaoOsThrService();
                        geracaoService.active(geracaoController);
                        if (geracaoController.Msg != null)
                        {
                            MessageBox.Show(geracaoController.Msg);
                        }
                        else
                        {
                            apontamentoController = new Controller.manutencao.apontamentoOsThrController();
                            apontamentoController.Geracao = geracaoController.Geracao;
                            apontamentoService = new Service.manutencao.apontamentoOsThrService();
                            statusService = new Service.manutencao.statusOsThrService();
                            apontamentoService.list(apontamentoController);
                            if (apontamentoController.Msg != null)
                            {
                                MessageBox.Show(apontamentoController.Msg);
                            }
                            else
                            {
                                foreach (var apont in apontamentoController.Apont)
                                {
                                    statusController = new Controller.manutencao.statusOsThrController();
                                    statusService = new Service.manutencao.statusOsThrService();
                                    if (apont == "Geração")
                                    {
                                        statusController.NOsThr = controller.NOs;
                                        statusController.Andamento = apont;
                                        statusController.DataHoraApontamento = Convert.ToString(dataHora);
                                        statusController.UsuarioApontamento = loginController.Nome;
                                        statusController.DataHoraAlteracao = Convert.ToString(dataHora);
                                        statusController.UsuarioAlteracao = loginController.Nome;
                                        statusController.Observacao = "";
                                        statusService.insert(statusController);
                                        if (statusController.Msg != null)
                                        {
                                            MessageBox.Show(statusController.Msg);
                                        }
                                    }
                                    else
                                    {

                                        statusController.NOsThr = controller.NOs;
                                        statusController.Andamento = apont;
                                        statusController.DataHoraApontamento = "00/00/0000 00:00:00";
                                        statusController.UsuarioApontamento = "";
                                        statusController.DataHoraAlteracao = "00/00/0000 00:00:00";
                                        statusController.UsuarioAlteracao = "";
                                        statusController.Observacao = "";
                                        statusService.insert(statusController);
                                        if (statusController.Msg != null)
                                        {
                                            MessageBox.Show(statusController.Msg);
                                        }

                                    }
                                }
                                MessageBox.Show("Ordem solicitada com sucesso!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                        }


                    }

                }

                this.Cursor = Cursors.Default;
                this.Close();
            }
            else
            {
                MessageBox.Show("Campos obrigatório(s) vazio(s)", "THR SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSolicitarManutencaoTHR_Load(object sender, EventArgs e)
        {

            aseController = new Controller.manutencao.aseController();
            asService = new Service.manutencao.aseService();
            try
            {
                foreach (var item in asService.List())
                {
                    cboAondeSera.Items.Add(item);
                }
            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            int totalCaractere = 1000;

            foreach (char item in txtDescricao.Text)
            {
                totalCaractere += -1;
            }
            lblCaractere.Text = "Caracteres restantes: " + totalCaractere;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if (dateTimePicker1.Value >= DateTime.Today)
            {
                dateTimePicker1.Format = DateTimePickerFormat.Short;
            }
            else
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
            }
        }
    }
}
