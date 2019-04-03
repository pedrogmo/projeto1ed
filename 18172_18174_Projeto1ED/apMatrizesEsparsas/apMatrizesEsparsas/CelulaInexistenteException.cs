using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace apMatrizesEsparsas
{
    class CelulaInexistenteException : Exception
    {
        public CelulaInexistenteException(string msg) : base(msg) { }
    }
}
