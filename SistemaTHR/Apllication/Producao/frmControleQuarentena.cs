using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Producao.Impressao
{
    public partial class frmControleQuarentena : Form
    {
        Modelo.Producao.fichaController controller;
        String usuario;
        public frmControleQuarentena(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void frmControleQuarentena_Load(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void loadGridView()
        {
            controller = new Modelo.Producao.fichaController();
            controller.selectAnalise();
            dataGridView1.DataSource = controller.dt;
            if(controller.msg != null)
            {
                MessageBox.Show(controller.msg);
            }
        }
    }
}
