using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Manutencao
{
    internal class SolicitaCompraOSTHRDAO
    {

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
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

        private void selectRequisicaoPeca()
        {
            cmd.CommandText = "Select * from tab_SolicitacaoPecaOSTHR where NOS = @nOS";
            cmd.Parameters.AddWithValue("@nOS", nOS);

            try
            {
                cmd.Connection = con.conectar();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(dt);


            }
            catch (Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }

        }

        public void selectPecas()
        {
            selectRequisicaoPeca();
        }

    }
}
