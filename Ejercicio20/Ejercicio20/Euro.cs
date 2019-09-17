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

    static Euro()
    {
      cotizRespectoDolar = 1.16;
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
    #region operadores
    #region Conversores
        static public explicit operator Dolar(Euro e)// 0.86
    {
      double cantidad;
      cantidad = e.GetCantidad() / 1.16;
      Dolar d = new Dolar(cantidad, (1/1.16));
      return d;
    }

    public static implicit operator Euro(double e)
    {
      Euro nuevoEuro = new Euro(e, 1);
      return nuevoEuro;
    }

    static public explicit operator Peso(Euro e) // recivo  euros y quiero convertirlos a pesos
    //euro lo convierto a dolar
    //y ese dolar lo convierto a peso y  tengo el equivalente de pesos expresado en dolares.
    {
            Peso p = new Peso(1);
            Dolar d = new Dolar(1);
            d = (Dolar)e;
            p = (Peso)d;
            return p;
    }
        #endregion
    #region Iguales y distintos
        public static bool operator ==(Euro e, Peso p)
        {
            if (!e.Equals(null) && !p.Equals(null))
            {
                if ((Peso)e == p)
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

        public static bool operator !=(Euro e, Peso p)
        {
            return !(e == p);
        }

        public static bool operator ==(Euro e,Dolar d)
        {
            if (!d.Equals(null) && !e.Equals(null))
            {
                if (e == (Euro)d)
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

        public static bool operator !=(Euro e, Dolar d)
        {
            return !(e == d);
        }

        public static bool operator ==(Euro e1, Euro e2)
        {
            if (!e1.Equals(null) && !e2.Equals(null))
            {
                if (e1 == e2)
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
        public static bool operator !=(Euro e1, Euro e2)
        {
            return !(e1 == e2);
        }
        #endregion
    #region Suma y resta
        public static Euro operator -(Euro e, Dolar d)
        {
            double cantidad;
            Euro euroConvertido = (Euro)d;
            cantidad = d.GetCantidad() - euroConvertido.GetCantidad();
            Euro euros = new Euro(cantidad);
            return euros;
        }

        public static Euro operator -(Euro e , Peso p)
        {
            double cantidad;
            Euro euroConvertido = (Euro)p;
            cantidad = p.GetCantidad() - euroConvertido.GetCantidad();
            Euro euros = new Euro(cantidad);
            return euros;
        }

        public static Euro operator +(Euro e, Dolar d)
        {
            double cantidad;
            Euro euroConvertido = (Euro)d;
            cantidad = d.GetCantidad() + euroConvertido.GetCantidad();
            Euro euros = new Euro(cantidad);
            return euros;
        }

        public static Euro operator +(Euro e, Peso p)
        {
            double cantidad;
            Euro euroConvertido = (Euro)p;
            cantidad = p.GetCantidad() - euroConvertido.GetCantidad();
            Euro euros = new Euro(cantidad);
            return euros;
        }
        #endregion
        #endregion

    }
}
