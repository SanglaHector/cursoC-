using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exepciones
{
    public class DniInvalidoException : Exception
    {
        public DniInvalidoException(): base("DNI invalido.")
        {
        }
    }
}
