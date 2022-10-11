using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTHR.Controller.Login;
using SistemaTHR.Service.login;

namespace SistemaTHR.Apllication.Gerencial
{
    public partial class frmFiltroUsuarios : Form
    {
        private frmGerenciarLogin gerenciarLogins;
        private loginController controller;
        private loginService service;


        public frmFiltroUsuarios(frmGerenciarLogin gerenciarLogins)
        {
            this.gerenciarLogins = gerenciarLogins;
            InitializeComponent();
            IniciarService();
        }

        private loginService IniciarService()
        {
            return service = new loginService();
        }

        private void frmFiltroUsuarios_Load(object sender, EventArgs e)
        {
            LoadGridView();
        }

        private void LoadGridView()
        {
            controller = new loginController();
            service.Table(controller);
            if(controller.Msg != null)
            {
                MessageBox.Show(controller.Msg, "SITEMA THR", MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else
            {
                dataGridView1.DataSource = controller.Dt;
            }
        }

        private void txtNome_TextChanged(object sender, EventArgs e)
        {
            controller.Dt.DefaultView.RowFilter = string.Format($"[Nome] like '%{txtNome.Text}%'");
            dataGridView1.DataSource = controller.Dt;
        }

        private void btnFechar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            gerenciarLogins.loadDataGridView(txtNome.Text);
            this.Close();

            this.Cursor = Cursors.Default;
        }
    }
}
