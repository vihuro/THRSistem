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
    
    internal class SolicitacaoService
    {
        private SolicitacaoDto dto;
        private loginController loginController;
        private SolicitacaoDao dao = new SolicitacaoDao();
        private MovimentacaoController movimentacaController;
        private MovimentacaoSerivce movimentacaoService;
        private SolicitacaoService service;

        public SolicitacaoService(loginController loginController)
        {
            this.loginController = loginController;
            movimentacaoService = new MovimentacaoSerivce(loginController);
        }

        public void Insert(SolicitacaoController controller)
        {
            dto = new SolicitacaoDto();
            if(controller.OrdemProducao != string.Empty && controller.Maquina != string.Empty && controller.CodigoItem != string.Empty && 
                controller.DescricaoItem != string.Empty && controller.Fornecedor != string.Empty)
            {
                dto.Data = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy"));
                dto.OrdemProducao = controller.OrdemProducao;
                dto.Requerente = loginController.Nome;
                dto.Maquina = controller.Maquina;
                dto.Item = controller.Item;
                dto.DescricaoItem = controller.DescricaoItem;
                dto.CodigoItem = controller.CodigoItem;
                dto.Fornecedor = controller.Fornecedor;
                dto.HoraSolicitacao = Convert.ToString(DateTime.Now.ToString("HH:mm:sss"));
                dto.Status = "AGUARDANDO ENTREGA";
                dao.Insert(dto);
                if (dto.Msg != null)
                {
                    controller.Msg = dto.Msg;
                }
            }
            else
            {
                controller.Msg = "Campo(s) obrigatorio(s) vazio(s)!";
            }

        }
        public void UpdateFinally(SolicitacaoController controller,string quantidade)
        {

            dto = new SolicitacaoDto();
            InsertMovimentacao(controller, quantidade);
            var tempoEspera = TempoEspera(Convert.ToDateTime(controller.Data.ToString()), DateTime.Now);
            dto.HoraEntrega = Convert.ToString(DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"));
            dto.Status = "ENTREGUE";
            dto.TempoEspera = tempoEspera;
            dto.Entregador = loginController.Nome;
            dto.Id = controller.Id;
            dao.UpdateFinally(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }


        }

        public void InsertMovimentacao(SolicitacaoController controller, string quantidade)
        {
            movimentacaController = new MovimentacaoController();
            movimentacaController.Codigo = controller.CodigoItem;
            movimentacaController.Descricao = controller.DescricaoItem;
            movimentacaController.Quantidade = quantidade;
            movimentacaoService.InsertRequisicaoProducao(movimentacaController);
            if(movimentacaController.Msg != null)
            {
                controller.Msg = movimentacaController.Msg;
            }


        }

        public void Delete(SolicitacaoController controller)
        {
            dto = new SolicitacaoDto();
            dto.Id = controller.Id;
            dao.Delete(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }

        }
        public void Table(SolicitacaoController controller)
        {
            dto = new SolicitacaoDto();
            dao.Table(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Dt = dto.Dt;
            }
        }
        public void SelectNumeroRequisicao(SolicitacaoController controller)
        {
            //Tenho que bucar a hora da Solicitacão aqui
            dto = new SolicitacaoDto();
            
        }

        public String TempoEspera(DateTime horaRequisicao, DateTime horaEntrega)
        {
            
            
            TimeSpan Conta = horaRequisicao - horaEntrega;



            string horas = Convert.ToString(Conta.ToString("hh"));
            string minutos = Convert.ToString(Conta.ToString("mm"));
            string segudos = Convert.ToString(Conta.ToString("ss"));

            string Reusltado = $"{horas}:{minutos}:{segudos}";

            return Reusltado;
        }
    }
}
