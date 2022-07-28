using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO
{
    internal class aseDao
    {

        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        public DataTable dt = new DataTable();
        OleDbDataAdapter da;

        public String numero;
        public String execucao;
        public String usuarioCadastro;
        public String dataHoraCadastro;
        public String msg;
        public bool tem = false;
        
        public List<String>ase = new List<String>(); 


        private void selectExecucao()
        {
            cmd.CommandText = "Select * from tab_ASE order by execucao asc";

            try
            {
                cmd.Connection = con.conectar();
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                msg = "Erro " +ex;
            }
            finally
            {
                con.desconectar();
            }
        }
        public void selectEx()
        {
            selectExecucao();
        }

        private void insertExecuxao()
        {
            cmd.CommandText = "Insert into tab_ASE (Execucao, UsuarioCadastro, dataHoraCadastro) values (@execucao, @usuarioCadastro, @dataHoraCadastro)";
            cmd.Parameters.AddWithValue("@execucao",execucao);
            cmd.Parameters.AddWithValue("@usuarioCadastro",usuarioCadastro);
            cmd.Parameters.AddWithValue("@dataHoraCadastro",dataHoraCadastro);
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

        public void insertEx()
        {
            insertExecuxao();
        }

        private void deleteExecuxao()
        {
            cmd.CommandText = "Delete from tab_ASE where NumeroASE = @numero";
            cmd.Parameters.AddWithValue("@numero",numero);

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

        public void deleteEx()
        {
            deleteExecuxao();
        }



        private void selectASE()
        {
            cmd.CommandText = "Select * from tab_ASE order by execucao asc ";

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        ase.Add(dr.GetString(dr.GetOrdinal("execucao")));
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

        public void ASE()
        {
            selectASE();
        }

        private void verificarEx()
        {
            cmd.CommandText = "Select * from tab_ASE where execucao = @execusao";
            cmd.Parameters.AddWithValue("@execuxao",execucao);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
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

        public void verificar()
        {
            verificarEx();
        }

    }
}
