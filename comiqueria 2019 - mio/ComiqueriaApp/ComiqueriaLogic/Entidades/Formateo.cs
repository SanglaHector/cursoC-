using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComiqueriaLogic.Entidades
{
    public static class Formateo
    {
        public static string FormatearPrecio(this double valor)
        {
            string valorFormateado = valor.ToString();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("$" + valorFormateado);
            return sb.ToString();
        }
        
    }
}
