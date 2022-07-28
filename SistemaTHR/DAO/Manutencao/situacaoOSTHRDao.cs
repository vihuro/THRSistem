using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO
{
    internal class situacaoOSTHRDao
    {
        public String situacao;
        public String codigo;
        public String msg;

        OleDbCommand cmd = new OleDbCommand();
        Connection con = new Connection();
        OleDbDataAdapter da;
        public DataTable dt = new DataTable();

        private void selectSituacao()
        {
            cmd.CommandText = "Select * from tab_SituacaoOSTHR";
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

        public void selectSit()
        {
            selectSituacao();
        }

        private void insertSituacao()
        {
            cmd.CommandText = "Insert into tab_SituacaoOSTHR (Situacao) Values (@situacao)";
            cmd.Parameters.AddWithValue("@situacao",situacao);

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

        public void insert()
        {
            insertSituacao();
        }

        private void deletSituacao()
        {
            cmd.CommandText = "Delete from tab_SituacaoOSTHR where Codigo = @codigo";
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
            deletSituacao();
        }

    }
}
