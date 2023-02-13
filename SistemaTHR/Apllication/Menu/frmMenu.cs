using SistemaTHR.Apllication.Estoque;
using SistemaTHR.Apllication.Manutencao;
using SistemaTHR.Apllication.Producao;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication
{
    public partial class frmMenu : Form
    {

        Controller.Login.modulosController modulosController;
        Controller.Login.loginController loginController;

        public frmMenu(Controller.Login.loginController loginController, Controller.Login.modulosController modulosController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.modulosController = modulosController;
        }

       private void empilhadeira1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmTrocaGas frmTrocaGas = new frmTrocaGas();
            frmTrocaGas.lblNumeroEmp.Text = "1";
            frmTrocaGas.lblUsuario.Text = this.lblUsuario.Text;
            frmTrocaGas.Show();
            this.Cursor = Cursors.Default;
        }

        private void empilhadeira2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmTrocaGas frmTrocaGas = new frmTrocaGas();
            frmTrocaGas.lblNumeroEmp.Text = "2";
            frmTrocaGas.lblUsuario.Text = this.lblUsuario.Text;
            frmTrocaGas.Show();
            this.Cursor = Cursors.Default;
        }

        private void empilhadeira3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmTrocaGas frmTrocaGas = new frmTrocaGas();
            frmTrocaGas.lblNumeroEmp.Text = "3";
            frmTrocaGas.lblUsuario.Text = this.lblUsuario.Text;
            frmTrocaGas.Show();
            this.Cursor = Cursors.Default;

        }

        private void empilhadeira3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmTrocaGas frmTrocaGas = new frmTrocaGas();
            frmTrocaGas.lblNumeroEmp.Text = "4";
            frmTrocaGas.lblUsuario.Text = this.lblUsuario.Text;
            frmTrocaGas.Show();
            this.Cursor = Cursors.Default;

        }

        private void empilhadeira3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmTrocaGas frmTrocaGas = new frmTrocaGas();
            frmTrocaGas.lblNumeroEmp.Text = "5";
            frmTrocaGas.lblUsuario.Text = this.lblUsuario.Text;
            frmTrocaGas.Show();
            this.Cursor = Cursors.Default;

        }

        private void trocaGásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmPainelTrocaGas frmPainelTrocaGas = new frmPainelTrocaGas();
            frmPainelTrocaGas.Show();
            this.Cursor = Cursors.Default;
        }

        private void solicitarManutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmSolicitarManutencao frmSolicitarManutencao = new frmSolicitarManutencao();
            frmSolicitarManutencao.lblUsuario.Text = this.lblUsuario.Text;
            frmSolicitarManutencao.ShowDialog();
            this.Cursor = Cursors.Default;
        }

        private void manutenççõesEmAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmPainelManutencoesAberto frmPainelManutencoesAberto = new frmPainelManutencoesAberto();
            frmPainelManutencoesAberto.lblUsuario.Text = this.lblUsuario.Text;
     
            frmPainelManutencoesAberto.Show();
            this.Cursor = Cursors.Default;
        }



        private void transfêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmTransferencia frmTransferencia = new frmTransferencia(this.loginController, this.modulosController);
            frmTransferencia.lblUsuario.Text = this.lblUsuario.Text;
            frmTransferencia.Show();
            this.Cursor = Cursors.Default;

        }

        private void gerenciarLoginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmGerenciarLogin gerenciarLogin = new frmGerenciarLogin(loginController,modulosController);
            gerenciarLogin.Show();

            this.Cursor = Cursors.Default;
        }
         

        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmManutencao manutencao = new frmManutencao(this.loginController, this.modulosController);
            manutencao.lblUsuario.Text = this.lblUsuario.Text;

            this.Cursor = Cursors.Default;

        }

        private void solicitarManutençãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmSolicitarManutencaoTHR frmSolicitar = new frmSolicitarManutencaoTHR(this.loginController);
            frmSolicitar.lblUsuario.Text = this.lblUsuario.Text;
            frmSolicitar.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        private void manutençõesEmAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmManutencao manutencao = new frmManutencao(this.loginController,this.modulosController);
            manutencao.lblUsuario.Text = this.lblUsuario.Text;
            manutencao.Show();

            this.Cursor = Cursors.Default;
        }


        private void painelManutençõesmEmAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmPainelManutencoesTHR painel = new frmPainelManutencoesTHR();
            painel.Show();

            this.Cursor = Cursors.Default;
        }



        private void paínesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmPainelTransferencias frmPainelTransferencias = new frmPainelTransferencias(this.loginController, this.modulosController);

            frmPainelTransferencias.btnEditar.Enabled = false;
            frmPainelTransferencias.lblUsuario.Text = this.lblUsuario.Text;

            if (modulosController.ExpNivel == "1")
            {
                frmPainelTransferencias.btnEditar.Enabled = true;
            }


            frmPainelTransferencias.Show();

            this.Cursor = Cursors.Default;
        }



        private void alterarSenhaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmAlterarSenha alterarSenha = new frmAlterarSenha(this.loginController);
            alterarSenha.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        private void gerenciarLocaisDeManutençãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmGerenciarLocaisManu manutencao = new frmGerenciarLocaisManu(this.loginController, this.modulosController);
            manutencao.lblUsuario.Text = this.lblUsuario.Text;
            manutencao.Show();

            this.Cursor = Cursors.Default;
        }

        private void gerenciarApontamentosdeOSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmGeracaoOS geracao = new frmGeracaoOS();
            geracao.Show();

            this.Cursor = Cursors.Default;
        }

        private void fichaDeQuarentenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Apllication.Produção.frmFichaQuarentena quarentena = new Produção.frmFichaQuarentena(this.loginController, this.modulosController);
            quarentena.lblUsuario.Text = this.lblUsuario.Text;
            quarentena.ShowDialog();

            this.Cursor = Cursors.Default;
        }

        private void painelDeQuarentenaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Producao.frmPainelQuarentena painel = new Producao.frmPainelQuarentena();
            painel.Show();

            this.Cursor = Cursors.Default;
        }

        private void finalizarAnáliseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            //Producao.Impressao.frmControleQuarentena quarentena = new Producao.Impressao.frmControleQuarentena(this.loginController, this.modulosController);
            //quarentena.lblUsuario.Text = this.lblUsuario.Text;
            //quarentena.Show();

            this.Cursor = Cursors.Default;

        }

        private void gerenciarPrioridadeDeManutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            Gerencial.frmGerenciarPrioridade gerenciarPrioridade = new Gerencial.frmGerenciarPrioridade(this.loginController, this.modulosController);
            gerenciarPrioridade.lblUsuario.Text = this.lblUsuario.Text;
            gerenciarPrioridade.Show();

            this.Cursor = Cursors.Default;

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void requisicaoPeçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmRequisicoesPecas requisicoes = new frmRequisicoesPecas(modulosController, loginController);
            requisicoes.lblUsuario.Text = this.lblUsuario.Text;
            requisicoes.Show();
            this.Cursor = Cursors.Default;

        }

        private void estoquePeçasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Apllication.Manutencao.frmEstoquePecas estoquePecas = new Manutencao.frmEstoquePecas(loginController,modulosController);
            estoquePecas.lblUsuario.Text = this.lblUsuario.Text;
            estoquePecas.Show();
            this.Cursor = Cursors.Default;
        }

        private void movimentaçãoPeçasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Manutencao.frmMovimentacaPecas movimentacao = new Manutencao.frmMovimentacaPecas(loginController, modulosController);
            movimentacao.Show();
            this.Cursor = Cursors.Default;
        }

        private void gerenciarAondeSeráUsadoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Manutencao.frmAsu asu = new Manutencao.frmAsu(loginController, modulosController);
            asu.lblUsuario.Text = this.lblUsuario.Text;
            asu.Show();
            this.Cursor = Cursors.Default;
        }

        private void requisiçõesDeCompraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            Compras.frmRequisicaoCompra compras = new Compras.frmRequisicaoCompra(loginController, modulosController);
            compras.lblUsuario.Text = this.lblUsuario.Text;
            compras.Show();
            this.Cursor = Cursors.Default;
        }

        private void estoqueToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmEstoque estoque = new frmEstoque(loginController, modulosController);
            estoque.lblUsuario.Text = this.lblUsuario.Text;
            estoque.Show();
            this.Cursor = Cursors.Default;
        }

        private void solicitaçãoDeMaterialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            frmRequisicaoMaterial requisicaMaterial = new frmRequisicaoMaterial(loginController, modulosController);
            requisicaMaterial.lblUsuario.Text = this.lblUsuario.Text;
            requisicaMaterial.ShowDialog();
            this.Cursor = Cursors.Default;

        }

        private void finalizarSolicitaçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmFinalizarRequisicao finalizar = new frmFinalizarRequisicao(loginController,modulosController);
            finalizar.lblUsuario.Text = this.lblUsuario.Text;
            finalizar.Show();

            this.Cursor = Cursors.Default;
        }


        private void ordensDeProduçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmOrdensProdução producao = new frmOrdensProdução();
            producao.Show();

        }

        private void impressãoDePAToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmFazerPa producao = new frmFazerPa();

            producao.Show();
        }

        private void painelSolicitaçãoWindToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPainelSolicitacoes wind = new frmPainelSolicitacoes(loginController);
            wind.Show();
        }

        private void entradaSaídaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMovimentacaoMaterial entradaSaida = new frmMovimentacaoMaterial(loginController);
            entradaSaida.ShowDialog();
        }

        private void estoquePeçasToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var estoquePecas = new  frmConversaoEstoquePecas(loginController,modulosController);
            estoquePecas.Show();
        }
    }
}
