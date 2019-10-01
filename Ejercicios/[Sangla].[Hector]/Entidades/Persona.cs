using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Persona
    {
        #region Atributos
        private string apellido;
        private int dni;
        private int edad;
        private string nombre;
        #endregion
        #region propiedades
        public string Apellido
        {
            get
            {
                return apellido;
            }
        }
        public string Nombre
        {
            get
            {
                return nombre;
            }
        }
        public int Edad
        {
            get
            {
                return edad;
            }
        }
        public int Dni
        {
            get
            {
                return dni;
            }
        }
        #endregion
        #region Contructores
        public Persona(string nombre, string apellido, int edad, int dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
        }
        #endregion
        #region Metodos
        public virtual string Mostrar()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre: " + this.Nombre);
            sb.AppendLine("Apelido: " + this.Apellido);
            sb.AppendLine("Edad: " + this.Edad);
            sb.AppendLine("Dni: " + this.Edad);
            return sb.ToString();
        }
        public abstract bool ValidarAptitud();
        #endregion
    }
}
