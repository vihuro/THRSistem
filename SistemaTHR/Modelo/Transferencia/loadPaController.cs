using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo
{
    internal class loadPaController
    {
        public String numeroPa;
        public String descricao;
        public String codigo;
        public double pesoBruto;
        public double pesoLiquido;
        public double qtBobinas;

        public void selectPA(String numeroPA)
        {
            DAO.loadPADAO loadPADAO = new DAO.loadPADAO();
            loadPADAO.selectPA(numeroPA);
            this.numeroPa = numeroPA;
            this.descricao = loadPADAO.descricao;
            this.codigo = loadPADAO.codigo;
            this.pesoBruto = loadPADAO.pesoBruto;
            this.pesoLiquido = loadPADAO.pesoLiquido;
            this.qtBobinas = loadPADAO.qtBobinas;
        }

        String PA;

        private void selectPAExped()
        {
            DAO.loadPADAO pADAO = new DAO.loadPADAO();
            pADAO.selecExpedicao(PA);
            this.descricao = pADAO.descricao;
            this.codigo = pADAO.codigo;
            this.pesoBruto = pADAO.pesoBruto;
            this.pesoLiquido = pADAO.pesoLiquido;
            this.qtBobinas = pADAO.qtBobinas;

        }

        public void selectExp(String numeroPa)
        {
            this.PA = numeroPa;
            selectPAExped();
        }
    }
}
