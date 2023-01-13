using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.dto.manutencao
{
    public class EstoquePecasDto
    {
        private string nPecas;
        private string codigo;
        private string descricao;
        private string unidade;
        private string qtEstoque;
        private string estoqueMax;
        private string estoqueMin;
        private string fornecedor1 = "";
        private string codFornecedor1 = "";
        private string fornecedor2 = "";
        private string codFornecedor2 = "";
        private string fornecedor3 = "";
        private string codFornecedor3 = "";
        private string usuarioGravacao;
        private string dataHoraGravacao;
        private string msg;
        private bool exists = false;
        private DataTable dt;

        public EstoquePecasDto() { }

        public string NPecas { get => nPecas; set => nPecas = value; }
        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Unidade { get => unidade; set => unidade = value; }
        public string QtEstoque { get => qtEstoque; set => qtEstoque = value; }
        public string EstoqueMax { get => estoqueMax; set => estoqueMax = value; }
        public string EstoqueMin { get => estoqueMin; set => estoqueMin = value; }
        public string UsuarioGravacao { get => usuarioGravacao; set => usuarioGravacao = value; }
        public string DataHoraGravacao { get => dataHoraGravacao; set => dataHoraGravacao = value; }
        public string Msg { get => msg; set => msg = value; }
        public DataTable Dt { get => dt; set => dt = value; }
        public string CodFornecedor1 { get => codFornecedor1; set => codFornecedor1 = value; }
        public string CodFornecedor2 { get => codFornecedor2; set => codFornecedor2 = value; }
        public string CodFornecedor3 { get => codFornecedor3; set => codFornecedor3 = value; }
        public bool Exists { get => exists; set => exists = value; }
        public string Fornecedor1 { get => fornecedor1; set => fornecedor1 = value; }
        public string Fornecedor2 { get => fornecedor2; set => fornecedor2 = value; }
        public string Fornecedor3 { get => fornecedor3; set => fornecedor3 = value; }
    }
}
