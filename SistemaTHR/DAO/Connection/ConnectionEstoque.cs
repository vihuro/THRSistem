using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO
{
    public class ConnectionEstoque
    {
        OleDbConnection conn = new OleDbConnection();
        String conexao;

        public ConnectionEstoque()
        {

            // conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=C:/Users/Vitor_2/Desktop/Minha pasta/7.1/bd_estoque.accdb;";

            conexao = "Provider=Microsoft.ACE.OLEDB.12.0;Data Source=//192.168.2.137/expedicao/apontamento/7.1/bkp 01-04-20/Base Teste Gustavo/20-01-2022 - @@/bd_estoque.accdb;";

            conn.ConnectionString = conexao;
        }

        public OleDbConnection conectar()
        {
            if(conn.State == System.Data.ConnectionState.Open)
            {
                return conn;
            }
            conn.Open();
            return conn;
        }

        public void desconectar()
        {
            conn.Close();
        }
    }
}
