using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            double numeroDecimal;
            string numeroBinario;
            string a;

            Console.WriteLine("Ingrese un numero decimal: ");
            a = Console.ReadLine();
            numeroDecimal = Convert.ToDouble(a);
            {
                if(numeroDecimal > 0)
                {
                    numeroBinario = Conversor.DecimalToBinari(numeroDecimal);
                    Console.WriteLine("{0}", numeroBinario);

                }else if (numeroDecimal == 0)
                {
                    Console.WriteLine("0");
                }else
                {
                    Console.WriteLine("El programa solo convierte numeros positivos!");
                }
            }


            Console.WriteLine("Ingrese un numero binario; ");
            numeroBinario = Console.ReadLine();

            numeroDecimal = Convert.ToDouble(numeroBinario);
            if (numeroDecimal > 0)
            {
                numeroDecimal = Conversor.BinariToDecimal(numeroBinario);
                Console.WriteLine("{0}", numeroDecimal);
            }else if (numeroDecimal == 0)
            {
                Console.WriteLine("0");
            }else
            {
                Console.WriteLine("El programa solo convierte numeros positivos!");
            }
            Console.ReadKey();

            

        }
    }
}
