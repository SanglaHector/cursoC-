using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeraAplicacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string a;
            int numero;
            int minimo = 1000000000;
            int maximo = 0;
            int acumulador = 0;
            float promedio;



            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine("Ingrese un numero: ");
                
                a = Console.ReadLine();
                if(int.TryParse(a,out numero))
                {
                    if( numero >= maximo)
                    {
                        maximo = numero;
                    }
                    if( numero <= minimo)
                    {
                        minimo = numero;
                    }
                    acumulador = acumulador + numero;
                }else
                {
                    Console.WriteLine("Por favor, solo ingrese numeros!");
                }

            }
            promedio = (acumulador / 5);

            Console.WriteLine("El numero maximo es: {0} \nEl numero minimo es: {1}\n Y el promedio es: {2} ", maximo, minimo, promedio);
            Console.ReadKey();
        }
    }
}
