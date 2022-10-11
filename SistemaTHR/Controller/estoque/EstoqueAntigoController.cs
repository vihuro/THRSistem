using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Controller.estoque
{
    internal class EstoqueAntigoController
    {
        private string cogigoReferencia;
        private string codigo;
        private bool exits = false;
        private List<string> listaCodigo;
        private string msg;

        public string CogigoReferencia { get => cogigoReferencia; set => cogigoReferencia = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public bool Exits { get => exits; set => exits = value; }
        public List<string> ListaCodigo { get => listaCodigo; set => listaCodigo = value; }
        public string Msg { get => msg; set => msg = value; }
    }
}
