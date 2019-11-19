using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Entities;
namespace Persistencia
{
    public class WhatsappTexto : IData<string>
    {
        private readonly string path;

        /// <summary>
        /// Asignar valor al path
        /// </summary>
        public WhatsappTexto()
        {
            path = String.Format("{0}\\{1}", (Environment.GetFolderPath(Environment.SpecialFolder.Desktop)), "WhatssappTexto.txt");
        }

        public void Guardar(Emisor emisor)
        {
            StreamWriter st = new StreamWriter(path, true);
            try
            {
                st.WriteLine(emisor.ToString());
            }
            catch (Exception e)
            {
                throw e;
            }
            finally
            {
                st.Close();
            }
        }

        public string Leer()
        {
            StreamReader sr;
            try
            {
                sr = new StreamReader(path, true);
                string lectura;
                lectura = sr.ReadToEnd();
                sr.Close();
                return lectura;
            }
            catch (Exception)
            {
                throw;
            }           
        }
    }
}
