using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO
{
    internal class trocaGasDao
    {
        public String trocaGas = null;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        public String menssagem = "";

        public void insertTrogaGas(String numeroEmp, String ultimaTroca,String trocaAtual, String horasTrabalhadas,DateTime dataHoraTroca, String usuarioTroca)
        {
            cmd.CommandText = "Insert into tab_trocaGas(numeroEmp, ultimaTroca, trocaAtual,horasTrabalhadas,dataHoraTroca,usuarioTroca) Values (@numeroEmp, @ultimaTroca, @trocaAtual, @horasTabalhadas, @dataHoraTroca, @usuarioTroca)";
            cmd.Parameters.AddWithValue("@numeroEmp", numeroEmp);
            cmd.Parameters.AddWithValue("@ultimaTroca", ultimaTroca);
            cmd.Parameters.AddWithValue("@trocaAtual", trocaAtual);
            cmd.Parameters.AddWithValue("@horasTrabalhadas", horasTrabalhadas);
            cmd.Parameters.AddWithValue("@dataHoraTroca", dataHoraTroca);
            cmd.Parameters.AddWithValue("@usuarioTroca", usuarioTroca);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteReader();

            }
            catch
            {

            }
        }



    }
}
