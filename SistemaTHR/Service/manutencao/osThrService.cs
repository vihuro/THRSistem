using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.Service.manutencao;
using SistemaTHR.DAO.Manutencao;
using SistemaTHR.dto.manutencao;

namespace SistemaTHR.Service.manutencao
{
    internal class osThrService
    {
        Controller.manutencao.osThrController controller;
        DAO.Manutencao.OsTHRDAO dao = new DAO.Manutencao.OsTHRDAO();
        dto.manutencao.osThrDto dto;

        private void insertOs()
        {
            dto = new dto.manutencao.osThrDto();
            dto.Descricao = controller.Descricao;
            dto.TipoServico = controller.TipoServico;
            dto.DataHora = controller.DataHora;
            dto.Usuario = controller.Usuario;
            dto.Ase = controller.Ase;
            dto.Categoria = controller.Categoria;
            dto.DataIdeal = controller.DataIdeal;
            dto.StatusOs = controller.StatusOs;
            dao.insert(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void insert(Controller.manutencao.osThrController controller)
        {
            this.controller = controller;
            insertOs();
        }

        private void selectNOs()
        {
            dto = new dto.manutencao.osThrDto();
            dao.selectOS(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.NOs = dto.NOs;
            }
        }

        private void selectTable()
        {
            dto = new dto.manutencao.osThrDto();
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

        public void table(Controller.manutencao.osThrController controller)
        {
            this.controller = controller;
            selectTable();
        }

        public void selectOS(Controller.manutencao.osThrController controller)
        {
            this.controller = controller;
            selectNOs();
        }

        private void selectPainel()
        {
            dto = new dto.manutencao.osThrDto();
            dao.painel(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }

        public void painel(Controller.manutencao.osThrController controller)
        {
            this.controller = controller;
            selectPainel();
        }

        private void updatePriori()
        {
            dto = new dto.manutencao.osThrDto();
            dto.Prioridade = controller.Prioridade;
            dto.UsuarioPrioridade = controller.UsuarioPrioridade;
            dto.DataHoraPrioridade = controller.DataHoraPrioridade;
            dto.NOs = controller.NOs;
            dao.UpdatePrioridade(dto);
            if(dto.Msg != null)
            {
                controller.Msg = controller.Msg;
            }
        }

        public void updatePrioridade(Controller.manutencao.osThrController controller)
        {
            this.controller = controller;
            updatePriori();
        }

        private void updateStatus()
        {
            dto = new dto.manutencao.osThrDto();
            dto.StatusOs = controller.StatusOs;
            dto.NOs = controller.NOs;
            dao.updateStatus(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void status(Controller.manutencao.osThrController controller)
        {
            this.controller = controller;
            updateStatus();
        }

        private void loadInfoOS()
        {
            dto = new dto.manutencao.osThrDto();
            dto.NOs = controller.NOs;
            dao.loadINFO(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Prioridade = dto.Prioridade;
                controller.StatusOs = dto.StatusOs;
            }
        }

        public void load(Controller.manutencao.osThrController controller)
        {
            this.controller = controller;
            loadInfoOS();
        }

        public void SelectTableFilter(osThrController controller)
        {
            dto = new osThrDto();
            dto.EmAberto = controller.EmAberto;
            dto.ManutenacaoIniciada = controller.ManutenacaoIniciada;
            dto.OrdemINC = controller.OrdemINC;
            dto.AguardandoPeca = controller.AguardandoPeca;
            dto.ManutencaoNC = controller.ManutencaoNC;
            dto.ManutencaoFinalizada = controller.ManutencaoFinalizada;
            dao.fiterStatusOS(dto);
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
