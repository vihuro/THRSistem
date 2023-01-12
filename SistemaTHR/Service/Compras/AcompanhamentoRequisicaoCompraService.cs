using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.Compras;
using SistemaTHR.Controller.Compras;
using SistemaTHR.DAO.Compras;
using SistemaTHR.DAO.Manutencao;
using SistemaTHR.Service.Exepction;
using System.Data;
using SistemaTHR.Controller.Login;

namespace SistemaTHR.Service.Compras
{
    internal class AcompanhamentoRequisicaoCompraService
    {
        private AcompanhamentoRequisicaoCompraDao dao;
        private AcompanhamentoRequisicaoCompraDto dto;
        private modulosController modulosController;
        private loginController loginController;
        public AcompanhamentoRequisicaoCompraService(modulosController modulosController, loginController loginController)
        {
            dao = new AcompanhamentoRequisicaoCompraDao();
            this.modulosController = modulosController;
            this.loginController = loginController;
        }
        public void Insert(string  numeroRequisicao)
        {
            dto = new AcompanhamentoRequisicaoCompraDto();
            //Validar se o campo está vazio
            if (numeroRequisicao == string.Empty)
            {
                throw new ExceptionService("Não foi possivel gerar o acompanhamento dessa requisição!");
            }
            //Valida se o usuário tem permissão para fazer o Insert
            if(modulosController.Almoxarifado != "Sim" && 
                modulosController.AlmoxarifadoNivel != "2" &&
                modulosController.AlmoxarifadoNivel != "1" || 
                modulosController.Compras != "Sim" && 
                modulosController.ComprasNivel != "2" && 
                modulosController.ComprasNivel != "1")
            {
                throw new ExceptionService("Esse usuário não tem permissão para essa ação!");
            }

            foreach(var itens in Acompanhamentos())
            {
                dto.NumeroRequisicao = numeroRequisicao;
                dto.DescricaoRequisicao = itens;
                dto.DataHoraApontamento = "00/00/0000 00:00";
                dto.UsuarioApontamento = "";
                dto.DataHoraAlteracao = "00/00/0000 00:00";
                dto.UsuarioAlteracao = "";
                dto.Observacao = "";

                if (itens == "Geração")
                {
                    dto.DataHoraApontamento = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
                    dto.UsuarioApontamento = loginController.Nome;
                    dto.DataHoraAlteracao = dto.DataHoraApontamento;
                    dto.UsuarioAlteracao = loginController.Nome;


                    dao.Insert(dto);
                }
                else
                {
                    dao.Insert(dto);
                }

            }


        }

        public void Update(AcompanhamentoRequisicaoCompra controller)
        {
            dto = new AcompanhamentoRequisicaoCompraDto();
            if(controller.UsuarioAlteracao == string.Empty && controller.NumeroRequisicao == string.Empty)
            {
                throw new ExceptionService("Campo(s) obrigatório(s) vazios(s)!");
            }

            dto.UsuarioAlteracao = controller.UsuarioAlteracao;
            dto.DataHoraAlteracao = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm"));
            dto.Observacao = controller.Observacao;
            dao.Update(dto);
        }

        private bool Validar(AcompanhamentoRequisicaoCompra controller)
        {
            if(controller.UsuarioAlteracao == string.Empty && controller.NumeroRequisicao == string.Empty)
            {
                return true;
            }
            return false;
        }
        public void Delete(AcompanhamentoRequisicaoCompra controller)
        {
            dto = new AcompanhamentoRequisicaoCompraDto();
            if (Validar(controller))
            {
                throw new ExceptionService("Campo(s) obrigatório(s) vazios(s)!");
            }

            dto.DataHoraApontamento = "";
            dto.UsuarioApontamento = "";
            dto.DataHoraAlteracao = "";
            dto.UsuarioAlteracao = "";
            dao.Delete(dto);

        }

        private string[] Acompanhamentos()
        {
            string[] lista = new string[]
            {
                "Geração",
                "Diário",
                "Compra",
                "Entrega"
            };

            return lista;
        }

        public DataTable Table()
        {
            return dao.Table();
        }
    }
}
