using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO
{
    internal class prioridadeManDAO
    {

        public String codigo;
        public String prioridade;
        public String usuarioGravacao;
        public String dataHoraGravacao;
        OleDbDataReader dr;
        public List<String> prioridadeList = new List<String>();
        public String msg;
        public DataTable dt = new DataTable();

        OleDbCommand cmd = new OleDbCommand();
        Connection con = new Connection();
        OleDbDataAdapter da;

        private void selectPrioridadeList()
        {

            cmd.CommandText = "Select * from tab_PrioridadeManutencao order by codigo asc";
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        prioridadeList.Add(dr.GetString(dr.GetOrdinal("Prioridade")));
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

        public void selectList()
        {
            selectPrioridadeList();
        }

        private void selectTablePrioridade()
        {
            cmd.CommandText = "Select * from tab_PrioridadeManutencao order by codigo asc";
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

        public void selectTable()
        {
            selectTablePrioridade();
        }

        private void insertPrioridade()
        {
            cmd.CommandText = "Insert into tab_PrioridadeManutencao (Priordade, UsuarioGravacao, dataHoraGravacao) Values" +
                " (@prioridade, @usuarioGravacao, @dataHoraGravacao)";
            cmd.Parameters.AddWithValue("@prioridade",prioridade);
            cmd.Parameters.AddWithValue("@usuarioGravacao",usuarioGravacao);
            cmd.Parameters.AddWithValue("@dataHoraGravacao",dataHoraGravacao);

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

        public void insert()
        {
            insertPrioridade();
        }

        private void deletePrioridade()
        {
            cmd.CommandText = "Delete from tab_prioridadeManutencao where codigo = @codigo";
            cmd.Parameters.AddWithValue("@codigo",codigo);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void delete()
        {
            deletePrioridade();
        }

    }
}
