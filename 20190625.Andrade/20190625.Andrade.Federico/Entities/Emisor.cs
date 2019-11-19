using System;
using System.Xml.Serialization;

namespace Entities
{
  /// <summary>
  /// Product types 
  /// </summary>
  public enum EProducto
  {
    SQLDatabase,
    MonitoringApp,
    AppHosting
  }

  public abstract class Emisor
  {
    private EProducto producto;
    private string mensaje;
    [field:NonSerialized]
    public event EnviarMensajeDelegate eventMensaje;

    [XmlIgnore]
    public EnviarMensajeDelegate EventMensaje
    {
      get { return eventMensaje; }
      set { eventMensaje = value; }
    } 
    public EProducto Producto { get => producto; set => producto = value; }

    public string Mensaje { get => mensaje; set => mensaje = value; }

    public abstract void EnviarMensaje();

    public override string ToString()
    {
      return $"{Mensaje} - {Producto}";
    }

    protected Emisor(string mensaje, EProducto producto)
    {
      this.Mensaje = mensaje;
      this.Producto = producto;
    }

    public Emisor()
    {
    }
  }
}
