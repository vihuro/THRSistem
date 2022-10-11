using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Manutencao
{
    internal class geracaoOSTHRDAO
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        OleDbDataAdapter da;

        private dto.manutencao.geracaoOsTHRDto dto;


        private void selectTable()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_GeracaoOSTHR";

            try
            {
                cmd.Connection = con.conectar();
                da = new OleDbDataAdapter(cmd);
                dto.Dt = new DataTable();
                da.Fill(dto.Dt);
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

        public void table(dto.manutencao.geracaoOsTHRDto dto)
        {
            this.dto = dto;
            selectTable();
        }

        private void insertGeracao()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into tab_GeracaoOSTHR (usuarioCriacao, dataHoraCriacao, Status) Values " +
                                                            "(@usuario, @dataHora, @Status)";
            cmd.Parameters.AddWithValue("@usuario",dto.Usuario);
            cmd.Parameters.AddWithValue("@dataHora", dto.DataHora);
            cmd.Parameters.AddWithValue("@status", dto.Status);
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

        public void insert(dto.manutencao.geracaoOsTHRDto dto)
        {
            this.dto = dto;
            insertGeracao();
        }

        private void updateGeracao()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Update tab_geracaoOSTHR set Status = @status where geracao = @geracao";
            cmd.Parameters.AddWithValue("@status",dto.Status);
            cmd.Parameters.AddWithValue("@geracao",dto.Geracao);

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

        public void update(dto.manutencao.geracaoOsTHRDto dto)
        {
            this.dto = dto;
            updateGeracao();
        }

        private void selectActive()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_geracaoOSTHR where status = 'Ativo'";

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dto.Geracao = dr["geracao"].ToString();
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

        public void active(dto.manutencao.geracaoOsTHRDto dto)
        {
            this.dto = dto;
            selectActive();
        }
        
    }
}
