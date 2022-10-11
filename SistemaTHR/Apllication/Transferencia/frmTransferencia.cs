
using System;
using System.Data;
using System.Windows.Forms;


namespace SistemaTHR.Apllication
{
    public partial class frmTransferencia : Form
    {
        Controller.Login.loginController loginController;
        Controller.Login.modulosController ModulosController;
        Controller.transferencia.transferenciaController transferenciaController;

        Service.transferencia.transferenciaService transferenciaService = new Service.transferencia.transferenciaService();

        Service.transferencia.movimentacaoService movimentacaoService = new Service.transferencia.movimentacaoService();

        Service.transferencia.fechamentoService fechamentoService = new Service.transferencia.fechamentoService();

        public frmTransferencia(Controller.Login.loginController loginController, Controller.Login.modulosController modulosController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.ModulosController = modulosController;

        }

        private void txtNumeroPA_KeyUp(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {

               loadPA();

            }

        }

        public void loadPA()
        {
            this.Cursor = Cursors.WaitCursor;

            listView1.SelectedItems.Clear();
            for(var i = 0; i < listView1.Items.Count; i++)
            {
                if (listView1.Items[i].Text == "Resultado:")
                {

                    listView1.Items[i].Selected = true;
                    listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                }
            }

            Controller.estoque.paController paController = new Controller.estoque.paController();
            Service.estoque.paEstoqueService paService = new Service.estoque.paEstoqueService();
            paController.NumeroPa = txtNumeroPA.Text;
            if(rdbProducao.Checked == true)
            {
                paService.PaEstoque(paController);
            }
            if(rdbExpedicao.Checked == true)
            {
                paService.PaExpedicao(paController);
            }

            if (paController.Msg != null)
            {
                MessageBox.Show(paController.Msg);
            }
            else
            {
                if (paController.Codigo != null)
                {
                    ListViewItem list = new ListViewItem(txtNumeroPA.Text);

                    list.SubItems.Add(paController.Codigo);
                    list.SubItems.Add(paController.Descricao);
                    list.SubItems.Add(paController.PesoBruto.ToString("###,###.#0"));
                    list.SubItems.Add(paController.PesoLiquido.ToString("###,###.#0"));
                    list.SubItems.Add(paController.Bobinas.ToString("###,###.#0"));

                    listView1.Items.Add(list);
                    for(var i = 0; i < listView1.Items.Count; i++)
                    {
                        listView1.TopItem = listView1.Items[i];
                    }

                    if (listView2.Items.Count > 0)
                    {
                        for (var i = 0; i < listView2.Items.Count; i++)
                        {
                            if (listView2.Items[i].Text == paController.Codigo)
                            {
                                decimal pesoBruto = Convert.ToDecimal(listView2.Items[i].SubItems[2].Text);
                                decimal pesoLiquido = Convert.ToDecimal(listView2.Items[i].SubItems[3].Text);
                                double qtBobinas = Convert.ToDouble(listView2.Items[i].SubItems[4].Text);

                                decimal BrutoLoadPa = Convert.ToDecimal(paController.PesoBruto);
                                decimal LiquidoLoadPa = Convert.ToDecimal(paController.PesoLiquido);
                                double qtbobinasPa = Convert.ToDouble(paController.Bobinas);

                                decimal resultadoBruto = pesoBruto + BrutoLoadPa;
                                decimal resultadoLiquido = pesoLiquido + LiquidoLoadPa;
                                double resultadoQtBobinas = qtBobinas + qtbobinasPa;


                                listView2.Items[i].SubItems[2].Text = resultadoBruto.ToString("###,###.#0");
                                listView2.Items[i].SubItems[3].Text = resultadoLiquido.ToString("###,###.#0");
                                listView2.Items[i].SubItems[4].Text = resultadoQtBobinas.ToString("###,###.#0");

                                txtNumeroPA.Text = string.Empty;


                                break;
                            }
                            else if (i == listView2.Items.Count - 1)
                            {
                                ListViewItem listFechamento = new ListViewItem(paController.Codigo);
                                listFechamento.SubItems.Add(paController.Descricao);
                                listFechamento.SubItems.Add(paController.PesoBruto.ToString("###,###.#0"));
                                listFechamento.SubItems.Add(paController.PesoLiquido.ToString("###,###.#0"));
                                listFechamento.SubItems.Add(paController.Bobinas.ToString("###,###.#0"));

                                listView2.Items.Add(listFechamento);

                                txtNumeroPA.Text = string.Empty;
                                break;
                            }

                        }
                    }
                    else
                    {
                        ListViewItem listFechamento = new ListViewItem(paController.Codigo);
                        listFechamento.SubItems.Add(paController.Descricao);
                        listFechamento.SubItems.Add(paController.PesoBruto.ToString("###,###.#0"));
                        listFechamento.SubItems.Add(paController.PesoLiquido.ToString("###,###.#0"));
                        listFechamento.SubItems.Add(paController.Bobinas.ToString("###,###.#0"));

                        listView2.Items.Add(listFechamento);

                        txtNumeroPA.Text = string.Empty;
                    }
                    for(var i = 0; i < listView2.Items.Count; i++)
                    {
                        listView2.TopItem = listView2.Items[i];
                    }
                }
                else
                {
                    MessageBox.Show("P.A não localizada. Tente alterar o local de estocagem!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }

            txtNumeroPA.Text = string.Empty;

            this.Cursor = Cursors.Default;
        }

        private void btnConectar_Click_1(object sender, EventArgs e)
        {
            loadPA();

        }


        private void btnSomar_Click_1(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            decimal resultadopesoBruto = 0;
            decimal resultadopesoLiquido = 0;
            double resultadoQtBobinas = 0;

            int resultado = -1;
            int resultado2 = listView1.Items.Count;
            int numeroLinha = resultado + resultado2;

            ListViewItem item1 = listView1.Items[numeroLinha];

            if (item1.Text != "Resultado:")
            {
                foreach (ListViewItem item in listView1.Items)
                {
                    decimal pesoBruto = Convert.ToDecimal(item.SubItems[3].Text);
                    decimal pesoLiquido = Convert.ToDecimal(item.SubItems[4].Text);
                    double qtBobinas = Convert.ToDouble(item.SubItems[5].Text);


                    resultadopesoBruto = resultadopesoBruto + pesoBruto;
                    resultadopesoLiquido = resultadopesoLiquido + pesoLiquido;
                    resultadoQtBobinas = resultadoQtBobinas + qtBobinas;

                }

                ListViewItem list = new ListViewItem("Resultado:");
                list.SubItems.Add("");
                list.SubItems.Add("");
                list.SubItems.Add(resultadopesoBruto.ToString("###,###.#0"));
                list.SubItems.Add(resultadopesoLiquido.ToString("###,###.#0"));
                list.SubItems.Add(resultadoQtBobinas.ToString());

                listView1.Items.Add(list);
                for(var i = 0; i < listView1.Items.Count; i++)
                {
                    listView1.TopItem = listView1.Items[i];
                }

            }
            this.Cursor = Cursors.Default;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DateTime dateTime = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            this.Cursor = Cursors.WaitCursor;

            if (listView1.Items.Count > 0 && listView2.Items.Count > 0)
            {
                transferenciaController = new Controller.transferencia.transferenciaController();
                transferenciaController.DataHoraTransf = dateTime.ToString();
                transferenciaController.UsuarioTransf = loginController.Nome;
                transferenciaService.insert(transferenciaController);
                if (transferenciaController.Msg != null)
                {
                    MessageBox.Show(transferenciaController.Msg);
                }
                else
                {
                    transferenciaService.selectId(transferenciaController);
                    if (transferenciaController.Msg != null)
                    {
                        MessageBox.Show(transferenciaController.Msg);
                    }
                    else
                    {
                        Controller.transferencia.movimentacaoController movimentacaoController = new Controller.transferencia.movimentacaoController();
                        movimentacaoController.IdTansferencia = transferenciaController.Id;

                        Controller.transferencia.fechamentoController fechamentoController = new Controller.transferencia.fechamentoController();
                        fechamentoController.IdTransferencia = transferenciaController.Id;

                        foreach (ListViewItem item in listView1.Items)
                        {
                            if (item.SubItems[0].Text != "Resultado:" || item.SubItems[1].Text != string.Empty)
                            {
                                movimentacaoController.NumeroPa = item.SubItems[0].Text;
                                movimentacaoController.Codigo = item.SubItems[1].Text;
                                movimentacaoController.Descricao = item.SubItems[2].Text;
                                movimentacaoController.PesoBruto = item.SubItems[3].Text;
                                movimentacaoController.PesoLiquido = item.SubItems[4].Text;
                                movimentacaoController.Bobinas = item.SubItems[5].Text;
                                movimentacaoController.Usuario = loginController.Nome;

                                movimentacaoService = new Service.transferencia.movimentacaoService();
                                movimentacaoService.insert(movimentacaoController);
                                if (movimentacaoController.Msg != null)
                                {
                                    MessageBox.Show(movimentacaoController.Msg);
                                }

                            }

                        }
                        foreach (ListViewItem item2 in listView2.Items)
                        {
                            fechamentoController.Codigo = item2.SubItems[0].Text;
                            fechamentoController.Descricao = item2.SubItems[1].Text;
                            fechamentoController.PesoBruto = item2.SubItems[2].Text;
                            fechamentoController.PesoLiquido = item2.SubItems[3].Text;
                            fechamentoController.Bobinas = item2.SubItems[4].Text;

                            fechamentoService.insert(fechamentoController);
                            if (fechamentoController.Msg != null)
                            {
                                MessageBox.Show(fechamentoController.Msg);
                            }
                        }

                    }
                    MessageBox.Show("Transferencia realizada com sucesso!", "THR SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView1.Items.Clear();
                    listView2.Items.Clear();

                }

            }
            else
            {
                MessageBox.Show("Não é possivel adicionar uma transferencia com os itens vazios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.Cursor = Cursors.Default;
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            if (listView2.FindItemWithText(listView1.SelectedItems[0].SubItems[1].Text) != null)
            {

                for (var i = 0; i < listView2.Items.Count; i++)
                {
                    if (listView2.Items[i].Text == listView1.SelectedItems[0].SubItems[1].Text)
                    {
                        decimal pesoBrutoMovi = Convert.ToDecimal(listView1.SelectedItems[0].SubItems[3].Text);
                        decimal pesoLiquidoMovi = Convert.ToDecimal(listView1.SelectedItems[0].SubItems[4].Text);
                        decimal qtBobinasMovi = Convert.ToDecimal(listView1.SelectedItems[0].SubItems[5].Text);

                        decimal pesoBrutoFech = Convert.ToDecimal(listView2.Items[i].SubItems[2].Text);
                        decimal pesoLiquidoFech = Convert.ToDecimal(listView2.Items[i].SubItems[3].Text);
                        decimal qtBobinasFech = Convert.ToDecimal(listView2.Items[i].SubItems[4].Text);

                        decimal pesoBrutoResultado = pesoBrutoMovi - pesoBrutoFech;
                        decimal pesoLiquidoResultado = pesoLiquidoMovi - pesoLiquidoFech;
                        decimal qtBobinasResultado = qtBobinasMovi - qtBobinasFech;

                        decimal pesoBrutoTotal = pesoBrutoResultado * -1;
                        decimal pesoLiquidoTotal = pesoLiquidoResultado * -1;
                        decimal qtBobinasTotal = qtBobinasResultado * -1;

                        if (pesoBrutoTotal > 0)
                        {
                            listView2.Items[i].SubItems[2].Text = pesoBrutoTotal.ToString();
                            listView2.Items[i].SubItems[3].Text = pesoLiquidoTotal.ToString();
                            listView2.Items[i].SubItems[4].Text = qtBobinasTotal.ToString();

                            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                        }
                        else
                        {
                            foreach (ListViewItem item in listView2.Items)
                            {
                                if (listView1.SelectedItems[0].SubItems[1].Text == item.SubItems[0].Text)
                                {

                                    item.Selected = true;
                                    listView2.Items.RemoveAt(listView2.SelectedIndices[0]);
                                    listView1.Items.RemoveAt(listView1.SelectedIndices[0]);

                                    break;
                                }


                            }

                        }

                        break;
                    }
                }
            }
            this.Cursor = Cursors.Default;
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            // Modelo.transferenciaController transferenciaController = new Modelo.transferenciaController();

            // transferenciaController.selectId();
            // this.id = transferenciaController.id;
            // transferenciaController.loadFechImp(id);
            // this.dt = transferenciaController.dt;

            // frmImp imp = new frmImp(dt);
            // imp.ShowDialog();


        }

        private void listView1_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if(listView1.SelectedItems.Count > 0)
            {
                btnRemover.Enabled = true;
            }
        }

    }
}
