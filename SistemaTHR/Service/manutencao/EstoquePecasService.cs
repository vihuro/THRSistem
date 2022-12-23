using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.dto.manutencao;
using SistemaTHR.Service.manutencao;
using SistemaTHR.DAO.Manutencao;
using SistemaTHR.Controller.Login;
using System.Data;

namespace SistemaTHR.Service.manutencao
{
    internal class EstoquePecasService
    {
        private EstoquePecasController controller;
        private movimentacaoPecasController movimentacaoController;
        private movimentacaoPecasService movimentacaoService;
        private loginController loginController;
        private modulosController modulosController;
        private EstoquePecasDao dao;
        private EstoquePecasDto dto;

        public EstoquePecasService(loginController loginController, modulosController modulosController)
        {
            dao = new EstoquePecasDao();
            this.loginController = loginController;
            this.modulosController = modulosController;
            //IniciarMovimentacaoService();

        }


        private movimentacaoPecasService IniciarMovimentacaoService()
        {
            return movimentacaoService = new movimentacaoPecasService(loginController, modulosController);
        }

        public void Insert(EstoquePecasController controller)
        {
            dto = new EstoquePecasDto();
            if(controller.Codigo != string.Empty && controller.Descricao != string.Empty && controller.Unidade != string.Empty && 
                controller.EstoqueMax != string.Empty && controller.EstoqueMin != string.Empty)
            {
                dto.Codigo = controller.Codigo.ToUpper();
                dto.Descricao = controller.Descricao.ToUpper();
                dto.Unidade = controller.Unidade;
                dto.QtEstoque = "0";
                dto.Fornecedor1 = controller.Fornecedor1.ToUpper();
                dto.CodFornecedor1 = controller.CodFornecedor1.ToUpper();
                dto.Fornecedor2 = controller.Fornecedor2.ToUpper();
                dto.CodFornecedor2 = controller.CodFornecedor2.ToUpper();
                dto.Fornecedor3 = controller.Fornecedor3.ToUpper();
                dto.CodFornecedor3 = controller.CodFornecedor3.ToUpper();
                dto.EstoqueMax = controller.EstoqueMax;
                dto.EstoqueMin = controller.EstoqueMin;
                dto.UsuarioGravacao = loginController.Nome;
                dto.DataHoraGravacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:sss"));
                dao.Insert(dto);
                if (dto.Msg != null)
                {
                    controller.Msg = dto.Msg;
                }
            }
            else
            {
                controller.Msg = "Campos(s) obrigatorio(s) vazio(s)!";
            }

        }

    
        public void UpdateEstoque(EstoquePecasController controller, string QuantidadeDisponivel, string tipoMovimento)
        {
            dto = new EstoquePecasDto();
            if(modulosController.AlmoxarifadoNivel == "1" || modulosController.AlmoxarifadoNivel == "2")
            {
                decimal QuantidadeEstoque = Convert.ToDecimal(QuantidadeDisponivel);

                decimal QuantidadeSolicitada = Convert.ToDecimal(controller.QtEstoque);

                if (QuantidadeEstoque < QuantidadeSolicitada && tipoMovimento == "Saída")
                {
                    controller.Msg = $"Quantidade em estoque é menor do que a quantidade solicitada! \r\n " +
                                     $"Quantidade em estoque: {QuantidadeEstoque.ToString("###,###.##")}\r\n" +
                                     $"Quantidade Solicitada: {QuantidadeSolicitada.ToString("###,###.##")}";
                }
                else
                {
                    decimal total = 0;
                    if (tipoMovimento == "Saída") 
                    {
                        total = QuantidadeEstoque - QuantidadeSolicitada;

                    }
                    else if(tipoMovimento == "Entrada")
                    {
                        total = QuantidadeEstoque + QuantidadeSolicitada;
                    }


                    dto.Codigo = controller.Codigo;
                    dto.QtEstoque = total.ToString();

                    dao.updateQtEstoque(dto);
                    if (dto.Msg != null)
                    {
                        controller.Msg = dto.Msg;
                    }


                }
            }
            else
            {
                controller.Msg = "Esse usuário não tem permissão para movimentar o estoque!";
            }


        }

