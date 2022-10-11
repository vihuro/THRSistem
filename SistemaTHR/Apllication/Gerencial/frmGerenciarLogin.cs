using SistemaTHR.Apllication.Gerencial;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using SistemaTHR.Controller.Login;
using SistemaTHR.Service.login;

namespace SistemaTHR.Apllication
{
    public partial class frmGerenciarLogin : Form
    {
        private Controller.Login.loginController loginController;
        private Controller.Login.modulosController modulosController;
        private Service.login.loginService loginService;
        private Service.modulosService modulosService;

        public frmGerenciarLogin(Controller.Login.loginController loginController, Controller.Login.modulosController modulosController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.modulosController = modulosController;

        }

        private void loadDataGridView()
        {
            modulosService = new Service.modulosService();
            modulosService.dataTable(modulosController);
            if (modulosController.Msg != null)
            {
                MessageBox.Show(modulosController.Msg);
            }
            else
            {
                dataGridView1.DataSource = modulosController.Dt;
            }

        }

        public void loadDataGridView(string usuario)
        {
            modulosController.Dt.DefaultView.RowFilter = string.Format("[Usuario] like '%{0}%'",usuario);

            dataGridView1.DataSource = modulosController.Dt;

        }

        private void frmGerenciarLogin_Load(object sender, EventArgs e)
        {
            loadDataGridView();
            clearAll();

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {


            int i = dataGridView1.SelectedRows.Count;
            loginService = new Service.login.loginService();

            if (i > 0)
            {
                this.Cursor = Cursors.WaitCursor;

                loginController = new Controller.Login.loginController();
                loginController.Nome = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
                loginService.info(loginController);


                txtUsuario.Text = loginController.Nome;
                txtNome.Text = loginController.NomeUsuario;
                txtSenha.Text = loginController.Senha;


                txtUsuario.ReadOnly = true;
                txtUsuario.BackColor = Color.White;

                if (dataGridView1.SelectedRows[0].Cells[2].Value.ToString() == "Sim")
                {
                    rbEmpSim.Checked = true;

                }

                else
                {
                    rbEmpNao.Checked = true;

                }

                if (dataGridView1.SelectedRows[0].Cells[4].Value.ToString() == "Sim")
                {
                    rbEmpRecebSim.Checked = true;

                }
                else
                {
                    rbRecebeNao.Checked = true;

                }


                if (dataGridView1.SelectedRows[0].Cells[6].Value.ToString() == "Sim")
                {
                    rbExpSim.Checked = true;

                }

                else
                {
                    rbExpNao.Checked = true;

                }

                if (dataGridView1.SelectedRows[0].Cells[8].Value.ToString() == "Sim")
                {
                    rbAdmSim.Checked = true;

                }
                else
                {
                    rbAdmNao.Checked = true;

                }

                if (dataGridView1.SelectedRows[0].Cells[10].Value.ToString() == "Sim")
                {
                    rdbManutencaoSim.Checked = true;

                }
                else
                {
                    rdbManutencaoNao.Checked = true;

                }

                if (dataGridView1.SelectedRows[0].Cells[12].Value.ToString() == "Sim")
                {
                    rdbProducaoSim.Checked = true;
                }
                else
                {
                    rdbProducaoNao.Checked = true;

                }
                if (dataGridView1.SelectedRows[0].Cells[14].Value.ToString() == "Sim")
                {
                    rdbAlmoxarifadoSim.Checked = true;

                }
                else
                {
                    rdbAlmoxarifadoNao.Checked = true;
                }

                if (dataGridView1.SelectedRows[0].Cells[16].Value.ToString() == "Sim")
                {
                    rdbEstoqueSim.Checked = true;

                }
                else
                {
                    rdbEstoqueNao.Checked = false;
                }
                if (dataGridView1.SelectedRows[0].Cells[18].Value.ToString() == "Sim")
                {
                    rdbComprasSim.Checked = true;
                }
                else
                {
                    rdbEstoqueNao.Checked = false;
                }

                cboEmp.Text = dataGridView1.SelectedRows[0].Cells[3].Value.ToString();
                cboReceb.Text = dataGridView1.SelectedRows[0].Cells[5].Value.ToString();
                cboExp.Text = dataGridView1.SelectedRows[0].Cells[7].Value.ToString();
                cboAdm.Text = dataGridView1.SelectedRows[0].Cells[9].Value.ToString();
                cboManutencao.Text = dataGridView1.SelectedRows[0].Cells[11].Value.ToString();
                cboProducao.Text = dataGridView1.SelectedRows[0].Cells[13].Value.ToString();
                cboAlmoxarifado.Text = dataGridView1.SelectedRows[0].Cells[15].Value.ToString();
                cboEstoque.Text = dataGridView1.SelectedRows[0].Cells[17].Value.ToString();
                cboCompras.Text = dataGridView1.SelectedRows[0].Cells[19].Value.ToString();

            }
            this.Cursor = Cursors.Default;
        }

        private void clearAll()
        {
            txtUsuario.ReadOnly = false;
            txtUsuario.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSenha.Text = string.Empty;

            cboExp.Text = string.Empty;
            cboEmp.Text = string.Empty;
            cboManutencao.Text = string.Empty;
            cboReceb.Text = string.Empty;
            cboEmp.Text = string.Empty;
            cboProducao.Text = string.Empty;

            rbAdmSim.Checked = false;
            rbAdmNao.Checked = false;

            rbEmpSim.Checked = false;
            rbEmpNao.Checked = false;

            rbEmpRecebSim.Checked = false;
            rbRecebeNao.Checked = false;

            rbExpSim.Checked = false;
            rbExpNao.Checked = false;

            rdbManutencaoSim.Checked = false;
            rdbManutencaoNao.Checked = false;

            rdbProducaoSim.Checked = false;
            rdbProducaoNao.Checked = false;

            rdbAlmoxarifadoSim.Checked = false;
            rdbAlmoxarifadoNao.Checked = false;

            rdbEstoqueSim.Checked = false;
            rdbEstoqueNao.Checked = false;

            rdbComprasSim.Checked = false;
            rdbComprasNao.Checked = false;

            cboAdm.Enabled = false;
            cboEmp.Enabled = false;
            cboManutencao.Enabled = false;
            cboReceb.Enabled = false;
            cboExp.Enabled = false;
            cboProducao.Enabled = false;
            cboAlmoxarifado.Enabled = false;
            cboEstoque.Enabled = false;
            cboCompras.Enabled = false;

            dataGridView1.ClearSelection();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            carregar();

        }


        private void btnExcluir_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            loginController.Nome = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();
            modulosController.Usuario = dataGridView1.SelectedRows[0].Cells[1].Value.ToString();

            loginService.delete(loginController);
            if (loginController.Msg != null)
            {
                MessageBox.Show(loginController.Msg);
            }
            modulosService.delete(modulosController);
            if (modulosController.Msg != null)
            {
                MessageBox.Show(modulosController.Msg);
            }

            carregar();

            this.Cursor = Cursors.Default;
        }

