using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Controller.manutencao
{
    internal class apontamentoOsThrController
    {
        private string codigo;
        private string apontamento;
        private string geracao;
        private string msg;
        private DataTable dt;
        private List<string> apont;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Apontamento
        {
            get { return apontamento; }
            set { apontamento = value; }
        }

        public string Geracao
        {
            get { return geracao; }
            set { geracao = value; }
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

        public List<string> Apont
        {
            get { return apont; }
            set { apont = value; }
        }
    }
}
