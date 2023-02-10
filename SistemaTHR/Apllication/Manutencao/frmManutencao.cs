using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using SistemaTHR.Apllication.Manutencao;
using SistemaTHR.Controller.Login;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.Service.Exepction;
using SistemaTHR.Service.manutencao;


namespace SistemaTHR.Apllication
{
    public partial class frmManutencao : Form
    {

        private osThrController osController;
        private osThrService osService;

        private statusOsThrController statusController;
        private statusOsThrService statusService;

        private prioridadeManController prioriadadeController;
        private prioridadeManService prioridadeService;

        private solictacaoPecaService solictacaoPecaService;
        private solicitacaoPecaoController solicitacaoPecaoController;

        private EstoquePecasService estoqueService;
        private movimentacaoPecasService movimentacaoService;


        String Status;
        public string Pesquisa ="";

        private loginController loginController;
        private modulosController modulosController;
        public frmManutencao(loginController loginController, modulosController modulosController)
        {
            this.loginController = loginController;
            this.modulosController = modulosController;
            InitializeComponent();
            IniciarOsThrService();
            IniciarStatusService();
            IniciarPrioridadeManuntecaoService();
            IniciarSolicitacaoPecaService();
            IniciarMovimentacaoService();
            IniciarEstoqueService();

        }
        private EstoquePecasService IniciarEstoqueService()
        {
            return estoqueService = new EstoquePecasService(loginController, modulosController);
        }

        private movimentacaoPecasService IniciarMovimentacaoService()
        {
            return movimentacaoService = new movimentacaoPecasService(loginController, modulosController);
        }

        private solictacaoPecaService IniciarSolicitacaoPecaService()
        {
            return solictacaoPecaService = new solictacaoPecaService(loginController, modulosController);
        }

        private prioridadeManService IniciarPrioridadeManuntecaoService()
        {
            return this.prioridadeService = new prioridadeManService();
        }

        private osThrService IniciarOsThrService()
        {
            return this.osService = new osThrService();
        }

        private statusOsThrService IniciarStatusService()
        {
            return this.statusService = new statusOsThrService();
        }

        public void loadFilter(osThrController osController)
        {
            osService.SelectTableFilter(osController);
            if (osController.Msg != null)
            {
                MessageBox.Show(osController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.DataSource = osController.Dt;
            }
        }

        public void loadGridView1()
        {

            try
            {
                dataGridView1.DataSource = osService.Table();
                for (var i = 0; i < dataGridView1.Rows.Count; i++)
                {

                    if (i == dataGridView1.Rows.Count - 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];

                        break;
                    }

                }
                if(Pesquisa != string.Empty)
                {
                    var dt = (DataTable)dataGridView1.DataSource;
                    dt.DefaultView.RowFilter = Pesquisa;
                }

            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }



        }

        String numeroOS;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            DataGridView dataGrid = (DataGridView)sender;
            int i = dataGrid.SelectedRows.Count;

            if (dataGridView1.Rows.Count > 0)
            {
                if (dataGridView1.SelectedRows.Count > 0)
                {
                    numeroOS = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    txtOrdemServico.Text = numeroOS;
                    txtDescricao.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value.ToString();
                    cboPrioridade.Text = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[8].Value.ToString();

                    loadDataGridView2();
                    loadGridView3();
                }
            }


            if (modulosController.ManutencaoNivel == "1" ||
                modulosController.ManutencaoNivel == "2" ||
                modulosController.ManutencaoNivel == "3")
            {

                btnAdicionar.Enabled = true;
            }
            else
            {
                btnAdicionar.Enabled = false;
            }
            this.Cursor = Cursors.Default;
        }


