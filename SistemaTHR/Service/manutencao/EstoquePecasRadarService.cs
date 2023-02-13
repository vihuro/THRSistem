using SistemaTHR.DAO.Manutencao;
using SistemaTHR.dto.manutencao;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Service.manutencao
{
    internal class EstoquePecasRadarService
    {
        private EstoquePecasRadarDao dao;
        private EstoquePecasRadarDto dto;
        public EstoquePecasRadarService() 
        {
            dao = new EstoquePecasRadarDao();
        }

        public DataTable Table()
        {
            return dao.EstoquePecas();
        }

        public List<EstoquePecasRadarDto> Verificar(DataTable estoqueRadar, DataTable estoqueTHR)
        {
            int linhas = 0;
            var lista = new List<EstoquePecasRadarDto>();
            for(int i = 0;  i < estoqueRadar.Rows.Count; i++)
            {
                if(estoqueTHR.Rows.Count == 0)
                {
                    lista.AddRange(new[]
{
                            new EstoquePecasRadarDto()
                            {
                                Codigo = estoqueRadar.Rows[i]["Código"].ToString(),
                                Descricao = estoqueRadar.Rows[i]["Nome Produto"].ToString(),
                                Unidade = estoqueRadar.Rows[i]["Un."].ToString()
                            }
                        });
                }
                else
                {
                    for (int j = 0; j < estoqueTHR.Rows.Count; j++)
                    {


                        if (estoqueRadar.Rows[i]["Código"].ToString() == estoqueTHR.Rows[j][1].ToString())
                        {
                            break;
                        }
                        else if (j == estoqueTHR.Rows.Count - 1)
                        {
                            lista.AddRange(new[]
                            {
                            new EstoquePecasRadarDto()
                            {
                                Codigo = estoqueRadar.Rows[i]["Código"].ToString(),
                                Descricao = estoqueRadar.Rows[i]["Nome Produto"].ToString(),
                                Unidade = estoqueRadar.Rows[i]["Un."].ToString()
                            }
                        });
                            break;
                        }
                    }
                }

            }

            return lista;
        }
    }
}
