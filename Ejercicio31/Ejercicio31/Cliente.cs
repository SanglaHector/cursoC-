using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
  public class Cliente
  {
    #region Atributos
    private string nombre;
    private int numero;
    #region Propiedades
    public string Nombre
    {
      get
      {
        return nombre;
      }
      set
      {
        this.nombre = value;
      }
    }
    public int Numero
    {
      get
      {
        return numero;
      }
    }
    #endregion
    #endregion
    #region Constructores
    public Cliente(int numero)
    {
      this.numero = numero;
    }

    public Cliente(int numero, string nombre)
    {
      this.numero = numero;
      this.Nombre = nombre;
    }
    #endregion
    #region Operadores
    public static  bool operator ==(Cliente c1, Cliente c2)
    {
      if(!c1.Equals(null) || !c2.Equals(null) )
      {
        if(c1.Numero == c2.Numero)
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

    public static bool operator !=(Cliente c1, Cliente c2)
    {
      return !(c1 == c2);
    }
      #endregion
  }
}
