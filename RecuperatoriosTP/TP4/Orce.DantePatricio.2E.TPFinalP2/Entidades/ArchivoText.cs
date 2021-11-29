using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class ArchivoText : IArchivo<string>
    {
        /// <summary>
        /// Escribe un archivo de texto en una ruta indicada con la informacion que le enviemos por parametro.
        /// </summary>
        /// <param name="dato"></param>
        /// <param name="path"></param>
        public void Escribir(string dato, string path)
        {
            try
            {
                using (StreamWriter sw = new StreamWriter(path))
                {
                    sw.Write(dato);
                }
            }
            catch (Exception)
            {
                throw new Exception("Error al escribir el archivo.");
            }
        }
        /// <summary>
        /// Lee un archivo de texto en la ruta indicada por parametro.
        /// </summary>
        /// <param name="path"></param>
        /// <returns>Devuelve un string con el texto recuperado.</returns>
        public string Leer(string path)
        {
            string aux = string.Empty;
            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        aux += $"{sr.ReadLine()}";
                    }
                }
            }
            catch (Exception)
            {
                throw new Exception("Error al leer el archivo");
            }
            return aux;
        }
    }
}
