using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio31
{
  public class Negocio
  {
    #region Atributos
    private PuestoAtencion caja;
    private Queue<Cliente> clientes;
    private string nombre;

    public Queue<Cliente>Cliente
    {
      get
      {
        return this.clientes;
      }
      set
      {
        this.clientes = value;
      }
    }
    #endregion

    #region Constructores

    private Negocio(string nombre)
    {
      this.caja = PuestoAtencion.Puesto.Caja1;
    }
    #endregion

    #region Operadores
    public static  bool operator ==(Negocio n ,Cliente c)
    {
      bool retorno = false;
      if(!(n.Equals(null)) && !(c.Equals(null)))
      {
        
        foreach (Cliente item in n.clientes)
        {
          if(item.Numero.Equals(c.Numero))
          {
            retorno = true;
          }
        }
       }
      return retorno;
    }

    public static bool operator != (Negocio n , Cliente c)
    {
      return !(n == c);
    }
    public static bool operator ~(Negocio n)
    {
      bool retorno = false;
      if(!(n.Equals(null)))
      {
        PuestoAtencion.Atender(n.Cliente.First);
      }
    }
    }
    #endregion
  }
}
