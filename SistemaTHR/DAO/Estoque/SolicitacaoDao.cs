using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.estoque;


namespace SistemaTHR.DAO.Estoque
{
    internal class SolicitacaoDao
    {
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private ConnectionEstoque con = new ConnectionEstoque();
        private OleDbDataAdapter da;

        public void Insert(SolicitacaoDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into Solicitacao (Data, Ordem, Requerente, Maquina,Item, Descricao_Item, Codigo_Item, " +
                "Fornecedor, HorarioSolicitado, Status) Values (@Data, @Ordem, @Requerente,@Maquina, @Item, @DescricaoItem, @CodigoItem, " +
                "@Fornecedor, @HoraSolicitacao, @Status)";
            cmd.Parameters.AddWithValue("", dto.Data);
            cmd.Parameters.AddWithValue("", dto.OrdemProducao);
            cmd.Parameters.AddWithValue("", dto.Requerente);
            cmd.Parameters.AddWithValue("", dto.Maquina);
            cmd.Parameters.AddWithValue("", dto.Item);
            cmd.Parameters.AddWithValue("", dto.DescricaoItem);
            cmd.Parameters.AddWithValue("", dto.CodigoItem);
            cmd.Parameters.AddWithValue("", dto.Fornecedor);
            cmd.Parameters.AddWithValue("", dto.HoraSolicitacao);
            cmd.Parameters.AddWithValue("", dto.Status);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                dto.Msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }
        public void UpdateFinally(SolicitacaoDto dto)
        {
            cmd.CommandText = "Update Solicitacao Set HorarioEntrega = @HorarioEntrega, Status = @Status, TempoEspera = @TempoEspera, " +
                "RespEstoque = @Entregador where id = @id";
            cmd.Parameters.AddWithValue("",dto.HoraEntrega);
            cmd.Parameters.AddWithValue("", dto.Status);
            cmd.Parameters.AddWithValue("", dto.TempoEspera);
            cmd.Parameters.AddWithValue("", dto.Entregador);
            cmd.Parameters.AddWithValue("", dto.Id);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }
        public void Delete(SolicitacaoDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Delete from Solicitacao where id = @id";
            cmd.Parameters.AddWithValue("", dto.Id);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                dto.Msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }

        }
        public void Table(SolicitacaoDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from Solicitacao where Status <> 'ENTREGUE' order by id";
            try
            {
                cmd.Connection = con.conectar();
                da = new OleDbDataAdapter(cmd);
                dto.Dt = new System.Data.DataTable();
                da.Fill(dto.Dt);

            }
            catch (Exception ex)
            {

                dto.Msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }
        public void SelectNumeroRequisicao(SolicitacaoDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from Solicitacao where id = @id";
            try
            {
                
            }
            catch (Exception ex)
            {

                dto.Msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }
    }
}
