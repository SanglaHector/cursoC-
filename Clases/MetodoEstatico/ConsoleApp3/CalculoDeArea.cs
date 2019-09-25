using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    public static class CalculoDeArea
    {
        public static float CalculoCuadrado (float altura, float largo )
        {
            float area = 0;
            if(altura > 0 && largo > 0 )
            {
                area = altura * largo;
            }
            return area;
        }

        public static float CalculoTriangulo(float altura, float largo)
        {
            float area = CalculoDeArea.CalculoCuadrado(altura, largo) / 2;
            return area;
        }

        public static float CalculoCirculo (float radio)
        {
            float area;
            float pi =Convert.ToSingle(Math.PI);


            area = radio * Convert.ToSingle(Math.Pow(pi, 2));
            return area;
        }
    }
}
