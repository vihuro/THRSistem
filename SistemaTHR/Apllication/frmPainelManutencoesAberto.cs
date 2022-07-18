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
    public partial class frmPainelManutencoesAberto : Form
    {
        public frmPainelManutencoesAberto()
        {
            InitializeComponent();
            loadListView();
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();

        public void loadListView()
        {
            cmd.CommandText = "Select * from tab_Manutencoes order by dataHoraSolicitacao asc";


            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    ListViewItem listItem = new ListViewItem(dr["id"].ToString());

                    listItem.SubItems.Add(dr["numeroEmp"].ToString());
                    listItem.SubItems.Add(dr["prioridade"].ToString());
                    listItem.SubItems.Add(dr["status"].ToString());
                    String dateTime = Convert.ToDateTime(dr["dataHoraSolicitacao"]).ToString("dd/MM/yyy HH:mm:ss");

                    listItem.SubItems.Add(dateTime);

                    listItem.SubItems.Add(dr["usuarioSolicitacao"].ToString());



                    listView1.Items.Add(listItem);


                }
            }
            catch
            {
                dr = null;
            }
        }

        private void listView1_MouseClick(object sender, MouseEventArgs e)
        {
            if(listView1.SelectedIndices.Count > 0)
            {

                int numeroID = int.Parse(listView1.SelectedItems[0].SubItems[0].Text);

                Modelo.manutecaoEmpilhadeirasController manutecaoEmpilhadeirasController = new Modelo.manutecaoEmpilhadeirasController();
                manutecaoEmpilhadeirasController.selectIDTrocaGas(numeroID);

                txtDescricao.Text = manutecaoEmpilhadeirasController.descricao;
            }
        }




        private void listView1_DoubleClick(object sender, EventArgs e)
        {


            frmOrdemServico frmOrdemServico = new frmOrdemServico();
           // frmMenu frmMenu = new frmMenu();
            frmOrdemServico.lblUsuario.Text = this.lblUsuario.Text;
            frmOrdemServico.txtId.Text = listView1.SelectedItems[0].SubItems[0].Text;
            frmOrdemServico.txtNumeroEmp.Text = listView1.SelectedItems[0].SubItems[1].Text;
            frmOrdemServico.Show();
        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
