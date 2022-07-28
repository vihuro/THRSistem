using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo
{
    internal class situacaoOSTHRController
    {
        public String situacao;
        public String codigo;
        public String msg;
        public DataTable dt = new DataTable();

        DAO.situacaoOSTHRDao dao;

        private void selectSituacao()
        {
            dao = new DAO.situacaoOSTHRDao();
            dao.selectSit();
            this.dt = dao.dt;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void selectSit()
        {
            selectSituacao();
        }

        private void insertSituacao()
        {
            dao = new DAO.situacaoOSTHRDao();
            dao.situacao = this.situacao;
            dao.insert();
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void insert()
        {
            insertSituacao();
        }
        private void deletSituacao()
        {
            dao = new DAO.situacaoOSTHRDao();
            dao.codigo = this.codigo;
            dao.delete();
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void delete()
        {
            deletSituacao();
        }

    }
}
