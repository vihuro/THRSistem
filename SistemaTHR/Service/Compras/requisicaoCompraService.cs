using SistemaTHR.dto.Compras;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Service.Compras
{
    internal class requisicaoCompraService
    {
        private Controller.Compras.requisicaoCompraController controller;
        private DAO.Manutencao.requisicaoCompraDao dao = new DAO.Manutencao.requisicaoCompraDao();
        private dto.Compras.requisicaoCompraDto dto;
        private void insertRequisicao()
        {
            dto = new dto.Compras.requisicaoCompraDto();
            dto.Codigo = controller.Codigo;
            dto.Descricao = controller.Descricao;
            dto.Quantidade = controller.Quantidade;
            dto.Unidade = controller.Unidade;
            dto.UsuarioSolicitacao = controller.UsuarioSolicitacao;
            dto.DataHoraSolicitacao = controller.DataHoraSolicitacao;
            dto.Status = "Pendedente";
            dao.insert(dto);
        }
        public void insert(Controller.Compras.requisicaoCompraController controller)
        {
            this.controller = controller;
            verificarAberto();
        }
        private void verificarAberto()
        {
            dto = new dto.Compras.requisicaoCompraDto();
            dto.Codigo = controller.Codigo;
            dao.verificar(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                if(dto.NRequisicao != null)
                {
                    updateRequisicao(dto);
                }
                else
                {
                    insertRequisicao();
                }
            }
 
        }
        public void verificar(requisicaoCompraDto dto)
        {
            this.dto = dto;
            verificarAberto();
        }

        private void updateRequisicao(requisicaoCompraDto dto)
        {
            decimal quantidadeAntiga =Convert.ToDecimal(dto.Quantidade);
            decimal quantidadeRequisitada = Convert.ToDecimal(controller.Quantidade);
            decimal total = quantidadeAntiga + quantidadeRequisitada;
            dto.Quantidade = total.ToString();
            dao.updateRequisicao(dto);

        }

        private void updateAuth()
        {
            dto = new dto.Compras.requisicaoCompraDto();
            dto.UsuarioAutorizador = controller.UsuarioAutorizador;
            dto.DataHoraAutorizacao = controller.DataHoraAutorizacao;
            dto.Status = controller.Status;
            dto.NRequisicao = controller.NRequisicao;
            dao.auth(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }
        public void auth(Controller.Compras.requisicaoCompraController controller)
        {
            this.controller = controller;
            updateAuth();
        }
        private void updateCompra()
        {
            dto = new dto.Compras.requisicaoCompraDto();
            dto.UsuarioCompra = controller.UsuarioCompra;
            dto.DataHoraCompra = controller.DataHotaCompra;
            dto.Status = controller.Status;
            dto.NRequisicao = controller.NRequisicao;
            dao.compra(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
        }
        public void compra(Controller.Compras.requisicaoCompraController controller)
        {
            this.controller = controller;
            updateCompra();
        }
        private void selectTable()
        {
            dto = new dto.Compras.requisicaoCompraDto();
            dao.table(dto);
            if(dto.Msg != null)
            {
                controller.Msg= dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }
        public void table(Controller.Compras.requisicaoCompraController controller)
        {
            this.controller = controller;
            selectTable();
        }
    }
}
