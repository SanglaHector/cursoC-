using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
         
            int contador = 0;
            int numero = 1;
            int acumulador = 0;
            Console.WriteLine("El programa calculara cuatro numeros perferctos...");
           // Console.ReadKey();

            do
            {
                for (int i = 1; i < numero; i++)
                {
                    //Console.WriteLine("i: {0}", i);
                    if (numero % i == 0)
                    {
                       // Console.WriteLine("i: {0}", i);
                        acumulador = acumulador + i;
                    }
                }
                if (acumulador == numero)
                {
                    Console.WriteLine("Numero Perfercto: {0}", numero);
                    contador++;
                }
                else if (acumulador > numero)
                {
                    acumulador = 0;
                }
                acumulador = 0;
                    numero++;
                
            } while (contador != 4);
            Console.ReadLine();

        }
    }
}
