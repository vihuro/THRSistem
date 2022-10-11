using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SistemaTHR.DAO
{
    public class transferenciaDao
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection conn = new Connection();

        private dto.transferencia.transferenciaDto dto;

        private void insertTransferencia()
        {

            cmd = new OleDbCommand();
            cmd.CommandText = "Insert into tab_Transferencia(dataHoraTransf, usuarioTransf) Values (@dataHoraTransf,@usuarioTransf)";
            cmd.Parameters.AddWithValue("@dataHoraTransf", dto.DataHoraTransf);
            cmd.Parameters.AddWithValue("@usuarioTransf", dto.UsuarioTransf);

            try
            {
                cmd.Connection = conn.conectar();
                cmd.ExecuteNonQuery();

            }
            catch (Exception ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally
            {
                conn.desconectar();
            }
        }

        public void insert(dto.transferencia.transferenciaDto dto)
        {
            this.dto = dto;
            insertTransferencia();

        }

        private void selecTransfenrecias()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_Transferencia";
            try
            {
                cmd.Connection = conn.conectar();
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
                conn.desconectar();
            }
        }

        public void selectTable(dto.transferencia.transferenciaDto dto)
        {
            this.dto = dto;
            selecTransfenrecias();

        }


        private void selectIdTransf()
        {
            cmd = new OleDbCommand();
            cmd.CommandText = "Select * from tab_transferencia order by id asc";
            try
            {
                cmd.Connection = conn.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    dto.Id = dr["id"].ToString();
                }

            }
            catch (Exception ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally
            {
                conn.desconectar();
            }

        }


        public void selectId(dto.transferencia.transferenciaDto dto)
        {
            this.dto = dto;
            selectIdTransf();

        }


    }
}
