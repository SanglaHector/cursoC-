using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Jugador: Persona
    {
        #region Atributos
        private float altura;
        private float peso;
        private Posicion posicion;
        #endregion
        #region Propiedades
        public float Altura
        {
            get
            {
                return altura;
            }
        }
        public float Peso
        {
            get
            {
                return peso;
            }
        }
        public Posicion Posicion
        {
            get
            {
                return posicion;
            }
        }
        #endregion
        #region Constructores
        public Jugador(string nombre,string apellido, int edad, int dni, float peso, float altura, Posicion posicion): base(nombre, apelido, edad, dni)
        {
            this.peso = peso;
            this.altura = altura;
            this.posicion = posicion;
        }
        #endregion
        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar() + "Peso: " + Peso);
            sb.AppendLine("Altura: " + Altura);
            sb.AppendLine("Posicion: " + Posicion);
            return sb.ToString();
        }
        public bool ValidarEstadoFisico()
        {
            bool retorno = false;
            float IMC = this.Peso /(float)(Math.Pow(this.Altura,2));
            if(IMC >= 18.5 && IMC <= 25 )
            {
                retorno = true;
            }
            return retorno;
        }
        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if(ValidarEstadoFisico() && this.Edad <= 40)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion
    }
}
