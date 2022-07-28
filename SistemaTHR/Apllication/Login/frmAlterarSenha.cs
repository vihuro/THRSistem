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
    public partial class frmAlterarSenha : Form
    {
        String usuario;
        
        public frmAlterarSenha(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void frmAlterarSenha_Load(object sender, EventArgs e)
        {

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(txtSenha.Text != string.Empty && txtConfirmacao.Text != string.Empty)
            {
                if (txtSenha.Text == txtConfirmacao.Text)
                {
                    loginController controller = new loginController();
                    controller.usuario = this.usuario;
                    controller.senha = txtConfirmacao.Text;
                    controller.alterarS();

                    if(controller.menssagem != null)
                    {
                        MessageBox.Show("Erro inesperado. Contate o administrador do sistema. " + controller.menssagem, "SITEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show("Alteração feita com sucesso!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();

                        
                    }

                }
                else
                {
                    MessageBox.Show("Campos não correspondentes!","SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Campo(s) obrigatório(s) vazio(s)!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void frmAlterarSenha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnSenha_Click(object sender, EventArgs e)
        {
            if (txtSenha.PasswordChar.ToString() == "•")
            {
                txtSenha.PasswordChar = '\0';
            }
            else
            {
                txtSenha.PasswordChar = '•';
            }
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            if (txtConfirmacao.PasswordChar.ToString() == "•")
            {
                txtConfirmacao.PasswordChar = '\0';
            }
            else
            {
                txtConfirmacao.PasswordChar = '•';
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
