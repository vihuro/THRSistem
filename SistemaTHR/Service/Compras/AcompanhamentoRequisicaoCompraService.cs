using System;
using SistemaTHR.dto.Compras;
using SistemaTHR.Controller.Compras;
using SistemaTHR.DAO.Compras;
using SistemaTHR.Service.Exepction;
using System.Data;
using SistemaTHR.Controller.Login;

namespace SistemaTHR.Service.Compras
{
    internal class AcompanhamentoRequisicaoCompraService
    {
        private readonly AcompanhamentoRequisicaoCompraDao dao;
        private readonly requisicaoCompraService requisicaoService;
        private readonly modulosController modulosController;
        private readonly loginController loginController;
        public AcompanhamentoRequisicaoCompraService(modulosController modulosController, loginController loginController, requisicaoCompraService requisicaoService)
        {
            dao = new AcompanhamentoRequisicaoCompraDao();
            this.modulosController = modulosController;
            this.loginController = loginController;
            this.requisicaoService = requisicaoService;
        }
        public void Insert(string numeroRequisicao)
        {
            var dto = new AcompanhamentoRequisicaoCompraDto();
            //Validar se o campo está vazio
            if (numeroRequisicao == string.Empty)
            {
                throw new ExceptionService("Não foi possivel gerar o acompanhamento dessa requisição!");
            }
            //Valida se o usuário tem permissão para fazer o Insert
            if (modulosController.Almoxarifado != "Sim" &&
                modulosController.AlmoxarifadoNivel != "2" &&
                modulosController.AlmoxarifadoNivel != "1" ||
                modulosController.Compras != "Sim" &&
                modulosController.ComprasNivel != "2" &&
                modulosController.ComprasNivel != "1")
            {
                throw new ExceptionService("Esse usuário não tem permissão para essa ação!");
            }

            foreach (var itens in Acompanhamentos())
            {
                dto.NumeroRequisicao = numeroRequisicao;
                dto.DescricaoRequisicao = itens;
                dto.DataHoraApontamento = "00/00/0000 00:00";
                dto.UsuarioApontamento = "";
                dto.DataHoraAlteracao = "00/00/0000 00:00";
                dto.UsuarioAlteracao = "";
                dto.Observacao = "";

                if (itens == "Geração")
                {
                    dto.DataHoraApontamento = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                    dto.UsuarioApontamento = loginController.Nome;
                    dto.DataHoraAlteracao = dto.DataHoraApontamento;
                    dto.UsuarioAlteracao = loginController.Nome;


                    dao.Insert(dto);
                }
                else
                {
                    dao.Insert(dto);
                }

            }
        }

        public AcompanhamentoRequisicaoCompra InsertApontamento(AcompanhamentoRequisicaoCompra controller, string tipoApontamento)
        {
            var requisicao = requisicaoService.SelectRequisicao(controller.NumeroRequisicao);
            if (requisicao == null)
            {
                throw new ExceptionService("Requisição de compra não encontrada!");
            }
            var apontamento = dao.Apontamento(controller.Id);
            if (apontamento == null)
            {
                throw new ExceptionService("Falha ao encontrar apontamento!");
            }
            else if (controller.DescricaoRequisicao == "COMPRA" && controller.Observacao == string.Empty)
            {
                throw new ExceptionService("Para declar uma compra, é necessário colocar o numero da nota na observação!");
            }
            else if (!ValidarStatus(controller.DescricaoRequisicao, requisicao, apontamento))
            {
                throw new ExceptionService("Não é possível fazer essa alteração!");
            }
            else if(apontamento.UsuarioApontamento != string.Empty && tipoApontamento == "APONTAMENTO")
            {
                controller.DataHoraApontamento = apontamento.DataHoraApontamento;
                controller.UsuarioApontamento = apontamento.UsuarioApontamento;
                controller.DataHoraAlteracao = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
            }
            else if (apontamento.UsuarioApontamento == string.Empty && tipoApontamento == "APONTAMENTO")
            {
                controller.DataHoraApontamento = DateTime.Now.ToString("dd/MM/yyyy HH:mm");
                controller.UsuarioApontamento = loginController.Nome;
                controller.DataHoraAlteracao = controller.DataHoraApontamento;
            }
            else if (tipoApontamento == "DESFAZER" && modulosController.ComprasNivel == "1")
            {
                controller.UsuarioApontamento = string.Empty;
                controller.DataHoraApontamento = "00/00/0000 00:00";
                controller.DataHoraAlteracao = "00/00/0000 00:00";
                controller.Observacao = string.Empty;
            }
            apontamento.DataHoraApontamento = controller.DataHoraApontamento;
            apontamento.UsuarioApontamento = controller.UsuarioApontamento;
            apontamento.DataHoraAlteracao = controller.DataHoraAlteracao;
            apontamento.UsuarioAlteracao = loginController.Nome;
            apontamento.Observacao = controller.Observacao;

            dao.InsertApontamento(apontamento);

            var obj = new AcompanhamentoRequisicaoCompra()
            {
                Id = apontamento.Id,
                NumeroRequisicao = apontamento.NumeroRequisicao,
                DescricaoRequisicao = apontamento.DescricaoRequisicao,
                UsuarioApontamento = apontamento.UsuarioApontamento,
                DataHoraApontamento = apontamento.DataHoraApontamento,
                UsuarioAlteracao = apontamento.UsuarioAlteracao,
                DataHoraAlteracao = apontamento.DataHoraAlteracao,
                Observacao = apontamento.Observacao
            };

            return obj;
        }

        private bool ValidarStatus(string descricaoRequisicao, requisicaoCompraDto requisicao, AcompanhamentoRequisicaoCompraDto acompanhamento)
        {
            if (modulosController.ComprasNivel != "1" && requisicao.Status == "Entregue")
            {
                return false;
            }
            else if (modulosController.ComprasNivel == "4" && descricaoRequisicao == "COMPRA" ||
                    requisicao.Status == "ENTREGUE")
            {
                return false;
            }
            else if (modulosController.ComprasNivel == "3" && requisicao.Status == "PENDENTE" ||
                    requisicao.Status == "ENTREGUE" || descricaoRequisicao == "ENTREGA")
            {
                return false;
            }

            return true;
        }





        private string[] Acompanhamentos()
        {
            string[] lista = new string[]
            {
                "GERAÇÃO",
                "DIÁRIO",
                "COMPRA",
                "ENTREGA"
            };

            return lista;
        }

        public DataTable Table()
        {
            return dao.Table();
        }
    }
}
