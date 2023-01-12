using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.estoque;
using SistemaTHR.Controller.estoque;
using SistemaTHR.DAO.Estoque;
using SistemaTHR.Controller.Login;

namespace SistemaTHR.Service.estoque
{
    internal class MovimentacaoSerivce
    {
        private MovimentacaoDto dto;
        private MovimentacaoDao dao = new MovimentacaoDao();
        private loginController loginController;
        private modulosController modulosController;


        public MovimentacaoSerivce(loginController loginController)
        {
            this.loginController = loginController;

        }

        public void Count(MovimentacaoController controller)
        {
            dto = new MovimentacaoDto();
            dto.Codigo = controller.Codigo;
            dao.Count(dto);
            if(dto.Msg != null)
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
            dao.SelectTable(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }
        public void InsertRequisicaoProducao(MovimentacaoController controller)
        {
            double quantidadeMovimetacao = Convert.ToDouble(controller.Quantidade) *-1;

            dto = new MovimentacaoDto();
            dto.Codigo = controller.Codigo;
            dto.Descricao = controller.Descricao;
            dto.Movimento = "SAIDA";
            dto.DataMovimentacao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyy HH:mm:ss"));
            dto.Quantidade = quantidadeMovimetacao.ToString();
            dto.Operacao = "SAIDA - REQUISICAO PRODUCAO";
            dto.Usuario = loginController.Nome;
            dao.Insert(dto);
            if(dto.Msg != null)
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
            if(controller.Codigo != string.Empty && controller.Descricao != string.Empty && controller.Quantidade != string.Empty && controller.Movimento != string.Empty && 
                QuantidadeEstoque != string.Empty)
            {
                if (Convert.ToDouble(QuantidadeEstoque) < Convert.ToDouble(controller.Quantidade))
                {
                    controller.Msg = $"Não é possivel inserir uma saída maior do que a quantidade disponivel! \r\n " +
                        $"Quantidade Disponivel = {QuantidadeEstoque} \r\n" +
                        $"Quantidade Solicitada = {controller.Quantidade}";
                }
                else
                {
                    double quantidadeMovimetacao = Convert.ToDouble(controller.Quantidade) * -1;

                    dto.Codigo = controller.Codigo.ToUpper();
                    dto.Descricao = controller.Descricao.ToUpper();
                    dto.Movimento = "SAIDA";
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
                controller.Msg = "Campo(s) obrigatorio(s) vazio(s)!";
            }

        }

        public string quantidadeDisponivel()
        {

            return texto = $"Quantidade anterior = {QuantidadeAntiga} \r\n" +
                           $"Nova quantidade     = {QuantidadeNova} ";
        }

        public void InsertEntradaManual(MovimentacaoController controller, string QuantidadeEstoque)
        {
            if(controller.Codigo != string.Empty && controller.Descricao != string.Empty && controller.Operacao != string.Empty && 
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
                controller.Msg = "Campo(s) obrigatorio(s) vazio(s)!";
            }

        }
    }
}
