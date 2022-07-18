using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Modelo
{
    internal class ultimaTrocaController
    {
        public String ultimaTroca;
        String numeroEmpilhadeira;


        public String buscarUltimaTroca(String numeroEmp)
        {
            DAO.ultimaTrocaDao ultimaTrocaDao = new DAO.ultimaTrocaDao();
            numeroEmpilhadeira = ultimaTrocaDao.buscarUltimaTroca(numeroEmp);
            if (!ultimaTrocaDao.UltimaTroca.Equals(""))
            {
                this.ultimaTroca = ultimaTrocaDao.UltimaTroca;
            }


            return ultimaTroca;
        }
        
    }
}
