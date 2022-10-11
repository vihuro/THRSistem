using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Controller.Producao
{
    public class OrdensProducaoController
    {
        private string numeroOp;
        private string numeroOpChave;
        private string opSituacao;
        private string opChaveMae;
        private string nomeCliente;
        private string numeroPedido;
        private string dataEmissao;
        private string codigoMaterial;
        private string descricaoMaterial;
        private string quantidadeProgramada;
        private string procDescricao;
        private string previsaoInicio;
        private string previsaoConclusao;
        private string realizadoInicio;
        private string realizadoConclusao;
        private string procSitucao;
        private string msg;
        private DataTable dt;

        public string NumeroOp { get => numeroOp; set => numeroOp = value; }
        public string NumeroOpChave { get => numeroOpChave; set => numeroOpChave = value; }
        public string OpSituacao { get => opSituacao; set => opSituacao = value; }
        public string OpChaveMae { get => opChaveMae; set => opChaveMae = value; }
        public string NomeCliente { get => nomeCliente; set => nomeCliente = value; }
        public string NumeroPedido { get => numeroPedido; set => numeroPedido = value; }
        public string DataEmissao { get => dataEmissao; set => dataEmissao = value; }
        public string CodigoMaterial { get => codigoMaterial; set => codigoMaterial = value; }
        public string DescricaoMaterial { get => descricaoMaterial; set => descricaoMaterial = value; }
        public string QuantidadeProgramada { get => quantidadeProgramada; set => quantidadeProgramada = value; }
        public string ProcDescricao { get => procDescricao; set => procDescricao = value; }
        public string PrevisaoInicio { get => previsaoInicio; set => previsaoInicio = value; }
        public string PrevisaoConclusao { get => previsaoConclusao; set => previsaoConclusao = value; }
        public string RealizadoInicio { get => realizadoInicio; set => realizadoInicio = value; }
        public string RealizadoConclusao { get => realizadoConclusao; set => realizadoConclusao = value; }
        public string ProcSitucao { get => procSitucao; set => procSitucao = value; }
        public string Msg { get => msg; set => msg = value; }
        public DataTable Dt { get => dt; set => dt = value; }
    }
}