        private void MovimetacaoPecas(EstoquePecasController controller, string tipoMovimentacao)
        {/*
            movimentacaoController = new movimentacaoPecasController();

            movimentacaoController.NRequisicao = "";
            movimentacaoController.CodigoPeca = controller.Codigo;
            movimentacaoController.DescricaoPeca = controller.Descricao;
            movimentacaoController.Unidade = controller.Unidade;
            movimentacaoController.Qtd = controller.QtEstoque;

            if(movimentacaoController.Asu == string.Empty)
            {
                movimentacaoController.Asu = "MOVIMENTAÇÂO - MANUAL";
            }

            if(tipoMovimentacao == "Entrada")
            {
                movimentacaoController.Status = "Finalizado";
            }
            else if(tipoMovimentacao == "Saída")
            {
                movimentacaoController.Status = "Pendente";
            }
            movimentacaoController.TipoMovimentacao = tipoMovimentacao;

            movimentacaoController.UsuarioSolicitacao = "";
            movimentacaoController.DataHoraSolicitacao = "";
            movimentacaoController.UsuarioAutorizacao = "";
            movimentacaoController.DataHoraAutorizacao = "";
            movimentacaoController.UsuarioMovimentacao = loginController.Nome;
            movimentacaoController.DataHoraMovimentacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));

            movimentacaoService.insertMovimentacao(movimentacaoController);
            if(movimentacaoController.Msg != null)
            {
                controller.Msg = movimentacaoController.Msg;
            }*/

        }

        public void VerificarCodigo(EstoquePecasController controller, string tipoMovimentacao)
        {
            dto = new EstoquePecasDto();
            if (controller.Codigo != string.Empty && controller.Descricao != string.Empty && controller.QtEstoque != string.Empty &&
                tipoMovimentacao != string.Empty)
            {
                dto.Codigo = controller.Codigo;
                dao.estoque(dto);
                if (dto.Msg != null)
                {
                    controller.Msg = dto.Msg;
                }
                else
                {
                    controller.Exists = dto.Exists;
                    controller.QtEstoque = dto.QtEstoque;
                }

            }
            else
            {
                controller.Msg = "Campo(s) obrigatorio(s) vazio(s)!";
            }


        }

        private void EntradaEstoque(EstoquePecasController controller, EstoquePecasDto dto, string tipoMovimentacao)
        {
            controller.Exists = dto.Exists;
            decimal qtEstoque = Convert.ToDecimal(dto.QtEstoque);
            decimal qtRecebida = Convert.ToDecimal(controller.QtEstoque);



            decimal total = qtEstoque + qtRecebida;
            controller.QtEstoque = Convert.ToString(total);
            controller.Descricao = dto.Descricao;
            dto.QtEstoque = total.ToString();

            dto.Codigo = controller.Codigo;
            MovimetacaoPecas(controller, tipoMovimentacao);
            if(controller.Msg == null)
            {
                dao.updateQtEstoque(dto);
                if (dto.Msg != null)
                {
                    controller.Msg = dto.Msg;
                }
            }

        }

        public void Update(EstoquePecasController controller)
        {
            dto = new EstoquePecasDto();
            if(modulosController.AlmoxarifadoNivel == "1" || modulosController.AlmoxarifadoNivel == "2")
            {

                dto.Descricao = controller.Descricao;
                dto.Unidade = controller.Unidade;
                dto.Fornecedor1 = controller.Fornecedor1;
                dto.CodFornecedor1 = controller.CodFornecedor1;
                dto.Fornecedor2 = controller.Fornecedor2;
                dto.CodFornecedor2 = controller.CodFornecedor2;
                dto.Fornecedor3 = controller.Fornecedor3;
                dto.CodFornecedor3 = controller.CodFornecedor3;
                dto.EstoqueMax = controller.EstoqueMax;
                dto.EstoqueMin = controller.EstoqueMin;
                dto.UsuarioGravacao = loginController.Nome;
                dto.DataHoraGravacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:sss"));
                dto.Codigo = controller.Codigo;
                dao.Update(dto);
                if (dto.Msg != null)
                {
                    controller.Msg = dto.Msg;
                }
            }
            else
            {
                controller.Msg = "Este usuário não tem acesso para alterar cadastro!";
            }

        }

        public DataTable table()
        {
            return dao.table();
        }

        private void deleteCadastro()
        {
            dto = new dto.manutencao.EstoquePecasDto();
            dto.Codigo = controller.Codigo;
            dao.delete(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }
        public void delete(EstoquePecasController controller)
        {
            this.controller = controller;
            deleteCadastro();
        }

        public void BuscarInformacao(EstoquePecasController controller)
        {
            var linha = controller.Dt.Select($"Codigo = '{controller.Codigo}'");
            if (linha.Count() > 0)
            {
                controller.Descricao = linha[0]["Descricao"].ToString();
                controller.Unidade = linha[0]["Unidade"].ToString();
            }
            else
            {
                controller.Msg = "Código não econtrado!";
            }
        }
    }
}
