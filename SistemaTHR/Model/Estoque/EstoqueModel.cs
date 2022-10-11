using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Model.Estoque
{
    internal class EstoqueModel
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
        private int estoqueMinimo;
        private int estoqueMaximo;
        private int estoqueSeguranca;

        public string CodRef { get => codRef; set => codRef = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Unidade { get => unidade; set => unidade = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }
        public string RuaBox { get => ruaBox; set => ruaBox = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string DataHoraCadatro { get => dataHoraCadatro; set => dataHoraCadatro = value; }
        public int EstoqueMinimo { get => estoqueMinimo; set => estoqueMinimo = value; }
        public int EstoqueMaximo { get => estoqueMaximo; set => estoqueMaximo = value; }
        public int EstoqueSeguranca { get => estoqueSeguranca; set => estoqueSeguranca = value; }
    }
}
