using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Producao
{
    public partial class frmEcolhaStatus : Form
    {

        Impressao.frmControleQuarentena controleQuarentena;
        public frmEcolhaStatus(Impressao.frmControleQuarentena controleQuarentena)
        {
            InitializeComponent();
            this.controleQuarentena = controleQuarentena;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            

            this.Close();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
