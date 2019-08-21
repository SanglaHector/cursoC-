using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int numero;
            int acumulador = 0;
            int centrico = 0;

            Console.WriteLine("Ingrese un numero: ");
            a = Console.ReadLine();
            if (int.TryParse(a, out numero))
            {
                for( int i = 1; i < numero; i++)
                {
                    if ( centrico != i)
                    {
                        acumulador = acumulador + i;
                        if(acumulador == (numero / 2))
                        {
                            centrico = i + 1;
                        }
                    }
                }

            }
                
        }
    }
}
