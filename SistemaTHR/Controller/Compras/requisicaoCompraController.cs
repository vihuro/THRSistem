using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Controller.Compras
{
    internal class requisicaoCompraController
    {
        private string nRequisicao;
        private string codigo;
        private string descricao;
        private string quantidade;
        private string unidade;
        private string usuarioSolicitacao;
        private string dataHoraSolicitacao;
        private string status;
        private string usuarioAutorizador;
        private string dataHoraAutorizacao;
        private string usuarioCompra;
        private string dataHotaCompra;
        private string observacao;
        private string msg;
        private DataTable dt;

        public string NRequisicao { get => nRequisicao; set => nRequisicao = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Quantidade { get => quantidade; set => quantidade = value; }
        public string Unidade { get => unidade; set => unidade = value; }
        public string UsuarioSolicitacao { get => usuarioSolicitacao; set => usuarioSolicitacao = value; }
        public string DataHoraSolicitacao { get => dataHoraSolicitacao; set => dataHoraSolicitacao = value; }
        public string Status { get => status; set => status = value; }
        public string UsuarioCompra { get => usuarioCompra; set => usuarioCompra = value; }
        public string DataHotaCompra { get => dataHotaCompra; set => dataHotaCompra = value; }
        public string Observacao { get => observacao; set => observacao = value; }
        public string Msg { get => msg; set => msg = value; }
        public DataTable Dt { get => dt; set => dt = value; }
        public string UsuarioAutorizador { get => usuarioAutorizador; set => usuarioAutorizador = value; }
        public string DataHoraAutorizacao { get => dataHoraAutorizacao; set => dataHoraAutorizacao = value; }
    }
}
