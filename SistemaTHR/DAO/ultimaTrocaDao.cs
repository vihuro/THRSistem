using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO
{
    internal class ultimaTrocaDao
    {
        public String UltimaTroca = null;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        public String menssagem = "";

        public String buscarUltimaTroca(String numeroEmp)
        {
            cmd.CommandText = "Select * from tab_trocaGas where NumeroEmp = @numeroEmp";
            cmd.Parameters.AddWithValue("@numeroEmp", numeroEmp);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    UltimaTroca = dr["trocaAtual"].ToString();
                }


            }
            catch
            {
                UltimaTroca = "Não Econtrado";
            }

            return UltimaTroca;
        }

    }


}