        private void carregar()
        {
            loadDataGridView();
            clearAll();
        }

        private void button1_Click(object sender, EventArgs e)
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

        private void verificarModulos()
        {
            if (rbEmpSim.Checked == true)
            {
                modulosController.Empilhadeiras = rbEmpSim.Text;
                modulosController.EmpNivel = cboEmp.Text;
            }
            else
            {
                modulosController.Empilhadeiras = rbEmpNao.Text;
                modulosController.EmpNivel = "";
            }

            if (rbEmpRecebSim.Checked == true)
            {
                modulosController.Recebimento = rbEmpRecebSim.Text;
                modulosController.RecebNivel = cboReceb.Text;
            }
            else
            {
                modulosController.Recebimento = rbRecebeNao.Text;
                modulosController.RecebNivel = "";
            }

            if (rbExpSim.Checked == true)
            {
                modulosController.Expedicao = rbExpSim.Text;
                modulosController.ExpNivel = cboExp.Text;
            }
            else
            {
                modulosController.Expedicao = rbExpNao.Text;
                modulosController.ExpNivel = "";
            }

            if (rbAdmSim.Checked == true)
            {
                modulosController.Adm = rbAdmSim.Text;
                modulosController.AdmNivel = cboAdm.Text;
            }
            else
            {
                modulosController.Adm = rbAdmNao.Text;
                modulosController.AdmNivel = "";
            }

            if (rdbManutencaoSim.Checked == true)
            {
                modulosController.Manutencao = rdbManutencaoSim.Text;
                modulosController.ManutencaoNivel = cboManutencao.Text;
            }
            else
            {
                modulosController.Manutencao = rdbManutencaoNao.Text;
                modulosController.ManutencaoNivel = "";
            }

            if (rdbProducaoSim.Checked == true)
            {
                modulosController.Producao = rdbProducaoSim.Text;
                modulosController.ProducaoNivel = cboProducao.Text;

            }
            else
            {
                modulosController.Producao = rdbProducaoNao.Text;
                modulosController.ProducaoNivel = "";
            }

            if (rdbAlmoxarifadoSim.Checked == true)
            {
                modulosController.Almoxarifado = rdbAlmoxarifadoSim.Text;
                modulosController.AlmoxarifadoNivel = cboAlmoxarifado.Text;
            }
            else
            {
                modulosController.Almoxarifado = rdbAlmoxarifadoNao.Text;
                modulosController.AlmoxarifadoNivel = "";
            }

            if (rdbEstoqueSim.Checked == true)
            {
                modulosController.Estoque = rdbEstoqueSim.Text;
                modulosController.EstoqueNivel = cboEstoque.Text;
            }
            else
            {
                modulosController.Estoque = rdbEstoqueNao.Text;
                modulosController.EstoqueNivel = "";
            }

            if (rdbComprasSim.Checked == true)
            {
                modulosController.Compras = rdbComprasSim.Text;
                modulosController.ComprasNivel = cboCompras.Text;
            }
            else
            {
                modulosController.Compras = rdbComprasNao.Text;
                modulosController.ComprasNivel = "";
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;

            loginController.NomeUsuario = txtUsuario.Text;
            loginController.Nome = txtNome.Text;
            loginController.Senha = txtSenha.Text;


            if (txtNome.Text != string.Empty && txtUsuario.Text != string.Empty && txtSenha.Text != string.Empty)
            {

                loginService.authorized(loginController);
                verificarModulos();
                loginController.Nome = txtUsuario.Text;
                modulosController.Usuario = txtUsuario.Text;
                loginController.NomeUsuario = txtNome.Text;
                loginController.Senha = txtSenha.Text;
                if (loginController.Msg != null)
                {
                    MessageBox.Show(loginController.Msg);
                }
                else
                {
                    if (loginController.Autorizado == true)
                    {

                        loginService.update(loginController);
                        modulosService.update(modulosController);

                    }
                    else
                    {

                        loginService.insert(loginController);
                        modulosService.insert(modulosController);
                    }
                }

            }
            carregar();

            this.Cursor = Cursors.Default;
        }

        private void rbEmpSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmpSim.Checked == true)
            {
                cboEmp.Enabled = true;
            }
            else
            {
                cboEmp.Enabled = false;
            }
        }

