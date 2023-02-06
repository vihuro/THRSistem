using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SistemaTHR.dto.estoque;
using SistemaTHR.Controller.estoque;
using SistemaTHR.DAO.Estoque;
using System.Data;

namespace SistemaTHR.Service.estoque
{
    internal class MpService
    {
        private MpDao dao = new MpDao();
        private MpDto dto;
        private EstoqueController estoqueController;
        private EstoqueService estoqueService;

        public void ProcurarMp(MpController controller)
        {
            dto = new MpDto();
            estoqueController = new EstoqueController();
            dto.NumeroMP = controller.NumeroMP;
            dao.ProcurandoMp(dto);
            if(dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                if(dto.CodigoMaterial == controller.CodigoMaterial)
                {
                    controller.Exists = true;
                }
                else if (!dto.Exists)
                {
                    controller.Msg = "M.P não localizada!";
                }
                else
                {
                    ValidarCodigo(controller,dto.CodigoMaterial);
                }

            }

        }
        public void ValidarCodigo(MpController controller,string codigo)
        {
            //

            EstoqueAntigoController estoqueAntigo = new EstoqueAntigoController();
            EstoqueAntigoService estoqueAntigoService = new EstoqueAntigoService();
            estoqueAntigo.Codigo = codigo;
            estoqueAntigoService.SelectCodigoAntigo(estoqueAntigo);
            if (estoqueAntigo.Msg != null)
            {
                controller.Msg = estoqueAntigo.Msg;
            }
            else
            {
                if (estoqueAntigo.Exits)
                {
                    foreach(var item in estoqueAntigo.ListaCodigo)
                    {
                        codigo = item;
                    }

                    estoqueController = new EstoqueController();
                    Controller.Login.loginController loginController = new Controller.Login.loginController();
                    estoqueService = new EstoqueService(loginController);
                    estoqueController.CodRef = codigo;
                    estoqueService.FilterCode(estoqueController);

                    if (estoqueController.Msg != null)
                    {
                        controller.Msg = estoqueController.Msg;
                    }
                    else
                    {
                        if (estoqueController.Exits)
                        {
                            for (int i = 0; i < estoqueController.CodigoList.Count; i++)
                            {
                                if (estoqueController.CodigoList[i] == controller.CodigoMaterial)
                                {
                                    controller.CodigoMaterial = estoqueController.CodigoList[i];
                                    controller.Exists = true;
                                    break;
                                }
                                if (i == estoqueController.CodigoList.Count)
                                {
                                    controller.Exists = false;
                                }
                            }

                        }
                    }
                }
            }

        }

    }
}
