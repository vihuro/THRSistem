

namespace SistemaTHR.Service.manutencao
{
    internal class asuService
    {
        private Controller.manutencao.asuController controller;
        private DAO.Manutencao.asuDao dao = new DAO.Manutencao.asuDao();
        private dto.manutencao.asuDto dto;

        private void insertAsu()
        {
            dto = new dto.manutencao.asuDto();
            dto.Asu = controller.Asu;
            dto.UsuarioGravao = controller.UsuarioGravao;
            dto.DataHoraGravacao = controller.DataHoraGravacao;
            dao.inset(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }

        }
        public void insert(Controller.manutencao.asuController controller)
        {
            this.controller = controller;
            insertAsu();
        }
        private void deleteAsu()
        {
            dto = new dto.manutencao.asuDto();
            dto.Codigo = controller.Codigo;
            dao.delete(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }
        public void delete(Controller.manutencao.asuController controller)
        {
            this.controller = controller;
            deleteAsu();
        }
        private void selectTable()
        {
            dto = new dto.manutencao.asuDto();
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
        public void table(Controller.manutencao.asuController controller)
        {
            this.controller = controller;
            selectTable();
        }
        private void selectList()
        {
            dto = new dto.manutencao.asuDto();
            dao.list(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.AsuList = dto.AsuList;
            }
        }
        public void list(Controller.manutencao.asuController controller)
        {
            this.controller = controller;
            selectList();
        }
    }
}
