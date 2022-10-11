using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Gerencial
{
    public partial class frmGerenciarPrioridade : Form
    {


        private Controller.Login.loginController loginController;
        private Controller.Login.modulosController modulosController;
        public frmGerenciarPrioridade(Controller.Login.loginController loginController, Controller.Login.modulosController modulosController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.modulosController = modulosController;
        }

        private void frmGerenciarPrioridade_Load(object sender, EventArgs e)
        {
            loadGridView();
            txtPrioridade.Text = string.Empty;
            btnExcluir.Enabled = false;
        }

        private void loadGridView()
        {
            Controller.manutencao.prioridadeManController controller = new Controller.manutencao.prioridadeManController();
            Service.manutencao.prioridadeManService service = new Service.manutencao.prioridadeManService();
            service.Table(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                dataGridView1.DataSource = controller.Dt;
            }
            
            dataGridView1.ClearSelection();
        }

        private void clearAll()
        {
            loadGridView();
            txtPrioridade.Text = string.Empty;
            btnSalvar.Enabled = false;
            btnExcluir.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {

            clearAll();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            DateTime dataHora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss"));
            if(txtPrioridade.Text != string.Empty)
            {
                Controller.manutencao.prioridadeManController controller = new Controller.manutencao.prioridadeManController();
                Service.manutencao.prioridadeManService service = new Service.manutencao.prioridadeManService();
                controller.Prioridade = txtPrioridade.Text;
                controller.UsuarioGravacao = loginController.Nome;
                controller.DataHoraGravacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy hh:mm:ss"));
                service.insert(controller);
                if(controller.Msg != null)
                {
                    MessageBox.Show(controller.Msg);
                }
                else
                {
                    clearAll();
                }
               
            }
            else
            {
                MessageBox.Show("Campo PRIORIDADE, vazio! Não é possivel salvar uma prioridade nula!","SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                txtPrioridade.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                btnExcluir.Enabled = true;   
            }
            
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            Controller.manutencao.prioridadeManController controller = new Controller.manutencao.prioridadeManController();
            Service.manutencao.prioridadeManService service = new Service.manutencao.prioridadeManService();
            controller.Codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            service.delete(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                clearAll();
            }

        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                dataGridView1.DefaultCellStyle.SelectionBackColor = Color.Black;
                dataGridView1.DefaultCellStyle.SelectionForeColor = Color.White;
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
