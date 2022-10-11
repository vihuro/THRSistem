using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.estoque;

namespace SistemaTHR.DAO.Estoque
{
    internal class MovimentacaoDao
    {
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private ConnectionEstoque con = new ConnectionEstoque();
        private OleDbDataAdapter da;

        public void Count(MovimentacaoDto dto)
        {
            cmd = new OleDbCommand();

            cmd.CommandText = "Select Sum (Quantidade) as soma from Movimento where codProd = @codigo";
            cmd.Parameters.AddWithValue("", dto.Codigo);
            try
            {

                 cmd.Connection = con.conectar();

                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dto.Quantidade = dr["soma"].ToString();
                    }
                }
            }
            catch (Exception ex )
            {
                dto.Msg = "Erro " + ex;
                Console.WriteLine(ex);


            }
            finally
            {
                con.desconectar();
            }
        }
        public void SelectTable(MovimentacaoDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select *  from Movimento order by codigo asc";
            try
            {
                cmd.Connection = con.conectar();
                da = new OleDbDataAdapter(cmd);
                dto.Dt = new System.Data.DataTable();
                da.Fill(dto.Dt);

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


        internal void Insert(MovimentacaoDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Insert Into Movimento (CodProd, Descricao, Movimento, Data, Quantidade, Operacao, Usuario) Values " +
                "(@CodProd, @Descricao, @Movimento, @Data, @Quantidade, @Operacao, @Usuario)";
            cmd.Parameters.AddWithValue("", dto.Codigo);
            cmd.Parameters.AddWithValue("", dto.Descricao);
            cmd.Parameters.AddWithValue("", dto.Movimento);
            cmd.Parameters.AddWithValue("", dto.DataMovimentacao);
            cmd.Parameters.AddWithValue("", dto.Quantidade);
            cmd.Parameters.AddWithValue("", dto.Operacao);
            cmd.Parameters.AddWithValue("", dto.Usuario);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
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
