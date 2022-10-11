using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Controller.estoque
{
    public class MovimentacaoController
    {
        private string codigo;
        private string descricao;
        private string movimento;
        private string dataMovimentacao;
        private string quantidade;
        private string operacao;
        private List<string> listaCodigos;
        private string msg;
        private DataTable dt;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Movimento { get => movimento; set => movimento = value; }
        public string DataMovimentacao { get => dataMovimentacao; set => dataMovimentacao = value; }
        public string Quantidade { get => quantidade; set => quantidade = value; }
        public string Operacao { get => operacao; set => operacao = value; }
        public List<string> ListaCodigos { get => listaCodigos; set => listaCodigos = value; }
        public string Msg { get => msg; set => msg = value; }
        public DataTable Dt { get => dt; set => dt = value; }
    }
}
