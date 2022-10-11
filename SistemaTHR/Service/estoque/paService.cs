using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Service.estoque
{
    internal class paEstoqueService
    {
        private Controller.estoque.paController controller;
        private dto.estoque.paDto dto;
        private DAO.Estoque.PaDao dao = new DAO.Estoque.PaDao();

        private void selectPaEstoque()
        {
            dto = new dto.estoque.paDto();
            dto.NumeroPa = controller.NumeroPa;
            dao.PaEstoque(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Codigo = dto.Codigo;
                controller.Descricao = dto.Descricao;
                controller.PesoBruto = dto.PesoBruto;
                controller.PesoLiquido = dto.PesoLiquido;
                controller.Bobinas = dto.Bobinas;
            }
        }

        public void VerificarCodigoPa(Controller.estoque.paController controller)
        {
            dto = new dto.estoque.paDto();
            dto.NumeroPa = controller.NumeroPa;
            dao.PaEstoque(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else if (controller.Codigo == dto.Codigo)
            {
                controller.Codigo = dto.Codigo;
                controller.Descricao = dto.Descricao;
                controller.PesoBruto = dto.PesoBruto;
                controller.PesoLiquido = dto.PesoLiquido;
                controller.Bobinas = dto.Bobinas;
            }
            else
            {
                dao.PaExpedicao(dto);
                if (dto.Msg != null)
                {
                    controller.Msg = dto.Msg;
                }
                else if (controller.Codigo == dto.Codigo)
                {
                    controller.Codigo = dto.Codigo;
                    controller.Descricao = dto.Descricao;
                    controller.PesoBruto = dto.PesoBruto;
                    controller.PesoLiquido = dto.PesoLiquido;
                    controller.Bobinas = dto.Bobinas;
                }
                else
                {
                    controller.Msg = "Código não correspondente!";
                }

            }
        }

        public void PaEstoque(Controller.estoque.paController controller)
        {
            this.controller = controller;
            selectPaEstoque();
        }

        private void selectPaExpedicao()
        {
            dto = new dto.estoque.paDto();
            dto.NumeroPa = controller.NumeroPa;
            dao.PaExpedicao(dto);
            if (dto.Msg != null)
            {
                controller.Msg = dto.Msg;
            }
            else
            {
                controller.Codigo = dto.Codigo;
                controller.Descricao = dto.Descricao;
                controller.PesoBruto = dto.PesoBruto;
                controller.PesoLiquido = dto.PesoLiquido;
                controller.Bobinas = dto.Bobinas;
            }
        }

        public void PaExpedicao(Controller.estoque.paController controller)
        {
            this.controller = controller;
            selectPaExpedicao();
        }
    }
}
