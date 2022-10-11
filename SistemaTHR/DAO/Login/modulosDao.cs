using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Login
{
    internal class modulosDao
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        private dto.modulosDto dto;

        private void verificarNivel()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tabModulos where Usuario = @usuario";
            cmd.Parameters.AddWithValue("@usuario", dto.Usuario);
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                while (dr.Read())
                {

                    dto.Usuario = dr["usuario"].ToString();

                    dto.Empilhadeiras = dr["Empilhadeiras"].ToString();
                    dto.EmpNivel = dr["EmpNivel"].ToString();


                    dto.Recebimento = dr["Recebimento"].ToString();
                    dto.RecebNivel = dr["recebNivel"].ToString();


                    dto.Expedicao = dr["Expedicao"].ToString();
                    dto.ExpNivel = dr["ExpNivel"].ToString();


                    dto.Adm = dr["ADM"].ToString();
                    dto.AdmNivel = dr["ADMNivel"].ToString();

                    dto.Manutencao = dr["manutencao"].ToString();
                    dto.ManutencaoNivel = dr["manutencaoNivel"].ToString();

                    dto.Producao = dr["producao"].ToString();
                    dto.ProducaoNivel = dr["producaoNivel"].ToString();

                    dto.Almoxarifado = dr["Almoxarifado"].ToString();
                    dto.AlmoxarifadoNivel = dr["AlmoxarifadoNivel"].ToString();

                    dto.Estoque = dr["Estoque"].ToString();
                    dto.EstoqueNivel = dr["EstoqueNivel"].ToString();

                    dto.Compras = dr["Compras"].ToString();
                    dto.ComprasNivel = dr["ComprasNivel"].ToString();
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

        public void info(dto.modulosDto dto)
        {
            this.dto = dto;
            verificarNivel();
        }
        private void load()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tabModulos";

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
        public void loadDataTable(dto.modulosDto dto)
        {
            this.dto = dto;
            load();
        }
        private void updateModulosUser()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Update tabModulos set empilhadeiras = @empilhadeiras, empNivel = @empNivel, Recebimento = @Recebimento, " +
                               "RecebNivel = @RecebNivel, Expedicao = @expedicao, ExpNivel = @ExpNivel, ADM = @ADM, ADMNIVEL = @admNivel," +
                               " Manutencao = @manutencao, ManutencaoNivel = @manutencaoNivel, producao = @producao, " +
                               "producaoNivel = @producaoNivel, Almoxarifado = @Almoxarifado, AlmoxarifadoNivel = @AlmoxarifadoNivel, " +
                               "estoque = @estoque, estoqueNivel = @estoqueNivel, compras = @Compras, comprasNivel = @ComprasNivel " +
                               " where usuario = @usuario ";
            cmd.Parameters.AddWithValue("@empilhadeiras", dto.Empilhadeiras);
            cmd.Parameters.AddWithValue("@empNivel", dto.EmpNivel);
            cmd.Parameters.AddWithValue("@Recebimento", dto.Recebimento);
            cmd.Parameters.AddWithValue("@RecebNivel", dto.RecebNivel);
            cmd.Parameters.AddWithValue("@expedicao", dto.Expedicao);
            cmd.Parameters.AddWithValue("@ExpNivel", dto.ExpNivel);
            cmd.Parameters.AddWithValue("@ADM", dto.Adm);
            cmd.Parameters.AddWithValue("@admNivel", dto.AdmNivel);
            cmd.Parameters.AddWithValue("@manutencao", dto.Manutencao);
            cmd.Parameters.AddWithValue("@manutencaoNivel", dto.ManutencaoNivel);
            cmd.Parameters.AddWithValue("@producao", dto.Producao);
            cmd.Parameters.AddWithValue("@producaoNivel", dto.ProducaoNivel);
            cmd.Parameters.AddWithValue("@Almoxarifado", dto.Almoxarifado);
            cmd.Parameters.AddWithValue("@AlmoxarifadoNivel", dto.AlmoxarifadoNivel);
            cmd.Parameters.AddWithValue("@estoque", dto.Estoque);
            cmd.Parameters.AddWithValue("@estoqueNivel", dto.EstoqueNivel);
            cmd.Parameters.AddWithValue("@Compras", dto.Compras);
            cmd.Parameters.AddWithValue("@ComprasNivel", dto.ComprasNivel);
            cmd.Parameters.AddWithValue("@usuario", dto.Usuario);


            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally { con.desconectar(); }
        }
        public void update(dto.modulosDto dto)
        {
            this.dto = dto;
            updateModulosUser();
        }
        private void insertModulos()
        {

            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into tabModulos (empilhadeiras,empNivel,Recebimento,RecebNivel, " +
                                "Expedicao, ExpNivel, ADM,ADMNIVEL,Manutencao,ManutencaoNivel, usuario, producao, producaoNivel, " +
                                "Almoxarifado, AlmoxarifadoNivel, Estoque, EstoqueNivel, Compras, ComprasNivel) values " +
                                "(@empilhadeiras, @empNivel,@Recebimento, @RecebNivel, @expedicao, @ExpNivel," +
                                " @ADM, @admNivel, @manutencao, @manutencaoNivel,@usuario,@producao, @producaoNivel," +
                                "@Almoxarifado, @AlmoxarifadoNivel,@Estoque, @EstoqueNivel, @Compras, @ComprasNivel)";

            cmd.Parameters.AddWithValue("@empilhadeiras", dto.Empilhadeiras);
            cmd.Parameters.AddWithValue("@empNivel", dto.EmpNivel);
            cmd.Parameters.AddWithValue("@Recebimento", dto.Recebimento);
            cmd.Parameters.AddWithValue("@RecebNivel", dto.RecebNivel);
            cmd.Parameters.AddWithValue("@expedicao", dto.Expedicao);
            cmd.Parameters.AddWithValue("@ExpNivel", dto.ExpNivel);
            cmd.Parameters.AddWithValue("@ADM", dto.Adm);
            cmd.Parameters.AddWithValue("@admNivel", dto.AdmNivel);
            cmd.Parameters.AddWithValue("@manutencao", dto.Manutencao);
            cmd.Parameters.AddWithValue("@manutencaoNivel", dto.ManutencaoNivel);
            cmd.Parameters.AddWithValue("@usuario", dto.Usuario);
            cmd.Parameters.AddWithValue("@producao", dto.Producao);
            cmd.Parameters.AddWithValue("@producaoNivel", dto.ProducaoNivel);
            cmd.Parameters.AddWithValue("@Almoxarifado",dto.Almoxarifado);
            cmd.Parameters.AddWithValue("@AlmoxarifadoNivel",dto.AlmoxarifadoNivel);
            cmd.Parameters.AddWithValue("@Estoque", dto.Estoque);
            cmd.Parameters.AddWithValue("@EstoqueNivel", dto.EstoqueNivel);
            cmd.Parameters.AddWithValue("@Compras", dto.Compras);
            cmd.Parameters.AddWithValue("@ComprasNivel", dto.ComprasNivel);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally { con.desconectar(); }
        }
        public void insert(dto.modulosDto dto)
        {
            this.dto = dto;
            insertModulos();
        }
        private void deleteUserModulos()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Delete from tabModulos where usuario = @usuario";
            cmd.Parameters.AddWithValue("@usuario", dto.Usuario);
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
        public void delete(dto.modulosDto dto)
        {
            this.dto = dto;
            deleteUserModulos();
        }
    }
}
