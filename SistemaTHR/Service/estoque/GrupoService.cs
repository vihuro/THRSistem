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
    internal class GrupoService
    {
        private GrupoDao dao = new GrupoDao();
        private GrupoDto dto;
        public void Insert(GrupoController controller)
        {
            dto = new GrupoDto();
            dto.Grupo = controller.Grupo;
            dto.UsuarioGravacao = controller.UsuarioGravacao;
            dto.DataHoraGravacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            dao.Insert(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void Table(GrupoController controller)
        {
            dto = new GrupoDto();
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
        public void Delete(GrupoController controller)
        {
            dto = new GrupoDto();
            dto.Id = controller.Id;
            dao.Delete(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }
        public void List(GrupoController controller)
        {
            dto = new GrupoDto();
            dao.List(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Lista = dto.Lista;
            }
        }

        public void Exits (GrupoController controller)
        {
            dto = new GrupoDto();
            dto.Grupo = controller.Grupo;
            dao.Exits(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                if (dto.Exists)
                {
                    Insert(controller);
                }
                else
                {
                    controller.Exists = dto.Exists;
                }

            }
        }
        public void Filter(GrupoController controller)
        {
            dto = new GrupoDto();
            dto.Grupo = controller.Grupo;
            dao.Filter(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }
    }
}
