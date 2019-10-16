using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Local: Llamada
    {
        #region Atribuos
        public float costo;
        #endregion
        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return costo;
            }
        }
        #endregion
        #region Metodos
        #region Constructor
        public Local(Llamada llamada, float costo):this(llamada.NroOrigen, llamada.Duracion, llamada.NroDestino, costo )
        {
        }
        public Local(string origen, float duracion, string destino, float costo): base(duracion, destino, origen)
        {
          this.costo = costo;
        }

    #endregion
    private float CalcularCosto()
        {
            float valor = Duracion * CostoLlamada;
            return valor;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar() + "Valor: " + CostoLlamada);
            return sb.ToString();
        }
    public override bool Equals(object obj)
    {
      if(obj is Local)
      {
        return true;
      }
      else
      {
        return false;
      }
    }
    public override string ToString()
    {
      return this.Mostrar();
    }
    #endregion
  }
}
