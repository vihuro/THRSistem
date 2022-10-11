using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Controller.estoque
{
    public class EstoqueController
    {
        private string codRef;
        private string codigo;
        private string descricao;
        private string unidade;
        private string grupo;
        private string fornecedor;
        private string ruaBox;
        private string usuario;
        private string dataHoraCadatro;
        private string estoqueMinimo;
        private string estoqueMaximo;
        private string estoqueSeguranca;
        private DataTable dt;
        private string msg;
        private bool exits;
        private List<string> codigoList;
        private List<string> descricaoList;

        public string CodRef { get => codRef; set => codRef = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Unidade { get => unidade; set => unidade = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }
        public string RuaBox { get => ruaBox; set => ruaBox = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string DataHoraCadatro { get => dataHoraCadatro; set => dataHoraCadatro = value; }
        public string EstoqueMinimo { get => estoqueMinimo; set => estoqueMinimo = value; }
        public string EstoqueMaximo { get => estoqueMaximo; set => estoqueMaximo = value; }
        public string EstoqueSeguranca { get => estoqueSeguranca; set => estoqueSeguranca = value; }
        public DataTable Dt { get => dt; set => dt = value; }
        public string Msg { get => msg; set => msg = value; }
        public bool Exits { get => exits; set => exits = value; }
        public List<string> CodigoList { get => codigoList; set => codigoList = value; }
        public List<string> DescricaoList { get => descricaoList; set => descricaoList = value; }
    }
}
