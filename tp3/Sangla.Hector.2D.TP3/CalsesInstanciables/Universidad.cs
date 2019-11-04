using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClasesInstanciables
{
    public class Universidad
    {
        private List<Alumno> alumnos;
        private List<Profesor> profesores;
        private List<Jornada> jornadas;

        public enum EClase
        {
            Programacion,
            Laboratorio,
            Legislacion,
            Spd
        }

        public List<Alumno> Alumnos { get; set; }
        public List<Profesor> Profesores { get; set; }
        public List<Jornada> Jornadas { get; set; }
        public Jornada this[int i]
        {
            get
            {
                return this[i];
            }
            set
            {
                this[i] = value;
            }
        }
        public Universidad()
        {
            alumnos = new List<Alumno>();
            profesores = new List<Profesor>();
            jornadas = new List<Jornada>();
        }
    }
}
