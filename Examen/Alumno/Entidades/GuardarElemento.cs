using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Entidades
{
    public static class GuardarElemento
    {
        public static string MostrarElemento(this Fruta elemento)
        {
            try
            {
                StringBuilder st = new StringBuilder();
                st.Append(Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + "Fruta.txt");
                string path = st.ToString();
                StreamWriter writer = new StreamWriter(path);
                writer.Write(elemento.ToString());
                writer.Close();
            }
            catch (Exception ex)
            {
                throw new Exception("Problemas para escribir el archivo.");
            }
            return elemento.MostrarDatos();
        }
        
    }
}
