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
    public partial class frmSelectImp : Form
    {
        String id;
        DataTable dt = new DataTable();
        public frmSelectImp(String id)
        {
            InitializeComponent();
            this.id = id;

        }


        private void btnImprimir_Click(object sender, EventArgs e)
        {
            if(cboSelect.Text == "Fechamento")
            {
                
                Modelo.transferenciaController transferenciaController = new Modelo.transferenciaController();
                transferenciaController.selectFech(id);
                this.dt = transferenciaController.dt;

                frmImp frmImp = new frmImp(dt);
                frmImp.ShowDialog();

            }
            if(cboSelect.Text == "Movimentação")
            {
                Modelo.transferenciaController transferenciaController = new Modelo.transferenciaController();
                transferenciaController.selectMovi(id);
                this.dt = transferenciaController.dt;

                frmImpMovimento frmImp = new frmImpMovimento(dt);
                frmImp.ShowDialog();
            }
        }

    }
}
