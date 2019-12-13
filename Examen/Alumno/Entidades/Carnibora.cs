using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Carnibora:ReinoVegetal,IVegetalescs
    {
        public enum Captura
        {
            Pinzas,
            Pelos,
            Caída,
            Mecánicas,
            Combinada
        }
        // Tipos del enumerado: Pinzas, Pelos, Caída, Mecánicas, Combinada
        private Captura tipo;
        private int tamanio;

        public Captura Tipo
        {
            get
            {
                return tipo;
            }
        }
        public int Tamanio
        {
            get
            {
                return tamanio;
            }
        }
        public Carnibora(float valor, Gusto gusto, Captura tipo):base(valor,gusto)
        {
            this.tipo = tipo;
            // Completar
        }

        public Carnibora(float valor, Gusto gusto, Captura tipo, int tamanio):this(valor,gusto,tipo)
        {
            // Completar
            this.tamanio = tamanio;
        }
        public static implicit operator String(Carnibora c)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(c.Mostrar());
            sb.AppendLine("Tipo: " + c.Tipo);
            sb.AppendLine("Tamaño: " + c.Tamanio);
            return sb.ToString();
        }
        public string MostrarDatos()
        {
            return (string)this;
        }

    }
}
