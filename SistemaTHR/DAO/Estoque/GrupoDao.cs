using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.estoque;
using System.Data;

namespace SistemaTHR.DAO.Estoque
{
    internal class GrupoDao
    {
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private ConnectionEstoque con = new ConnectionEstoque();
        private OleDbDataAdapter da;

        public void Insert(GrupoDto dto) 
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into Grupo (Grupo, UsuarioGravacao, DataHoraGravacao) Values" +
                                "(@grupo, @UsuarioGravacao, @dataHoraGravacao)";
            cmd.Parameters.AddWithValue("", dto.Grupo);
            cmd.Parameters.AddWithValue("", dto.UsuarioGravacao);
            cmd.Parameters.AddWithValue("", dto.DataHoraGravacao);
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
        public void Table(GrupoDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from grupo order by grupo asc";
            try
            {
                cmd.Connection = con.conectar();
                da = new OleDbDataAdapter(cmd);
                dto.Dt = new DataTable();
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
        public void Delete(GrupoDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Delete from grupo where id = @id";
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
        public void List(GrupoDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from grupo order by grupo asc";
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dto.Lista = new List<string>();
                    while (dr.Read())
                    {
                        dto.Lista.Add(dr["grupo"].ToString());
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

        public void Exits(GrupoDto dto)
        {
            cmd.CommandText = "Select * from grupo where grupo = @grupo";
            cmd.Parameters.AddWithValue("", dto.Grupo);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dto.Exists = true;
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
        public void Filter(GrupoDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from grupo where grupo like '%'+ @dto.Grupo +'%' ";
            cmd.Parameters.AddWithValue("@dto.Grupo", dto.Grupo);
            try
            {
                cmd.Connection = con.conectar();
                dto.Dt = new DataTable();
                da = new OleDbDataAdapter(cmd);
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
    }
}
