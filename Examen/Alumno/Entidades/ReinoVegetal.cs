using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    abstract public class ReinoVegetal
    {
        // Tipos del enumerado Dulce, Salado, Toxica
        public enum Gusto
        {
            Dulce,
            Salado,
            Toxica
        }
        private static Random calcularValor;
        protected float valor;
        protected Gusto gusto;

        public ReinoVegetal(Gusto gusto)
        {
            //this.valor = calcularValor.Next(1, 100);
            this.gusto = gusto;
        }

        public ReinoVegetal(float valor, Gusto gusto):this(gusto)
        {
            this.valor = valor;
        }
        public static  explicit operator String(ReinoVegetal rv)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Valor: " + rv.valor);
            sb.AppendLine("Gusto: " + rv.gusto);
            return sb.ToString();
        }
        public string Mostrar()
        {
            return (String)this;
        }
        //public ReinoVegetal(Gusto gust)
        //{
        //    int ram = calcularValor.Next(1, 100);
        //    this.gusto = Gusto.Dulce;
        //}
        public static bool operator==(ReinoVegetal rv1 ,ReinoVegetal rv2)
        {
            if(rv1 is Verdura && rv2 is Verdura)
            {
                if(rv1.gusto ==rv2.gusto)
                {
                    return true;
                }
            }
            if (rv1 is Fruta && rv2 is Fruta)
            {
                if (rv1.gusto == rv2.gusto)
                {
                    return true;
                }
            }
            if (rv1 is Carnibora && rv2 is Carnibora)
            {
                if (rv1.gusto == rv2.gusto)
                {
                    return true;
                }
            }
            return false;
        }
        public static bool operator !=(ReinoVegetal rv1, ReinoVegetal rv2)
        {
            return !(rv1 == rv2);
        }
    }
}
