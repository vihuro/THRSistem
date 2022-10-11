using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Manutencao
{
    internal class requisicaoCompraDao
    {
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private Connection con = new Connection();
        private OleDbDataAdapter da;
        private dto.Compras.requisicaoCompraDto dto;

        private void insertRequisicao()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into tab_RequisicaoCompra (Codigo, Descricao, Quantidade, Unidade, UsuarioSolicitante, DataHoraSolicitacao, Status) Values " +
                                                                "(@Codigo, @Descricao, @Quantidade, @Unidade, @UsuarioSolicitante, @DataHoraSolicitacao, @Status)";
            cmd.Parameters.AddWithValue("",dto.Codigo);
            cmd.Parameters.AddWithValue("",dto.Descricao);
            cmd.Parameters.AddWithValue("",dto.Quantidade);
            cmd.Parameters.AddWithValue("",dto.Unidade);
            cmd.Parameters.AddWithValue("",dto.UsuarioSolicitacao);
            cmd.Parameters.AddWithValue("",dto.DataHoraSolicitacao);
            cmd.Parameters.AddWithValue("",dto.Status);
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
        public void insert(dto.Compras.requisicaoCompraDto dto)
        {
            this.dto = dto;
            insertRequisicao();
        }
        private void verificarCodigo()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_RequisicaoCompra where codigo = @codigo and status = @status";
            cmd.Parameters.AddWithValue("",dto.Codigo);
            cmd.Parameters.AddWithValue("","Pendente");
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
            catch (Exception ex)
            {

                dto.Msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }
        public void verificar(dto.Compras.requisicaoCompraDto dto)
        {
            this.dto = dto;
            verificarCodigo();
        }
        private void updateRequisicaoCompra()
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
            catch (Exception ex)
            {

                dto.Msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }
        public void updateRequisicao(dto.Compras.requisicaoCompraDto dto)
        {
            this.dto = dto;
            updateRequisicaoCompra();
        }
        private void updateAuth()
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
            catch (Exception ex)
            {

                dto.Msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }
        public void auth(dto.Compras.requisicaoCompraDto dto)
        {
            this.dto = dto;
            updateAuth();
        }
        private void updateCompra() 
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Update tab_RequisicaoCompra set usuarioCompra = @UsuarioCompra, dataHoraCompra = @dataHoraCompra, " +
                "Status = @Status where NRequisicaoCompra = @NRequisicao";
            cmd.Parameters.AddWithValue("",dto.UsuarioCompra);
            cmd.Parameters.AddWithValue("", dto.DataHoraCompra);
            cmd.Parameters.AddWithValue("", dto.Status);
            cmd.Parameters.AddWithValue("", dto.NRequisicao);
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
        public void compra(dto.Compras.requisicaoCompraDto dto)
        {
            this.dto = dto;
            updateCompra();
        }
        private void selectTable()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_RequisicaoCompra order by NRequisicaoCompra";
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
        public void table(dto.Compras.requisicaoCompraDto dto)
        {
            this.dto = dto;
            selectTable();
        }
    }
}
