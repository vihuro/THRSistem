using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Producao
{
    internal class FichaDao
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        OleDbDataAdapter da;
        public DataTable dt = new DataTable();

        public String id;
        public String lote;
        public String descricao;
        public String codigo;
        public String dataHoraInicio;
        public String usuarioLancamento;
        public String dataHoraFinAnalise;
        public String usuarioFinAnalise;
        public String dataHoraFinProd;
        public String usuarioFinProd;
        public String status;
        public String msg;

        private void selectFichaImpressao()
        {
            cmd.CommandText = "Select * from tab_ficha where id = @id";
            cmd.Parameters.AddWithValue("@id",id);
            try
            {
                cmd.Connection = con.conectar();
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
            }
            catch(Exception ex)
            {
                msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }

        }

        public void selectFicha()
        {
            selectFichaImpressao();
        }

        private void selectIdFicha()
        {
            cmd.CommandText = "Select * from tab_ficha order by id asc";
            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                    while(dr.Read())
                    {
                        id = dr["id"].ToString();
                    }
                }
            }
            catch (Exception ex)
            {

                msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void selectId()
        {
            selectIdFicha();
        }

        private void insertFicha()
        {
            cmd.CommandText = "Insert into tab_ficha(Lote, Descricao, Codigo, dataHoraIniAnalise,usuarioLancamento , status)" +
                "values(@lote, @descricao, @codigo, @dataHoraInicio, @usuarioLancamento, @status)";
            cmd.Parameters.AddWithValue("@lote",lote);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@dataHoraInicio", dataHoraInicio);
            cmd.Parameters.AddWithValue("@usuarioLancamento", usuarioLancamento);
            cmd.Parameters.AddWithValue("@status", status);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }

        }

        public void insert()
        {
            insertFicha();
        }

        private void updateFichaCQ()
        {
            cmd.CommandText = "Update tab_ficha set dataHoraFinAnalise = @dataHoraFinAnalise, usuarioFinAnalise = @usuarioFinAnalise, status = @Status where id = @id";
            cmd.Parameters.AddWithValue("@dataHoraFinAnalise",dataHoraFinAnalise);
            cmd.Parameters.AddWithValue("@usuarioFinAnalise",usuarioFinAnalise);
            cmd.Parameters.AddWithValue("@status",status);
            cmd.Parameters.AddWithValue("@id",id);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void updateCQ()
        {
            updateFichaCQ();

        }

        private void updateFichaProd()
        {
            cmd.CommandText = "Update tab_ficha set dataHoraFinProd = @dataHoraFinProd, UsuarioFinProd = @usuarioFinProd, status = @status where id = @id";
            cmd.Parameters.AddWithValue("@dataHoraFinProd",dataHoraFinProd);
            cmd.Parameters.AddWithValue("@usuarioFinProd",usuarioFinProd);
            cmd.Parameters.AddWithValue("@status",status);
            cmd.Parameters.AddWithValue("@id",id);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void updateProd()
        {
            updateFichaProd();
        }

        private void painelFichas()
        {
            cmd.CommandText = "Select * from tab_ficha order by id asc";

            try
            {
                cmd.Connection = con.conectar();
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);
            }
            catch (Exception ex)
            {

                msg = "Erro " + ex;
            }
            finally
            {
               con.desconectar();
            }
        }

        public void painel()
        {
            painelFichas();
        }

        private void selectAnaliseS()
        {
            cmd.CommandText = "Select * from tab_ficha order by id asc ";
            try
            {
                cmd.Connection = con.conectar();
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void selectAnalise()
        {
            selectAnaliseS();
        }

        private void selectAnalisefin()
        {
            cmd.CommandText = "Select * from tab_ficha '";
            try
            {
                cmd.Connection = con.conectar();
                da = new OleDbDataAdapter(cmd);
                da.Fill(dt);

            }
            catch (Exception ex)
            {

                msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void selecFinAnalise()
        {
            selectAnalisefin();
        }
    }
}
