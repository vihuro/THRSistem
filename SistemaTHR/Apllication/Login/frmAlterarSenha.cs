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
        Controller.Login.loginController controller;
        Service.login.loginService service = new Service.login.loginService();
        
        public frmAlterarSenha(Controller.Login.loginController controller)
        {
            InitializeComponent();
            this.controller = controller;
           
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
                    controller.Senha = txtConfirmacao.Text;
                    service.update(controller);
                    if(controller.Msg != null)
                    {
                        MessageBox.Show(controller.Msg);
                    }
                    else
                    {
                        MessageBox.Show("Alteração feita com sucesso!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                }
                else
                {
                    MessageBox.Show("Senha não correspondente!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                    

            }
            else
            {
              MessageBox.Show("Campos vazios!","SISTEMA THR",MessageBoxButtons.OK,MessageBoxIcon.Warning);
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
