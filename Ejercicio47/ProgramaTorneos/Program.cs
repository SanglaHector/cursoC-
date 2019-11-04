using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades47;
namespace ProgramaTorneos
{
    public class Program
    {
        static void Main(string[] args)
        {
            Torneo<EquipoFutbol> torneoFutbol = new Torneo<EquipoFutbol>("Superliga");
            Torneo<EquipoBasket> torneoBasket = new Torneo<EquipoBasket>("Confederaciones");
            DateTime dato = new DateTime(1852, 10, 18);
            EquipoFutbol riverPlate = new EquipoFutbol("River plate", dato);
            dato = new DateTime(1850, 9, 6);
            EquipoFutbol bocaJuniors = new EquipoFutbol("Boca Juniors", dato);
            dato = new DateTime(1870, 1, 2);
            EquipoFutbol sanLorenzo = new EquipoFutbol("San Lorenzo" , dato);
            dato = new DateTime(1930, 7, 5);
            EquipoBasket lomas = new EquipoBasket("Lomas", dato);
            dato = new DateTime(1950, 11, 25);
            EquipoBasket independienteBurzaco = new EquipoBasket("Independiente de Burzaco", dato);
            dato = new DateTime(1970, 8, 29);
            EquipoBasket losAlamos = new EquipoBasket("Los Alamos" , dato);

            _ = riverPlate + torneoFutbol;
            _ = riverPlate + torneoFutbol;
            _ = bocaJuniors + torneoFutbol;
            _ = sanLorenzo + torneoFutbol;

            Console.WriteLine(torneoFutbol.Mostrar());
            Console.ReadKey();
            Console.WriteLine(torneoFutbol.JugarPartido(riverPlate, bocaJuniors));
            Console.ReadKey();
            Console.WriteLine(torneoFutbol.JugarPartido(sanLorenzo, riverPlate));
            Console.ReadKey();
            Console.WriteLine(torneoFutbol.JugarPartido(bocaJuniors, sanLorenzo));
            Console.ReadKey();

        }
    }
}
