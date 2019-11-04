using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades47
{
    public abstract class Equipo
    {
        public string nombre;
        public DateTime fechaDeCreacion;

        public Equipo(string nombre, DateTime fecha)
        {
            this.nombre = nombre;
            fechaDeCreacion = fecha;
        }

        public static bool operator ==(Equipo e1, Equipo e2)
        {
            bool retorno = false;
            if(e1.fechaDeCreacion == e2.fechaDeCreacion && e1.nombre == e2.nombre)
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Equipo e1, Equipo e2)
        {
            return !(e1 == e2);
        }
        public string Ficha()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(this.nombre + " fundado el " + this.fechaDeCreacion);
            return sb.ToString();
        }
    }
}
