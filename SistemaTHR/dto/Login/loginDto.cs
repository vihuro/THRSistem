using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.dto.Login
{
    internal class loginDto
    {
        private string nomeUsuario;
        private string senha;
        private string nome;
        private bool autorizado = false;
        private string msg;
        private DataTable dt;

        public string NomeUsuario
        {
            get { return nomeUsuario; }
            set
            {
                nomeUsuario = value;
            }
        }
        public string Senha
        {
            get { return senha; }
            set
            {
                senha = value;
            }
        }
        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public bool Autorizado
        {
            get { return autorizado; }
            set { autorizado = value; }
        }

        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }

        public DataTable Dt { get => dt; set => dt = value; }
    }
}
