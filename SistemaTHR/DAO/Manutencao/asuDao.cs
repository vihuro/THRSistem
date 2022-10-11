using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Manutencao
{
    internal class asuDao
    {
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        private Connection con = new Connection();
        private dto.manutencao.asuDto dto;

        private void insertAsu()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into tab_Asu(Asu, UsuarioGravacao, DataHoraGravacao) Values" +
                "(@asu, @usuarioGravacao, @dataHoraGravacao)";
            cmd.Parameters.AddWithValue("@asu",dto.Asu);
            cmd.Parameters.AddWithValue("@usuarioGravacao",dto.UsuarioGravao);
            cmd.Parameters.AddWithValue("@dataHoraGravacao",dto.DataHoraGravacao);
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
        public void inset(dto.manutencao.asuDto dto)
        {
            this.dto = dto;
            insertAsu();
        }
        private void deleteAsu()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Delete from tab_Asu where codigo = @codigo";
            cmd.Parameters.AddWithValue("",dto.Codigo);
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
        public void delete(dto.manutencao.asuDto dto)
        {
            this.dto = dto;
            deleteAsu();
        }
        private void selectTable()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_Asu order by codigo asc";
            try
            {
                cmd.Connection = con.conectar();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
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
        public void table(dto.manutencao.asuDto dto)
        {
            this.dto = dto;
            selectTable();
        }
        private void selectList()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_Asu order by asu asc";
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dto.AsuList = new List<string>();
                    while (dr.Read())
                    {
                        dto.AsuList.Add(dr.GetString(dr.GetOrdinal("asu")));
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
        public void list(dto.manutencao.asuDto dto)
        {
            this.dto = dto;
            selectList();
        }
    }
}
