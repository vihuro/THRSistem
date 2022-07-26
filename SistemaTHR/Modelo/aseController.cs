using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo
{
    internal class aseController
    {
        public String numero;
        public String execucao;
        public String usuarioCadastro;
        public String dataHoraCadastro;
        public String msg;
        public DataTable dt;
        public bool tem;

        public List<String> ase = new List<String>();

        DAO.aseDao dao;

        private void selectExecucao()
        {
            dao = new DAO.aseDao();
            dao.selectEx();
            this.dt = dao.dt;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }

        }

        public void selectEx()
        {
            selectExecucao();
        }

        private void insertExecuxao()
        {
            dao = new DAO.aseDao();
            dao.execucao = this.execucao;
            dao.usuarioCadastro = this.usuarioCadastro;
            dao.dataHoraCadastro = this.dataHoraCadastro;
            dao.insertEx();
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void insertEx()
        {
            insertExecuxao();
        }

        private void deleteExecuxao()
        {
            dao = new DAO.aseDao();
            dao.numero = this.numero;
            dao.deleteEx();
            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void deleteEx()
        {
            deleteExecuxao();
        }

        public void selectASE()
        {
            dao = new DAO.aseDao();
            dao.ASE();
            this.ase = dao.ase;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void ASE()
        {
            selectASE();
        }

        private void verificarEx()
        {
            dao = new DAO.aseDao();
            dao.execucao = this.execucao;
            dao.verificar();
            this.tem = dao.tem;
            if(dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void verificar()
        {
            verificarEx();
        }

    }
}
