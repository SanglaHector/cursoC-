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
    #region operadores
    #region Conversores
        static public explicit operator Dolar(Peso p)// 0.86
    {
      double cantidad;
      cantidad = p.GetCantidad() / 38.33;
      Dolar d = new Dolar(cantidad, 1);
      return d;
    }

    public static implicit operator Euro(Peso p)
    {
        Dolar d = new Dolar(1);
        Euro e = new Euro(1);
        d = (Dolar)p;
        e = (Euro)d;
        return e;
    }

    public static implicit operator Peso(double p)
    {
        Peso nuevoPeso = new Peso(p, 1);
        return nuevoPeso;
    }
        #endregion
    #region Suma y resta
        public static Peso operator -(Peso p, Euro e)
        {
            double cantidad;
            Peso pesoConvertido = (Peso)e;
            cantidad = p.GetCantidad() - pesoConvertido.GetCantidad();
            Peso pesos = new Peso(cantidad);
            return pesos;
        }

        public static Peso operator +(Peso p, Euro e)
        {
            double cantidad;
            Peso pesoConvertido = (Peso)e;
            cantidad = p.GetCantidad() + pesoConvertido.GetCantidad();
            Peso pesos = new Peso(cantidad);
            return pesos;
        }

        public static Peso operator -(Peso p, Dolar d)
        {
            double cantidad;
            Peso pesoConvertido = (Peso)d;
            cantidad = p.GetCantidad() - pesoConvertido.GetCantidad();
            Peso pesos = new Peso(cantidad);
            return pesos;
        }

        public static Peso operator +(Peso p, Dolar d)
        {
            double cantidad;
            Peso pesoConvertido = (Peso)d;
            cantidad = p.GetCantidad() + pesoConvertido.GetCantidad();
            Peso pesos = new Peso(cantidad);
            return pesos;
        }
        #endregion
    #region Iguales y distintos
        public static bool operator ==(Peso p, Euro e)
        {
            if (!p.Equals(null) && !e.Equals(null))
            {
                if (p ==  (Peso)e)
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

        public static bool operator !=(Peso p, Euro e)
        {
            return !(p == e);
        }

        public static bool operator ==(Peso p, Dolar d)
        {
            if (!p.Equals(null) && !d.Equals(null))
            {
                if (p == (Peso)d)
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

        public static bool operator !=(Peso p, Dolar d)
        {
            return !(p == d);
        }

        public static bool operator ==(Peso p1, Peso p2)
        {
            if (!p1.Equals(null) && !p2.Equals(null))
            {
                if (p1 == p2)
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
        public static bool operator !=(Peso p1, Peso p2)
        {
            return !(p1 == p2);
        }
        #endregion
        #endregion
    }
}
