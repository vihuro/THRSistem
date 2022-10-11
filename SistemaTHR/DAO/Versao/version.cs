using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Versao

{
    internal class version
    {
        private dto.Versao.versaoDto dto;
        
        private OleDbCommand cmd = new OleDbCommand();
        private OleDbDataReader dr;
        private DAO.Connection con = new Connection();


        private void verificarVersao()
        {
            cmd.CommandText = "Select * from tab_Version where NVersion = @Versao";
            cmd.Parameters.AddWithValue("@Versao",dto.NVersao);

            try
            {

                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();

                if (dr.HasRows)
                {
                   dto.Exists = true;
                }
                else
                {
                    dto.Exists = false;
                }

            }
            catch(OleDbException ex)
            {
                dto.Msg = "Erro " + ex;
            }
            finally
            {
                con.desconectar();
            }
        }

        public void verificar(dto.Versao.versaoDto dto)
        {
            this.dto = dto;
            verificarVersao();
        }
        
    }
}
