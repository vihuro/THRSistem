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
    public partial class frmObservacoes : Form
    {
        frmManutencao GManutencao;
        public frmObservacoes(String observaco, frmManutencao manutencao)
        {
            InitializeComponent();
            GManutencao = manutencao;

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            
            GManutencao.txtObservacao.Text = this.txtObservaco.Text;
            this.Close();
        }

        private void txtObservaco_TextChanged(object sender, EventArgs e)
        {
            int totalCaractere = 1000;

            foreach (char item in txtObservaco.Text)
            {
                totalCaractere = totalCaractere - 1;
            }
            lblCaractere.Text = "Caracteres restantes: " + totalCaractere ;
        }

        private void frmObservacoes_Load(object sender, EventArgs e)
        {

        }

        private void lblCaractere_Click(object sender, EventArgs e)
        {

        }
    }
}
