using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
  class Producto
  {
    #region Atribitos
    private string codigoDeBarra;
    private string marca;
    private float precio;
    #endregion

    #region Constructor

    public Producto(string codigo, string marca, float precio)
    {
      this.codigoDeBarra = codigo;
      this.marca = marca;
      this.precio = precio;
    }

    #endregion

    #region getters
    public string GetMarca()
    {
      return this.marca;
    }

    public float GetPrecio()
    {
      return this.precio;
    }

    #endregion

    #region Metodos
    public static string MostrarProducto(Producto producto)
    {
      string productoFinal;
      string marca = producto.GetMarca();
      string precio = Convert.ToString(producto.GetPrecio());
      productoFinal = String.Concat(marca, ",", precio, ",", producto.codigoDeBarra,"\n");
      return productoFinal;
    }
    #endregion

    #region operadores
    public static explicit operator string (Producto producto)
    {
      return producto.codigoDeBarra;
    }

    public static bool operator ==(Producto productoUno, Producto productoDos)
    {
      if(!(productoUno is null) && (productoDos is null))
      {
        return (productoUno.codigoDeBarra == productoDos.codigoDeBarra);
      }else 
      {
        return !(productoUno.codigoDeBarra == productoDos.codigoDeBarra);
      }
    }

    public static bool operator !=(Producto productoUno, Producto productoDos)
    {
      return !(productoUno.codigoDeBarra == productoDos.codigoDeBarra);
    }
    
    public static bool operator ==(Producto productoUno, string cadena)
    {
      return (productoUno.codigoDeBarra == cadena);
    
    }

    public static bool operator !=(Producto productoUno, string cadena)
    {
      return !(productoUno.codigoDeBarra == cadena);
    }
    #endregion
  }

}

