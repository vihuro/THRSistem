using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Service
{
    internal class modulosService
    {
        private dto.modulosDto dto;
        private Controller.Login.modulosController controller;
        private DAO.Login.modulosDao dao = new DAO.Login.modulosDao();
            
        private void saveModulos()
        {
            dto = new dto.modulosDto();
            dto.Usuario = controller.Usuario;
            dto.Empilhadeiras = controller.Empilhadeiras;
            dto.EmpNivel = controller.EmpNivel;
            dto.Recebimento = controller.Recebimento;
            dto.RecebNivel = controller.RecebNivel;
            dto.Expedicao = controller.Expedicao;
            dto.ExpNivel = controller.ExpNivel;
            dto.Adm = controller.Adm;
            dto.AdmNivel = controller.AdmNivel;
            dto.Manutencao = controller.Manutencao;
            dto.ManutencaoNivel = controller.ManutencaoNivel;
            dto.Producao = controller.Producao;
            dto.ProducaoNivel = controller.ProducaoNivel;
            dto.Almoxarifado = controller.Almoxarifado;
            dto.AlmoxarifadoNivel = controller.AlmoxarifadoNivel;
            dto.Estoque = controller.Estoque;
            dto.EstoqueNivel = controller.EstoqueNivel;
            dto.Compras = controller.Compras;
            dto.ComprasNivel = controller.ComprasNivel;

            dao.insert(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            
        }

        public void insert(Controller.Login.modulosController controller)
        {
            this.controller = controller;
            saveModulos();
        }

        private void verificar()
        {
            dto = new dto.modulosDto();
            dto.Usuario = controller.Usuario;
            dao.info(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Usuario = dto.Usuario;
                controller.Empilhadeiras = dto.Empilhadeiras;
                controller.EmpNivel = dto.EmpNivel;
                controller.Recebimento = dto.Recebimento;
                controller.RecebNivel = dto.RecebNivel;
                controller.Expedicao = dto.Expedicao;
                controller.ExpNivel = dto.ExpNivel;
                controller.Adm = dto.Adm;
                controller.AdmNivel = dto.AdmNivel;
                controller.Manutencao = dto.Manutencao;
                controller.ManutencaoNivel = dto.ManutencaoNivel;
                controller.Producao = dto.Producao;
                controller.ProducaoNivel = dto.ProducaoNivel;
                controller.Almoxarifado = dto.Almoxarifado;
                controller.AlmoxarifadoNivel = dto.AlmoxarifadoNivel;
                controller.Estoque = dto.Estoque;
                controller.EstoqueNivel = dto.EstoqueNivel;
                controller.Compras = dto.Compras;
                controller.ComprasNivel = dto.ComprasNivel;
            }

        }

        public void info(Controller.Login.modulosController modulosController)
        {
            this.controller = modulosController;
            verificar();
        }

        private void updateModulos()
        {
            dto = new dto.modulosDto();
            dto.Usuario = controller.Usuario;
            dto.Empilhadeiras = controller.Empilhadeiras;
            dto.EmpNivel = controller.EmpNivel;
            dto.Recebimento = controller.Recebimento;
            dto.RecebNivel = controller.RecebNivel;
            dto.Expedicao = controller.Expedicao;
            dto.ExpNivel = controller.ExpNivel;
            dto.Adm = controller.Adm;
            dto.AdmNivel = controller.AdmNivel;
            dto.Manutencao = controller.Manutencao;
            dto.ManutencaoNivel = controller.ManutencaoNivel;
            dto.Producao = controller.Producao;
            dto.ProducaoNivel = controller.ProducaoNivel;
            dto.Almoxarifado = controller.Almoxarifado;
            dto.AlmoxarifadoNivel = controller.AlmoxarifadoNivel;
            dto.Estoque = controller.Estoque;
            dto.EstoqueNivel = controller.EstoqueNivel;
            dto.Compras = controller.Compras;
            dto.ComprasNivel = controller.ComprasNivel;
            dao.update(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void update(Controller.Login.modulosController controller)
        {
            this.controller = controller;
            updateModulos();
        }

        private void deleteUser()
        {
            dto = new dto.modulosDto();
            dto.Usuario = controller.Usuario;
            dao.delete(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void delete(Controller.Login.modulosController controller)
        {
            this.controller = controller;
            deleteUser();
        }

        private void loadDataTable()
        {
            dto = new dto.modulosDto();
            dao.loadDataTable(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            controller.Dt = dto.Dt;
        }

        public void dataTable(Controller.Login.modulosController modulosController)
        {
            this.controller = modulosController;
            loadDataTable();
        }

    }
}
