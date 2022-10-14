using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.manutencao;

namespace SistemaTHR.DAO.Manutencao
{
    internal class movimentacaoPecasDao
    {

        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private Connection con = new Connection();
        private OleDbDataAdapter da;

        private movimentacaoPecasDto dto;

        public void Insert(movimentacaoPecasDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into tab_movimentacaoPecas " +
                "(NRequisicao, CodigoPeca , DescricaoPeca, Unidade, Qtd, Asu,TipoMovimentacao,Status , UsuarioSolicitacao, " +
                "DataHoraSolicitacao, UsuarioAutorizacao, DataHoraAutorizacao, usuarioMovimentacao, DataHoraMovimentacao)" +
                " Values" +
                " (@NRequisicao ,@codigoPeca, @descricaoPeca, @unidade, @Qtd, @Asu,@TipoMovimentacao, @Status , @UsuarioSolicitacao, " +
                "@dataHoraSolicitacao, @usuarioAutorizacao, @dataHoraAutorizacao, @usuarioMovimentacao, @dataHoraMovimentacao)";
            cmd.Parameters.AddWithValue("", dto.NRequisicao);
            cmd.Parameters.AddWithValue("", dto.CodigoPeca);
            cmd.Parameters.AddWithValue("", dto.DescricaoPeca);
            cmd.Parameters.AddWithValue("", dto.Unidade);
            cmd.Parameters.AddWithValue("", dto.Qtd);
            cmd.Parameters.AddWithValue("", dto.Asu);
            cmd.Parameters.AddWithValue("", dto.TipoMovimentacao);
            cmd.Parameters.AddWithValue("", dto.Status);
            cmd.Parameters.AddWithValue("", dto.UsuarioSolicitacao);
            cmd.Parameters.AddWithValue("", dto.DataHoraSolicitacao);
            cmd.Parameters.AddWithValue("", dto.UsuarioAutorizacao);
            cmd.Parameters.AddWithValue("", dto.DataHoraAutorizacao);
            cmd.Parameters.AddWithValue("", dto.UsuarioMovimentacao);
            cmd.Parameters.AddWithValue("", dto.DataHoraMovimentacao);
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

     
        private void updateMovimentacao()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Update tab_movimentacaoPecas set Status =@Status, usuarioMovimentacao = @usuarioMovimentacao, dataHoraMovimentacao = @dataHoramovimentacao " +
                "where NMovimentacao = @NMovimentacao ";
            cmd.Parameters.AddWithValue("", dto.Status);
            cmd.Parameters.AddWithValue("",dto.UsuarioMovimentacao);
            cmd.Parameters.AddWithValue("", dto.DataHoraMovimentacao);
            cmd.Parameters.AddWithValue("", dto.NMovimentacao);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }
        public void liberar(dto.manutencao.movimentacaoPecasDto dto)
        {
            this.dto = dto;
            updateMovimentacao();
        }
        private void selectTable()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_MovimentacaoPecas order by NMovimentacao asc";
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

        public void table(dto.manutencao.movimentacaoPecasDto dto)
        {
            this.dto = dto;
            selectTable();
        }

        private void exportMovimetacao()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_movimentacaoPecas where NRequisicao = @NRequisicao";
            cmd.Parameters.AddWithValue("",dto.NRequisicao);
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
        public void export(dto.manutencao.movimentacaoPecasDto dto)
        {
            this.dto = dto;
            exportMovimetacao();
        }

        private void selectCodigo()
        {

            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_movimentacaoPecas where codigoPeca = @codigoPeca";
            cmd.Parameters.AddWithValue("",dto.CodigoPeca);
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

        public void selectHistory(dto.manutencao.movimentacaoPecasDto dto)
        {
            this.dto = dto;
            selectCodigo();
        }

        private void deleteMovimentacao()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Delete from tab_MovimentacaoPecas where NMovimentacao = @NMovimentacao";
            cmd.Parameters.AddWithValue("", dto.NMovimentacao);
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
        public void delete(dto.manutencao.movimentacaoPecasDto dto)
        {
            this.dto = dto;
            deleteMovimentacao();
        }
    }
}
