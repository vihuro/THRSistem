using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.manutencao;

namespace SistemaTHR.DAO.Manutencao
{
    internal class OsTHRDAO
    {
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        private Connection con = new Connection();

        private dto.manutencao.osThrDto dto;

        private void insertOS()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into tab_OSTHR (DescricaoServico, TipoServico,DataHoraGeracao,UsuarioSolicitacao,Categoria,ASE,DataIdeal,StatusOP) " +
                            "Values (@DescricaoServico, @TipoServico, @DataHoraGeracao, @UsuarioSolicitacao,@categoria ,@ASE,@DataIdeal, @StatusOP)";
            cmd.Parameters.AddWithValue("@DescricaoServico", dto.Descricao);
            cmd.Parameters.AddWithValue("@TipoServico", dto.TipoServico);
            cmd.Parameters.AddWithValue("@DataHoraGeracao", dto.DataHora);
            cmd.Parameters.AddWithValue("@UsuarioSolicitacao", dto.Usuario);
            cmd.Parameters.AddWithValue("@categoria", dto.Categoria);
            cmd.Parameters.AddWithValue("@ASE", dto.Ase);
            cmd.Parameters.AddWithValue("@DataIdeal", dto.DataIdeal);
            cmd.Parameters.AddWithValue("@StatusOP", dto.StatusOs);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                dto.Msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }
        public void insert(dto.manutencao.osThrDto dto)
        {
            this.dto = dto;
            insertOS();
        }
        private void selectNOs()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_OsThr order by NOP asc";
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dto.NOs = dr["NOP"].ToString();
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
        public void selectOS(dto.manutencao.osThrDto dto)
        {
            this.dto = dto;
            selectNOs();
        }
        private void selectTable()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_osThr order by NOP asc";
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
        public void table(dto.manutencao.osThrDto dto)
        {
            this.dto = dto;
            selectTable();
        }
        private void selectPainel()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_OSTHR where StatusOP <> 'OS/Finalizada' order by Prioridade asc";
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
        public void painel(dto.manutencao.osThrDto dto)
        {
            this.dto = dto;
            selectPainel();
        }
        private void UpdatePriori()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Update tab_OSTHR set Prioridade = @Prioridade," +
                " UsuarioPrioridade = @UsuarioPrioridade, " +
                "DataHoraPrioridade = @DataHoraPrioridade " +
                "where NOP = @NumeroOSTHR";
            cmd.Parameters.AddWithValue("@Prioridade", dto.Prioridade);
            cmd.Parameters.AddWithValue("@UsuarioPrioridade", dto.UsuarioPrioridade);
            cmd.Parameters.AddWithValue("@DataHoraPrioridade", dto.DataHoraPrioridade);
            cmd.Parameters.AddWithValue("@NumeroOSTHR", dto.NOs);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                dto.Msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }
        public void UpdatePrioridade(dto.manutencao.osThrDto dto)
        {
            this.dto = dto;
            UpdatePriori();
        }
        private void update()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Update tab_OSTHR set StatusOP = @StatusOS where NOP = @numeroOS";
            cmd.Parameters.AddWithValue("@StatusOS", dto.StatusOs);
            cmd.Parameters.AddWithValue("@NumeroOS", dto.NOs);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {
                dto.Msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }
        public void updateStatus(osThrDto dto)
        {
            this.dto = dto;
            update();
        }


        public void fiterStatusOS(osThrDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_OSTHR where statusOP in(@EmAberto, @ManIN, @OSINC, @AguardandoPeca," +
                                                                        " @ManFIN, @ManNC, @OSFin)";
            cmd.Parameters.AddWithValue("@EmAberto", dto.EmAberto);
            cmd.Parameters.AddWithValue("@ManIN", dto.ManutenacaoIniciada);
            cmd.Parameters.AddWithValue("@OSINC", dto.OrdemINC);
            cmd.Parameters.AddWithValue("@AguardandoPeca", dto.AguardandoPeca);
            cmd.Parameters.AddWithValue("@ManFIN", dto.ManutencaoFinalizada);
            cmd.Parameters.AddWithValue("@ManNC", dto.ManutencaoNC);
            cmd.Parameters.AddWithValue("@OSFin", dto.ManutencaoFinalizada);

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

        private void loadInfoOS()
        {
            cmd.CommandText = "Select * from tab_OSTHR where NOP = @numeroOS";
            cmd.Parameters.AddWithValue("@numeroOS", dto.NOs);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {

                    dto.Prioridade = dr["Prioridade"].ToString();
                    dto.StatusOs = dr["StatusOP"].ToString();

                }
            }
            catch (Exception ex)
            {
                dto.Msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }
        public void loadINFO(dto.manutencao.osThrDto dto)
        {
            this.dto = dto;
            loadInfoOS();
        }
        private void selectImpOS()
        {
            cmd.CommandText = "Select * from tab_OSTHR where NOP = @numeroOS";
            cmd.Parameters.AddWithValue("@numeroOS", dto.NOs);

            try
            {
                cmd.Connection = con.conectar();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);
                dto.Dt = new DataTable();
                da.Fill(dto.Dt);



            }
            catch (Exception ex)
            {
                dto.Msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }
        public void selectImpOrdemServico()
        {
            selectImpOS();
        }
    }
}
