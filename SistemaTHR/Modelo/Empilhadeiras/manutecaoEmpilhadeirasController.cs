using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo
{
    internal class manutecaoEmpilhadeirasController
    {
        public void insertSolicitacao(String numeroEmp, String descricao, String prioridade, String Status, DateTime dataHoraSolicitacao, String usuarioSolicitacao)
        {
            DAO.manutecaoEmpilhadeiraDao manutecaoEmpilhadeiraDao= new DAO.manutecaoEmpilhadeiraDao();
            manutecaoEmpilhadeiraDao.insertSolicitacao(numeroEmp, descricao, prioridade, Status, dataHoraSolicitacao, usuarioSolicitacao);
        }

        public String descricao;

        public String selectIDTrocaGas(int id)
        {
            DAO.manutecaoEmpilhadeiraDao manutecaoEmpilhadeiraDao = new DAO.manutecaoEmpilhadeiraDao();
            manutecaoEmpilhadeiraDao.selectIDTrocaGas(id);
            if (!manutecaoEmpilhadeiraDao.Equals(""))
            {
                this.descricao = manutecaoEmpilhadeiraDao.descricao;
            }

            return descricao;
        }
    }
}
