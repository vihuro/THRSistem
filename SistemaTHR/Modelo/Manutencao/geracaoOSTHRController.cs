using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo
{
    internal class geracaoOSTHRController
    {
        public String usuario;
        public String dataHoraCriacao;
        public String msg;
        public String status;
        public String geracao;
        public DataTable dt = new DataTable();

        DAO.geracaoOSTHRDAO dao;

        private void selectGeracaoGRID()
        {
            dao = new DAO.geracaoOSTHRDAO();
            dao.selectGrid();
            this.dt = dao.dt;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void selectGrid()
        {
            selectGeracaoGRID();
        }

        private void insertGeracao()
        {
            dao = new DAO.geracaoOSTHRDAO();
            dao.usuario = this.usuario;
            dao.dataHoraCriacao = this.dataHoraCriacao;
            dao.status = this.status;
            dao.insert();
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void insert() 
        {
            insertGeracao();
        }

        private void updateGeracao()
        {
            dao = new DAO.geracaoOSTHRDAO();
            dao.status = this.status;
            dao.geracao = this.geracao;
            dao.updateGer();
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void updateGer()
        {
            updateGeracao();
        }

        private void selectAtivo()
        {
            dao = new DAO.geracaoOSTHRDAO();
            dao.selectAtiv();
            this.geracao = dao.geracao;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void selectAtiv()
        {
            selectAtivo();
        }

    }
}
