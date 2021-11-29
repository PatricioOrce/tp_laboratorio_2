using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace UnitTest
{
    [TestClass]
    public class TestFiltros
    {
        [TestMethod]
        public void Test_FiltradoPorSector_Valido()
        {
            //Arrange
            List<Alumno> listaFiltrada = new List<Alumno>();
            List<Alumno> listaAux = new List<Alumno>()
            {
                new Alumno("Patricio","Orce",20,EGenero.Masculino,ESector.Secundario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("Florencia","Prados",19,EGenero.Femenino,ESector.Primario, ETurno.Maniana,EOrientacion.Economia),
                new Alumno("Facundo","Careri",22,EGenero.Masculino,ESector.Secundario, ETurno.Tarde,EOrientacion.Economia),
                new Alumno("Julian","Scarlato",21,EGenero.Masculino,ESector.Primario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Agostina","Orce",26,EGenero.Femenino,ESector.Secundario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Pedro","Ramirez",12,EGenero.Otro,ESector.Primario, ETurno.Maniana,EOrientacion.Naturales),
            };
            ESector sector = ESector.Primario;

            //Act
            listaFiltrada = Filtro.FilterBy(listaAux, sector);

            //Assert
            foreach (Alumno item in listaFiltrada)
            {
                Assert.IsTrue(item.Sector == ESector.Primario);
            }

        }
        [TestMethod]
        public void Test_FiltradoPorSector_Invalido()
        {
            //Arrange
            List<Alumno> listaFiltrada = new List<Alumno>();
            List<Alumno> listaAux = new List<Alumno>()
            {
                new Alumno("Patricio","Orce",20,EGenero.Masculino,ESector.Secundario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("Florencia","Prados",19,EGenero.Femenino,ESector.Primario, ETurno.Maniana,EOrientacion.Economia),
                new Alumno("Facundo","Careri",22,EGenero.Masculino,ESector.Secundario, ETurno.Tarde,EOrientacion.Economia),
                new Alumno("Julian","Scarlato",21,EGenero.Masculino,ESector.Primario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Agostina","Orce",26,EGenero.Femenino,ESector.Secundario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Pedro","Ramirez",12,EGenero.Otro,ESector.Primario, ETurno.Maniana,EOrientacion.Naturales),
            };
            ESector sector = ESector.Secundario;

            //Act
            listaFiltrada = Filtro.FilterBy(listaAux, sector);

            //Assert
            foreach (Alumno item in listaFiltrada)
            {
                Assert.IsFalse(item.Sector == ESector.Primario);
            }

        }
        [TestMethod]
        public void Test_FiltradoPorGenero_Valido()
        {
            //Arrange
            List<Alumno> listaFiltrada = new List<Alumno>();
            List<Alumno> listaAux = new List<Alumno>()
            {
                new Alumno("Patricio","Orce",20,EGenero.Masculino,ESector.Secundario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("Florencia","Prados",19,EGenero.Femenino,ESector.Primario, ETurno.Maniana,EOrientacion.Economia),
                new Alumno("Facundo","Careri",22,EGenero.Masculino,ESector.Secundario, ETurno.Tarde,EOrientacion.Economia),
                new Alumno("Julian","Scarlato",21,EGenero.Masculino,ESector.Primario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Agostina","Orce",26,EGenero.Femenino,ESector.Secundario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Pedro","Ramirez",12,EGenero.Otro,ESector.Primario, ETurno.Maniana,EOrientacion.Naturales),
            };
            EGenero genero = EGenero.Masculino;

            //Act
            listaFiltrada = Filtro.FilterBy(listaAux, genero);

            //Assert
            foreach (Alumno item in listaFiltrada)
            {
                Assert.IsTrue(item.Genero == EGenero.Masculino);
            }

        }
        [TestMethod]
        public void Test_FiltradoPorGenero_Invalido()
        {
            //Arrange
            List<Alumno> listaFiltrada = new List<Alumno>();
            List<Alumno> listaAux = new List<Alumno>()
            {
                new Alumno("Patricio","Orce",20,EGenero.Masculino,ESector.Secundario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("Florencia","Prados",19,EGenero.Femenino,ESector.Primario, ETurno.Maniana,EOrientacion.Economia),
                new Alumno("Facundo","Careri",22,EGenero.Masculino,ESector.Secundario, ETurno.Tarde,EOrientacion.Economia),
                new Alumno("Julian","Scarlato",21,EGenero.Masculino,ESector.Primario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Agostina","Orce",26,EGenero.Femenino,ESector.Secundario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Pedro","Ramirez",12,EGenero.Otro,ESector.Primario, ETurno.Maniana,EOrientacion.Naturales),
            };
            EGenero genero = EGenero.Masculino;

            //Act
            listaFiltrada = Filtro.FilterBy(listaAux, genero);

            //Assert
            foreach (Alumno item in listaFiltrada)
            {
                Assert.IsFalse(item.Genero == EGenero.Femenino);
            }


        }
        [TestMethod]
        public void Test_FiltradoPorTurno_Valido()
        {
            //Arrange
            List<Alumno> listaFiltrada = new List<Alumno>();
            List<Alumno> listaAux = new List<Alumno>()
            {
                new Alumno("Patricio","Orce",20,EGenero.Masculino,ESector.Secundario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("Florencia","Prados",19,EGenero.Femenino,ESector.Primario, ETurno.Maniana,EOrientacion.Economia),
                new Alumno("Facundo","Careri",22,EGenero.Masculino,ESector.Secundario, ETurno.Tarde,EOrientacion.Economia),
                new Alumno("Julian","Scarlato",21,EGenero.Masculino,ESector.Primario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Agostina","Orce",26,EGenero.Femenino,ESector.Secundario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Pedro","Ramirez",12,EGenero.Otro,ESector.Primario, ETurno.Maniana,EOrientacion.Naturales),
            };
            ETurno turno = ETurno.Maniana;

            //Act
            listaFiltrada = Filtro.FilterBy(listaAux, turno);

            //Assert
            foreach (Alumno item in listaFiltrada)
            {
                Assert.IsTrue(item.Turno == ETurno.Maniana);
            }

        }
        [TestMethod]
        public void Test_FiltradoPorTurno_Invalido()
        {
            //Arrange
            List<Alumno> listaFiltrada = new List<Alumno>();
            List<Alumno> listaAux = new List<Alumno>()
            {
                new Alumno("Patricio","Orce",20,EGenero.Masculino,ESector.Secundario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("Florencia","Prados",19,EGenero.Femenino,ESector.Primario, ETurno.Maniana,EOrientacion.Economia),
                new Alumno("Facundo","Careri",22,EGenero.Masculino,ESector.Secundario, ETurno.Tarde,EOrientacion.Economia),
                new Alumno("Julian","Scarlato",21,EGenero.Masculino,ESector.Primario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Agostina","Orce",26,EGenero.Femenino,ESector.Secundario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Pedro","Ramirez",12,EGenero.Otro,ESector.Primario, ETurno.Maniana,EOrientacion.Naturales),
            };
            ETurno turno = ETurno.Maniana;

            //Act
            listaFiltrada = Filtro.FilterBy(listaAux, turno);

            //Assert
            foreach (Alumno item in listaFiltrada)
            {
                Assert.IsFalse(item.Turno == ETurno.Tarde || item.Turno == ETurno.Noche);
            }
        }
        [TestMethod]
        public void Test_FiltradoPorOrientacion_Valido()
        {
            //Arrange
            List<Alumno> listaFiltrada = new List<Alumno>();
            List<Alumno> listaAux = new List<Alumno>()
            {
                new Alumno("Patricio","Orce",20,EGenero.Masculino,ESector.Secundario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("Florencia","Prados",19,EGenero.Femenino,ESector.Primario, ETurno.Maniana,EOrientacion.Economia),
                new Alumno("Facundo","Careri",22,EGenero.Masculino,ESector.Secundario, ETurno.Tarde,EOrientacion.Economia),
                new Alumno("Julian","Scarlato",21,EGenero.Masculino,ESector.Primario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Agostina","Orce",26,EGenero.Femenino,ESector.Secundario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Pedro","Ramirez",12,EGenero.Otro,ESector.Primario, ETurno.Maniana,EOrientacion.Naturales),
            };
            EOrientacion orientacion = EOrientacion.Naturales;

            //Act
            listaFiltrada = Filtro.FilterBy(listaAux, orientacion);

            //Assert
            foreach (Alumno item in listaFiltrada)
            {
                Assert.IsTrue(item.Orientacion == EOrientacion.Naturales);
            }

        }
        [TestMethod]
        public void Test_FiltradoPorOrientacion_Invalido()
        {
            //Arrange
            List<Alumno> listaFiltrada = new List<Alumno>();
            List<Alumno> listaAux = new List<Alumno>()
            {
                new Alumno("Patricio","Orce",20,EGenero.Masculino,ESector.Secundario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("Florencia","Prados",19,EGenero.Femenino,ESector.Primario, ETurno.Maniana,EOrientacion.Economia),
                new Alumno("Facundo","Careri",22,EGenero.Masculino,ESector.Secundario, ETurno.Tarde,EOrientacion.Economia),
                new Alumno("Julian","Scarlato",21,EGenero.Masculino,ESector.Primario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Agostina","Orce",26,EGenero.Femenino,ESector.Secundario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Pedro","Ramirez",12,EGenero.Otro,ESector.Primario, ETurno.Maniana,EOrientacion.Naturales),
            };
            EOrientacion orientacion = EOrientacion.Naturales;

            //Act
            listaFiltrada = Filtro.FilterBy(listaAux, orientacion);

            //Assert
            foreach (Alumno item in listaFiltrada)
            {
                Assert.IsFalse(item.Orientacion == EOrientacion.Economia || item.Orientacion == EOrientacion.Sociales || item.Orientacion == EOrientacion.Tecnica);
            }
        }
        [TestMethod]
        public void Test_FiltradoPorEdad_Valido()
        {
            //Arrange
            List<Alumno> listaFiltrada = new List<Alumno>();
            List<Alumno> listaAux = new List<Alumno>()
            {
                new Alumno("Patricio","Orce",22,EGenero.Masculino,ESector.Secundario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("Florencia","Prados",19,EGenero.Femenino,ESector.Primario, ETurno.Maniana,EOrientacion.Economia),
                new Alumno("Facundo","Careri",22,EGenero.Masculino,ESector.Secundario, ETurno.Tarde,EOrientacion.Economia),
                new Alumno("Julian","Scarlato",22,EGenero.Masculino,ESector.Primario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Agostina","Orce",26,EGenero.Femenino,ESector.Secundario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Pedro","Ramirez",12,EGenero.Otro,ESector.Primario, ETurno.Maniana,EOrientacion.Naturales),
            };
            int edad = 22;

            //Act
            listaFiltrada = Filtro.FilterBy(listaAux, edad);

            //Assert
            foreach (Alumno item in listaFiltrada)
            {
                Assert.IsTrue(item.Edad == edad);
            }
        }
        [TestMethod]
        public void Test_FiltradoPorEdad_Invalido()
        {
            //Arrange
            List<Alumno> listaFiltrada = new List<Alumno>();
            List<Alumno> listaAux = new List<Alumno>()
            {
                new Alumno("Patricio","Orce",22,EGenero.Masculino,ESector.Secundario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("Florencia","Prados",19,EGenero.Femenino,ESector.Primario, ETurno.Maniana,EOrientacion.Economia),
                new Alumno("Facundo","Careri",22,EGenero.Masculino,ESector.Secundario, ETurno.Tarde,EOrientacion.Economia),
                new Alumno("Julian","Scarlato",22,EGenero.Masculino,ESector.Primario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Agostina","Orce",26,EGenero.Femenino,ESector.Secundario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Pedro","Ramirez",12,EGenero.Otro,ESector.Primario, ETurno.Maniana,EOrientacion.Naturales),
            };
            int edad = 22;
            int edadInvalida = 21;
            //Act
            listaFiltrada = Filtro.FilterBy(listaAux, edad);

            //Assert
            foreach (Alumno item in listaFiltrada)
            {
                Assert.IsFalse(item.Edad == edadInvalida);
            }
        }
        [TestMethod]
        public void Test_FiltradoPorRangoDeEdad_Valido()
        {
            //Arrange
            List<Alumno> listaFiltrada = new List<Alumno>();
            List<Alumno> listaAux = new List<Alumno>()
            {
                new Alumno("Patricio","Orce",22,EGenero.Masculino,ESector.Secundario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("Florencia","Prados",19,EGenero.Femenino,ESector.Primario, ETurno.Maniana,EOrientacion.Economia),
                new Alumno("Facundo","Careri",22,EGenero.Masculino,ESector.Secundario, ETurno.Tarde,EOrientacion.Economia),
                new Alumno("Julian","Scarlato",22,EGenero.Masculino,ESector.Primario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Agostina","Orce",26,EGenero.Femenino,ESector.Secundario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Pedro","Ramirez",12,EGenero.Otro,ESector.Primario, ETurno.Maniana,EOrientacion.Naturales),
            };
            int edad1 = 22;
            int edad2 = 26;

            //Act
            listaFiltrada = Filtro.FilterBy(listaAux, edad1,edad2);

            //Assert
            foreach (Alumno item in listaFiltrada)
            {
                Assert.IsTrue(item.Edad >=edad1 && item.Edad<=edad2);
            }
        }
        [TestMethod]
        public void Test_FiltradoPorRangoDeEdad_Invalido()
        {
            //Arrange
            List<Alumno> listaFiltrada = new List<Alumno>();
            List<Alumno> listaAux = new List<Alumno>()
            {
                new Alumno("Patricio","Orce",22,EGenero.Masculino,ESector.Secundario, ETurno.Maniana,EOrientacion.Sociales),
                new Alumno("Florencia","Prados",19,EGenero.Femenino,ESector.Primario, ETurno.Maniana,EOrientacion.Economia),
                new Alumno("Facundo","Careri",22,EGenero.Masculino,ESector.Secundario, ETurno.Tarde,EOrientacion.Economia),
                new Alumno("Julian","Scarlato",22,EGenero.Masculino,ESector.Primario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Agostina","Orce",26,EGenero.Femenino,ESector.Secundario, ETurno.Noche,EOrientacion.Tecnica),
                new Alumno("Pedro","Ramirez",12,EGenero.Otro,ESector.Primario, ETurno.Maniana,EOrientacion.Naturales),
            };
            int edad1 = 22;
            int edad2 = 26;

            //Act
            listaFiltrada = Filtro.FilterBy(listaAux, edad1, edad2);

            //Assert
            foreach (Alumno item in listaFiltrada)
            {
                Assert.IsFalse(item.Edad < edad1 && item.Edad > edad2);
            }
        }

    }
}
