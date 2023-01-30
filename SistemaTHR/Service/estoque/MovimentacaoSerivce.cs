using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.estoque;
using SistemaTHR.Controller.estoque;
using SistemaTHR.DAO.Estoque;
using SistemaTHR.Controller.Login;
using SistemaTHR.Service.Exepction;
using SistemaTHR.dto.manutencao;
using SistemaTHR.dto.transferencia;
using SistemaTHR.Controller.transferencia;

namespace SistemaTHR.Service.estoque
{
    internal class MovimentacaoSerivce
    {
        private MovimentacaoDto dto;
        private MovimentacaoDao dao = new MovimentacaoDao();
        private loginController loginController;
        private modulosController modulosController;
        private EstoqueService estoqueService;


        public MovimentacaoSerivce(loginController loginController)
        {
            this.loginController = loginController;
            estoqueService = new EstoqueService(loginController);

        }

        public void Count(MovimentacaoController controller)
        {
            dto = new MovimentacaoDto();
            dto.Codigo = controller.Codigo;
            dao.Count(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;

            }
            else
            {
                controller.Quantidade = dto.Quantidade;
            }

        }

        public void SelectTable(MovimentacaoController controller)
        {
            dto = new MovimentacaoDto();
            controller.Dt = dao.SelectTable();
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }

        }
        public void InsertRequisicaoProducao(MovimentacaoController controller)
        {
            double quantidadeMovimetacao = Convert.ToDouble(controller.Quantidade) * -1;

            dto = new MovimentacaoDto();
            controller.Dt = dao.SelectTable();
            var disponivel = estoqueService.Count(controller, controller.Codigo);
            if (disponivel + quantidadeMovimetacao < 0)
            {
                throw new ExceptionService($"Não é possível fazer essa movimentação! \r\n" +
                                            $"Quantidade disponível = {disponivel} \r\n" +
                                            $"Quantidade Solicitada = {controller.Quantidade}");
            }
            dto.Codigo = controller.Codigo;
            dto.Descricao = controller.Descricao;
            dto.Movimento = "SAÍDA";
            dto.DataMovimentacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyy HH:mm:ss"));
            dto.Quantidade = quantidadeMovimetacao.ToString();
            dto.Operacao = "SAÍDA - REQUISIÇÃO PRODUÇÃO";
            dto.Usuario = loginController.Nome;
            dao.Insert(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        string QuantidadeAntiga;
        string QuantidadeNova;
        string texto;




        public void InsertSaidaManual(MovimentacaoController controller, string QuantidadeEstoque)
        {
            dto = new MovimentacaoDto();
            if (controller.Codigo != string.Empty && controller.Descricao != string.Empty && controller.Quantidade != string.Empty && controller.Movimento != string.Empty &&
                QuantidadeEstoque != string.Empty)
            {
                if (Convert.ToDouble(QuantidadeEstoque) < Convert.ToDouble(controller.Quantidade))
                {
                    controller.Msg = $"Não é possível inserir uma saída maior do que a quantidade disponível! \r\n " +
                        $"Quantidade disponível = {QuantidadeEstoque} \r\n" +
                        $"Quantidade Solicitada = {controller.Quantidade}";
                }
                else
                {
                    double quantidadeMovimetacao = Convert.ToDouble(controller.Quantidade) * -1;

                    dto.Codigo = controller.Codigo.ToUpper();
                    dto.Descricao = controller.Descricao.ToUpper();
                    dto.Movimento = "SAÍDA";
                    dto.DataMovimentacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyy HH:mm:ss"));
                    dto.Quantidade = quantidadeMovimetacao.ToString();
                    dto.Operacao = controller.Operacao;
                    dto.Usuario = loginController.Nome;
                    dao.Insert(dto);
                    if (dto.Msg != null)
                    {
                        controller.Msg = dto.Msg;
                    }
                    double EmEstoque = Convert.ToDouble(QuantidadeEstoque);
                    double total = Convert.ToDouble(QuantidadeEstoque) - Convert.ToDouble(controller.Quantidade);
                    this.QuantidadeAntiga = EmEstoque.ToString("###,###.##");
                    this.QuantidadeNova = total.ToString("###,###.##");
                }
            }
            else
            {
                controller.Msg = "Campo(s) obrigatório(s) vazio(s)!";
            }

        }

        public string quantidadeDisponivel()
        {

            return texto = $"Quantidade anterior = {QuantidadeAntiga} \r\n" +
                           $"Nova quantidade     = {QuantidadeNova} ";
        }

        public void InsertEntradaManual(MovimentacaoController controller, string QuantidadeEstoque)
        {
            if (controller.Codigo != string.Empty && controller.Descricao != string.Empty && controller.Operacao != string.Empty &&
                controller.Quantidade != string.Empty)
            {
                dto = new MovimentacaoDto();
                dto.Codigo = controller.Codigo.ToUpper();
                dto.Descricao = controller.Descricao.ToUpper();
                dto.Movimento = "ENTRADA";
                dto.DataMovimentacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyy HH:mm:ss"));
                dto.Quantidade = controller.Quantidade;
                dto.Operacao = controller.Operacao;
                dto.Usuario = loginController.Nome;
                dao.Insert(dto);
                if (dto.Msg != null)
                {
                    controller.Msg = dto.Msg;
                }
                else
                {
                    double EmEstoque = Convert.ToDouble(QuantidadeEstoque);
                    double total = Convert.ToDouble(QuantidadeEstoque) + Convert.ToDouble(controller.Quantidade);
                    this.QuantidadeAntiga = EmEstoque.ToString("###,###.##");
                    this.QuantidadeNova = total.ToString("###,###.##");
                }
            }
            else
            {
                controller.Msg = "Campo(s) obrigatório(s) vazio(s)!";
            }

        }

    }
}
