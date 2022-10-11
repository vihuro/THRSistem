using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Service.Versao
{
    internal class VersaoService
    {
        private Controller.Versao.VersionController controller;
        private DAO.Versao.version dao = new DAO.Versao.version();
        private dto.Versao.versaoDto dto;

        private void verificarVersao()
        {
            dto = new dto.Versao.versaoDto();
            dto.NVersao = controller.NVersao;
            dao.verificar(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Exists = dto.Exists;
            }
        } 
        public void verificar(Controller.Versao.VersionController controller)
        {
            this.controller = controller;
            verificarVersao();
        }
    }
}