        private void loadGridView3()
        {
            solicitacaoPecaoController = new solicitacaoPecaoController();


            solicitacaoPecaoController.NOs = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            solictacaoPecaService.selectTable(solicitacaoPecaoController);
            if (solicitacaoPecaoController.Msg != null)
            {
                MessageBox.Show(solicitacaoPecaoController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                dataGridView3.DataSource = solicitacaoPecaoController.Dt;
            }
            dataGridView3.ClearSelection();
        }

        private void loadDataGridView2()
        {
            statusController = new statusOsThrController();


            statusController.NOsThr = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            statusService.selecTableOS(statusController);
            if (statusController.Msg != null)
            {
                MessageBox.Show(statusController.Msg);
            }
            else
            {
                //statusController.Dt.DefaultView.RowFilter = string.Format("[NumeroOSTHR] = '{0}'", dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                dataGridView2.DataSource = statusController.Dt;
            }

            dataGridView2.ClearSelection();
            txtObservacao.Text = string.Empty;
            btnApontar.Enabled = false;
            btnDesfazer.Enabled = false;

        }

        private void btnApontar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            string datahora = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));


            if (dataGridView2.SelectedRows[0].Cells[3].Value.Equals("00/00/0000 00:00:00"))
            {
                dataGridView2.SelectedRows[0].Cells[3].Value = Convert.ToString(DateTime.Now.ToString());
                dataGridView2.SelectedRows[0].Cells[4].Value = loginController.Nome;
            }
            if (!dataGridView2.SelectedRows[0].Cells[3].Value.Equals("00/00/0000 00:00:00"))
            {
                dataGridView2.SelectedRows[0].Cells[5].Value = Convert.ToString(datahora);
                dataGridView2.SelectedRows[0].Cells[6].Value = loginController.Nome;
            }


            osController = new osThrController();

            osController.NOs = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            osService.load(osController);
            if (osController.Msg != null)
            {
                MessageBox.Show(osController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (dataGridView3.Rows.Count > 0)
                {
                    for (int i = 0; i < dataGridView3.Rows.Count; i++)
                    {
                        if (dataGridView3.Rows[i].Cells[8].Value.ToString() == "AGUARDANDO/AUT. PEÇAS")
                        {
                            Status = "Aguardando/AUT.Peça";
                            break;
                        }
                        else if (i == dataGridView3.Rows.Count - 1)
                        {
                            if (osController.StatusOs == "Aguardando/AUT.Peça")
                            {
                                Status = "Peças Autorizadas";
                                break;
                            }
                        }
                    }
                }
                if (osController.StatusOs == "Aguardando/AUT.Peça" && Status != "Peças Autorizadas")
                {
                    Status = "Aguardando/AUT.Peça";
                }
                else if (osController.StatusOs == "OS/INC" && modulosController.ManutencaoNivel == "3")
                {
                    Status = "OS/INC";
                }
                else if (osController.StatusOs == "Manutenção/NC" && modulosController.ManutencaoNivel == "4")
                {
                    Status = "Manutenção/NC";
                }
                else
                {

                    if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "Início de manutenção")
                    {
                        Status = "Manutenção/INI";
                    }

                    else if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "Inconsistência da OS")
                    {
                        Status = "OS/INC";
                    }

                    else if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "Fim de Manutenção")
                    {
                        Status = "Manutenção/FIN";
                    }
                    else if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "OS Finalizada")
                    {
                        Status = "OS/Finalizada";
                    }
                    else if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "Geração")
                    {
                        Status = "EM ABERTO (G 2)";
                    }
                    else if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "Manutenção N/C")
                    {
                        Status = "Manutenção/NC";
                    }
                    else if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "Compra de Peça ENT")
                    {
                        Status = "Solicitado/Compra";
                    }
                    else if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "Compra de Peça SDA")
                    {
                        Status = "Comprado";
                    }
                    else if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "Incosistência da OS")
                    {
                        Status = "OS/INC";
                    }
                    else
                    {
                        Status = osController.StatusOs;
                    }

                }
            }
            osController = new osThrController();

            osController.StatusOs = Status;
            osController.NOs = dataGridView2.SelectedRows[0].Cells[1].Value.ToString();
            osService.status(osController);
            if (osController.Msg != null)
            {
                MessageBox.Show(osController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                statusController = new statusOsThrController();
                statusController.DataHoraApontamento = dataGridView2.SelectedRows[0].Cells[3].Value.ToString();
                statusController.UsuarioApontamento = dataGridView2.SelectedRows[0].Cells[4].Value.ToString();
                statusController.DataHoraAlteracao = dataGridView2.SelectedRows[0].Cells[5].Value.ToString();
                statusController.UsuarioAlteracao = dataGridView2.SelectedRows[0].Cells[6].Value.ToString();
                statusController.Observacao = txtObservacao.Text;
                statusController.NStatus = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
                statusService.update(statusController);
                if (statusController.Msg != null)
                {
                    MessageBox.Show(statusController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }


            dataGridView2.ClearSelection();
            loadDataGridView2();
            //loadGridView2Apontamento(numeroStatus);
            btnApontar.Enabled = false;
            btnDesfazer.Enabled = false;

            this.Cursor = Cursors.Default;

        }

        private void loadGridView2Apontamento(String nApontamento)
        {


            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                if (dataGridView2.Rows[i].Cells[0].Value.ToString() == nApontamento)
                {

                    dataGridView2.CurrentCell = dataGridView2.Rows[i].Cells[2];
                    break;
                }
            }

            dataGridView2.ClearSelection();
            txtObservacao.Text = string.Empty;
            btnApontar.Enabled = false;
            btnDesfazer.Enabled = false;
        }

        private void dataGridView2_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            for (int i = 0; i < dataGridView2.Rows.Count; i++)
            {
                dataGridView2.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;

                if (dataGridView2.Rows[i].Cells[4].Value.ToString() != "")
                {
                    dataGridView2.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                    dataGridView2.Rows[i].DefaultCellStyle.SelectionForeColor = Color.LightPink;

                }
                if (dataGridView2.Rows[i].Cells[4].Value.ToString() == "" && dataGridView2.Rows[i].Cells[2].Value.ToString() == "Início de manutenção")
                {

                    dataGridView2.Rows[6].DefaultCellStyle.ForeColor = Color.Gray;
                }

                if (dataGridView2.Rows[i].Cells[4].Value.ToString() == "" && dataGridView2.Rows[i].Cells[2].Value.ToString() == "Compra de Peça ENT")
                {

                    dataGridView2.Rows[5].DefaultCellStyle.ForeColor = Color.Gray;
                }

                if (dataGridView2.Rows[i].Cells[2].Value.ToString() == "Manutenção N/C" && modulosController.ManutencaoNivel != "3" &&
                    modulosController.ManutencaoNivel != "1" && dataGridView2.Rows[i].Cells[4].Value.ToString() == string.Empty)
                {

                    dataGridView2.Rows[i].DefaultCellStyle.ForeColor = Color.Gray;
                }

                if (dataGridView2.Rows[i].Cells[2].Value.ToString() == "OS Finalizada" && modulosController.ManutencaoNivel != "3" &&
                    dataGridView2.Rows[i].Cells[4].Value.ToString() == string.Empty)
                {

                    dataGridView2.Rows[i].DefaultCellStyle.ForeColor = Color.Gray;
                    dataGridView2.Rows[i].DefaultCellStyle.SelectionForeColor = Color.DarkGray;
                }

            }

        }

        private void clearAll()
        {
            dataGridView1.ClearSelection();

            while (dataGridView2.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView2.Rows.Count; i++)
                {

                    dataGridView2.Rows.Remove(dataGridView2.Rows[i]);

                }
            }

            while (dataGridView3.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {

                    dataGridView3.Rows.Remove(dataGridView3.Rows[i]);

                }
            }

            dataGridView2.ClearSelection();
            dataGridView3.ClearSelection();
            styleGridView3();
            txtDescricao.Text = string.Empty;
            txtObservacao.Text = string.Empty;
            txtOrdemServico.Text = string.Empty;
            cboPrioridade.Text = string.Empty;
            btnApontar.Enabled = false;
            btnDesfazer.Enabled = false;
            btnAutorizar.Enabled = false;
            btnAdicionar.Enabled = false;


        }

        private void frmManutencao_Load(object sender, EventArgs e)
        {

            loadGridView1();
            clearAll();
            prioridadeComboBox();

            if (modulosController.ManutencaoNivel == "1" || modulosController.ManutencaoNivel == "2")
            {
                cboPrioridade.Enabled = true;
            }
        }

        private void prioridadeComboBox()
        {
            prioriadadeController = new prioridadeManController();
            prioridadeService.List(prioriadadeController);
            {
                if (prioriadadeController.Msg != null)
                {
                    MessageBox.Show(prioriadadeController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    foreach (var prioridade in prioriadadeController.List)
                    {
                        cboPrioridade.Items.Add(prioridade);
                    }
                }
            }
        }

        private void dataGridView2_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int i = dataGrid.SelectedRows.Count;

            if (dataGridView2.CurrentCell != null)
            {

                if (i > 0)
                {

                    txtObservacao.Text = dataGridView2.SelectedRows[0].Cells[7].Value.ToString();
                    for (i = 0; i < dataGridView2.Rows.Count; i++)
                    {
                        if (dataGridView2.CurrentRow.DefaultCellStyle.ForeColor == Color.Gray)
                        {
                            btnApontar.Enabled = false;

                        }
                        else
                        {
                            btnApontar.Enabled = true;
                        }
                    }

                }
                if (dataGridView2.SelectedRows.Count > 0)
                {
                    if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "OS Finalizada")
                    {
                        if (modulosController.ManutencaoNivel == "4" || modulosController.ManutencaoNivel == "1")
                        {
                            if (modulosController.ManutencaoNivel == "4" && dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == loginController.Nome)
                            {
                                btnApontar.Enabled = true;
                            }
                            else if (modulosController.ManutencaoNivel == "1")
                            {
                                btnApontar.Enabled = true;
                            }
                            else if (modulosController.ManutencaoNivel == "2" && dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == loginController.Nome)
                            {
                                btnApontar.Enabled = true;
                            }
                            else
                            {
                                btnApontar.Enabled = false;
                            }

                        }
                        else if (dataGridView1.SelectedRows[0].Cells[6].Value.ToString() == "Preventiva")
                        {
                            if (modulosController.ManutencaoNivel == "2")
                            {
                                btnApontar.Enabled = true;
                            }
                            else
                            {
                                btnApontar.Enabled = false;
                            }

                        }
                        else if (modulosController.ManutencaoNivel == "2" && dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == loginController.Nome)
                        {
                            btnApontar.Enabled = true;
                        }
                        else
                        {
                            btnApontar.Enabled = false;
                        }

                    }

                    else if (dataGridView2.SelectedRows[0].Cells[4].Value.ToString() != "" && modulosController.ManutencaoNivel == "1")
                    {
                        btnDesfazer.Enabled = true;
                    }
                    else
                    {
                        btnDesfazer.Enabled = false;
                    }


                    if (dataGridView2.SelectedRows[0].Cells[2].Value.ToString() == "Manutenção N/C" &&
                        dataGridView1.SelectedRows[0].Cells[11].Value.ToString() == "Manutenção/FIN")
                    {
                        btnApontar.Enabled = true;
                    }
                }


            }

        }

        private void btnLimpar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(btnLimpar, "Atualizar");
        }

        private void btnFiltrar_MouseMove(object sender, MouseEventArgs e)
        {
            toolTip1.SetToolTip(btnFiltrar, "Filtrar");
        }

        private void btnCompra_MouseMove(object sender, MouseEventArgs e)
        {


        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            Pesquisa = "";
            loadGridView1();
            clearAll();
        }


        private void btnDesfazer_Click(object sender, EventArgs e)
        {

            dataGridView2.SelectedRows[0].Cells[3].Value = "00/00/0000 00:00:00";
            dataGridView2.SelectedRows[0].Cells[4].Value = "";
            dataGridView2.SelectedRows[0].Cells[5].Value = "00/00/0000 00:00:00";
            dataGridView2.SelectedRows[0].Cells[6].Value = loginController.Nome;

            Controller.manutencao.statusOsThrController controller = new Controller.manutencao.statusOsThrController();
            Service.manutencao.statusOsThrService service = new Service.manutencao.statusOsThrService();

            controller.DataHoraApontamento = "00/00/0000 00:00:00";
            controller.UsuarioApontamento = "";
            controller.DataHoraAlteracao = "00/00/0000 00:00:00";
            controller.UsuarioAlteracao = loginController.Nome;
            controller.NStatus = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
            service.desfazer(controller);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }

            /* Modelo.OSTHRController controller = new Modelo.OSTHRController();
             controller.numeroStatus = dataGridView2.SelectedRows[0].Cells[0].Value.ToString();
             controller.dataHoraApontament = "00/00/0000 00:00:00";
             controller.usuarioApontamento = "";
             controller.dataHoraAlteracao = "00/00/0000 00:00:00";
             controller.usuarioAlteracao = Usuario;
             controller.desfazerApont();

             if(controller.msg != null)
             {
                 MessageBox.Show(controller.msg);
             }*/

            dataGridView2.ClearSelection();
            loadDataGridView2();
            btnApontar.Enabled = false;
            btnDesfazer.Enabled = false;

        }

        private void BtnSalvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            osController = new Controller.manutencao.osThrController();
            osService = new Service.manutencao.osThrService();
            osController.NOs = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            osService.load(osController);
            if (osController.Msg != null)
            {
                MessageBox.Show(osController.Msg);
            }
            else
            {
                if (osController.Prioridade != cboPrioridade.Text)
                {

                    osController.Prioridade = cboPrioridade.Text;
                    osController.DataHoraPrioridade = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                    osController.UsuarioPrioridade = loginController.Nome;
                    osService.updatePrioridade(osController);
                    if (osController.Msg != null)
                    {
                        MessageBox.Show(osController.Msg);
                    }
                }

            }
            if (dataGridView3.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {

                    if (dataGridView3.Rows[i].Cells[9].Value.ToString() == "AGUARDANDO/AUT. PEÇAS")
                    {
                        Status = "Aguardando/AUT. Peça";
                        for (int i2 = 0; i2 < dataGridView2.Rows.Count; i2++)
                        {
                            if (dataGridView2.Rows[i2].Cells[2].Value.ToString() == "Requisição de Peça")
                            {
                                if (dataGridView2.Rows[i2].Cells[4].Value.ToString() == "")
                                {
                                    statusController = new Controller.manutencao.statusOsThrController();
                                    statusService = new Service.manutencao.statusOsThrService();
                                    statusController.DataHoraApontamento = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                                    statusController.UsuarioApontamento = loginController.Nome;
                                    statusController.DataHoraAlteracao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                                    statusController.UsuarioAlteracao = loginController.Nome;
                                    statusController.NStatus = dataGridView2.Rows[i2].Cells[0].Value.ToString();
                                    statusController.Observacao = "";
                                    statusService.update(statusController);
                                    if (statusController.Msg != null)
                                    {
                                        MessageBox.Show(statusController.Msg);
                                    }

                                }
                                else
                                {
                                    statusController = new Controller.manutencao.statusOsThrController();
                                    statusService = new Service.manutencao.statusOsThrService();
                                    statusController.DataHoraApontamento = dataGridView2.Rows[i2].Cells[3].Value.ToString();
                                    statusController.UsuarioApontamento = dataGridView2.Rows[i2].Cells[4].Value.ToString();
                                    statusController.DataHoraAlteracao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                                    statusController.UsuarioAlteracao = loginController.Nome;
                                    statusController.NStatus = dataGridView2.Rows[i2].Cells[0].Value.ToString();
                                    statusController.Observacao = "";
                                    statusService.update(statusController);
                                    if (statusController.Msg != null)
                                    {
                                        MessageBox.Show(statusController.Msg);
                                    }
                                    break;

                                }
                            }
                        }
                        break;

                    }

                    if (i == dataGridView3.Rows.Count - 1)
                    {
                        if (osController.StatusOs == "Aguardando/AUT. Peça")
                        {
                            Status = "Peças Autorizadas";
                            for (int i2 = 0; i2 < dataGridView2.Rows.Count; i2++)
                            {
                                if (dataGridView2.Rows[i2].Cells[2].Value.ToString() == "Requisição de Peça")
                                {
                                    statusController = new Controller.manutencao.statusOsThrController();
                                    statusService = new Service.manutencao.statusOsThrService();
                                    statusController.DataHoraApontamento = dataGridView2.Rows[i2].Cells[3].Value.ToString();
                                    statusController.UsuarioApontamento = dataGridView2.Rows[i2].Cells[4].Value.ToString();
                                    statusController.DataHoraAlteracao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                                    statusController.UsuarioAlteracao = loginController.Nome;
                                    statusController.NStatus = dataGridView2.Rows[i2].Cells[0].Value.ToString();
                                    statusController.Observacao = "";
                                    statusService.update(statusController);
                                    break;
                                }
                            }
                        }

                    }
                }
                if (Status != null)
                {
                    osController = new Controller.manutencao.osThrController();
                    osService = new Service.manutencao.osThrService();
                    osController.StatusOs = Status;
                    osController.NOs = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                    osService.status(osController);
                    if (osController.Msg != null)
                    {
                        MessageBox.Show(osController.Msg);
                    }
                }


            }

            loadGridView1();

            this.Cursor = Cursors.Default;

        }

        private void loadGridView1SelectOS(String numeroOs)
        {

            loadGridView1();

            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {


                if (numeroOs == dataGridView1.Rows[dataGridView1.Rows[i].Index].Cells[0].Value.ToString())
                {

                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];

                    break;
                }

            }
            clearAll();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmObservacoes observacoes = new frmObservacoes(txtObservacao.Text, this);
            observacoes.txtObservaco.Text = this.txtObservacao.Text;
            observacoes.ShowDialog();
        }

        private void txtObservacao_DoubleClick(object sender, EventArgs e)
        {
            frmObservacoes observacoes = new frmObservacoes(txtObservacao.Text, this);
            observacoes.txtObservaco.Text = this.txtObservacao.Text;
            observacoes.ShowDialog();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            frmOSTHR oSTHR = new frmOSTHR(numeroOS);
            oSTHR.ShowDialog();
        }

        private void selectNOS()
        {
            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (txtOrdemServico.Text == dataGridView1.Rows[dataGridView1.Rows[i].Index].Cells[0].Value.ToString())
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                    break;
                }

                if (i == dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                    dataGridView1.ClearSelection();
                    clearAll();
                    MessageBox.Show("OS não encontrada!", "THR SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    break;
                }

            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                loadGridView1();
                clearAll();
            }
        }

        private void txtOrdemServico_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                loadGridView1();
                clearAll();
            }

            if (e.KeyCode == Keys.Enter)
            {
                selectNOS();
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            frmFiltroManutencoes filtro = new frmFiltroManutencoes(this);
            filtro.ShowDialog();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "EM ABERTO")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "Aguardando/AUT. Peça")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Purple;

                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Violet;
                }

                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "Autorizado")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;

                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Yellow;
                }

                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "Manutenção/FIN")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.OrangeRed;

                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.DarkOrange;
                }

                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "OS/INC"
                    || dataGridView1.Rows[i].Cells[11].Value.ToString() == "Manutenção/NC")
                {

                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.DarkRed;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Red;

                }

                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "OS/Finalizada")
                {

                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.LightGreen;
                }

                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "Peças Autorizadas")
                {

                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Yellow;

                }

                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "EM ABERTO (G 2)")
                {

                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.HotPink;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.LightPink;

                }
            }
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            if (txtCodigo.Text != string.Empty && txtDescricao.Text != string.Empty && txtUnidade.Text != string.Empty &&
                txtQuantidade.Text != string.Empty)
            {
                solicitacaoPecaoController = new solicitacaoPecaoController();

                solicitacaoPecaoController.NOs = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                solicitacaoPecaoController.CodigoPeca = txtCodigo.Text;
                solicitacaoPecaoController.DescricaoPeca = txtDescricaoPeca.Text;
                solicitacaoPecaoController.Qtd = txtQuantidadePeca.Text;
                solicitacaoPecaoController.Unidade = txtUnidade.Text;
                solicitacaoPecaoController.ASU = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                solictacaoPecaService.insert(solicitacaoPecaoController);
                if (solicitacaoPecaoController.Msg != null)
                {
                    MessageBox.Show(solicitacaoPecaoController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    solictacaoPecaService.selectTable(solicitacaoPecaoController);
                    if (solicitacaoPecaoController.Msg != null)
                    {
                        MessageBox.Show(solicitacaoPecaoController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        dataGridView3.DataSource = solicitacaoPecaoController.Dt;
                        txtDescricaoPeca.Text = string.Empty;
                        txtCodigo.Text = string.Empty;
                        txtUnidade.Text = string.Empty;
                        txtQuantidadePeca.Text = string.Empty;
                    }
                }
            }
            else
            {
                MessageBox.Show("Campo(s) obrigatorio(s) vazio(s)!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnInvalidar_Click(object sender, EventArgs e)
        {
            solicitacaoPecaoController = new solicitacaoPecaoController();

            solicitacaoPecaoController.NRequisicao = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
            solicitacaoPecaoController.StatusSolicitacao = dataGridView3.SelectedRows[0].Cells[9].Value.ToString();
            solictacaoPecaService.delete(solicitacaoPecaoController);
            if (solicitacaoPecaoController.Msg != null)
            {
                MessageBox.Show(solicitacaoPecaoController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                loadGridView3();
            }
        }

        private void dataGridView3_SelectionChanged(object sender, EventArgs e)
        {

            if (dataGridView3.SelectedRows.Count > 0)
            {

                if (modulosController.ManutencaoNivel == "1" ||
                    modulosController.ManutencaoNivel == "2" ||
                    modulosController.ManutencaoNivel == "3" ||
                    modulosController.ManutencaoNivel == "4")
                {
                    if (modulosController.ManutencaoNivel == "1" || modulosController.ManutencaoNivel == "2" &&
                        dataGridView3.SelectedRows[0].Cells[9].Value.ToString() != "AUTORIZADO")
                    {
                        btnAutorizar.Enabled = true;
                    }
                    if (dataGridView3.SelectedRows[0].Cells[9].Value.ToString() == "AUTORIZADO")
                    {
                        btnInvalidar.Enabled = false;

                    }
                    else
                    {
                        btnInvalidar.Enabled = true;
                    }

                }

            }

        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            if (modulosController.ManutencaoNivel == "1" || modulosController.ManutencaoNivel == "2")
            {
                solicitacaoPecaoController = new solicitacaoPecaoController();
                solictacaoPecaService = new solictacaoPecaService(loginController, modulosController, estoqueService, movimentacaoService);


                solicitacaoPecaoController.NRequisicao = dataGridView3.SelectedRows[0].Cells[0].Value.ToString();
                solicitacaoPecaoController.NOs = dataGridView3.SelectedRows[0].Cells[1].Value.ToString();
                solicitacaoPecaoController.CodigoPeca = dataGridView3.SelectedRows[0].Cells[2].Value.ToString();
                solicitacaoPecaoController.DescricaoPeca = dataGridView3.SelectedRows[0].Cells[3].Value.ToString();
                solicitacaoPecaoController.Qtd = dataGridView3.SelectedRows[0].Cells[4].Value.ToString();
                solicitacaoPecaoController.Unidade = dataGridView3.SelectedRows[0].Cells[5].Value.ToString();
                solicitacaoPecaoController.ASU = dataGridView3.SelectedRows[0].Cells[6].Value.ToString();
                solicitacaoPecaoController.UsuarioSolicitacao = dataGridView3.SelectedRows[0].Cells[7].Value.ToString();
                solicitacaoPecaoController.DataHoraSolicitacao = dataGridView3.SelectedRows[0].Cells[8].Value.ToString();
                solictacaoPecaService.authorizeRequisicao(solicitacaoPecaoController);
                if (solicitacaoPecaoController.Msg != null)
                {
                    MessageBox.Show(solicitacaoPecaoController.Msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    loadGridView3();
                }
                else
                {

                    loadGridView3();
                }
            }
        }


        private void dataGridView3_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for (var i = 0; i < dataGridView3.Rows.Count; i++)
            {
                dataGridView3.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
                if (dataGridView3.Rows[i].Cells[9].Value.ToString() == "AGUARDANDO/AUT. PEÇAS")
                {
                    dataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.Black;
                }
                if (dataGridView3.Rows[i].Cells[9].Value.ToString() == "AUTORIZADO")
                {
                    dataGridView3.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Yellow;
                    dataGridView3.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                }
            }
        }

        private void styleGridView3()
        {
            dataGridView3.Columns[0].Visible = false;
        }

        private void btnCompra_Click(object sender, EventArgs e)
        {

        }

        private void txtQuantidadePeca_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!Char.IsDigit(e.KeyChar) && e.KeyChar != (char)8 && !Char.IsPunctuation(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void btnBuscarPecas_Click(object sender, EventArgs e)
        {
            frmEstoquePesquisa pesquisa = new frmEstoquePesquisa(this);
            pesquisa.ShowDialog();
        }

        private void btnLimparPecas_Click(object sender, EventArgs e)
        {
            txtDescricaoPeca.ReadOnly = false;
            txtCodigo.ReadOnly = false;
            txtUnidade.ReadOnly = false;
            txtQuantidadePeca.ReadOnly = false;
        }

        private void txtCodigo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {

                Procurar();
            }
        }

        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            if (txtDescricaoPeca.Text.Length > 0)
            {
                Procurar();
            }
        }

        private void Procurar()
        {
            try
            {
                var obj = estoqueService.BuscarPorCodigo(txtCodigo.Text);
                txtCodigo.Text = obj.Codigo;
                txtDescricaoPeca.Text = obj.Descricao;
                txtUnidade.Text = obj.Unidade;

            }
            catch (ExceptionService ex)
            {
                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtCodigo.Text = "";
                txtDescricao.Text = "";
                txtUnidade.Text = "";

            }
        }
    }
}
