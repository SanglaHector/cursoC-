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
        public float CostoLlamada
        {
            get
            {
                return CalcularCosto();
            }
        }
        #endregion
        #region Metodos
        #region Constructores
        public Provincial(Franja miFranja, Llamada llamada): base(llamada.Duracion,llamada.NroDestino,llamada.NroOrigen)
        {
            this.duracion = llamada.Duracion;
            this.nroDestino = llamada.NroDestino;
            this.nroOrigen = llamada.NroOrigen;
            this.franjaHoraria = miFranja;
        }
        public Provincial(string origen, Franja miFranja, float duracion, string destino) : this(miFranja , new Llamada(duracion, destino, origen))
        {
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
        #endregion
    }
}
