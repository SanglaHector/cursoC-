using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Ejercicio14
    {
        static void Main(string[] args)
        {
            string input;
            float altura;
            float largo;
            float radio;
            float area;
            bool flag = false;

            do
            {
                Console.ReadLine();
                Console.WriteLine("Ingrese una altura: ");
                input = Console.ReadLine();
                if(float.TryParse(input, out altura) && altura > 0)
                {
                    flag = true;
                }
            } while (!flag);
            
            do
            {
                Console.ReadLine();
                Console.WriteLine("Ingrese un largo: ");
                input = Console.ReadLine();
                if (float.TryParse(input, out largo) && largo > 0)
                {
                    flag = true;
                }
            } while (!flag);

            do
            {
                Console.ReadLine();
                Console.WriteLine("Ingrese un radio: ");
                input = Console.ReadLine();
                if (float.TryParse(input, out radio) && radio > 0)
                {
                    flag = true;
                }
            } while (!flag);

            area = CalculoDeArea.CalculoCuadrado(altura, largo);
            Console.WriteLine("El area de su cuadrado es de: {0}", area);

            area = CalculoDeArea.CalculoTriangulo(altura, largo);
            Console.WriteLine("El area de su triangulo es de: {0}", area);

            area = CalculoDeArea.CalculoCirculo(radio);
            Console.WriteLine("El area de su circulo es de: {0}", area);

            Console.ReadLine();
        }
    }
}
