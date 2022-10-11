using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Transferencia
{
    internal class fechamentoDao
    {
        OleDbCommand cmd = new OleDbCommand();
        Connection conn = new Connection();
        dto.transferencia.fechamentoDto dto;

        private void insertIntoFechamento()
        {

            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into tab_fechamento(Codigo,Descricao,PesoBruto,PesoLiquido,QtBobinas,IdTransferencia)" +
                " Values (@Codigo,@Descricao,@PesoBruto,@PesoLiquido,@QtBobinas,@IdTransferencia)";
            cmd.Parameters.AddWithValue("@Codigo", dto.Codigo);
            cmd.Parameters.AddWithValue("@Descricao", dto.Descricao);
            cmd.Parameters.AddWithValue("@PesoBruto", dto.PesoBruto);
            cmd.Parameters.AddWithValue("@PesoLiquido", dto.PesoLiquido);
            cmd.Parameters.AddWithValue("@QtBobinas", dto.Bobinas);
            cmd.Parameters.AddWithValue("@IdTransferencia", dto.IdTransferencia);

            try
            {
                cmd.Connection = conn.conectar();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally
            {
                conn.desconectar();
            }

        }
        public void Insert(dto.transferencia.fechamentoDto dto)
        {
            this.dto = dto;
            insertIntoFechamento();

        }
        private void selectTable()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_fechamento where IdTransferencia = @id";
            cmd.Parameters.AddWithValue("@id", dto.IdTransferencia);
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
        public void table(dto.transferencia.fechamentoDto dto)
        {
            this.dto = dto;
            selectTable();

        }
        private void deleteFechamento()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Delete from tab_fechamento where id = @id";
            cmd.Parameters.AddWithValue("@id", dto.Id);
            try
            {
                cmd.Connection = conn.conectar();
                cmd.ExecuteReader();


            }
            catch (Exception ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally
            {
                conn.desconectar();
            }
        }
        public void delete(dto.transferencia.fechamentoDto dto)
        {
            this.dto = dto;
            deleteFechamento();
        }
        private void loadFechamentoImp()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_Fechamento where idTransferencia = @id";
            cmd.Parameters.AddWithValue("@id", dto.Id);

            try
            {
                cmd.Connection = conn.conectar();

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                dto.Dt = new DataTable();

                da.Fill(dto.Dt);


            }
            catch (Exception ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally
            {
                conn.desconectar();
            }

        }
        public void impressao(dto.transferencia.fechamentoDto dto)
        {
            this.dto = dto;
            loadFechamentoImp();
        }
        private void updateFechamento()
        {

            cmd = new OleDbCommand();
            cmd.CommandText = "Update tab_Fechamento SET PesoBruto = @pesoBruto, PesoLiquido = @pesoliquido, QtBobinas = @qtBobinas WHERE ID = @id";

            cmd.Parameters.AddWithValue("@pesoBruto", dto.PesoBruto);
            cmd.Parameters.AddWithValue("@pesoliquido", dto.PesoLiquido);
            cmd.Parameters.AddWithValue("@qtBobinas", dto.Bobinas);
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
        public void update(dto.transferencia.fechamentoDto dto)
        {
            this.dto = dto;
            updateFechamento();
        }
    }
}
