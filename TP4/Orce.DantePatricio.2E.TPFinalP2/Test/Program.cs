using Entidades;
using System;
using System.Collections.Generic;
using System.IO;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            string pathXml = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProgramTest.xml");
            string pathJson = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProgramTest.json");
            string pathTxt = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "ProgramTest.txt");
            Serializer<List<Alumno>> listaJson = new Serializer<List<Alumno>>(ETipo.JSON);
            Serializer<List<Alumno>> listaXml = new Serializer<List<Alumno>>(ETipo.XML);
            List<Alumno> listaAuxiliar = new List<Alumno>();
            List<Alumno> listaAlumnos = new List<Alumno>()
            {
                new Alumno("PersonaLeida","ConExito",20,EGenero.Masculino,ESector.Secundario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("GraciasPor","Testear",19,EGenero.Femenino,ESector.Secundario, ETurno.Maniana,EOrientacion.Economia),
            };
            ArchivoText archivoTexto = new ArchivoText();
            Console.WriteLine("=======================Bienvenidos al testeo del program!=================================");

            listaJson.Escribir(listaAlumnos,pathJson);
            listaXml.Escribir(listaAlumnos, pathXml);

            Console.WriteLine("Datos escritos en archivos XML y JSON.");
            Console.WriteLine("Como pueden observar los datos ya fueron escritos en ambos archivos, ahora procederemos a leerlos!");
            Console.WriteLine("Lecura de datos en Json.....................");
            Console.WriteLine("Pulse para continuar.\n\n");
            Console.ReadKey();

            listaAuxiliar = listaJson.Leer(pathJson);
            foreach (Alumno item in listaAuxiliar)
            {
                Console.WriteLine($"{item.Nombre}, {item.Apellido}");
            }

            Console.WriteLine("Lecura de datos en Xml.....................");
            Console.WriteLine("Pulse para continuar.\n\n");
            Console.ReadKey();

            listaAuxiliar = listaXml.Leer(pathXml);
            foreach (Alumno item in listaAuxiliar)
            {
                Console.WriteLine($"{item.Nombre}, {item.Apellido}");
            }

            Console.WriteLine("Ahora procedemos a la escritura de un archivo txt.");
            Console.WriteLine("Escritura de datos en txt...................");
            Console.WriteLine("Pulse para continuar.\n\n");
            Console.ReadKey();

            archivoTexto.Escribir("Todo salio perfectamente bien.",pathTxt);

            
            Console.WriteLine("Lectura de datos en txt..................");
            Console.WriteLine("Pulse para continuar.\n\n");
            Console.ReadKey();
            Console.WriteLine(archivoTexto.Leer(pathTxt));


           
          

        }
    }
}
