using System.Data;

namespace SistemaTHR.Controller.manutencao
{
    internal class movimentacaoPecasController
    {
        private string nMovimentacao;
        private string nRequisicao = "";
        private string codigoPeca;
        private string descricaoPeca;
        private string unidade;
        private string qtd;
        private string asu = "";
        private string tipoMovimentacao;
        private string status;
        private string usuarioSolicitacao = "";
        private string dataHoraSolicitacao = "";
        private string usuarioAutorizacao = "";
        private string dataHoraAutorizacao = "";
        private string usuarioMovimentacao;
        private string dataHoraMovimentacao;
        private DataTable dt;
        private string msg;

        public string NMovimentacao { get => nMovimentacao; set => nMovimentacao = value; }
        public string CodigoPeca { get => codigoPeca; set => codigoPeca = value; }
        public string DescricaoPeca { get => descricaoPeca; set => descricaoPeca = value; }
        public string Unidade { get => unidade; set => unidade = value; }
        public string Qtd { get => qtd; set => qtd = value; }
        public string Asu { get => asu; set => asu = value; }
        public string UsuarioSolicitacao { get => usuarioSolicitacao; set => usuarioSolicitacao = value; }
        public string DataHoraSolicitacao { get => dataHoraSolicitacao; set => dataHoraSolicitacao = value; }
        public string UsuarioAutorizacao { get => usuarioAutorizacao; set => usuarioAutorizacao = value; }
        public string DataHoraAutorizacao { get => dataHoraAutorizacao; set => dataHoraAutorizacao = value; }
        public string UsuarioMovimentacao { get => usuarioMovimentacao; set => usuarioMovimentacao = value; }
        public string DataHoraMovimentacao { get => dataHoraMovimentacao; set => dataHoraMovimentacao = value; }
        public DataTable Dt { get => dt; set => dt = value; }
        public string Msg { get => msg; set => msg = value; }
        public string TipoMovimentacao { get => tipoMovimentacao; set => tipoMovimentacao = value; }
        public string NRequisicao { get => nRequisicao; set => nRequisicao = value; }
        public string Status { get => status; set => status = value; }
    }
}
