using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.dto.manutencao
{
    internal class geracaoOsTHRDto
    {
        private string geracao;
        private string usuario;
        private string dataHora;
        private string status;
        private DataTable dt;
        private List<string> situacao;
        private string msg;

        public string Geracao
        {
            get { return geracao; }
            set { geracao = value; }
        }
        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public string DataHora
        {
            get { return dataHora; }
            set { dataHora = value; }
        }

        public string Status
        {
            get { return status; }
            set { status = value; }
        }

        public DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }

        public List<string> Situacao
        {
            get { return situacao; }
            set { situacao = value; }
        }

        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
    }
}
