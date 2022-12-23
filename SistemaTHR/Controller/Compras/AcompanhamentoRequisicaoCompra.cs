using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Controller.Compras
{
    internal class AcompanhamentoRequisicaoCompra
    {
        private string id;
        private string numeroRequisicao;
        private string descricaoRequisicao;
        private string dataHoraApontamento;
        private string usuarioApontamento;
        private string dataHoraAlteracao;
        private string usuarioAlteracao;
        private string observacao;

        public string Id { get => id; set => id = value; }
        public string NumeroRequisicao { get => numeroRequisicao; set => numeroRequisicao = value; }
        public string DescricaoRequisicao { get => descricaoRequisicao; set => descricaoRequisicao = value; }
        public string DataHoraApontamento { get => dataHoraApontamento; set => dataHoraApontamento = value; }
        public string UsuarioApontamento { get => usuarioApontamento; set => usuarioApontamento = value; }
        public string DataHoraAlteracao { get => dataHoraAlteracao; set => dataHoraAlteracao = value; }
        public string UsuarioAlteracao { get => usuarioAlteracao; set => usuarioAlteracao = value; }
        public string Observacao { get => observacao; set => observacao = value; }
    }
}
