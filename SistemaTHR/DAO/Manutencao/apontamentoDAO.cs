using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Manutencao
{
    internal class apontamentoDAO
    {
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        private Connection con = new Connection();
        private OleDbDataAdapter da;
        private dto.manutencao.apontamentoOsTHRDto dto;

        private void selectTable()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_apontamentoOSTHR where geracao = @geracao";
            cmd.Parameters.AddWithValue("geracao",dto.Geracao);

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

        public void table(dto.manutencao.apontamentoOsTHRDto dto)
        {
            this.dto = dto;
            selectTable();
        }

        private void insertApontamento()
        {
            cmd.CommandText = "Insert into tab_apontamentoOSTHR(apontamento, geracao) Values (@apontamento, @geracao)";
            cmd.Parameters.AddWithValue("@apontamento",dto.Apontamento);
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

        public void insert(dto.manutencao.apontamentoOsTHRDto dto)
        {
            this.dto = dto;
            insertApontamento();
        }

        private void selectList()
        {
            cmd.CommandText = "Select * from tab_apontamentoOSTHR where geracao = @geracao";
            cmd.Parameters.AddWithValue("@geracao",dto.Geracao);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dto.Apont = new List<string>();
                    while (dr.Read())
                    {
                        dto.Apont.Add(dr.GetString(dr.GetOrdinal("apontamento")));
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

        public void list(dto.manutencao.apontamentoOsTHRDto dto)
        {
            this.dto = dto;
            selectList();
        }
    }
}
