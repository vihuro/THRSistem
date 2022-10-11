using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Service.manutencao
{
    internal class prioridadeManService
    {
        Controller.manutencao.prioridadeManController controller;
        DAO.Manutencao.prioridadeManDAO dao = new DAO.Manutencao.prioridadeManDAO();
        dto.manutencao.prioidadeManDto dto;

        private void selectList()
        {
            dto = new dto.manutencao.prioidadeManDto();
            dao.List(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.List = dto.List;
            }
            
        }

        public void List(Controller.manutencao.prioridadeManController controller)
        {
            this.controller = controller;
            selectList();
        }

        private void selectTable()
        {
            dto = new dto.manutencao.prioidadeManDto();
            dao.Table(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
            
        }

        public void Table(Controller.manutencao.prioridadeManController controller)
        {
            this.controller = controller;
            selectTable();
        }

        private void insertPrioridade()
        {
            dto = new dto.manutencao.prioidadeManDto();
            dto.Prioridade = controller.Prioridade;
            dto.UsuarioGravacao = controller.UsuarioGravacao;
            dto.DataHoraGravacao = controller.DataHoraGravacao;
            dao.insert(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void insert(Controller.manutencao.prioridadeManController controller)
        {
            this.controller = controller;
            insertPrioridade();
        }

        private void deletePrioridade()
        {
            dto = new dto.manutencao.prioidadeManDto();
            dto.Codigo = controller.Codigo;
            dao.delete(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void delete(Controller.manutencao.prioridadeManController controller)
        {
            this.controller = controller;
            deletePrioridade();
        }

    }
}
