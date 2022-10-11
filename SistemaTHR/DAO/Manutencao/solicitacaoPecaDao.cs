using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Manutencao
{
    internal class solicitacaoPecaDao
    {
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        private Connection con = new Connection();

        private dto.manutencao.solicitacaoPecaDto dto;

        private void insertRequisicao()
        {

            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into tab_SolicitacaoPecaOSTHR (NOS, codigoPeca, DescricaoPeca, Qtd, Unidade, ASU ,NomeSolicitante, StatusSolicitacao,DataHoraSolicitacao) " +
                                "values " +
                                "(@Nos, @codigoPeca, @DescricaoPeca, @qtd, @Unidade, @ASU , @NomeSolicitante, @StatusSolicitacao,@dataHoraSolicitacao)";
            cmd.Parameters.AddWithValue("",dto.NOs);
            cmd.Parameters.AddWithValue("",dto.CodigoPeca);
            cmd.Parameters.AddWithValue("",dto.DescricaoPeca);
            cmd.Parameters.AddWithValue("",dto.Qtd);
            cmd.Parameters.AddWithValue("",dto.Unidade);
            cmd.Parameters.AddWithValue("", dto.ASU);
            cmd.Parameters.AddWithValue("",dto.UsuarioSolicitacao);
            cmd.Parameters.AddWithValue("",dto.StatusSolicitacao);
            cmd.Parameters.AddWithValue("", dto.DataHoraSolicitacao);


            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }

        }

        public void insert(dto.manutencao.solicitacaoPecaDto dto)
        {
            this.dto = dto;
            insertRequisicao();
        }

        private void deleteRequicao()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Delete from tab_SolicitacaoPecaOSTHR where NRequisicao = @NRequisicao";
            cmd.Parameters.AddWithValue("@NRequisicao",dto.NRequisicao);
            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void delete(dto.manutencao.solicitacaoPecaDto dto)
        {
            this.dto = dto;
            deleteRequicao();
        }

        private void authorizeRequisicao()
        {
            cmd.CommandText = "Update tab_SolicitacaoPecaOSTHR SET " +
                                "StatusSolicitacao = @StatusSolicitacao," +
                                "NomeAutorizador = @NomeAutorizador," +
                                "DataHoraAutorizacao = @DataHoraAutorizacao" +
                                " WHERE NRequisicao = @NRequisicao";

            cmd.Parameters.AddWithValue("@StatusSolicitacao", dto.StatusSolicitacao);
            cmd.Parameters.AddWithValue("@NomeAutorizador", dto.UsuarioAutorizacao);
            cmd.Parameters.AddWithValue("@DataHoraAutorizacao", dto.DataHoraAutorizacao);

            cmd.Parameters.AddWithValue("@NRequisicao", dto.NRequisicao);

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

        public void authorize(dto.manutencao.solicitacaoPecaDto dto)
        {
            this.dto = dto;
            authorizeRequisicao();
        }

        private void selectRequiscao()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_solicitacaoPecaOSThr where Nos = @Nos";
            cmd.Parameters.AddWithValue("@Nos", dto.NOs);
            try
            {
                cmd.Connection = con.conectar();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                dto.Dt = new DataTable();
                da.Fill(dto.Dt);
            }
            catch(Exception ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void selectTable(dto.manutencao.solicitacaoPecaDto dto)
        {
            this.dto = dto;
            selectRequiscao();
        }

        private void selectRequisicoes()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_SolicitacaoPecaOSTHR order by NRequisicao asc";
            try
            {
                cmd.Connection = con.conectar();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
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

        public void table(dto.manutencao.solicitacaoPecaDto dto)
        {
            this.dto = dto;
            selectRequisicoes();
        }

    }
}
