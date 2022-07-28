using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO
{
    internal class geracaoOSTHRDAO
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        OleDbDataAdapter da;

        public DataTable dt = new DataTable();
        public String geracao;
        public String usuario;
        public String dataHoraCriacao;
        public String msg;
        public String status;
        public List<string> situacao = new List<string>();

        private void selectGeracaoGRID()
        {
            cmd.CommandText = "Select * from tab_GeracaoOSTHR";

            try
            {
                cmd.Connection = con.conectar();
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
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

        public void selectGrid()
        {
            selectGeracaoGRID();
        }

        private void insertGeracao()
        {
            cmd.CommandText = "Insert into tab_GeracaoOSTHR (usuarioCriacao, dataHoraCriacao, Status) Values " +
                                                            "(@usuario, @dataHora, @Status)";
            cmd.Parameters.AddWithValue("@usuario",usuario);
            cmd.Parameters.AddWithValue("@dataHora",dataHoraCriacao);
            cmd.Parameters.AddWithValue("@status",status);
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
            insertGeracao();
        }

        private void updateGeracao()
        {
            cmd.CommandText = "Update tab_geracaoOSTHR set Status = @status where geracao = @geracao";
            cmd.Parameters.AddWithValue("@status",status);
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

        public void updateGer()
        {
            updateGeracao();
        }

        private void selectAtivo()
        {
            cmd.CommandText = "Select * from tab_geracaoOSTHR where status = 'Ativo'";

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        geracao = dr["geracao"].ToString();
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

        public void selectAtiv()
        {
            selectAtivo();
        }
        
    }
}
