using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo.Producao
{
    internal class fichaController
    {
        DAO.Producao.FichaDao dao;
        public DataTable dt = new DataTable();
        public String id;
        public String lote;
        public String descricao;
        public String codigo;
        public String dataHoraInicio;
        public String dataHoraFinAnalise;
        public String dataHoraFinProd;
        public String status;
        public String msg;

        private void selectFichaImpressao()
        {
            dao = new DAO.Producao.FichaDao();
            dao.selectFicha();
            this.dt = dao.dt;
            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }
        public void selectFicha()
        {
            selectFichaImpressao();
        }

        private void selectIdFicha()
        {
            dao = new DAO.Producao.FichaDao();
            dao.selectFicha();
            this.id = dao.id;
            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }
        public void selectId()
        {
            selectIdFicha();
        }

        private void insertFicha()
        {
            dao = new DAO.Producao.FichaDao();
            dao.lote = this.lote;
            dao.codigo = this.codigo;
            dao.dataHoraInicio = this.dataHoraInicio;
            dao.status = this.status;
            dao.insert();
            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }
        public void insert()
        {
            insertFicha();
        }



        private void updateFichaCQ()
        {
            dao = new DAO.Producao.FichaDao();
            dao.dataHoraFinAnalise = this.dataHoraFinAnalise;
            dao.status = this.status;
            dao.id = this.id;
            dao.updateCQ();
            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }
        public void updateCQ()
        {
            updateFichaCQ();

        }

        private void updateFichaProd()
        {
            dao = new DAO.Producao.FichaDao();
            dao.dataHoraFinAnalise = this.dataHoraFinAnalise;
            dao.status = this.status;
            dao.id = this.id;
            dao.updateProd();
            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void updateProd()
        {
            updateFichaProd();
        }

        private void painelFichas()
        {
            dao = new DAO.Producao.FichaDao();
            dao.painel();
            this.dt = dao.dt;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void painel()
        {
            painelFichas();
        }

    }
}
