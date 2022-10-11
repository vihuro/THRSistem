using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Controller.manutencao
{
    internal class FiltroOSController
    {
        private string emAberto = "Em Aberto";
        private string manutencaoIniciada = "Manutenção iniciada";
        private string osINC = "OS INC";
        private string aguardandoPeca = "Aguardando AUT/PECA";
        private string pecasAutorizadas = "Peças Autorizadas";
        private string manutencaoNC = "Manutencao N/C";
        private string osFinalizada = "OS Finalizada";

        public string EmAberto { get => emAberto; }
        public string ManutencaoIniciada { get => manutencaoIniciada; }
        public string OsINC { get => osINC; }
        public string AguardandoPeca { get => aguardandoPeca;  }
        public string PecasAutorizadas { get => pecasAutorizadas; }
        public string ManutencaoNC { get => manutencaoNC; }
        public string OsFinalizada { get => osFinalizada; }

    }
}
