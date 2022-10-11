using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;
using Npgsql;
using SistemaTHR.dto.Login;

namespace SistemaTHR.DAO.Login
{
    internal class LoginDao
    {

        //NpgsqlCommand cmd;
        //NpgsqlDataReader dr;


        private OleDbCommand cmd;
        private OleDbDataReader dr;
        private Connection con = new Connection();
        private OleDbDataAdapter da;
        
        private dto.Login.loginDto dto;

        private void updateUser()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Update tbUsuario set nome = @nome , senha = @senha where usuario = @usuario";
            cmd.Parameters.AddWithValue("@nome", dto.NomeUsuario);
            cmd.Parameters.AddWithValue("@senha", dto.Senha);
            cmd.Parameters.AddWithValue("@usuario", dto.Nome);

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

        public void update(dto.Login.loginDto dto)
        {
            this.dto = dto;
            updateUser();
        }

        private void insertUser()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into tbUsuario (Usuario,Nome,Senha) Values (@usuario,@nome,@senha)";
            cmd.Parameters.AddWithValue("@usuario",dto.Nome);
            cmd.Parameters.AddWithValue("@nome",dto.NomeUsuario);
            cmd.Parameters.AddWithValue("@senha",dto.Senha);

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

        public void insert(dto.Login.loginDto dto)
        {
            this.dto = dto;
            insertUser();
        }


        private void authorizedUser()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tbUsuario where Usuario = @usuario and senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", dto.NomeUsuario);
            cmd.Parameters.AddWithValue("@senha", dto.Senha);

            try
            {
                cmd.Connection = con.conectar();
                 
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    dto.Autorizado = true;
                    while (dr.Read())
                    {
                        dto.Nome = dr["Nome"].ToString();
                        dto.NomeUsuario = dr["usuario"].ToString();
                    }
                }

            }
            catch(Exception ex)
            {
                dto.Msg = "Erro" + ex;
            }
            finally
            { 
                con.desconectar(); 
            }
        }

        public void authorized(dto.Login.loginDto dto)
        {
            this.dto = dto;
            authorizedUser();
        }


        private void deleteUser()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Delete from tb_Usuario where usuario = @usuario";
            cmd.Parameters.AddWithValue("@usuario",dto.Nome);
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

        internal void Table(loginDto dto)
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tbUsuario order by Nome asc";
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

        public void delete(dto.Login.loginDto dto)
        {
            this.dto = dto;
            deleteUser();
        }

        private void infoUser()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tbUsuario where usuario = @usuario";
            cmd.Parameters.AddWithValue("@usuario",dto.Nome);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    while (dr.Read())
                    {
                        dto.Nome = dr["usuario"].ToString();
                        dto.NomeUsuario = dr["nome"].ToString();
                        dto.Senha = dr["Senha"].ToString();
                    }
                }
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

        public void info(dto.Login.loginDto dto)
        {
            this.dto = dto;
            infoUser();
        }

    }
}
