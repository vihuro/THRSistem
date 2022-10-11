using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.Login;
using SistemaTHR.Controller.Login;
using SistemaTHR.DAO.Login;

namespace SistemaTHR.Service.login
{
    public class loginService
    {
        private dto.Login.loginDto dto;
        private Controller.Login.loginController controller;
        private DAO.Login.LoginDao dao = new DAO.Login.LoginDao();

        private void authorizedUser()
        {
            dto = new dto.Login.loginDto();

            dto.NomeUsuario = controller.NomeUsuario;
            dto.Senha = controller.Senha;
            dao.authorized(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            controller.NomeUsuario = dto.NomeUsuario;
            controller.Nome = dto.Nome;
            controller.Autorizado = dto.Autorizado;

        }

        public void authorized(Controller.Login.loginController controller)
        {
            this.controller = controller;
            authorizedUser();
        }

        private void infoUsuario()
        {
            dto = new dto.Login.loginDto();
            dto.Nome = controller.Nome;
            dao.info(dto);

            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.NomeUsuario = dto.NomeUsuario;
                controller.Senha = dto.Senha;
            }
        }

        public void info(Controller.Login.loginController controller)
        {
            this.controller = controller;
            infoUsuario();
        }

        private void insertUser()
        {
            dto = new dto.Login.loginDto();
            dto.Nome = controller.Nome;
            dto.NomeUsuario = controller.NomeUsuario;
            dto.Senha = controller.Senha;
            dao.insert(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void insert(Controller.Login.loginController controller)
        {
            this.controller = controller;
            insertUser();
        }

        private void updateUser()
        {
            dto = new dto.Login.loginDto();
            dto.Nome = controller.Nome;
            dto.NomeUsuario = controller.NomeUsuario;
            dto.Senha = controller.Senha;
            dao.update(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void update(Controller.Login.loginController controller)
        {
            this.controller = controller;
            updateUser();
        }

        private void deleteUser()
        {
            dto = new dto.Login.loginDto();
            dto.Nome = controller.Nome;
            dao.delete(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void delete(Controller.Login.loginController controller)
        {
            this.controller = controller;
            deleteUser();
        }

        public void Table(loginController controller)
        {
            dto = new loginDto();
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

    }


    
}
