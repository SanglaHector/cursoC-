using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio20
{
  public class Euro
  {
    double cantidad;
    static double cotizRespectoDolar;


    #region Constructores

    public Euro()
    {
      this.cantidad = 0;
    }

    public Euro(double cantidad)
    {
      this.cantidad = cantidad;
    }

    public Euro(double cantidad, double cotizacion)
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


  }
}
