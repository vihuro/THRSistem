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
    public partial class frmSolicitarManutencao : Form
    {
        public frmSolicitarManutencao()
        {
            InitializeComponent();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            int totalCaractere = 250;

            foreach(char item in txtDescricao.Text)
            {
                totalCaractere = totalCaractere - 1;
            }
            lblCaractere.Text = "Restam " + totalCaractere + " caracteres";
        }


        private void btnSolicitar_Click(object sender, EventArgs e)
        {
            String emAberto = "Em aberto";

            DateTime dataHora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            if(cboNumeroEmp.Text != string.Empty && cboPrioridade.Text != string.Empty && txtDescricao.Text != string.Empty)
            {
                //Modelo.manutecaoEmpilhadeirasController manutecaoEmpilhadeirasController = new Modelo.manutecaoEmpilhadeirasController();
                //manutecaoEmpilhadeirasController.insertSolicitacao(cboNumeroEmp.Text, txtDescricao.Text, cboPrioridade.Text, emAberto, dataHora, lblUsuario.Text);

                

                MessageBox.Show("Solicitaçao realizada com sucesso!", "Informação", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Close();
            }
            else
            {
                MessageBox.Show("Campos obrigatórios vazio!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSolicitarManutencao_Load(object sender, EventArgs e)
        {

        }

        private void lblCaractere_Click(object sender, EventArgs e)
        {

        }
    }
}
