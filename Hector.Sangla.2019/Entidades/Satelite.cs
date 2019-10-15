using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Satelite : Astro
    {
        public string Nombre
        {
            get
            {
                return (string)this;
            }
        }
        public Satelite(int duracionOrbita, int duracionRotacion, string nombre):base(duracionOrbita,duracionRotacion,nombre)
        { 
        }
        public override string Orbitar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Orbitando planeta: " + (string)(this));
            return sb.ToString();
        }
        public override string ToString()
        {
            return base.Mostrar();
        }
    }
}
