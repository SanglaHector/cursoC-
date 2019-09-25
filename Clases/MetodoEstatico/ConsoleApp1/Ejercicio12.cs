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
            char continuar = 'N';
            string a;
            int x;
            int suma = 0;
            int numero;

            do
            {
                Console.ReadLine();
                Console.WriteLine("Ingrese un numero que quiera sumar");
                a = Console.ReadLine();
                if(int.TryParse(a,out numero))
                {
                    suma = suma + numero;
                    Console.WriteLine("ingrese S si desea continua o N si no lo desea: ");
                    x = Console.Read();
                    continuar = Convert.ToChar(x);
                }else
                {
                    Console.WriteLine("ingrese S si desea continua o N si no lo desea: ");
                    x = Console.Read();
                }
            } while (Validar.ValidaS_N(continuar));
        }
    }
}
