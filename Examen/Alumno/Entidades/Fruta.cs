using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Fruta:ReinoVegetal , IVegetalescs
    {
        private ConsoleColor color;
        public ConsoleColor Color
        {
            get
            {
                return color;
            }
        }

        public Fruta(float valor, Gusto gusto, ConsoleColor color):base(valor,gusto)
        {
            this.color = color;
            // Completar
        }
        public static  implicit operator String(Fruta f)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(f.Mostrar());
            sb.AppendLine("Color: "  + f.Color);
            return sb.ToString();
        }
        public string MostrarDatos()
        {
            return (string)this;
        }
    }
}
