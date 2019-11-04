using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using ClasesInstanciables;
using static ClasesInstanciables.Universidad;

namespace ClasesInstanciables
{
    public class Jornada
    {
        private List<Alumno> alumnos;
        private EClase clase;
        private Profesor instructor;

        public List<Alumno> Alumnos
        {
            get
            {
                return alumnos;
            }
            set
            {
                alumnos = value;
            }
        }
        public EClase Clase
        {
            get
            {
                return clase;
            }
            set
            {
                clase = value;
            }
        }
        public Profesor Instructor
        {
            get
            {
                return instructor;
            }
            set
            {
                instructor = value;
            }
        }
        public Jornada()
        {
            alumnos = new List<Alumno>();
        }
    }
}
