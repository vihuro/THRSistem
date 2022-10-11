using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.Controller.Login;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.dto.manutencao;
using SistemaTHR.DAO.Manutencao;

namespace SistemaTHR.Service.manutencao
{
    internal class movimentacaoPecasService
    {
        private movimentacaoPecasController controller;
        private movimentacaoPecasDao dao;
        private movimentacaoPecasDto dto;

        private loginController loginController;

        public movimentacaoPecasService(loginController loginController)
        {
            this.loginController = loginController;
            IniciarDao();
        }

        private movimentacaoPecasDao IniciarDao()
        {
            return dao = new movimentacaoPecasDao();
        }

        private void insertMovimentacao()
        {
            dto = new movimentacaoPecasDto();
            dto.NRequisicao = controller.NRequisicao;
            dto.CodigoPeca = controller.CodigoPeca;
            dto.DescricaoPeca = controller.DescricaoPeca;
            dto.Unidade = controller.Unidade;
            dto.Qtd = controller.Qtd;
            dto.Asu = controller.Asu;
            dto.TipoMovimentacao = controller.TipoMovimentacao;
            dto.Status = controller.Status;
            dto.UsuarioSolicitacao = controller.UsuarioSolicitacao;
            dto.DataHoraSolicitacao = controller.DataHoraSolicitacao;
            dto.UsuarioAutorizacao = controller.UsuarioAutorizacao;
            dto.DataHoraAutorizacao = controller.DataHoraAutorizacao;
            dto.UsuarioMovimentacao = controller.UsuarioMovimentacao;
            dto.DataHoraMovimentacao = controller.DataHoraMovimentacao;
            dao.insert(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void InsertSaida(movimentacaoPecasController controller)
        {
            dto = new movimentacaoPecasDto();
            dto.NRequisicao = controller.NRequisicao;
            dto.CodigoPeca = controller.CodigoPeca;
            dto.DescricaoPeca = controller.DescricaoPeca;
            dto.Unidade = controller.Unidade;
            dto.Qtd = controller.Qtd;
            dto.Asu = controller.Asu;
            dto.TipoMovimentacao = "Saída";
            dto.Status = "Pendente";
            dto.UsuarioSolicitacao = controller.UsuarioSolicitacao;
            dto.DataHoraSolicitacao = controller.DataHoraSolicitacao;
            dto.UsuarioAutorizacao = controller.UsuarioAutorizacao;
            dto.DataHoraAutorizacao = controller.DataHoraAutorizacao;
            dto.UsuarioMovimentacao = loginController.Nome;
            dto.DataHoraMovimentacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            dao.insert(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        private void update()
        {
            dto = new dto.manutencao.movimentacaoPecasDto();
            dto.Status = controller.Status;
            dto.UsuarioMovimentacao = controller.UsuarioMovimentacao;
            dto.DataHoraMovimentacao = controller.DataHoraMovimentacao;
            dto.NMovimentacao = controller.NMovimentacao;
            dao.liberar(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }
        public void liberar(Controller.manutencao.movimentacaoPecasController controller)
        {
            this.controller = controller;
            update();
        }
        private void selectTable()
        {
            dto = new dto.manutencao.movimentacaoPecasDto();
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
        public void table(Controller.manutencao.movimentacaoPecasController controller)
        {
            this.controller = controller;
            selectTable();
        }
        private void exporMovimentacao()
        {
            dto = new dto.manutencao.movimentacaoPecasDto();
            dto.NRequisicao = controller.NRequisicao;
            dao.export(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }
        public void export(Controller.manutencao.movimentacaoPecasController controller)
        {
            this.controller = controller;
            exporMovimentacao();
        }
        private void selectCodigo()
        {
            dto = new dto.manutencao.movimentacaoPecasDto();
            dto.CodigoPeca = controller.CodigoPeca;
            dao.selectHistory(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }
        public void history(Controller.manutencao.movimentacaoPecasController controller)
        {
            this.controller = controller;
            selectCodigo();
        }
        private void deleteMovimentacao()
        {
            dto = new dto.manutencao.movimentacaoPecasDto();
            dto.NMovimentacao = controller.NMovimentacao;
            dao.delete(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }
        public void delete(Controller.manutencao.movimentacaoPecasController controller)
        {
            this.controller = controller;
            deleteMovimentacao();
        }
    }
}
