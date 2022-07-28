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
    public partial class frmGerenciarLocaisManu : Form
    {
        String numero;
        String usuario;
        Modelo.aseController controller;
        public DataTable dt;
        DateTime dataHora;
        public frmGerenciarLocaisManu(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void frmGerenciarLocaisManu_Load(object sender, EventArgs e)
        {
            loadGridView1();
        }

        private void loadGridView1()
        {
            controller = new Modelo.aseController();
            controller.selectEx();
            this.dt = controller.dt;

            dataGridView1.DataSource = dt;

            if(controller.msg != null)
            {
                MessageBox.Show(controller.msg);
            }

            dataGridView1.ClearSelection();
            txtExecucao.Text = string.Empty;
            btnRemover.Enabled = false;

        }


        private void clear()
        {
            loadGridView1();
            txtExecucao.Text = string.Empty;
            btnRemover.Enabled = false;
            
        }
        private void btnSalvar_Click(object sender, EventArgs e)
        {
            dataHora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

            controller = new Modelo.aseController();
            controller.execucao = txtExecucao.Text;
            controller.verificar();
            if(controller.tem == false)
            {
                controller = new Modelo.aseController();
                controller.execucao = this.txtExecucao.Text;
                controller.usuarioCadastro = this.usuario;
                controller.dataHoraCadastro = Convert.ToString(dataHora);
                controller.insertEx();
                if (controller.msg != null)
                {
                    MessageBox.Show(controller.msg);
                }
                clear();
            }
            else
            {
                MessageBox.Show("Já existe um local de execução com esse nome!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }



        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            numero = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();
            controller = new Modelo.aseController();
            controller.numero = this.numero;
            controller.deleteEx();
            if (controller.msg != null)
            {
                MessageBox.Show(controller.msg);
            }
            clear();
        }

        private void splitContainer1_SplitterMoved(object sender, SplitterEventArgs e)
        {

        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


            if(dataGridView1.SelectedRows.Count > 0)
            {
                txtExecucao.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                btnRemover.Enabled = true;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
