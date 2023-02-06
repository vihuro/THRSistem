using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.estoque;

namespace SistemaTHR.DAO.Estoque
{
    internal class MpDao
    {
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private ConnectionEstoque con = new ConnectionEstoque();

        public void ProcurandoMp(MpDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from MP where Código = @codigo";
            cmd.Parameters.AddWithValue("", dto.NumeroMP);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dto.Exists = true;
                    while (dr.Read())
                    {
                        dto.CodigoMaterial = dr["CodigoMaterial"].ToString();

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
