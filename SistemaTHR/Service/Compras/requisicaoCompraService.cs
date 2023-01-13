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

namespace SistemaTHR.Service.Compras
{
    internal class requisicaoCompraService
    {
        private requisicaoCompraDao dao;
        private requisicaoCompraDto dto;
        private loginController loginController;
        private modulosController modulosController;
        private AcompanhamentoRequisicaoCompraService acompanhamentoService;

        public requisicaoCompraService(loginController loginController, modulosController modulosController)
        {
            dao = new requisicaoCompraDao();
            this.modulosController = modulosController;
            this.loginController = loginController;
            acompanhamentoService = new AcompanhamentoRequisicaoCompraService(modulosController, loginController);
        }

        private void Insert(requisicaoCompraController controller)
        {
            dto = new requisicaoCompraDto();
            if (controller.Codigo == string.Empty && controller.Descricao == string.Empty &&
                controller.Quantidade == string.Empty && controller.Unidade == string.Empty &&
                controller.Prioridade == string.Empty && controller.DataHoraEsperadaEntrega == string.Empty)
            {
                throw new ExceptionService("Campos obrigatório(s) vazio(s)!");
            }

            dto.Codigo = controller.Codigo;
            dto.Descricao = controller.Descricao;
            dto.Quantidade = controller.Quantidade;
            dto.Unidade = controller.Unidade;
            dto.Prioridade = controller.Prioridade;
            dto.DataHoraEsperadaEntrega = controller.DataHoraEsperadaEntrega;
            dto.UsuarioSolicitacao = loginController.Nome;
            dto.DataHoraSolicitacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            dto.Status = "Pendente";
            acompanhamentoService.Insert(dao.Insert(dto));
        }

        public void verificarAberto(requisicaoCompraController controller)
        {

            dto = new requisicaoCompraDto();

            dto.Codigo = controller.Codigo;
            dto.Status = "Pendente";
            dao.verificarCodigo(dto);


            if (dto.NRequisicao != null)
            {
                updateRequisicao(dto, controller.Quantidade);
            }
            else
            {
                Insert(controller);
            }


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
            else if(obj.Status == "Entregue" && modulosController.ComprasNivel != "1")
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
            dto.Fornecedor = controller.Fornecedor;
            dto.FreteIncluso = controller.FreteIncluso;
            dto.Frete = controller.Frete;
            dto.EstadoDaCompra = controller.EstadoDaCompra;
            dto.NRequisicao = controller.NRequisicao;
            dao.Update(dto);
        }

        public void updateCompra()
        {
            /*dao = new requisicaoCompraDao();

            dto = new dto.Compras.requisicaoCompraDto();
            dto.UsuarioCompra = controller.UsuarioCompra;
            dto.DataHoraCompra = controller.DataHotaCompra;
            dto.Status = controller.Status;
            dto.NRequisicao = controller.NRequisicao;
            dao.compra(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }*/
        }

        public DataTable Table()
        {
            return dao.Table();
        }
    }
}
