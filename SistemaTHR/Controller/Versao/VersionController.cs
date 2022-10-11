using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Controller.Versao
{
    internal class VersionController
    {
        private string codigo;
        private string nVersao;
        private DataTable dt;
        private string msg;
        private bool exists;

        public string Codigo { get => codigo; set => codigo = value; }
        public string NVersao { get => nVersao; set => nVersao = value; }
        public DataTable Dt { get => dt; set => dt = value; }
        public string Msg { get => msg; set => msg = value; }
        public bool Exists { get => exists; set => exists = value; }
    }
}
