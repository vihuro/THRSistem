using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.dto.manutencao
{
    internal class EstoquePecasRadarDto
    {
        private string codigo;
        private string descricao;
        private string unidade;

        public string Codigo { get => codigo; set => codigo = value; }
        public string Descricao { get => descricao; set => descricao = value; }
        public string Unidade { get => unidade; set => unidade = value; }
    }
}
