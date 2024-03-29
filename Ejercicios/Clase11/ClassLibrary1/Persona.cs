using System;

namespace Entidades
{
    public abstract class Persona
    {
        public double Cuil { get; set; }
        public string Nombre { get; set; }
        public Persona(string nombre, double cuil)
        {
            this.Cuil = cuil;
            this.Nombre = nombre;
        }

        public virtual string Mostrar()
        {
            return "nom:"+  this.Nombre + " cuil:" + this.Cuil;
        }

    public bool validarCuil(double cuil)
    {
      char[] ponderador = { '5', '4', '3', '2', '7', '6', '5', '4', '3', '2' };
      int i;
      double suma = 0;
      char[] numero = cuil.ToString("00000000000").ToCharArray();
      for (i = 0; i < 10; i++)
      {
        suma += (int.Parse(ponderador[i].ToString()) * int.Parse(numero[i].ToString()));
      }

      suma = suma % 11;

      suma = suma == 10 ? 0 : suma == 11 ? 1 : suma;

      suma = 11 - suma;

      return suma == int.Parse(numero[10].ToString());

    }
  }
}
