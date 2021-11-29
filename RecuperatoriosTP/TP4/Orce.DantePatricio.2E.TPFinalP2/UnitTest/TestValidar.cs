using Entidades;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTest
{
    [TestClass]
    public class TestValidar
    {
        [TestMethod]
        public void Test_ValidarNombre_Valido()
        {
            //Arrange
            string nombre = "Lautaro";

            //Act
            bool test = Validar.IsNombre(nombre);

            //Assert
            Assert.IsTrue(test);
        }
        [TestMethod]
        public void Test_ValidarNombre_Invalido()
        {
            //Arrange
            string nombre = "1234  --12.";

            //Act
            bool test = Validar.IsNombre(nombre);

            //Assert
            Assert.IsFalse(test);
        }
    }
}
