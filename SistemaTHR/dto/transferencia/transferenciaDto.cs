using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.dto.transferencia
{
    public class transferenciaDto
    {
        private string id;
        private string dataHoraTransf;
        private string usuarioTransf;
        private DataTable dt;
        private string msg;

        public string Id
        {
            get { return id; }
            set { id = value; }
        }

        public string DataHoraTransf
        {
            get { return dataHoraTransf; }
            set { dataHoraTransf = value; }
        }

        public string UsuarioTransf
        {
            get { return usuarioTransf; }
            set { usuarioTransf = value; }
        }

        public DataTable Dt
        {
            get { return dt; }
            set { dt = value; }
        }

        public string Msg
        {
            get { return msg; }
            set { msg = value; }
        }
    }
}
