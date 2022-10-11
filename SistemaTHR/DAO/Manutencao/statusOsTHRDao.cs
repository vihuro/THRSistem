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
    internal class statusOsTHRDao
    {
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        private Connection con = new Connection();

        private statusOsThrDto dto;

        private void insertStatus()
        {
            cmd.CommandText = "Insert into tab_StatusOSTHR (NumeroOSTHR, Andamento, DataHoraApontamento,UsuarioApontamento,DataHoraAlteracao,UsuarioAlteracao,Observacao) " +
                 "Values(@NumeroOSTHR, @Andamento, @DataHoraApontamento,@usuarioApontamento, @DataHoraAlteracao, @usuarioAlteracao,@observacao)";
            cmd.Parameters.AddWithValue("@NumeroOSTHR", dto.NOsThr);
            cmd.Parameters.AddWithValue("@Andamento", dto.Andamento);
            cmd.Parameters.AddWithValue("@DataHoraApontamento", dto.DataHoraApontamento);
            cmd.Parameters.AddWithValue("@usuarioApontamento", dto.UsuarioApontamento);
            cmd.Parameters.AddWithValue("@DataHoraAlteracao", dto.DataHoraAlteracao);
            cmd.Parameters.AddWithValue("@usuarioAlteracao", dto.UsuarioAlteracao);
            cmd.Parameters.AddWithValue("@observacao", dto.Observacao);

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

        public void insert(dto.manutencao.statusOsThrDto dto)
        {
            this.dto = dto;
            insertStatus();
        }

        public void selecTableOS(statusOsThrDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_StatusOSTHR where NumeroOSTHR = @NumeroOS order by NUMEROStatus";
            cmd.Parameters.AddWithValue("@numeroOS", dto.NOsThr);

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
        
        public void tableOS(dto.manutencao.statusOsThrDto dto)
        {
            this.dto = dto;
            //selecTableOS();
        }

        private void updateStatusOS()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Update tab_StatusOSTHR SET DataHoraApontamento = @dataHoraApontamento," +
                "UsuarioApontamento = @usuarioApontamento," +
                "DataHoraAlteracao = @dataHoraAlteracao," +
                "UsuarioAlteracao = @usuarioAlteracao," +
                "Observacao = @observacao" +
                " WHERE NUMEROStatus = @numeroStatus";


            cmd.Parameters.AddWithValue("@dataHoraApontamento", dto.DataHoraApontamento);
            cmd.Parameters.AddWithValue("@usuarioApontamento", dto.UsuarioApontamento);
            cmd.Parameters.AddWithValue("@dataHoraAlteracao", dto.DataHoraAlteracao);
            cmd.Parameters.AddWithValue("@usuarioAlteracao", dto.UsuarioAlteracao);
            cmd.Parameters.AddWithValue("@observacao", dto.Observacao);

            cmd.Parameters.AddWithValue("@numeroStatus", dto.NStatus);

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

        public void update(dto.manutencao.statusOsThrDto dto)
        {
            this.dto = dto;
            updateStatusOS();
        }

        private void desfazerApontamento()
        {
            cmd.CommandText = "Update tab_StatusOSTHR set DataHoraApontamento = @dataHoraApontamento," +
                                "UsuarioApontamento = @usuarioApontamento," +
                                "DataHoraAlteracao = @dataHoraAlteracao," +
                                "UsuarioAlteracao = @usuarioAlteracao," +
                                "Observacao = @observacao " +
                                "where NUMEROStatus = @numeroStatus";

            cmd.Parameters.AddWithValue("@dataHoraApontamento", dto.DataHoraApontamento);
            cmd.Parameters.AddWithValue("@usuarioApontamento", dto.UsuarioApontamento);
            cmd.Parameters.AddWithValue("@dataHoraAlteracao", dto.DataHoraAlteracao);
            cmd.Parameters.AddWithValue("@usuarioAlteracao", dto.UsuarioAlteracao);
            cmd.Parameters.AddWithValue("@observacao", "");
            cmd.Parameters.AddWithValue("@numeroStatus", dto.NStatus);

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

        public void desfazer(dto.manutencao.statusOsThrDto dto)
        {
            this.dto = dto;
            desfazerApontamento();

        }

    }
}
