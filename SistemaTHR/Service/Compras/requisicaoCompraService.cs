using Microsoft.SqlServer.Server;
using SistemaTHR.Controller.Compras;
using SistemaTHR.dto.Compras;
using SistemaTHR.Service.Exepction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.DAO.Manutencao;
using SistemaTHR.Controller.Login;
using SistemaTHR.Service.manutencao;

namespace SistemaTHR.Service.Compras
{
    internal class requisicaoCompraService
    {
        private requisicaoCompraDao dao;
        private requisicaoCompraDto dto;
        private loginController loginController;
        private modulosController modulosController;
        private AcompanhamentoRequisicaoCompraService acompanhamentoService;
        private EstoquePecasService estoquePecasService;

        public requisicaoCompraService(loginController loginController, modulosController modulosController)
        {
            dao = new requisicaoCompraDao();
            this.modulosController = modulosController;
            this.loginController = loginController;
            acompanhamentoService = new AcompanhamentoRequisicaoCompraService(modulosController, loginController,this);
            estoquePecasService = new EstoquePecasService(loginController, modulosController);
        }

        private void Insert(requisicaoCompraController controller)
        {
            dto = new requisicaoCompraDto();

            dto.Codigo = controller.Codigo.ToUpper();
            dto.Descricao = controller.Descricao.ToUpper();
            dto.Quantidade = controller.Quantidade;
            dto.Unidade = controller.Unidade;
            dto.Prioridade = controller.Prioridade.ToUpper();
            dto.DataHoraEsperadaEntrega = controller.DataHoraEsperadaEntrega;
            dto.UsuarioSolicitacao = loginController.Nome;
            dto.DataHoraSolicitacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            dto.Status = "Pendente";
            acompanhamentoService.Insert(dao.Insert(dto));
        }

        public void verificarAberto(requisicaoCompraController controller)
        {

            dto = new requisicaoCompraDto();

            if (controller.Codigo == string.Empty && controller.Descricao == string.Empty &&
                controller.Quantidade == string.Empty && controller.Unidade == string.Empty &&
                controller.Prioridade == string.Empty && controller.DataHoraEsperadaEntrega == string.Empty)
            {
                throw new ExceptionService("Campos obrigatório(s) vazio(s)!");
            }
            if (!estoquePecasService.VerificarSeExiste(controller.Codigo))
            {
                throw new ExceptionService("Código de peça não encontrado!");
            }
            if (modulosController.Compras != "Sim")
            {
                throw new ExceptionService("Esse usuário não tem permissão para essa requisição!");
            }
            if (Convert.ToDecimal(controller.Quantidade.ToString()) <= 0)
            {
                throw new ExceptionService("A quantidade não pode ser menor ou igual a zero!");
            }

            dto.Codigo = controller.Codigo.ToUpper();
            dto.Status = "Pendente";
            var obj = dao.verificarCodigo(dto);


            if (obj != null)
            {
                dto.Status = controller.Status;
                updateRequisicao(obj, controller.Quantidade);
            }
            else
            {
                Insert(controller);
            }


        }

        public void UpdateStatusRequisicao(requisicaoCompraController controller)
        {
            var obj = new requisicaoCompraDto();
            obj = dao.VerifyForNumber(controller.NRequisicao);
            if(obj == null)
            {
                throw new ExceptionService("Falha ao atualizar status da ordem de serviço!");
            }
            obj.Status = controller.Status;
            dao.Update(obj);

        }

        private void updateRequisicao(requisicaoCompraDto dto, string quantidade)
        {
            decimal quantidadeAntiga = Convert.ToDecimal(dto.Quantidade);
            decimal quantidadeRequisitada = Convert.ToDecimal(quantidade);
            decimal total = quantidadeAntiga + quantidadeRequisitada;

            if (total <= 0)
            {
                throw new ExceptionService("Quantidade solictada não pode ser igual ou menor que zero!");
            }

            dto.Quantidade = total.ToString();
            dao.updateRequisicaoCompra(dto);

        }

        public void updateAuth(requisicaoCompraController controller)
        {
            dto = new requisicaoCompraDto();
            if (dto.UsuarioAutorizador == string.Empty && dto.NRequisicao == string.Empty)
            {
                throw new ExceptionService("Campo(s) obrigatório(s) vazio(s)!");
            }
            if(modulosController.ComprasNivel != "1" && modulosController.ComprasNivel != "2")
            {
                throw new ExceptionService("Esse usuário não pode fazer essa requisição!");
            }

            dto.UsuarioAutorizador = loginController.Nome;
            dto.DataHoraAutorizacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            dto.Status = "Autorizado";
            dto.NRequisicao = controller.NRequisicao;
            dao.updateAuth(dto);

        }

        public void Update(requisicaoCompraController controller)
        {
            dto = new requisicaoCompraDto();
            if (controller.NRequisicao == string.Empty)
            {
                throw new ExceptionService("Não é possível fazer essa movimentação!");
            }
            var obj = dao.VerifyForNumber(controller.NRequisicao);

            //Caso o usuário seja do almoxarifado, ele não pode fazer uma alteração
            if (modulosController.ComprasNivel == "4")
            {
                throw new ExceptionService("Não é possível fazer essa movimentação!");
            }
            //Caso já esteja entregue e o usuário seja difente de TI, não é possivel fazer uma alteração
            else if(obj.Status == "Entregue" && modulosController.ComprasNivel != "1" && modulosController.ComprasNivel != "2")
            {
                throw new ExceptionService("Não é possível fazer essa movimentação!");
            }
            // Caso esteja comprado ou entregue e o usuário seja do compras, não é possivel fazer uma alteração
            else if(obj.Status == "Comprado" || obj.Status == "Entregue" &&
                     modulosController.ComprasNivel == "3") 
            {
                throw new ExceptionService("Não é possível fazer essa movimentação!");
            }
            //Caso seja diferente de pendente e difente de TI, não é possivel fazer uma alteração
            else if (obj.Status != "Pendente" && modulosController.ComprasNivel != "1")
            {
                throw new ExceptionService("Não é possível fazer essa movimentação!");
            }


            dto.ValorProduto = controller.ValorProduto;
            dto.Fornecedor = controller.Fornecedor.ToUpper();
            dto.FreteIncluso = controller.FreteIncluso;
            dto.Frete = controller.Frete;
            dto.EstadoDaCompra = controller.EstadoDaCompra.ToUpper();
            dto.NRequisicao = controller.NRequisicao;
            dto.Status = "Pendente";
            dao.Update(dto);
        }


        public requisicaoCompraDto SelectRequisicao(string id)
        {
            return dao.SelectRequisicao(id);
        }

        public DataTable Table()
        {
            return dao.Table();
        }
    }
}
