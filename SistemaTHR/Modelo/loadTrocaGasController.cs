using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo
{
    internal class loadTrocaGasController
    {
        public List<String> empNumero = new List<String>();
        public List<String> ultimaTrocaList = new List<String>();
        public List<String> trocaAtualList = new List<String>();
        public String numeroEmpilhadeira;
        public String ultimaTroca;

        public void numeroEmp()
        {
            DAO.loadTrocasDao loadTrocaGas = new DAO.loadTrocasDao();
            loadTrocaGas.loadTrocas();

            if (!loadTrocaGas.Equals(""))
            {
                this.empNumero = loadTrocaGas.numeroEmp;
                this.ultimaTrocaList = loadTrocaGas.ultimaTrocaList;
                this.trocaAtualList = loadTrocaGas.trocaAtualList;

            }

        }
    }
}
