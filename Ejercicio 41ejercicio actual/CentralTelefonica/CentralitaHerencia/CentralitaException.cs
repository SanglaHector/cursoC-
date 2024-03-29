using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
  public class CentralitaException : Exception
  {
    private string nombreClase;
    private string nombreMetodo;
    public string NombreClase
    {
      get
      {
        return nombreClase;
      }
    }
    public string NombreMetodo
    {
      get
      {
        return nombreMetodo;
      }
    }
    public CentralitaException(string mensaje,string clase,string metodo)
    {
      this.nombreClase = clase;
      this.nombreMetodo = metodo;
    }
    public CentralitaException(string mensaje, string clase, string metodo, Exception innerException)
    {

    }
  }
}
