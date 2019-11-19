using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;
using System.Xml;
using Entities;
namespace Persistencia
{
  public class WhatsappXml : IData<IEnumerable<EmisorDeWhatsapp>>
  {
    private readonly string path;

    /// <summary>
    /// Le asigna un valor al path.
    /// </summary>
    public WhatsappXml()
    {
      path = String.Format("{0}\\{1}", (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)), "WhatssappTexto.xml");
    }

    public void Guardar(Emisor emisor)
    {
      XmlTextWriter xml = new XmlTextWriter(path, UTF8Encoding.UTF8);
      XmlSerializer ser = new XmlSerializer(typeof(IEnumerable<EmisorDeWhatsapp>));
      try
      {
        ser.Serialize(xml, emisor);
      }
      catch (Exception)
      {

        throw;
      }
      finally
      {
        xml.Close();
      }
    }

    public IEnumerable<EmisorDeWhatsapp> Leer()
    {
      XmlTextReader xml = new XmlTextReader(path);
      XmlSerializer ser = new XmlSerializer(typeof(EmisorDeWhatsapp));
      IEnumerable<EmisorDeWhatsapp> iEmisor;
      try
      {
        iEmisor = (IEnumerable<EmisorDeWhatsapp>)ser.Deserialize(xml);
        return iEmisor;
      }
      catch (Exception)
      {

        throw;
      }
      finally
      {
        xml.Close();
      }
    }
  }
}
