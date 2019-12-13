using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Verdura:ReinoVegetal,IVegetalescs
    {
        // Tipos del enumerado Semilla, Raíz, Tubérculo, Bulbo, Tallo, Hoja, Inflorescencia, Rizoma
        public enum TipoVerdura
        {
            Semilla,
            Raíz,
            Tubérculo,
            Bulbo,
            Tallo,
            Hoja,
            Inflorescencia,
            Rizoma
        }
        private TipoVerdura tipo;
        public TipoVerdura Tipo
        {
            get
            {
                return tipo;
            }
        }

        public Verdura(float valor, Gusto gusto, TipoVerdura tipo):base(valor,gusto)
        {
            // Completar
            this.tipo = tipo;
        }
        public static implicit operator String(Verdura v)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(v.Mostrar());
            sb.AppendLine("Tipo: " + v.tipo);
            return sb.ToString();
        }
        public string MostrarDatos()
        {
            return (string)this;
        }
    }
}
