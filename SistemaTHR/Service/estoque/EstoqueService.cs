using System;
using System.Linq;
using SistemaTHR.dto.estoque;
using SistemaTHR.Controller.estoque;
using SistemaTHR.DAO.Estoque;
using SistemaTHR.Controller.Login;
using System.Data;

namespace SistemaTHR.Service.estoque
{
    public class EstoqueService
    {
        private EstoqueDto dto;
        private EstoqueDao dao = new EstoqueDao();
        private loginController loginController;

        public EstoqueService(loginController loginController)
        {
            this.loginController = loginController;
        }

        public void selectTable(EstoqueController controller)
        {
            dto = new EstoqueDto();
            dao.selectTable(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }


        public void Insert(EstoqueController controller)
        {
            dto = new EstoqueDto();
            dto.CodRef = controller.CodRef.ToUpper();
            dto.Codigo = controller.Codigo.ToUpper();
            dto.Descricao = controller.Descricao.ToUpper();
            dto.Unidade = controller.Unidade;
            dto.Grupo = controller.Grupo;
            dto.Fornecedor = controller.Fornecedor.ToUpper();
            dto.Usuario = loginController.Nome;
            dto.DataHoraCadatro = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            dto.EstoqueMinimo = controller.EstoqueMinimo;
            dto.EstoqueMaximo = controller.EstoqueMaximo;
            dto.EstoqueSeguranca = controller.EstoqueSeguranca;
            dao.Insert(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }

        public void Update(EstoqueController controller)
        {
            dto = new EstoqueDto();
            dto.Codigo = controller.Codigo.ToUpper();
            dto.CodRef = controller.CodRef.ToUpper();
            dto.Descricao = controller.Descricao.ToUpper();
            dto.Unidade = controller.Unidade;
            dto.Grupo = controller.Grupo;
            dto.Fornecedor = controller.Fornecedor.ToUpper();
            dto.Usuario = loginController.Nome;
            dto.DataHoraCadatro = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            dto.EstoqueMinimo = controller.EstoqueMinimo;
            dto.EstoqueMaximo = controller.EstoqueMaximo;
            dto.EstoqueSeguranca = controller.EstoqueSeguranca;
            dao.Update(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }
        public void Delete(EstoqueController controller)
        {
            dto = new EstoqueDto();
            dto.Codigo = controller.Codigo;
            dto.CodRef = controller.CodRef;
            dao.Delete(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }
        public void FilterWithCodigo(EstoqueController controller)
        {
            dto = new EstoqueDto();
            dto.Codigo = controller.Codigo;
            dao.FilterWithCodigo(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }
        public void FilterWithGrupo(EstoqueController controller)
        {
            dto = new EstoqueDto();
            dto.Grupo = controller.Grupo;
            dao.FilterWithGrupo(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }
        public void FilterWithDescricao(EstoqueController controller)
        {
            dto = new EstoqueDto();
            dto.Descricao = controller.Descricao;
            dao.FilterWithDescricao(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }
        public void FilterTableDescricao(EstoqueController controller)
        {
            dto = new EstoqueDto();
            dto.Descricao = controller.Descricao;
            dao.FilterTableDescricao(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }
        public double Count(MovimentacaoController movimentacaoController, string codigo)
        {


            var somaPorCodigo = movimentacaoController.Dt.AsEnumerable().Where(rows => rows.Field<string>("CodProd") ==
                 codigo)
                .Sum(rows => rows.Field<double>("Quantidade"));


            return somaPorCodigo;
        }
        public double Count(DataTable dt, string codigo)
        {


            var somaPorCodigo = dt.AsEnumerable().Where(rows => rows.Field<string>("CodProd") ==
                 codigo)
                .Sum(rows => rows.Field<double>("Quantidade"));


            return somaPorCodigo;
        }

        public void FilterCode(EstoqueController controller)
        {
            dto = new EstoqueDto();
            dto.CodRef = controller.CodRef;
            dao.FilterCode(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.CodigoList = dto.CodigoList;
                controller.DescricaoList = dto.DescricaoList;

                controller.Exits = dto.Exitis;
                controller.Codigo = dto.Codigo;
            }
        }
    }
}
