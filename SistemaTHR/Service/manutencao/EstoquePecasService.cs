using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.dto.manutencao;
using SistemaTHR.Service.manutencao;
using SistemaTHR.DAO.Manutencao;

namespace SistemaTHR.Service.manutencao
{
    internal class EstoquePecasService
    {
        private EstoquePecasController controller;
        private EstoquePecasDao dao;
        private EstoquePecasDto dto;

        public EstoquePecasService()
        {
            dao = new EstoquePecasDao();
        }


        private void insertEstoque()
        {
            dto = new dto.manutencao.EstoquePecasDto();
            dto.Codigo = controller.Codigo;
            dto.Descricao = controller.Descricao;
            dto.Unidade = controller.Unidade;
            dto.QtEstoque = controller.QtEstoque;
            dto.Fornecedor1 = controller.Fornecedor1;
            dto.CodFornecedor1 = controller.CodFornecedor1;
            dto.Fornecedor2 = controller.Fornecedor2;
            dto.CodFornecedor2 = controller.CodFornecedor2;
            dto.Fornecedor3 = controller.Fornecedor3;
            dto.CodFornecedor3 = controller.CodFornecedor3;
            dto.EstoqueMax = controller.EstoqueMax;
            dto.EstoqueMin = controller.EstoqueMin;
            dto.UsuarioGravacao = controller.UsuarioGravacao;
            dto.DataHoraGravacao = controller.DataHoraGravacao;
            dao.insert(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }
        public void insert(EstoquePecasController controller)
        {
            this.controller = controller;
            insertEstoque();
        }
        private void SaidaEstoque(EstoquePecasController controller,EstoquePecasDto dto)
        {
            controller.Exists = dto.Exists;
            decimal qtEstoque = Convert.ToDecimal(dto.QtEstoque);
            decimal qtRecebida = Convert.ToDecimal(controller.QtEstoque);

            if (qtEstoque < qtRecebida)
            {
                controller.Msg = $"Quantidade em estoque é menor do que a quantidade solicitada! \r\n Quantidade em estoque: {qtEstoque}" +
                    $"\r\n Quantidade Solicitada: {qtRecebida}";
            }
            else
            {
                decimal total = qtEstoque - qtRecebida;
                controller.QtEstoque = Convert.ToString(total *-1);
                controller.Descricao = dto.Descricao;
                dto.QtEstoque = total.ToString();

                dto.Codigo = controller.Codigo;
                dao.updateQtEstoque(dto);

                if (dto.Msg != null)
                {
                    controller.Msg = dto.Msg;
                }
                else
                {
                    MovimentacaPecaSaida(controller);
                }
            }
        }

        private void MovimentacaPecaSaida(EstoquePecasController controller)
        {
            //movimentacaoPecasController = new movimentacaoPecasController();
        }

        public void VerificarCodigo(EstoquePecasController controller)
        {
            dto = new EstoquePecasDto();
            dto.Codigo = controller.Codigo;
            dao.estoque(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                if (dto.Exists == true)
                {

                    SaidaEstoque(controller,dto);

                }
                else
                {
                    controller.Msg = "Peça não encontrada! Não é possivel gerar a movimentação de uma peça não cadastrada!";
                }

            }

        }


        public void entradaEstoque(EstoquePecasController controller)
        {
            this.controller = controller;
            //qtdEstoque();
        }
        private void updateInfoEstoque()
        {
            dto = new dto.manutencao.EstoquePecasDto();
            dto.Unidade = controller.Unidade;
            dto.EstoqueMax = controller.EstoqueMax;
            dto.EstoqueMin = controller.EstoqueMin;
            dto.UsuarioGravacao = controller.UsuarioGravacao;
            dto.DataHoraGravacao = controller.DataHoraGravacao;
            dto.Codigo = controller.Codigo;
            dao.updateInfo(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }
        public void updateInfo(EstoquePecasController controller)
        {
            this.controller = controller;
            updateInfoEstoque();
        }
        private void openTable()
        {
            dto = new dto.manutencao.EstoquePecasDto();
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
        public void table(EstoquePecasController controlle)
        {
            this.controller = controlle;
            openTable();
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
            if(linha.Count() > 0)
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
