using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Manutencao
{
    public partial class frmAsu : Form
    {
        Controller.Login.loginController loginController;
        Controller.Login.modulosController modulosController;
        public frmAsu(Controller.Login.loginController loginController, Controller.Login.modulosController modulosController)
        {
            this.loginController = loginController;
            this.modulosController = modulosController;
            InitializeComponent();
        }

        private void frmAsu_Load(object sender, EventArgs e)
        {
            loadGridView();
            clearAll();
        }

        private void clearAll()
        {
            txtAsu.Text = string.Empty;
            txtCodigo.Text = string.Empty;
            btnCancelar.Enabled = false;
            dataGridView1.ClearSelection();
        }

        private void loadGridView()
        {
            this.Cursor = Cursors.WaitCursor;
            Controller.manutencao.asuController controller = new Controller.manutencao.asuController();
            Service.manutencao.asuService service = new Service.manutencao.asuService();
            service.table(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                dataGridView1.DataSource = controller.Dt;
            }

            this.Cursor = Cursors.Default;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            if (txtAsu != null)
            {
                Controller.manutencao.asuController controller = new Controller.manutencao.asuController();
                Service.manutencao.asuService service = new Service.manutencao.asuService();
                controller.Asu = txtAsu.Text;
                controller.UsuarioGravao = loginController.Nome;
                controller.DataHoraGravacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                service.insert(controller);
                if (controller.Msg != null)
                {
                    MessageBox.Show(controller.Msg);
                }
                else
                {
                    loadGridView();
                    clearAll();
                }
            }
            else
            {
                MessageBox.Show("Campo obrigatório em branco!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


            this.Cursor = Cursors.Default;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Controller.manutencao.asuController controller = new Controller.manutencao.asuController();
            Service.manutencao.asuService service = new Service.manutencao.asuService();
            controller.Codigo = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            service.delete(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                loadGridView();
                clearAll();
            }
            this.Cursor = Cursors.Default;
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            for(int i = 0; i < dataGridView1.SelectedRows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;
                btnCancelar.Enabled = true;
                txtCodigo.Text = dataGridView1.SelectedRows[i].Cells[0].Value.ToString();
                txtAsu.Text = dataGridView1.SelectedRows[i].Cells[1].Value.ToString();
            }
        }
    }
}
