using System;
using System.Windows.Forms;
using SistemaTHR.Controller.Login;
using SistemaTHR.Controller.estoque;
using SistemaTHR.Service.estoque;

namespace SistemaTHR.Apllication.Estoque
{
    public partial class frmGrupo : Form
    {
        private loginController loginController;
        private modulosController modulosController;
        private GrupoController controller;
        private GrupoService service = new GrupoService();
        private frmEstoque formulario;

        public frmGrupo(frmEstoque formulario ,loginController loginController , modulosController modulosController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.modulosController = modulosController;
            this.formulario = formulario;
        }

        private void frmGrupo_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void loadGridView()
        {
            controller = new GrupoController();
            service.Table(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                dataGridView1.DataSource = controller.Dt;
            }
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            controller = new GrupoController();
            controller.Grupo = txtDescricaoCadastro.Text;
            controller.UsuarioGravacao = loginController.Nome;
            service.Insert(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                loadGridView();
            }

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                txtDescricaoCadastro.Enabled = false;
                btnCadastrar.Enabled = false;
                btnDeletar.Enabled = true;
                txtDescricaoCadastro.Text = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            }
        }


        private void btnAtivar_Click(object sender, EventArgs e)
        {
            loadGridView();
            dataGridView1.ClearSelection();
            btnCadastrar.Enabled = true;
            txtDescricaoCadastro.Text = string.Empty;
            txtDescricaoCadastro.Enabled = true;
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            controller = new GrupoController();
            controller.Id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            service.Delete(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg);
            }
            else
            {
                loadGridView();
            }

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            controller.Dt.DefaultView.RowFilter = string.Format("[grupo] like '%{0}%'", txtDescricao.Text);

            dataGridView1.DataSource = controller.Dt;
        }

        private void btnCarregar_Click(object sender, EventArgs e)
        {
            formulario.cboGrupo.Items.Clear();
            formulario.cboGrupo.Items.Add("");
            formulario.loadComboBoxGrupo();
            formulario.cboGrupo.Text = txtDescricaoCadastro.Text;
            this.Close();
        }
    }
}
