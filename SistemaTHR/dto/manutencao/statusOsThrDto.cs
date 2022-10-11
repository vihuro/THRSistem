using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.dto.manutencao
{
    internal class statusOsThrDto
    {
        private string nStatus;
        private string nOsThr;
        private string andamento;
        private string dataHoraApontamento;
        private string usuarioApontamento;
        private string dataHoraAlteracao;
        private string usuarioAlteracao;
        private string observacao;
        private string msg;
        private DataTable dt;
        private List<string> apontamento;

        public string NStatus
        {
            get { return nStatus; }
            set { nStatus = value; }
        }

        public string NOsThr
        {
            get { return nOsThr; }
            set { nOsThr = value; }
        }

        public string Andamento
        {
            get { return andamento; }
            set { andamento = value; }
        }

        public string DataHoraApontamento
        {
            get { return dataHoraApontamento; }
            set { dataHoraApontamento = value; }
        }

        public string UsuarioApontamento
        {
            get { return usuarioApontamento; }
            set { usuarioApontamento = value; }
        }

        public string DataHoraAlteracao
        {
            get { return dataHoraAlteracao; }
            set { dataHoraAlteracao = value; }
        }

        public string UsuarioAlteracao
        {
            get { return usuarioAlteracao; }
            set { usuarioAlteracao = value; }
        }

        public string Observacao
        {
            get { return observacao; }
            set { observacao = value; }
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
        public List<string> Apontamento
        {
            get { return apontamento; }
            set { apontamento = value; }
        }
    }
}
