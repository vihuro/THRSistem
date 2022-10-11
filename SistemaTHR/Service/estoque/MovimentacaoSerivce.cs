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

        public void InsertSaidaManual(MovimentacaoController controller, string QuantidadeEstoque)
        {
            dto = new MovimentacaoDto();
            if(Convert.ToDouble(QuantidadeEstoque.ToString()) < Convert.ToDouble(controller.Quantidade.ToString()))
            {
                controller.Msg = $"Não é possivel inserir uma saída maior do que a quantidade disponivel! Quantidade Disponivel = {QuantidadeEstoque}";
            }
            else
            {
                double quantidadeMovimetacao = Convert.ToDouble(controller.Quantidade) * -1;

                dto.Codigo = controller.Codigo;
                dto.Descricao = controller.Descricao;
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
            }

        }

        public void InsertEntradaManual(MovimentacaoController controller)
        {
            dto = new MovimentacaoDto();
            dto.Codigo = controller.Codigo;
            dto.Descricao = controller.Descricao;
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
        }
    }
}
