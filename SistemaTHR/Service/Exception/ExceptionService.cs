using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaTHR.Service.Exepction
{
    internal class ExceptionService : Exception
    {
        public ExceptionService(string msg) :base(msg) { 
        }
    }
}
