using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Manutencao
{
    internal class prioridadeManDAO
    {

        private OleDbCommand cmd = new OleDbCommand();
        private Connection con = new Connection();
        private OleDbDataReader dr;
        private OleDbDataAdapter da;

        private dto.manutencao.prioidadeManDto dto;

        private void selectPrioridadeList()
        {

            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_PrioridadeManutencao order by prioridade asc";
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dto.List = new List<string>();
                    while (dr.Read())
                    {
                        dto.List.Add(dr.GetString(dr.GetOrdinal("Prioridade")));
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

        public void List(dto.manutencao.prioidadeManDto dto)
        {
            this.dto = dto;
            selectPrioridadeList();
        }

        private void selectTablePrioridade()
        {
            cmd.CommandText = "Select * from tab_PrioridadeManutencao order by codigo asc";
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

        public void Table(dto.manutencao.prioidadeManDto dto)
        {
            this.dto = dto;
            selectTablePrioridade();
        }

        private void insertPrioridade()
        {
            cmd.CommandText = "Insert into tab_PrioridadeManutencao (Prioridade, UsuarioGravacao, dataHoraGravacao) Values" +
                " (@prioridade, @usuarioGravacao, @dataHoraGravacao)";
            cmd.Parameters.AddWithValue("@prioridade", dto.Prioridade);
            cmd.Parameters.AddWithValue("@usuarioGravacao", dto.UsuarioGravacao);
            cmd.Parameters.AddWithValue("@dataHoraGravacao", dto.DataHoraGravacao);

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

        public void insert(dto.manutencao.prioidadeManDto dto)
        {
            this.dto = dto;
            insertPrioridade();
        }

        private void deletePrioridade()
        {
            cmd.CommandText = "Delete from tab_prioridadeManutencao where codigo = @codigo";
            cmd.Parameters.AddWithValue("@codigo",dto.Codigo);

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

        public void delete(dto.manutencao.prioidadeManDto dto)
        {
            this.dto = dto;
            deletePrioridade();
        }

    }
}
