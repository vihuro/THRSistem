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
        private ExceptionService exception;
        
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
                                                                                "Observacao)" +
                                                                                "VALUES " +
                                                                                "(@DescricaoRequisicao," +
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
            catch (ExceptionService ex)
            {

                throw new ExceptionService("Erro " + ex.Message);
            }
            finally
            {
                con.desconectar();
            }
        }

        public void Update(AcompanhamentoRequisicaoCompraDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "UPDATE tab_AcompanhamentoRequisicaoCompra SET dataHoraAlteracao = @dataHoraAlteracao," +
                                                                             "usuarioAlteracao = @UsuarioAlteracao," +
                                                                             "observacao = @observacao WHERE " +
                                                                             "id = @id";
            cmd.Parameters.AddWithValue("", dto.DataHoraAlteracao);
            cmd.Parameters.AddWithValue("", dto.UsuarioAlteracao);
            cmd.Parameters.AddWithValue("", dto.Observacao);
            cmd.Parameters.AddWithValue("", dto.Id);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (ExceptionService ex)
            {

                throw new ExceptionService("Erro " + ex.Message);
            }
            finally
            {
                con.desconectar();
            }
        }

        public void Delete(AcompanhamentoRequisicaoCompraDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "UPDATE tab_AcompanhamentoRequisicaoCompra SET usuarioApontamento = @usuarioApontamento," +
                                                                             "dataHoraApontamento = @dataHoraApontamento," +
                                                                             "dataHoraAlteracao = @dataHoraAlteracao," +
                                                                             "usuarioAlteracao = @UsuarioAlteracao," +
                                                                             "observacao = @observacao WHERE " +
                                                                             "id = @id";
            cmd.Parameters.AddWithValue("", dto.UsuarioApontamento);
            cmd.Parameters.AddWithValue("", dto.DataHoraApontamento);
            cmd.Parameters.AddWithValue("", dto.UsuarioAlteracao);
            cmd.Parameters.AddWithValue("", dto.DataHoraAlteracao);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (ExceptionService ex)
            {

                throw new ExceptionService("Erro " + ex.Message);
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
            catch (ExceptionService ex)
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
