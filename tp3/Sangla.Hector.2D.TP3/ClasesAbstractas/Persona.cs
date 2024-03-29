﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        private string apellido;
        private int dni;
        private string nombre;
        private ENacionalidad nacionalidad;

        public enum ENacionalidad
        {
            Argentino,
            Extranjero
        }
        #region Propiedades
        public string Nombre
        {
            get
            {
                return nombre;
            }
            set
            {
                nombre = ValidarNombreApellido(value);
            }
        }
        public string Apellido
        {
            get
            {
                return apellido;
            }
            set
            {
                apellido = ValidarNombreApellido(value);
            }
        }
        public ENacionalidad Nacionalidad
        {
            get
            {
                return nacionalidad;
            }
            set
            {
                nacionalidad = value;
            }
        }
        public int DNI
        {
            get
            {
                return dni;
            }
            set
            {
                dni = ValidarDni(nacionalidad,value);
            }
        }
        public string StringToDNI
        {
            set
            {
                int.TryParse(value,out dni);
            }
        }
        #endregion
        #region Constructores
        public Persona()
        {
            this.nombre = "";
            this.apellido = "";
            this.dni = 00000000;
            this.nacionalidad = ENacionalidad.Argentino;
        }
        public Persona(string nombre, string apellido,ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
            this.dni = 00000000;
        }
        public Persona(string nombre, string apellido,int dni, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
            this.dni = dni;
        }
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.nacionalidad = nacionalidad;
            StringToDNI = dni;
        }
        #endregion
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Nombre completo: " + Apellido + ", " + Nombre);
            sb.AppendLine("Nacionalidad: " + Nacionalidad.ToString());
            sb.AppendLine("DNI: " + DNI);
            return sb.ToString();
        }
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            int dni;
            if(nacionalidad == ENacionalidad.Argentino && (dato > 0 && dato < 90000000))
            {
                dni = dato;
            }else if(nacionalidad == ENacionalidad.Extranjero && (dato >= 90000000 && dato < 100000000))
            {
                dni = dato;
            }
            else
            {
                dni = 0;
            }
            return dni;
        }
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
            int dni;
            int datoAuxiliar;
            if(int.TryParse(dato, out datoAuxiliar))
            {
                if (nacionalidad == ENacionalidad.Argentino && (datoAuxiliar > 0 && datoAuxiliar < 90000000))
                {
                    dni = datoAuxiliar;
                }
                else if (nacionalidad == ENacionalidad.Extranjero && (datoAuxiliar >= 90000000 && datoAuxiliar < 100000000))
                {
                    dni = datoAuxiliar;
                }
            }
            else
            {
                dni = 0;
            }
            return datoAuxiliar;
        }
        private string ValidarNombreApellido(string dato)
        {
            string retorno;
            if (Regex.IsMatch(dato, @"^[a-zA-Z]+$") && (dato.Length < 0))
            {
                retorno = dato;
            }
            else
            {
                retorno = "";
            }
            return retorno;
        }
    }
}
