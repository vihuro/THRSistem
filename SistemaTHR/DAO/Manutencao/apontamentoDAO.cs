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
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        public DataTable dt = new DataTable();
        OleDbDataAdapter da;

        public String apontamento;
        public String geracao;
        public String msg;
        public List<String> apont = new List<string>();

        private void selectApontamento()
        {
            cmd.CommandText = "Select * from tab_apontamentoOSTHR where geracao = @geracao";
            cmd.Parameters.AddWithValue("geracao",geracao);

            try
            {
                cmd.Connection = con.conectar();
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void selectApont()
        {
            selectApontamento();
        }

        private void insertApontamento()
        {
            cmd.CommandText = "Insert into tab_apontamentoOSTHR(apontamento, geracao) Values (@apontamento, @geracao)";
            cmd.Parameters.AddWithValue("@apontamento",apontamento);
            cmd.Parameters.AddWithValue("@geracao",geracao);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void insertApont()
        {
            insertApontamento();
        }

        private void selectApontSitu()
        {
            cmd.CommandText = "Select * from tab_apontamentoOSTHR where geracao = @geracao";
            cmd.Parameters.AddWithValue("@geracao",geracao);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        apont.Add(dr.GetString(dr.GetOrdinal("apontamento")));
                    }
                }
            }
            catch (Exception ex)
            {

                msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void selectSituacao()
        {
            selectApontSitu();
        }
    }
}
