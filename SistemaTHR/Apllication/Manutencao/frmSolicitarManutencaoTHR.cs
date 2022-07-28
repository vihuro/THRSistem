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
    public partial class frmSolicitarManutencaoTHR : Form
    {
        String usuario;
        public String numeroOP;
        private String geracao;
        private String apontamentos;
        private List<String> apont = new List<string>();
        public frmSolicitarManutencaoTHR(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }
       
        String dataServico;
        DateTime data;
        private void verificarData()
        {


            if (dateTimePicker1.Format == DateTimePickerFormat.Custom)
            {
                dataServico = "00/00/0000";
            }
            else
            {
                dateTimePicker1.Value = dateTimePicker1.Value.Date;

                data = Convert.ToDateTime(dateTimePicker1.Value.ToString());

                dataServico = data.ToString("dd/MM/yyyy");

            }
        }


        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(cboAondeSera.Text != string.Empty && cboTipoServico.Text != string.Empty && txtDescricao.Text != string.Empty)
            {
                DateTime dataHora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                verificarData();

                Modelo.OSTHRController oSTHRController = new Modelo.OSTHRController();
                oSTHRController.insertOrdemServico(txtDescricao.Text, cboTipoServico.Text, Convert.ToString(dataHora), usuario,cboAondeSera.Text, dataServico, "EM ABERTO");

                if(oSTHRController.msg != null)
                {
                    MessageBox.Show(oSTHRController.msg,"ERRO COM BANCO DE DADOS!",MessageBoxButtons.OK,MessageBoxIcon.Error);
                }
                else
                {
                    oSTHRController.selectOrdemServico();
                    if (oSTHRController.msg != null)
                    {
                        MessageBox.Show(oSTHRController.msg, "ERRO COM BANCO DE DADOS!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        this.numeroOP = oSTHRController.numeroOP;
                    }

                    if(this.numeroOP != null)
                    {
                        Modelo.geracaoOSTHRController geracaoController = new Modelo.geracaoOSTHRController();
                        geracaoController.selectAtiv();
                        this.geracao = geracaoController.geracao;

                        Modelo.Manutencao.apontamentoController apontamento = new Modelo.Manutencao.apontamentoController();
                        apontamento.geracao = this.geracao;
                        apontamento.selectSituacao();
                        this.apont = apontamento.apont;


                        foreach(var apont in this.apont)
                        {
                            if (apont == "Geração")
                            {
                                oSTHRController.insertStatusOS(numeroOP, apont, Convert.ToString(dataHora), usuario, Convert.ToString(dataHora), usuario, "");
                            }
                            else
                            {
                                oSTHRController.insertStatusOS(numeroOP, apont, "00/00/0000 00:00:00", "", "00/00/0000 00:00:00", "", "");
                            }
                            
                        }


                        MessageBox.Show("Serviço solicitado com sucesso!", "THR SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Erro ao acrescentar o acompanhamento da OS. Contante o administrador do sistema!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }



            }
            else
            {
                MessageBox.Show("Campos obrigatório(s) vazio(s)", "THR SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmSolicitarManutencaoTHR_Load(object sender, EventArgs e)
        {
            Modelo.aseController controller = new Modelo.aseController();
            controller.ASE();
            foreach(var item in controller.ase)
            {
                cboAondeSera.Items.Add(item);
            }

            if(controller.msg != null)
            {
                MessageBox.Show(controller.msg);
            }
           
        }

        private void txtDescricao_TextChanged(object sender, EventArgs e)
        {
            int totalCaractere = 1000;

            foreach (char item in txtDescricao.Text)
            {
                totalCaractere = totalCaractere - 1;
            }
            lblCaractere.Text = "Caracteres restantes: " + totalCaractere;
        }

        private void lblCaractere_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void txtDataIdeal_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cboTipoServico_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {
            if(dateTimePicker1.Value >= DateTime.Today)
            {
                dateTimePicker1.Format = DateTimePickerFormat.Short;
            }
            else
            {
                dateTimePicker1.Format = DateTimePickerFormat.Custom;
            }
        }
    }
}
