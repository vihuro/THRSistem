using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Service.manutencao
{
    internal class geracaoOsThrService
    {
        Controller.manutencao.geracaoOsTHRController controller;
        DAO.Manutencao.geracaoOSTHRDAO dao = new DAO.Manutencao.geracaoOSTHRDAO();
        dto.manutencao.geracaoOsTHRDto dto;

        private void selectTable()
        {
            dto = new dto.manutencao.geracaoOsTHRDto();
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

        public void table(Controller.manutencao.geracaoOsTHRController controller)
        {
            this.controller = controller;
            selectTable();
        }

        private void insertGeracao()
        {
            dto = new dto.manutencao.geracaoOsTHRDto();
            dto.Usuario = controller.Usuario;
            dto.DataHora = controller.DataHora;
            dto.Status = controller.Status;
            dao.insert(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void insert(Controller.manutencao.geracaoOsTHRController controller)
        {
            this.controller = controller;
            insertGeracao();
        }

        private void updateGeracao()
        {
            dto = new dto.manutencao.geracaoOsTHRDto();
            dto.Status = controller.Status;
            dto.Geracao = controller.Geracao;
            dao.update(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void update(Controller.manutencao.geracaoOsTHRController controller)
        {
            this.controller = controller;
            updateGeracao();
        }

        private void selectActive()
        {
            dto = new dto.manutencao.geracaoOsTHRDto();
            dao.active(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Geracao = dto.Geracao;
            }
        }

        public void active(Controller.manutencao.geracaoOsTHRController controller)
        {
            this.controller = controller;
            selectActive();
        }
    }
}
