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
            string a;
            int numero;
            Console.WriteLine("Ingrese un numero: ");
            a = Console.ReadLine();
            if(int.TryParse( a,out numero))
            {
                for( int i = 0; i < numero; i++)
                {
                    if (i % 2 != 0  || i % 3 != 0) 
                    {
                        Console.WriteLine("Numero Primo: {0}", i);
                    }
                }
            }
            Console.ReadKey();
        }
    }
}
