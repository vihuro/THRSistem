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
        private string prioridade;
        private string dataHoraEsperadaEntrega;
        private string valorProduto;
        private string freteIncluso;
        private string fornecedor;
        private string frete;
        private string estadoDaCompra;
        private string usuarioSolicitacao;
        private string dataHoraSolicitacao;
        private string status;
        private string usuarioAutorizador;
        private string dataHoraAutorizacao;

        public string NRequisicao { get => nRequisicao; set => nRequisicao = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Quantidade { get => quantidade; set => quantidade = value; }
        public string Unidade { get => unidade; set => unidade = value; }
        public string Prioridade { get => prioridade; set => prioridade = value; }
        public string DataHoraEsperadaEntrega { get => dataHoraEsperadaEntrega; set => dataHoraEsperadaEntrega = value; }
        public string ValorProduto { get => valorProduto; set => valorProduto = value; }
        public string FreteIncluso { get => freteIncluso; set => freteIncluso = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }
        public string Frete { get => frete; set => frete = value; }
        public string EstadoDaCompra { get => estadoDaCompra; set => estadoDaCompra = value; }
        public string UsuarioSolicitacao { get => usuarioSolicitacao; set => usuarioSolicitacao = value; }
        public string DataHoraSolicitacao { get => dataHoraSolicitacao; set => dataHoraSolicitacao = value; }
        public string Status { get => status; set => status = value; }
        public string UsuarioAutorizador { get => usuarioAutorizador; set => usuarioAutorizador = value; }
        public string DataHoraAutorizacao { get => dataHoraAutorizacao; set => dataHoraAutorizacao = value; }

    }
}
