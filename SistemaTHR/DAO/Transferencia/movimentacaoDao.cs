using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Transferencia
{
    internal class movimentacaoDao
    {
        private OleDbCommand cmd = new OleDbCommand();
        private Connection conn = new Connection();
        private dto.transferencia.movimentacaoDto dto;

        private void insertoMovimentaco()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into tab_Movimentacao (numeroPa,codigo,Descricao,PesoBruto," +
                "PesoLiquido,Bobinas,idTransferencia,UsuarioTransferencia) " +
                "Values (@numeroPa,@codigo,@descricao,@pesoBruto,@pesoLiquido,@bobinas,@idTransferencia,@usuarioTransferencia)";
            cmd.Parameters.AddWithValue("@numeroPa", dto.NumeroPa);
            cmd.Parameters.AddWithValue("@codigo", dto.Codigo);
            cmd.Parameters.AddWithValue("@descricao", dto.Descricao);
            cmd.Parameters.AddWithValue("@pesoBruto", dto.PesoBruto);
            cmd.Parameters.AddWithValue("@pesoLiquido", dto.PesoLiquido);
            cmd.Parameters.AddWithValue("@bobinas", dto.Bobinas);
            cmd.Parameters.AddWithValue("@idTransferencia", dto.IdTansferencia);
            cmd.Parameters.AddWithValue("@usuarioTransferencia", dto.Usuario);

            try
            {
                cmd.Connection = conn.conectar();
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally
            {
                conn.desconectar();
            }


        }

        public void insert(dto.transferencia.movimentacaoDto dto)
        {
            this.dto = dto;

            insertoMovimentaco();

        }

        private void selectMovimentacao()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_Movimentacao where idTransferencia = @id order by id asc";
            cmd.Parameters.AddWithValue("@id", dto.IdTansferencia);

            try
            {
                cmd.Connection = conn.conectar();

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                dto.Dt = new DataTable();

                da.Fill(dto.Dt);

            }
            catch(Exception ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally
            {
                conn.desconectar();
            }

        }

        public void selectTable(dto.transferencia.movimentacaoDto dto)
        {
            this.dto = dto;
            selectMovimentacao();
        }

        private void deletMovimentacao()
        {

            cmd.CommandText = "Delete from tab_movimentacao where id = @id";
            cmd.Parameters.AddWithValue("@id", dto.Id);

            try
            {
                cmd.Connection = conn.conectar();
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally
            {
                conn.desconectar();
            }

        }

        public void delete(dto.transferencia.movimentacaoDto dto)
        {
            this.dto = dto;
            deletMovimentacao();
        }

    }
}
