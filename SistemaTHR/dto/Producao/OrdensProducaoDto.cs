using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.dto.Producao
{
    internal class OrdensProducaoDto
    {
        private string opMae;
        private string ordemProducaoOpSituacao;
        private string ordemProducaoChaveOpMae;
        private string itemNomeCliente;
        private string numeroPedido;
        private string dataEmissao;
        private string codigoMaterial;
        private string descricaoMaterial;
        private string procDescricao;
        private string previsaoInicio;
        private string previsaoConclusao;
        private string realizadoInicio;
        private string realizadoConclusao;
        private string situacao;
        private DataTable dt;
        private string msg;

        public string OpMae { get => opMae; set => opMae = value; }
        public string OrdemProducaoOpSituacao { get => ordemProducaoOpSituacao; set => ordemProducaoOpSituacao = value; }
        public string OrdemProducaoChaveOpMae { get => ordemProducaoChaveOpMae; set => ordemProducaoChaveOpMae = value; }
        public string ItemNomeCliente { get => itemNomeCliente; set => itemNomeCliente = value; }
        public string NumeroPedido { get => numeroPedido; set => numeroPedido = value; }
        public string DataEmissao { get => dataEmissao; set => dataEmissao = value; }
        public string CodigoMaterial { get => codigoMaterial; set => codigoMaterial = value; }
        public string DescricaoMaterial { get => descricaoMaterial; set => descricaoMaterial = value; }
        public string ProcDescricao { get => procDescricao; set => procDescricao = value; }
        public string PrevisaoInicio { get => previsaoInicio; set => previsaoInicio = value; }
        public string PrevisaoConclusao { get => previsaoConclusao; set => previsaoConclusao = value; }
        public string RealizadoInicio { get => realizadoInicio; set => realizadoInicio = value; }
        public string RealizadoConclusao { get => realizadoConclusao; set => realizadoConclusao = value; }
        public string Situacao { get => situacao; set => situacao = value; }
        public DataTable Dt { get => dt; set => dt = value; }
        public string Msg { get => msg; set => msg = value; }
    }
}
