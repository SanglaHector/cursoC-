using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Centralita
    {
        #region Atributos
        private List<Llamada> listaDeLlamadas;
        private string razonSocial;
        #endregion
        #region Propiedades
        public float GananciaPorLocal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLLamada.Local);
            }
        }
        public float GananciaPorProvincia
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLLamada.Provincial);
            }
        }
        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(Llamada.TipoLLamada.Todas);
            }
        }
        public List<Llamada>Llamadas
        {
            get
            {
                return listaDeLlamadas;   
            }
        }
    #endregion
    #region Metodos
    #region Contructores
        public Centralita()
        {
        }

        public Centralita(string nombreEmpresa)
        {
          listaDeLlamadas = new List<Llamada>();
          razonSocial = nombreEmpresa;
        }
    #endregion
    private float CalcularGanancia(Llamada.TipoLLamada tipo)
        {
            float ganancia = 0;
            switch(tipo)
            {
                case Llamada.TipoLLamada.Local:
                    foreach (Llamada item in listaDeLlamadas)
                    {
                        if (item is Local)
                        {
                            ganancia = ganancia + ((Local)item).CostoLlamada;
                        }
                    }
                    return ganancia;
                case Llamada.TipoLLamada.Provincial:
                    foreach (Llamada item in listaDeLlamadas)
                    {
                        if (item is Provincial)
                        {
                            ganancia = ganancia + ((Provincial)item).CostoLlamada;
                        }
                    }
                    return ganancia;
                default:
                    foreach (Llamada ll in Llamadas)
                    {
                        if (ll is Local)
                        {
                            Local aux = (Local)ll;
                            ganancia += aux.CostoLlamada;
                        }
                        else
                        {
                            Provincial aux = (Provincial)ll;
                            ganancia += aux.CostoLlamada;
                        }
                    }
                    return ganancia;
            }
        }
        public string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("*****************************************************");
            sb.AppendLine("Razon social         : " + this.razonSocial);
            sb.AppendLine("Ganancia Total       : " + CalcularGanancia(Llamada.TipoLLamada.Todas));
            sb.AppendLine("Ganancias Local      : " + CalcularGanancia(Llamada.TipoLLamada.Local));
            sb.AppendLine("Ganancias Provincial : " + CalcularGanancia(Llamada.TipoLLamada.Provincial));
            sb.AppendLine("*****************************************************");
            foreach (Llamada llamada in listaDeLlamadas)
            {
                if (llamada is Local)
                    sb.AppendLine(((Local)llamada).ToString());
                else
                    sb.AppendLine(((Provincial)llamada).ToString());
            }
            return sb.ToString();
        }

    private void AgregarLlamada(Llamada l1)
    {
      this.listaDeLlamadas.Add(l1);
    }
    public static bool operator ==(Centralita c, Llamada llamada)
    {
      bool retorno = false;
      foreach (Llamada item in c.listaDeLlamadas)
      {
        if(item == llamada && item.Equals(llamada))
        {
          retorno = true;
          break;
        }
      }
      return retorno;
    }
    public static bool operator !=(Centralita c, Llamada llamada)
    {
      return !(c == llamada);
    }
    public static Centralita operator +(Centralita c, Llamada nuevaLlamada)
    {
      if (c != nuevaLlamada)
      {
        c.AgregarLlamada(nuevaLlamada);
      }
      return c;
    }
    #endregion

  }
}
