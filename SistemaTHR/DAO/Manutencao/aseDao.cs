using SistemaTHR.Service.Exepction;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Manutencao
{
    internal class aseDao
    {

        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        private Connection con = new Connection();
        private OleDbDataAdapter da;
        private dto.manutencao.aseDto dto;

        private void selectTable()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_ASE order by execucao asc";

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
        public void table(dto.manutencao.aseDto dto)
        {
            this.dto = dto;
            selectTable();
        }

        private void insertEx()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into tab_ASE (Execucao, UsuarioCadastro, dataHoraCadastro) values (@execucao, @usuarioCadastro, @dataHoraCadastro)";
            cmd.Parameters.AddWithValue("@execucao",dto.Execucao);
            cmd.Parameters.AddWithValue("@usuarioCadastro",dto.Usuario);
            cmd.Parameters.AddWithValue("@dataHoraCadastro",dto.DataHora);
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

        public void insert(dto.manutencao.aseDto dto)
        {
            this.dto = dto;
            insertEx();
        }

        private void deleteEx()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Delete from tab_ASE where NumeroASE = @numero";
            cmd.Parameters.AddWithValue("@numero",dto.Numero);

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

        public void delete(dto.manutencao.aseDto dto)
        {
            this.dto = dto;
            deleteEx();
        }

        public List<string> List()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_ASE order by execucao asc ";

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                var list = new List<string>();

                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        list.Add(dr.GetString(dr.GetOrdinal("execucao")));
                    }
                    return list;

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


        private void verificarEx()
        {
            cmd.CommandText = "Select * from tab_ASE where execucao = @execusao";
            cmd.Parameters.AddWithValue("@execuxao",dto.Execucao);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dto.Check = true;
                }
                else
                {
                    dto.Check = false;
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

        public void verificar(dto.manutencao.aseDto dto)
        {
            this.dto = dto;
            verificarEx();
        }

    }
}
