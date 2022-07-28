using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO
{
    internal class manutecaoEmpilhadeiraDao
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();

        public void insertSolicitacao(String numeroEmp, String descricao, String prioridade, String Status, DateTime dataHoraSolicitacao, String usuarioSolicitacao)
        {
            cmd.CommandText = "Insert into tab_manutencoes (numeroEmp , descricao, prioridade, Status, dataHoraSolicitacao, usuarioSolicitacao) Values (@numeroEmp, @descricao, @prioridade, @status, @dataHoraSolicitacao, @usuarioSolicitacao)";
            cmd.Parameters.AddWithValue("@numeroEmp", numeroEmp);
            cmd.Parameters.AddWithValue("@descricao", descricao);
            cmd.Parameters.AddWithValue("@prioridade", prioridade);
            cmd.Parameters.AddWithValue("@Status",Status);
            cmd.Parameters.AddWithValue("@dataHoraSolicitacao", dataHoraSolicitacao);
            cmd.Parameters.AddWithValue("@usuarioSolicitacao", usuarioSolicitacao);

            try
            {
                cmd.Connection = con.conectar();
                cmd.ExecuteReader();

                con.desconectar();

            }
            catch
            {

            }

        }

        public String descricao;

        public String selectIDTrocaGas(int id)
        {

            cmd.CommandText = "Select * from tab_Manutencoes where id = @id";
            cmd.Parameters.AddWithValue("@id", id);


            try
            {
                cmd.Connection = con.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    descricao = dr["descricao"].ToString();
                }



                con.desconectar();

            }
            catch
            {

            }
            return descricao;
        }

    }
}
