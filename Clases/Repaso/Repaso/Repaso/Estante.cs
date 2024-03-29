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

    // public Estante(Producto[] listaDeProductos, int capacidad, int ubicacion): this (listaDeProductos)
    // {
    //  this.productos = new Producto[capacidad];
    //  this.ubicacion = ubicacion;
    //}
    public Estante( int capacidad, int ubicacion)
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
        estanteFinal = String.Concat(estanteFinal,Producto.MostrarProducto(i));
      }
      return estanteFinal;
    }
    #endregion

    #region Operadores

    public static bool operator ==(Producto producto, Estante estante)
    {
      if (estante != null || !(producto is null))
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

    public static bool operator +(Estante estante,Producto producto)
    {
 
      if ( producto!=estante )
      {
        for ( int i = 0; i < estante.productos.Length; i++)
        {
          if(estante.productos[i] is null)
          {
            estante.productos[i] = producto;
            return true;
          }
        }
      }
      return false;
    }

    public static Estante operator -(Estante estante, Producto producto)
    {
      if(producto == estante)
      {
        for (int i = 0; i < estante.productos.Length; i++)
        {
          if (estante.productos[i] == producto)
          {
            estante.productos[i] = null;
            return estante;
          }
        }
      }
      return estante;
    }
      #endregion
    }
}

