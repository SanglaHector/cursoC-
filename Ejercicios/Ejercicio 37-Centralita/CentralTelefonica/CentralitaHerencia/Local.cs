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
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion
        #region Metodos
        #region Constructor
        public Local(Llamada llamada, float costo):base(llamada.Duracion, llamada.NroDestino, llamada.NroOrigen )
        {
          //  this.duracion = llamada.Duracion;
          //  this.nroDestino = llamada.NroDestino;
          //  this.nroOrigen = llamada.NroOrigen;
            this.costo = costo;
        }
        public Local(string origen, float duracion, string destino, float costo): this(new Llamada(duracion, destino, origen),costo)
        {
        }

        #endregion
        private float CalcularCosto()
        {
            //       float valor = this.duracion * this.costo;
            float valor = Duracion * CostoLlamada;
            return valor;
        }
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar() + "Valor: " + CostoLlamada);
            return sb.ToString();
        }
        #endregion
    }
}
