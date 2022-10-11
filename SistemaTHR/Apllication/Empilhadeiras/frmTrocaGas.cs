using SistemaTHR.DAO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication
{
    public partial class frmTrocaGas : Form
    {
       /* public frmTrocaGas()
        {
            InitializeComponent();


        }

        public frmTrocaGas(String ultimaTroca)
        {

        }

        private void loadUltimaTroca()
        {
            try
            {
                Modelo.ultimaTrocaController ultimaTrocaController = new Modelo.ultimaTrocaController();
                ultimaTrocaController.buscarUltimaTroca(lblNumeroEmp.Text);
                if (ultimaTrocaController.ultimaTroca != null)
                {
                    txtUltimaTroca.Text = ultimaTrocaController.ultimaTroca.ToString();
                }

            }
            catch
            {
                MessageBox.Show("Erro");
            }
        }

        private void frmTrocaGas_Load(object sender, EventArgs e)
        {
            try
            {
                Modelo.ultimaTrocaController ultimaTrocaController = new Modelo.ultimaTrocaController();
                ultimaTrocaController.buscarUltimaTroca(lblNumeroEmp.Text);
                if (ultimaTrocaController.ultimaTroca != null)
                {
                    txtUltimaTroca.Text = ultimaTrocaController.ultimaTroca.ToString();
                }

            }
            catch
            {
                MessageBox.Show("Erro");
            }


        }


        private void btnBuscar_Click(object sender, EventArgs e)
        {



        }

        private void txtTrocaAtual_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void txtTrocaAtual_TextChanged(object sender, EventArgs e)
        {
            int ultimaTroca;
            int trocaAtual;
            int resultado;

            if (txtTrocaAtual.Text != string.Empty)
            {
                trocaAtual = Convert.ToInt32(txtTrocaAtual.Text);
                ultimaTroca = Convert.ToInt32(txtUltimaTroca.Text);

                resultado = ultimaTroca - trocaAtual;

                 resultado = resultado * -1;

                lblHorasTrabalhadas.Text = resultado.ToString();
            }

        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {


            Modelo.trocaGasController trocaGasController = new Modelo.trocaGasController();

            int horasTrabalhadas = int.Parse(this.lblHorasTrabalhadas.Text);

            DateTime dataHora =  Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));


            if(horasTrabalhadas > 6 && horasTrabalhadas < 10)
            {
                    try
                    {
                        trocaGasController.insertTrocaGas(lblNumeroEmp.Text, txtUltimaTroca.Text, txtTrocaAtual.Text, lblHorasTrabalhadas.Text, dataHora , this.lblUsuario.Text);

                        MessageBox.Show("Troca declarada com sucesso!","Informação",MessageBoxButtons.OK,MessageBoxIcon.Information);
                        frmTrocaGas frmTroca = new frmTrocaGas();
                        this.Close();

                    }
                    catch
                    {
                        MessageBox.Show("Erro");
                    }

            }
            else
            {
                MessageBox.Show("Horas trabalhadas fora da média!","Erro",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }




        }

        private void txtTrocaAtual_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void frmTrocaGas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               // MessageBox.Show("Enter pressionado");
                this.SelectNextControl(this.ActiveControl, !e.Shift, true, true, true);
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }*/
    }
    
}

