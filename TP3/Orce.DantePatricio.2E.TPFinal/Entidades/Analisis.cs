using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public static class Analisis<T> where T : class
    {
        public static float SacarPorcentaje(List<T> listaCompleta, List<T> listaFiltrada)
        {
            try
            {
                if(listaCompleta.Count > listaFiltrada.Count && listaFiltrada.Count > 0)
                {
                    float resultado = (listaFiltrada.Count / listaCompleta.Count);
                    return resultado * 100;
                }
            }
            catch(Exception)
            {
                throw new Exception("Error al calcular porcentajes.");
            }
            return 0;
        }
    }
}
