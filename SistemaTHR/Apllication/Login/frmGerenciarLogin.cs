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
    public partial class frmGerenciarLogin : Form
    {
        public DataTable dt = new DataTable();

        public frmGerenciarLogin()
        {
            InitializeComponent();
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void loadDataGridView()
        {
            loginController controller = new loginController();
            controller.loadUser();
            this.dt = controller.dt;
            dataGridView1.DataSource = this.dt;
        }

        private void frmGerenciarLogin_Load(object sender, EventArgs e)
        {

            loadDataGridView();
            clearAll();


        }

        String nomeUsuario;
        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            int i = dataGridView1.SelectedRows.Count;
            if(i > 0)
            {
                nomeUsuario = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[1].Value.ToString();

                loginController login = new loginController();
                login.loadInfo(nomeUsuario);
                login.usuario = nomeUsuario;
                login.selectNomeUsuario();
                txtNome.Text = login.nomeUsuario;
                txtSenha.Text = login.senha;

                txtUsuario.Text = nomeUsuario;
                txtUsuario.ReadOnly = true;
                txtUsuario.BackColor = Color.White;

                if(login.Expedicao == "Sim")
                {
                    rbExpSim.Checked = true;
                    cboExp.Enabled = true;
                }

                else
                {
                    rbExpNao.Checked = true;
                    cboExp.Enabled = false;
                }

                if (login.Empilhadeiras == "Sim")
                {
                    rbEmpSim.Checked = true;
                    cboEmp.Enabled = true;
                }

                else
                {
                    rbEmpNao.Checked = true;
                    cboEmp.Enabled = false;
                }

                if (login.Recebimento == "Sim")
                {
                    rbEmpRecebSim.Checked = true;
                    cboReceb.Enabled = true;
                }
                else
                {
                    rbRecebeNao.Checked = true;
                    cboReceb.Enabled = false;
                }

                if (login.Adm == "Sim")
                {
                    rbAdmSim.Checked = true;
                    cboAdm.Enabled = true;
                }
                else
                {
                    rbAdmNao.Checked = true;
                    cboAdm.Enabled = false;
                }

                if (login.manutencao == "Sim")
                {
                    rdbManutencaoSim.Checked = true;
                    cboManutencao.Enabled = true;
                }
                else
                {
                    rdbManutencaoNao.Checked = true;
                    cboManutencao.Enabled = false;
                }

                cboAdm.Text = login.AdmNivel;
                cboEmp.Text = login.EmpNivel;
                cboExp.Text = login.ExpNivel;
                cboReceb.Text = login.RecebNivel;
                cboManutencao.Text = login.manutencaoNivel;


            }

        }

        private void cboEmp_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(rbEmpSim.Checked == true)
            {
                cboExp.Enabled = false;
            }
            else
            {
                cboExp.Enabled=true;
            }
        }

        private void rbEmpSim_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rbEmpSim_Click(object sender, EventArgs e)
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


        }

        private void rbEmpNao_Click(object sender, EventArgs e)
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

        private void rbEmpNao_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void rbEmpNao_CheckedChanged_2(object sender, EventArgs e)
        {

        }

        private void rbEmpRecebSim_Click(object sender, EventArgs e)
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

        private void rbRecebeNao_Click(object sender, EventArgs e)
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

        private void rbExpSim_Click(object sender, EventArgs e)
        {
            if(rbExpSim.Checked == true)
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

        }

        private void rbExpNao_Click(object sender, EventArgs e)
        {
            if(rbExpNao.Checked == true)
            {
                cboExp.Enabled = false;
            }
            else
            {
                cboExp.Enabled = true;
            }
        }

        private void rbAdmSim_Click(object sender, EventArgs e)
        {
            if(rbAdmSim.Checked == true)
            {
                cboAdm.Enabled = true;
            }
            else
            {
                cboAdm.Enabled = false;
            }
        }

        private void rbAdmNao_Click(object sender, EventArgs e)
        {
            if(rbEmpNao.Checked == true)
            {
                cboAdm.Enabled = false;
            }
            else
            {
                cboAdm.Enabled = true;
            }
        }

        private void rdbManutencaoSim_Click(object sender, EventArgs e)
        {
            if(rdbManutencaoSim.Checked == true)
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
            if(rdbManutencaoNao.Checked == true)
            {
                cboManutencao.Enabled = false;
            }
            else
            {
                cboManutencao.Enabled = true;
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void clearAll()
        {
            txtUsuario.ReadOnly = false;
            txtUsuario.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtSenha.Text = string.Empty;

            cboAdm.Enabled = true;
            cboEmp.Enabled = true;
            cboManutencao.Enabled = true;
            cboReceb.Enabled = true;
            cboExp.Enabled = true;


            cboExp.Text = string.Empty;
            cboEmp.Text = string.Empty;
            cboManutencao.Text = string.Empty;
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

            dataGridView1.ClearSelection();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clearAll();


        }

        private void btnSalvar_Click_1(object sender, EventArgs e)
        {
            loginController controller = new loginController();
            controller.usuario = txtUsuario.Text;
            controller.verificarUsuario();

            if(txtNome.Text != string.Empty && txtUsuario.Text != string.Empty && txtSenha.Text != string.Empty)
            {
                String empilhadeiras = "Não";
                String recebimento = "Não";
                String expedicao = "Não";
                String aDM = "Não";
                String manutencao = "Não";
                String producao = "Não";

                if (rbEmpSim.Checked == true)
                {
                    empilhadeiras = rbEmpSim.Text;
                }
                if (rbEmpNao.Checked == true)
                {
                    empilhadeiras = rbEmpNao.Text;
                }

                if (rbEmpRecebSim.Checked == true)
                {
                    recebimento = rbEmpRecebSim.Text;
                }
                if (rbRecebeNao.Checked == true)
                {
                    recebimento = rbRecebeNao.Text;
                }

                if (rbExpSim.Checked == true)
                {
                    expedicao = rbExpSim.Text;
                }
                if (rbExpNao.Checked == true)
                {
                    expedicao = rbExpNao.Text;
                }

                if (rbAdmSim.Checked == true)
                {
                    aDM = rbAdmSim.Text;
                }
                if (rbEmpNao.Checked == true)
                {
                    aDM = rbAdmNao.Text;
                }

                if (rdbManutencaoSim.Checked == true)
                {
                    manutencao = rdbManutencaoSim.Text;
                }
                if (rdbManutencaoNao.Checked == true)
                {
                    manutencao = rdbManutencaoNao.Text;
                }

                if (rdbProducaoSim.Checked == true)
                {
                    manutencao = rdbManutencaoSim.Text;
                }

                if (rdbProducaoNao.Checked == true)
                {
                    manutencao = rdbManutencaoNao.Text;
                }

                controller.Empilhadeiras = empilhadeiras;
                controller.EmpNivel = cboEmp.Text;
                controller.Recebimento = recebimento;
                controller.RecebNivel = cboReceb.Text;
                controller.Expedicao = expedicao;
                controller.ExpNivel = cboExp.Text;
                controller.Adm = aDM;
                controller.AdmNivel = cboAdm.Text;
                controller.manutencao = manutencao;
                controller.manutencaoNivel = cboManutencao.Text;
                controller.nomeUsuario = txtNome.Text;
                controller.senha = txtSenha.Text;


                if (controller.tem == true)
                {

                    controller.uptadeModulosUsuario();
                    controller.updateUser();
                }
                else
                {

                    controller.inserUsuario();
                    controller.insertMod();

                }
                loadDataGridView();
                clearAll();
            }
            else
            {
                MessageBox.Show("Campo(s) obrigatório(s) vazio(s)!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            loginController controller = new loginController();
            controller.usuario = txtUsuario.Text;
            controller.deleteUsuario();

            if(controller.menssagem != null)
            {
                MessageBox.Show("Erro inespereado. Contate o administrador do sistema! " + controller.msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            controller = new loginController();
            controller.usuario = txtUsuario.Text;
            controller.deleteUsuarioModulos();

            if(controller.menssagem != null)
            {
                MessageBox.Show("Erro inespereado. Contate o administrador do sistema! " + controller.msg, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
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
    }
}
