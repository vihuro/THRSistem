using SistemaTHR.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;

namespace SistemaTHR.Apllication
{
    public partial class frmTeste : Form
    {
        public frmTeste()
        {
            InitializeComponent();
            //loadGradeView();

            trocaGas();
        }

        public void loadGradeView()
        {

            

            

            //dataGridView1.Rows.Clear();
            //dataGridView1.Columns.Clear();
            //dataGridView1.ColumnCount = 7;

            dataGridView1.Columns[0].Name = "id";
            dataGridView1.Columns[1].Name = "numeroEmp";
            dataGridView1.Columns[2].Name = "ultimaTroca";
            dataGridView1.Columns[3].Name = "TrocaAtual";
            dataGridView1.Columns[4].Name = "HorasTrabalhadas";
            dataGridView1.Columns[5].Name = "dataHoraTroca";
            dataGridView1.Columns[6].Name = "UsuarioTroca";

            dataGridView1.Columns["id"].HeaderText = "ID";
            dataGridView1.Columns["numeroEmp"].HeaderText = "Numero Empilhadeira";
            dataGridView1.Columns["ultimaTroca"].HeaderText = "Ultima Troca";
            dataGridView1.Columns["TrocaAtual"].HeaderText = "Troca Atual";
            dataGridView1.Columns["HorasTrabalhadas"].HeaderText = "Horas Trabalhadas";
            dataGridView1.Columns["dataHoraTroca"].HeaderText = "Data/Hora Troca";
            dataGridView1.Columns["UsuarioTroca"].HeaderText = "Usuário Troca";

            dataGridView1.Columns["id"].Visible = false;

        }


        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds;

        private void trocaGas()
        {
            OleDbCommand cmd = new OleDbCommand();
            OleDbDataReader dr;
            Connection con = new Connection();

            DataSet ds;
            //DataTable dt = new DataTable();


            cmd.CommandText = "Select * from tab_trocaGas order by dataHoraTroca asc";


                //con.conectar();
                cmd.Connection = con.conectar();


                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                DataTable dt = new DataTable();

                da.Fill(dt);

            dataGridView1.DataSource = dt;

            dataGridView1.DataMember = dt.TableName;
            loadGradeView();

            /*da = new OleDbDataAdapter(cmd);

            dt.Load(dr);*/



        }



        private void frmTeste_Load(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
