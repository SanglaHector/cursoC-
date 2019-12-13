using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        [ExpectedException(typeof(NoAgregaException))]
        public void TestMethod1()
        {
            Canasta<Fruta> c = new Canasta<Fruta>(2);
            Fruta f1 = new Fruta(1, ReinoVegetal.Gusto.Dulce, ConsoleColor.Black);
            Fruta f2 = new Fruta(1, ReinoVegetal.Gusto.Salado, ConsoleColor.Blue);
            Fruta f3 = new Fruta(1, ReinoVegetal.Gusto.Toxica, ConsoleColor.DarkCyan);
            c += f1;
            c += f2;
            c += f3;
            
        }
    }
}
