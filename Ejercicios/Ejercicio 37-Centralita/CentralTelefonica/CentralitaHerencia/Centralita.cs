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
                float ganancia = 0;
                foreach (Llamada item in listaDeLlamadas)
                {
                    if (item is Local)
                    {
                        ganancia = ganancia + ((Local)item).CostoLlamada;
                    }
                }
                return ganancia;
            }
        }
        public float GananciaPorProvincia
        {
            get
            {
                float ganancia = 0;
                foreach (Llamada item in listaDeLlamadas)
                {
                    if(item is Provincial)
                    {
                        ganancia = ganancia + ((Provincial)item).CostoLlamada;
                    }
                }
                return ganancia;
            }
        }
        public float GananciaPorTotal
        {
            get
            {
                return (GananciaPorProvincia + GananciaPorLocal);
            }
        }
        public List<Llamada>Llamadas
        {
            get
            {
                return this.listaDeLlamadas;
            }
        }
        #endregion
        #region Metodos
        #region Contructores
        public Centralita()
        {
            this.listaDeLlamadas = new List<Llamada>();
            this.razonSocial = "";
        }
        public Centralita(string nombreEmpresa)
        {
            this.razonSocial = nombreEmpresa;
        }
        #endregion
        private float CalcularGanancia(Llamada.TipoLLamada tipo)
        {
            switch(tipo)
            {
                case Llamada.TipoLLamada.Local:
                    return this.GananciaPorLocal;
                case Llamada.TipoLLamada.Provincial:
                    return this.GananciaPorProvincia;
                case Llamada.TipoLLamada.Todas:
                    return this.GananciaPorTotal;
                default:
                    return 0;
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
                    sb.AppendLine(((Local)llamada).Mostrar());
                else
                    sb.AppendLine(((Provincial)llamada).Mostrar());
            }
            return sb.ToString();
        }
        #endregion

    }
}
