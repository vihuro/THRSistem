using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.Controller.Producao;
using SistemaTHR.dto.Producao;
using SistemaTHR.DAO.Producao;
using System.Data;

namespace SistemaTHR.Service.Producao
{
    internal class OrdenProducaoService
    {
        private OrdensProducaoDto dto = new OrdensProducaoDto();
        private OrdensProducaoController controller = new OrdensProducaoController();
        private OrdensProducaoDao dao = new OrdensProducaoDao();

        public DataTable BuscarTable()
        {
            
            return dao.NovaTable();
        }

        public void VerificarLote(OrdensProducaoController controller)
        {
            var table = BuscarTable();

            if(table.Rows.Count > 0)
            {
                controller.Dt = new DataTable();


                var linha = table.Select($"OpMae ='{controller.NumeroOp}' ");
                if(linha.Count() > 0)
                {

                    controller.Dt.Columns.Add("NumeroOp", typeof(string));
                    controller.Dt.Columns.Add("NumeroOpChave", typeof(string));
                    controller.Dt.Columns.Add("OpSituacao", typeof(string));
                    controller.Dt.Columns.Add("OpChaveMae", typeof(string));
                    controller.Dt.Columns.Add("NomeCliente", typeof(string));
                    controller.Dt.Columns.Add("NumeroPedido", typeof(string));
                    controller.Dt.Columns.Add("DataEmissao", typeof(string));
                    controller.Dt.Columns.Add("CodigoMaterial", typeof(string));
                    controller.Dt.Columns.Add("DescricaoMaterial", typeof(string));
                    controller.Dt.Columns.Add("QuantidadeProgramada", typeof(string));
                    controller.Dt.Columns.Add("ProcDescricao", typeof(string));
                    controller.Dt.Columns.Add("PrevisaoInicio", typeof(string));
                    controller.Dt.Columns.Add("PrevisaoConclusao", typeof(string));
                    controller.Dt.Columns.Add("RealizadoInicio", typeof(string));
                    controller.Dt.Columns.Add("RealizadoConclusao", typeof(string));
                    controller.Dt.Columns.Add("ProcSitucao", typeof(string));


                    controller.NumeroOp = linha[0]["OpMae"].ToString();
                    controller.NumeroOpChave = linha[0]["Chave"].ToString();
                    controller.OpSituacao = linha[0]["Situação/Prod."].ToString();
                    controller.OpChaveMae = linha[0]["OrdemProducaoChaveMae"].ToString();
                    controller.NomeCliente = linha[0]["Cliente"].ToString();
                    controller.NumeroPedido = linha[0]["Nº/Pedido"].ToString();
                    controller.DataEmissao = linha[0]["Emissão"].ToString();
                    controller.CodigoMaterial = linha[0]["Código"].ToString();
                    controller.DescricaoMaterial = linha[0]["Descrição"].ToString();
                    controller.QuantidadeProgramada = linha[0]["Qtd/Progr."].ToString();
                    controller.ProcDescricao = linha[0]["Proc.Descrição"].ToString();
                    controller.PrevisaoInicio = linha[0]["Prev/Ini."].ToString();
                    controller.PrevisaoConclusao = linha[0]["Prev/Conc."].ToString();
                    controller.RealizadoInicio = linha[0]["Rel/Ini."].ToString();
                    controller.RealizadoConclusao = linha[0]["Rel/Conc"].ToString();
                    controller.ProcSitucao = linha[0]["Situação"].ToString();


                    controller.Dt.Rows.Add(linha[0]["OpMae"], linha[0]["Chave"], linha[0]["Situação/Prod."],
                        linha[0]["OrdemProducaoChaveMae"], linha[0]["Cliente"], linha[0]["Nº/Pedido"], linha[0]["Emissão"],
                        linha[0]["Código"], linha[0]["Descrição"], linha[0]["Qtd/Progr."], linha[0]["Proc.Descrição"],
                        linha[0]["Prev/Ini."], linha[0]["Prev/Conc."], linha[0]["Rel/Ini."], linha[0]["Rel/Conc"],
                        linha[0]["Situação"]);

                    //controller.Dt = new DataTable();



                    //controller.Dt.Columns.Add("Código", typeof(string));
                    //controller.Dt.Columns.Add("Descrição", typeof(string));


                    // controller.Dt = table;



                }
                else
                {
                    controller.Msg = "Lote não econtrado!";
                }


            }
            else
            {
                controller.Msg = "Table não econtrada";
            }





        }

    }
}
