using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo.Producao
{
    internal class selectLoteController
    {
        DAO.Produção.selectLoteDao dao;
        public String lote;
        public String codigo;
        public String descricao;
        public String msg;

        private void selectLote()
        {
            dao = new DAO.Produção.selectLoteDao();
            dao.lote = this.lote;
            dao.selectLot();
            this.descricao = dao.descricao;
            this.codigo = dao.codigo;
            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }

        }

        public void selectLot()
        {
            selectLote();
        }
    }
}
