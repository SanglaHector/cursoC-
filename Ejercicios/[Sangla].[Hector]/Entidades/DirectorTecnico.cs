using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class DirectorTecnico: Persona
    {
        #region Atributos
        private int añosExperiencia;
        #endregion
        #region Propiedades
        public int AñosExperiencai
        {
            get
            {
                return añosExperiencia;
            }
        }
        #endregion
        #region Constructores
        public DirectorTecnico(string nombre, string apellido, int edad, int dni, int añosExperiencia):base(nombre, apellido, edad, dni)
        {
            this.añosExperiencia = añosExperiencia;
        }
        #endregion
        #region Metodos
        public override string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.Mostrar() + "Años de experiencia: " + AñosExperiencai);
            return sb.ToString();
        }
        public override bool ValidarAptitud()
        {
            bool retorno = false;
            if(this.AñosExperiencai >= 2 && this.Edad < 65)
            {
                retorno = true;
            }
            return retorno;
        }
        #endregion

    }
}
