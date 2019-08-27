using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Ejercicio11
    {
        static void Main(string[] args)
        {
            string a;
            int numero;
            int max = 100;
            int min = -100;
            int contador = 0;
            do
            {
                Console.WriteLine("Ingrese un numero entre 100 y -100 ");
                a = Console.ReadLine();
                if (int.TryParse(a, out numero))
                {
                    if(Validacion.Validar(numero,min,max))
                    {
                        contador++;
                    }else
                    {
                        Console.WriteLine("El numero ingresado anteriormente no es correcto. Ingrese otro en su lugar...");
                    }

                }
                else
                {
                    Console.WriteLine("Por favor ingrese un numero");
                }
            }while (contador != 10);
            Console.ReadKey();
        }
    }
}
