using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO
{
    internal class loadTrocasDao
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        OleDbDataAdapter da = new OleDbDataAdapter();
        DataSet ds;

        public List<String> numeroEmp = new List<String>();
        public List<String> ultimaTrocaList = new List<String>();
        public List<String> trocaAtualList = new List<String>();
        public String numero;
        public String ultimaTroca;


        public void loadTrocas()
        {
            cmd.CommandText = "Select * from tab_trocaGas order by dataHoraTroca asc";
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    da.Fill(ds);

                    foreach(var list in dr["numeroEmp"].ToString())
                    {
                        // list = dr["numeroEmp"].ToString();
                        var numeroEmpilhadeira = new List<String> { dr["numeroEmp"].ToString(), dr["ultimaTroca"].ToString(), dr["trocaAtual"].ToString() };
                        // var ultimaTroca = new List<String> { dr["ultimaTroca"].ToString() };
                        //var trocaAtual = new List<String> { dr["trocaAtual"].ToString() };

                        //numero = numeroEmpilhadeira.ToString();
                        //numeroEmp.AddRange(numeroEmpilhadeira);
                        //ultimaTrocaList.AddRange(ultimaTroca);
                        //trocaAtualList.AddRange(trocaAtual);

                        numero = numeroEmpilhadeira.ToString();

                    }



                    /*numero = dr["numeroEmp"].ToString() ;
                    ultimaTroca = dr["ultimaTroca"].ToString();
                    numeroEmp.Add(numero);
                    ultimaTrocaList.Add(ultimaTroca);*/

                    // Console.Write(dr["numeroEmp"].ToString());


                }

            }
            catch
            {
                dr = null;
            }


        }
    }
}
