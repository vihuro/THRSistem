using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Service.manutencao
{
    internal class statusOsThrService
    {
        Controller.manutencao.statusOsThrController controller;
        DAO.Manutencao.statusOsTHRDao dao = new DAO.Manutencao.statusOsTHRDao();
        dto.manutencao.statusOsThrDto dto;

        private void insertStatus()
        {
            dto = new dto.manutencao.statusOsThrDto();
            dto.NOsThr = controller.NOsThr;
            dto.Andamento = controller.Andamento;
            dto.DataHoraApontamento = controller.DataHoraApontamento;
            dto.UsuarioApontamento = controller.UsuarioApontamento;
            dto.DataHoraAlteracao = controller.DataHoraAlteracao;
            dto.UsuarioAlteracao = controller.UsuarioAlteracao;
            dto.Observacao = controller.Observacao;
            dao.insert(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void insert(Controller.manutencao.statusOsThrController controller)
        {
            this.controller = controller;
            insertStatus();
        }

        public void selecTableOS(Controller.manutencao.statusOsThrController controller)
        {
            dto = new dto.manutencao.statusOsThrDto();
            dto.NOsThr = controller.NOsThr;
            dao.selecTableOS(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }

        public void tableOs(Controller.manutencao.statusOsThrController controller)
        {
            this.controller = controller;
            //selecTableOS();
        }

        private void updateStatus()
        {
            dto = new dto.manutencao.statusOsThrDto();
            dto.DataHoraApontamento = controller.DataHoraApontamento;
            dto.UsuarioApontamento = controller.UsuarioApontamento;
            dto.DataHoraAlteracao = controller.DataHoraAlteracao;
            dto.UsuarioAlteracao = controller.UsuarioAlteracao;
            dto.Observacao = controller.Observacao;
            dto.NStatus = controller.NStatus;
            dao.update(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void update(Controller.manutencao.statusOsThrController controller)
        {
            this.controller = controller;
            updateStatus();
        }

        private void desfazeApontamento()
        {
            dto = new dto.manutencao.statusOsThrDto();
            dto.DataHoraApontamento = controller.DataHoraApontamento;
            dto.UsuarioApontamento = controller.UsuarioApontamento;
            dto.DataHoraAlteracao = controller.DataHoraAlteracao;
            dto.UsuarioAlteracao = controller.UsuarioAlteracao;
            dto.NStatus = controller.NStatus;
            dao.desfazer(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void desfazer(Controller.manutencao.statusOsThrController controller)
        {
            this.controller = controller;
            desfazeApontamento();
        }
    }
}
