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
    public partial class frmPainelTransferencias : Form
    {
        String usuario;
        public frmPainelTransferencias(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
 
        }

        DataTable dt = new DataTable();


        private void loadGridView1()
        {
            Modelo.transferenciaController transferenciaController = new Modelo.transferenciaController();
            transferenciaController.selectTransferencia();
            this.dt = transferenciaController.dt;

            dataGridView1.DataSource = dt;
            dataGridView1.DataMember = dt.TableName;


        }

        private void frmPainelTransferencias_Load(object sender, EventArgs e)
        {
            loadGridView1();
        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(e.Value != null && e.Value.Equals("26/06/2022 12:20:43"))
            {
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ToString();
            }

            if (e.Value != null && e.Value.Equals("vitor"))
            {

                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkRed;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionForeColor = Color.BlueViolet;
                dataGridView1.Rows[e.RowIndex].DefaultCellStyle.SelectionBackColor = Color.Black;
                
            }
        }
        String idSelecionado;
        String usuarioMovimentacao;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGridView = (DataGridView)sender;
            int i = dataGridView.SelectedRows.Count;

            if(i > 0)
            {
                idSelecionado = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
                usuarioMovimentacao = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[2].Value.ToString();
                loadDataGridView2();
                loadDataGridView3();
            }
            
        }


        private void loadDataGridView2() 
        {
            Modelo.transferenciaController transferenciaController = new Modelo.transferenciaController();
            transferenciaController.selectMovi(idSelecionado);
            this.dt = transferenciaController.dt;

            dataGridView2.DataSource = dt;
            dataGridView2.DataMember = dt.TableName;
           // loadStyleGridView2();
        }

        private void loadDataGridView3()
        {
            Modelo.transferenciaController transferencia = new Modelo.transferenciaController();
            transferencia.selectFech(idSelecionado);
            this.dt = transferencia.dt;

            dataGridView3.DataSource = dt;

        }





        private void btnEditar_Click(object sender, EventArgs e)
        {
            frmEditarTransferencia frmEditarTransferencia = new frmEditarTransferencia(idSelecionado,usuario);

            frmEditarTransferencia.Show();
        }

        

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            frmSelectImp selectImp = new frmSelectImp(idSelecionado);
            selectImp.ShowDialog();
        }

        private void btnFiltro_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
