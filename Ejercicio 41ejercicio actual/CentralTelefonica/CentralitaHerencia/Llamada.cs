using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public abstract class Llamada
    {
        #region Atributos
        protected float duracion;
        protected string nroDestino;
        protected string nroOrigen;
        #endregion
        #region Propiedades
        public float Duracion
        {
            get
            {
                return duracion;
            }
        }
        public abstract float CostoLlamada { get; }
        public string NroDestino
        {
            get
            {
                return nroDestino;
            }
        }
        public string NroOrigen
        {
            get
            {
                return nroOrigen;
            }
        }
        #endregion
        #region Enumerado
        public enum TipoLLamada
        {
            Local,
            Provincial,
            Todas
        }
        #endregion
        #region Metodos
        #region Contructores
        public Llamada(float duracion, string nroDestino,string nroOrigen)
        {
            this.duracion = duracion;
            this.nroDestino = nroDestino;
            this.nroOrigen = nroOrigen;
        }
        #endregion
        public int OrdenarPorDuracion(Llamada llamada1, Llamada llamada2)
        {
            int retorno =  0;
            if (llamada1.Duracion > llamada2.Duracion)
            {
                retorno = 1;
            }
            else if (llamada1.Duracion < llamada2.Duracion)
            {
                retorno = 2;
            }
            return retorno;
        }
        protected virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Duracion      : " + Duracion);
            sb.AppendLine("Numero Destino: " + NroDestino);
            sb.AppendLine("Numero Origen : " + NroOrigen);
            return sb.ToString();
        }
        #endregion
        public static bool operator ==(Llamada l1 , Llamada l2)
        {
            bool retorno = false;
            if(l1.Equals(l2) && l1.NroDestino == l2.NroDestino && l1.NroOrigen == l2.NroOrigen )
            {
                retorno = true;
            }
            return retorno;
        }
        public static bool operator !=(Llamada l1, Llamada l2)
        {
            return !(l1 == l2);
        }
    }
}
