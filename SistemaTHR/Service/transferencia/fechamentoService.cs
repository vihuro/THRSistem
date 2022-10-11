using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Service.transferencia
{
    public class fechamentoService
    {
        Controller.transferencia.fechamentoController controller;
        dto.transferencia.fechamentoDto dto;
        DAO.Transferencia.fechamentoDao dao = new DAO.Transferencia.fechamentoDao();

        private void insertFechamento()
        {
            dto = new dto.transferencia.fechamentoDto();
            dto.Codigo = controller.Codigo;
            dto.Descricao = controller.Descricao;
            dto.PesoBruto = controller.PesoBruto;
            dto.PesoLiquido = controller.PesoLiquido;
            dto.Bobinas = controller.Bobinas;
            dto.IdTransferencia = controller.IdTransferencia;
            dao.Insert(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void insert(Controller.transferencia.fechamentoController controller)
        {
            this.controller = controller;
            insertFechamento();
        }

        private void selectTable()
        {
            dto = new dto.transferencia.fechamentoDto();
            dto.IdTransferencia = controller.IdTransferencia;
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

        public void table(Controller.transferencia.fechamentoController controller)
        {
            this.controller = controller;
            selectTable();
        }

        private void deleteFechamento()
        {
            dto = new dto.transferencia.fechamentoDto();
            dto.Id = controller.Id;
            dao.delete(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void delete(Controller.transferencia.fechamentoController controller)
        {
            this.controller = controller;
            deleteFechamento();
        }

        private void updateFechamento()
        {
            dto = new dto.transferencia.fechamentoDto();
            dto.PesoBruto = controller.PesoBruto;
            dto.PesoLiquido = controller.PesoLiquido;
            dto.Bobinas = controller.Bobinas;
            dto.Id = controller.Id;
            dao.update(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void update(Controller.transferencia.fechamentoController controller)
        {
            this.controller = controller;
            updateFechamento();
        }
    }
}
