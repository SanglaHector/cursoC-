using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Ejercicio31
{
  public class PuestoAtencion
  {
    public enum Puesto
    {
      Caja1,
      Caja2
    }
    #region Atributros
    private static int numeroActual;
    private Puesto puesto;

    #endregion
    #region Propiedades
    public static int  NumeroActual
    {
      get
      {
        return (numeroActual + 1);
      }
    }
    #endregion
    #region Contructores
    public PuestoAtencion()
    {
      numeroActual = 0;
    }
    public PuestoAtencion(Puesto puesto)
    {
      this.puesto = puesto;
    }
    #endregion
    #region Metodos
    public bool Atender(Cliente cli)
    {
      if(!(cli.Equals(null)))
      {
        Thread.Sleep(100);
        return true;
      }
      else
      {
        return false;
      }
    }
    #endregion
  }
}
