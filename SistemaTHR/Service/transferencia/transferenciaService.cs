using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Service.transferencia
{
    public class transferenciaService
    {
        private dto.transferencia.transferenciaDto dto;
        private Controller.transferencia.transferenciaController controller;
        private DAO.transferenciaDao dao = new DAO.transferenciaDao();

        private void insertTransferencia()
        {
            dto = new dto.transferencia.transferenciaDto();
            dto.DataHoraTransf = controller.DataHoraTransf;
            dto.UsuarioTransf = controller.UsuarioTransf;
            dao.insert(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void insert(Controller.transferencia.transferenciaController controller)
        {
            this.controller = controller;
            insertTransferencia();
        }

        private void historicoTransferencia()
        {
            dto = new dto.transferencia.transferenciaDto();
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

        public void historico(Controller.transferencia.transferenciaController controller)
        {
            this.controller = controller;
            historicoTransferencia();

        }

        private void selectTransferencia()
        {
            dto = new dto.transferencia.transferenciaDto();
            dao.selectId(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Id = dto.Id;
            }

        }

        public void selectId(Controller.transferencia.transferenciaController controller)
        {
            this.controller = controller;
            selectTransferencia();
        }

    }
}
