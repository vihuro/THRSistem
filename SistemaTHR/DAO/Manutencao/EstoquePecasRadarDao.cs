using SistemaTHR.Service.Exepction;
using System;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.DAO.Manutencao
{
    internal class EstoquePecasRadarDao
    {
        public DataTable EstoquePecas()
        {
            var dt = new DataTable();
            try
            {
                using (var sr = new StreamReader(@"\\192.168.2.137\almoxarifado\F4ALM\ExpAuto_Produtos_Lista_Sistema_Almoxarifado_F4ALM.txt",
                                    Encoding.GetEncoding("ISO-8859-1"), true))
                {
                    var linha = "";
                    var lerLinha = sr.ReadLine();
                    var col = lerLinha.Replace("\"", "").Split(';');

                    for (int i = 0; i < col.Count(); i++)
                    {
                        dt.Columns.Add(col[i], typeof(string));
                    }

                    while ((linha = sr.ReadLine()) != null)
                    {

                        dt.Rows.Add(linha.Replace("\"","").Split(';'));


                    }

                    return dt;
                }
            }
            catch (Exception ex)
            {

                throw new ExceptionService(ex.Message);
            }
        }

    }
}
