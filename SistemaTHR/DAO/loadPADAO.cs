using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO
{
    internal class loadPADAO
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        ConnectionDBEstoque con = new ConnectionDBEstoque();

        public String descricao;
        public String codigo;
        public double pesoBruto;
        public double pesoLiquido;
        public double qtBobinas;

        public void selectPA(String numeroPA)
        {
            cmd.CommandText = "Select * from Apontamento where Sequencia = @sequencia";
            cmd.Parameters.AddWithValue("@sequencia", numeroPA);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    codigo = dr["CodProduto"].ToString();
                    descricao = dr["descricao"].ToString();
                    pesoBruto = Convert.ToDouble(dr["PesoBruto"]);
                    pesoLiquido = Convert.ToDouble(dr["pesoLiquido"]);
                    qtBobinas = Convert.ToDouble(dr["QtdBobinas"]);

                    con.desconectar();

                }

            }
            catch
            {

            }

        }

        String numeroPA;

        

        public void selectPAEXPEDICAO()
        {
            cmd.CommandText = "Select * from ApontamentoSaida where Sequencia = @sequencia";
            cmd.Parameters.AddWithValue("@sequencia", numeroPA);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    codigo = dr["CodProduto"].ToString();
                    descricao = dr["descricao"].ToString();
                    pesoBruto = Convert.ToDouble(dr["PesoBruto"]);
                    pesoLiquido = Convert.ToDouble(dr["pesoLiquido"]);
                    qtBobinas = Convert.ToDouble(dr["QtdBobinas"]);

                    con.desconectar();

                }

            }
            catch
            {

            }

        }

        public void selecExpedicao(String numeroPa)
        {
            this.numeroPA = numeroPa;

            selectPAEXPEDICAO();
        }
    }
}
