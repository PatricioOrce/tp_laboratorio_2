using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Analizar<T> where T : class
    {
        /// <summary>
        /// Calcula el porcentaje de una lista respecto a otra.
        /// </summary>
        /// <param name="listaCompleta"></param>
        /// <param name="listaFiltrada"></param>
        /// <returns>Devuelve el porcentaje calculado de ser valido, de lo contrario lanza una excepcion.</returns>
        public static float CalcularPorcentaje(List<T> listaCompleta, List<T> listaFiltrada)
        {
            try
            {
                if(listaCompleta.Count > listaFiltrada.Count && listaFiltrada.Count > 0)
                {
                    float primerValor = listaFiltrada.Count();
                    float segundoValor = listaCompleta.Count();
                    float resultado = (primerValor / segundoValor);
                    resultado *= 100;
                    return resultado;
                }
                return 0;
            }
            catch(Exception)
            {
                throw new Exception("Error al calcular procentaje.");
            }
        }
    }
}
