using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO
{
    internal class version
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        DAO.Connection con = new Connection();
        public String versao;
        public String msg;
        public bool tem = false;

        private void verificarVersao()
        {
            cmd.CommandText = "Select * from tab_Version where NVersion = @Versao";
            cmd.Parameters.AddWithValue("@Versao",versao);

            try
            {

                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
                }

            }
            catch(OleDbException ex)
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
            verificarVersao();
        }
        
    }
}
