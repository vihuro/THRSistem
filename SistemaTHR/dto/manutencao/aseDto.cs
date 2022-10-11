using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.dto.manutencao
{
    internal class aseDto
    {
        private string numero;
        private string execucao;
        private string usuario;
        private string dataHora;
        private DataTable dt;
        private string msg;
        private List<string> ase;
        private bool check;

        public string Numero
        {
            get { return numero; }
            set { numero = value; }
        }

        public string Execucao
        {
            get { return execucao; }
            set { execucao = value; }
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

        public List<string> Ase
        {
            get { return ase; }
            set { ase = value; }
        }

        public bool Check
        {
            get { return check; }
            set { check = value; }
        }
    }
}
