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
    public partial class frmOrdemServico : Form
    {
        public frmOrdemServico()
        {
            InitializeComponent();
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            int totalCaractere = 250;

            foreach (char item in txtDescricao.Text)
            {
                totalCaractere = totalCaractere - 1;
            }
            lblCaractere.Text = "Restam " + totalCaractere + " caracteres";
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
         

            if(this.radioButton1.Checked == true)
            {
                MessageBox.Show(radioButton1.Text);
            }
            if(this.radioButton2.Checked == true)
            {
                MessageBox.Show(radioButton2.Text);
            }


        }
    }
}
