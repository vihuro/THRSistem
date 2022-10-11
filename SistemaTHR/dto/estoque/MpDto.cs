using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.dto.estoque
{
    internal class MpDto
    {
        private string codigoMaterial;
        private bool exists = false;
        private string msg;

        private string numeroMP;
        public string CodigoMaterial { get => codigoMaterial; set => codigoMaterial = value; }
        public bool Exists { get => exists; set => exists = value; }
        public string NumeroMP { get => numeroMP; set => numeroMP = value; }
        public string Msg { get => msg; set => msg = value; }
    }
}
