using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace Entidades
{

    public class Planeta<TAstro> : Astro, IAstro where TAstro : Astro
    {
        private int cantAstros;
        private Tipo tipo;
        private List<TAstro> satelites;

        public Planeta(int durOrb, int duraRot, string nmbr)
            : base(durOrb, duraRot, nmbr)
        {
            this.satelites = new List<TAstro>();
        }

        public Planeta(int durOrb, int durRot, string nmbr, int cantAstr, Tipo tipo)
            : this(durOrb, durRot, nmbr)
        {
            this.cantAstros = cantAstr;
            this.tipo = tipo;
        }

        public List<TAstro> Satelites
        {
            get
            {
                return this.satelites;
            }

            set
            {
                this.satelites = value;
            }
        }

        public int CantAstros
        {
            get
            {
                return this.cantAstros;
            }
            set
            {
                this.cantAstros = value;
            }
        }

        public Tipo Tipo
        {
            get
            {
                return this.tipo;
            }
            set
            {
                this.tipo = value;
            }
        }

        public static bool operator +(Planeta<TAstro> planeta, TAstro astro)
        {
            bool retorno = false;
            if(planeta != astro)
            {
                planeta.Satelites.Add(astro);
            }
            return retorno;
        }

        public static bool operator ==(Planeta<TAstro> planeta, TAstro satelite)
        {
            foreach (TAstro astro in planeta.satelites)
            {
                if (astro.Nombre == astro.Nombre)
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Planeta<TAstro> planeta, TAstro astro)
        {
            return !(planeta == astro);
        }

        //public static bool operator ==(Planeta planeta, ...)
        //{
        //    bool retorno = false;

        //    ...

        //    return retorno;
        //}

        //public static bool operator !=(Planeta planeta, ...)
        //{
        //    ....
        //}

        public string Orbitar()
        {
            return $"Termino de orbitar el planeta {this.Nombre}";
        }

        public string Rotar()
        {
            return $"Termino de rotar el planeta {this.Nombre}";
        }

        public override string ToString()
        {
            StringBuilder retorno = new StringBuilder();
            retorno.AppendLine("Planeta");
            retorno.Append(base.Mostrar());
            retorno.AppendLine($"Tipo: {tipo}");
            retorno.AppendLine($"Cantidad de Satelites {cantAstros}");

            foreach (Astro satelite in this.satelites)
            {
                retorno.AppendLine(satelite.ToString());
            }

            return retorno.ToString();
        }

        Thread IAstro.HiloOrbita()
        {
            throw new NotImplementedException();
        }

        Thread IAstro.HiloRotacion()
        {
            throw new NotImplementedException();
        }

        public string Rotacion()
        {
            throw new NotImplementedException();
        }
        public void RunEvenRotar()
        {
            int duracion = this.DuraRotacion;
            while(duracion > 0)
            {
                Thread.Sleep(3000);
                duracion--;
            }
            InvocarEvento(Rotar());
        }
        public void RunEvenOrbitar()
        {
            // Agregar evento de que finalizó la exposición de la patente
            //this.finExposicion(this);
        }
        public void InvocarEvento(string st)
        {
            // implementar llamada a evento
            new AstroDelegate(this.Rotar);
        }
    }
}
