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
        public Local(string origen, float duracion, string destino, float costo): base(duracion,destino,origen)
        {
            this.costo = costo;
        }
        public Local(Llamada llamada, float costo):this(llamada.NroOrigen,llamada.Duracion,llamada.NroDestino,costo)
        {
        }

        #endregion
        private float CalcularCosto()
        {
            //       float valor = this.duracion * this.costo;
            float valor = Duracion * CostoLlamada;
            return valor;
        }
        protected override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat(base.Mostrar() + "Valor: " + CostoLlamada);
            return sb.ToString();
        }
        #endregion
        public override bool Equals(object obj)
        {
            bool retorno = false;
            if(obj is Local)
            {
                retorno = true;
            }
            return retorno;
        }
        public override string ToString()
        {
            return this.Mostrar();  
        }
    }
}
