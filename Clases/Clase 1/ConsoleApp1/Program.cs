using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int numero;
            Console.WriteLine("Ingrese un numero mayor que cero: ");
            a = Console.ReadLine();
            if (int.TryParse(a, out numero))
            {
                if (numero > 0)
                {
                    Console.WriteLine("El cuadrado de su numero es: {0}\nEl cubo de su numero es: {1}", Math.Pow(numero, 2), Math.Pow(numero, 3));
                    
                }
                else
                {
                    Console.WriteLine("Por favor ingrese un numero mayor que cero!");
                }
            }
            Console.ReadKey();
        }
    }
}
