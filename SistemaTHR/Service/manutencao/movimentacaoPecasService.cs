using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.Controller.Login;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.dto.manutencao;
using SistemaTHR.DAO.Manutencao;
using SistemaTHR.Service.Exepction;
using System.Data;

namespace SistemaTHR.Service.manutencao
{
    internal class movimentacaoPecasService
    {
        private movimentacaoPecasController controller;
        private movimentacaoPecasDao dao;
        private movimentacaoPecasDto dto;
        private EstoquePecasController EstoqueController;
        private EstoquePecasService EstoqueService;
        private loginController loginController;
        private modulosController modulosController;

        public movimentacaoPecasService(loginController loginController, modulosController modulosController)
        {
            this.loginController = loginController;
            this.modulosController = modulosController;
            
            dao = new movimentacaoPecasDao();
            
            IniciarDao();
            IniciarEstoqueService();
        }

        private movimentacaoPecasDao IniciarDao()
        {
            return this.dao = new movimentacaoPecasDao();
        }

        private EstoquePecasService IniciarEstoqueService()
        {
            return this.EstoqueService = new EstoquePecasService(loginController, modulosController);
        }



        public void insertMovimentacao(movimentacaoPecasController controller)
        {
            dto = new movimentacaoPecasDto();
            if(controller.CodigoPeca == string.Empty && controller.DescricaoPeca == string.Empty &&
                controller.Unidade == string.Empty && controller.Qtd == string.Empty && 
                controller.TipoMovimentacao == string.Empty && controller.Status == string.Empty)
            {
                throw new ExceptionService("Campo(s) obrigatório(s) vazio(s)!");
            }

            else if (controller.TipoMovimentacao == "Saída" && controller.UsuarioAutorizacao == string.Empty)
            {
                throw new ExceptionService("Só é possivel realizar uma saída com autorização!");
            }
            else if(controller.TipoMovimentacao == "Entrada" && 
                modulosController.AlmoxarifadoNivel == "2" || modulosController.AlmoxarifadoNivel == "3")
            {
                throw new ExceptionService("Esse usuário não tem acesso para fazer entrada de peças!");
            }

            Insert(controller);


        }

        private void Insert(movimentacaoPecasController controller)
        {

            dto = new movimentacaoPecasDto();
            dto.NRequisicao = controller.NRequisicao;
            dto.CodigoPeca = controller.CodigoPeca;
            dto.DescricaoPeca = controller.DescricaoPeca;
            dto.Unidade = controller.Unidade;
            dto.Asu = controller.Asu;
            dto.TipoMovimentacao = controller.TipoMovimentacao;
            dto.UsuarioSolicitacao = controller.UsuarioSolicitacao;
            dto.DataHoraSolicitacao = controller.DataHoraSolicitacao;
            dto.UsuarioAutorizacao = controller.UsuarioAutorizacao;
            dto.DataHoraAutorizacao = controller.DataHoraAutorizacao;
            dto.UsuarioMovimentacao = loginController.Nome;
            dto.DataHoraMovimentacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));

            decimal QuantidadeSolicitada = Convert.ToDecimal(controller.Qtd);

            if (controller.TipoMovimentacao == "Saída")
            {
                dto.Qtd = Convert.ToString(QuantidadeSolicitada * -1);
                dto.Status = "Pendente";
            }
            else
            {
                dto.Qtd = controller.Qtd;
                dto.Status = "Finalizado";
            }
            if (controller.TipoMovimentacao == "Entrada")
            {
                EstoqueService.UpdateEstoque(controller.CodigoPeca, controller.Qtd, controller.TipoMovimentacao);
            }
            dao.Insert(dto);


        }

        public void Liberacao(movimentacaoPecasController controller)
        {
            if (controller.CodigoPeca == string.Empty && controller.DescricaoPeca == string.Empty)
            {
                throw new ExceptionService("Campo(s) obrigatório(s) vazio(s)!");
            }
            EstoqueService.UpdateEstoque(controller.CodigoPeca, controller.Qtd, controller.TipoMovimentacao);
            update(controller.NMovimentacao);
        }


        private void update(string numeroMovimentacao)
        {
            dto = new movimentacaoPecasDto();
            dto.Status = "Liberado";
            dto.UsuarioMovimentacao = loginController.Nome;
            dto.DataHoraMovimentacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            dto.NMovimentacao = numeroMovimentacao;
            dao.liberar(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public DataTable Table()
        {
            return dao.Table();
        }

        private void exporMovimentacao()
        {
            dto = new movimentacaoPecasDto();
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
        public void export(movimentacaoPecasController controller)
        {
            this.controller = controller;
            exporMovimentacao();
        }
        private void selectCodigo()
        {
            dto = new movimentacaoPecasDto();
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
        public void history(movimentacaoPecasController controller)
        {
            this.controller = controller;
            selectCodigo();
        }
        private void deleteMovimentacao()
        {
            dto = new movimentacaoPecasDto();
            dto.NMovimentacao = controller.NMovimentacao;
            dao.delete(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }
        public void delete(movimentacaoPecasController controller)
        {
            this.controller = controller;
            deleteMovimentacao();
        }
    }
}
