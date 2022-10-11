using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.dto.manutencao
{
    internal class solicitacaoPecaDto
    {
        private string nRequisicao;
        private string nOs;
        private string codigoPeca;
        private string descricaoPeca;
        private string qtd;
        private string unidade;
        private string asu;
        private string usuarioSolicitacao;
        private string dataHoraSolicitacao;
        private string statusSolicitacao;
        private string usuarioAutorizacao;
        private string dataHoraAutorizacao;
        private string msg;
        private DataTable dt;

        public string NRequisicao
        {
            get { return nRequisicao; }
            set { nRequisicao = value; }
        }

        public string NOs
        {
            get { return nOs; }
            set { nOs = value; }
        }

        public string CodigoPeca
        {
            get { return codigoPeca; }
            set { codigoPeca = value; }
        }

        public string DescricaoPeca
        {
            get { return descricaoPeca; }
            set { descricaoPeca = value; }
        }

        public string Qtd
        {
            get { return qtd; }
            set { qtd = value; }
        }

        public string Unidade
        {
            get { return unidade; }
            set { unidade = value; }
        }

        public string ASU
        {
            get { return asu; }
            set { asu = value; }
        }

        public string UsuarioSolicitacao
        {
            get { return usuarioSolicitacao; }
            set { usuarioSolicitacao = value; }
        }

        public string DataHoraSolicitacao
        {
            get { return dataHoraSolicitacao; }
            set { dataHoraSolicitacao = value; }
        }

        public string StatusSolicitacao
        {
            get { return statusSolicitacao; }
            set { statusSolicitacao = value; }
        }

        public string UsuarioAutorizacao
        {
            get { return usuarioAutorizacao; }
            set { usuarioAutorizacao = value; }
        }

        public string DataHoraAutorizacao
        {
            get { return dataHoraAutorizacao; }
            set { dataHoraAutorizacao = value; }
        }

        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
            
        public DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }

    }
}
