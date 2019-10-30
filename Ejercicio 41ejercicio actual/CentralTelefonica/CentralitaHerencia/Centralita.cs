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
                return CalcularGanancia(TipoLLamada.Local);
            }
        }
        public float GananciaPorProvincia
        {
            get
            {
                return CalcularGanancia(TipoLLamada.Provincial);
            }
        }
        public float GananciaPorTotal
        {
            get
            {
                return CalcularGanancia(TipoLLamada.Todas);
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
      listaDeLlamadas = new List<Llamada>();
    }

        public Centralita(string nombreEmpresa)
        {
          listaDeLlamadas = new List<Llamada>();
          razonSocial = nombreEmpresa;
        }
    #endregion
    private float CalcularGanancia(TipoLLamada tipo)
        {
            float ganancia = 0;
            switch(tipo)
            {
                case TipoLLamada.Local:
                    foreach (Llamada item in listaDeLlamadas)
                    {
                        if (item is Local)
                        {
                            ganancia = ganancia + ((Local)item).CostoLlamada;
                        }
                    }
                    return ganancia;
                case TipoLLamada.Provincial:
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
            sb.AppendLine("Ganancia Total       : " + CalcularGanancia(TipoLLamada.Todas));
            sb.AppendLine("Ganancias Local      : " + CalcularGanancia(TipoLLamada.Local));
            sb.AppendLine("Ganancias Provincial : " + CalcularGanancia(TipoLLamada.Provincial));
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
        private void AgregarLlamada(Llamada nuevaLlamada)
        {
            listaDeLlamadas.Add(nuevaLlamada);
        }
        public static bool operator ==(Centralita c , Llamada ll)
        {
            bool retorno = false;
            foreach  (Llamada item in c.Llamadas)
            {
                if(item == ll)
                {
                    retorno = true;
                    break;
                }
            }
            return retorno;
        }
        public static bool operator !=(Centralita c, Llamada ll)
        {
            return !(c == ll);
        }
        public static Centralita operator +(Centralita c, Llamada ll)
        {
            if(c != ll)
            {
                c.AgregarLlamada(ll);
            }else
      {
        throw  new CentralitaException("La llamada ya ha sido registrada", "Llamada", "+");
      }
            return c;
        }
        #endregion

    }
}