        private void rbEmpNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmpNao.Checked == true)
            {
                cboEmp.Enabled = false;
            }
            else
            {
                cboEmp.Enabled = true;
            }
        }

        private void rbEmpRecebSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbEmpRecebSim.Checked == true)
            {
                cboReceb.Enabled = true;
            }
            else
            {
                cboReceb.Enabled = false;
            }
        }

        private void rbRecebeNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbRecebeNao.Checked == true)
            {
                cboReceb.Enabled = false;
            }
            else
            {
                cboReceb.Enabled = true;
            }
        }

        private void rbExpSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExpSim.Checked == true)
            {
                cboExp.Enabled = true;
            }
            else
            {
                cboExp.Enabled = true;
            }
        }

        private void rbExpNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbExpNao.Checked == true)
            {
                cboExp.Enabled = false;
            }
            else
            {
                cboExp.Enabled = true;
            }
        }

        private void rbAdmSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdmSim.Checked == true)
            {
                cboAdm.Enabled = true;
            }
            else
            {

                cboAdm.Enabled = false;
            }
        }

        private void rbAdmNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAdmNao.Checked == true)
            {
                cboAdm.Enabled = false;
            }
            else
            {
                cboAdm.Enabled = true;
            }

        }

        private void rdbManutencaoSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbManutencaoSim.Checked == true)
            {
                cboManutencao.Enabled = true;
            }
            else
            {
                cboManutencao.Enabled = false;
            }
        }

        private void rdbManutencaoNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbManutencaoNao.Checked == true)
            {
                cboManutencao.Enabled = false;
            }
            else
            {
                cboManutencao.Enabled = true;
            }
        }

        private void rdbProducaoSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbProducaoSim.Checked == true)
            {
                cboProducao.Enabled = true;
            }
            else
            {
                cboProducao.Enabled = false;
            }
        }

        private void rdbAlmoxarifadoSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAlmoxarifadoSim.Checked == true)
            {
                cboAlmoxarifado.Enabled = true;
            }
            else
            {
                cboAlmoxarifado.Enabled = false;
            }
        }

        private void rdbAlmoxarifadoNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbAlmoxarifadoNao.Checked == true)
            {
                cboAlmoxarifado.Enabled = false;
            }
            else
            {
                cboAlmoxarifado.Enabled = true;
            }
        }

        private void rdbEstoqueSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEstoqueSim.Checked == true)
            {
                cboEstoque.Enabled = true;
            }
            else
            {
                cboEstoque.Enabled = false;
            }
        }

        private void rdbEstoqueNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbEstoqueNao.Checked == true)
            {
                cboEstoque.Enabled = false;
            }
            else
            {
                cboEstoque.Enabled = true;
            }
        }

        private void rdbComprasSim_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbComprasSim.Checked == true)
            {
                cboCompras.Enabled = true;
            }
            else
            {
                cboCompras.Enabled = false;
            }
        }

        private void rdbComprasNao_CheckedChanged(object sender, EventArgs e)
        {
            if (rdbComprasNao.Checked == true)
            {
                cboCompras.Enabled = false;
            }
            else
            {
                cboCompras.Enabled = true;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;

            frmFiltroUsuarios filtro = new frmFiltroUsuarios(this);
            filtro.ShowDialog();

            this.Cursor = Cursors.Default;
        }
    }
}
