using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO
{
    internal class OsTHRDAO
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        public DataTable dt = new DataTable();

        public String descricaoServico;
        public String tipoServico;
        public String dataHoraGeraca;
        public String usuarioSolicitacao;
        public String statusOP;
        public String ASE;
        public String DataIdeal;
        public String Prioridade;
        public String usuarioPrioridade;
        public String dataHoraPrioridade;
        public String numeroRequisicao;
        public String nomeAutorizador;
        public String dataHoraAutorizacao;
        public String msg;

        private void insertOS()
        {
            cmd.CommandText = "Insert into tab_OSTHR (DescricaoServico, TipoServico,DataHoraGeracao,UsuarioSolicitacao,ASE,DataIdeal,StatusOP) " +
                            "Values (@DescricaoServico, @TipoServico, @DataHoraGeracao, @UsuarioSolicitacao,@ASE,@DataIdeal, @StatusOP)";
            cmd.Parameters.AddWithValue("@DescricaoServico", descricaoServico);
            cmd.Parameters.AddWithValue("@TipoServico", tipoServico);
            cmd.Parameters.AddWithValue("@DataHoraGeracao", dataHoraGeraca);
            cmd.Parameters.AddWithValue("@UsuarioSolicitacao", usuarioSolicitacao);
            cmd.Parameters.AddWithValue("@ASE", ASE);
            cmd.Parameters.AddWithValue("@DataIdeal", DataIdeal);
            cmd.Parameters.AddWithValue("@StatusOP", statusOP);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();



            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void insertOrdemServico(String descricaoServico, String tipoServico, String dataHoraGeraca, String usuarioSolicitacao,String ASE,String DataIdeal, String statusOP)
        {
            this.descricaoServico = descricaoServico;
            this.tipoServico = tipoServico;
            this.dataHoraGeraca = dataHoraGeraca;
            this.usuarioSolicitacao = usuarioSolicitacao;
            this.ASE = ASE;
            this.DataIdeal = DataIdeal;
            this.statusOP = statusOP;
            insertOS();
        }

        public String numeroOP;
        private void selectOS()
        {
            cmd.CommandText = "Select * from tab_OSTHR order by NOP asc";

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    numeroOP = dr["NOP"].ToString();
                }
            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();

            }
 

        }

        public void selectOrdemServico()
        {
            selectOS();
            
        }

        public String numeroOSTHR;
        public String Andamento;
        public String dataHoraApontament;
        public String usuarioApontamento;
        public String dataHoraAlteracao;
        public String usuarioAlteracao;
        public String observacao = "";

        private void insertSTatusOP()
        {
            cmd.CommandText = "Insert into tab_StatusOSTHR (NumeroOSTHR, Andamento, DataHoraApontamento,UsuarioApontamento,DataHoraAlteracao,UsuarioAlteracao,Observacao) " +
                 "Values(@NumeroOSTHR, @Andamento, @DataHoraApontamento,@usuarioApontamento, @DataHoraAlteracao, @usuarioAlteracao,@observacao)";
            cmd.Parameters.AddWithValue("@NumeroOSTHR",numeroOSTHR);
            cmd.Parameters.AddWithValue("@Andamento", Andamento);
            cmd.Parameters.AddWithValue("@DataHoraApontamento", dataHoraApontament);
            cmd.Parameters.AddWithValue("@usuarioApontamento", usuarioApontamento);
            cmd.Parameters.AddWithValue("@DataHoraAlteracao", dataHoraAlteracao);
            cmd.Parameters.AddWithValue("@usuarioAlteracao", usuarioAlteracao);
            cmd.Parameters.AddWithValue("@observacao", observacao);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }


        }

        public void insertStatusOS(String numeroOSTHR, String Andamento, String dataHoraApontament,  String usuarioApontamento, String dataHoraAlteracao, String usuarioAlteracao, String observacao)
        {
            this.numeroOSTHR = numeroOSTHR;
            this.Andamento = Andamento;
            this.dataHoraApontament = dataHoraApontament;
            this.usuarioApontamento = usuarioApontamento;
            this.dataHoraAlteracao = dataHoraAlteracao;
            this.usuarioAlteracao = usuarioAlteracao;
            this.observacao = observacao;
            insertSTatusOP();

        }

        public String status = "OS/Finalizada";
        private void selectOSAberto()
        {
            cmd.CommandText = "Select * from tab_OSTHR order by NOP asc";


            try
            {
                cmd.Connection = con.conectar();

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(dt);



            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }

        }

        public void selecOSAber()
        {
            selectOSAberto();
        }

        private void selecStatus()
        {
            cmd.CommandText = "Select * from tab_StatusOSTHR where numeroOSTHR = @numeroOS";
            cmd.Parameters.AddWithValue("@numeroOS", numeroOSTHR);

            try
            {
                cmd.Connection = con.conectar();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(dt);


            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void SelecStatusOS(String numeroOSTHR)
        {
            this.numeroOSTHR = numeroOSTHR;
            selecStatus();
        }
        String numeroStatus;
        
        private void updateStatusOS()
        {
            cmd.CommandText = "Update tab_StatusOSTHR SET DataHoraApontamento = @dataHoraApontamento," +
                "UsuarioApontamento = @usuarioApontamento," +
                "DataHoraAlteracao = @dataHoraAlteracao," +
                "UsuarioAlteracao = @usuarioAlteracao," +
                "Observacao = @observacao" +
                " WHERE NUMEROStatus = @numeroStatus";

           
            cmd.Parameters.AddWithValue("@dataHoraApontamento", dataHoraApontament);
            cmd.Parameters.AddWithValue("@usuarioApontamento", usuarioApontamento);
            cmd.Parameters.AddWithValue("@dataHoraAlteracao", dataHoraAlteracao);
            cmd.Parameters.AddWithValue("@usuarioAlteracao", usuarioAlteracao);
            cmd.Parameters.AddWithValue("@observacao",observacao);

            cmd.Parameters.AddWithValue("@numeroStatus", numeroStatus);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();


            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }

        }

        public void updateStatus(String numeroStatus)
        {
            this.numeroStatus = numeroStatus;
            updateStatusOS();
        }

        private void selectObservacao()
        {
            cmd.CommandText = "Select * from tab_StatusOSTHR where NumeroStatus = @NumeroStatus order by NUMEROStatus asc";
            cmd.Parameters.AddWithValue("@NumeroStatus", numeroStatus);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    observacao = dr["Observacao"].ToString();
                }

            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void selectOBS(String numeroStatus)
        {
            this.numeroStatus = numeroStatus;
            selectObservacao();
            
        }

        private void loadInfoOS()
        {
            cmd.CommandText = "Select * from tab_OSTHR where NOP = @numeroOS";
            cmd.Parameters.AddWithValue("@numeroOS", numeroOSTHR);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.Read())
                {
                    descricaoServico = dr["DescricaoServico"].ToString();
                    Prioridade = dr["Prioridade"].ToString();
                }
            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void loadINFO(String numeroOSTHR)
        {
            this.numeroOSTHR = numeroOSTHR;
            loadInfoOS();
        }

        private void verificarPrioridade()
        {
            cmd.CommandText = "Select * from tab_OSTHR where NOP = @NOP";
            cmd.Parameters.AddWithValue("@NOP",numeroOSTHR);

            try
            {
                cmd.Connection = con.conectar();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    Prioridade = dr["Prioridade"].ToString();
                }

            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void VerificarPriori(String NumeroOSTHR)
        {
            this.numeroOSTHR = NumeroOSTHR;
            verificarPrioridade();
        }

        private void UpdatePrioridade()
        {
            cmd.CommandText = "Update tab_OSTHR set Prioridade = @Prioridade," +
                " UsuarioPrioridade = @UsuarioPrioridade, " +
                "DataHoraPrioridade = @DataHoraPrioridade " +
                "where NOP = @NumeroOSTHR";
            cmd.Parameters.AddWithValue("@Prioridade", Prioridade);
            cmd.Parameters.AddWithValue("@UsuarioPrioridade", usuarioPrioridade);
            cmd.Parameters.AddWithValue("@DataHoraPrioridade", dataHoraPrioridade);
            cmd.Parameters.AddWithValue("@NumeroOSTHR", numeroOSTHR);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void UpdatePriori(String numeroOSTHR)
        {
            this.numeroOSTHR = numeroOSTHR;
            UpdatePrioridade();
        }

        private void UpdateStatusOS()
        {
            cmd.CommandText = "Update tab_OSTHR set StatusOP = @StatusOS where NOP = @numeroOS";
            cmd.Parameters.AddWithValue("@StatusOS", status);
            cmd.Parameters.AddWithValue("@NumeroOS", numeroOSTHR);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

           
            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void UpdateStaOS(String numeroOSTHR)
        {
            this.numeroOSTHR = numeroOSTHR;
            UpdateStatusOS();
        }

        public String codigoPeca;
        public String descricaoPeca;
        public String QTD;
        public String unidade;
        public String nomeSolicitante;
        public String dataHoraSolicitacao;
        public String statusSolicitacao;
        private void insertRequisicaoPeca()
        {
            cmd.CommandText = "Insert into tab_SolicitacaoPecaOSTHR (NOS, CodigoPeca,DescricaoPeca,QTD,Unidade,NomeSolicitante,DataHoraSolicitacao," +
                "StatusSolicitacao) Values (@NOS, @CodigoPeca,@DescricaoPeca, @QTD, @Unidade, @NomeSolicitante, @DataHoraSolicitacao,@StatusSolicitacao)";
            cmd.Parameters.AddWithValue("@NOS", numeroOSTHR);
            cmd.Parameters.AddWithValue("@CodigoPeca", codigoPeca);
            cmd.Parameters.AddWithValue("@descricaoPeca", descricaoPeca);
            cmd.Parameters.AddWithValue("@Qtd", QTD);
            cmd.Parameters.AddWithValue("@Unidade", unidade);
            cmd.Parameters.AddWithValue("@NomeSolicitante", nomeSolicitante);
            cmd.Parameters.AddWithValue("@DataHoraSolicitacao",dataHoraSolicitacao);
            cmd.Parameters.AddWithValue("@StatusSolicitacao", statusSolicitacao);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();


            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void insertRequisicaoPecas()
        {
            insertRequisicaoPeca();
        }

        private void selectRequisicaoPeca()
        {
            cmd.CommandText = "Select * from tab_SolicitacaoPecaOSTHR where NOS = @NumeroOS";
            cmd.Parameters.AddWithValue("@NumeroOS", numeroOSTHR);

            try
            {
                cmd.Connection = con.conectar();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(dt);


            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }

        }

        public void selectPecas()
        {
            selectRequisicaoPeca();
        }

        private void SelectInfoRequisicao()
        {
            cmd.CommandText = "Select * from tab_SolicitacaoPecaOSTHR where NRequisicao = @NRequisicao";
            cmd.Parameters.AddWithValue("@Nrequisicao", numeroRequisicao);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    codigoPeca = dr["codigoPeca"].ToString();
                    descricaoPeca = dr["descricaoPeca"].ToString();
                    QTD = dr["qtd"].ToString();
                    unidade = dr["Unidade"].ToString();

                }


            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void selectInfoRequi()
        {
            SelectInfoRequisicao();

        }

        private void autRequisicao()
        {
            cmd.CommandText = "Update tab_SolicitacaoPecaOSTHR set NomeAutorizador = @nomeAutorizador, dataHoraAutorizacao = @DataHoraAutorizacao, StatusSolicitacao = 'AUTORIZADO'" +
                "where NRequisicao = @numeroRequisicao ";
            cmd.Parameters.AddWithValue("@nomeAutorizador", nomeAutorizador);
            cmd.Parameters.AddWithValue("@dataHoraAutorizacao", dataHoraAutorizacao);
            cmd.Parameters.AddWithValue("@numeroRequisicao", numeroRequisicao);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void autorizarRequisicao()
        {
            autRequisicao();
        }

        private void selectImpOS()
        {
            cmd.CommandText = "Select * from tab_OSTHR where NOP = @numeroOS";
            cmd.Parameters.AddWithValue("@numeroOS", numeroOSTHR);

            try
            {
                cmd.Connection = con.conectar();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(dt);



            }
            catch(Exception ex)
            {
                msg = "Erro, " + ex;
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
