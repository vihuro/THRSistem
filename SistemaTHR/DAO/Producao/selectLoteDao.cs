using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Produção
{
    internal class selectLoteDao
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        ConnectionDBEstoque con = new ConnectionDBEstoque();

        public String lote;
        public String codigo;
        public String descricao;
        public String msg;

        private void selectLote()
        {
            cmd.CommandText = "Select * from ordemProducao where lote = @lote";
            cmd.Parameters.AddWithValue("@lote",lote);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                        codigo = dr["codProduto"].ToString();
                        descricao = dr["descricao"].ToString();

                    
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

        public void selectLot()
        {
            selectLote();
        }
    }
}
