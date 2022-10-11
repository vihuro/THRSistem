using System;
using System.Collections.Generic;
using System.Data;
using System.Data.OleDb;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.Controller.Producao;
using SistemaTHR.dto.Producao;


namespace SistemaTHR.DAO.Producao
{
    internal class OrdensProducaoDao
    {
        OleDbCommand cmd = new OleDbCommand();
        OleDbDataReader dr;
        Connection con = new Connection();
        OleDbDataAdapter da;




        private OrdensProducaoDto dto = new OrdensProducaoDto();
        public DataTable NovaTable()
        {
            DataTable dt = new DataTable();

            dto.Dt = new DataTable("OrdensProducao");

            dto.Dt.Columns.Add("OpMae", typeof(string));
            dto.Dt.Columns.Add("Chave", typeof(string));
            dto.Dt.Columns.Add("Situação/Prod.", typeof(string));
            dto.Dt.Columns.Add("OrdemProducaoChaveMae", typeof(string));
            dto.Dt.Columns.Add("Cliente", typeof(string));
            dto.Dt.Columns.Add("Nº/Pedido", typeof(string));
            dto.Dt.Columns.Add("Emissão", typeof(string));
            dto.Dt.Columns.Add("Código", typeof(string));
            dto.Dt.Columns.Add("Descrição", typeof(string));
            dto.Dt.Columns.Add("Qtd/Progr.", typeof(string));
            dto.Dt.Columns.Add("Proc.Descrição", typeof(string));
            dto.Dt.Columns.Add("Prev/Ini.", typeof(string));
            dto.Dt.Columns.Add("Prev/Conc.", typeof(string));
            dto.Dt.Columns.Add("Rel/Ini.", typeof(string));
            dto.Dt.Columns.Add("Rel/Conc", typeof(string));
            dto.Dt.Columns.Add("Situação", typeof(string));

            try
            {
                using (var sr = new StreamReader(@"\\192.168.2.137\estoque\testeop.txt", Encoding.GetEncoding("ISO-8859-1"), true))
                {
                    var linha = "";
                    var lerLinha = sr.ReadLine();

                    while ((linha = sr.ReadLine()) != null)
                    {
                        //lerLinha.Replace("\"", "");
                        var col = linha.Replace("\"","").Split('|');

                        dto.Dt.Rows.Add(col);
                    }
                }

                
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
                // MessageBox.Show(ex.ToString());
            }

            return dto.Dt;
        
        }
    }
}
