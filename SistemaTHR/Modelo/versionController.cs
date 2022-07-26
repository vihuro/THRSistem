using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo
{
    internal class versionController
    {
        public String versao;
        public String msg;
        public bool tem;
        private void verificarVersao()
        {
            DAO.version dao = new DAO.version();
            dao.versao = this.versao;
            dao.verificar();
            this.tem = dao.tem;
            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void verificar()
        {
            verificarVersao();
        }

    }
}
