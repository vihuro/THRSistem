using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo
{
    internal class trocaGasController
    {
        public void insertTrocaGas(String numeroEmp, String ultimaTroca, String trocaAtual, String horasTrabalhadas, DateTime dataHoraTroca, String usuarioTroca)
        {
            DAO.trocaGasDao trocaGasDao = new DAO.trocaGasDao();
            trocaGasDao.insertTrogaGas(numeroEmp,ultimaTroca,trocaAtual,horasTrabalhadas,dataHoraTroca,usuarioTroca);

        }
    }
}
