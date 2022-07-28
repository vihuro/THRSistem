using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo.Manutencao
{
    internal class SolicitacaoCompraOSTHRController
    {
        public DataTable dt = new DataTable();

        public String nOS;
        public String codigoPeca;
        public String DescricaoPeca;
        public String qtd;
        public String unidade;
        public String nomeSolicitante;
        public String dataHoraSolicitacao;
        public String nomeAutorizador;
        public String dataHoraAutorizacao;
        public String usuarioSolicitacaoCompra;
        public String dataHoraSolicitacaoCompra;
        public String dataHoraCompraRealizada;
        public String msg;

        DAO.Manutencao.SolicitaCompraOSTHRDAO dao;


        private void selectRequisicaoPeca()
        {
            dao = new DAO.Manutencao.SolicitaCompraOSTHRDAO();
            dao.nOS = this.nOS;
            dao.selectPecas();
            this.dt = dao.dt;
            if (dao.msg != null)
            {
                this.msg = dao.msg;
            }
        }

        public void selectPecas()
        {
            selectRequisicaoPeca();
        }
    }
}
