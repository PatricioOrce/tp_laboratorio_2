using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Entidades
{
    public enum EGenero
    {
        Masculino, Femenino, Otro
    }
    [XmlInclude(typeof(Alumno))]
    public abstract class Persona
    {
        private string nombre;
        private string apellido;
        private int edad;
        private EGenero genero;

        public Persona()
        {

        }
        public Persona(string nombre, string apellido, int edad, EGenero genero)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.edad = edad;
            this.genero = genero;
        }

        public EGenero Genero
        {
            get { return genero; }
            set { genero = value; }
        }

        public int Edad
        {
            get { return edad; }
            set { edad = value; }
        }

        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }



    }
}
