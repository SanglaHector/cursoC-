using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Repaso
{
  class Estante
  {
    #region Atributos
    private int ubicacion;
    private Producto[] productos;
    #endregion


    #region Contructor
    private Estante(Producto[] listaDeProductos)
    {
      this.productos = listaDeProductos;
    }

    public Estante(Producto[] listaDeProductos, int capacidad, int ubicacion): this (listaDeProductos)
    {
      this.productos = new Producto[capacidad];
      this.ubicacion = ubicacion;
    }

    #endregion

    #region Getters
    public Producto[] GetProductos()
    {
      return this.productos;
    }
    #endregion

    #region Metodos
    public static  string MostrarEstante(Estante estante)
    {
      string estanteFinal;
      Producto[] productos = estante.GetProductos();

      estanteFinal = String.Concat(estante.ubicacion);
      foreach(Producto  i in  productos)
      {
        estanteFinal = String.Concat(Producto.MostrarProducto(i));
      }
      return estanteFinal;
    }
    #endregion

    #region Operadores

    public static bool operator ==(Producto producto, Estante estante)
    {
      if (estante != null && !(producto is null))
      {

        foreach (Producto prod in estante.productos)
        {
          if (prod == producto)
          {
            return true;
          }
        } 
      }
      return false;
    }

    public static bool operator !=(Producto producto, Estante estante)
    {
      return !(producto == estante);
    }

    public static bool operator +(Producto producto, Estante estante)
    {
 
      if ( producto!=estante )
      {
        foreach(Producto prod in estante.productos)
        {
          if(prod is null)
          {
            prod = producto;
          }
        }
      }

    }
    #endregion

  }
}
//p1.Equals(p2);
//Object.ReferenceEquals(p1,p2);
//pi is null
//p2 is null
