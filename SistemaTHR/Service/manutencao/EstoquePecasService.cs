using System;
using System.Linq;
using SistemaTHR.Controller.manutencao;
using SistemaTHR.dto.manutencao;
using SistemaTHR.DAO.Manutencao;
using SistemaTHR.Controller.Login;
using System.Data;
using SistemaTHR.Service.Exepction;

namespace SistemaTHR.Service.manutencao
{
    internal class EstoquePecasService
    {
        private EstoquePecasController controller;
        private loginController loginController;
        private modulosController modulosController;
        private EstoquePecasDao dao;
        private EstoquePecasDto dto;

        public EstoquePecasService(loginController loginController, modulosController modulosController)
        {
            dao = new EstoquePecasDao();
            this.loginController = loginController;
            this.modulosController = modulosController;

        }




        public void Insert(EstoquePecasController controller)
        {
            dto = new EstoquePecasDto();
            if (controller.Codigo != string.Empty && controller.Descricao != string.Empty && controller.Unidade != string.Empty &&
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


        public void UpdateEstoque(string codigo, string quantidadeSolicitada, string tipoMovimento)
        {

            if (modulosController.AlmoxarifadoNivel != "1" && modulosController.AlmoxarifadoNivel != "2"
                && modulosController.AlmoxarifadoNivel != "3")
            {
                throw new ExceptionService("Esse usuário não tem permissão para essa requisição!");
            }

            dto = new EstoquePecasDto();

            var obj = BuscarPorCodigo(codigo);

            decimal QuantidadeEstoque = Convert.ToDecimal(obj.QtEstoque);

            decimal QuantidadeSolicitada = Convert.ToDecimal(quantidadeSolicitada);


            if (QuantidadeSolicitada * -1 > QuantidadeEstoque   && tipoMovimento == "Saída")
            {

                throw new ExceptionService($"Quantidade em estoque é menor do que a quantidade solicitada! \r\n " +
                                 $"Quantidade em estoque: {QuantidadeEstoque.ToString("###,###.##")}\r\n" +
                                 $"Quantidade Solicitada: {QuantidadeSolicitada.ToString("###,###.##")}");

            }


            if (tipoMovimento == "Saída" && QuantidadeSolicitada > 0)
            {
                QuantidadeEstoque += QuantidadeSolicitada * -1;

            }

            else
            {
                QuantidadeEstoque += QuantidadeSolicitada;
            }

            dto.Codigo = codigo;
            dto.QtEstoque = QuantidadeEstoque.ToString();

            dao.updateQtEstoque(dto);

        }


        public void VerificarCodigo(EstoquePecasController controller, string tipoMovimentacao)
        {
            dto = new EstoquePecasDto();
            if (controller.Codigo != string.Empty && controller.Descricao != string.Empty && controller.QtEstoque != string.Empty &&
                tipoMovimentacao != string.Empty)
            {
                dto.Codigo = controller.Codigo;
                dao.estoque(dto);

                controller.Exists = dto.Exists;
                controller.QtEstoque = dto.QtEstoque;
            }
            else
            {
                throw new ExceptionService("Campo(s) obrigatorio(s) vazio(s)!");
            }
        }

        public bool VerificarSeExiste(string codigo)
        {
            dto = new EstoquePecasDto();
            return dao.VerificarSeExiste(codigo);
        }

        public EstoquePecasController BuscarPorCodigo(string codigo)
        {
            dto = new EstoquePecasDto();
            if (codigo == string.Empty)
            {
                throw new ExceptionService("Código não encontrado!");
            }

            var item = dao.BuscarPorCodigo(codigo);
            if (item.Codigo == null)
            {
                throw new ExceptionService("Código não encontrado!");
            }

            return new EstoquePecasController(item);
        }


        public void Update(EstoquePecasController controller)
        {
            dto = new EstoquePecasDto();
            if (modulosController.AlmoxarifadoNivel == "1" || modulosController.AlmoxarifadoNivel == "2")
            {

                dto.Descricao = controller.Descricao.ToUpper();
                dto.Unidade = controller.Unidade.ToUpper();
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
