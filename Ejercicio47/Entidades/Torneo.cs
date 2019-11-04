using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Entidades47
{
    public class Torneo<T> where T : Equipo
    {
        public List<T> equipos;
        string nombre;

        public Torneo(string nombre)
        {
            this.nombre = nombre;
            this.equipos = new List<T>();
        }
    public static  bool operator ==(Equipo e, Torneo<T> t)
    {
      bool retorno = false;
      foreach (Equipo item in t.equipos)
      {
        if(item == e)
        {
          retorno = true;
          break;
        }
      }
      return retorno;
    }
    public static bool operator !=(Equipo e, Torneo<T> t)
    {
      return !(e==t);
    }
    public static bool operator +(Equipo e , Torneo<T> t)
    {
            bool retorno = false;
            if(e!=t)
            {
                t.equipos.Add((T)e);
                retorno = true;
            }
            return retorno;
    }
    public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre del torneo: " + this.nombre);
            sb.AppendLine("Equipos");
            sb.AppendLine("*-----------------------------------------------*");
            foreach (Equipo item in this.equipos)
            {
                sb.AppendLine(item.Ficha());
            }
            return sb.ToString();
        }
        private string CalcularPartido(T t1, T t2)
        {
            StringBuilder sb = new StringBuilder();
            Random goles = new Random();
            string golesUno = goles.Next(1, 5).ToString();
            string golesDos = goles.Next(1, 5).ToString();
            sb.AppendLine("[" + t1.nombre + "][" + golesUno + "] - [" + t2.nombre + "][" + golesDos + "]");
            return sb.ToString();
        }
        public string JugarPartido(T t1 , T t2)
        {
            string resultado;
            Random numero = new Random();
            Equipo equipoUno = t1;//this.equipos[numero.Next(0, this.equipos.Count())];
            Equipo equipoDos = t2;// this.equipos[numero.Next(0, this.equipos.Count())];
            if(equipoUno != equipoDos)
            {
                resultado = this.CalcularPartido((T)equipoUno, (T)equipoDos);
            }
            else
            {
                resultado = "No se puede jugar partidos entre equipos iguales";
            }
            return resultado;
        }
        
  }
}
