using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Data;

namespace SistemaTHR.DAO
{
    internal class LoginDao
    {
        public bool tem = false;
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        public String menssagem = "";
        public String nomeUsuario;
        public String manutencao;
        public String manutencaoNivel;
        public String senha;

        public bool verificar(String usuario, String senha)
        {
            cmd.CommandText = "Select * from tbUsuario where Usuario = @usuario and senha = @senha";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            cmd.Parameters.AddWithValue("@senha", senha);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                if (dr.HasRows)
                {
                    tem = true;
                }

            }
            catch (Exception)
            {
                this.menssagem = "Erro com banco de dados";
            }
            finally
            {
                con.desconectar();
            }
            return tem;
        }

        public String usuario;
        public String Empilhadeiras = "Não";
        public String EmpNivel = "0";
        public String Recebimento = "Não";
        public String RecebNivel = "0";
        public String Expedicao = "Não";
        public String ExpNivel = "0";
        public String Adm = "Não";
        public String AdmNivel = "0";

        private void verificarNivel()
        {
            cmd.CommandText = "Select * from tabModulos where Usuario = @usuario";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                        usuario = dr["usuario"].ToString();

                        Empilhadeiras = dr["Empilhadeiras"].ToString();
                        EmpNivel = dr["EmpNivel"].ToString();


                        Recebimento = dr["Recebimento"].ToString();
                        RecebNivel = dr["recebNivel"].ToString();


                        Expedicao = dr["Expedicao"].ToString();
                        ExpNivel = dr["ExpNivel"].ToString();

                        
                        Adm = dr["ADM"].ToString();
                        AdmNivel = dr["ADMNivel"].ToString();

                        manutencao = dr["manutencao"].ToString();
                        manutencaoNivel = dr["manutencaoNivel"].ToString();


                }

            }
            catch
            {

            }
            finally
            {
                con.desconectar();
            }

        }
        public DataTable dt = new DataTable();
        private void loadUsuario()
        {
            cmd.CommandText = "Select * from tabModulos";
            

            try
            {
                cmd.Connection=con.conectar();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(dt);

            }
            catch
            {

            }
            finally
            {
                con.desconectar();
            }
        }
        

        private void loadInformacoes()
        {
            cmd.CommandText = "Select * from tabModulos where Usuario = @usuario";
            cmd.Parameters.AddWithValue("@usuario", usuario);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    usuario = dr["usuario"].ToString();

                    Empilhadeiras = dr["Empilhadeiras"].ToString();
                    EmpNivel = dr["EmpNivel"].ToString();


                    Recebimento = dr["Recebimento"].ToString();
                    RecebNivel = dr["recebNivel"].ToString();


                    Expedicao = dr["Expedicao"].ToString();
                    ExpNivel = dr["ExpNivel"].ToString();


                    Adm = dr["ADM"].ToString();
                    AdmNivel = dr["ADMNivel"].ToString();



                }
            }
            catch
            {

            }
            finally { con.desconectar(); }
        }

        public void loadInfo(String usuario)
        {
            this.usuario = usuario;
            loadInformacoes();
        }

        public void loadUser()
        {
            
            loadUsuario();
        }

        public void verificarNivel(String usuario)
        {
            this.usuario = usuario;
            verificarNivel();

        }

        private void SelectNome()
        {
            cmd.CommandText = "Select * from tbUsuario where usuario = @usuario";
            cmd.Parameters.AddWithValue("usuario", usuario);

            try
            {
                cmd.Connection = con.conectar();

                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    nomeUsuario = dr["Nome"].ToString();


                }
                con.desconectar();

            }
            catch
            {

            }
            finally { con.desconectar(); }
        }

        public void SelecNomeUsuario(String usuario)
        {
            this.usuario = usuario;
            SelectNome();
        }

        private void selectNome()
        {
            cmd.CommandText = "Select * from tbUsuario where usuario = @usuario";
            cmd.Parameters.AddWithValue("@usuario", usuario);

            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {
                    nomeUsuario = dr["nome"].ToString();
                    senha = dr["senha"].ToString();
                }

                con.desconectar();
            }
            catch
            {

            }
            finally { con.desconectar(); }
        }

        public void selectNomeUsuario()
        {
            selectNome();
        }

        private void updateUsuario()
        {
            cmd.CommandText = "Update tbUsuario set nome = @nome where usuario = @usuario";
            cmd.Parameters.AddWithValue("@nome", nomeUsuario);
            cmd.Parameters.AddWithValue("@usuario", usuario);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteReader();

                con.desconectar();

            }
            catch
            {

            }
            finally { con.desconectar(); }
        }

        public void updateUser()
        {
            updateUsuario();
        }

        private void updateModulosUser()
        {
            cmd.CommandText = "Update tabModulos set empilhadeiras = @empilhadeiras, empNivel = @empNivel, Recebimento = @Recebimento, RecebNivel = @RecebNivel," +
                "Expedicao = @expedicao, ExpNivel = @ExpNivel, ADM = @ADM, ADMNIVEL = @admNivel, Manutencao = @manutencao, ManutencaoNivel = @manutencaoNivel" +
                " where usuario = @usuario ";
            cmd.Parameters.AddWithValue("@empilhadeiras",Empilhadeiras);
            cmd.Parameters.AddWithValue("@empNivel",EmpNivel);
            cmd.Parameters.AddWithValue("@Recebimento",Recebimento);
            cmd.Parameters.AddWithValue("@RecebNivel",RecebNivel);
            cmd.Parameters.AddWithValue("@expedicao",Expedicao);
            cmd.Parameters.AddWithValue("@ExpNivel",ExpNivel);
            cmd.Parameters.AddWithValue("@ADM",Adm);
            cmd.Parameters.AddWithValue("@admNivel",AdmNivel);
            cmd.Parameters.AddWithValue("@manutencao",manutencao);
            cmd.Parameters.AddWithValue("@manutencaoNivel",manutencaoNivel);
            cmd.Parameters.AddWithValue("@usuario",usuario);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteReader();


            }
            catch
            {

            }
            finally { con.desconectar(); }
        }

        public void uptadeModulosUsuario()
        {
           updateModulosUser();
        }

        private void insertUser()
        {
            cmd.CommandText = "Insert into tbUsuario (Usuario,Nome,Senha) Values (@usuario,@nome,@senha)";
            cmd.Parameters.AddWithValue("@usuario",usuario);
            cmd.Parameters.AddWithValue("@nome",nomeUsuario);
            cmd.Parameters.AddWithValue("@senha",senha);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteReader();


            }
            catch
            {

            }
            finally { con.desconectar(); }
        }

        public void inserUsuario()
        {
            insertUser();
        }

        private void insertModulos()
        {
            cmd.CommandText = "Insert into tabModulos (empilhadeiras,empNivel,Recebimento,RecebNivel, " +
                "Expedicao, ExpNivel, ADM,ADMNIVEL,Manutencao,ManutencaoNivel, usuario) values " +
                "(@empilhadeiras, @empNivel,@Recebimento, @RecebNivel, @expedicao, @ExpNivel, @ADM, @admNivel, @manutencao, @manutencaoNivel,@usuario)";

            cmd.Parameters.AddWithValue("@empilhadeiras", Empilhadeiras);
            cmd.Parameters.AddWithValue("@empNivel", EmpNivel);
            cmd.Parameters.AddWithValue("@Recebimento", Recebimento);
            cmd.Parameters.AddWithValue("@RecebNivel", RecebNivel);
            cmd.Parameters.AddWithValue("@expedicao", Expedicao);
            cmd.Parameters.AddWithValue("@ExpNivel", ExpNivel);
            cmd.Parameters.AddWithValue("@ADM", Adm);
            cmd.Parameters.AddWithValue("@admNivel", AdmNivel);
            cmd.Parameters.AddWithValue("@manutencao", manutencao);
            cmd.Parameters.AddWithValue("@manutencaoNivel", manutencaoNivel);
            cmd.Parameters.AddWithValue("@usuario", usuario);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteReader();


            }
            catch
            {

            }
            finally { con.desconectar(); }
        }

        public void insertMod()
        {
            insertModulos();
        }

        private void verificarUser()
        {
            cmd.CommandText = "Select * from tbUsuario where usuario = @usuario";
            cmd.Parameters.AddWithValue("@usuario", usuario);

            try
            {
                cmd.Connection = con.conectar();

                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    tem = true;
                }
                else
                {
                    tem = false;
                }
            }
            catch
            {

            }
            finally { con.desconectar(); }
        }

        public void verificarUsuario()
        {
            verificarUser();
        }

    }
}
