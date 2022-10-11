using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Controller.manutencao
{
    internal class prioridadeManController
    {
        private string codigo;
        private string prioridade;
        private string usuarioGravacao;
        private string dataHoraGravacao;
        private List<String> list;
        private String msg;
        private DataTable dt = new DataTable();

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Prioridade
        {
            get { return prioridade; }
            set { prioridade = value; }
        }

        public string UsuarioGravacao
        {
            get { return usuarioGravacao; }
            set { usuarioGravacao = value; }
        }

        public string DataHoraGravacao
        {
            get { return dataHoraGravacao; }
            set { dataHoraGravacao = value; }
        }

        public List<String> List
        {
            get { return list; }
            set { list = value; }
        }

        public String Msg
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
