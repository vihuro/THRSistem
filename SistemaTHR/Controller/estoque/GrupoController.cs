using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Controller.estoque
{
    internal class GrupoController
    {
        private string id;
        private string grupo;
        private string usuarioGravacao;
        private string dataHoraGravacao;
        private DataTable dt;
        private string msg;
        private List<string> lista;
        private bool exists = false;

        public string Id { get => id; set => id = value; }
        public string Grupo { get => grupo; set => grupo = value; }
        public string UsuarioGravacao { get => usuarioGravacao; set => usuarioGravacao = value; }
        public string DataHoraGravacao { get => dataHoraGravacao; set => dataHoraGravacao = value; }
        public DataTable Dt { get => dt; set => dt = value; }
        public string Msg { get => msg; set => msg = value; }
        public List<string> Lista { get => lista; set => lista = value; }
        public bool Exists { get => exists; set => exists = value; }
    }
}
