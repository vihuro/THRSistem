using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using SistemaTHR.dto.estoque;
using System.Data;
using SistemaTHR.DAO.Estoque;

namespace SistemaTHR.DAO.Estoque
{
    internal class EstoqueDao
    {
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private ConnectionEstoque con = new ConnectionEstoque();
        private OleDbDataAdapter da;

        public void selectTable(EstoqueDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from ProdutosEstoque order by descricao asc";

            try
            {
                cmd.Connection = con.conectar();
                da = new OleDbDataAdapter(cmd);
                dto.Dt = new DataTable();
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

        public void Insert(EstoqueDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Insert Into ProdutosEstoque(CodigoRef, Codigo, Descricao, Unid, Grupo, Fornecedor, Usuario, DataHora," +
                                "EstoqueMinimo, EstoqueMaximo,EstoqueSeguranca ) Values " +
                                "(@CodigoRef, @Codigo, @Descricao, @Uni, @Grupo, @Fornecedor, @Usuario, @DataHora, " +
                                "@EstoqueMinimo, @EstoqueMaximo, @EstoqueSeguranca)";
            cmd.Parameters.AddWithValue("", dto.CodRef);
            cmd.Parameters.AddWithValue("", dto.Codigo);
            cmd.Parameters.AddWithValue("", dto.Descricao);
            cmd.Parameters.AddWithValue("", dto.Unidade);
            cmd.Parameters.AddWithValue("", dto.Grupo);
            cmd.Parameters.AddWithValue("", dto.Fornecedor);
            cmd.Parameters.AddWithValue("", dto.Usuario);
            cmd.Parameters.AddWithValue("", dto.DataHoraCadatro);
            cmd.Parameters.AddWithValue("", dto.EstoqueMinimo);
            cmd.Parameters.AddWithValue("", dto.EstoqueMaximo);
            cmd.Parameters.AddWithValue("", dto.EstoqueSeguranca);

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

        internal void Update(EstoqueDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Update ProdutosEstoque SET CodigoRef = @CodRef, Descricao = @Descricao, Unid = @Unidade, Grupo = @Grupo," +
                               "Fornecedor = @Fornecedor, Usuario = @Usuario, DataHora = @DataHora, EstoqueMinimo = @EstoqueMinimo, " +
                               "EstoqueMaximo = @EstoqueMaximo,  EstoqueSeguranca = @EstoqueSeguranca where Codigo = @Codigo";

            cmd.Parameters.AddWithValue("", dto.CodRef);
            cmd.Parameters.AddWithValue("", dto.Descricao);
            cmd.Parameters.AddWithValue("", dto.Unidade);
            cmd.Parameters.AddWithValue("", dto.Grupo);
            cmd.Parameters.AddWithValue("", dto.Fornecedor);
            cmd.Parameters.AddWithValue("", dto.Usuario);
            cmd.Parameters.AddWithValue("", dto.DataHoraCadatro);
            cmd.Parameters.AddWithValue("", dto.EstoqueMinimo);
            cmd.Parameters.AddWithValue("", dto.EstoqueMaximo);
            cmd.Parameters.AddWithValue("", dto.EstoqueSeguranca);
            cmd.Parameters.AddWithValue("", dto.Codigo);

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

        public void Delete(EstoqueDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Delete from ProdutosEstoque where Codigo = @Codigo And CodigoRef = @CodigoRef";
            cmd.Parameters.AddWithValue("", dto.Codigo);
            cmd.Parameters.AddWithValue("", dto.CodRef);
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
        public void FilterWithCodigo(EstoqueDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from ProdutosEstoque where codigo = @codigo";
            cmd.Parameters.AddWithValue("", dto.Codigo);
            try
            {
                cmd.Connection = con.conectar();

                da = new OleDbDataAdapter(cmd);
                dto.Dt = new DataTable();
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
        public void FilterWithGrupo(EstoqueDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from ProdutosEstoque where Grupo = @Grupo";
            cmd.Parameters.AddWithValue("", dto.Grupo);
            try
            {
                cmd.Connection = con.conectar();

                da = new OleDbDataAdapter(cmd);
                dto.Dt = new DataTable();
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
        public void FilterWithDescricao(EstoqueDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from ProdutosEstoque where Descricao = @Descricao";
            cmd.Parameters.AddWithValue("", dto.Descricao);
            try
            {
                cmd.Connection = con.conectar();

                da = new OleDbDataAdapter(cmd);
                dto.Dt = new DataTable();
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
        public void FilterTableDescricao(EstoqueDto dto)
        {

            cmd.CommandText = "Select * from ProdutosEstoque where Descricao like '%' + @Descricao + '%' ";
            cmd.Parameters.AddWithValue("", dto.Descricao);
            try
            {
                cmd.Connection = con.conectar();

                da = new OleDbDataAdapter(cmd);
                dto.Dt = new DataTable();
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

        public void FilterCode(EstoqueDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from ProdutosEstoque where CodigoRef = @Codigo";
            cmd.Parameters.AddWithValue("", dto.CodRef);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dto.Exitis = true;
                    dto.CodigoList = new List<string>();
                    dto.DescricaoList = new List<string>();
                    while (dr.Read())
                    {
                        dto.CodigoList.Add(dr["codigo"].ToString());
                        dto.DescricaoList.Add(dr["descricao"].ToString());


                        dto.Codigo = dr["codigo"].ToString();
                        dto.Descricao = dr["Descricao"].ToString();
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
