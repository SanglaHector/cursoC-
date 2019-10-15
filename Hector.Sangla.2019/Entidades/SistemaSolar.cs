using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class SistemaSolar
    {
        private List<Astro> planetas;
        public List<Astro> Planetas
        {
            get
            {
                return planetas;
            }
        }
        public SistemaSolar()
        {
            this.planetas = new List<Astro>();
        }
        public string MostrarInformacionAstros()
        {
            StringBuilder sb = new StringBuilder();
            foreach (Planeta item in this.Planetas)
            {
                sb.AppendLine(item.ToString());
                //sb.AppendLine(item.Rotar() + item.Orbitar());
                sb.AppendLine("Satelites: ");
  
                foreach  (Satelite s in item.Stelites)
                {
                    sb.AppendLine(s.ToString());
                }
            }
            return sb.ToString();
        }
    }
}
