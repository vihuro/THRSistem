using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.estoque;

namespace SistemaTHR.DAO.Estoque
{
    internal class EstoqueAntigoDao
    {
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private ConnectionEstoque con = new ConnectionEstoque();
        private OleDbDataAdapter da;

        public void SelectCodigoAntigo(EstoqueAntigoDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from ProdutosEstoqueAntigo where codigo = @Codigo";
            cmd.Parameters.AddWithValue("",dto.Codigo);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dto.Exits = true;
                    dto.ListaCodigo = new List<string>();
                    while (dr.Read())
                    {
                        dto.ListaCodigo.Add(dr["CodigoRef"].ToString());
                    }
                }
            }
            catch (Exception ex)
            {

                dto.Msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }


    }
}
