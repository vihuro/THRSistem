using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;
using SistemaTHR.Apllication;
using System.Threading;

namespace SistemaTHR
{

    public partial class frmLogin : Form
    {

        private Controller.Login.modulosController modulosController;
        private Service.login.loginService service = new Service.login.loginService();
        private Service.modulosService modulosService = new Service.modulosService();
        private frmMenu menu;

        public frmLogin()
        {
            InitializeComponent();

        }


        private void btnEntrar_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Controller.Login.modulosController modulosController = new Controller.Login.modulosController();
            Controller.Login.loginController loginController = new Controller.Login.loginController();

            Controller.Versao.VersionController versao = new Controller.Versao.VersionController();
            Service.Versao.VersaoService versaoService = new Service.Versao.VersaoService();
            versao.NVersao = lblVersao.Text;
            versaoService.verificar(versao);
            if(versao.Msg != null)
            {
                MessageBox.Show(versao.Msg);
            }
            else
            {
                if (versao.Exists)
                {
                    loginController.NomeUsuario = txtNome.Text;
                    loginController.Senha = txtSenha.Text;
                    service.authorized(loginController);

                    if (loginController.Msg != null)
                    {
                        MessageBox.Show(loginController.Msg);
                    }
                    else
                    {
                        if (loginController.Autorizado == true)
                        {

                            modulosController.Usuario = txtNome.Text;
                            modulosService.info(modulosController);
                            if (modulosController.Msg != null)
                            {
                                MessageBox.Show(modulosController.Msg);
                            }
                            else
                            {
                                menu = new frmMenu(loginController, modulosController);
                                this.modulosController = modulosController;
                                hits(loginController);
                                txtNome.Text = string.Empty;

                                txtSenha.Text = string.Empty;
                            }

                        }
                        else
                        {
                            MessageBox.Show("Usuário ou senha inválidos!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Você não está com a versão mais atualizada desse programa. Contate o administrador do sistema!",
                        "Sistema THR",MessageBoxButtons.OK,MessageBoxIcon.Exclamation);
                }
            }


            this.Cursor = Cursors.Default;


        }

        private void hits(Controller.Login.loginController loginController)
        {
            menu.lblUsuario.Text = loginController.NomeUsuario;
            menu.empilhadeirasToolStripMenuItem.Enabled = false;
            menu.recebimentoToolStripMenuItem.Enabled = false;
            menu.expediçãoToolStripMenuItem.Enabled = false;
            menu.gerenciarLoginsToolStripMenuItem.Enabled = false;
            menu.manutençãoToolStripMenuItem.Enabled = false;
            menu.gerencialToolStripMenuItem.Enabled = false;
            menu.produçãoToolStripMenuItem.Enabled = false;
            menu.requisicaoPeçasToolStripMenuItem.Enabled = false;
            menu.estoquePeçasToolStripMenuItem.Enabled = false;
            menu.estoqueToolStripMenuItem1.Enabled = false;
            menu.estoqueToolStripMenuItem.Enabled = false;
            menu.comprasToolStripMenuItem.Enabled = false;
            menu.finalizarSolicitaçãoToolStripMenuItem.Enabled = false;
            menu.solicitaçãoDeMaterialToolStripMenuItem.Enabled = false;
            menu.entradaSaídaToolStripMenuItem.Enabled = false;
            menu.movimentaçãoPeçasToolStripMenuItem1.Enabled = false;
            menu.solicitarManutençãoToolStripMenuItem1.Enabled = false;
            menu.manutençõesEmAbertoToolStripMenuItem.Enabled = false;
            menu.painelSolicitaçãoWindToolStripMenuItem.Enabled = true;


            if (modulosController.Empilhadeiras == "Sim")
            {
                menu.empilhadeirasToolStripMenuItem.Enabled = true;
            }
            if (modulosController.Recebimento == "Sim")
            {
                menu.recebimentoToolStripMenuItem.Enabled = true;
            }
            if (modulosController.Expedicao == "Sim")
            {
                menu.expediçãoToolStripMenuItem.Enabled = true;
            }
            if (modulosController.Adm == "Sim")
            {
                menu.gerenciarLoginsToolStripMenuItem.Enabled = true;
                menu.gerencialToolStripMenuItem.Enabled = true;
            }
            if (modulosController.Manutencao == "Sim")
            {
                menu.manutençãoToolStripMenuItem.Enabled = true;

                if (modulosController.ManutencaoNivel == "5")
                {
                    menu.solicitarManutençãoToolStripMenuItem1.Enabled = false;
                    menu.manutençõesEmAbertoToolStripMenuItem.Enabled = false;
                }
                else
                {
                    menu.solicitarManutençãoToolStripMenuItem1.Enabled = true;
                    menu.manutençõesEmAbertoToolStripMenuItem.Enabled = true;
                }
            }

            if (modulosController.Producao == "Sim")
            {
                menu.produçãoToolStripMenuItem.Enabled = true;
            }
            if (modulosController.ProducaoNivel == "4")
            {
                menu.fichaDeQuarentenaToolStripMenuItem.Enabled = false;
                menu.ControleAnáliseToolStripMenuItem.Enabled = false;
            }
            if (modulosController.Almoxarifado == "Sim")
            {
                if(modulosController.AlmoxarifadoNivel == "2" || 
                    modulosController.AlmoxarifadoNivel == "1" || 
                    modulosController.AlmoxarifadoNivel == "3")
                {
                    menu.estoquePeçasToolStripMenuItem.Enabled = true;
                    menu.movimentaçãoPeçasToolStripMenuItem1.Enabled = true;
                }
                menu.requisicaoPeçasToolStripMenuItem.Enabled = true;
            }
            if (modulosController.Estoque == "Sim")
            {
                menu.estoqueToolStripMenuItem1.Enabled = true;
                if(modulosController.EstoqueNivel != "1")
                {
                    if(modulosController.EstoqueNivel == "4")
                    {
                        menu.solicitaçãoDeMaterialToolStripMenuItem.Enabled = true;
                    }
                    else if(modulosController.EstoqueNivel == "3")
                    {
                        menu.finalizarSolicitaçãoToolStripMenuItem.Enabled = true;
                        menu.entradaSaídaToolStripMenuItem.Enabled = true;
                    }
                }
                else
                {
                    if(modulosController.EstoqueNivel == "2")
                    {
                        menu.estoqueToolStripMenuItem.Enabled = true;
                        menu.finalizarSolicitaçãoToolStripMenuItem.Enabled = true;
                        menu.solicitaçãoDeMaterialToolStripMenuItem.Enabled = true;
                        //menu.estoquePeçasToolStripMenuItem.Enabled = true;
                        menu.entradaSaídaToolStripMenuItem.Enabled = true;
                    }
                    menu.estoqueToolStripMenuItem.Enabled = true;
                    menu.finalizarSolicitaçãoToolStripMenuItem.Enabled = true;
                    menu.solicitaçãoDeMaterialToolStripMenuItem.Enabled = true;
                    //menu.estoquePeçasToolStripMenuItem.Enabled = true;
                    menu.entradaSaídaToolStripMenuItem.Enabled = true;
                }
            }
            if (modulosController.Compras == "Sim")
            {
                menu.manutençãoToolStripMenuItem.Enabled = true;
                menu.requisicaoPeçasToolStripMenuItem.Enabled = true;
                menu.movimentaçãoPeçasToolStripMenuItem1.Enabled = true;
                menu.comprasToolStripMenuItem.Enabled = true;

            }


            this.txtNome.Text = string.Empty;
            this.txtSenha.Text = string.Empty;

            menu.Show();
        }

        private void frmLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }

        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            frmLogin frm = new frmLogin();
            this.Close();
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

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
