using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace Entidades
{
    public enum ESector
    {
        Primario, Secundario
    }
    public enum ETurno
    {
        Maniana, Tarde, Noche
    }
    public enum EOrientacion
    {
        Sociales, Naturales, Economia, Tecnica
    }
    public class Alumno : Persona
    {
        private ESector sector;
        private ETurno turno;
        private EOrientacion orientacion;

        public Alumno()
        {

        }

        public Alumno(string nombre, string apellido, int edad, EGenero genero, ESector sector, ETurno turno, EOrientacion orientacion) : base(nombre, apellido, edad, genero)
        {
            this.sector = sector;
            this.turno = turno;
            this.orientacion = orientacion;
        }

        public ESector Sector
        {
            get
            {
                return this.sector;
            }
            set
            {
                this.sector = value;
            }
        }

        public ETurno Turno
        {
            get
            {
                return this.turno;
            }
            set
            {
                this.turno = value;
            }
        }

        public EOrientacion Orientacion
        {
            get
            {
                return this.orientacion;
            }
            set
            {
                this.orientacion = value;
            }
        }

        public static bool operator ==(Alumno a1, Alumno a2)
        {
            if (a1 is not null && a2 is not null)
            {
                if ((a1.Nombre == a2.Nombre) && (a1.Apellido == a2.Apellido))
                {
                    return true;
                }
            }
            return false;
        }

        public static bool operator !=(Alumno a1, Alumno a2)
        {
            if (a1 is not null && a2 is not null)
            {
                if ((a1.Nombre != a2.Nombre) || (a1.Apellido != a2.Apellido))
                {
                    return true;
                }
            }
            return false;
        }

        public static List<Alumno> operator +(List<Alumno> lista, Alumno alumno)
        {
            if (lista is not null && alumno is not null)
            {
                foreach (Alumno item in lista)
                {
                    if (item != alumno)
                    {
                        lista.Add(alumno);
                    }
                }
            }
            return lista;
        }

    }
}
