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
        public String dataHoraFinAnalise;
        public String dataHoraFinProd;
        public String status;
        public String msg;

        private void selectFichaImpressao()
        {
            cmd.CommandText = "Select * from tab_ficha where id = 5";
            //cmd.Parameters.AddWithValue("@id",id);
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
            cmd.CommandText = "Insert into tab_ficha(Lote, Descricao, Codigo, dataHoraIniAnalise, status)" +
                "values(@lote, @descricao, @codigo, dataHoraInicio, @status)";
            cmd.Parameters.AddWithValue("@lote",lote);
            cmd.Parameters.AddWithValue("@codigo", codigo);
            cmd.Parameters.AddWithValue("@dataHoraIncio", dataHoraInicio);
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
            cmd.CommandText = "Update tab_ficha set dataHoraFinAnalise = @dataHoraFinAnalise, status = @Status where id = @id";
            cmd.Parameters.AddWithValue("@dataHoraFinAnalise",dataHoraFinAnalise);
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
            cmd.CommandText = "Update tab_ficha set dataHoraFinProd = @dataHoraFinProd, status = @status where id = @id";
            cmd.Parameters.AddWithValue("@dataHoraFinProd",dataHoraFinProd);
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
               //con.desconectar();
            }
        }

        public void painel()
        {
            painelFichas();
        }
    }
}
