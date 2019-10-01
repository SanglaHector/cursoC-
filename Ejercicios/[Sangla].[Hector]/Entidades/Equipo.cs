using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Equipo
    {
        #region Atributos
        private const int cantidadMaximaJugadores = 6;
        private DirectorTecnico directorTecnico;
        private List<Jugador> jugadores;
        private string nombre;
        #endregion
        #region Propiedades
        public int CantidadMaximaJugadores
        {
            get
            {
                return cantidadMaximaJugadores;
            }
        }
        public DirectorTecnico DirectorTecnico
        {
            //get
            //{
            //    return directorTecnico;
            //}
            set
            {
                if (this.directorTecnico.ValidarAptitud())
                {
                    directorTecnico = value;
                }
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public List<Jugador> Jugadores
        {
            get
            {
                return jugadores;
            }
        }
        #endregion
        #region Constructor
        private Equipo()
        {
            this.jugadores = new List<Jugador>();
        }
        private Equipo(string nombre) : this()
        {
            this.nombre = nombre;
        }
        #endregion
        #region Metodos
        public static bool ValidarEquipo(Equipo e)
        {
            bool retorno = false;
            if(!e.directorTecnico.Equals(null))
            {

            }
        }
        #endregion
        #region Operadores
        public static explicit operator string(Equipo e)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + e.Nombre);
            if (e.directorTecnico.Equals(null))
            {
                sb.AppendLine("Sin DT asignado");
            }
            else
            {
                sb.AppendLine("Nombre: " + e.directorTecnico.Mostrar());
            }
            foreach (Jugador item in e.Jugadores)
            {
                sb.AppendLine(item.Mostrar());
            }
            return sb.ToString();
        }
        public static bool  operator  == (Equipo e, Jugador j)
        {
            bool retorno = false;
            if(!e.Equals(null) && !j.Equals(null))
            {
                foreach (Jugador item in e.Jugadores)
                {
                    if(j.Equals(item))
                    {
                        retorno = true;
                    }
                }
            }
            return retorno;
        }
        public static bool operator !=(Equipo e, Jugador j)
        {
            return !(e == j);
        }
        public static Equipo operator +(Equipo e, Jugador j)
        {
            if(e == j && e.Jugadores.Count < 6 && j.ValidarAptitud())
            {
                e.Jugadores.Add(j);
            }
            return e;
        }
        #endregion
    }
}
