using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Service.manutencao
{
    internal class apontamentoOsThrService
    {
        Controller.manutencao.apontamentoOsThrController controller;
        DAO.Manutencao.apontamentoDAO dao = new DAO.Manutencao.apontamentoDAO();
        dto.manutencao.apontamentoOsTHRDto dto;

        private void selectTable()
        {
            dto = new dto.manutencao.apontamentoOsTHRDto();
            dao.table(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }

        public void table(Controller.manutencao.apontamentoOsThrController controller)
        {
            this.controller = controller;
            selectTable();
        }

        private void insertApontamento()
        {
            dto = new dto.manutencao.apontamentoOsTHRDto();
            dto.Apontamento = controller.Apontamento;
            dto.Geracao = controller.Geracao;
            dao.insert(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void insert(Controller.manutencao.apontamentoOsThrController controller)
        {
            this.controller = controller;
            insertApontamento();
        }

        private void selectList()
        {
            dto = new dto.manutencao.apontamentoOsTHRDto();
            dto.Geracao = controller.Geracao;
            dao.list(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Apont = dto.Apont;
            }
        }

        public void list(Controller.manutencao.apontamentoOsThrController controller)
        {
            this.controller = controller;
            selectList();
        }
    }
}
