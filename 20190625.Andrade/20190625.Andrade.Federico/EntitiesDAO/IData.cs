using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entities;
namespace Persistencia
{
  public interface IData<T>
  {
    void Guardar(Emisor emisor);
    T Leer();
  } 
}
