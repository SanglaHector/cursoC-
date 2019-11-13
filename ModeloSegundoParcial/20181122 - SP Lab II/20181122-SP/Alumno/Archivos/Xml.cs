using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Entidades;

namespace Archivos
{
  public class Xml<T>:IArchivo<T> 
  {
    public void Guardar(string archivo, T datos)
    {
      XmlSerializer serial = new XmlSerializer(typeof(T));
      XmlTextWriter writer = new XmlTextWriter(archivo, Encoding.UTF8);
      serial.Serialize(writer, datos);
      writer.Close();
    }
    public void Leer(string archivo, out T datos)
    {
      XmlSerializer serial = new XmlSerializer(typeof(T));
      XmlTextReader reader = new XmlTextReader(archivo);
      datos = (T)serial.Deserialize(reader);
    }
  }
}
