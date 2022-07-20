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
        String Usuario;
        public String Empilhadeiras;
        public String EmpNivel;
        public String Recebimento;
        public String RecebNivel;
        public String Expedicao;
        public String ExpNivel;
        public String Adm;
        public String AdmNivel;
        public String manutencao;
        public String manutencaoNivel;

        Thread nt;

        public frmMenu(String Usuario)
        {
            InitializeComponent();
            this.Usuario = Usuario;
        }

        private void empilhadeira1ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrocaGas frmTrocaGas = new frmTrocaGas();
            
            frmTrocaGas.lblNumeroEmp.Text = "1";
            frmTrocaGas.lblUsuario.Text = this.lblUsuario.Text;
            frmTrocaGas.Show();
        }

        private void empilhadeira2ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrocaGas frmTrocaGas = new frmTrocaGas();

            frmTrocaGas.lblNumeroEmp.Text = "2";
            frmTrocaGas.lblUsuario.Text = this.lblUsuario.Text;
            frmTrocaGas.Show();
        }

        private void empilhadeira3ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTrocaGas frmTrocaGas = new frmTrocaGas();

            frmTrocaGas.lblNumeroEmp.Text = "3";
            frmTrocaGas.lblUsuario.Text = this.lblUsuario.Text;
            frmTrocaGas.Show();

        }

        private void empilhadeira3ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmTrocaGas frmTrocaGas = new frmTrocaGas();

            frmTrocaGas.lblNumeroEmp.Text = "4";
            frmTrocaGas.lblUsuario.Text = this.lblUsuario.Text;
            frmTrocaGas.Show();

        }

        private void empilhadeira3ToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            frmTrocaGas frmTrocaGas = new frmTrocaGas();

            frmTrocaGas.lblNumeroEmp.Text = "5";
            frmTrocaGas.lblUsuario.Text = this.lblUsuario.Text;
            frmTrocaGas.Show();

        }

        private void trocaGásToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPainelTrocaGas frmPainelTrocaGas = new frmPainelTrocaGas();
            frmPainelTrocaGas.Show();
        }

        private void solicitarManutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmSolicitarManutencao frmSolicitarManutencao = new frmSolicitarManutencao();
            frmSolicitarManutencao.lblUsuario.Text = this.lblUsuario.Text;
            frmSolicitarManutencao.ShowDialog();
        }

        private void manutenççõesEmAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPainelManutencoesAberto frmPainelManutencoesAberto = new frmPainelManutencoesAberto();
            frmPainelManutencoesAberto.lblUsuario.Text = this.lblUsuario.Text;
     
            frmPainelManutencoesAberto.Show();
        }



        private void transfêToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTransferencia frmTransferencia = new frmTransferencia(Usuario);
            frmTransferencia.lblUsuario.Text = this.lblUsuario.Text;
            frmTransferencia.Show();

        }

        private void frmMenu_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmTeste frmTeste = new frmTeste();
            frmTeste.Show();
        }

        private void verificarLogin()
        {
            loginController loginController = new loginController();

            loginController.verificarNivel(this.lblUsuario.Text);
            this.Empilhadeiras = loginController.Empilhadeiras;
            this.EmpNivel = loginController.EmpNivel;
            this.Recebimento = loginController.Recebimento;
            this.RecebNivel = loginController.RecebNivel;
            this.Expedicao = loginController.Expedicao;
            this.ExpNivel = loginController.ExpNivel;
            this.Adm = loginController.Adm;
            this.AdmNivel = loginController.AdmNivel;
            this.manutencao = loginController.manutencao;
            this.manutencaoNivel = loginController.manutencaoNivel;
        }


        public DataTable dt = new DataTable();
        private void gerenciarLoginsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmGerenciarLogin gerenciarLogin = new frmGerenciarLogin();
            loginController login = new loginController();
            login.loadUser();
            this.dt = login.dt;
            gerenciarLogin.dataGridView1.DataSource = this.dt;
            gerenciarLogin.Show();
        }
         

        private void manutençãoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencao manutencao = new frmManutencao(Usuario);
            manutencao.lblUsuario.Text = this.lblUsuario.Text;

        }

        private void solicitarManutençãoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            frmSolicitarManutencaoTHR frmSolicitar = new frmSolicitarManutencaoTHR(Usuario);
            frmSolicitar.lblUsuario.Text = this.lblUsuario.Text;
            frmSolicitar.ShowDialog();
        }

        private void manutençõesEmAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManutencao manutencao = new frmManutencao(Usuario);
            verificarLogin();

            manutencao.btnCompra.Enabled = false;
            manutencao.btnDesfazer.Enabled = false;
            manutencao.cboPrioridade.Enabled = false;

            if (this.manutencaoNivel == "2" || this.manutencaoNivel == "1")
            {
                manutencao.btnCompra.Enabled = true;

            }
            if(this.manutencaoNivel == "1")
            {
                manutencao.btnDesfazer.Enabled = true;
                manutencao.cboPrioridade.Enabled = true;

            }


            manutencao.lblUsuario.Text = this.lblUsuario.Text;
            manutencao.manutencaoNivel = this.manutencaoNivel;
            manutencao.Show();
        }


        private void painelManutençõesmEmAbertoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPainelManutencoesTHR painel = new frmPainelManutencoesTHR();
            painel.Show();
        }

        private void statusStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void expediçãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void paínesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmPainelTransferencias frmPainelTransferencias = new frmPainelTransferencias();

            loginController loginController = new loginController();

            loginController.verificarNivel(this.lblUsuario.Text);
            this.Empilhadeiras = loginController.Empilhadeiras;
            this.EmpNivel = loginController.EmpNivel;
            this.Recebimento = loginController.Recebimento;
            this.RecebNivel = loginController.RecebNivel;
            this.Expedicao = loginController.Expedicao;
            this.ExpNivel = loginController.ExpNivel;
            this.Adm = loginController.Adm;
            this.AdmNivel = loginController.AdmNivel;
            this.manutencao = loginController.manutencao;
            this.manutencaoNivel = loginController.manutencaoNivel;

            frmPainelTransferencias.btnEditar.Enabled = false;
            frmPainelTransferencias.lblUsuario.Text = this.lblUsuario.Text;

            if (this.ExpNivel == "1")
            {
                frmPainelTransferencias.btnEditar.Enabled = true;
            }


            frmPainelTransferencias.Show();
        }
    }
}
