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

        private Controller.Login.loginController loginController;
        private Controller.Login.modulosController modulosController;


        public frmGerenciarLocaisManu(Controller.Login.loginController loginController, Controller.Login.modulosController modulosController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.modulosController = modulosController;

        }

        private void frmGerenciarLocaisManu_Load(object sender, EventArgs e)
        {
            loadGridView1();
        }

        private void loadGridView1()
        {
            Controller.manutencao.aseController controller = new Controller.manutencao.aseController();
            Service.manutencao.aseService service = new Service.manutencao.aseService();
            service.table(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                dataGridView1.DataSource = controller.Dt;
            }

            for(int i = 0;  i < dataGridView1.Rows.Count; i++)
            {
                if(i == dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[1];
                }
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
            Controller.manutencao.aseController controller = new Controller.manutencao.aseController();
            Service.manutencao.aseService service = new Service.manutencao.aseService();

            controller.Execucao = txtExecucao.Text;
            controller.Usuario = loginController.Nome;
            controller.DataHora = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            service.insert(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                loadGridView1();
            }
          
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            Controller.manutencao.aseController controller = new Controller.manutencao.aseController();
            Service.manutencao.aseService service = new Service.manutencao.aseService();
            controller.Numero = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            service.delete(controller);
            if (controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            clear();
        }

        private void btnNovo_Click(object sender, EventArgs e)
        {
            clear();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;

            if(dataGridView1.SelectedRows.Count > 0)
            {
                txtExecucao.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                btnRemover.Enabled = true;
                
            }
        }

    }
}
