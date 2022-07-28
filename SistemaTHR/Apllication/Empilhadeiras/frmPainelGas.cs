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

namespace SistemaTHR.Apllication
{
    public partial class frmPainelTrocaGas : Form
    {
        public frmPainelTrocaGas()
        {
            InitializeComponent();
            //listViewFinally();
            loadListView();

        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }


        public List<String> numeroEmp = new List<String>();
        public List<String> ultimaTroca = new List<String>();
        public List<String> trocaAtual = new List<String>();

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();


        public void loadListView()
        {
            cmd.CommandText = "Select * from tab_trocaGas order by dataHoraTroca asc";
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    ListViewItem listItem = new ListViewItem(dr["numeroEmp"].ToString());

                    listItem.SubItems.Add(dr["ultimaTroca"].ToString());
                    listItem.SubItems.Add(dr["trocaAtual"].ToString());
                    listItem.SubItems.Add(dr["horasTrabalhadas"].ToString());
                    listItem.SubItems.Add(dr["usuarioTroca"].ToString());

                    String dateTime = Convert.ToDateTime(dr["dataHoraTroca"]).ToString("dd/MM/yyy HH:mm:ss");

                   listItem.SubItems.Add(dateTime);


                    listView1.Items.Add(listItem);


                }
            }
            catch
            {
                dr = null;
            }
        }

        public void listViewFinally()
        {
            loadListView();

            foreach(var list in numeroEmp)
            {

                listView1.Items.Add(list);
            }

        }

        List<String> todos = new List<string>();

        public List<String> loadTrocas()
        {


            return null;
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
