using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Estoque
{
    internal class PaDao
    {
        OleDbCommand cmd;
        OleDbDataReader dr;
        //Connection con = new Connection();
        ConnectionDBEstoque con = new ConnectionDBEstoque();
        dto.estoque.paDto dto;

        private void selectPaEstoque()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from apontamento where sequencia = @sequencia";
            cmd.Parameters.AddWithValue("@sequencia", dto.NumeroPa);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dto.Codigo = dr["CodProduto"].ToString();
                    dto.Descricao = dr["descricao"].ToString();
                    dto.PesoBruto = Convert.ToDouble(dr["PesoBruto"]);
                    dto.PesoLiquido = Convert.ToDouble(dr["pesoLiquido"]);
                    dto.Bobinas = Convert.ToDouble(dr["QtdBobinas"]);
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

        public void PaEstoque(dto.estoque.paDto dto)
        {
            this.dto = dto;
            selectPaEstoque();
        }

        private void selectPaExpedicao()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from ApontamentoSaida where sequencia = @sequencia";
            cmd.Parameters.AddWithValue("@sequencia", dto.NumeroPa);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dto.Codigo = dr["CodProduto"].ToString();
                    dto.Descricao = dr["descricao"].ToString();
                    dto.PesoBruto = Convert.ToDouble(dr["PesoBruto"]);
                    dto.PesoLiquido = Convert.ToDouble(dr["pesoLiquido"]);
                    dto.Bobinas = Convert.ToDouble(dr["QtdBobinas"]);
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

        public void PaExpedicao(dto.estoque.paDto dto)
        {
            this.dto = dto;
            selectPaExpedicao();
        }

    }
}
