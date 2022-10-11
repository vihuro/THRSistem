using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.dto.estoque
{
    internal class MovimentacaoDto
    {

        private string codigoMovimentacao;
        private string codigo;
        private string descricao;
        private string movimento;
        private string dataMovimentacao;
        private string quantidade;
        private string operacao;
        private List<string> listaCodigos;
        private string msg;
        private DataTable dt;
        private string usuario;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Movimento { get => movimento; set => movimento = value; }
        public string DataMovimentacao { get => dataMovimentacao; set => dataMovimentacao = value; }
        public string Quantidade { get => quantidade; set => quantidade = value; }
        public string Operacao { get => operacao; set => operacao = value; }
        public List<string> ListaCodigos { get => listaCodigos; set => listaCodigos = value; }
        public string Msg { get => msg; set => msg = value; }
        public DataTable Dt { get => dt; set => dt = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string CodigoMovimentacao { get => codigoMovimentacao; set => codigoMovimentacao = value; }
    }
}
