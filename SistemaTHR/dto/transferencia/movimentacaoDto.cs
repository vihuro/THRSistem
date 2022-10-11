using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.dto.transferencia
{
    public class movimentacaoDto
    {
        private string id;
        private string numeroPa;
        private string codigo;
        private string descricao;
        private string pesoBruto;
        private string pesoLiquido;
        private string bobinas;
        private string idTransferencia;
        private string usuario;
        private DataTable dt;
        private string msg;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string NumeroPa
        {
            get { return numeroPa; }
            set { numeroPa = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string PesoBruto
        {
            get { return pesoBruto; }
            set { pesoBruto = value; }
        }

        public string PesoLiquido
        {
            get { return pesoLiquido; }
            set { pesoLiquido = value; }
        }

        public string Bobinas
        {
            get { return bobinas; }
            set { bobinas = value; }
        }

        public string IdTansferencia
        {
            get { return idTransferencia; }
            set { idTransferencia = value; }
        }

        public string Usuario
        {
            get { return usuario; }
            set { usuario = value; }
        }

        public DataTable Dt
        {
            get { return dt; }
            set { dt= value; }
        }

        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
    }
}
