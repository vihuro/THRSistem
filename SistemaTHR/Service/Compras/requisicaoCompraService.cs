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

        private DataTable dt;

        public requisicaoCompraService(loginController loginController,modulosController modulosController)
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
            dao.Insert(dto);
        }

        /*private string BuscarNovaRequisicao()
        {

        }*/

        //Esse metódo irá verificar a quantidade se estiver uma requisição aberto com o mesmo material
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

            if(total <= 0)
            {
                throw new ExceptionService("Quantidade solictada não pode ser igual ou menor que zero!");
            }

            dto.Quantidade = total.ToString();
            dao.updateRequisicaoCompra(dto);

        }

        public void updateAuth(requisicaoCompraController controller)
        {
            dto = new requisicaoCompraDto();
            if(dto.UsuarioAutorizador == string.Empty && dto.NRequisicao == string.Empty)
            {
                throw new ExceptionService("Campo(s) obrigatório(s) vazio(s)!");
            }

            dto.UsuarioAutorizador = controller.UsuarioAutorizador;
            dto.DataHoraAutorizacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            dto.Status = "Autorizado";
            dto.NRequisicao = controller.NRequisicao;
            dao.updateAuth(dto);

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
