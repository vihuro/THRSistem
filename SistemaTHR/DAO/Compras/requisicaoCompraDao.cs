using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.Compras;
using SistemaTHR.Service.Exepction;

namespace SistemaTHR.DAO.Manutencao
{
    internal class requisicaoCompraDao
    {
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private Connection con;
        private OleDbDataAdapter da;
        private ExceptionService expection;
        private DataTable dt;

        public requisicaoCompraDao()
        {
            con = new Connection();
        }


        public string Insert(requisicaoCompraDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into tab_RequisicaoCompra (Codigo, Descricao, Quantidade, Unidade, " +
                                                                "Prioridade, DataEsperadaEntrega," +
                                                                "UsuarioSolicitante, DataHoraSolicitacao, Status)" +
                                                                " Values " +
                                                                "(@Codigo, @Descricao, @Quantidade, @Unidade," +
                                                                "@Prioridade, @DataEsperadaEntrega, " +
                                                                "@UsuarioSolicitante, @DataHoraSolicitacao, @Status)";
            cmd.Parameters.AddWithValue("",dto.Codigo);
            cmd.Parameters.AddWithValue("",dto.Descricao);
            cmd.Parameters.AddWithValue("",dto.Quantidade);
            cmd.Parameters.AddWithValue("",dto.Unidade);
            cmd.Parameters.AddWithValue("",dto.Prioridade);
            cmd.Parameters.AddWithValue("",dto.DataHoraEsperadaEntrega);
            cmd.Parameters.AddWithValue("",dto.UsuarioSolicitacao);
            cmd.Parameters.AddWithValue("",dto.DataHoraSolicitacao);
            cmd.Parameters.AddWithValue("",dto.Status);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

                cmd.CommandText = "SELECT @@IDENTITY";
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        Console.WriteLine("O numero da nova requisição é = " + dr["Expr1000"].ToString());
                        return dr["Expr1000"].ToString();

                    }
                }
                return "";


            }
            catch (ExceptionService ex)
            {

                throw new ExceptionService("Erro " + ex);
            }
            finally
            {
                con.desconectar();
            }
        }
        public void verificarCodigo(requisicaoCompraDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_RequisicaoCompra where codigo = @codigo and status = @status";
            cmd.Parameters.AddWithValue("",dto.Codigo);
            cmd.Parameters.AddWithValue("",dto.Status);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dto.NRequisicao = dr["NRequisicaoCompra"].ToString();
                        dto.Quantidade = dr["Quantidade"].ToString();
                    }

                }
            }
            catch (ExceptionService ex)
            {

                throw new ExceptionService("Erro " + ex);
            }
            finally
            {
                con.desconectar();
            }
        }
        public void updateRequisicaoCompra(requisicaoCompraDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Update tab_RequisicaoCompra set quantidade = @quantidade where NRequisicaoCompra = @NRequisicaoCompra";
            cmd.Parameters.AddWithValue("", dto.Quantidade);
            cmd.Parameters.AddWithValue("", dto.NRequisicao);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (ExceptionService ex)
            {

                throw new ExceptionService("Erro " + ex);
            }
            finally
            {
                con.desconectar();
            }
        }
        public void updateAuth(requisicaoCompraDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Update tab_RequisicaoCompra set UsuarioAutorizacao = @usuarioAutorizador, dataHoraAutorizacao = @dataHora, status = @Staus" +
                                                                " where NRequisicaoCompra = @NRequisicaoCompra";
            cmd.Parameters.AddWithValue("",dto.UsuarioAutorizador);
            cmd.Parameters.AddWithValue("",dto.DataHoraAutorizacao);
            cmd.Parameters.AddWithValue("", dto.Status);
            cmd.Parameters.AddWithValue("",dto.NRequisicao);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (ExceptionService ex)
            {

                throw new ExceptionService("Erro " + ex);
            }
            finally
            {
                con.desconectar();
            }
        }
        public DataTable Table()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_RequisicaoCompra order by NRequisicaoCompra";
            try
            {
                cmd.Connection = con.conectar();
                da = new OleDbDataAdapter(cmd);
                dt = new DataTable();
                da.Fill(dt);

                return dt;
            }
            catch (ExceptionService ex)
            {

                throw new ExceptionService("Erro " + ex);
            }
            finally
            {
                con.desconectar();
            }
        }

    }
}
