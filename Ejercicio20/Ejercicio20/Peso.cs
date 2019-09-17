using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
  public class Peso
  {
    double cantidad;
    static double cotizRespectoDolar;

    #region Constructores

    static Peso()
    {
      cotizRespectoDolar = 0.86;
    }

    public Peso(double cantidad)
    {
      this.cantidad = cantidad;
    }

    public Peso(double cantidad, double cotizacion)
    {
      this.cantidad = cantidad;
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

    #region Conversores
    static public explicit operator Dolar(Euro e)// 0.86
    {
      double cantidad;
      cantidad = e.GetCantidad() * 0.86;
      Dolar d = new Dolar(cantidad, 0.86);
      return d;
    }

    public static implicit operator Euro(double e)
    {
      Euro nuevoEuro = new Euro(e, 1);
      return nuevoEuro;
    }

    static public explicit operator Peso(Euro e)// cualquier numero
    {
      double cantidad;
      cantidad = e.GetCantidad() * 38.33;
      Peso p = new Peso(cantidad, 38.33);
      return p;
    }
    #endregion
  }
}
