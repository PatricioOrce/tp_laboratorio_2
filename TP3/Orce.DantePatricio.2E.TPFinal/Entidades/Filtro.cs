using System;
using System.Collections.Generic;

namespace Entidades
{
    public static class Filtro
    {
        /// <summary>
        /// Filtra una lista de alumnos en relacion al sector recibido por parametro.
        /// </summary>
        /// <param name="listaPersonas"></param>
        /// <param name="sector"></param>
        /// <returns>Devuelve una lista filtrada</returns>
        public static List<Alumno> FilterBy(List<Alumno> listaPersonas, ESector sector)
        {
            if (listaPersonas.Count > 0)
            {
                List<Alumno> listaAux = new List<Alumno>();
                foreach (Alumno item in listaPersonas)
                {
                    if (item.GetType() == typeof(Alumno))
                    {
                        if ((item).Sector == sector)
                        {
                            listaAux.Add(item);
                        }
                    }
                }
                return listaAux;
            }
            else
            {
                throw new EmptyListException("La lista recibida esta vacia.");
            }
           

        }
        /// <summary>
        /// Filtra una lista de alumnos en relacion al turno recibido por parametro.
        /// </summary>
        /// <param name="listaPersonas"></param>
        /// <param name="turno"></param>
        /// <returns>Devuelve una lista filtrada</returns>
        public static List<Alumno> FilterBy(List<Alumno> listaPersonas, ETurno turno)
        {
            if (listaPersonas.Count > 0)
            {
                List<Alumno> listaAux = new List<Alumno>();
                foreach (Alumno item in listaPersonas)
                {
                    if (item.GetType() == typeof(Alumno))
                    {
                        if ((item).Turno == turno)
                        {
                            listaAux.Add(item);
                        }
                    }
                }
                return listaAux;
            }
            else
            {
                throw new EmptyListException("La lista recibida esta vacia.");
            }

        }
        /// <summary>
        /// Filtra una lista de alumnos en relacion a la orientacion recibida por parametro.
        /// </summary>
        /// <param name="listaPersonas"></param>
        /// <param name="orientacion"></param>
        /// <returns>Devuelve una lista filtrada</returns>
        public static List<Alumno> FilterBy(List<Alumno> listaPersonas, EOrientacion orientacion)
        {
            if(listaPersonas.Count > 0)
            {
                List<Alumno> listaAux = new List<Alumno>();
                foreach (Alumno item in listaPersonas)
                {
                    if (item.GetType() == typeof(Alumno))
                    {
                        if ((item).Orientacion == orientacion)
                        {
                            listaAux.Add(item);
                        }
                    }
                }
                return listaAux;
            }
            else
            {
                throw new EmptyListException("La lista recibida esta vacia.");
            }

        }
        /// <summary>
        /// Filtra una lista de alumnos en relacion al genero recibido por parametro.
        /// </summary>
        /// <param name="listaPersonas"></param>
        /// <param name="genero"></param>
        /// <returns>Devuelve una lista filtrada</returns>
        public static List<Alumno> FilterBy(List<Alumno> listaPersonas, EGenero genero)
        {
            if(listaPersonas.Count > 0)
            {
                List<Alumno> listaAux = new List<Alumno>();
                foreach (Alumno item in listaPersonas)
                {
                    if (item.GetType() == typeof(Alumno))
                    {
                        if ((item).Genero == genero)
                        {
                            listaAux.Add(item);
                        }
                    }
                }
                return listaAux;
            }
            else
            {
                throw new EmptyListException("La lista recibida esta vacia.");
            }
            
        }
        /// <summary>
        /// Filtra una lista de alumnos en relacion al genero, sector, turno y orientacion recibidos por parametro.
        /// </summary>
        /// <param name="listaPersonas"></param>
        /// <param name="genero"></param>
        /// <param name="sector"></param>
        /// <param name="turno"></param>
        /// <param name="orientacion"></param>
        /// <returns>Devuelve una lista filtrada en base al genero, sector, turno y orientacion enviados por parametro.</returns>
        public static List<Alumno> FilterBy(List<Alumno> listaPersonas, EGenero genero, ESector sector, ETurno turno, EOrientacion orientacion)
        {
            if(listaPersonas.Count > 0)
            {
                List<Alumno> listaAux = new List<Alumno>();
                foreach (Alumno item in listaPersonas)
                {
                    if (item.GetType() == typeof(Alumno))
                    {
                        if (item.Genero == genero && item.Sector == sector && item.Turno == turno && item.Orientacion == orientacion)
                        {
                            listaAux.Add(item);
                        }
                    }
                }
                return listaAux;
            }
            else
            {
                throw new EmptyListException("La lista recibida esta vacia.");
            }
           
        }
        /// <summary>
        /// Filtra una lista de alumnos en relacion al genero, sector y turno enviados por parametros.
        /// </summary>
        /// <param name="listaPersonas"></param>
        /// <param name="genero"></param>
        /// <param name="sector"></param>
        /// <param name="turno"></param>
        /// <returns>Devuelve una lista filtrada en base al genero, sector y turno enviados por parametros.</returns>
        public static List<Alumno> FilterBy(List<Alumno> listaPersonas, EGenero genero, ESector sector, ETurno turno)
        {
            if(listaPersonas.Count > 0)
            {
                List<Alumno> listaAux = new List<Alumno>();
                foreach (Alumno item in listaPersonas)
                {
                    if (item.GetType() == typeof(Alumno))
                    {
                        if (item.Genero == genero && item.Sector == sector && item.Turno == turno)
                        {
                            listaAux.Add(item);
                        }
                    }
                }
                return listaAux;
            }
            else
            {
                throw new EmptyListException("La lista recibida esta vacia.");
            }
           
        }
        /// <summary>
        /// Filtra una lista de alumnos en relacion al genero y sector recibidos por parametro.
        /// </summary>
        /// <param name="listaPersonas"></param>
        /// <param name="genero"></param>
        /// <param name="sector"></param>
        /// <returns>Devuelve una lista filtrada</returns>
        public static List<Alumno> FilterBy(List<Alumno> listaPersonas, EGenero genero, ESector sector)
        {
            List<Alumno> listaAux = new List<Alumno>();
            foreach (Alumno item in listaPersonas)
            {
                if (item.GetType() == typeof(Alumno))
                {
                    if (item.Genero == genero && item.Sector == sector)
                    {
                        listaAux.Add(item);
                    }
                }
            }
            return listaAux;
        }
        /// <summary>
        /// Filtra una lista de alumnos por la edad recibida por parametro.
        /// </summary>
        /// <param name="listaPersonas"></param>
        /// <param name="edad"></param>
        /// <returns>Devuelve una lista filtrada por la edad enviada</returns>
        public static List<Alumno> FilterBy(List<Alumno> listaPersonas, int edad)
        {
            if (listaPersonas.Count > 0)
            {
                List<Alumno> listaAux = new List<Alumno>();
                foreach (Alumno item in listaPersonas)
                {
                    if (item.GetType() == typeof(Alumno))
                    {
                        if (item.Edad == edad)
                        {
                            listaAux.Add(item);
                        }
                    }
                }
                return listaAux;
            }
            else
            {
                throw new EmptyListException("La lista recibida esta vacia.");
            }
           
        }
        /// <summary>
        /// Filtra una lista de alumnos por el rango de edad recibido por parametro.
        /// </summary>
        /// <param name="listaPersonas"></param>
        /// <param name="edad1">Edad base</param>
        /// <param name="edad2">Edad limite</param>
        /// <returns>Devuelve una lista filtrada por el rango de edad enviado.</returns>
        public static List<Alumno> FilterBy(List<Alumno> listaPersonas, int edad1, int edad2)
        {
            if(listaPersonas.Count > 0)
            {
                List<Alumno> listaAux = new List<Alumno>();
                foreach (Alumno item in listaPersonas)
                {
                    if (item.GetType() == typeof(Alumno))
                    {
                        if (item.Edad >= edad1 && item.Edad <= edad2)
                        {
                            listaAux.Add(item);
                        }
                    }
                }
                return listaAux;
            }
            else
            {
                throw new EmptyListException("La lista recibida esta vacia.");
            }
          
        }
        /// <summary>
        /// Filtra una lista de alumnos por la edad recibida por parametro, se indica si 
        /// la edad debe ser menor o mayor a ese numero.
        /// </summary>
        /// <param name="listaPersonas"></param>
        /// <param name="edad"></param>
        /// <param name="upOrDown">Al ser true se filtra por mayores a esa edad y false a menores.</param>
        /// <returns>Devuelve una lista filtrada por la edad enviada</returns>
        public static List<Alumno> FilterBy(List<Alumno> listaPersonas, int edad, bool upOrDown)
        {
            if(listaPersonas.Count > 0)
            {
                List<Alumno> listaAux = new List<Alumno>();
                foreach (Alumno item in listaPersonas)
                {
                    if (item.GetType() == typeof(Alumno))
                    {
                        if (upOrDown)
                        {
                            if ((item).Edad >= edad)
                            {
                                listaAux.Add(item);
                            }
                        }
                        else
                        {
                            if ((item).Edad <= edad)
                            {
                                listaAux.Add(item);
                            }
                        }

                    }
                }
                return listaAux;
            }
            else
            {
                throw new EmptyListException("La lista recibida esta vacia.");
            }
           
        }

    }
}
