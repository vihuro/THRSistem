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
    internal class transferenciaDao
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection conn = new Connection();
        public String idFechamento;
        public String menssagem;

        public DateTime dataHoraTransf;
        public String usuarioTransf;

        private void insertTransferencia()
        {

            
            cmd.CommandText = "Insert into tab_Transferencia(dataHoraTransf, usuarioTransf) Values (@dataHoraTransf,@usuarioTransf)";
            cmd.Parameters.AddWithValue("@dataHoraTransf", dataHoraTransf);
            cmd.Parameters.AddWithValue("@usuarioTransf", usuarioTransf);

            try
            {
                cmd.Connection = conn.conectar();
                cmd.ExecuteReader();

                conn.desconectar();

            }
            catch
            {

            }
        }

        DataTable tabela = new DataTable();

        public DataTable loadFechamento()
        {
            DataTable dt = new DataTable();
            cmd.CommandText = "Select * tab_fechamento where idTransferencia = 61";
            
            OleDbDataAdapter da = new OleDbDataAdapter(cmd);

            da.Fill(dt);

            conn.desconectar();



            return tabela;
        }

        public String numeroPa;
        public String codigo;
        public String descricao;
        public String pesoBruto;
        public String pesoLiquido;
        public String bobinas;
        public String idTransferencia;
        public String usuarioTransferencia;

        private void insertoMovimentaco()
        {
            if (cmd.Parameters.Count > 0)
            {
                cmd.Parameters.Clear();
            }


                cmd.CommandText = "Insert into tab_Movimentacao (numeroPa,codigo,Descricao,PesoBruto," +
                    "PesoLiquido,Bobinas,idTransferencia,UsuarioTransferencia) " +
                    "Values (@numeroPa,@codigo,@descricao,@pesoBruto,@pesoLiquido,@bobinas,@idTransferencia,@usuarioTransferencia)";
                cmd.Parameters.AddWithValue("@numeroPa", numeroPa);
                cmd.Parameters.AddWithValue("@codigo", codigo);
                cmd.Parameters.AddWithValue("@descricao", descricao);
                cmd.Parameters.AddWithValue("@pesoBruto", pesoBruto);
                cmd.Parameters.AddWithValue("@pesoLiquido", pesoLiquido);
                cmd.Parameters.AddWithValue("@bobinas", bobinas);
                cmd.Parameters.AddWithValue("@idTransferencia", idTransferencia);
                cmd.Parameters.AddWithValue("@usuarioTransferencia", usuarioTransferencia);

                try
                {
                    cmd.Connection = conn.conectar();
                     cmd.ExecuteNonQuery();
                   

                    conn.desconectar();
                }
                catch
                {

                }
            

        }

        private void insertIntoFechamento()
        {
            if (cmd.Parameters.Count > 0)
            {
                cmd.Parameters.Clear();
            }


                cmd.CommandText = "Insert into tab_fechamento(Codigo,Descricao,PesoBruto,PesoLiquido,QtBobinas,IdTransferencia)" +
                    " Values (@Codigo,@Descricao,@PesoBruto,@PesoLiquido,@QtBobinas,@IdTransferencia)";
                cmd.Parameters.AddWithValue("@Codigo", codigo);
                cmd.Parameters.AddWithValue("@Descricao", descricao);
                cmd.Parameters.AddWithValue("@PesoBruto", pesoBruto);
                cmd.Parameters.AddWithValue("@PesoLiquido", pesoLiquido);
                cmd.Parameters.AddWithValue("@QtBobinas", bobinas);
                cmd.Parameters.AddWithValue("@IdTransferencia", idTransferencia);

                try
                {

                    cmd.Connection = conn.conectar();
                    cmd.ExecuteNonQuery();


                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.ToString());
                }
                finally
                {
                    conn.desconectar();
                }
            
        }

        private void selectTransfenrecia()
        {
            cmd.CommandText = "Select * from tab_Movimentacao where idTransferencia = @id";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conn.conectar();

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(dt);

                conn.desconectar();

            }
            catch
            {

            }

        }
        private void loadFechamentoImp()
        {
            cmd.CommandText = "Select * from tab_Fechamento where idTransferencia = @id";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conn.conectar();

                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(dt);

                conn.desconectar();

            }
            catch
            {
                MessageBox.Show("Errooooo");
            }

        }

        public void loadImpFech(String id)
        {
            this.id = id;
            loadFechamentoImp();
        }

        public void selectTransf(String id)
        {
            this.id = id;
            selectTransfenrecia();
        }

        private void selectFechamentos()
        {
                cmd.CommandText = "Select * from tab_Fechamento where idTransferencia = @id";
                cmd.Parameters.AddWithValue("@id", id);

                try
                {
                    cmd.Connection = conn.conectar();

                    OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                    da.Fill(dt);

                    conn.desconectar();

                }
                catch
                {

                }
        }

        public String numeroMovimentacao;

        private void deletMovimentacao()
        {

            cmd.CommandText = "Delete from tab_movimentacao where id = @id";
            cmd.Parameters.AddWithValue("@id", numeroMovimentacao);

            try
            {
                cmd.Connection = conn.conectar();
                cmd.ExecuteReader();

                conn.desconectar();

            }
            catch
            {

            }

        }

        public void deletMovi(String numeroMovimentacao)
        {
            this.numeroMovimentacao = numeroMovimentacao;
            deletMovimentacao();
        }


        public String numeroFechamento;
        private void updateFechamento()
        {


            cmd.CommandText = "Update tab_Fechamento SET PesoBruto = @pesoBruto, PesoLiquido = @pesoliquido, QtBobinas = @qtBobinas WHERE ID = @id";

            cmd.Parameters.AddWithValue("@pesoBruto", pesoBruto);
            cmd.Parameters.AddWithValue("@pesoliquido", pesoLiquido);
            cmd.Parameters.AddWithValue("@qtBobinas", bobinas);
            cmd.Parameters.AddWithValue("@id", numeroFechamento);


            try
            {

                    cmd.Connection = conn.conectar();
                    cmd.ExecuteReader();

                     conn.desconectar();

            }
            catch
            {

            }

        }

        public void updataFech(String numeroFechamento)
        {
            this.numeroFechamento = numeroFechamento;
            updateFechamento();
        }

        public void selecMovimenta(String id)
        {
            this.id = id;
            selectFechamentos();
        }

        public void InsertFechamento(String codigo, String descricao, String pesoBruto, String pesoLiquido, String bobinas, String idTransferencia)
        {
            this.codigo = codigo;
            this.descricao = descricao;
            this.pesoBruto = pesoBruto;
            this.pesoLiquido = pesoLiquido;
            this.bobinas = bobinas;
            this.idTransferencia = idTransferencia;

            insertIntoFechamento();

        }
  

        public String id;
        private String selectIdTransf()
        {
            cmd.CommandText = "Select * from tab_transferencia order by id asc";
            try
            {
                cmd.Connection = conn.conectar();
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    id = dr["id"].ToString();
                }
                conn.desconectar();
            }
            catch
            {

            }
            return id;
        }
        public DataTable dt = new DataTable();

        private void selecTransfenrecias()
        {
            cmd.CommandText = "Select * from tab_Transferencia";
            try
            {
                cmd.Connection = conn.conectar();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(dt);

                conn.desconectar();

            }
            catch
            {

            }
        }

        private void selectMovimentacao()
        {
            cmd.CommandText = "Select * from tab_movimentacao where idTransferencia = @id";
            cmd.Parameters.AddWithValue("@id", id);

            try
            {
                cmd.Connection = conn.conectar();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(dt);

                conn.desconectar();
            }
            catch
            {

            }
        }

        private void selectFechamento() 
        {
            if(cmd.Parameters.Count > 0)
            {
                cmd.Parameters.Clear();
            }

            cmd.CommandText = "Select * from tab_fechamento where IdTransferencia = @id";
            cmd.Parameters.AddWithValue("@id", id);
            try
            {
                cmd.Connection = conn.conectar();
                OleDbDataAdapter da = new OleDbDataAdapter(cmd);

                da.Fill(dt);

                conn.desconectar();

            }
            catch
            {

            }

        }

        private void deleteFechamento()
        {
            cmd.CommandText = "Delete from tab_fechamento where id = @idFechamento";
            cmd.Parameters.AddWithValue("@idFechamento", idFechamento);
            try
            {
                cmd.Connection = conn.conectar();
                cmd.ExecuteReader();

       
            }
            catch(OleDbException e)
            {
                menssagem = e.ToString();
            }
            finally
            {
                conn.desconectar();
            }
        }

        public void deleteFech()
        {
            deleteFechamento();
        }



        public void selectFech(String id)
        {
            this.id = id;
            selectFechamento();

        }

        public void selecTransf(String id)
        {
            selecTransfenrecias();

        }
        public void selectMovi(String id)
        {
            this.id = id;
            selectMovimentacao();
            
        }

        public void insert(DateTime dataHoraTransf,String usuarioTransf)
        {
            this.dataHoraTransf = dataHoraTransf;
            this.usuarioTransf = usuarioTransf;
            

            insertTransferencia(); 
            
        }

        public void insertMovimentacao(String numeroPa,String codigo, String descricao, String pesoBruto, String pesoLiquido, String bobinas, String idTransferencia, String usuarioTransferencia)
        {

            this.numeroPa = numeroPa;
            this.codigo = codigo;
            this.descricao = descricao;
            this.pesoBruto = pesoBruto;
            this.pesoLiquido = pesoLiquido;
            this.bobinas = bobinas;
            this.idTransferencia = idTransferencia;
            this.usuarioTransferencia = usuarioTransferencia;
            insertoMovimentaco();

        }

        public void selectId()
        {
            selectIdTransf();
            
        }



    }
}
