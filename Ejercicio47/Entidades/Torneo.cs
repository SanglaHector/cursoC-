using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
  public class Torneo<T> where T : Equipo
  {
    public List<T> equipos;
    string nombre;


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
      re
    }
  }
}
