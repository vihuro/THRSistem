using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Service.manutencao
{
    internal class aseService
    {
        private Controller.manutencao.aseController controller;
        private dto.manutencao.aseDto dto;
        private DAO.Manutencao.aseDao dao = new DAO.Manutencao.aseDao();

        private void selectTable()
        {
            dto = new dto.manutencao.aseDto();
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

        public void table(Controller.manutencao.aseController controller)
        {
            this.controller = controller;
            selectTable();
        }

        private void insertEx()
        {
            dto = new dto.manutencao.aseDto();
            dto.Execucao = controller.Execucao;
            dto.Usuario = controller.Usuario;
            dto.DataHora = controller.DataHora;
            dao.insert(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void insert(Controller.manutencao.aseController controller)
        {
            this.controller = controller;
            insertEx();
        }

        private void deleteEx()
        {
            dto = new dto.manutencao.aseDto();
            dto.Numero = controller.Numero;
            dao.delete(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void delete(Controller.manutencao.aseController controller)
        {
            this.controller = controller;
            deleteEx();
        }

        private void selectList()
        {
            dto = new dto.manutencao.aseDto();
            dao.list(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Ase = dto.Ase;
            }
        }

        public void list(Controller.manutencao.aseController controller)
        {
            this.controller = controller;
            selectList();
        }

        private void verificarEx()
        {
            dto = new dto.manutencao.aseDto();
            dto.Execucao = controller.Execucao;
            dao.verificar(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Check = dto.Check;
            }
        }

        public void verificar(Controller.manutencao.aseController controller)
        {
            this.controller = controller;
            verificarEx();
        }
    }
}
