using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTHR.Controller.Producao;
using SistemaTHR.Service.Producao;

namespace SistemaTHR.Apllication.Producao
{
    public partial class frmOrdensProdução : Form
    {
        DataTable dt;

        public frmOrdensProdução()
        {
            InitializeComponent();

        }

        private void frmOrdensProdução_Load(object sender, EventArgs e)
        {

            dataGridView1.DataSource = dt;

            var dataTable = ObterDados();

            
            for(int i =0; i < dataTable.Rows.Count; i++)
            {
                if(i > 0)
                {
                    dataGridView1.DataSource = dataTable;
                }

            }

            dataGridView1.Columns["chave"].Visible = false;
            dataGridView1.Columns["OrdemProducaoChaveMae"].Visible = false;
            // dataGridView1.DataSource = ObterDados();
            //LoadGridView();

            verificarDados();
        }

        private void verificarDados()
        {
            DataTable novaDataTable = new DataTable();
            novaDataTable = (DataTable)dataGridView1.DataSource;

            var linhaLida = novaDataTable.Select("OP = '0521-000567'");

           // MessageBox.Show(linhaLida[0]["Código"].ToString());

        }

        private DataTable MontarDataTable()
        {
            var dt = (DataTable)dataGridView1.DataSource;

            return dt;
        }

        private void LoadGridView()
        {
            StreamReader txt = new StreamReader(@"\\192.168.2.137\estoque\testeop.txt", Encoding.GetEncoding("ISO-8859-1"), true);

            string linha;
            string[] campo;
            try
            {


                    while ((linha = txt.ReadLine()) != null)
                    {

                    campo = linha.Replace("\"", "").Split('|');
                    //campo = linha.Split('|');
                        //linha.Replace("\"", "");
                        dataGridView1.Rows.Add(campo);
                    }



            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }




        }

        public DataTable ObterDados()
        {

            DataTable dt = new DataTable("Ordem de Producao");

            dt.Columns.Add("OP",typeof(string));
            dt.Columns.Add("Chave", typeof(string));
            dt.Columns.Add("Situação/Prod.", typeof(string));
            dt.Columns.Add("OrdemProducaoChaveMae", typeof(string));
            dt.Columns.Add("Cliente", typeof(string));
            dt.Columns.Add("Nº/Pedido", typeof(string));
            dt.Columns.Add("Emissão", typeof(string));
            dt.Columns.Add("Código", typeof(string));
            dt.Columns.Add("Descrição", typeof(string));
            dt.Columns.Add("Qtd/Progr.", typeof(string));
            dt.Columns.Add("Proc.Descrição", typeof(string));
            dt.Columns.Add("Prev/Ini.", typeof(string));
            dt.Columns.Add("Prev/Conc.", typeof(string));
            dt.Columns.Add("Rel/Ini.", typeof(string));
            dt.Columns.Add("Rel/Conc", typeof(string));
            dt.Columns.Add("Situação", typeof(string));

            try
            {
                using (var sr = new StreamReader(@"\\192.168.2.137\estoque\testeop.txt",Encoding.GetEncoding("ISO-8859-1"), true))
                {
                    var linha = "";
                    var lerLinha = sr.ReadLine();

                    while ((linha = sr.ReadLine()) != null)
                    {
                        //lerLinha.Replace("\"", "");
                        var col = linha.Replace("\"","").Split('|');

                        dt.Rows.Add(col);
                    }
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.ToString());
            }

            return dt;
        }


        public string OpMae { get; set; }
        public string OrdemProducaoOpSituacao { get; set; }
        public string OrdemProducaoChaveOpMae { get; set; }
        public string ItemNomeCliente { get; set; }
        public string NumeroPedido { get; set; }
        public string DataEmissao { get; set; }
        public string CodigoMaterial { get; set; }
        public string DescricaoMaterial { get; set; }
        public string ProcDescricao { get; set; }
        public string PrevisaoInicio { get; set; }
        public string PrevisaoConclusao { get; set; }
        public string RealizadoInicio { get; set; }
        public string RealizadoConclusao { get; set; }
        public string Situacao { get; set; }

        private void button1_Click(object sender, EventArgs e)
        {
            OrdensProducaoController controller = new OrdensProducaoController();
            OrdenProducaoService service = new OrdenProducaoService();
            service.VerificarLote(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                MessageBox.Show("Achei o código " + controller.CodigoMaterial);
            }
        }
    }
}
