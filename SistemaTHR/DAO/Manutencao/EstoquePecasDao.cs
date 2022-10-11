using SistemaTHR.dto.manutencao;
using System;
using System.Data.OleDb;


namespace SistemaTHR.DAO.Manutencao
{
    internal class EstoquePecasDao
    {
        private OleDbCommand cmd = new OleDbCommand();

        private Connection con = new Connection();
        private OleDbDataReader dr;
        private OleDbDataAdapter da;
        private EstoquePecasDto dto;

        private void insertEstoque()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into tab_EstoquePecas (Codigo, Descricao, Unidade, QtEstoque, EstoqueMax, " +
                "EstoqueMin,Fornecedor1 , CodigoFornecedor1, " +
                "Fornecedor2, CodigoFornecedor2, Fornecedor3, CodigoFornecedor3 , UsuarioGravacao, DataHoraGravacao) " +
                "Values" +
                "(@codigo, @descricao,@unidade,@qtEstoque,@estoqueMax,@EstoqueMin,@Fornecedor1 ,@CodigoFornecedor1,@Fornecedor2," +
                " @CodigoFornecedor2,@Fornecedor3, @CodigoFornecedor3 " +
                ",@usuarioGravacao,@dataHoraGravacao)";
            cmd.Parameters.AddWithValue("",dto.Codigo);
            cmd.Parameters.AddWithValue("", dto.Descricao);
            cmd.Parameters.AddWithValue("", dto.Unidade);
            cmd.Parameters.AddWithValue("", dto.QtEstoque);
            cmd.Parameters.AddWithValue("", dto.EstoqueMax);
            cmd.Parameters.AddWithValue("", dto.EstoqueMin);
            cmd.Parameters.AddWithValue("", dto.Fornecedor1);
            cmd.Parameters.AddWithValue("", dto.CodFornecedor1);
            cmd.Parameters.AddWithValue("", dto.Fornecedor2);
            cmd.Parameters.AddWithValue("", dto.CodFornecedor2);
            cmd.Parameters.AddWithValue("", dto.Fornecedor3);
            cmd.Parameters.AddWithValue("", dto.CodFornecedor3);
            cmd.Parameters.AddWithValue("", dto.UsuarioGravacao);
            cmd.Parameters.AddWithValue("", dto.DataHoraGravacao);
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
        public void qtEstoque() 
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_EstoquePecas where Codigo = @codigo";
            cmd.Parameters.AddWithValue("", dto.Codigo);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    dto.Exists = true;
                    while (dr.Read())
                    {
                        dto.Descricao = dr["descricao"].ToString();
                        dto.QtEstoque = dr["QtEstoque"].ToString();
                    }
                }
                else
                {
                    dto.Exists = false;
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



        public void estoque(EstoquePecasDto dto)
        {
            this.dto = dto;
            qtEstoque();
        }
        public void insert(EstoquePecasDto dto)
        {
            this.dto = dto;
            insertEstoque();
        }
        public void updateQtEstoque(EstoquePecasDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Update tab_EstoquePecas set " +
                              "QtEstoque = @QtEstoque where codigo = @codigo";
            cmd.Parameters.AddWithValue("", dto.QtEstoque);
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

        private void updateInfoEstoque()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Update tab_EstoquePecas Set Unidade = @unidade, " +
                                "EstoqueMax = @EstoqueMax, " +
                                "EstoqueMin = @EstoqueMin, " +
                                "UsuarioGravacao = @UsuarioGravacao, " +
                                "DataHoraGravacao = @DataHoraGravacao " +
                                "where codigo = @codigo";
            cmd.Parameters.AddWithValue("",dto.Unidade);
            cmd.Parameters.AddWithValue("", dto.EstoqueMax);
            cmd.Parameters.AddWithValue("", dto.EstoqueMin);
            cmd.Parameters.AddWithValue("", dto.UsuarioGravacao);
            cmd.Parameters.AddWithValue("", dto.DataHoraGravacao);
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
        private void selectTable()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_EstoquePecas order by NPeca asc";
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
        public void table(EstoquePecasDto dto)
        {
            this.dto = dto;
            selectTable();

        }
        public void updateInfo(EstoquePecasDto dto)
        {
            this.dto = dto;
            updateInfoEstoque();
        }
        private void deleteCadastro()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Delete from tab_EstoquePecas where codigo = @codigo";
            cmd.Parameters.AddWithValue("",dto.Codigo);
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
        public void delete(EstoquePecasDto dto)
        {
            this.dto = dto;
            deleteCadastro();
        }

    }
}
