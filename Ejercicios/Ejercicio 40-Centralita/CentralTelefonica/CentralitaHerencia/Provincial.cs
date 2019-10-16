using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CentralitaHerencia
{
    public class Provincial : Llamada
    {
        #region Atributos
        public enum Franja
        {
            Franja_1,
            Franja_2,
            Franja_3
        }
        private Franja franjaHoraria;
        #endregion
        #region Propiedades
        public override float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion
        #region Metodos
        #region Constructores
        public Provincial(Franja miFranja, Llamada llamada): this(llamada.NroOrigen,miFranja,llamada.Duracion, llamada.NroDestino)
        {
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) : base(duracion,destino,origen)
        {
            this.franjaHoraria = miFranja;
        }
        #endregion
        private float CalcularCosto()
        {
            switch (this.franjaHoraria)
            {
                case Franja.Franja_1:
                    return duracion * (float)(0.99);
                case Franja.Franja_2:
                    return duracion * (float)(1.25);
                case Franja.Franja_3:
                    return duracion * (float)(0.66);
                default:
                    return 0;
            }
        }
    protected override string Mostrar()
    {
      StringBuilder sb = new StringBuilder();
      sb.AppendLine(base.Mostrar() + "Franja horaria: " + this.franjaHoraria + "Costo Llamada: " + this.CostoLlamada);
      return sb.ToString();
    }
    public override bool Equals(Object obj)
    {
      if(obj is Provincial)
      {
        return true;
      }else
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
