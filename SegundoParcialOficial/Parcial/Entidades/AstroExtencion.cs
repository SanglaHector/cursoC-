using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class AstroExtencion
    {
        public static bool GuardarPlanTxt(this Planeta<Satelite> plan )
        {
            return true;
        }
        public static bool GuardarXML(this Satelite sat)
        {
            return true;
        }
    }
}
