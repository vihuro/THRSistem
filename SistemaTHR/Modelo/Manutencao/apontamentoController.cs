using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo.Manutencao
{
    internal class apontamentoController
    {
        public String apontamento;
        public String geracao;
        public String msg;
        public List<String> apont = new List<string>();
        public DataTable dt = new DataTable();

        DAO.Manutencao.apontamentoDAO dao;

        private void selectApontamento()
        {
            dao = new DAO.Manutencao.apontamentoDAO();
            dao.geracao = this.geracao;
            dao.selectApont();
            this.dt = dao.dt;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }

        }
        public void selectApont()
        {
            selectApontamento();
        }

        private void insertApontamento()
        {
            dao = new DAO.Manutencao.apontamentoDAO();
            dao.apontamento = this.apontamento;
            dao.geracao = this.geracao;
            dao.insertApont();
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void insertApont()
        {
            insertApontamento();
        }

        private void selectApontSitu()
        {
            dao = new DAO.Manutencao.apontamentoDAO();

            dao.geracao = this.geracao;
            dao.selectSituacao();
            this.apont = dao.apont;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void selectSituacao()
        {
            selectApontSitu();
        }


    }
}
