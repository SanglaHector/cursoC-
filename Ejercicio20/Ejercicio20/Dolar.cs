using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
  public class Dolar
  {
    double cantidad;
    static double cotizRespectoDolar;

    #region Constructores

     static Dolar()
    {
      cotizRespectoDolar = 1;
    }

    public Dolar(double cantidad)
    {
      this.cantidad = cantidad;
    }

    public Dolar(double cantidad , double cotizacion)
    {
      this.cantidad = cantidad;
      //this.Dolar();
      cotizRespectoDolar = cotizacion;
    }
    #endregion

    #region getters
    static double GetCotizacion()
    {
      return cotizRespectoDolar;
    }

    public double GetCantidad()
    {
      return this.cantidad;
    }
    #endregion

    #region operadores

    #region Conversores
    static public explicit operator Euro(Dolar d)
    {
      double cantidad;
      cantidad = d.GetCantidad() * 1.16;
      Euro e = new Euro(cantidad, 1.16);
      return e;
    }

    public static implicit operator Dolar (double d)
    {
      Dolar nuevoDolar = new Dolar(d, 1);
      return nuevoDolar;
    }

    static public explicit operator Peso(Dolar d)
    {
      double cantidad;
      cantidad = d.GetCantidad() * 38.33;
      Peso p = new Peso(cantidad, 38.33);
      return p;
    }
    #endregion
    #region Iguales y distintos
    public static  bool operator == (Dolar d , Peso p)
    {
      if( !d.Equals(null) && !p.Equals(null))
      {
        if((Peso)d == p )
        {
          return true;
        }else
        {
          return false;
        }
      }
      else
      {
        return false;
      }
    }

    public static bool operator !=(Dolar d, Peso p)
    {
      return !(d==p);
    }

    public static bool operator ==(Dolar d, Euro e)
    {
      if (!d.Equals(null) && !e.Equals(null))
      {
        if ((Euro)d == e)
        {
          return true;
        }
        else
        {
          return false;
        }
      }
      else
      {
        return false;
      }
    }

    public static bool operator !=(Dolar d, Euro p)
    {
      return !(d == p);
    }
    #endregion
    #region Suma y resta
    public static Dolar operator -(Dolar d,Euro e)
    {
      double cantidad;
      cantidad = d - (Dolar)e;
      Dolar dolares = new Dolar(cantidad, 1);
      return dolares;
    }

    public static Dolar operator -(Dolar d, Peso p)
    {
      double cantidad;
      cantidad = d - (Dolar)p;
      Dolar dolares = new Dolar(cantidad, 1);
      return dolares;
    }

    public static Dolar operator +(Dolar d, Euro e)
    {
      double cantidad;
      cantidad = d + (Dolar)e;
      Dolar dolares = new Dolar(cantidad, 1);
      return dolares;
    }

    public static Dolar operator +(Dolar d, Peso p)
    {
      double cantidad;
      cantidad = d + (Dolar)p;
      Dolar dolares = new Dolar(cantidad, 1);
      return dolares;
    }
    #endregion

    #endregion
  }
}
