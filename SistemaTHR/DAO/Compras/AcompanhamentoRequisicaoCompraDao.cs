using SistemaTHR.Service.Exepction;
using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.Compras;
using System.Data;

namespace SistemaTHR.DAO.Compras
{
    internal class AcompanhamentoRequisicaoCompraDao
    {
        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private Connection con;
        private OleDbDataAdapter da;
        
        public AcompanhamentoRequisicaoCompraDao()
        {
            con = new Connection();
        }

        public void Insert(AcompanhamentoRequisicaoCompraDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "INSERT INTO tab_AcompanhamentoRequisicaoCompra (NumeroRequisicao, " +
                                                                                "DescricaoRequisicao," +
                                                                                "dataHoraApontamento," +
                                                                                "usuarioApontamento," +
                                                                                "dataHoraAlteracao," +
                                                                                "usuarioAlteracao," +
                                                                                "observacao)" +
                                                                                "VALUES " +
                                                                                "(@NumeroRequisicao," +
                                                                                "@DescricaoRequisicao," +
                                                                                "@dataHoraApontamento," +
                                                                                "@usuarioApontamento," +
                                                                                "@dataHoraAlteracao," +
                                                                                "@usuarioAlteracao," +
                                                                                "@Observacao)";
            cmd.Parameters.AddWithValue("",dto.NumeroRequisicao);
            cmd.Parameters.AddWithValue("",dto.DescricaoRequisicao);
            cmd.Parameters.AddWithValue("",dto.DataHoraApontamento);
            cmd.Parameters.AddWithValue("",dto.UsuarioApontamento);
            cmd.Parameters.AddWithValue("",dto.DataHoraAlteracao);
            cmd.Parameters.AddWithValue("", dto.UsuarioAlteracao);
            cmd.Parameters.AddWithValue("", dto.Observacao);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new ExceptionService("Erro " + ex.Message);
            }
            finally
            {
                con.desconectar();
            }
        
        }

        public void InsertApontamento(AcompanhamentoRequisicaoCompraDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "UPDATE tab_AcompanhamentoRequisicaoCompra SET DataHoraApontamento = @DataHoraApontamento, " +
                                                                             "UsuarioApontamento = @UsuarioApontamento," +
                                                                             "dataHoraAlteracao = @dataHoraAlteracao," +
                                                                             "usuarioAlteracao = @usuarioAlteracao," +
                                                                             "observacao = @observacao WHERE " +
                                                                             "id = @id";
            cmd.Parameters.AddWithValue("", dto.DataHoraApontamento);
            cmd.Parameters.AddWithValue("", dto.UsuarioApontamento);
            cmd.Parameters.AddWithValue("", dto.DataHoraAlteracao);
            cmd.Parameters.AddWithValue("", dto.UsuarioAlteracao);
            cmd.Parameters.AddWithValue("", dto.Observacao);
            cmd.Parameters.AddWithValue("", dto.Id);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new ExceptionService(ex.Message);
            }
            finally
            {
                con.desconectar();
            }
        }

        public AcompanhamentoRequisicaoCompraDto Apontamento(string id)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "SELECT * FROM tab_AcompanhamentoRequisicaoCompra WHERE id = @id";
            cmd.Parameters.AddWithValue("", id);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    var obj = new AcompanhamentoRequisicaoCompraDto();
                    while (dr.Read()) 
                    {
                        obj.Id = dr["id"].ToString();
                        obj.NumeroRequisicao = dr["NumeroRequisicao"].ToString();
                        obj.DescricaoRequisicao = dr["DescricaoRequisicao"].ToString();
                        obj.DataHoraApontamento = dr["dataHoraApontamento"].ToString();
                        obj.UsuarioApontamento = dr["usuarioApontamento"].ToString();
                        obj.DataHoraAlteracao = dr["dataHoraAlteracao"].ToString();
                        obj.UsuarioAlteracao = dr["usuarioAlteracao"].ToString();
                        obj.Observacao = dr["observacao"].ToString();
                    }
                    return obj;
                }
                return null;

            }
            catch (Exception ex)
            {

                throw new ExceptionService(ex.Message);
            }
            finally
            {
                con.desconectar();
            }
        }




        public DataTable Table()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "SELECT * FROM tab_AcompanhamentoRequisicaoCompra ORDER BY ID ASC";
            try
            {
                cmd.Connection = con.conectar();

                da = new OleDbDataAdapter(cmd);
                var dt = new DataTable();

                da.Fill(dt);

                return dt;
            }
            catch (Exception ex)
            {

                throw new ExceptionService("Erro " + ex.Message);
            }
            finally
            {
                con.desconectar();
            }
        }
    }
}
