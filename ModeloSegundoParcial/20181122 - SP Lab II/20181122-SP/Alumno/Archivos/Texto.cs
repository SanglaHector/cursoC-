using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entidades;

namespace Archivos
{
  public class Texto: IArchivo<Queue<Patente>> 
  {
    public void Guardar(string archivo, Queue<Patente> datos)
    {
      // la ruta por defecto( si es que no le pongo una ruta) es el source donde esta el proyecto
      // 
      StreamWriter writer = new StreamWriter(archivo);
      foreach (Patente item in datos)
      {
        writer.Write(item.CodigoPatente);
      }
      writer.Close();
    }
    public void Leer(string archivo, out Queue<Patente> datos)
    {
      StreamReader reader = new StreamReader(archivo);
      Queue<Patente> patentes = new Queue<Patente>();
      while(!reader.EndOfStream)
      {
                // aqui se valida si la patente es mercosur o vieja
                try
                {
                    Patente patente = new Patente(reader.ReadLine(), Patente.Tipo.Mercosur);
                    patentes.Enqueue(patente);
                }
                catch ( PatenteInvalidaException ex)
                {

                }
      }
      datos = patentes;
    }
  }
}
