using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
     public static class Conversor
    {
        public static string  DecimalToBinari(double numero)
        {

            String cadena = "";
            if (numero > 0)
            {
                while (numero > 0)
                {
                    if (numero % 2 == 0)
                    {
                        cadena = "0" + cadena;
                    }
                    else
                    {
                        cadena = "1" + cadena;
                    }
                    numero = (int)(numero / 2);
                }
            }
                return cadena;
        }

        public static double BinariToDecimal(string numero)
        {
            // double numeroDecimal;
            // numeroDecimal = Convert.ToInt32(numero);
            // return numeroDecimal;
            char[] array = numero.ToCharArray();
            // Invertido pues los valores van incrementandose de derecha a izquierda: 16-8-4-2-1
            Array.Reverse(array);
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] == '1')
                {
                    // Usamos la potencia de 2, según la posición
                    sum += (int)Math.Pow(2, i);
                }
            }

            return sum;
        }

    }
}
