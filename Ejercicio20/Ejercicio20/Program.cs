using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
  class Program
  {
    static void Main(string[] args)
    {
            Peso pesosUno = new Peso(100);
            Dolar dolarUno = new Dolar(1);
            Euro euroUno = new Euro(10);

            pesosUno = pesosUno + dolarUno;

            Console.WriteLine("Cantidad de pesos: {0}", pesosUno.GetCantidad());

            Console.ReadLine();
    }
  }
}
