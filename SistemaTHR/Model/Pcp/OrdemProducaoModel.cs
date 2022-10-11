using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Model.Pcp
{
    internal class OrdemProducaoModel
    {
        private string ordemProducao;
        private string dataAbertura;
        private string codigoProduto;
        private string descricaoProduto;
        private string setor;
        private string categoria;
        private string quantidade;
        private string unidade;
        private string lote;
        private string observacoes;
        private string destino;
        private string responsavel;
        private string quantidadeProduzida;

        public string OrdemProducao { get => ordemProducao; set => ordemProducao = value; }
        public string DataAbertura { get => dataAbertura; set => dataAbertura = value; }
        public string CodigoProduto { get => codigoProduto; set => codigoProduto = value; }
        public string DescricaoProduto { get => descricaoProduto; set => descricaoProduto = value; }
        public string Setor { get => setor; set => setor = value; }
        public string Categoria { get => categoria; set => categoria = value; }
        public string Quantidade { get => quantidade; set => quantidade = value; }
        public string Unidade { get => unidade; set => unidade = value; }
        public string Lote { get => lote; set => lote = value; }
        public string Observacoes { get => observacoes; set => observacoes = value; }
        public string Destino { get => destino; set => destino = value; }
        public string Responsavel { get => responsavel; set => responsavel = value; }
        public string QuantidadeProduzida { get => quantidadeProduzida; set => quantidadeProduzida = value; }
    }
}
