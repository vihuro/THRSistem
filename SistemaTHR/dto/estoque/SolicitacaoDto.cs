using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.dto.estoque
{
    internal class SolicitacaoDto
    {
        private string id;
        private string data;
        private string ordemProducao;
        private string requerente;
        private string maquina;
        private string item;
        private string descricaoItem;
        private string codigoItem;
        private string fornecedor;
        private string horaSolicitacao;
        private string horaEntrega;
        private string entregador;
        private string status;
        private string tempoEspera;
        private string observacoes;
        private string msg;
        private DataTable dt;

        public string Id { get => id; set => id = value; }
        public string Data { get => data; set => data = value; }
        public string OrdemProducao { get => ordemProducao; set => ordemProducao = value; }
        public string Requerente { get => requerente; set => requerente = value; }
        public string Maquina { get => maquina; set => maquina = value; }
        public string Item { get => item; set => item = value; }
        public string DescricaoItem { get => descricaoItem; set => descricaoItem = value; }
        public string Fornecedor { get => fornecedor; set => fornecedor = value; }
        public string HoraSolicitacao { get => horaSolicitacao; set => horaSolicitacao = value; }
        public string HoraEntrega { get => horaEntrega; set => horaEntrega = value; }
        public string Entregador { get => entregador; set => entregador = value; }
        public string Status { get => status; set => status = value; }
        public string TempoEspera { get => tempoEspera; set => tempoEspera = value; }
        public string Observacoes { get => observacoes; set => observacoes = value; }
        public string Msg { get => msg; set => msg = value; }
        public DataTable Dt { get => dt; set => dt = value; }
        public string CodigoItem { get => codigoItem; set => codigoItem = value; }

    }
}
