using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Controller.manutencao
{
    public class osThrController
    {
        private string nOs;
        private string descricao;
        private string tipoServico;
        private string dataHora;
        private string usuario;
        private string ase;
        private string categoria;
        private string dataIdeal;
        private string prioridade;
        private string usuarioPrioridade;
        private string dataHoraPrioridade;
        private string statusOs;
        private string dataHoraFinalizacao;
        private DataTable dt;
        private string msg;


        //filtros
        private string emAberto;
        private string manutenacaoIniciada;
        private string ordemINC;
        private string aguardandoPeca;
        private string manutencaoFinalizada;
        private string manutencaoNC;
        private string ordemFinalizada;

        public string NOs
        {
            get { return nOs; }
            set { nOs = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string TipoServico
        {
            get { return tipoServico; }
            set { tipoServico = value; }
        }

        public string DataHora
        {
            get { return dataHora; }
            set { dataHora = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string Ase
        {
            get { return ase; }
            set { ase = value; }
        }

        public string Categoria
        {
            get { return categoria; }
            set { categoria = value; }
        }

        public string DataIdeal
        {
            get { return dataIdeal; }
            set { dataIdeal = value; }
        }

        public string Prioridade
        {
            get { return prioridade; }
            set { prioridade = value; }
        }

        public string UsuarioPrioridade
        {
            get { return usuarioPrioridade; }
            set { usuarioPrioridade = value; }
        }

        public string DataHoraPrioridade
        {
            get { return dataHoraPrioridade; }
            set { dataHoraPrioridade = value; }
        }

        public string StatusOs
        {
            get { return statusOs; }
            set { statusOs = value; }
        }

        public string DataHoraFinalizacao
        {
            get { return dataHoraFinalizacao; }
            set { dataHoraFinalizacao = value; }
        }

        public DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }

        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }

        public string EmAberto { get => emAberto; set => emAberto = value; }
        public string ManutenacaoIniciada { get => manutenacaoIniciada; set => manutenacaoIniciada = value; }
        public string OrdemINC { get => ordemINC; set => ordemINC = value; }
        public string AguardandoPeca { get => aguardandoPeca; set => aguardandoPeca = value; }
        public string ManutencaoFinalizada { get => manutencaoFinalizada; set => manutencaoFinalizada = value; }
        public string ManutencaoNC { get => manutencaoNC; set => manutencaoNC = value; }
        public string OrdemFinalizada { get => ordemFinalizada; set => ordemFinalizada = value; }
    }
}
