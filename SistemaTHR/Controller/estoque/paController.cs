using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Controller.estoque
{
    internal class paController
    {
        private string numeroPa;
        private string descricao;
        private string codigo;
        private double pesoBruto;
        private double pesoLiquido;
        private double bobinas;
        private string msg;

        public string NumeroPa
        {
            get { return numeroPa; }
            set { numeroPa = value; }
        }

        public string Descricao
        {
            get { return descricao; }
            set { descricao = value; }
        }

        public string Codigo
        {
            get { return codigo; }
            set { codigo = value; }
        }

        public double PesoBruto
        {
            get { return pesoBruto; }
            set { pesoBruto = value; }
        }

        public double PesoLiquido
        {
            get { return pesoLiquido; }
            set { pesoLiquido = value; }
        }

        public double Bobinas
        {
            get { return bobinas; }
            set { bobinas = value; }
        }

        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
    }
}
