using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Controller.manutencao
{
    internal class asuController
    {
        private string codigo;
        private string asu;
        private string usuarioGravacao;
        private string dataHoraGravacao;
        private string msg;
        private List<string> asuList;
        private DataTable dt;

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }
        public string Asu 
        {
            get { return asu; }
            set { asu = value; }
        }
        public string UsuarioGravao
        {
            get { return usuarioGravacao; }
            set { usuarioGravacao = value; }
        }
        public string DataHoraGravacao
        {
            get { return dataHoraGravacao; }
            set { dataHoraGravacao = value; }
        }
        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
        public List<string> AsuList
        {
            get { return asuList; }
            set { asuList = value; }
        }
        public DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }
    }
}
