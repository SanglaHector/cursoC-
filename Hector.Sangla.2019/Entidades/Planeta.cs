using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Planeta : Astro
    {
        private int cantSatelite;
        private Tipo tipo;
        private List<Astro> satelites;

        public List<Astro> Stelites
        {
            get
            {
                return satelites;
            }
        }
        public Planeta(int duracionOrbita, int duracionRotacion, string nombre) : base(duracionOrbita, duracionRotacion, nombre)
        {
        }
        public Planeta(int duracionOrbita, int duracionRotacion, string nombre, int canSatelite, Tipo tipo) : this(duracionRotacion, duracionRotacion, nombre)
        {
            this.cantSatelite = canSatelite;
            this.tipo = tipo;
            this.satelites = new List<Astro>(canSatelite);
        }
        public override string Orbitar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Orbitando planeta: " + (string)(this));
            return sb.ToString();
        }
        public override string Rotar()
        {
            return base.Rotar();
        }
        public override string ToString()
        {
            return base.Mostrar();
        }
        #region Operadores
        public static  bool operator == (Planeta p, Satelite s)
        {
            bool retorno = false;
            if(!p.Equals(null) && !s.Equals(null))
            {
                foreach (Astro item in p.satelites)
                {
                    if (item.ToString() == s.ToString())
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
        public static bool operator !=(Planeta p, Satelite s)
        {
            return !(p == s);
        }
        public static bool operator ==(Planeta planetaUno, Planeta planetaDos)
        {
            bool retorno = false;
            if(planetaUno.ToString() == planetaDos.ToString())
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Planeta planetaUno, Planeta planetaDos)
        {
            return !(planetaUno == planetaDos);
        }
        public static bool operator +(Planeta planeta, Satelite satelite)
        {
            bool retorno = false;
            if(planeta != satelite && planeta.Stelites.Count < planeta.cantSatelite)
            {
                planeta.Stelites.Add(satelite);
                retorno = true;
            }
            return retorno;
        }

        #endregion
    }
}
