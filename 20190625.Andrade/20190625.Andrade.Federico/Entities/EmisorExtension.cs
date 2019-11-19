using System;
using System.Text;
namespace Entities
{
  static class EmisorExtenciones
  {
    static string Mostrar(this EmisorDeEmails emisor)
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(emisor.ToString());
      sb.AppendFormat("-{0}", emisor.Email);
      return sb.ToString();
    }
    static string Mostrar(this EmisorDeWhatsapp emisor)
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(emisor.ToString());
      sb.AppendFormat("-{0}", emisor.NumeroTelefono);
      return sb.ToString();
    }
  }

}
