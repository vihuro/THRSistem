
using System;
using System.Data;
using System.Windows.Forms;


namespace SistemaTHR.Apllication
{
    public partial class frmTransferencia : Form
    {
        String usuario;
        public frmTransferencia(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;

        }

        private void txtNumeroPA_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                if (listView1.Items.Count == 0)
                {
                    loadPA();

                }
                else
                {
                    int resultado = -1;
                    int resultado2 = listView1.Items.Count;
                    int numeroLinha = resultado + resultado2;

                    ListViewItem item1 = listView1.Items[numeroLinha];

                    if (item1.Text == "Resultado:")
                    {
                        alterarResultado();
                    }
                    else
                    {
                        loadPA();
                    }


                }
            }
        }

        public void alterarResultado()
        {


            if (rdbProducao.Checked == true)
            {
                Modelo.loadPaController loadPaController = new Modelo.loadPaController();
                loadPaController.selectPA(txtNumeroPA.Text);

                if (loadPaController.codigo != null)
                {
                    this.codigo = loadPaController.codigo;
                    this.descricao = loadPaController.descricao;
                    this.pesoBruto = loadPaController.pesoBruto.ToString("###,###.#0");
                    this.pesoLiquido = loadPaController.pesoLiquido.ToString("###,###.#0");
                    this.qtBobinas = loadPaController.qtBobinas.ToString();
                }
            }
            if (rdbExpedicao.Checked == true)
            {
                Modelo.loadPaController loadPaController = new Modelo.loadPaController();
                loadPaController.selectExp(txtNumeroPA.Text);

                if (loadPaController.codigo != null)
                {

                    this.codigo = loadPaController.codigo;
                    this.descricao = loadPaController.descricao;
                    this.pesoBruto = loadPaController.pesoBruto.ToString("###,###.#0");
                    this.pesoLiquido = loadPaController.pesoLiquido.ToString("###,###.#0");
                    this.qtBobinas = loadPaController.qtBobinas.ToString();
                }
            }

            int i2 = listView1.Items.Count;

            ListViewItem item1 = listView1.Items[i2 -1];

            if (item1.Text == "Resultado:")
            {
                item1.Text = txtNumeroPA.Text;
                item1.SubItems[1].Text = this.codigo;
                item1.SubItems[2].Text = this.descricao;
                item1.SubItems[3].Text = this.pesoBruto;
                item1.SubItems[4].Text = this.pesoLiquido;
                item1.SubItems.Add(this.qtBobinas);

                if (codigo != null)
                {
                    if (listView2.FindItemWithText(codigo) != null)
                    {
                        for (var i = 0; i < listView2.Items.Count; i++)
                        {
                            if (listView2.Items[i].Text == codigo)
                            {
                                decimal pesoBruto = Convert.ToDecimal(listView2.Items[i].SubItems[2].Text);
                                decimal pesoLiquido = Convert.ToDecimal(listView2.Items[i].SubItems[3].Text);

                                decimal BrutoLoadPa = Convert.ToDecimal(this.pesoBruto);
                                decimal LiquidoLoadPa = Convert.ToDecimal(this.pesoLiquido);

                                decimal resultadoBruto = pesoBruto + BrutoLoadPa;
                                decimal resultadoLiquido = pesoLiquido + LiquidoLoadPa;

                                listView2.Items[i].SubItems[2].Text = resultadoBruto.ToString("###,###.#0");
                                listView2.Items[i].SubItems[3].Text = resultadoLiquido.ToString("###,###.#0");

                                txtNumeroPA.Text = string.Empty;


                                break;
                            }
                        }
                    }
                    else
                    {
                        ListViewItem listFechamento = new ListViewItem(this.codigo);
                        listFechamento.SubItems.Add(this.descricao);
                        listFechamento.SubItems.Add(this.pesoBruto);
                        listFechamento.SubItems.Add(this.pesoLiquido);
                        listFechamento.SubItems.Add(this.qtBobinas);

                        listView2.Items.Add(listFechamento);


                    }
                }

            }

            txtNumeroPA.Text = string.Empty;

            this.codigo = null;
            this.descricao = null;
            this.pesoBruto = null;
            this.pesoLiquido = null;
            this.qtBobinas = null;
        }

        private String codigo;
        private String descricao;
        private String pesoBruto;
        private String pesoLiquido;
        private String qtBobinas;

        public void loadPA()
        {
            if(rdbProducao.Checked == true)
            {
                Modelo.loadPaController loadPaController = new Modelo.loadPaController();
                loadPaController.selectPA(txtNumeroPA.Text);
                if (loadPaController.codigo != null)
                {
                    this.codigo = loadPaController.codigo;
                    this.descricao = loadPaController.descricao;
                    this.pesoBruto = loadPaController.pesoBruto.ToString("###,###.#0");
                    this.pesoLiquido = loadPaController.pesoLiquido.ToString("###,###.#0");
                    this.qtBobinas = loadPaController.qtBobinas.ToString();
                }
            }
            if(rdbExpedicao.Checked == true)
            {
                Modelo.loadPaController loadPaController = new Modelo.loadPaController();
                loadPaController.selectExp(txtNumeroPA.Text);
               
                if (loadPaController.codigo != null)
                {

                    this.codigo = loadPaController.codigo;
                    this.descricao = loadPaController.descricao;
                    this.pesoBruto = loadPaController.pesoBruto.ToString("###,###.#0");
                    this.pesoLiquido = loadPaController.pesoLiquido.ToString("###,###.#0");
                    this.qtBobinas = loadPaController.qtBobinas.ToString();
                }
            }

            if(codigo!= null)
            {
                ListViewItem list = new ListViewItem(txtNumeroPA.Text);

                list.SubItems.Add(codigo);
                list.SubItems.Add(descricao);
                list.SubItems.Add(pesoBruto);
                list.SubItems.Add(pesoLiquido);
                list.SubItems.Add(qtBobinas);

                listView1.Items.Add(list);

            }
            else
            {
                MessageBox.Show("P.A inválida. Tente alterar o local de estocagem!", "THR SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                 if(codigo != null)
                {
                    if (listView2.FindItemWithText(codigo) != null)
                    {
                        for (var i = 0; i < listView2.Items.Count; i++)
                        {
                            if (listView2.Items[i].Text == codigo)
                            {
                                decimal pesoBruto = Convert.ToDecimal(listView2.Items[i].SubItems[2].Text);
                                decimal pesoLiquido = Convert.ToDecimal(listView2.Items[i].SubItems[3].Text);
                                double qtBobinas = Convert.ToDouble(listView2.Items[i].SubItems[4].Text);
                                
                                decimal BrutoLoadPa = Convert.ToDecimal(this.pesoBruto);
                                decimal LiquidoLoadPa = Convert.ToDecimal(this.pesoLiquido);
                                double qtbobinasPa = Convert.ToDouble(this.qtBobinas);
                                
                                decimal resultadoBruto = pesoBruto + BrutoLoadPa;
                                decimal resultadoLiquido = pesoLiquido + LiquidoLoadPa;
                                double resultadoQtBobinas = qtBobinas + qtbobinasPa;

                                
                                listView2.Items[i].SubItems[2].Text = resultadoBruto.ToString("###,###.#0");
                                listView2.Items[i].SubItems[3].Text = resultadoLiquido.ToString("###,###.#0");
                                listView2.Items[i].SubItems[4].Text = resultadoQtBobinas.ToString("###,###.#0");

                                txtNumeroPA.Text = string.Empty;


                                break;
                            }
                        }
                    }
                    else
                    {
                        ListViewItem listFechamento = new ListViewItem(codigo);
                        listFechamento.SubItems.Add(descricao);
                        listFechamento.SubItems.Add(this.pesoBruto);
                        listFechamento.SubItems.Add(this.pesoLiquido);
                        listFechamento.SubItems.Add(this.qtBobinas);

                        listView2.Items.Add(listFechamento);

                        txtNumeroPA.Text = string.Empty;
                    }
                
                 }


            txtNumeroPA.Text = string.Empty;

            this.codigo = null;
            this.descricao = null;
            this.pesoBruto = null;
            this.pesoLiquido = null;
            this.qtBobinas = null;
        }

    private void btnConectar_Click_1(object sender, EventArgs e)
        {

            if (listView1.Items.Count == 0)
            {
                loadPA();

            }
            else
            {
                int resultado = -1;
                int resultado2 = listView1.Items.Count;
                int numeroLinha = resultado + resultado2;

                ListViewItem item1 = listView1.Items[numeroLinha];

                if (item1.Text == "Resultado:")
                {
                    alterarResultado();
                }
                else
                {
                    loadPA();
                }


            }

        }

        public void alterarFechamento()
        {
            double totalPesoBruto;

            int quantidadeDeLinhas = listView2.Items.Count;

            totalPesoBruto = 0;

            double resultadopesoBruto = 0;
            double resultadopesoLiquido = 0;



            foreach (ListViewItem item in listView1.Items)
            {
                double pesoBruto = Convert.ToDouble(item.SubItems[3].Text);
                double pesoLiquido = Convert.ToDouble(item.SubItems[4].Text);
                double resultadopesoBruto1 = 0;
                double resultadopesoLiquido1 = 0;

                resultadopesoBruto = resultadopesoBruto + pesoBruto;
                resultadopesoLiquido = resultadopesoLiquido + pesoLiquido;


                resultadopesoBruto1 = resultadopesoBruto;
                resultadopesoLiquido1 = resultadopesoLiquido;

            }

            ListViewItem list = new ListViewItem("Resultado:");
            list.SubItems.Add("");
            list.SubItems.Add("");
            list.SubItems.Add(resultadopesoBruto.ToString("##,#0"));
            list.SubItems.Add(resultadopesoLiquido.ToString("##,#0"));



            listView1.Items.Add(list);
            

        }
        private void txtNumeroPA_KeyUp_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (listView1.Items.Count == 0)
                {
                    loadPA();

                }
                else
                {
                    int i = listView1.Items.Count;


                    ListViewItem item1 = listView1.Items[i - 1];

                    if (item1.Text == "Resultado:")
                    {

                        alterarResultado();
                    }
                    else
                    {

                        loadPA();
                    }


                }
            }

        }

        private void btnSomar_Click_1(object sender, EventArgs e)
        {


            int quantidadeDeLinhas = listView1.Items.Count;

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

            }

        }
        
        String id;
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DateTime dateTime = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

            if (listView1.Items.Count > 0 && listView2.Items.Count > 0) 
            {
                Modelo.transferenciaController transferenciaController = new Modelo.transferenciaController();


                    transferenciaController.insert(dateTime, usuario); ;
                    transferenciaController.selectId();
                    this.id = transferenciaController.id;


                    foreach (ListViewItem item in listView1.Items)
                    {
                        if (item.SubItems[0].Text != "Resultado:" || item.SubItems[1].Text != string.Empty)
                        {
                            String numeroPA = item.SubItems[0].Text;
                            String codigo = item.SubItems[1].Text;
                            String descricao = item.SubItems[2].Text;
                            String pesoBruto = item.SubItems[3].Text;
                            String pesoLiquido = item.SubItems[4].Text;
                            String bobinas = item.SubItems[5].Text;
                            String idTransferencia = this.id;

                            transferenciaController.insertMov(numeroPA, codigo, descricao, pesoBruto, pesoLiquido, bobinas, idTransferencia, usuario);
                        }


                    }
                    foreach (ListViewItem item2 in listView2.Items)
                    {
                        this.codigo = item2.SubItems[0].Text;
                        this.descricao = item2.SubItems[1].Text;
                        this.pesoBruto = item2.SubItems[2].Text;
                        this.pesoLiquido = item2.SubItems[3].Text;
                        this.qtBobinas = item2.SubItems[4].Text;

                        String idTransferencia = this.id;

                        transferenciaController.codigo = this.codigo;
                        transferenciaController.descricao = this.descricao;
                        transferenciaController.pesoBruto = this.pesoBruto;
                        transferenciaController.pesoLiquido = this.pesoLiquido;
                        transferenciaController.bobinas = this.qtBobinas;
                        transferenciaController.idTransferencia = idTransferencia;

                        transferenciaController.InsertFechamento();

                    }

                    MessageBox.Show("Transferencia realizada com sucesso!", "THR SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    listView1.Items.Clear();
                    listView2.Items.Clear();


                


            }
            else
            {
                MessageBox.Show("Não é possivel adicionar uma transferencia com os itens vazios!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnRemover_Click(object sender, EventArgs e)
        {

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

                        if(pesoBrutoTotal > 0)
                        {
                            listView2.Items[i].SubItems[2].Text = pesoBrutoTotal.ToString();
                            listView2.Items[i].SubItems[3].Text = pesoLiquidoTotal.ToString();
                            listView2.Items[i].SubItems[4].Text = qtBobinasTotal.ToString();

                            listView1.Items.RemoveAt(listView1.SelectedIndices[0]);
                        }
                        else
                        {
                            foreach(ListViewItem item in listView2.Items)
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
              
        }

        DataTable dt = new DataTable();




        private void btnImprimir_Click(object sender, EventArgs e)
        {

            Modelo.transferenciaController transferenciaController = new Modelo.transferenciaController();

            transferenciaController.selectId();
            this.id = transferenciaController.id;
            transferenciaController.loadFechImp(id);
            this.dt = transferenciaController.dt;

            frmImp imp = new frmImp(dt);
            imp.ShowDialog();
            

        }

        private void splitContainer3_Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtNumeroPA_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
