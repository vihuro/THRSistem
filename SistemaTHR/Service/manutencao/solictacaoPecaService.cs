using System;
using SistemaTHR.DAO.Manutencao;
using SistemaTHR.dto.manutencao;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.Controller.Login;

namespace SistemaTHR.Service.manutencao
{
    internal class solictacaoPecaService
    {
        private solicitacaoPecaoController controller;
        private solicitacaoPecaDao dao = new solicitacaoPecaDao();
        private solicitacaoPecaDto dto;
        private loginController loginController;
        private modulosController modulosController;
        private EstoquePecasService estoqueService;
        private EstoquePecasController estoqueController;
        private movimentacaoPecasController movimentacaoController;
        private movimentacaoPecasService movimentacaoService;

        public solictacaoPecaService(loginController loginController, modulosController modulosController, EstoquePecasService estoqueService, movimentacaoPecasService movimentacaoService)
        {
            this.loginController = loginController;
            this.modulosController = modulosController;
            this.estoqueService = estoqueService;
            this.movimentacaoService = movimentacaoService;
        }

        public solictacaoPecaService(loginController loginController, modulosController modulosController)
        {
            this.loginController = loginController;
            this.modulosController = modulosController;
        }
        public solictacaoPecaService()
        {

        }

        private void Insert(solicitacaoPecaDto dto)
        {
            dao.insert(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void insert(solicitacaoPecaoController controller)
        {
            dto = new solicitacaoPecaDto();

            dto.NOs = controller.NOs;
            dto.CodigoPeca = controller.CodigoPeca.ToUpper();
            dto.DescricaoPeca = controller.DescricaoPeca.ToUpper();
            dto.Qtd = controller.Qtd;
            dto.ASU = controller.ASU.ToUpper();
            dto.Unidade = controller.Unidade.ToUpper();
            dto.UsuarioSolicitacao = loginController.Nome;
            dto.StatusSolicitacao = "AGUARDANDO/AUT. PEÇAS";
            dto.DataHoraSolicitacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));


            if (controller.CodigoPeca != string.Empty && controller.DescricaoPeca != string.Empty && controller.Qtd != string.Empty &&
                controller.ASU != string.Empty && controller.Unidade != string.Empty)
            {
                if (modulosController.ManutencaoNivel != "1" || modulosController.ManutencaoNivel != "2")
                {
                    if (modulosController.ManutencaoNivel == "3" && controller.NOs == string.Empty)
                    {
                        controller.Msg = "Esse usuário não tem permissão para requisitar peça sem ordem de serviço!";
                    }
                    else
                    {
                        Insert(dto);
                    }
                }
                else
                {

                    Insert(dto);

                }

            }
            else
            {
                controller.Msg = "Campo(s) obrigatorio(s) vazio(s)!";
            }

        }

        public void delete(solicitacaoPecaoController controller)
        {
            dto = new solicitacaoPecaDto();
            if (modulosController.ManutencaoNivel == "1" || modulosController.ManutencaoNivel != "2" ||
                modulosController.ManutencaoNivel != "3" || modulosController.ManutencaoNivel != "4")
            {
                if (controller.StatusSolicitacao == "AGUARDANDO/AUT. PEÇAS")
                {
                    dto.NRequisicao = controller.NRequisicao;
                    dao.delete(dto);
                    if (dto.Msg != null)
                    {
                        controller.Msg = dto.Msg;
                    }
                }
                else
                {
                    controller.Msg = "Não é possivel cancelar essa solicitação. Contante o administrador do sistema!";
                }
            }
            else
            {
                controller.Msg = "Esse usuário não tem permissão para excluir uma peça!";
            }


        }


        public void authorizeRequisicao(solicitacaoPecaoController controller)
        {
            dto = new solicitacaoPecaDto();
            if (modulosController.ManutencaoNivel == "1" || modulosController.ManutencaoNivel == "2")
            {

                dto.StatusSolicitacao = "AUTORIZADO";
                dto.UsuarioAutorizacao = loginController.Nome;
                dto.DataHoraAutorizacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                dto.NRequisicao = controller.NRequisicao;
                dao.authorize(dto);
                if (dto.Msg != null)
                {
                    controller.Msg = dto.Msg;
                }
                else
                {

                    estoqueController = new EstoquePecasController();
                    estoqueController.Codigo = controller.CodigoPeca;
                    //estoqueController.QtEstoque = controller.Qtd;


                    //remover tipo de movimentação

                    estoqueService.VerificarCodigo(estoqueController, "Saída");

                    if (estoqueController.Exists)
                    {
                        movimentacaoController = new movimentacaoPecasController();
                        movimentacaoController.CodigoPeca = controller.CodigoPeca.ToUpper();
                        movimentacaoController.DescricaoPeca = controller.DescricaoPeca.ToUpper();
                        movimentacaoController.Qtd = controller.Qtd;
                        movimentacaoController.Unidade = controller.Unidade.ToUpper();
                        movimentacaoController.UsuarioSolicitacao = controller.UsuarioSolicitacao;
                        movimentacaoController.DataHoraSolicitacao = controller.DataHoraSolicitacao;
                        movimentacaoController.Asu = controller.ASU;
                        movimentacaoController.UsuarioAutorizacao = dto.UsuarioAutorizacao;
                        movimentacaoController.Status = "Pendente";
                        movimentacaoController.DataHoraAutorizacao = dto.DataHoraAutorizacao;
                        movimentacaoController.NRequisicao = controller.NRequisicao;
                        movimentacaoController.TipoMovimentacao = "Saída";
                        movimentacaoService.insertMovimentacao(movimentacaoController);

                    }
                    else
                    {
                        controller.Msg = "Peça não encontrada! Não é possivel gerar a movimentação de uma peça não cadastrada!";
                    }
                }

            }
            else
            {
                controller.Msg = "Este usuário não pode autorizar peças!";
            }

        }


        private void seletecRequisicao()
        {
            dto = new solicitacaoPecaDto();
            dto.NOs = controller.NOs;
            dao.selectTable(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }

        public void selectTable(solicitacaoPecaoController controller)
        {
            this.controller = controller;
            seletecRequisicao();
        }

        private void SelectMovimentacoes()
        {
            dto = new solicitacaoPecaDto();
            dao.table(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }

        public void table(solicitacaoPecaoController controller)
        {
            this.controller = controller;
            SelectMovimentacoes();
        }
    }
}
