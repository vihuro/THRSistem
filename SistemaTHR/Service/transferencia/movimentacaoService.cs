using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Service.transferencia
{
    public class movimentacaoService
    {
        private dto.transferencia.movimentacaoDto dto;
        private Controller.transferencia.movimentacaoController controller;
        private DAO.Transferencia.movimentacaoDao dao = new DAO.Transferencia.movimentacaoDao();

        private void insertMovimentacao()
        {
            dto = new dto.transferencia.movimentacaoDto();
            dto.NumeroPa = controller.NumeroPa;
            dto.Codigo = controller.Codigo;
            dto.Descricao = controller.Descricao;
            dto.PesoBruto = controller.PesoBruto;
            dto.PesoLiquido = controller.PesoLiquido;
            dto.Bobinas = controller.Bobinas;
            dto.IdTansferencia = controller.IdTansferencia;
            dto.Usuario = controller.Usuario;
            dao.insert(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void insert(Controller.transferencia.movimentacaoController controller)
        {
            this.controller = controller;
            insertMovimentacao();
        }

        private void selectTable()
        {
            dto = new dto.transferencia.movimentacaoDto();
            dto.IdTansferencia = controller.IdTansferencia;
            dao.selectTable(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }

        public void table(Controller.transferencia.movimentacaoController controller)
        {
            this.controller = controller;
            selectTable();
        }

        private void deleteMovimentacao()
        {
            dto = new dto.transferencia.movimentacaoDto();
            dto.Id = controller.Id;
            dao.delete(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void delete(Controller.transferencia.movimentacaoController controller)
        {
            this.controller = controller;
            deleteMovimentacao();
        }


    }
}
