using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    static class Extension
    {
        /// <summary>
        /// Valida si la cadena ingresada cumple con los requisitos para ser un nombre.
        /// </summary>
        /// <param name="nombreIngresado"></param>
        /// <returns>Devuelve True en caso de serlo, de lo contrario devuelve false.</returns>
        public static bool IsName(this string nombreIngresado)
        {
            string nombre = nombreIngresado.Trim();
            int espacios = 0;
            int barras = 0;
            if (nombre.Length > 1 && nombre.Length < 41)
            {
                foreach (char character in nombre)
                {
                    if ((character >= 'a' && character <= 'z') || (character >= 'A' && character <= 'Z') || (character == ' ' || character == '-'))
                    {
                        if (character == ' ')
                        {
                            espacios += 1;
                        }
                        if (character == '-')
                        {
                            barras += 1;
                        }
                    }
                    else
                    {
                        return false;
                    }
                }
                if (espacios < 2 && barras < 2)
                {
                    return true;
                }
            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
