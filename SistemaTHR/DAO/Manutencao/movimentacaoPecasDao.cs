using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.manutencao;
using SistemaTHR.Service.Exepction;

namespace SistemaTHR.DAO.Manutencao
{
    internal class movimentacaoPecasDao
    {

        private OleDbCommand cmd;
        private Connection con = new Connection();
        private OleDbDataAdapter da;
        private OleDbDataReader dr;

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
                throw new ExceptionService(ex.Message);
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
                throw new ExceptionService(ex.Message);
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
        public DataTable Table()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "SELECT * from tab_MovimentacaoPecas ORDER BY NMovimentacao ASC";
            try
            {
                cmd.Connection = con.conectar();
                da = new OleDbDataAdapter(cmd);
                var dt = new DataTable();
                da.Fill(dt);

                return dt;

            }
            catch (Exception ex)
            {
                throw new ExceptionService(ex.Message);
            }
            finally
            {
                con.desconectar();
            }
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

        public movimentacaoPecasDto SelectMovimentacao(string id)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "SELECT * FROM tab_movimentacaoPecas WHERE NMovimentacao = @NumeroMovimentacao";
            cmd.Parameters.AddWithValue("", id);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    var obj = new movimentacaoPecasDto();
                    while (dr.Read())
                    {
                        obj.NMovimentacao = id;
                        obj.NRequisicao = dr["NRequisicao"].ToString();
                        obj.CodigoPeca = dr["CodigoPeca"].ToString();
                        obj.DescricaoPeca = dr["DescricaoPeca"].ToString();
                        obj.Unidade = dr["Unidade"].ToString();
                        obj.Qtd = dr["Qtd"].ToString();
                        obj.Asu = dr["Asu"].ToString();
                        obj.TipoMovimentacao = dr["TipoMovimentacao"].ToString();
                        obj.Status = dr["Status"].ToString();
                        obj.UsuarioSolicitacao = dr["UsuarioSolicitacao"].ToString();
                        obj.DataHoraSolicitacao = dr["DataHoraSolicitacao"].ToString();
                        obj.UsuarioAutorizacao = dr["UsuarioAutorizacao"].ToString();
                        obj.DataHoraAutorizacao = dr["DataHoraAutorizacao"].ToString();
                        obj.UsuarioMovimentacao = dr["UsuarioMovimentacao"].ToString();
                        obj.DataHoraMovimentacao = dr["DataHoraMovimentacao"].ToString();
                    }

                    return obj;
                }
                return null;
            }
            catch (Exception ex)
            {
                throw new ExceptionService(ex.Message);
            }
            finally
            {
                con.desconectar();
            }
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
