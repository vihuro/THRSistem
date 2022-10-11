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
    public partial class frmSolicitacaoPeca : Form
    {
        String usuario;
        String numeroOS;
        String numeroRequisicao;
        public String manutencaoNivel;


        public frmSolicitacaoPeca(String usuario, String numeroOS, String manutencaoNivel)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.numeroOS = numeroOS;
            this.manutencaoNivel = manutencaoNivel;
            loadDataGridView1();
        }

        private void loadDataGridView1()
        {



            for (var i = 0; i < dataGridView1.Rows.Count; i++)
            {

                if (i == dataGridView1.Rows.Count - 1)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[4];

                    break;
                }

            }
            dataGridView1.ClearSelection();
            clearall();
            
        }

        private void frmSolicitacaoPeca_Load(object sender, EventArgs e)
        {
            dataGridView1.ClearSelection();
            txtCodigo.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtUnidade.Text = string.Empty;
            txtQuantidade.Text = string.Empty;


        }

        private void clearall()
        {
            txtCodigo.Text = string.Empty;
            txtDescricao.Text = string.Empty;
            txtUnidade.Text = string.Empty;
            txtQuantidade.Text = string.Empty;
            dataGridView1.ClearSelection();
            
        }

        private void btnAdicionar_Click(object sender, EventArgs e)
        {
            DateTime dataHora;

            dataHora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

            if (txtDescricao.Text != string.Empty && txtUnidade.Text != string.Empty && txtQuantidade.Text != string.Empty)
            {
               /* Modelo.OSTHRController controller = new Modelo.OSTHRController();
                controller.numeroOSTHR = numeroOS;
                controller.codigoPeca = txtCodigo.Text;
                controller.descricaoPeca = txtDescricao.Text;
                controller.QTD = txtQuantidade.Text;
                controller.unidade = txtUnidade.Text;
                controller.nomeSolicitante = usuario;
                controller.dataHoraSolicitacao = dataHora.ToString();
                controller.statusSolicitacao = "AGUARDANDO/AUT. PEÇAS";

                controller.insertRequisicaoPecas();

                clearall();

                loadDataGridView1();*/
            }
            else
            {
                MessageBox.Show("Campo(s) obrigatório(s) vazio(s)!", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }



        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            DataGridView dataGrid = (DataGridView)sender;
            int i = dataGrid.SelectedRows.Count;

            if (i > 0)
            {

                numeroRequisicao = dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[0].Value.ToString();

                loadInfoDataGrid();

                if (dataGridView1.Rows[dataGridView1.SelectedRows[0].Index].Cells[8].Value.ToString() == "AGUARDANDO/AUT. PEÇAS" &&
                    manutencaoNivel == "1")
                {
                    btnAutorizar.Enabled = true;
                }
                else
                {
                    btnAutorizar.Enabled = false;
 
                }
            }
        }
        private void loadInfoDataGrid()
        {
           /* Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.numeroRequisicao = numeroRequisicao;
            controller.selectInfoRequi();
            txtCodigo.Text = controller.codigoPeca;
            txtDescricao.Text = controller.descricaoPeca;
            txtUnidade.Text = controller.unidade;
            txtQuantidade.Text = controller.QTD;*/
        }

        private void btnAutorizar_Click(object sender, EventArgs e)
        {
            DateTime dataHora;

            dataHora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

            /*Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.numeroRequisicao = numeroRequisicao;
            controller.nomeAutorizador = usuario;
            controller.dataHoraAutorizacao = dataHora.ToString();
            controller.statusRequisicao = "Autorizado";
            controller.autorizarRequisicao();*/

            loadDataGridView1();
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            clearall();
        }


        private void btnRemover_Click(object sender, EventArgs e)
        {
           /* Modelo.OSTHRController controller = new Modelo.OSTHRController();
            controller.numeroRequisicao = numeroRequisicao;
            controller.deleteRequisicao();
            if(controller.msg != null)
            {
                MessageBox.Show(controller.msg);
            }
            loadDataGridView1();*/

        }

        private void aguardandoAutPeca()
        {
           /* Modelo.OSTHRController controller = new Modelo.OSTHRController();

            controller.numeroOSTHR = numeroOS;
            controller.selectRequisicao();

            if (controller.msg != null)
            {
                MessageBox.Show("Erro inesperado. Contante o administrador do sistema!  " + controller.msg, "THR SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                if (controller.usuarioApontamento != string.Empty)
                {

                    controller.statusOP = "Aguardando/AUT. Peça";
                    controller.dataHoraAlteracao = Convert.ToString(datahora);
                    controller.usuarioAlteracao = usuario;
                    controller.observacao = "";

                    controller.updateRequisicao();

                    if (controller.msg != null)
                    {
                        MessageBox.Show(controller.msg);
                    }

                    controller.UpdateStaOS(numeroOS);
                    if (controller.msg != null)
                    {
                        MessageBox.Show(controller.msg);
                    }
                }
                else
                {
                    this.numeroStatus = controller.numeroStatus;


                    controller = new Modelo.OSTHRController();
                    controller.dataHoraApontament = Convert.ToString(datahora);
                    controller.usuarioApontamento = usuario;
                    controller.dataHoraAlteracao = Convert.ToString(datahora);
                    controller.usuarioAlteracao = usuario;
                    controller.observacao = "";
                    controller.updateStatus(numeroStatus);

                    controller.statusOP = "Aguardando/AUT. Peça";
                    controller.UpdateStaOS(numeroOS);
                    if (controller.msg != null)
                    {
                        MessageBox.Show("Erro inesperado. Contante o administrador do sistema!  " + controller.msg, "THR SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
            }*/
        }

        private void btnGravar_Click(object sender, EventArgs e)
        {
            int linhas = dataGridView1.Rows.Count;

            //datahora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

            if (linhas > 0)
            {
                for (int i = 0; i < dataGridView1.Rows.Count; i++)
                {

                   

                    if (dataGridView1.Rows[i].Cells[8].Value.ToString() == "AGUARDANDO/AUT. PEÇAS")
                    {
                        aguardandoAutPeca();

                        break;
                    }


                    else if(i == linhas -1)
                    {
                       /* Modelo.OSTHRController controller = new Modelo.OSTHRController();

                        controller.dataHoraAlteracao = Convert.ToString(datahora);
                        controller.usuarioAlteracao = usuario;


                        controller.statusOP = "Peças Autorizadas";
                        controller.UpdateStaOS(numeroOS);*/
                       // if(controller.msg != null)
                       // {
                           // MessageBox.Show("Erro inesperado. Contante o administrador do sistema!  " + controller.msg, "THR SISTEMAS", MessageBoxButtons.OK, MessageBoxIcon.Error);
                       // }

                    }

                }
                this.Close();

            }
            else
            {
                MessageBox.Show("Nenhuma peça solicitada","THR SISTEMAS", MessageBoxButtons.OK,MessageBoxIcon.Warning);

                this.Close();
            }
        }

        
    }
}
