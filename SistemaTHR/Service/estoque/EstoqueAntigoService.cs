using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.estoque;
using SistemaTHR.Controller.estoque;
using SistemaTHR.DAO.Estoque;

namespace SistemaTHR.Service.estoque
{
    internal class EstoqueAntigoService
    {

        private EstoqueAntigoDto dto;
        private EstoqueAntigoDao dao = new EstoqueAntigoDao();

        public void SelectCodigoAntigo(EstoqueAntigoController controller)
        {
            dto = new EstoqueAntigoDto();
            dto.Codigo = controller.Codigo;
            dao.SelectCodigoAntigo(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Exits = dto.Exits;
                controller.ListaCodigo = dto.ListaCodigo;
            }
        }
    }
}
