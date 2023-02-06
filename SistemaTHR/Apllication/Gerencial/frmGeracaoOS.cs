using System;

using System.Windows.Forms;

namespace SistemaTHR.Apllication
{
    public partial class frmGeracaoOS : Form
    {


        public frmGeracaoOS()
        {
            InitializeComponent();
        }


        private void btnAddApont_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnRemovApont_Click(object sender, EventArgs e)
        {



        }

        private void dataGridView3_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadGridView1()
        {



            clear();
        }

        private void loadGridView3()
        {


        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {


        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int i = dataGrid.SelectedRows.Count;
            if (i > 0)
            {


                btnSalvar.Enabled = false;
                btnAtivar.Enabled = true;
                btnInativar.Enabled = true;
            }
        }

        private void btnAtivar_Click(object sender, EventArgs e)
        {

            loadGridView1();
        }

        private void clear()
        {
            
            txtApontamento.Text = string.Empty;

            while (dataGridView3.Rows.Count > 0)
            {
                for (int i = 0; i < dataGridView3.Rows.Count; i++)
                {

                    dataGridView3.Rows.Remove(dataGridView3.Rows[i]);

                }
            }
            dataGridView1.ClearSelection();
            btnSalvar.Enabled = true;
            btnAtivar.Enabled = false;
            btnInativar.Enabled = false;
        }
        private void BtnNovo_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void btnInativar_Click(object sender, EventArgs e)
        {

            loadGridView1();
        }
    }
}
