﻿using System;
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
        public frmSolicitarManutencaoTHR(String usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }



        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(cboAondeSera.Text != string.Empty && cboTipoServico.Text != string.Empty && txtDescricao.Text != string.Empty)
            {
                DateTime dataHora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:00"));


                Modelo.OSTHRController oSTHRController = new Modelo.OSTHRController();
                oSTHRController.insertOrdemServico(txtDescricao.Text, cboTipoServico.Text, Convert.ToString(dataHora), usuario,cboAondeSera.Text,txtDataIdeal.Text , "EM ABERTO");

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
                        String geracao = "Geração";


                        oSTHRController.insertStatusOS(numeroOP, geracao, Convert.ToString(dataHora), usuario, Convert.ToString(dataHora), usuario, "");

                        String IniMan = "Início de manutenção";

                        oSTHRController.insertStatusOS(numeroOP, IniMan, "00/00/0000 00:00:00", "", "00/00/0000 00:00:00", "", "");

                        String RequisicaoPeca = "Requisição de peça";

                        oSTHRController.insertStatusOS(numeroOP, RequisicaoPeca, "00/00/0000 00:00:00", "", "00/00/0000 00:00:00", "", "");

                        String OrdemNaoProcede = "Inconsistência da OS";

                        oSTHRController.insertStatusOS(numeroOP, OrdemNaoProcede, "00/00/0000 00:00:00", "", "00/00/0000 00:00:00", "", "");

                        String FinMan = "Fim de manutenção";

                        oSTHRController.insertStatusOS(numeroOP, FinMan, "00/00/0000 00:00:00", "", "00/00/0000 00:00:00", "", "");

                        String OSNaoProcede = "Manutenção N/C";

                        oSTHRController.insertStatusOS(numeroOP, OSNaoProcede, "00/00/0000 00:00:00", "", "00/00/0000 00:00:00", "", "");

                        String OSFin = "OS Finalizada";

                        oSTHRController.insertStatusOS(numeroOP, OSFin, "00/00/0000 00:00:00", "", "00/00/0000 00:00:00", "", "");

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
    }
}
