using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.Apllication.Producao.Impressao
{
    public partial class frmControleQuarentena : Form
    {

       /* //loginController loginController;
        String id;
        String usuario;
        String nivel;
        DateTime dataLanc;
        DateTime dataAgora;

        TimeSpan diaResult;

        String diaResultString;
        String horaResultString;
        String minResultString;
        String segResultString;
        String temposAnalise;

        Controller.Login.loginController loginController;
        Controller.Login.modulosController modulosController;
        public frmControleQuarentena(Controller.Login.loginController loginController, Controller.Login.modulosController modulosController)
        {
            InitializeComponent();
            this.loginController = loginController;
            this.modulosController = modulosController;

        }

        private void frmControleQuarentena_Load(object sender, EventArgs e)
        {
            loadGridView();
            verificarNivel();
            txtFicha.Text = string.Empty;
        }

        private void loadGridView()
        {
            controller = new Modelo.Producao.fichaController();
            controller.selectAnalise();
            dataGridView1.DataSource = controller.dt;
            if(controller.msg != null)
            {
                MessageBox.Show(controller.msg);
            }

                for (int i = 0;i< dataGridView1.Rows.Count; i++)
                {
                    if(i == dataGridView1.Rows.Count - 1)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        break;
                    }
                }
            

            dataGridView1.ClearSelection();
            btnSalvar.Enabled = false;
            txtFicha.Text = string.Empty;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            if(this.nivel == "2")
            {
                encerrarAnalise();
            }
            else if(this.nivel == "3")
            {
                finalizarProducao();
            }
            else if(this.nivel == "1")
            {
                Producao.frmEcolhaStatus ecolha = new frmEcolhaStatus(this);
                ecolha.ShowDialog();
            }

            loadGridViewFicha(id);
        }

        private void loadGridViewFicha(String id)
        {
            controller = new Modelo.Producao.fichaController();
            controller.selectAnalise();
            dataGridView1.DataSource = controller.dt;
            if (controller.msg != null)
            {
                MessageBox.Show(controller.msg);
            }

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                if (dataGridView1.Rows[i].Cells[0].Value.ToString() == id)
                {
                    dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                    break;
                }
            }


            dataGridView1.ClearSelection();
            btnSalvar.Enabled = false;
            txtFicha.Text = string.Empty;
        }

        public void encerrarAnalise()
        {
            DateTime dataHora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss"));

            controller = new Modelo.Producao.fichaController();
            controller.dataHoraFinAnalise = dataHora.ToString();
            controller.usuarioFinAnalise = this.usuario;
            controller.status = "Analisado";
            controller.id = this.id;
            controller.updateCQ();
            if(controller.msg != null)
            {
                MessageBox.Show(controller.msg);
            }

        }

        private void tempoAnalise()
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                dataLanc = Convert.ToDateTime(dataGridView1.SelectedRows[0].Cells[4].Value.ToString());

                dataAgora = DateTime.Now;

                diaResult = dataLanc - dataAgora;

                diaResultString = Convert.ToString(diaResult.ToString("dd"));
                horaResultString = Convert.ToString(diaResult.ToString("hh"));
                minResultString = Convert.ToString(diaResult.ToString("mm"));
                segResultString = Convert.ToString(diaResult.ToString("ss"));

                temposAnalise = diaResultString + " D " + horaResultString + " HRS " + minResultString + " MIN " + segResultString + " SEG";

            }
        }

        public void finalizarProducao()
        {
            DateTime dataHora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss"));
            tempoAnalise();

            controller = new Modelo.Producao.fichaController();
            controller.dataHoraFinProd = dataHora.ToString();
            controller.usuarioFinProd = this.usuario;
            controller.tempoAnalise = temposAnalise;
            controller.status = "Finalizado";
            controller.id = this.id;
            controller.updateProd();
            if (controller.msg != null)
            {
                MessageBox.Show(controller.msg);
            }
        }

        public void aguardando()
        {
            DateTime dataHora = Convert.ToDateTime(DateTime.Now.ToString("dd/MM/yyyy  HH:mm:ss"));

            controller = new Modelo.Producao.fichaController();
            controller.dataHoraInicio = dataHora.ToString();
            controller.usuarioLancamento = this.usuario;
            controller.id = this.id;
            controller.BackAguardando();
            if(controller.msg != null)
            {
                MessageBox.Show(controller.msg);
            }

        }

        private void verificarNivel()
        {

        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if(dataGridView1.SelectedRows.Count > 0)
            {
                id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                if(nivel == "2" && dataGridView1.SelectedRows[0].Cells[11].Value.ToString() == "Finalizado" ||
                   nivel == "2" && dataGridView1.SelectedRows[0].Cells[11].Value.ToString() == "Analisado")
                {
                    btnSalvar.Enabled = false;
                }
                else if(nivel == "3" && dataGridView1.SelectedRows[0].Cells[11].Value.ToString() == "Aguardando" ||
                        nivel == "3" && dataGridView1.SelectedRows[0].Cells[11].Value.ToString() == "Finalizado")
                {
                    btnSalvar.Enabled = false;
                }
                else
                {
                    btnSalvar.Enabled = true;
                }

                txtFicha.Text = id;
                if(nivel == "1")
                {
                    btnExcluir.Enabled = true;
                    btnSalvar.Enabled = true;

                }
            }
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            controller = new Modelo.Producao.fichaController();
            controller.id = this.id;
            controller.delete();
            if(controller.msg != null)
            {
                MessageBox.Show(controller.msg);
            }
            loadGridView();
        }

        private void txtFicha_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                loadGridView();
                txtFicha.Text = string.Empty;
                
            }

            if (e.KeyCode == Keys.Enter || e.KeyCode == Keys.Tab)
            {

                for(int i = 0; i < dataGridView1.Rows.Count; i++)
                {
                    if (dataGridView1.Rows[i].Cells[0].Value.ToString() == txtFicha.Text)
                    {
                        dataGridView1.CurrentCell = dataGridView1.Rows[i].Cells[0];
                        break;
                    }
                    else if(i == dataGridView1.Rows.Count -1)
                    {
                        MessageBox.Show("Ficha não encontrada", "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        dataGridView1.ClearSelection();
                    }
                }
            }
        }

        private void dataGridView1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.F5)
            {
                loadGridView();
                txtFicha.Text = string.Empty;

            }
        }

        private void btnAtualizar_Click(object sender, EventArgs e)
        {
            loadGridView();
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            for(int i = 0;i < dataGridView1.Rows.Count; i++)
            {
                dataGridView1.Rows[i].DefaultCellStyle.SelectionBackColor = Color.Black;

                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "Analisado")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Blue;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.Yellow;
                }
                if (dataGridView1.Rows[i].Cells[11].Value.ToString() == "Finalizado")
                {
                    dataGridView1.Rows[i].DefaultCellStyle.ForeColor = Color.Green;
                    dataGridView1.Rows[i].DefaultCellStyle.SelectionForeColor = Color.LightPink;
                }
            }
        }*/
    }
}
