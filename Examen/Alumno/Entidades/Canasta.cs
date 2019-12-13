using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Canasta<T> where T:ReinoVegetal, IVegetalescs
    {
        private List<T> plantas;
        private short capacidad;
            
        public Canasta(short capacidad):this()
        {
            this.capacidad = capacidad;
        }
        public Canasta()
        {
            plantas = new List<T>();
        }
        public static Canasta<T> operator +(Canasta<T> c, ReinoVegetal reinoVegetal)
        {
            if (reinoVegetal is T)
            {
                if (c.plantas.Count < c.capacidad)
                {
                    ReinoVegetal aux = (ReinoVegetal)Convert.ChangeType(reinoVegetal, typeof(T));
                    c.plantas.Add((T)aux);

                    return c;
                }
                else
                {
                    throw new NoAgregaException("Capacidad exedida.");
                    // Lanzar excepción con el mensaje "Capacidad excedida."
                }
            }
            else
            {
                StringBuilder sb = new StringBuilder();
                sb.Append("El elemento es del tipo" + reinoVegetal.GetType() + ". Se esperaba" + typeof(T));
                throw new NoAgregaException(sb.ToString());
                // Lanzar excepción con el mensaje "El elemento es del tipo {0}. Se esperaba {1}."
            }
        }
       
        /* Lógica operador +
            if (reinoVegetal is ...)
            {
                if (c.plantas.Count < c.capacidad)
                {
                    ... aux = (...)Convert.ChangeType(reinoVegetal, typeof(T));
                    c.plantas.Add(aux);

                    return c;
                }
                else
                {
                    // Lanzar excepción con el mensaje "Capacidad excedida."
                }
            }
            else
            {
                // Lanzar excepción con el mensaje "El elemento es del tipo {0}. Se esperaba {1}."
            }
        */

        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Capacidad: " + this.capacidad);
            foreach (T reinoVegetal in this.plantas)
            {
                sb.AppendLine(reinoVegetal.MostrarDatos());
            }
            return sb.ToString();
        }
    }
}
