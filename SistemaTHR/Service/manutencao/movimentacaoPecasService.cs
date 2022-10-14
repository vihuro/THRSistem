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



        public void insertMovimentacao(movimentacaoPecasController controller, string QuantidadeDisponivel)
        {
            dto = new movimentacaoPecasDto();
            if(controller.CodigoPeca != string.Empty && controller.DescricaoPeca != string.Empty && controller.Unidade != string.Empty && 
                controller.Qtd != string.Empty && controller.TipoMovimentacao != string.Empty && controller.Status != string.Empty)
            {
                if(controller.TipoMovimentacao == "Saída" && controller.UsuarioAutorizacao == string.Empty)
                {
                    if(modulosController.AlmoxarifadoNivel != "1" && modulosController.AlmoxarifadoNivel != "2")
                    {
                        controller.Msg = "Só é possivel realizar uma saída com autorização!";
                    }
                    else
                    {
                        Insert(controller, QuantidadeDisponivel);
                    }

                }
                else
                {
                    if(modulosController.AlmoxarifadoNivel != "1" && modulosController.AlmoxarifadoNivel != "2")
                    {
                        controller.Msg = "Esse usuário não tem acesso para fazer entrada de peças!";
                    }
                    else
                    {
                        Insert(controller, QuantidadeDisponivel);
                    }

                }

            }
            else
            {
                controller.Msg = "Campo(s) obrigatorio(s) vazio(s)! Não foi possivel gerar movimentação dessa peça!";
            }

        }

        private void Insert(movimentacaoPecasController controller, string QuantidadeDisponivel)
        {

            //Primeiro vou verificar se a quantidade disponivel é maior que a quantidade solicitada e se o tipo de movimentação é uma saída


            double QuantidadeSolicitada = Convert.ToDouble(controller.Qtd);
            double Disponivel = Convert.ToDouble(QuantidadeDisponivel);

            if(QuantidadeSolicitada > Disponivel && controller.TipoMovimentacao == "Saída")
            {
                controller.Msg = $"Quantidade em estoque é menor do que a quantidade solicitada! \r\n " +
                                 $"Quantidade em estoque: {Disponivel.ToString("###,###.##")}\r\n" +
                                 $"Quantidade Solicitada: {QuantidadeSolicitada.ToString("###,###.##")}";
            }
            else
            {

                dto = new movimentacaoPecasDto();
                dto.NRequisicao = controller.NRequisicao;
                dto.CodigoPeca = controller.CodigoPeca;
                dto.DescricaoPeca = controller.DescricaoPeca;
                dto.Unidade = controller.Unidade;

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

                dto.Asu = controller.Asu;
                dto.TipoMovimentacao = controller.TipoMovimentacao;

                dto.UsuarioSolicitacao = controller.UsuarioSolicitacao;
                dto.DataHoraSolicitacao = controller.DataHoraSolicitacao;
                dto.UsuarioAutorizacao = controller.UsuarioAutorizacao;
                dto.DataHoraAutorizacao = controller.DataHoraAutorizacao;
                dto.UsuarioMovimentacao = loginController.Nome;
                dto.DataHoraMovimentacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
                dao.Insert(dto);
                if (dto.Msg != null)
                {
                    controller.Msg = dto.Msg;
                }
                else
                {
                    EstoqueController = new EstoquePecasController();
                    EstoqueController.QtEstoque = controller.Qtd;
                    EstoqueController.Codigo = controller.CodigoPeca;
                    EstoqueService.UpdateEstoque(EstoqueController,QuantidadeDisponivel,controller.TipoMovimentacao);
                    if(EstoqueController.Msg != null)
                    {
                        controller.Msg = EstoqueController.Msg;
                    }
                }
            }

        }

        public void InsertSaida(movimentacaoPecasController controller)
        {
           /* dto = new movimentacaoPecasDto();
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
            }*/
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
