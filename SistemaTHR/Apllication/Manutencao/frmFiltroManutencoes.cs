using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.Service.Exepction;
using SistemaTHR.Service.manutencao;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace SistemaTHR.Apllication
{
    public partial class frmFiltroManutencoes : Form
    {
        frmManutencao manutencao;
        private osThrService service;
        private aseService aondeSeraService;
        public string pesquisa;


        public frmFiltroManutencoes(frmManutencao manutencao)
        {
            InitializeComponent();
            CriarLista();
            service = new osThrService();
            aondeSeraService = new aseService();
            this.manutencao = manutencao;
        }

        private List<CheckBox> CriarLista()
        {
            var list = new List<CheckBox>();
            for (int i = 0; i < groupBox1.Controls.Count; i++)
            {
                list.Add((CheckBox)groupBox1.Controls[i]);
            }

            return list;
        }

        private void LoadGridView()
        {
            try
            {                
                dataGridView1.DataSource = service.Table();

            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }




        private void btnFiltrar_Click(object sender, EventArgs e)
        {

            manutencao.Pesquisa = this.pesquisa;

            if (pesquisa != string.Empty)
            {
                manutencao.loadGridView1();

            }

            this.Close();

        }

        private void frmFiltroManutencoes_Load(object sender, EventArgs e)
        {
            LoadGridView();
            CarregarComboBoxUsuario();
            CarregarAondeSera();
            CarregarTipoServico();

        }

        private void CarregarTipoServico()
        {
            foreach (var iten in CarregarTipoServicoList())
            {
                cboTipoServico.Items.Add(iten);
            }
        }

        private List<string> CarregarTipoServicoList()
        {
            var list = new List<string>();
            for(int i =0; i <  dataGridView1.Rows.Count; i++)
            {
                if(list.Count == 0)
                {
                    list.Add(dataGridView1.Rows[i].Cells[2].Value.ToString());
                }
                else
                {
                    for(int j = 0; j < list.Count; j++)
                    {
                        if (list[j] == dataGridView1.Rows[i].Cells[2].Value.ToString())
                        {
                            break;
                        }
                        else if (j == list.Count - 1)
                        {
                            list.Add(dataGridView1.Rows[i].Cells[2].Value.ToString());
                            break;
                        }
                    }
                }
            }

            return list;
        }

        private void CarregarAondeSera()
        {
            try
            {
                foreach (var iten in aondeSeraService.List())
                {
                    cboAondeSeraExcecutado.Items.Add(iten);
                }
            }
            catch (ExceptionService ex)
            {

                MessageBox.Show(ex.Message, "SISTEMA THR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void CarregarComboBoxUsuario()
        {
            foreach(var iten in CarregarUsuarioList())
            {
                cboUsuarioSolicitacao.Items.Add(iten);
            }
        }

        private List<string> CarregarUsuarioList()
        {
            var list = new List<string>();
            for(int i =0; i< dataGridView1.Rows.Count; i++)
            {
                if(list.Count == 0)
                {
                    list.Add(dataGridView1.Rows[i].Cells[4].Value.ToString());
                }
                else
                {
                    for(int j =0; j< list.Count; j++)
                    {
                        if (list[j] == dataGridView1.Rows[i].Cells[4].Value.ToString())
                        {
                            break;
                        }
                        else if(j == list.Count -1)
                        {
                            list.Add(dataGridView1.Rows[i].Cells[4].Value.ToString());
                            break;
                        }
                    }
                }
            }

            return list;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            pesquisa = string.Empty;
            cboAondeSeraExcecutado.Text = string.Empty;
            cboUsuarioSolicitacao.Text = string.Empty;
            cboTipoServico.Text = string.Empty;
            chbEmAberto.Checked = false;
            chbManIni.Checked = false;
            chbOsINC.Checked = false;
            chbAutPeca.Checked = false;
            chbManFin.Checked = false;
            chbManInc.Checked = false;
            chbOsFinalizada.Checked = false;
        }

        private void chbManIni_CheckedChanged(object sender, EventArgs e)
        {
            Pesquisar("Status");
        }
        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            Pesquisar("Status");
        }
        private void chbOsINC_CheckedChanged(object sender, EventArgs e)
        {
            Pesquisar("Status");
        }
        private void chbAutPeca_CheckedChanged(object sender, EventArgs e)
        {
            Pesquisar("Status");
        }
        private void chbManFin_CheckedChanged(object sender, EventArgs e)
        {
            Pesquisar("Status");
        }
        private void chbManInc_CheckedChanged(object sender, EventArgs e)
        {
            Pesquisar("Status");
        }
        private void chbOsFinalizada_CheckedChanged(object sender, EventArgs e)
        {
            Pesquisar("Status");
        }


        private void Pesquisar(string tipo)
        {
            var list = CriarLista();
            var dt = (DataTable)dataGridView1.DataSource;
            pesquisa = "";

            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Checked)
                {

                    if (pesquisa != string.Empty)
                    {
                        pesquisa += string.Format(" OR [StatusOP] = '{0}' ", list[i].Text);
                        if (cboAondeSeraExcecutado.Text != string.Empty)
                        {
                            pesquisa += string.Format("AND [ASE] = '{0}'", cboAondeSeraExcecutado.Text);

                        }
                        if (cboTipoServico.Text != string.Empty)
                        {
                            pesquisa += string.Format("AND [TipoServico] = '{0}'", cboTipoServico.Text);

                        }
                        if (cboUsuarioSolicitacao.Text != string.Empty)
                        {
                            pesquisa += string.Format("AND [UsuarioSolicitacao] = '{0}'", cboUsuarioSolicitacao.Text);

                        }
                    }
                    else
                    {
                        pesquisa += string.Format("[StatusOP] = '{0}' ", list[i].Text);

                        if (cboAondeSeraExcecutado.Text != string.Empty)
                        {
                            pesquisa += string.Format("AND [ASE] = '{0}'", cboAondeSeraExcecutado.Text);

                        }
                        if (cboTipoServico.Text != string.Empty)
                        {
                            pesquisa += string.Format("AND [TipoServico] = '{0}'", cboTipoServico.Text);

                        }
                        if (cboUsuarioSolicitacao.Text != string.Empty)
                        {
                            pesquisa += string.Format("AND [UsuarioSolicitacao] = '{0}'", cboUsuarioSolicitacao.Text);

                        }


                    }
                }
            }
            if (pesquisa == string.Empty)
            {
                if (cboAondeSeraExcecutado.Text != string.Empty)
                {
                    pesquisa += string.Format("[ASE] = '{0}'", cboAondeSeraExcecutado.Text);

                }
                if (cboTipoServico.Text != string.Empty)
                {
                    if(pesquisa != string.Empty)
                    {
                        pesquisa += " AND ";
                    }
                    pesquisa += string.Format("[TipoServico] = '{0}'", cboTipoServico.Text);

                }
                if (cboUsuarioSolicitacao.Text != string.Empty)
                {
                    if (pesquisa != string.Empty)
                    {
                        pesquisa += " AND ";
                    }
                    pesquisa += string.Format("[UsuarioSolicitacao] = '{0}'", cboUsuarioSolicitacao.Text);

                }
            }
            dt.DefaultView.RowFilter = pesquisa;
        }

        private void cboAondeSeraExcecutado_TextChanged(object sender, EventArgs e)
        {
            Pesquisar("AondeSeraExecutado");

        }

        private void cboTipoServico_TextChanged(object sender, EventArgs e)
        {
            Pesquisar("TipoServiço");

        }

        private void cboUsuarioSolicitacao_TextChanged(object sender, EventArgs e)
        {
            Pesquisar("UsuarioSolicitacao");

        }

        private void chbPecasAutorizadas_CheckedChanged(object sender, EventArgs e)
        {
            Pesquisar("PecasAutorizadas");
        }
    }
}
